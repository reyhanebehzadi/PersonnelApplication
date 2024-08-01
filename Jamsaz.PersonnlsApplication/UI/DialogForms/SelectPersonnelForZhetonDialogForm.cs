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
namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class SelectPersonnelForZhetonDialogForm : BasePersianForm
    {
        public SelectPersonnelForZhetonDialogForm()
        {
            InitializeComponent();
        }
        public int DepartmentID { get; set; }
        public int ChildID { get; set; }
        readonly JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        private void SelectPersonnelForZhetonDialogForm_Load(object sender, EventArgs e)
        {
            var lst = new List<Department> { new Department { Code = "-1", Name = "همه واحد ها" } };
            lst.AddRange(
                db.Departments.Join(db.DepartmentVersions, d => d.DepartmentVersionID, dv => dv.ID,
                    (d, dv) => new { d, dv }).Where(x => x.dv.IsActive.Value && !x.d.Code.Contains("-")).Select(x => x.d).ToList());
            departmentBindingSource.DataSource = lst;
        }

        private void departmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentDepartmentSelected = (Department)departmentComboBox.SelectedItem;
            if (currentDepartmentSelected == null) return;
            var lst = new List<SelectAllChildDepartmentsResult> { new SelectAllChildDepartmentsResult { Code = "-1", Name = "همه بخش ها" } };
            lst.AddRange(db.SelectAllChildDepartments(currentDepartmentSelected.Id)
                .Join(db.DepartmentVersions, d => d.DepartmentVersionID, dv => dv.ID,
                (d, dv) => new { d, dv })
                .Where(
                    x =>
                       x.dv.IsActive.GetValueOrDefault())
                .Select(x => x.d)
                .ToList());
            childrenOfDepartmentbindingSource.DataSource = lst;
        }

        private void SelectedButton_Click(object sender, EventArgs e)
        {
            var department = departmentComboBox.SelectedItem as Department;
            if (department != null && department.Code != "-1")
            {
                var chDepartments = departmentComboboxChilds.SelectedItem as SelectAllChildDepartmentsResult;
                if (chDepartments != null && chDepartments.Code == "-1")
                {
                    DepartmentID= department.Id;
                }
                else if (chDepartments != null)
                {
                    ChildID =Convert.ToInt32( chDepartments.ID);
                }
            }
            DepartmentID = 0;

            DialogResult = DialogResult.OK;
        }
    }
}
