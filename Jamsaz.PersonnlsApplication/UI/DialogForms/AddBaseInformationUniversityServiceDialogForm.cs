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
namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class AddBaseInformationUniversityServiceDialogForm : BasePersianForm
    {
        public AddBaseInformationUniversityServiceDialogForm()
        {
            InitializeComponent();
        }
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        public FormStatus FormStatus { get; set; }
        public UniversityDegree UniversityDegree { get; set; }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Helper.Confirm("آیا تمایل به ثبت اطلاعات دارید؟"))
            {
                if (string.IsNullOrEmpty(nameTextBox.Text))
                {
                    Helper.ShowMessage("نام مدرک تحصیلی را وارد کنید");
                    return;
                }

                if (db.UniversityDegrees.Any(c => c.Name == nameTextBox.Text))
                {
                    Helper.ShowMessage(" مقدار قبلا در لیست اضافه شده  لطفا مقدار را تغییر دهید ");
                    return;
                }
                if (FormStatus == FormStatus.Add)
                    db.UniversityDegrees.InsertOnSubmit(UniversityDegree);

                db.SubmitChanges();
                DialogResult = DialogResult.OK;
            }

           
        }

        private void AddBaseInformationUniversityServiceDialogForm_Load(object sender, EventArgs e)
        {
            if (FormStatus == FormStatus.Add)
            {
                UniversityDegree = new UniversityDegree();
                UniversityDegree.Code = (db.UniversityDegrees.Count() + 1).ToString();
            }
            else
                UniversityDegree = db.UniversityDegrees.SingleOrDefault(c => c.Id == UniversityDegree.Id);
            universityDegreeBindingSource.DataSource = UniversityDegree;

        }
    }
}
