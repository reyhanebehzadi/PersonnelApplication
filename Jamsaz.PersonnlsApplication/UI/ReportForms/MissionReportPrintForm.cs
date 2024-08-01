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
    public partial class MissionReportPrintForm : BasePersianForm
    {
        private List<PersonnelMissionReportResult> Result ;
        public MissionReportPrintForm(List<PersonnelMissionReportResult> value)
        {
            InitializeComponent();
            this.Result = value;
        }

        private void MissionReportPrintForm_Load(object sender, EventArgs e)
        {
            PersonnelMissionReportResultBindingSource.DataSource = Result;
            reportViewer1.RefreshReport();
        }
    }
}
