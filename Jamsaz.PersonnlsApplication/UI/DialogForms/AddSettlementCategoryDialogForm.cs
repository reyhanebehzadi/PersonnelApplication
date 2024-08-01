using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Definitions;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class AddSettlementCategoryDialogForm : BasePersianForm
    {
        public AddSettlementCategoryDialogForm()
        {
            InitializeComponent();
        }
        public FormStatus FormStatus { get; set; }
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        public SettlementCategory SettlementCategory { get; set; }
        private void AddSettlementCategoryDialogForm_Load(object sender, EventArgs e)
        {
            int count = db.SettlementCategories.Count();
            if (FormStatus == FormStatus.Add)
            {

                SettlementCategory = new SettlementCategory();
                codeTextBox.Text = (count + 1).ToString();
                SettlementCategory.Code = (count + 1).ToString();
            }
            else
                SettlementCategory = db.SettlementCategories.SingleOrDefault(c => c.ID == SettlementCategory.ID);
            settlementCategoryBindingSource.DataSource = SettlementCategory;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Helper.Confirm("مایل به ثبت اطلاعات هستید؟"))
                if (FormStatus == FormStatus.Add)
                {

                    db.SettlementCategories.InsertOnSubmit(SettlementCategory);
                    db.SubmitChanges();

                }
                else
                    db.SubmitChanges();
            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
