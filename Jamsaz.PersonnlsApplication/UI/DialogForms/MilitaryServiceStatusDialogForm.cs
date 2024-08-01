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
    public partial class MilitaryServiceStatusDialogForm : Form
    {
        public MilitaryServiceStatusDialogForm()
        {
            InitializeComponent();
        }
        int? Selected;
        JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
        List<MilitaryServiceStatus> MilitaryServiceStatusNames = new List<MilitaryServiceStatus>();
        private void selectButton_Click(object sender, EventArgs e)
        {
            SelectedRow();
        }
       

        private void militaryServiceStatusDialogForm_Load(object sender, EventArgs e)
        {
            try
            {
                MilitaryServiceStatusNames = db.MilitaryServiceStatus.ToList();
                militaryServiceStatusBindingSource.DataSource = MilitaryServiceStatusNames;
            }
            catch (Exception exp)
            {
                if (exp.GetType() == typeof(System.Data.SqlClient.SqlException))
                   Helper.ShowMessage("خطا در ارتباط با بانک اطلاعاتی", " اتصال به بانک اطلاعاتی برقرار نیست " + "\n لطفا مشکل را به مسئول شبکه گزارش دهید\n ");
                else
                    Helper.ShowMessage(exp.Message);
            }
        }

        public MilitaryServiceStatus SelectedMilitaryServiceStatus { get; set; }
       
 

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void militaryServiceStatusDataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 24)
                this.Close();

            if (e.KeyChar == 10)
            {
                SelectedRow();
            }
        }

       

        private void txtFilterName_TextChanged(object sender, EventArgs e)
        {
            militaryServiceStatusBindingSource.DataSource = MilitaryServiceStatusNames.Where(c => c.Title.Contains(filterNameTextBox.Text));
        }
        private void SelectedRow()
        {
            try
            {
                if (passNullCheckBox.Checked)
                    this.SelectedMilitaryServiceStatus = null;
                else if(militaryServiceStatusBindingSource.Current !=null)
                {
                   this.SelectedMilitaryServiceStatus = (MilitaryServiceStatus)militaryServiceStatusBindingSource.Current;
                }

                this.DialogResult = DialogResult.OK;
            }
            catch { }
        }

        private void militaryServiceStatusDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow();
        }
   

     
    }
}