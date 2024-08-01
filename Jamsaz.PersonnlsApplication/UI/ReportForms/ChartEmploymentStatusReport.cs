using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Microsoft.Reporting.WinForms;

namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    public partial class ChartEmploymentStatusReport : BasePersianForm
    {
        public ChartEmploymentStatusReport()
        {
            InitializeComponent();
        }
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        private void ChartEmploymentStatusReport_Load(object sender, EventArgs e)
        {

        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            ReportParameter year = new ReportParameter("Year",yearUpDown.Value.ToString());
            ReportParameter date = new ReportParameter("Date",DateTime.Now.Date.ToPersianDate());
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { year,date });
            ChartEmploymentStatusResultBindingSource.DataSource = db.ChartEmploymentStatus(Convert.ToInt32(yearUpDown.Value));
            reportViewer1.RefreshReport();
        }
    }
}
