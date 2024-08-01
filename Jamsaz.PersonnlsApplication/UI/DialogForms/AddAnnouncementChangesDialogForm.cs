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
    public partial class AddAnnouncementChangesDialogForm : BasePersianForm
    {
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        public FormStatus FormStatus { get; set; }
        public FiscalYear CurrentYear { get; set; }
        public AnnouncementChange AnnouncementChange { get; set; }

        public AddAnnouncementChangesDialogForm()
        {
            InitializeComponent();
        }

        private void selectPersonnelButton_Click(object sender, EventArgs e)
        {
            PersonnelListForm personnelListForm = new PersonnelListForm(db);
            if (personnelListForm.ShowDialog() == DialogResult.OK)
            {
                this.AnnouncementChange.Personnel = db.Personnels.SingleOrDefault(c => c.Id == personnelListForm.Personnel.Id);
            }
        }

        private void AddAnnouncementChangesDialogForm_Load(object sender, EventArgs e)
        {
            changeTypeBindingSource.DataSource = db.ChangeTypes;
            if (FormStatus == FormStatus.Add)
            {
                AnnouncementChange = new AnnouncementChange()
                {
                    FiscalYear = db.FiscalYears.SingleOrDefault(c => c.ID == (CurrentYear.ID)),
                    Code = db.AnnouncementChanges.Any(c => c.FiscalYearID == CurrentYear.ID) ? db.AnnouncementChanges.Where(c => c.FiscalYearID == CurrentYear.ID).Max(p => p.Code) + 1 : 1,
                    DateTime=DateTime.Now
                };
            }
            else
            {
                AnnouncementChange = db.AnnouncementChanges.FirstOrDefault(p => p.ID == AnnouncementChange.ID);
                changeTypeComboBox.SelectedItem = AnnouncementChange.ChangeType;
            }
            announcementChangeBindingSource.DataSource = AnnouncementChange;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Helper.Confirm("آیا مایل به ثبت اطلاعات هستید؟"))
            {

                AnnouncementChange.ChangeType = db.ChangeTypes.SingleOrDefault(c=>c.ID==((ChangeType)changeTypeComboBox.SelectedItem).ID);
                if (FormStatus == FormStatus.Add)

                    db.AnnouncementChanges.InsertOnSubmit(AnnouncementChange);


                db.SubmitChanges();
            }
            DialogResult = DialogResult.OK;
        }
    }
}
