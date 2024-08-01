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
    public partial class LeaveReportForm : BasePersianForm
    {
        private List<LeaveRequestsReportResult> Result;
        public LeaveReportForm(List<LeaveRequestsReportResult> value)
        {
            InitializeComponent();
            this.Result = value;
        }

        private void LeaveReportForm_Load(object sender, EventArgs e)
        {
            LeaveRequestsReportResultBindingSource.DataSource = Result.OrderBy(c => int.Parse(c.PersonnelNumbler));
            reportViewer1.RefreshReport();
        }
    }
}
