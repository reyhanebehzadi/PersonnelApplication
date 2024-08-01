using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using Jamsaz.Application.Common.UI.DialogForm;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.PersonnlsApplication.UI.ReportForms;
using Jamsaz.PersonnlsApplication.UI.DialogForms;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class WebApplicantsDockForm : BasePersianForm
    {
        public WebApplicantsDockForm()
        {
            InitializeComponent();
        }

        private JamsazERPLiteDataClassesDataContext db;

        private void WebApplicantsDockForm_Load(object sender, EventArgs e)
        {
            LoadDate();
        }

        private void LoadDate()
        {
            try
            {
                db = new JamsazERPLiteDataClassesDataContext();
                genderComboBox.SelectedIndex = 2;
                universitydegreeComboBox.SelectedItem = null;
                filterApplicantResultBindingSource.DataSource = db.FilterApplicant(null, null, null, null, null, null ,null);
            }
            catch (Exception ex)
            {

                ex.Message.ToString();
            }


        }

        private void printbutton_Click(object sender, EventArgs e)
        {
            WebApplicantReportForm reportForm = new WebApplicantReportForm()
            {
                Applicant = db.Applicants.SingleOrDefault(c => c.ID == ((FilterApplicantResult)filterApplicantResultBindingSource.Current).ID)
            };

            reportForm.ShowDialog();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

      

       
        private void searchButton_Click(object sender, EventArgs e)
        {
            int? gender;
            if (genderComboBox.SelectedIndex == 2)
                gender = null;
            else
                gender = genderComboBox.SelectedIndex + 1;

            int? degreeLevel;
            if (universitydegreeComboBox.SelectedIndex != -1)

                degreeLevel = universitydegreeComboBox.SelectedIndex + 1;
            else
                degreeLevel = null;

            majoredTextBox.Text = majoredTextBox.Text.Replace("ي", "ی");
            majoredTextBox.Text = majoredTextBox.Text.Replace("ك", "ک");
            filterApplicantResultBindingSource.DataSource = db.FilterApplicant(nameTextBox.Text != "" ? nameTextBox.Text : null,
                                                                                familyTextBox.Text != "" ? familyTextBox.Text : null,
                                                                                gender,
                                                                                degreeLevel,
                                                                                majoredTextBox.Text != "" ? majoredTextBox.Text : null,
                                                                                registerDatePicker.SelectedDateTime != null? registerDatePicker.SelectedDateTime : null,
                                                                                skillTextBox.Text != "" ? skillTextBox.Text : null);
            if (filterApplicantResultBindingSource.Count==0)
            {
                applicantsEducationsBindingSource.DataSource=null;
                applicantSkillsBindingSource.DataSource = null;
                applicantsWorkExperiencesBindingSource.DataSource = null;
                applicantCoursesBindingSource.DataSource = null;

            }
           

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            FilterApplicantResult current = (FilterApplicantResult)filterApplicantResultBindingSource.Current;
            if (current != null)
            {
                EditWebApplicantDialogForm editWebApplicantDialogForm = new EditWebApplicantDialogForm() { Applicant = db.Applicants.SingleOrDefault(c=>c.ID==current.ID) };
                if (editWebApplicantDialogForm.ShowDialog() == DialogResult.OK)
                {
                    db = new JamsazERPLiteDataClassesDataContext();
                    applicantBindingSource.DataSource = db.Applicants.Where(c => c.SelfRegistration == true);
                    applicantDataGridView.Refresh();
                }
            }

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
         
            nameTextBox.Text = "";
            familyTextBox.Text = "";
            majoredTextBox.Text = "";
            registerDatePicker.SelectedDateTime = null;
            skillTextBox.Text = "";
            LoadDate();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            FilterApplicantResult current = (FilterApplicantResult)filterApplicantResultBindingSource.Current;
            if (current != null)
            {
                if (Helper.Confirm("آیا مایل به حذف اطلاعات هستید؟"))
                {
                    db.Applicants.DeleteOnSubmit(db.Applicants.SingleOrDefault(c=>c.ID==current.ID));
                    db.SubmitChanges();
                    searchButton_Click(null, null);
                    applicantDataGridView.Refresh();
                }
            }

        }

       

        private void filterApplicantResultBindingSource_PositionChanged(object sender, EventArgs e)
        {
            FilterApplicantResult curret = (FilterApplicantResult)filterApplicantResultBindingSource.Current;
           
            if (curret != null)
            {
                applicantsEducationsBindingSource.DataSource = db.ApplicantsEducations.Where(c => c.ApplicantID == curret.ID);
                applicantSkillsBindingSource.DataSource = db.ApplicantSkills.Where(c => c.ApplicantID == curret.ID);
                applicantsWorkExperiencesBindingSource.DataSource = db.ApplicantsWorkExperiences.Where(c => c.ApplicantID == curret.ID);
                applicantCoursesBindingSource.DataSource = db.ApplicantCourses.Where(c => c.ApplicantID == curret.ID);

            }
           

        }

        private void applicantDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            filterApplicantResultBindingSource_PositionChanged(sender,e);
        }

        private void nameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                searchButton_Click(null,null);
            }
        }

        private void familyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchButton_Click(null, null);
            }
        }

        private void majoredTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchButton_Click(null, null);
            }
        }

        private void skillTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchButton_Click(null, null);
            }
        }
    }
}
