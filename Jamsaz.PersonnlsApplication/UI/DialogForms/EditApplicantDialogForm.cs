using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.PersonnlsApplication.Definitions;
using System.Data.Linq;

namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class EditApplicantDialogForm : Jamsaz.Common.BasePersianForm
    {
        public EditApplicantDialogForm(int? applicantID,Definitions.ActionForm actionForm)
        {
            InitializeComponent();
            this.applicantID = applicantID;
            maritalStatusComboBox.ValueMember = "intValue";
            maritalStatusComboBox.DisplayMember = "Value";
           maritalStatusComboBox.DataSource = Jamsaz.PersonnlsApplication.Definitions.enumMaritualStatus.getItems();

           genderComboBox.ValueMember = "intValue";
           genderComboBox.DisplayMember = "Value";
           genderComboBox.DataSource = Jamsaz.PersonnlsApplication.Definitions.enumGender.getItems();

           statusComboBox.ValueMember = "intValue";
           statusComboBox.DisplayMember = "Value";
           statusComboBox.DataSource = Jamsaz.PersonnlsApplication.Definitions.enumeApplicantStatus.getItems();

            this.actionForm = actionForm;
        }
        JamsazERPLiteDataClassesDataContext db = new Jamsaz.PersonnlsApplication.BusinessObjects.Data.JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
        Applicant applicant = new Applicant();
        int? applicantID;
        Definitions.ActionForm actionForm = new Jamsaz.PersonnlsApplication.Definitions.ActionForm();
        private void EditApplicantDialogForm_Load(object sender, EventArgs e)
        {
            if (this.actionForm == ActionForm.Edit)
            {
                applicant = db.Applicants.Single(c => c.ID == this.applicantID);
                applicantBindingSource.DataSource = applicant;
            }
            else
            {
                applicant = (Applicant)applicantBindingSource.AddNew();
            }
            
        }
        private void selectMajorsButton_Click(object sender, EventArgs e)
        {
            DialogForms.MajorsDialogForm majorsDialogForm = new MajorsDialogForm();

            if (majorsDialogForm.ShowDialog() == DialogResult.OK)
            {

                if (majorsDialogForm.SelectedMajor == null)
                {
                    applicant.MajorId = null;
                    maritalStatusComboBox.Text = string.Empty;
                }
                else
                {
                    applicant.Major = db.Majors.Single(c => c.Id == majorsDialogForm.SelectedMajor.Id);
                    majorNameTextBox.Text = majorsDialogForm.SelectedMajor.Name;
                }

            }
        }

        private void selectMilitaryServiceStatusButton_Click(object sender, EventArgs e)
        {
            DialogForms.MilitaryServiceStatusDialogForm militaryServiceStatusDialogForm = new MilitaryServiceStatusDialogForm();
            if (militaryServiceStatusDialogForm.ShowDialog() == DialogResult.OK)
            {

                if (militaryServiceStatusDialogForm.SelectedMilitaryServiceStatus == null)
                {
                    applicant.MilitaryServiceStatusId = null;
                    militaryServiceStatusNameTextBox.Text = string.Empty;
                }
                else
                {
                    applicant.MilitaryServiceStatus = db.MilitaryServiceStatus.Single(c => c.Id == militaryServiceStatusDialogForm.SelectedMilitaryServiceStatus.Id);
                    militaryServiceStatusNameTextBox.Text = militaryServiceStatusDialogForm.SelectedMilitaryServiceStatus.Title;
                }
            }
        }

        private void selectUniversityDegreeButton_Click(object sender, EventArgs e)
        {
            DialogForms.UniversityDegreesDialogForm universityDegreesDialogForm = new UniversityDegreesDialogForm();

            if (universityDegreesDialogForm.ShowDialog() == DialogResult.OK)
            {
                if (universityDegreesDialogForm.SelectedUniversityDegree == null)
                {
                    applicant.UniversityDegreeId = null;
                    universityDegreeNameTextbox.Text = string.Empty;
                }
                else
                {
                    applicant.UniversityDegree = db.UniversityDegrees.Single(c=>c.Id == universityDegreesDialogForm.SelectedUniversityDegree.Id);
                    universityDegreeNameTextbox.Text = universityDegreesDialogForm.SelectedUniversityDegree.Name;
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (isValidControls())
            {
                applicantBindingSource.EndEdit();
                if(actionForm == ActionForm.Insert)
                db.Applicants.InsertOnSubmit(applicant);

                db.SubmitChanges();
                this.DialogResult = DialogResult.OK;
            }

        }
        private bool isValidControls()
        {
            errorProvider.Clear();
            if (string.IsNullOrEmpty(NameTextBox.Text))
            {
                errorProvider.SetError(NameTextBox, "ِلطفا نام  را وارد کنید");
                return false;
            }
            else if (string.IsNullOrEmpty(lastNameTextBox.Text))
            {
                errorProvider.SetError(lastNameTextBox, "ِلطفا نام خانوادگی را وارد کنید");
                return false;
            }
            else if (respectDateFaDatePicker.IsNull)
            {
                errorProvider.SetError(respectDateFaDatePicker,"لطفا تاریخ مراجعه را وارد کنید");
                return false;
            }
            else return true;
           
        }
        public override bool CloseForm()
        {
            try
            {
                ChangeSet changeSet = db.GetChangeSet();
                if (changeSet.Deletes.Count != 0 || changeSet.Inserts.Count != 0 || changeSet.Updates.Count != 0)
                    return false;

                return true;
            }
            catch
            {
                return true;
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
                cancelButton_Click(null, null);

            if (keyData == Keys.F5)
                saveButton_Click(null,null);
         
            return base.ProcessCmdKey(ref msg, keyData);
        }

        

    }
}
