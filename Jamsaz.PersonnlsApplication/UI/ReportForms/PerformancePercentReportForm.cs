using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    public partial class PerformancePercentReportForm : BasePersianForm
    {
        public PerformancePercentReportForm()
        {
            InitializeComponent();
        }

        public IList Source { get; set; }

        private void PerformanceReportForm_Load(object sender, EventArgs e)
        {
            PerformancPercentBindingSource.DataSource =  Source;
            reportViewer1.RefreshReport();
        }
    }
}
