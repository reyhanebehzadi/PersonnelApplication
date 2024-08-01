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
    public partial class AddAccidentDialogForm : BasePersianForm
    {
        public AddAccidentDialogForm()
        {
            InitializeComponent();
        }
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        public Accident Accident { get; set; }
        public FormStatus FormStatus { get; set; }
        private void selectPersonnelButton_Click(object sender, EventArgs e)
        {
            PersonnelListForm personnelListForm = new PersonnelListForm(db);
            if (personnelListForm.ShowDialog() == DialogResult.OK)
            {
                this.Accident.Personnel = personnelListForm.Personnel;
            }
        }

        private void AddAccidentDialogForm_Load(object sender, EventArgs e)
        {
            if (FormStatus == FormStatus.Add)
            {
                this.Accident = new Accident()
                {
                    FiscalYearID = User.FiscalYearID,
                    Code = db.Accidents.Any(c => c.FiscalYearID == User.FiscalYearID) ? db.Accidents.Where(c => c.FiscalYearID == User.FiscalYearID).Max(d => d.Code) + 1 : 1,
                    Date=DateTime.Now
                    
                };

            }
            else
            {
                Accident = db.Accidents.SingleOrDefault(c => c.ID == Accident.ID);

            }
            accidentBindingSource.DataSource = Accident;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Helper.Confirm("آیا مایل به ثبت اطلاعات هستید؟"))
            {
                if (FormStatus == FormStatus.Add)

                    db.Accidents.InsertOnSubmit(Accident);

                db.SubmitChanges();

            }
            DialogResult = DialogResult.OK;
        }

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))

            {
                e.Handled = true;
            }
        }
    }
}
