using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.Common;

namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class ContractTypeDialogForm : Form
    {
        public ContractTypeDialogForm()
        {
            InitializeComponent();
        }
        int? Selected;
        JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
        List<ContractType> contractTypeNames = new List<ContractType>(); 
        private void frmpopkindsofcontract_Load(object sender, EventArgs e)
        {
            try
            {
                contractTypeNames = db.ContractTypes.ToList();
                kindsOfContractBindingSource.DataSource = contractTypeNames;
            }
            catch (Exception exp)
            {
                if (exp.GetType() == typeof(System.Data.SqlClient.SqlException))
                    Helper.ShowMessage("خطا در ارتباط با بانک اطلاعاتی", " اتصال به بانک اطلاعاتی برقرار نیست " + "\n لطفا مشکل را به مسئول شبکه گزارش دهید\n ");
                else
                    Helper.ShowMessage(exp.Message);
            }

        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            SelectedRow();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contractTypeDataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 24)
                this.Close();

            if (e.KeyChar == 10)
            {
                SelectedRow();
            }

        }

        private void contractTypeDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow();
        }

        public ContractType SelectedContractType { get; set; }

        private void txtFilterName_TextChanged(object sender, EventArgs e)
        {
            kindsOfContractBindingSource.DataSource = contractTypeNames.Where(c => c.Name.Contains(filterNameTextBox.Text));
        }

        private void SelectedRow()
        {
            try
            {
                if (!passNullCheckBox.Checked && kindsOfContractBindingSource.Current != null)
                    this.SelectedContractType = (ContractType)kindsOfContractBindingSource.Current;
                else this.SelectedContractType = null;
                this.DialogResult = DialogResult.OK;
            }
            catch { }
        }

       

       
   
    }
}