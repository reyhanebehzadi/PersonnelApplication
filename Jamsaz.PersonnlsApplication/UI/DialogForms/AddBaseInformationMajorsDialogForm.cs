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
    public partial class AddBaseInformationMajorsDialogForm : BasePersianForm
    {
        public AddBaseInformationMajorsDialogForm()
        {
            InitializeComponent();
        }
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        public Major Major { get; set; }
        public FormStatus FormStatus { get; set; }

        private void AddBaseInformationMajorsDialogForm_Load(object sender, EventArgs e)
        {
            if (FormStatus == FormStatus.Add)
            {
                Major = new Major();
                Major.Code = db.Majors.Count() + 1;
            }

            else
                Major = db.Majors.SingleOrDefault(c => c.Id == Major.Id);
            majorBindingSource.DataSource = Major;


        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Helper.Confirm("آیا مایل به ثبت اطلاعات هستید؟"))
            {
                if (string.IsNullOrEmpty(nameTextBox.Text))
                {
                    Helper.ShowMessage("نام رشته تحصیلی را وارد کنید");
                    return;
                }
                if (IsHassWord(Major.Name))
                {
                    Helper.ShowMessage("قبلا در لیست اضافه شده است");
                    return;
                }

                if (FormStatus == FormStatus.Add)
                    db.Majors.InsertOnSubmit(Major);
                db.SubmitChanges();
                DialogResult = DialogResult.OK;
            }

        }

        public bool IsHassWord(string name)
        {
            try
            {
                foreach (Major major in db.Majors)
                {
                    if (major.Name == name)
                        return true;
                }
                return false;

            }
            catch { }
            return false;
        }


    }
}
