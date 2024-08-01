using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jamsaz.PersonnlsApplication.Classes;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using System.Threading;
using Jamsaz.PersonnlsApplication.UI.DialogForms;
using Jamsaz.Common;


namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    public partial class PersonnelsListReportForm : BasePersianForm
    {
        public PersonnelsListReportForm()
        {
            InitializeComponent();
        }

        private JamsazERPLiteDataClassesDataContext db;

        private void PersonnelsListReportForm_Load(object sender, EventArgs e)
        {
          
        }

        private void PersonnelsListReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.reportViewer.LocalReport.ReleaseSandboxAppDomain();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            db = new JamsazERPLiteDataClassesDataContext();
            if (startDatePicker.SelectedDateTime == null || endDatePicker.SelectedDateTime == null)
                this.SelectPersonnelsResultBindingSource.DataSource = db.SelectPersonnels(null, null).ToList();
            else
                this.SelectPersonnelsResultBindingSource.DataSource = db.SelectPersonnels(startDatePicker.SelectedDateTime, endDatePicker.SelectedDateTime).ToList();

           

            this.reportViewer.RefreshReport();
        }
    }
}
