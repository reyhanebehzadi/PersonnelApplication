using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Microsoft.Reporting.WinForms;
using Jamsaz.PersonnlsApplication.BusinessObjects.Definitions;

namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    public partial class PersonnelReportForm : BasePersianForm
    {
        public PersonnelReportForm()
        {
            InitializeComponent();
        }
        int? setadi;
        int? tolid;
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        private List<GetPersonnelReportResult> result = new List<GetPersonnelReportResult>();
        private void PersonnelReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                var lst = new List<Department> { new Department { Code = "-1", Name = "همه واحد ها" } };
                lst.AddRange(
                    db.Departments.Join(db.DepartmentVersions, d => d.DepartmentVersionID, dv => dv.ID,
                        (d, dv) => new { d, dv }).Where(x => x.dv.IsActive.Value && !x.d.Code.Contains("-")).Select(x => x.d).ToList());
                departmentBindingSource.DataSource = lst;


                responsibilityBindingSource.DataSource = db.Responsibilities.ToList();
                universityDegreeBindingSource.DataSource = db.UniversityDegrees.ToList();
                majorBindingSource.DataSource = db.Majors.ToList();
                getUnitsHaveStaffResultBindingSource.DataSource = db.GetUnitsHaveStaff();


                Refresh();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }



        }

        private void showButton_Click(object sender, EventArgs e)
        {

            int? universityid;
            int? majorid;
            string occupation;
            int? departmentid;
            string university = string.Empty;
            string unitName = string.Empty;
            string majorName = string.Empty;
            int? workgroupid;
            string workgrouptitle = string.Empty;


            if (occupationCmboBox.SelectedItem == null)

                occupation = null;
            else
                occupation = ((Responsibility)occupationCmboBox.SelectedItem).Title;


            if (universityComboBox.SelectedItem == null)
            {
                universityid = null;
                university = "";
            }

            else
            {
                universityid = ((UniversityDegree)universityComboBox.SelectedItem).Id;
                university = ((UniversityDegree)universityComboBox.SelectedItem).Name;
            }



            if (majorComboBox.SelectedItem == null)
            {
                majorid = null;
                majorName = "";
            }

            else
            {
                majorid = ((Major)majorComboBox.SelectedItem).Id;
                majorName = ((Major)majorComboBox.SelectedItem).Name;
            }


            if (setadicheckBox.Checked == true && tolidicheckBox.Checked == false)
            {
                setadi = 1;
                tolid = null;
            }
            else
           if (tolidicheckBox.Checked == true && setadicheckBox.Checked == false)
            {
                tolid = 2;
                setadi = null;
            }
            else
           if (tolidicheckBox.Checked == true && setadicheckBox.Checked == true)
            {
                setadi = 1;
                tolid = 2;
            }
            else
            {
                setadi = null;
                tolid = null;
            }

          
           


            var department = departmentComboBox.SelectedItem as Department;
            if (department != null && department.Code != "-1")
            {
               
                var chDepartments = departmentComboboxChilds.SelectedItem as SelectAllChildDepartmentsResult;
                if (chDepartments != null && chDepartments.Code == "-1")
                {

                   result = db.GetPersonnelReport(occupation, universityid, majorid, department.Id, tolid, setadi).ToList();
                }
                else if (chDepartments != null)
                {
                    result = db.GetPersonnelReport(occupation, universityid, majorid, department.Id, tolid, setadi).Where(c=>c.DepartmentChildOrginalId== chDepartments.OriginalDepartmentID).ToList();

                }
            }
            else
                result= db.GetPersonnelReport(occupation, universityid, majorid, null, tolid, setadi).ToList();
            unitName = departmentComboBox.Text;

            
          


            ReportParameter unit = new ReportParameter("Unit", unitName);
            ReportParameter univercity = new ReportParameter("Univercity", university);
            ReportParameter major = new ReportParameter("Major", majorName);
            ReportParameter occupationTitle = new ReportParameter("Occupation", occupation);
            ReportParameter workgroup = new ReportParameter("WorkGroup", "");
            ReportParameter count = new ReportParameter("Count", result.Count.ToString());
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { unit, univercity, major, occupationTitle, workgroup, count });
            GetPersonnelReportResultBindingSource.DataSource = result;

            this.reportViewer1.RefreshReport();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Refresh();
            ReportParameter unit = new ReportParameter("Unit", "");
            ReportParameter univercity = new ReportParameter("Univercity", "");
            ReportParameter major = new ReportParameter("Major", "");
            ReportParameter occupationTitle = new ReportParameter("Occupation", "");
            ReportParameter workgroup = new ReportParameter("WorkGroup", "");
            ReportParameter count = new ReportParameter("Count", "");
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { unit, univercity, major, occupationTitle, workgroup, count });
            GetPersonnelReportResultBindingSource.DataSource = db.GetPersonnelReport(null, null, null, null, null, null);

            this.reportViewer1.RefreshReport();
        }

        public void Refresh()
        {
            occupationCmboBox.SelectedItem = null;
            universityComboBox.SelectedItem = null;
            majorComboBox.SelectedItem = null;
            departmentComboBox.SelectedIndex = 0;



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void universityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

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
