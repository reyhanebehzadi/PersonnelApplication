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
    public partial class AddEidRegistrationDialogForm : BasePersianForm
    {
        public AddEidRegistrationDialogForm()
        {
            InitializeComponent();
        }
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        public FormStatus FormStatus { get; set; }
        public EidRegistration EidRegistration { get; set; }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void AddEidRegistrationDialogForm_Load(object sender, EventArgs e)
        {

            //dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            fiscalYearBindingSource.DataSource = db.FiscalYears;
            fiscalyearComboBox.SelectedItem = db.FiscalYears.SingleOrDefault(c => c.Status == 2);

            if (FormStatus == FormStatus.Add)
            {
                fiscalyearComboBox.Enabled = true;
                selectButton.Enabled = true;

                EidRegistration = new EidRegistration();

            }
            else
            {
                fiscalyearComboBox.Enabled = false;
                selectButton.Enabled = false;

                EidRegistration = db.EidRegistrations.SingleOrDefault(c => c.ID == EidRegistration.ID);
                FullNameTextBox.Text = this.EidRegistration.FullName;
                personnelNumberTextBox.Text = this.EidRegistration.PersonnelNumber;
                fiscalyearComboBox.SelectedValue = this.EidRegistration.FiscalYearID;

            }
            eidRegistrationBindingSource.DataSource = EidRegistration;
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            PersonnelListForm personnelListForm = new PersonnelListForm(db) { AllPersonnel = true };
            if (personnelListForm.ShowDialog() == DialogResult.OK)
            {
                this.EidRegistration.Personnel = personnelListForm.Personnel;
                FullNameTextBox.Text = personnelListForm.Personnel.FullName;
                personnelNumberTextBox.Text = personnelListForm.Personnel.PersonnelNumber;

            }

        }

        private void numberOfDayTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }


        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.EidRegistration.FiscalYear = (FiscalYear)fiscalYearBindingSource.Current;
            if (FormStatus == FormStatus.Add)
                if (db.EidRegistrations.Any(c => c.PersonnelID == this.EidRegistration.PersonnelID && c.FiscalYearID == this.EidRegistration.FiscalYearID))
                {
                    Helper.ShowMessage("امکان ثبت رکورد تکراری وجود ندارد");
                    return;
                }


            if (Helper.Confirm("آیا مایل به ثبت اطلاعات هستید؟"))
                if (FormStatus == FormStatus.Add)

                    db.EidRegistrations.InsertOnSubmit(this.EidRegistration);

            db.SubmitChanges();
            DialogResult = DialogResult.OK;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 || e.ColumnIndex == 1 || e.ColumnIndex == 2 || e.ColumnIndex == 3 || e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 6 || e.ColumnIndex == 7
                || e.ColumnIndex == 8 || e.ColumnIndex == 9 || e.ColumnIndex == 10 || e.ColumnIndex == 11)
                this.EidRegistration.Total = this.EidRegistration.M1.GetValueOrDefault()   + this.EidRegistration.M2.GetValueOrDefault() + this.EidRegistration.M3.GetValueOrDefault() + this.EidRegistration.M4.GetValueOrDefault() + this.EidRegistration.M5.GetValueOrDefault() +
                  this.EidRegistration.M6.GetValueOrDefault() + this.EidRegistration.M7.GetValueOrDefault() + this.EidRegistration.M8.GetValueOrDefault() + this.EidRegistration.M9.GetValueOrDefault() + this.EidRegistration.M10.GetValueOrDefault() + this.EidRegistration.M11.GetValueOrDefault() + this.EidRegistration.M12.GetValueOrDefault();
        }
    }
}
