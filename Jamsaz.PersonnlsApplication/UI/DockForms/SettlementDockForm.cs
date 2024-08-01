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
using Jamsaz.PersonnlsApplication.UI.DialogForms;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.PersonnlsApplication.BusinessObjects.Definitions;
namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class SettlementDockForm : BasePersianForm
    {
        public SettlementDockForm()
        {
            InitializeComponent();
        }

        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        private int PersonnelID;
        private void selectPersonnelButton_Click(object sender, EventArgs e)
        {
            PersonnelListForm personnelListForm = new PersonnelListForm(db = db) { IsActive = false };
            if (personnelListForm.ShowDialog() == DialogResult.OK)
            {
                PersonnelID = personnelListForm.Personnel.Id;
                personnelNameTextBox.Text = string.Format("{0} {1}", personnelListForm.Personnel.FirstName, personnelListForm.Personnel.LastName);
            }

            if (PersonnelID > 0)
            {
                settlementBindingSource.DataSource = db.Settlements.Where(c => c.PersonnelID == PersonnelID);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Settlement current = (Settlement)settlementBindingSource.Current;
            if (current != null)

                if (Helper.Confirm("آیا مایل به حذف اطلاعات هستید؟"))
                {

                    db.Settlements.DeleteOnSubmit(current);
                    db.SubmitChanges();
                    db = new JamsazERPLiteDataClassesDataContext();
                    settlementBindingSource.DataSource = db.Settlements.Where(c => c.PersonnelID == PersonnelID);
                }

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Settlement current = (Settlement)settlementBindingSource.Current;
            if (current != null)
            {
                SettlementDialogForm settlementDialogForm = new SettlementDialogForm()
                {
                    FormStatus = FormStatus.Edit,
                    Personnel = current.Personnel,
                    Settlement=current

                };

                if (settlementDialogForm.ShowDialog() == DialogResult.OK)
                {
                    db = new JamsazERPLiteDataClassesDataContext();
                    settlementBindingSource.DataSource = db.Settlements.Where(c => c.PersonnelID == PersonnelID);
                }
            }


        }
    }
}
