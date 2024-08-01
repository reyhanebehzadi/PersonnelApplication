using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Jamsaz.Common;
using Microsoft.Reporting.WinForms;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;

namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    public partial class WithoutOvertimePersonnelReportForm : BasePersianForm
    {
        public WithoutOvertimePersonnelReportForm()
        {
            InitializeComponent();
        }

        public int ItemTakeoutOrderID { get; set; }
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();

        private void WithoutOvertimePersonnelReportForm_Load(object sender, EventArgs e)
        {
            this.SelectPersonnelWithoutOvertimeResultBindingSource.DataSource =
                db.SelectPersonnelWithoutOvertime();
            this.reportViewer1.RefreshReport();
            
        }

        private void WithoutOvertimePersonnelReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
