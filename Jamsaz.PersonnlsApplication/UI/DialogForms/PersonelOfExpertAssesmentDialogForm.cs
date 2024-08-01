using System;
using System.Linq;
using System.Windows.Forms;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;

namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class PersonelOfExpertAssesmentDialogForm : BasePersianForm
    {
        private readonly JamsazERPLiteDataClassesDataContext _db;
        private readonly ExpertAssesment _expert;

        public PersonelOfExpertAssesmentDialogForm(ExpertAssesment expert)
        {
            _expert = expert;
            InitializeComponent();
            _db = new JamsazERPLiteDataClassesDataContext();
        }

        private void LoadData()
        {
            var fullName = fullNameText.Text;
            var no = personelNumberText.Text;
            var query = _db.PersonelOfExpertAsseements.AsQueryable();
            if (!string.IsNullOrEmpty(fullName))
                query = query.Where(x => x.Personnel.Descriptor.Contains(fullName));
            if (!string.IsNullOrEmpty(no))
                query = query.Where(x => x.Personnel.PersonnelNumber.StartsWith(no));
            personelOfExpertAsseementBindingSource.ResetBindings(false);
            personelOfExpertAsseementBindingSource.DataSource = query.Where(x=>x.ExpertID == _expert.ID).ToList();
        }

        private void PersonelOfExpertAssesmentDialogForm_Load(object sender, System.EventArgs e)
        {
            try
            {
                LoadData();
                expertFullNameText.Text = _expert.FullName;
                expertNumberText.Text = _expert.PersonelNumber.ToString();
                expertDepartmentText.Text = _expert.DepartmentName;
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(ex.Message);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Helper.Confirm("آیا برای حذف این شخص مطمئن هستید")) return;
                var currentPerson = personelOfExpertAsseementBindingSource.Current as PersonelOfExpertAsseement;
                if (currentPerson == null) return;
                var person = _db.PersonelOfExpertAsseements.SingleOrDefault(x => x.ID == currentPerson.ID);
                if (person == null) return;
                _db.PersonelOfExpertAsseements.DeleteOnSubmit(person);
                _db.SubmitChanges();
                LoadData();
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(ex.Message);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                var personelSelectDialog = new AddPersonelOfExpertAssesmentDialogForm(_expert);
                if (personelSelectDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(ex.Message);
            }
        }
    }
}
