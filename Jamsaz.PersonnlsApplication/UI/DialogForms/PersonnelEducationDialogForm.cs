using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.Common;


namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class PersonnelEducationDialogForm : Form
    {
        int personnelID;
        public PersonnelEducationDialogForm(int personnelID)
        {
            InitializeComponent();
            this.personnelID = personnelID;
        }

        JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
        List<PersonnalsEducation> personnalEducations = new List<PersonnalsEducation>();

        private void frmPersonnelEducation_Load(object sender, EventArgs e)
        {
            Personnel personnel = db.Personnels.Single(c => c.Id == personnelID);
            titlePersonnelNumberLabel.Text = personnel.PersonnelNumber;
            titlePersonnelFullNameLabel.Text = personnel.FirstName + " " + personnel.LastName;
            SubQuery();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            PersonnalsEducation personnelEducation = (PersonnalsEducation)personnelsEducationBindingSource.Current;
            if (personnelEducation != null)
            {
                DialogForms.editPersonnelsEducationDialogForm editPersonnelsEducationDialogForm = new editPersonnelsEducationDialogForm(personnelEducation.ID, personnelID, Jamsaz.PersonnlsApplication.Definitions.ActionForm.Edit);
                if (editPersonnelsEducationDialogForm.ShowDialog() == DialogResult.OK)
                    SubQuery();
            }


        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            PersonnalsEducation personnelEducation = (PersonnalsEducation)personnelsEducationBindingSource.Current;
          
                DialogForms.editPersonnelsEducationDialogForm editPersonnelsEducationDialogForm = new editPersonnelsEducationDialogForm(0, personnelID, Jamsaz.PersonnlsApplication.Definitions.ActionForm.Insert);

                if (editPersonnelsEducationDialogForm.ShowDialog() == DialogResult.OK)
                    SubQuery();

            

        }

        private void SubQuery()
        {
            db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
            personnelsEducationBindingSource.DataSource = db.PersonnalsEducations.Where(c => c.PersonnelID == personnelID);
        }

        private void deletedButton_Click(object sender, EventArgs e)
        {
            PersonnalsEducation personnalsEducation = (PersonnalsEducation)personnelsEducationBindingSource.Current;

            if (personnalsEducation != null)
            {
                if (Helper.Confirm("آیا مطمئن هستید؟"))
                {
                    personnelsEducationBindingSource.RemoveCurrent();
                    db.SubmitChanges();
                }
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void returnButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
