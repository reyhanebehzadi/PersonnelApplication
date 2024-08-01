using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class EditWebApplicantDialogForm : BasePersianForm
    {
        public EditWebApplicantDialogForm()
        {
            InitializeComponent();

            genderComboBox.ValueMember = "intValue";
            genderComboBox.DisplayMember = "Value";
            genderComboBox.DataSource = Jamsaz.PersonnlsApplication.Definitions.enumGender.getItems();

            maritalStatusComboBox.ValueMember = "intValue";
            maritalStatusComboBox.DisplayMember = "Value";
            maritalStatusComboBox.DataSource = Jamsaz.PersonnlsApplication.Definitions.enumMaritualStatus.getItems();

            statusComboBox.ValueMember = "intValue";
            statusComboBox.DisplayMember = "Value";
            statusComboBox.DataSource = Jamsaz.PersonnlsApplication.Definitions.enumeApplicantStatus.getItems();
        }
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        public Applicant Applicant { get; set; }
        private void EditWebApplicantDialogForm_Load(object sender, EventArgs e)
        {
            applicantBindingSource.DataSource = db.Applicants.SingleOrDefault(c => c.ID == Applicant.ID);

            
            genderComboBox.SelectedValue = Applicant.Gender;

            
            if (Applicant.MaritalStatus != null)
            {
                maritalStatusComboBox.SelectedValue = Applicant.MaritalStatus;
            }
            else
                maritalStatusComboBox.SelectedIndex = 1;

           
        }

        private void selectMilitaryServiceStatusButton_Click(object sender, EventArgs e)
        {
            DialogForms.MilitaryServiceStatusDialogForm militaryServiceStatusDialogForm = new MilitaryServiceStatusDialogForm();
            if (militaryServiceStatusDialogForm.ShowDialog() == DialogResult.OK)
            {

                if (militaryServiceStatusDialogForm.SelectedMilitaryServiceStatus == null)
                {
                    Applicant.MilitaryServiceStatusId = null;
                    militaryServiceStatusNameTextBox.Text = string.Empty;
                }
                else
                {
                    Applicant.MilitaryServiceStatus = db.MilitaryServiceStatus.Single(c => c.Id == militaryServiceStatusDialogForm.SelectedMilitaryServiceStatus.Id);
                    militaryServiceStatusNameTextBox.Text = militaryServiceStatusDialogForm.SelectedMilitaryServiceStatus.Title;
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (Helper.Confirm("آیا مایل به ثبت تغییرات می باشید؟")) 
            {
                db.SubmitChanges();
            }
            DialogResult = DialogResult.OK;
        }
    }
}
