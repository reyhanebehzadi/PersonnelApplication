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

namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    public partial class StaffPayrollReportForm : BasePersianForm
    {
        public StaffPayrollReportForm()
        {
            InitializeComponent();
        }
        private int? personnelNumber;
        private string FirstName;
        private string LastName;
        private int childDepartmentID;
      
        int? organizationPostId = null;
        private int PostID;

        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();

        private void StaffPayrollReportForm_Load(object sender, EventArgs e)
        {
            var lst = new List<Department> { new Department { Code = "-1", Name = "همه واحد ها" } };
            lst.AddRange(
                db.Departments.Join(db.DepartmentVersions, d => d.DepartmentVersionID, dv => dv.ID,
                    (d, dv) => new { d, dv }).Where(x => x.dv.IsActive.Value && !x.d.Code.Contains("-")).Select(x => x.d).ToList());
            departmentBindingSource.DataSource = lst;
           
         


            organizationPostBindingSource.DataSource = db.OrganizationPosts;
            organizationPostComboBox.SelectedIndex = -1;

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SubSearch();

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Keys valKeys = (Keys)(short)keyData;
            if (valKeys == Keys.Enter)
                SubSearch();
           

            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void SubSearch()
        {
            if (!string.IsNullOrEmpty(personnelNumberTextBox.Text))
                personnelNumber = int.Parse(personnelNumberTextBox.Text);
            else
                personnelNumber = null;

            if (!string.IsNullOrEmpty(NameTextBox.Text))
                FirstName = NameTextBox.Text;
            else
                FirstName = "";

            if (!string.IsNullOrEmpty(familyTextBox.Text))
                LastName = familyTextBox.Text;
            else
                LastName = "";

            if (organizationPostComboBox.SelectedValue != null)
                organizationPostId = (int)organizationPostComboBox.SelectedValue;

            var department = departmentComboBox.SelectedItem as Department;
            if (department != null && department.Code != "-1")
            {
                var chDepartments = departmentComboboxChilds.SelectedItem as SelectAllChildDepartmentsResult;
                if (chDepartments != null && chDepartments.Code == "-1")
                {
                   
                 getStaffPayrollResultBindingSource.DataSource = db.GetStaffPayroll(null, personnelNumber, FirstName, LastName, organizationPostId,department.Id);
                }
                else if (chDepartments != null)
                {
                    getStaffPayrollResultBindingSource.DataSource= db.GetStaffPayroll(chDepartments.OriginalDepartmentID, personnelNumber, FirstName, LastName, organizationPostId, department.Id);
                   
                }
            }
            else
                getStaffPayrollResultBindingSource.DataSource = db.GetStaffPayroll(null, personnelNumber, FirstName, LastName, organizationPostId, null);


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

        private void organizationPostComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
