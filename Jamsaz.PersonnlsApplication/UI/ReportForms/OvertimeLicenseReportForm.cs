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
using Jamsaz.PersonnlsApplication.UI.DialogForms;
using MD.PersianDateTime;

namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    public partial class OvertimeLicenseReportForm : BasePersianForm
    {
        public OvertimeLicenseReportForm()
        {
            InitializeComponent();
        }
        private JamsazERPLiteDataClassesDataContext db;
        public int personnelID;
        List<OvertimeLicense> result = new List<OvertimeLicense>();
        private void OvertimeLicenseReportForm_Load(object sender, EventArgs e)
        {
            this.DatePicker.SelectedDateTime = endDatePicker.SelectedDateTime = DateTime.Now;
            LoadData();
        }

        private void LoadData()
        {
            db = new JamsazERPLiteDataClassesDataContext();

            if (personnelID > 0)
            {
                var query = from i in db.OvertimeLicenses
                            join j in db.OvertimeLicenseDetails
                            on i.ID equals j.OvertimeLicenseID
                            where i.Date >= DatePicker.SelectedDateTime.Value.Date && i.Date <= endDatePicker.SelectedDateTime.Value.Date && j.PersonnelID == personnelID
                            select i;
                result = null;
                result = query.ToList();


            }


            else
            {
                var query = from i in db.OvertimeLicenses
                            where i.Date >= DatePicker.SelectedDateTime.Value.Date && i.Date <= endDatePicker.SelectedDateTime.Value.Date
                            select i;

                result = null;
                result = query.ToList();
            }



            overtimeLicenseBindingSource.DataSource = result;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void overtimeLicenseDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                OvertimeLicense current = (OvertimeLicense)overtimeLicenseBindingSource.Current;
                if (current != null)
                {


                    if (current.AdministrativeStatus != true)
                        if (Helper.Confirm(" آیا مایل به تایید مرخصی هستید؟"))
                        {
                            current.AdministrativeStatus = true;
                            db.SubmitChanges();
                        }
                }

            }
            LoadData();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            OvertimeLicense current = (OvertimeLicense)overtimeLicenseBindingSource.Current;
            if (current != null)
            {
                PersianDateTime persianDateTime = new PersianDateTime(current.Date);
                ReportForm form = new ReportForm()
                {
                    OvertimeLicense = current,
                    PersianDate = persianDateTime.ToLongDateString()
                };
                form.ShowDialog();
            }
        }

        private void selectPersonButton_Click(object sender, EventArgs e)
        {
            PersonnelListForm personnelListForm = new PersonnelListForm(db) { IsActive=true};
            if (personnelListForm.ShowDialog() == DialogResult.OK)
            {
                personnelID = personnelListForm.Personnel.Id;
                this.personelNumberTextBox.Text = personnelListForm.Personnel.PersonnelNumber;
                this.fullNameTextBox.Text = string.Format("{0} {1}", personnelListForm.Personnel.FirstName, personnelListForm.Personnel.LastName);
            }


        }

        private void overtimeLicenseBindingSource_PositionChanged(object sender, EventArgs e)
        {
            OvertimeLicense current = (OvertimeLicense)overtimeLicenseBindingSource.Current;
            if (current != null)
            {
                overtimeLicenseDetailsBindingSource.DataSource = db.OvertimeLicenseDetails.Where(c => c.OvertimeLicenseID == current.ID);
            }
        }
    }
}
