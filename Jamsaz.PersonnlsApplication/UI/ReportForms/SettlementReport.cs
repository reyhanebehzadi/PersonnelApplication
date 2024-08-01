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
    public partial class SettlementReport : BasePersianForm
    {
        public SettlementReport()
        {
            InitializeComponent();
        }

        public List<GetSettlementReportResult> Result { get; set; }
        public string From { get; set; }
        public string End { get; set; }
        private void SettlementReport_Load(object sender, EventArgs e)
        {
            ReportParameter current = new ReportParameter("CurrentDate", Helper.GetPersianDate(DateTime.Now.Date));
            ReportParameter from = new ReportParameter("FromDate", From);
            ReportParameter to = new ReportParameter("EndDate", End);
            reportViewer1.LocalReport.SetParameters(new[] { current, from, to });
            GetSettlementReportResultBindingSource.DataSource = Result;
            this.reportViewer1.RefreshReport();
        }
    }
}
