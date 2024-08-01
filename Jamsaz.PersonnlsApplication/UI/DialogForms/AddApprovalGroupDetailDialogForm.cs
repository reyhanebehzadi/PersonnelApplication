using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.PersonnlsApplication.BusinessObjects.Definitions;

namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class AddApprovalGroupDetailDialogForm : BasePersianForm
    {

        public FormStatus FormStatus { get; set; }
        public ApprovalGroupDetail ApprovalGroupDetail { get; set; }
        public bool Mission { get; set; }
        public MissionApprovalGroupDetail MissionApprovalGroupDetail { get; set; }

        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        public Personnel Personnel { get; set; }
        public Personnel ReplacementPersonnel { get; set; }
        public Personnel ReplacementPersonnel2 { get; set; }

        public AddApprovalGroupDetailDialogForm()
        {
            InitializeComponent();
        }

        private void AddApprovalGroupDetailDialogForm_Load(object sender, EventArgs e)
        {
            if (this.FormStatus == FormStatus.Edit && Mission == false)
            {
                ApprovalGroupDetail = db.ApprovalGroupDetails.SingleOrDefault(c => c.ID == ApprovalGroupDetail.ID);
                this.Personnel = this.ApprovalGroupDetail.Personnel;
                this.personnelTextBox.Text = string.Format("{0} {1}", this.Personnel.FirstName, this.Personnel.LastName);

                this.ReplacementPersonnel = this.ApprovalGroupDetail.Personnel1;
                this.replacementTextBox.Text = this.ReplacementPersonnel != null ? string.Format("{0} {1}", this.ReplacementPersonnel.FirstName, this.ReplacementPersonnel.LastName) : "";

                this.ReplacementPersonnel2 = this.ApprovalGroupDetail.Personnel2;
                this.replacementPersonnel2.Text = this.ReplacementPersonnel2 != null ? string.Format("{0} {1}", this.ReplacementPersonnel2.FirstName, this.ReplacementPersonnel2.LastName) : "";

            }
            else
            {
                MissionApprovalGroupDetail = db.MissionApprovalGroupDetails.SingleOrDefault(c => c.ID == MissionApprovalGroupDetail.ID);
                this.Personnel = this.MissionApprovalGroupDetail.Personnel;
                this.personnelTextBox.Text = string.Format("{0} {1}", this.Personnel.FirstName, this.Personnel.LastName);

                this.ReplacementPersonnel = this.MissionApprovalGroupDetail.Personnel1;
                this.replacementTextBox.Text = this.ReplacementPersonnel != null ? string.Format("{0} {1}", this.ReplacementPersonnel.FirstName, this.ReplacementPersonnel.LastName) : "";

                this.ReplacementPersonnel2 = this.MissionApprovalGroupDetail.Personnel2;
                this.replacementPersonnel2.Text = this.ReplacementPersonnel2 != null ? string.Format("{0} {1}", this.ReplacementPersonnel2.FirstName, this.ReplacementPersonnel2.LastName) : "";
            }
        }

        private void selectPersonnelButton_Click(object sender, EventArgs e)
        {
            PersonnelListForm personnelListForm = new PersonnelListForm(db) { IsActive = true };
            if (personnelListForm.ShowDialog() == DialogResult.OK)
            {
                Personnel = personnelListForm.Personnel;
                this.personnelTextBox.Text = string.Format("{0} {1}", this.Personnel.FirstName, this.Personnel.LastName);
            }
        }

        private void selectreplacementButton_Click(object sender, EventArgs e)
        {
            PersonnelListForm personnelListForm = new PersonnelListForm(db) { IsActive = true };
            if (personnelListForm.ShowDialog() == DialogResult.OK)
            {
                ReplacementPersonnel = personnelListForm.Personnel;
                this.replacementTextBox.Text = string.Format("{0} {1}", this.ReplacementPersonnel.FirstName, this.ReplacementPersonnel.LastName);
            }
        }

        private void deleteFirstPersonButton_Click(object sender, EventArgs e)
        {
            ReplacementPersonnel = null;
            this.replacementTextBox.Text = string.Empty;
        }

        private void selectReplacement2Button_Click(object sender, EventArgs e)
        {
            PersonnelListForm personnelListForm = new PersonnelListForm(db) { IsActive = true };
            if (personnelListForm.ShowDialog() == DialogResult.OK)
            {
                ReplacementPersonnel2 = personnelListForm.Personnel;
                this.replacementPersonnel2.Text = string.Format("{0} {1}", this.ReplacementPersonnel2.FirstName, this.ReplacementPersonnel2.LastName);
            }
        }

        private void deleteSecondPersonButton_Click(object sender, EventArgs e)
        {
            ReplacementPersonnel2 = null;
            this.replacementPersonnel2.Text = string.Empty;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
