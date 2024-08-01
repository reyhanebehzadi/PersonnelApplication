using System;
using System.Collections;
using System.Linq;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Microsoft.Reporting.WinForms;

namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    public partial class PerformanceByDepartmentReportForm : BasePersianForm
    {
        public string DepartmentName;
        public IList Source;
        public PerformanceByDepartmentReportForm()
        {
            InitializeComponent();
        }
        public PerformancEvaluationMaster Master { get; set; }
        
        private void PerformanceReportForm_Load(object sender, EventArgs e)
        {
            PerformanceByDepartmentResultBindingSource.DataSource = Source;
            reportViewer1.LocalReport.SetParameters(new ReportParameter("DepartmentName", DepartmentName));

            reportViewer1.RefreshReport();
        }

    }
}
