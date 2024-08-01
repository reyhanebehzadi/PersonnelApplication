using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.Common;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class PersonnelsListForAssignForm : Jamsaz.Common.BasePersianForm
    {
        public PersonnelsListForAssignForm()
        {
            InitializeComponent();
          //  MessageBox.Show(Properties.Settings.Default.JamsazERPLiteConnectionString);
        }

        Jamsaz.PersonnlsApplication.BusinessObjects.Data.JamsazERPLiteDataClassesDataContext db = new Jamsaz.PersonnlsApplication.BusinessObjects.Data.JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);

        List<Personnels_FullSearchAdvanced1Result> personnelsList = new List<Personnels_FullSearchAdvanced1Result>();

        List<Personnels_FullSearchAdvanced1Result> selectionPersonnels = new List<Personnels_FullSearchAdvanced1Result>();

        public List<Personnels_FullSearchAdvanced1Result> GetPersonnels { get; set; }
        
        public List<int> HassPersonnles { get; set; }
        
        private void PersonnelsListForAssignForm_Load(object sender, EventArgs e)
        {
            //personnelsList = db.vwMainPersonnely_SearchAdvanced(" "," ",
            //  Helper.GetInt(personnelNumberTextBox.Text), string.Empty,
            //   string.Empty, string.Empty, 1, "1900/01/01", "3000/01/01", "1900/01/01",
               //    "3000/01/01", "1900/01/01", "3000/01/01", "1900/01/01", "3000/01/01").ToList();
            db = new Jamsaz.PersonnlsApplication.BusinessObjects.Data.JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
            
            //personnelsList = db.vwPersonnels_FullSearchAdvanced(" "," ",Helper.GetInt(personnelNumberTextBox.Text)).ToList();
            personnelsList = db.Personnels_FullSearchAdvanced1(" "," ",Helper.GetInt(personnelNumberTextBox.Text)).ToList();
         
            sourcePersonnelsBindingSource.DataSource = personnelsList.Where(c => !HassPersonnles.Contains(c.Id));
            selecedPersonnelsBindingSource.DataSource = selectionPersonnels;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (selecedPersonnelsBindingSource.Count != 0)
            {
                selectionPersonnels = new List<Personnels_FullSearchAdvanced1Result>();
                foreach (Personnels_FullSearchAdvanced1Result resultsearchAdvenced in selecedPersonnelsBindingSource.List)
                {
                    selectionPersonnels.Add(resultsearchAdvenced);
                }

                this.GetPersonnels = selectionPersonnels;
                this.DialogResult = DialogResult.OK;
            }
            else
                Helper.ShowMessage("پرسنلی انتخاب نشده");
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (sourcePersonnelsBindingSource.Current != null)
            {
                Personnels_FullSearchAdvanced1Result currentPersonnel = (Personnels_FullSearchAdvanced1Result)sourcePersonnelsBindingSource.Current;
                selecedPersonnelsBindingSource.Add(currentPersonnel);
                sourcePersonnelsBindingSource.RemoveCurrent();
                counterSelectedPersonnlesLabel.Text = "تعداد انتخاب شده:" + " " + selecedPersonnelsBindingSource.Count.ToString();
                selecedPersonnelsBindingSource.EndEdit();
            }

        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            if (selecedPersonnelsBindingSource.Current != null)
            {
                Personnels_FullSearchAdvanced1Result currentPersonnle = (Personnels_FullSearchAdvanced1Result)selecedPersonnelsBindingSource.Current;
                sourcePersonnelsBindingSource.Add(currentPersonnle);
                selecedPersonnelsBindingSource.RemoveCurrent();
                counterSelectedPersonnlesLabel.Text = "تعداد انتخاب شده:" + " " + selecedPersonnelsBindingSource.Count.ToString();
                sourcePersonnelsBindingSource.EndEdit();
            }
        }

        private void clearSelectionDataGrid_Click(object sender, EventArgs e)
        {
            selecedPersonnelsBindingSource.Clear();
            selecedPersonnelsBindingSource.EndEdit();
            counterSelectedPersonnlesLabel.Text = "تعداد انتخاب شده:" + " " + selecedPersonnelsBindingSource.Count.ToString();
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            personnelsList = db.Personnels_FullSearchAdvanced1(firstNameTextBox.Text, lastNameTextBox.Text,
            Helper.GetInt(personnelNumberTextBox.Text)).ToList();

            selectionPersonnels = new List<Personnels_FullSearchAdvanced1Result>();
            
            foreach (Personnels_FullSearchAdvanced1Result resultsearchAdvenced in selecedPersonnelsBindingSource.List)
            {
                selectionPersonnels.Add(resultsearchAdvenced);
            }
            sourcePersonnelsBindingSource.DataSource = personnelsList.Where(c => !selectionPersonnels.Select(d=>d.Id).Contains(c.Id) && !HassPersonnles.Contains(c.Id));

           
                
        }

        private void personnelNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                searchButton_Click(null, null);
            
            if (e.KeyChar == (char)Keys.Back)
                clearControlsButton_Click(null, null);
        }

        private void clearControlsButton_Click(object sender, EventArgs e)
        {
            personnelNumberTextBox.Text = string.Empty;
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            searchButton_Click(null, null);
        }
    }
}
