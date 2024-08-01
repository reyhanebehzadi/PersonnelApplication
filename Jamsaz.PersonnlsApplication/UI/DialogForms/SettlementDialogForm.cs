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
    public partial class SettlementDialogForm : BasePersianForm
    {
        public SettlementDialogForm()
        {
            InitializeComponent();
        }
        public Personnel Personnel { get; set; }
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        public Settlement Settlement { get; set; }
        public FormStatus FormStatus { get; set; }
        private void SettlementDialogForm_Load(object sender, EventArgs e)
        {
            settlementCategoryBindingSource.DataSource = db.SettlementCategories.ToList();
            fullNametextBox.Text = Personnel.FirstName + " " + Personnel.LastName;
            personnelNumberTextBox.Text = Personnel.PersonnelNumber;
           

            if (FormStatus == FormStatus.Add)
            {
                Settlement = new Settlement();
                Settlement.Date = DateTime.Now;
                Settlement.Complained = false;
                Settlement.AccidentComplaint = false;
                Settlement.Pay_AccidentComplaint = false;
                Settlement.Pay_complaint = false;
                Settlement.UnemploymentInsurance = false;
            }

            else
            {

              

                Settlement = db.Settlements.SingleOrDefault(c => c.ID == Settlement.ID);
                Settlement.SettlementCategoryID = Settlement.SettlementCategory.ID;
                SettlementCategorycomboBox.SelectedValue = Settlement.SettlementCategoryID;
            }

            settlementBindingSource.DataSource = Settlement;

           
        }



        private void okButton_Click(object sender, EventArgs e)
        {
            if (FormStatus==FormStatus.Add)
            {
                Settlement.SettlementCategoryID = ((SettlementCategory)settlementCategoryBindingSource.Current).ID;
                Settlement.PersonnelID = Personnel.Id;
                Helper.Confirm("آیا مایل به غیر فعال کردن پرسنل  هستید؟");
                db.Settlements.InsertOnSubmit(Settlement);
                db.SubmitChanges();
                DialogResult = DialogResult.OK;
            }
            else
            {
                Helper.Confirm("آیا مایل ثبت اطلاعات هستید؟");
                Settlement.SettlementCategory = ((SettlementCategory)settlementCategoryBindingSource.Current);
                db.SubmitChanges();
                DialogResult = DialogResult.OK;
            }
            

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumber(e);
        }

        private void complainedAmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumber(e);
        }

        private void accidentComplaintAmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumber(e);
        }

        public void OnlyNumber(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))

            {
                e.Handled = true;
            }
        }
    }
}
