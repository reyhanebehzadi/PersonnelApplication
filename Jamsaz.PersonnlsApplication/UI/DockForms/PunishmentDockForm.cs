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
using Jamsaz.PersonnlsApplication.UI.DialogForms;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class PunishmentDockForm : BasePersianForm
    {
        public PunishmentDockForm()
        {
            InitializeComponent();
        }

        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();

        private void PunishmentDockForm_Load(object sender, EventArgs e)
        {
            personnelBindingSource.DataSource = db.Personnels.Where(c => c.IsActive == true).OrderBy(d => Convert.ToInt32(d.PersonnelNumber));
        }

       
        private void personnelTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (personnelTextBox.Text != string.Empty)
                if (e.KeyChar == (Char)Keys.Enter)
                    personnelBindingSource.DataSource = db.Personnels.Where(c => c.FirstName.Contains(personnelTextBox.Text) || c.LastName.Contains(personnelTextBox.Text) || c.PersonnelNumber.Contains(personnelTextBox.Text)).OrderBy(d => Convert.ToInt32(d.PersonnelNumber)); ;

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            personnelBindingSource.DataSource = db.Personnels.Where(c => c.FirstName.Contains(personnelTextBox.Text) || c.LastName.Contains(personnelTextBox.Text) || c.PersonnelNumber.Contains(personnelTextBox.Text)).OrderBy(d => Convert.ToInt32(d.PersonnelNumber)); ;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            personnelTextBox.Text = string.Empty;
            personnelBindingSource.DataSource = db.Personnels.Where(c => c.IsActive == true).OrderBy(d => Convert.ToInt32(d.PersonnelNumber));
        }

        private void personnelBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Personnel personnel = (Personnel)personnelBindingSource.Current;

            punishmentBindingSource.DataSource = db.Punishments.Where(c => c.PersonnelID == personnel.Id);
        }

        private void personnelBindingSource_PositionChanged(object sender, EventArgs e)
        {
            personnelBindingSource_CurrentChanged(null, null);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Personnel personnel = (Personnel)personnelBindingSource.Current;
            if (personnel != null)
            {
                AddPunishmentDialogForm addPunishmentDialogForm = new AddPunishmentDialogForm() { FormStatus = FormStatus.Add, Personnel = personnel };

                if (addPunishmentDialogForm.ShowDialog() == DialogResult.OK)
                {
                    db = new JamsazERPLiteDataClassesDataContext();
                    punishmentBindingSource.DataSource = db.Punishments.Where(c => c.PersonnelID == personnel.Id).ToList();
                    punishmentDataGridView.Refresh();
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Personnel personnel = (Personnel)personnelBindingSource.Current;
            if (personnel != null)
            {
                Punishment punishment = (Punishment)punishmentBindingSource.Current;
                if (punishment != null)
                {
                    AddPunishmentDialogForm addPunishmentDialogForm = new AddPunishmentDialogForm()
                    {
                        FormStatus = FormStatus.Edit,
                        Punishment = punishment,
                        Personnel = personnel
                    };

                    if (addPunishmentDialogForm.ShowDialog() == DialogResult.OK)
                    {
                        db = new JamsazERPLiteDataClassesDataContext();

                        punishmentBindingSource.DataSource = db.Punishments.Where(c => c.PersonnelID == personnel.Id).ToList();
                        punishmentDataGridView.Refresh();
                    }
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Personnel personnel = (Personnel)personnelBindingSource.Current;
            if (personnel != null)
            {
                Punishment punishment = (Punishment)punishmentBindingSource.Current;
                if (punishment != null)
                {
                    if (Helper.Confirm("آیا مایل به حذف رکورد جاری هستید؟"))
                    {
                        db.Punishments.DeleteOnSubmit(punishment);
                        db.SubmitChanges();

                        db = new JamsazERPLiteDataClassesDataContext();
                        punishmentBindingSource.DataSource = db.Punishments.Where(c => c.PersonnelID == personnel.Id).ToList();

                    }


                }
            }
        }
    }
}
