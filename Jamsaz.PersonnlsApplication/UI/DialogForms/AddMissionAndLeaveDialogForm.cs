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
using Jamsaz.PersonnlsApplication.BusinessObjects.Definitions;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class AddMissionAndLeaveDialogForm : BasePersianForm
    {
        public AddMissionAndLeaveDialogForm()
        {
            InitializeComponent();
        }
        public FormStatus FormStatus { get; set; }

        public DepartmentApprovalCategoryPersonnel DepartmentApprovalCategoryPersonnel { get; set; }


        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        public Personnel Personnel { get; set; }
        public Personnel ReplacementPersonnel { get; set; }
        public Personnel ReplacementPersonnel2 { get; set; }


        private void AddMissionAndLeaveDialogForm_Load(object sender, EventArgs e)
        {
            if (this.FormStatus == FormStatus.Edit)
            {
                DepartmentApprovalCategoryPersonnel = db.DepartmentApprovalCategoryPersonnels.SingleOrDefault(c => c.ID == DepartmentApprovalCategoryPersonnel.ID);
                this.Personnel = this.DepartmentApprovalCategoryPersonnel.Personnel;
                this.personnelTextBox.Text = string.Format("{0} {1}", this.Personnel.FirstName, this.Personnel.LastName);

                this.ReplacementPersonnel = this.DepartmentApprovalCategoryPersonnel.Personnel2;
                this.replacementTextBox.Text = this.ReplacementPersonnel != null ? string.Format("{0} {1}", this.ReplacementPersonnel.FirstName, this.ReplacementPersonnel.LastName) : "";

                this.ReplacementPersonnel2 = this.DepartmentApprovalCategoryPersonnel.Personnel1;
                this.replacementPersonnel2.Text = this.ReplacementPersonnel2 != null ? string.Format("{0} {1}", this.ReplacementPersonnel2.FirstName, this.ReplacementPersonnel2.LastName) : "";

            }
            else
            {
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
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

        private void deleteFirstPersonButton_Click(object sender, EventArgs e)
        {
            ReplacementPersonnel = null;
            this.replacementTextBox.Text = string.Empty;
        }

        private void deleteSecondPersonButton_Click(object sender, EventArgs e)
        {
            ReplacementPersonnel2 = null;
            this.replacementPersonnel2.Text = string.Empty;
        }
    }
}
