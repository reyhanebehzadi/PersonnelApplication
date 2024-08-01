using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.PersonnlsApplication.UI.DialogForms;
using Jamsaz.PersonnlsApplication.UI.ReportForms;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class PersonelShabaDockForm : BasePersianForm
    {
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        public PersonelShabaDockForm()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, System.EventArgs e)
        {
            Search();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                Search();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Search()
        {
            int? peronelNumber =
                int.Parse(string.IsNullOrEmpty(personnelNumberTextBox.Text) ? "0" : personnelNumberTextBox.Text);
            personnelBindingSource.DataSource = db.vwAccountNumberPersonnely_SearchAdvanced(NameTextBox.Text,
                lastNameTextBox.Text, peronelNumber == 0 ? null : peronelNumber, null, "", "", 1, "1900/01/01",
                "3000/01/01", "1900/01/01", "3000/01/01", "1900/01/01", "3000/01/01", "1900/01/01", "3000/01/01")
                .Where(x => x.BankID == ((Bank)bankTypeCombo.SelectedItem).ID)
                .ToList();
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            var reportForm = new PersonelShebaReportForm {BankName = ((Bank)bankTypeCombo.SelectedItem).Name };
            var personnel = personnelBindingSource.DataSource as vwAccountNumberPersonnely_SearchAdvancedResult;
            reportForm.Personnels = personnel != null
                ? new List<vwAccountNumberPersonnely_SearchAdvancedResult> { personnel }
                : ((IList<vwAccountNumberPersonnely_SearchAdvancedResult>)personnelBindingSource.DataSource)
                    .ToList();
            reportForm.Show();
        }

        private void shabaButton_Click(object sender, EventArgs e)
        {
            var personnelShabaDialogForm = new SetShabaForPersonnelDialogForm();
            personnelShabaDialogForm.ShowDialog();
        }

        private void PersonelShabaDockForm_Load(object sender, EventArgs e)
        {
            bankBindingSource.DataSource = db.Banks.ToList();
        }
    }
}
