using System;
using System.Linq;
using System.Windows.Forms;
using Jamsaz.Common;
using Jamsaz.Common.Classes;
using Jamsaz.Common.UserAuthenticationManager;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class PersonnelSearcherDockForm : BasePersianForm
    {
        public PersonnelSearcherDockForm()
        {
            InitializeComponent();
        }

        JamsazERPLiteDataClassesDataContext db ;
       
        private void MainForm_Load(object sender, EventArgs e)
        {
            db = new JamsazERPLiteDataClassesDataContext();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void personnelNumberTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private void Search()
        {
            if (!string.IsNullOrEmpty(personnelNumberTextBox.Text))
            {
                Personnel personnel =db.Personnels.SingleOrDefault(c=>c.PersonnelNumber==personnelNumberTextBox.Text.Trim());
                if (personnel != null)
                    personnelBindingSource.DataSource = personnel;
                else
                    personnelBindingSource.DataSource = db.Personnels.Where(c => c.FirstName.Contains(firstNameTextBox.Text) && c.LastName.Contains(lastNameTextBox.Text)).OrderBy(c=>Convert.ToInt32(c.PersonnelNumber));
            }
            else
            {
                personnelBindingSource.DataSource = db.Personnels.Where(c => c.FirstName.Contains(firstNameTextBox.Text) && c.LastName.Contains(lastNameTextBox.Text)).OrderBy(c => Convert.ToInt32(c.PersonnelNumber));
            }
        }

       

       
    }
}
