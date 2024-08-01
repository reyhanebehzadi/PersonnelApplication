using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;

namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class AddPersonelOfExpertAssesmentDialogForm : BasePersianForm
    {
        private readonly JamsazERPLiteDataClassesDataContext _db;
        private readonly ExpertAssesment _expert;
        public AddPersonelOfExpertAssesmentDialogForm(ExpertAssesment expert)
        {
            InitializeComponent();
            _db = new JamsazERPLiteDataClassesDataContext();
            _expert = expert;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void PersonnelListForm_Load(object sender, EventArgs e)
        {
            var lst = new List<Department> { new Department { Code = "-1", Name = "همه واحد ها" } };
            lst.AddRange(
                _db.Departments.Join(_db.DepartmentVersions, d => d.DepartmentVersionID, dv => dv.ID,
                    (d, dv) => new { d, dv }).Where(x => x.dv.IsActive.Value && !x.d.Code.Contains("-")).Select(x => x.d).ToList());
            departmentBindingSource.DataSource = lst;
            LoadData();
        }

        private void LoadData()
        {
            var currentDepartment = departmentBindingSource.Current as Department;
            var currentSection = childrenOfDepartmentbindingSource.Current as SelectAllChildDepartmentsResult;
            var query = _db.Personnels.AsQueryable();
            if (familyTextBox.Text != string.Empty)
                query = query.Where(
                    c =>
                        (c.LastName.Contains(familyTextBox.Text) || c.FirstName.Contains(familyTextBox.Text) ||
                         c.PersonnelNumber == familyTextBox.Text) && c.IsActive == true);
            if (currentDepartment != null && currentDepartment.Code != "-1")
                query =
                    query.Where(
                        p =>
                                p.DepartmentId == currentDepartment.Id);
            if (currentSection != null && currentSection.Code != "-1")
                query = query.Where(p => p.DepartmentPersonnels.Any(
                    dp =>
                        dp.IsActiveDepartment.Value && dp.PersonnelID == p.Id &&
                        dp.DepartmentID == currentSection.ID));
            personnelBindingSource.ResetBindings(false);
            personnelBindingSource.DataSource = query.Except(_db.Personnels.Where(x => x.Id == _expert.PersonelID)).Except(_db.PersonelOfExpertAsseements.Select(pea => pea.Personnel)).OrderBy(d => Convert.ToInt32(d.PersonnelNumber)).ToList();
        }

        private void SaveData(bool isSelectAll)
        {
            var personels = personnelBindingSource.List as List<Personnel>;
            var personelIds = new List<Personnel>();
            if (personels != null)
            {
                if (isSelectAll)
                {
                    personelIds.AddRange(personels);
                }
                else
                {
                    foreach (DataGridViewRow row in personnelDataGridView.Rows)
                    {
                        var checkBoxCell = row.Cells[0] as DataGridViewCheckBoxCell;
                        if (checkBoxCell == null || !bool.Parse(checkBoxCell.Value.ToString())) continue;
                        var personelId = int.Parse(row.Cells[1].Value.ToString());
                        personelIds.AddRange(personels.Where(p => p.Id == personelId));
                    }
                }
                foreach (var personnel in personelIds)
                {
                    var section = personnel.DepartmentPersonnels.FirstOrDefault(
                        x => x.IsActiveDepartment != null && (x.PersonnelID == personnel.Id && x.IsActiveDepartment.Value));
                    if (section != null)
                    {
                        _db.PersonelOfExpertAsseements.InsertOnSubmit(new PersonelOfExpertAsseement
                        {
                            ExpertID = _expert.ID,
                            PersonelID = personnel.Id,
                            SectionID = section.DepartmentID
                        });
                    }
                }
                _db.SubmitChanges();
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
            Close();
        }

        private void familyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            LoadData();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            SaveData(false);
        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            SaveData(true);
        }

        private void departmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentDepartmentSelected = (Department)departmentComboBox.SelectedItem;
            if (currentDepartmentSelected == null) return;
            var lst = new List<SelectAllChildDepartmentsResult> { new SelectAllChildDepartmentsResult { Code = "-1", Name = "همه بخش ها" } };
            lst.AddRange(_db.SelectAllChildDepartments(currentDepartmentSelected.Id).Join(_db.DepartmentVersions, d => d.DepartmentVersionID, dv => dv.ID,
                (d, dv) => new { d, dv })
                .Where(
                    x =>
                       x.dv.IsActive.Value &&
                        x.d.OriginalDepartmentID != currentDepartmentSelected.OriginalDepartmentID)
                .Select(x => x.d)
                .ToList());
            childrenOfDepartmentbindingSource.DataSource = lst;
        }
    }
}
