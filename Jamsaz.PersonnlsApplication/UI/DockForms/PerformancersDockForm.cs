using System;
using System.Linq;
using System.Windows.Forms;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.PersonnlsApplication.UI.DialogForms;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class PerformancersDockForm : BasePersianForm
    {
        private readonly JamsazERPLiteDataClassesDataContext _db;

        public PerformancersDockForm()
        {
            InitializeComponent();
            _db = new JamsazERPLiteDataClassesDataContext();
        }

        private void PerformancersDockForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(ex.Message);
            }
        }

        private void LoadData()
        {
            var fullName = fullNameText.Text;
            var no = personelNumberText.Text;
            var query = _db.ExpertAssesments.AsQueryable();
            if (!string.IsNullOrEmpty(fullName))
                query = query.Where(x => x.Personnel.Descriptor.Contains(fullName));
            if (!string.IsNullOrEmpty(no))
                query = query.Where(x => x.Personnel.PersonnelNumber.StartsWith(no));
            expertAssesmentBindingSource.ResetBindings(false);
            expertAssesmentBindingSource.DataSource = query.ToList();
            dataGridView1.Refresh();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                var addEditDialog = new AddEditExpertAssesmentDialogForm();
                if (addEditDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
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
                if (!Helper.Confirm("آیا از حذف این سطر مطمئن هستید؟")) return;
                var currentExpert = expertAssesmentBindingSource.Current as ExpertAssesment;
                if (currentExpert == null) return;
                _db.ExpertAssesments.DeleteOnSubmit(currentExpert);
                _db.SubmitChanges();
                LoadData();
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(ex.Message);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(ex.Message);
            }
        }

        private void setPersonelOfExpertButton_Click(object sender, EventArgs e)
        {
            //فعلا مخفی شده است
            //به روش دیگر این امر انجام می شود
            try
            {
                var currentExpert = expertAssesmentBindingSource.Current as ExpertAssesment;
                if (currentExpert != null)
                {
                    var addPersonelOfEpert = new PersonelOfExpertAssesmentDialogForm(currentExpert);
                    if (addPersonelOfEpert.ShowDialog() == DialogResult.OK)
                    {
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(ex.Message);
            }
        }
    }
}
