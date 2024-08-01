using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Linq.Mapping;
using FarsiLibrary.Utils;
using System.Data.Linq;


using Jamsaz.PersonnlsApplication.Definitions;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.Classes;

namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class editPersonnelsEducationDialogForm : Form
    {
        int personnelEducationID;
        int personnelID;

        ActionForm formStatus = new Jamsaz.PersonnlsApplication.Definitions.ActionForm();
        JamsazERPLiteDataClassesDataContext db = new Jamsaz.PersonnlsApplication.BusinessObjects.Data.JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
        PersonnalsEducation personnelEducation = new PersonnalsEducation();
        List<Classes.AnyItemsForlist> itemStausStudys = new List<Classes.AnyItemsForlist>();
        public editPersonnelsEducationDialogForm(int PassPersonnelEducationID, int personnelID, ActionForm formStatus)
        {
            InitializeComponent();
            personnelEducationID = PassPersonnelEducationID;
            this.formStatus = formStatus;
            this.personnelID = personnelID;
        }

        private void frmEditPersonnelsEducation_Load(object sender, EventArgs e)
        {

            Classes.AnyItemsForlist itemStatusStudy1 = new AnyItemsForlist  {ID = 0,Name = "درحال تحصیل" };
            Classes.AnyItemsForlist itemStatusStudy2 = new AnyItemsForlist { ID = 1, Name = "فارغ التحصیل" };
            
            itemStausStudys.Add(itemStatusStudy1);
            itemStausStudys.Add(itemStatusStudy2);
            ItemsStatusStudyBindingSource.DataSource = itemStausStudys;
                
            if (formStatus == ActionForm.Edit)
            {
                personnelsEducationBindingSource.DataSource = db.PersonnalsEducations.Single(p => p.ID == personnelEducationID);
                personnelEducation = (PersonnalsEducation)personnelsEducationBindingSource.Current;
            }
            else
            {
                personnelEducation = (PersonnalsEducation)personnelsEducationBindingSource.AddNew();
                Personnel personnel = (Personnel)db.Personnels.Single(c => c.Id == this.personnelID);
                personnelEducation.Personnel = personnel;
         //       personnelEducation.PersonnelNumber = personnel.PersonnelNumber;

          //      personnelEducation.FullName = personnel.FirstName + " " + personnel.LastName;
                statusStudyingComboBox.SelectedIndex = 1;
            }
          
           

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            if (CheckHassError() != false)
            {
                personnelEducation.PersonnelID = this.personnelID;
                personnelsEducationBindingSource.EndEdit();
                ChangeSet changeSet = db.GetChangeSet();
                db.SubmitChanges();
                this.DialogResult = DialogResult.OK;
            }
            else
                errorProvider.SetError(saveButton, "لطفا تمام گزینه ها را پر کنید");

        }
        private void SelectMajorButton_Click(object sender, EventArgs e)
        {
            DialogForms.MajorsDialogForm majorsDialogForm = new MajorsDialogForm();
            if (majorsDialogForm.ShowDialog() == DialogResult.OK)
            {
                if (majorsDialogForm.SelectedMajor != null)
                {
                    personnelEducation.Major1 = db.Majors.Single(c => c.Id == majorsDialogForm.SelectedMajor.Id);
                    majorNameTextBox.Text = majorsDialogForm.SelectedMajor.Name;
                }
            }
        }

        private void SelectDegreeLevelButton_Click(object sender, EventArgs e)
        {
            DialogForms.UniversityDegreesDialogForm universityDegreesDialogForm = new UniversityDegreesDialogForm();
            if (universityDegreesDialogForm.ShowDialog() == DialogResult.OK)
            {
                if (universityDegreesDialogForm.SelectedUniversityDegree != null)
                {
                    personnelEducation.UniversityDegree = db.UniversityDegrees.Single(c => c.Id == universityDegreesDialogForm.SelectedUniversityDegree.Id);
                    degreeLevelTextBox.Text = universityDegreesDialogForm.SelectedUniversityDegree.Name;
                }
            }
        }

        private  bool CheckHassError()
        {
            if (string.IsNullOrEmpty(majorNameTextBox.Text))
                return false;
            else if (string.IsNullOrEmpty(degreeLevelTextBox.Text))
                return false;
            else if (string.IsNullOrEmpty(educationalOrganaizationNameTextBox.Text))
                return false;
            

            return true;
        }

    

    

    
    }
   
}
