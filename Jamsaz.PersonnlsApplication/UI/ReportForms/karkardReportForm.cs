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

namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    public partial class karkardReportForm : BasePersianForm
    {
        public karkardReportForm()
        {
            InitializeComponent();
        }
        public Personnel selectedPersonnel { get; set; }
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        private void selectPersonelButton_Click(object sender, EventArgs e)
        {
            PersonnelListForm personnelListForm = new PersonnelListForm(db) { IsActive = false, AllPersonnel = true };

            if (personnelListForm.ShowDialog() == DialogResult.OK)
            {
                this.selectedPersonnel = personnelListForm.Personnel;
                personelNumberTextBox.Text = personnelListForm.Personnel.PersonnelNumber;
                personnelNameTextBox.Text = personnelListForm.Personnel.FullName;
            }
        }

        private void karkardReportForm_Load(object sender, EventArgs e)
        {
            if (selectedPersonnel != null)
            {
                personelNumberTextBox.Text = selectedPersonnel.PersonnelNumber;
                personnelNameTextBox.Text = selectedPersonnel.FullName;
                reportButton_Click(null, null);
            }

        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            if (selectedPersonnel!=null)
            {
                EidRegistrationBindingSource.DataSource = db.EidRegistrations.Where(c => c.PersonnelID == selectedPersonnel.Id).OrderBy(p=>p.FiscalYearID);
                GetSanavatReportResultBindingSource.DataSource = db.GetSanavatReport(selectedPersonnel.Id);
                this.reportViewer1.RefreshReport();
            }
            
        }
    }
}
