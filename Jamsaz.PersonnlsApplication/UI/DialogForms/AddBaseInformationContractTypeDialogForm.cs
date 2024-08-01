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
    public partial class AddBaseInformationContractTypeDialogForm : BasePersianForm
    {
        public AddBaseInformationContractTypeDialogForm()
        {
            InitializeComponent();
        }
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        public ContractType ContractType { get; set; }
        public FormStatus FormStatus { get; set; }

        private void AddBaseInformationContractTypeDialogForm_Load(object sender, EventArgs e)
        {
            if (FormStatus == FormStatus.Add)
            {
                ContractType = new ContractType();
                ContractType.Code = db.ContractTypes.Count() + 1;
            }
               
            else
            ContractType = db.ContractTypes.SingleOrDefault(c => c.Id == ContractType.Id);
            contractTypeBindingSource.DataSource = ContractType;
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
                    Helper.ShowMessage("نام نوع قرارداد را وارد کنید");
                    return;
                }
                if (db.ContractTypes.Any(c => c.Name == nameTextBox.Text))
                {
                    Helper.ShowMessage("قبلا در لیست اضافه شده  لطفا مقدار را تغییر دهید ");
                    return;
                }
                if (FormStatus == FormStatus.Add)
                    db.ContractTypes.InsertOnSubmit(ContractType);
                db.SubmitChanges();
                DialogResult = DialogResult.OK;
            }

        }
    }
}
