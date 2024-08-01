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
using Jamsaz.PersonnlsApplication.BusinessObjects.Definitions;
using Jamsaz.PersonnlsApplication.UI.DialogForms;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class EncouragementDockForm : BasePersianForm
    {
        public EncouragementDockForm()
        {
            InitializeComponent();
        }

        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        private Department department;
        List<GetEncouragementResult> list;
        private void EncouragementDockForm_Load(object sender, EventArgs e)
        {
            personnelBindingSource.DataSource = db.Personnels.Where(c => c.IsActive == true).OrderBy(d => Convert.ToInt32(d.PersonnelNumber));

            var lst = new List<Department> { new Department { Code = "-1", Name = "همه واحد ها" } };
            lst.AddRange(
                db.Departments.Join(db.DepartmentVersions, d => d.DepartmentVersionID, dv => dv.ID,
                    (d, dv) => new { d, dv }).Where(x => x.dv.IsActive.Value && !x.d.Code.Contains("-")).Select(x => x.d).ToList());
            departmentBindingSource.DataSource = lst;
        }

        private void personnelTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (personnelTextBox.Text != string.Empty)
                if (e.KeyChar == (Char)Keys.Enter)
                    personnelBindingSource.DataSource = db.Personnels.Where(c => c.FirstName.Contains(personnelTextBox.Text) || c.LastName.Contains(personnelTextBox.Text) || c.PersonnelNumber.Contains(personnelTextBox.Text)).OrderBy(d => Convert.ToInt32(d.PersonnelNumber)); ;

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            department = departmentComboBox.SelectedItem as Department;
            if (department != null && department.Code != "-1" && string.IsNullOrEmpty(personnelTextBox.Text))
            {
                var list = db.Personnels.Where(c => c.DepartmentId == department.Id).OrderBy(d => Convert.ToInt32(d.PersonnelNumber)).ToList();
                personnelBindingSource.DataSource = db.Personnels.Where(c => c.DepartmentId == department.Id).OrderBy(d => Convert.ToInt32(d.PersonnelNumber)).ToList();
            }
                
            else 
                personnelBindingSource.DataSource = db.Personnels.Where(c => c.FirstName.Contains(personnelTextBox.Text) || c.LastName.Contains(personnelTextBox.Text) || c.PersonnelNumber.Contains(personnelTextBox.Text)).OrderBy(d => Convert.ToInt32(d.PersonnelNumber));




        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            personnelTextBox.Text = string.Empty;
            personnelBindingSource.DataSource = db.Personnels.Where(c => c.IsActive == true).OrderBy(d => Convert.ToInt32(d.PersonnelNumber));
        }

        private void personnelBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Personnel personnel = (Personnel)personnelBindingSource.Current;

            encouragementBindingSource.DataSource = db.Encouragements.Where(c => c.PersonnelID == personnel.Id);
        }

        private void personnelBindingSource_PositionChanged(object sender, EventArgs e)
        {
            personnelBindingSource_CurrentChanged(null, null);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Personnel personnel = (Personnel)personnelBindingSource.Current;
            if (personnel != null)
            {
                AddEncouragementDialogForm addEncouragementDialogForm = new AddEncouragementDialogForm() { FormStatus = FormStatus.Add, Personnel = personnel };

                if (addEncouragementDialogForm.ShowDialog() == DialogResult.OK)
                {
                    db = new JamsazERPLiteDataClassesDataContext();
                    encouragementBindingSource.DataSource = db.Encouragements.Where(c => c.PersonnelID == personnel.Id).ToList();
                    encouragementDataGridView.Refresh();
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Personnel personnel = (Personnel)personnelBindingSource.Current;
            if (personnel != null)
            {
                Encouragement encouragement = (Encouragement)encouragementBindingSource.Current;
                if (encouragement != null)
                {
                    AddEncouragementDialogForm addEncouragementDialogForm = new AddEncouragementDialogForm()
                    {
                        FormStatus = FormStatus.Edit,
                        Encouragement = encouragement,
                        Personnel = personnel
                    };

                    if (addEncouragementDialogForm.ShowDialog() == DialogResult.OK)
                    {
                        db = new JamsazERPLiteDataClassesDataContext();
                        
                        encouragementBindingSource.DataSource = db.Encouragements.Where(c => c.PersonnelID == personnel.Id).ToList();
                        encouragementDataGridView.Refresh();
                    }
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Personnel personnel = (Personnel)personnelBindingSource.Current;
            if (personnel != null)
            {
                Encouragement encouragement = (Encouragement)encouragementBindingSource.Current;
                if (encouragement != null)
                {
                    if (Helper.Confirm("آیا مایل به حذف رکورد جاری هستید؟"))
                    {
                        db.Encouragements.DeleteOnSubmit(encouragement);
                        db.SubmitChanges();

                        db = new JamsazERPLiteDataClassesDataContext();
                        encouragementBindingSource.DataSource = db.Encouragements.Where(c => c.PersonnelID == personnel.Id).ToList();

                    }


                }
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            department = departmentComboBox.SelectedItem as Department;
            var report = new Stimulsoft.Report.StiReport();

            if (department != null && department.Code != "-1")
              list = db.GetEncouragement(department.Id, string.IsNullOrEmpty(personnelTextBox.Text) ? null : personnelTextBox.Text).ToList();
            else
            {
                bool x = string.IsNullOrEmpty(personnelTextBox.Text);
                list = db.GetEncouragement(null, string.IsNullOrEmpty(personnelTextBox.Text) ? null : personnelTextBox.Text).ToList();
            }

            //report.Load(@"D:\EncouragementReport.mrt");
            report.Load(Properties.Resources.EncouragementReport);


            report.RegBusinessObject("items", list);
            report.Render();


            //report.Design();
            report.Show(true);

        }
    }
}
