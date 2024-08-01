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
    public partial class AddPunishmentDialogForm : BasePersianForm
    {
        public AddPunishmentDialogForm()
        {
            InitializeComponent();
        }

        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();

        public BusinessObjects.Definitions.FormStatus FormStatus { get; set; }

        public BusinessObjects.Data.Punishment Punishment { get; set; }

        public BusinessObjects.Data.Personnel Personnel { get; set; }

        private void AddPunishmentDialogForm_Load(object sender, EventArgs e)
        {
            if (FormStatus == FormStatus.Add)
            {
                Punishment = new Punishment() { Personnel = db.Personnels.Single(c => c.Id == Personnel.Id) ,FiscalYearID=User.FiscalYearID};
            }
            else
            {
                Punishment = db.Punishments.SingleOrDefault(c => c.ID == this.Punishment.ID);
            }
            punishmentBindingSource.DataSource = Punishment;
        }

        private void selectApplicantButton_Click(object sender, EventArgs e)
        {
            //bool isActive = true;
            bool isActive = false;
            PersonnelListForm personnelListForm = new PersonnelListForm(db){IsActive = isActive};
            if (personnelListForm.ShowDialog() == DialogResult.OK)
            {
                Punishment.Personnel1 = db.Personnels.SingleOrDefault(c => c.Id == personnelListForm.Personnel.Id);
            }
        }

        private void selectConfirmorButton_Click(object sender, EventArgs e)
        {
           // bool isActive = true;
            bool isActive = false;
            PersonnelListForm personnelListForm = new PersonnelListForm(db) { IsActive = isActive };
            if (personnelListForm.ShowDialog() == DialogResult.OK)
            {
                Punishment.Personnel2 = db.Personnels.SingleOrDefault(c => c.Id == personnelListForm.Personnel.Id);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Punishment.Date == null)
            {
                Helper.Error("تاریخ را مشخص نمایید");
                return;
            }

            if (FormStatus == FormStatus.Add)
            {
                db.Punishments.InsertOnSubmit(Punishment);
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
    }
}
