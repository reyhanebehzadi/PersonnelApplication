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
using Jamsaz.PersonnlsApplication.BusinessObjects.Definitions;

namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class AddEncouragementDialogForm : BasePersianForm
    {
        public AddEncouragementDialogForm()
        {
            InitializeComponent();
        }

        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        public FormStatus FormStatus { get; set; }
        public Encouragement Encouragement { get; set; }

        private void AddEncouragementDialogForm_Load(object sender, EventArgs e)
        {
            if (FormStatus == FormStatus.Add)
            {
                Encouragement = new Encouragement() { Personnel = db.Personnels.Single(c => c.Id == Personnel.Id) ,FiscalYearID=User.FiscalYearID};
            }
            else
            {
                Encouragement = db.Encouragements.SingleOrDefault(c => c.ID == this.Encouragement.ID);
            }
            encouragementBindingSource.DataSource = Encouragement;
        }

        private void selectApplicantButton_Click(object sender, EventArgs e)
        {
            // bool isActive = true;
            bool isActive = false;
            PersonnelListForm personnelListForm = new PersonnelListForm(db) { IsActive = isActive };
            if (personnelListForm.ShowDialog() == DialogResult.OK)
            {
                Encouragement.Personnel1 = db.Personnels.SingleOrDefault(c => c.Id == personnelListForm.Personnel.Id);
            }
        }

        private void selectConfirmorButton_Click(object sender, EventArgs e)
        {
            // bool isActive = true;
            bool isActive = false;
            PersonnelListForm personnelListForm = new PersonnelListForm(db) { IsActive = isActive };
            if (personnelListForm.ShowDialog() == DialogResult.OK)
            {
                Encouragement.Personnel2 = db.Personnels.SingleOrDefault(c => c.Id == personnelListForm.Personnel.Id);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Encouragement.Date == null)
            {
                Helper.Error("تاریخ را مشخص نمایید");
                return;
            }

            if (FormStatus == FormStatus.Add)
            {
                
                db.Encouragements.InsertOnSubmit(Encouragement);
                db.SubmitChanges();
            }
            else
            {
                db.SubmitChanges();
            }

            this.DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public Personnel Personnel { get; set; }
    }
}
