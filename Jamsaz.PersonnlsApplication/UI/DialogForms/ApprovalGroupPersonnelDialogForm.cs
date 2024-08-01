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
    public partial class ApprovalGroupPersonnelDialogForm : BasePersianForm
    {

        private List<Personnel> AllPersonnel;
        private JamsazERPLiteDataClassesDataContext db;
        public bool Mission { get; set; }
        public List<Personnel> personnels { get; set; }


        public ApprovalGroupPersonnelDialogForm()
        {
            InitializeComponent();
        }




        private void ApprovalGroupPersonnelDialogForm_Load(object sender, EventArgs e)
        {
            db = new JamsazERPLiteDataClassesDataContext();

            var lst = new List<Department> { new Department { Code = "-1", Name = "همه واحد ها" } };
            lst.AddRange(
                db.Departments.Join(db.DepartmentVersions, d => d.DepartmentVersionID, dv => dv.ID,
                    (d, dv) => new { d, dv }).Where(x => x.dv.IsActive.Value && !x.d.Code.Contains("-")).Select(x => x.d).ToList());
            departmentBindingSource.DataSource = lst;

            LoadData();
        }

        private async void LoadData()
        {
            try
            {
                if (Mission)
                {

                    AllPersonnel = db.Personnels.Where(c => c.IsActive == true && !(db.MissionApprovalGroupPersonnels.Any(d => d.PersonnelID == c.Id))).ToList();
                    personnelBindingSource.DataSource = db.Personnels.Where(c => c.IsActive == true && !(db.MissionApprovalGroupPersonnels.Any(d => d.PersonnelID == c.Id)));
                }
                else
                {

                    AllPersonnel = db.Personnels.Where(c => c.IsActive == true && !(db.ApprovalGroupPersonnels.Any(d => d.PersonnelID == c.Id))).ToList();
                    personnelBindingSource.DataSource = db.Personnels.Where(c => c.IsActive == true && !(db.ApprovalGroupPersonnels.Any(d => d.PersonnelID == c.Id)));

                }
            }
            catch (Exception e)
            {
                Helper.ShowMessage(e.InnerException?.Message ?? e.Message);
            }




        }


        private void voidButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            personnels = new List<Personnel>();
            this.personnelDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);

            //foreach (Personnel item in this.personnelBindingSource.List)
            foreach (Personnel item in AllPersonnel)
            {
                if (item.IsSelect)
                {
                    personnels.Add(item);
                }
            }
            DialogResult = DialogResult.OK;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (familyTextBox.Text != string.Empty)

                this.personnelBindingSource.DataSource = AllPersonnel.Where(c => (c.LastName.Contains(familyTextBox.Text) || c.FirstName.Contains(familyTextBox.Text) || c.PersonnelNumber == familyTextBox.Text)).OrderBy(d => Convert.ToInt32(d.PersonnelNumber));
           
            else if (departmentComboBox.SelectedItem != null)
            {
                var department = departmentComboBox.SelectedItem as Department;

                if (department != null && department.Code != "-1")
                {
                    var chDepartments = departmentComboboxChilds.SelectedItem as SelectAllChildDepartmentsResult;
                    if (chDepartments != null && chDepartments.Code == "-1")
                    {
                        this.personnelBindingSource.DataSource = AllPersonnel.Where(x => x.DepartmentId == department.Id);
                    }
                    else if (chDepartments != null)
                    {
                        var query = from item in AllPersonnel
                                    join
                                     item2 in db.vwMainPersonnelies on item.Id equals item2.Id
                                    where item2.DepartmentChildOrginalId == chDepartments.OriginalDepartmentID
                                    select item;
                        this.personnelBindingSource.DataSource = query;
                        //this.personnelBindingSource.DataSource = AllPersonnel.Where(x => x.DepartmentChildOrginalId == chDepartments.OriginalDepartmentID);
                    }
                }
            }
               
            else
                this.LoadData();

        }

        private void familyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (familyTextBox.Text != string.Empty )

                    this.personnelBindingSource.DataSource = AllPersonnel.Where(c => (c.LastName.Contains(familyTextBox.Text) || c.FirstName.Contains(familyTextBox.Text) || c.PersonnelNumber == familyTextBox.Text)).OrderBy(d => Convert.ToInt32(d.PersonnelNumber));
               
                else
                    this.LoadData();

            }
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
