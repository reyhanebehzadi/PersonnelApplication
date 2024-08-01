using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.PersonnlsApplication.Classes;

namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class AddOrEditPersonelBankAccount : BasePersianForm
    {

        #region Definitions

        JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        public int PersonelNumber { get; set; }
        public int BankAccountId { get; set; }
        private readonly List<object> _accountTypes;

        #endregion

        #region Ctor

        public AddOrEditPersonelBankAccount()
        {
            InitializeComponent();
            _accountTypes = new List<object> { new { Name = "سپرده", Id = 0 }, new { Name = "تسهیلات", Id = 1 } };
            accountType.DataSource = _accountTypes;
            accountType.DisplayMember = "Name";
        }


        #endregion

        #region Events

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddOrEditPersonelBankAccount_Load(object sender, EventArgs e)
        {
            bankBindingSource.DataSource = db.Banks;
            if (BankAccountId <= 0) return;
            var personelBankAccount = db.PersonelBankAccounts.SingleOrDefault(x => x.ID == BankAccountId);
            if (personelBankAccount == null) return;
            bankCombobox.SelectedItem = personelBankAccount.Bank;
            accountNumber.Text = personelBankAccount.AccountNumber;
            shebaNumber.Text = personelBankAccount.ShebaNumber;
            accountType.SelectedItem =
                _accountTypes.FirstOrDefault(
                    x =>
                        x.GetType().GetProperty("Id").GetValue(x, null).ToString() ==
                        personelBankAccount.Type.ToString());
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (BankAccountId > 0)
                {
                    var personelBankAccount = db.PersonelBankAccounts.SingleOrDefault(x => x.ID == BankAccountId);
                    if (personelBankAccount == null) return;
                    personelBankAccount.Bank = ((Bank)bankCombobox.SelectedItem);
                    personelBankAccount.AccountNumber = accountNumber.Text;
                    personelBankAccount.PersonelID = PersonelNumber;
                    personelBankAccount.ShebaNumber = shebaNumber.Text;
                    personelBankAccount.Type =
                        int.Parse(
                            accountType.SelectedItem.GetType()
                                .GetProperty("Id")
                                .GetValue(accountType.SelectedItem, null)
                                .ToString());
                    db.SubmitChanges();
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    db.PersonelBankAccounts.InsertOnSubmit(new PersonelBankAccount
                    {
                        BankID = ((Bank)bankCombobox.SelectedItem).ID,
                        AccountNumber = accountNumber.Text,
                        PersonelID = PersonelNumber,
                        ShebaNumber = shebaNumber.Text,
                        Type =
                            int.Parse(
                                accountType.SelectedItem.GetType()
                                    .GetProperty("Id")
                                    .GetValue(accountType.SelectedItem, null)
                                    .ToString())
                    });
                    db.SubmitChanges();
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.Cancel;
                Helper.ShowMessage(ex.Message);
            }
        }


        #endregion

        #region Private Methods

        private void shabaProduction_Click(object sender, EventArgs e)
        {
            var codeGenerator = new ShabaCodeGenerator(((Bank)bankCombobox.SelectedItem).BBAN, accountNumber.Text,
                accountType.SelectedItem.GetType().GetProperty("Id").GetValue(accountType.SelectedItem, null).ToString());
            shebaNumber.Text = codeGenerator.Generate();
        }

        #endregion

    }
}
