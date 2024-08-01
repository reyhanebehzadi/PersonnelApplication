using System;
using System.Linq;
using System.Windows.Forms;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;

namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class AddEditExpertAssesmentDialogForm : BasePersianForm
    {
        private readonly JamsazERPLiteDataClassesDataContext _db;
        private Personnel _personnel;
        private int _personelDepartmentId;

        public AddEditExpertAssesmentDialogForm()
        {
            InitializeComponent();
            _db = new JamsazERPLiteDataClassesDataContext();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                var personelList = new PersonnelListForm(_db);
                if (personelList.ShowDialog() != DialogResult.OK) return;
                personelNumberText.Text = personelList.Personnel.PersonnelNumber;
                fullNameText.Text = personelList.Personnel.Descriptor;
                var department = _db.Departments.SingleOrDefault(d => d.Id == personelList.Personnel.DepartmentId);
                if (department != null)
                    departmentText.Text =
                        department.Name;
                var section = _db.DepartmentPersonnels.SingleOrDefault(
                    pd => pd.PersonnelID == personelList.Personnel.Id && pd.IsActiveDepartment.Value);
                if (section != null)
                {
                    sectionNameText.Text =
                        section.DepartmentName;
                    _personelDepartmentId = section.DepartmentID;
                }
                _personnel = personelList.Personnel;
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(ex.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var expert = new ExpertAssesment
                {
                    PersonelID = _personnel.Id,
                    DepartmentId = _personnel.DepartmentId.Value,
                    SectionId = _personelDepartmentId
                };
                _db.ExpertAssesments.InsertOnSubmit(expert);
                _db.SubmitChanges();
                if (expert.ID <= 0) return;
                DialogResult = DialogResult.OK;
                Helper.ShowMessage("ثبت شد");
                Close();
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(ex.Message);
            }
        }
    }
}
