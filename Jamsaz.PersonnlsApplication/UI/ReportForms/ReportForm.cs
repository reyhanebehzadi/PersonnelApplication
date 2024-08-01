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
using Microsoft.Reporting.WinForms;

namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    public partial class ReportForm : BasePersianForm
    {
        public ReportForm()
        {
            InitializeComponent();
        }
        public OvertimeLicense OvertimeLicense { get; set; }
        public string PersianDate { get; set; }
        private void ReportForm_Load(object sender, EventArgs e)
        {
            OvertimeLicenseDetailBindingSource.DataSource = OvertimeLicense.OvertimeLicenseDetails;
            ReportParameter department = new ReportParameter("Department", OvertimeLicense.Department);
            ReportParameter date = new ReportParameter("Date", PersianDate);
            reportViewer1.LocalReport.SetParameters(new[] { department, date });
            this.reportViewer1.RefreshReport();
        }
    }
}
