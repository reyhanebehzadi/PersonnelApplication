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

namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    public partial class EndDateOfPersonnelContractReportForm : BasePersianForm
    {
        public EndDateOfPersonnelContractReportForm()
        {
            InitializeComponent();
        }

        private JamsazERPLiteDataClassesDataContext db;
        private void EndDateOfPersonnelContractReportForm_Load(object sender, EventArgs e)
        {

        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            db = new JamsazERPLiteDataClassesDataContext();
            if (startDatePicker.SelectedDateTime == null || endDatePicker.SelectedDateTime == null)
                this.EndDateOfPersonnelContractResultBindingSource.DataSource = db.EndDateOfPersonnelContract(null, null).ToList();
            else
                this.EndDateOfPersonnelContractResultBindingSource.DataSource = db.EndDateOfPersonnelContract(startDatePicker.SelectedDateTime, endDatePicker.SelectedDateTime).ToList();



            this.reportViewer.RefreshReport();
        }

        private void EndDateOfPersonnelContractReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.reportViewer.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
