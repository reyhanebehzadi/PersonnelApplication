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
    public partial class AddBaseInformationMilitaryServiceDialogForm : BasePersianForm
    {
        public AddBaseInformationMilitaryServiceDialogForm()
        {
            InitializeComponent();
        }
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        public MilitaryServiceStatus MilitaryServiceStatus { get; set; }
        public FormStatus FormStatus { get; set; }


        private void AddBaseInformationMilitaryServiceDialogForm_Load(object sender, EventArgs e)
        {
            if (FormStatus == FormStatus.Add)
            {
                MilitaryServiceStatus = new MilitaryServiceStatus();
                MilitaryServiceStatus.Code = db.MilitaryServiceStatus.Count() + 1;
            }

            else
                MilitaryServiceStatus = db.MilitaryServiceStatus.SingleOrDefault(c => c.Id == MilitaryServiceStatus.Id);
            militaryServiceStatusBindingSource.DataSource = MilitaryServiceStatus;
        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Helper.Confirm("آیا مایل به ثبت اطلاعات هستید؟"))
            {

                if (db.MilitaryServiceStatus.Any(c => c.Title == titleTextBox.Text))
                {
                    MessageBox.Show("قبلا در لیست اضافه شده است");
                    return;
                }

                if (string.IsNullOrEmpty(MilitaryServiceStatus.Title))
                {
                    Helper.ShowMessage("عنوان را وارد کنید");
                    return;
                }

                if (FormStatus == FormStatus.Add)
                    db.MilitaryServiceStatus.InsertOnSubmit(MilitaryServiceStatus);
                db.SubmitChanges();
                DialogResult = DialogResult.OK;


            }

        }

       


    }
}
