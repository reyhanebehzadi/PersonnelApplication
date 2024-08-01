using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.PersonnlsApplication.UI.DialogForms;
using Microsoft.Reporting.WinForms;

namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    public partial class GetOvertimeLicenseReportForm : BasePersianForm
    {
        public GetOvertimeLicenseReportForm()
        {
            InitializeComponent();
        }
        public Personnel personnel;
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        private void GetOvertimeLicenseReportForm_Load(object sender, EventArgs e)
        {

            var lst = new List<Department> { new Department { Code = "-1", Name = "همه واحد ها" } };
            lst.AddRange(
                db.Departments.Join(db.DepartmentVersions, d => d.DepartmentVersionID, dv => dv.ID,
                    (d, dv) => new { d, dv }).Where(x => x.dv.IsActive.Value && !x.d.Code.Contains("-")).Select(x => x.d).ToList());
            departmentBindingSource.DataSource = lst;

        }

        private void selectPersonButton_Click(object sender, EventArgs e)
        {
            PersonnelListForm personnelListForm = new PersonnelListForm(db) { IsActive = true };
            if (personnelListForm.ShowDialog() == DialogResult.OK)
            {
                personnel = new Personnel();
                if(personnelListForm.Personnel.Id > 0)
                    personnel = personnelListForm.Personnel;
                this.personelNumberTextBox.Text = personnelListForm.Personnel.PersonnelNumber;
                this.fullNameTextBox.Text = string.Format("{0} {1}", personnelListForm.Personnel.FirstName, personnelListForm.Personnel.LastName);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (DatePicker.SelectedDateTime == null || endDatePicker.SelectedDateTime == null)
            {
                Helper.ShowMessage("بازه زمانی را مشخص نمایید");
                return;
            }

            var department = departmentComboBox.SelectedItem as Department;

            ReportParameter personnel = new ReportParameter("Personnel", string.Format("{0} {1}", this.personnel != null ? this.personnel.FirstName:"", this.personnel != null ? this.personnel.LastName:""));
            ReportParameter from = new ReportParameter("From", Helper.GetPersianDate(DatePicker.SelectedDateTime.GetValueOrDefault()));
            ReportParameter to = new ReportParameter("To", Helper.GetPersianDate(endDatePicker.SelectedDateTime.GetValueOrDefault()));
            reportViewer1.LocalReport.SetParameters(new[] { personnel, from, to });


            if (this.personnel != null)
            {
                GetOvertimeLicenseReportResultBindingSource.DataSource = null;
                GetOvertimeLicenseReportResultBindingSource.DataSource = db.GetOvertimeLicenseReport(DatePicker.SelectedDateTime.Value.Date, endDatePicker.SelectedDateTime.Value.Date, this.personnel.Id, User.FiscalYearID,null);
               
            }
            

            else if (department != null && department.Code != "-1")

            {
                var chDepartments = departmentComboboxChilds.SelectedItem as SelectAllChildDepartmentsResult;
                if (chDepartments != null && chDepartments.Code == "-1")
                {
                    GetOvertimeLicenseReportResultBindingSource.DataSource=null;
                    GetOvertimeLicenseReportResultBindingSource.DataSource = db.GetOvertimeLicenseReport(DatePicker.SelectedDateTime.Value.Date, endDatePicker.SelectedDateTime.Value.Date, null, User.FiscalYearID,null);
                }
                else if (chDepartments != null)
                {
                    GetOvertimeLicenseReportResultBindingSource.DataSource = null;
                    GetOvertimeLicenseReportResultBindingSource.DataSource = db.GetOvertimeLicenseReport(DatePicker.SelectedDateTime.Value.Date, endDatePicker.SelectedDateTime.Value.Date, null, User.FiscalYearID, chDepartments.OriginalDepartmentID);
                }

               
            }

          else  if (this.personnel == null)
            {
                GetOvertimeLicenseReportResultBindingSource.Clear();
                GetOvertimeLicenseReportResultBindingSource.DataSource = db.GetOvertimeLicenseReport(DatePicker.SelectedDateTime.Value.Date, endDatePicker.SelectedDateTime.Value.Date, null, User.FiscalYearID,null);
                
            }

            this.reportViewer1.RefreshReport();
        }

        private void departmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentDepartmentSelected = (Department)departmentComboBox.SelectedItem;
            if (currentDepartmentSelected == null) return;
            var lst = new List<SelectAllChildDepartmentsResult> { new SelectAllChildDepartmentsResult { Code = "-1", Name = "همه بخش ها" } };
            lst.AddRange(db.SelectAllChildDepartments(currentDepartmentSelected.Id).Join(db.DepartmentVersions, d => d.DepartmentVersionID, dv => dv.ID,
                (d, dv) => new { d, dv })
                .Where(
                    x =>
                       x.dv.IsActive.GetValueOrDefault() &&
                        x.d.OriginalDepartmentID != currentDepartmentSelected.OriginalDepartmentID)
                .Select(x => x.d)
                .ToList());
            childrenOfDepartmentbindingSource.DataSource = lst;
        }
    }
}
