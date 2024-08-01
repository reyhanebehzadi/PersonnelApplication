using System;
using System.Linq;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Microsoft.Reporting.WinForms;

namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    public partial class PerformanceAllDepartmentReportForm : BasePersianForm
    {
        public int StepId;
        public string DepartmentName;
        public PerformanceAllDepartmentReportForm()
        {
            InitializeComponent();
        }
        public PerformancEvaluationMaster Master { get; set; }
        private readonly JamsazERPLiteDataClassesDataContext _db = new JamsazERPLiteDataClassesDataContext();
        private void PerformanceReportForm_Load(object sender, EventArgs e)
        {
            PerformanceAllDepartmentResultBindingSource.DataSource = _db.PerformanceAllDepartment(User.FiscalYearID, StepId, true).ToList();
            reportViewer1.LocalReport.SetParameters(new ReportParameter("DepartmentName", DepartmentName));

            reportViewer1.RefreshReport();
        }

    }
}
