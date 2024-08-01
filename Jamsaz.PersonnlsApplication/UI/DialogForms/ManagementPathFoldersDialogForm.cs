using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class ManagementPathFoldersDialogForm : Form
    {
        public ManagementPathFoldersDialogForm()
        {
            InitializeComponent();
        }
       
        private void ManagePathFoldersForm_Load(object sender, EventArgs e)
        {
        pathPersonnelImageTextBox.Text = Properties.Settings.Default.PathPersonnelsImage;
        pathTemplateTextBox.Text = Properties.Settings.Default.PathTemplate;
        }

        private void selectFolderPathImageButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                pathPersonnelImageTextBox.Text = folderBrowserDialog1.SelectedPath+"\\";
            }
        }

        private void selectFolderPathTemplateButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                pathTemplateTextBox.Text = folderBrowserDialog1.SelectedPath+"\\";
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (String.IsNullOrEmpty(pathPersonnelImageTextBox.Text))
                errorProvider1.SetError(pathPersonnelImageTextBox, "لطفا مسیر عکس را وارد کنید");
            else if (string.IsNullOrEmpty(pathTemplateTextBox.Text))
                errorProvider1.SetError(pathTemplateTextBox, "لطفا مسیر قالب گزارش ها را وارد کنید");
            else
            {
                Properties.Settings.Default.PathPersonnelsImage = pathPersonnelImageTextBox.Text;
               // op.CommonLinq.Classes.helper.ChangePathFolders(1, pathPersonnelImageTextBox.Text);
               // Properties.Settings.Default.JamsazERPLiteConnectionString = pathTemplateTextBox.Text;
           //     op.CommonLinq.Classes.helper.ChangePathFolders(2, pathTemplateTextBox.Text);
                Properties.Settings.Default.Save();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
