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
using System.Data.Linq;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class ApplicantsForm : Jamsaz.Common.BasePersianForm
    {
        public ApplicantsForm()
        {
            InitializeComponent();
       
            //Jamsaz.Common.UserAuthenticationManager.SetAccessContorls.ModifyControl(this);
        }

        Major major;
        JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
        
        private void searchButton_Click(object sender, EventArgs e)
        {
            int? majorid =null;

            if (major != null)
                majorid = major.Id;

            applicantBindingSource.DataSource = db.Applicants_AdvancedSearch(nameTextbox.Text, lastNameTextBox.Text, issueNoLabelTextBox.Text, fatherNameTextBox.Text,majorid, selfRegistrationCheckbox.Checked);
            countPersonnelTextBox.Text = applicantBindingSource.Count.ToString();
        }

        private void clearControlsButton_Click(object sender, EventArgs e)
        {
            nameTextbox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            fatherNameTextBox.Text = string.Empty;
            issueNoLabelTextBox.Text = string.Empty;
            majorNameTextBox.Text = string.Empty ;
            major = new Major();
            countPersonnelTextBox.Text = applicantBindingSource.Count.ToString();
        }

        private void editApplicantButton_Click(object sender, EventArgs e)
        {
            //Applicant applicant = (Applicant)applicantBindingSource.Current;
            int applicantID = ((Applicants_AdvancedSearchResult)this.applicantBindingSource.Current).ID;
            if (applicantID != null)
            {
                DialogForms.EditApplicantDialogForm editApplicantDialogForm = new Jamsaz.PersonnlsApplication.UI.DialogForms.EditApplicantDialogForm(applicantID,Jamsaz.PersonnlsApplication.Definitions.ActionForm.Edit);
                editApplicantDialogForm.ShowDialog();
            }
        }

        private void insertApplicantButton_Click(object sender, EventArgs e)
        {
                DialogForms.EditApplicantDialogForm editApplicantDialogForm = new Jamsaz.PersonnlsApplication.UI.DialogForms.EditApplicantDialogForm(0, Jamsaz.PersonnlsApplication.Definitions.ActionForm.Insert);
                editApplicantDialogForm.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //Applicant applicant = (Applicant)applicantBindingSource.Current;
            Applicant applicant = db.Applicants.Single(c => c.ID == ((Applicants_AdvancedSearchResult)applicantBindingSource.Current).ID);

            if (applicant != null)
            {
                if (Helper.Confirm("آیا مطمئن هستید؟"))
                {
                    applicantBindingSource.RemoveCurrent();
                    db.Applicants.DeleteOnSubmit(applicant);
                    db.SubmitChanges();
                    countPersonnelTextBox.Text = applicantBindingSource.Count.ToString();
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                db.SubmitChanges();
                Helper.ShowMessage("تغییرات ثبت شد");
            }
            catch (Exception exp)
            {
                Helper.ShowMessage(exp.Message);

            }
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

        private void ApplicantsForm_Load(object sender, EventArgs e)
        {

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {


            Keys currentKey = keyData;
            if (currentKey == Keys.F2 )
                editApplicantButton_Click(null, null);

            if (currentKey == Keys.Enter && this.ActiveControl.GetType() == typeof(TextBox))
                searchButton_Click(null, null);

            if (currentKey == Keys.F5)
                SaveButton_Click(null, null);


            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void applicantDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editApplicantButton_Click(null, null);
        }

        private void importToTablePersonnelsButton_Click(object sender, EventArgs e)
        {
            //Applicant applicant = (Applicant)applicantBindingSource.Current;
            Applicant applicant = db.Applicants.Single(c => c.ID == ((Applicants_AdvancedSearchResult)applicantBindingSource.Current).ID);
            if (applicant != null)
            {
                if (Helper.Confirm("آیا مایل به اضافه کردن کارجو به لیست پرسنل هستید؟"))
                {
                    Personnel personnel = new Personnel();
                    personnel.ApplicantID = applicant.ID;
                    personnel.FirstName = applicant.Name;
                    personnel.LastName = applicant.LastName;
                    personnel.BrithDate = applicant.BrithDate;
                    personnel.IssueNo = applicant.IssueNo;
                    personnel.MajorId = applicant.MajorId;
                    personnel.MilitaryServiceStatusId = applicant.MilitaryServiceStatusId;
                    personnel.MobileNumber = applicant.MobileNumber;
                    personnel.Tel = applicant.Tel;
                    personnel.UniversityDegreeId = applicant.UniversityDegreeId;
                    personnel.FatherName = applicant.FatherName;
                    personnel.Gender = applicant.Gender;
                    db.Personnels.InsertOnSubmit(personnel);
                    db.SubmitChanges();
                    Helper.ShowMessageBox("ثبت شد", "ثبت اطلاعات", FarsiLibrary.Win.Enums.FarsiMessageBoxExIcon.Information);
                }
            }
        }

        private void majorSelectButton_Click(object sender, EventArgs e)
        {
            DialogForms.MajorsDialogForm majorsDialogForm = new Jamsaz.PersonnlsApplication.UI.DialogForms.MajorsDialogForm();
            if(majorsDialogForm.ShowDialog() == DialogResult.OK)
            {
                major = new Major();
                major = majorsDialogForm.SelectedMajor;
                majorNameTextBox.Text = major.Name;
            }
        }
        
    }
}
