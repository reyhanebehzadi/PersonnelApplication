using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class CustomConnectionStringDialogForm : Form
    {
        public CustomConnectionStringDialogForm()
        {
            InitializeComponent();
        }
        string currentConnectionString = string.Empty;
        private void FormCustomConnectionString_Load(object sender, EventArgs e)
        {
            serverNameTextBox.Text = Properties.Settings.Default.ServerName;
            catalogTextBox.Text = Properties.Settings.Default.InitialCatalog;
            
            connectionStringTextBox.Text = Properties.Settings.Default.JamsazERPLiteConnectionString;
          
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(serverNameTextBox.Text))
                errorProvider1.SetError(serverNameTextBox, "نام سرور را وارد کنید");
            else if (string.IsNullOrEmpty(connectionStringTextBox.Text))
                errorProvider1.SetError(connectionStringTextBox, " را وارد کنید" + " connectionString " + "لطفا ");
            else
            {
                if (!manualCheckBox.Checked)
                {
                    Properties.Settings.Default.ServerName = serverNameTextBox.Text;
                    Properties.Settings.Default.InitialCatalog = catalogTextBox.Text;
                    Properties.Settings.Default.JamsazERPLiteConnectionString = "Data Source=" + serverNameTextBox.Text + ";Initial Catalog=" + catalogTextBox.Text + ";Integrated Security=True";
                    Jamsaz.PersonnlsApplication.BusinessObjects.Classes.ConnectionStringHelper.SaveConnectionString(connectionStringTextBox.Text);
                }
                else
                {
                    Properties.Settings.Default.JamsazERPLiteConnectionString = connectionStringTextBox.Text;
                    Jamsaz.PersonnlsApplication.BusinessObjects.Classes.ConnectionStringHelper.SaveConnectionString(connectionStringTextBox.Text);
                }
                
            //    op.CommonLinq.Classes.helper.ChangeConnectionString(connectionStringTextBox.Text);
                Properties.Settings.Default.Save();
                this.GetConnectionString = connectionStringTextBox.Text;
                this.DialogResult = DialogResult.OK;
            }
        }

        public string GetConnectionString { get; set; }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

      

        private void defaultConnectionStringRadioButton_CheckedChanged(object sender, EventArgs e)
        {
           
            if (defaultConnectionStringRadioButton.Checked)
            {
                serverNameTextBox.Text = "atlas";
                catalogTextBox.Text = "JamsazERPLite";
                Properties.Settings.Default.ServerName = "atlas";
                Properties.Settings.Default.InitialCatalog = "JamsazERPLite";
                connectionStringTextBox.Text = "Data Source=atlas;Initial Catalog=JamsazERPLite;Integrated Security=True";
                manualCheckBox.Checked = false;
            }
            if (setConnectionStringTehranRadioButton.Checked)
            {
                serverNameTextBox.Text = "aria\\sql2005";
                catalogTextBox.Text = "JamsazERPLiteTehran";

                Properties.Settings.Default.ServerName = "aria\\sql2005";
                Properties.Settings.Default.InitialCatalog = "JamsazERPLiteTehran";
                connectionStringTextBox.Text = "Data Source=aria\\sql2005;Initial Catalog=JamsazERPLiteTehran;Integrated Security=True";
                manualCheckBox.Checked = false;
            }
            if (setConnectionStringFactoryRadioButton.Checked)
            {
                serverNameTextBox.Text = "atlas";
                catalogTextBox.Text = "JamsazERPLite";

                Properties.Settings.Default.ServerName = "atlas";
                Properties.Settings.Default.InitialCatalog = "JamsazERPLite";
                connectionStringTextBox.Text = "Data Source=aria;Initial Catalog=JamsazERPLite;Integrated Security=True";
                manualCheckBox.Checked = false;
            }
            if (setAmeriRadioButton.Checked)
            {
                serverNameTextBox.Text = "atlas";
                catalogTextBox.Text = "JamsazERPLite";

                Properties.Settings.Default.ServerName = "atlas";
                Properties.Settings.Default.InitialCatalog = "JamsazERPLite";
                connectionStringTextBox.Text = "Data Source=atlas.Jamsaz.org;Initial Catalog=JamsazERPLite;User Id=Ameri;Password=321ameri#@!";
                manualCheckBox.Checked = true;

            }
        }

        private void testConnectionButton_Click(object sender, EventArgs e)
        {
            if (connectionStringTextBox.Text != string.Empty)
            {
                using (System.Data.Linq.DataContext d = new System.Data.Linq.DataContext(connectionStringTextBox.Text))
                {
                    try
                    {
                        d.ExecuteCommand("SELECT GETDATE()");
                        MessageBox.Show("اتصال به بانک اطلاعاتی با موفقیت برقرار شد", "تست اتصال به بانک",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    catch 
                    {
                        MessageBox.Show("اتصال به بانک اطلاعاتی برقرار نیست", "تست اتصال به بانک",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void serverNameTextBox_TextChanged(object sender, EventArgs e)
        {
            connectionStringTextBox.Text = "Data Source=" + serverNameTextBox.Text + ";Initial Catalog=" + catalogTextBox.Text + ";Integrated Security=True";
        }

     
      
    }
}
