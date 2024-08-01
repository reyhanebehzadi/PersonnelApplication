using System;
using System.Linq;
using System.Windows.Forms;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;

namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class PersonelBankAccountDialogForm : BasePersianForm
    {
        #region Definitions

        JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        public int PersonID { get; set; }

        #endregion

        #region Ctor

        public PersonelBankAccountDialogForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        private void PersonelBankAccountDialogForm_Load(object sender, System.EventArgs e)
        {
            LoadData();
        }

        private void newAccountButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                var editDialog = new AddOrEditPersonelBankAccount { PersonelNumber = PersonID, BankAccountId = 0 };
                if (editDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(ex.Message);
            }
        }

        private void editAccountButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (bankAccountGridView.CurrentRow != null)
                {
                    var current = bankAccountGridView.CurrentRow.Cells[0].Value;//ID
                    var editDialog = new AddOrEditPersonelBankAccount
                    {
                        PersonelNumber = PersonID,
                        BankAccountId = (int)current
                    };
                    if (editDialog.ShowDialog() == DialogResult.OK)
                    {
                        Helper.ShowMessage("تغییرات انجام شد");
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(ex.Message);
            }
        }

        private void deleteAccountButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (bankAccountGridView.CurrentRow != null)
                {
                    var current = bankAccountGridView.CurrentRow.Cells[0].Value;//ID
                    if (Helper.Confirm("آیا از حذف کردن شماره حساب مطمئن هستید؟"))
                    {
                        var bankAccount = db.PersonelBankAccounts.FirstOrDefault(x => x.ID == (int)current);
                        if (bankAccount != null)
                        {
                            db.PersonelBankAccounts.DeleteOnSubmit(bankAccount);
                            db.SubmitChanges();
                            LoadData();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(ex.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        #endregion

        #region Private Methods

        private void LoadData()
        {
            personelBankAccountBindingSource.DataSource = db.PersonelBankAccounts.Where(x => x.PersonelID == PersonID);
            personelBankAccountBindingSource.ResetBindings(false);
        }

        #endregion

    }
}
