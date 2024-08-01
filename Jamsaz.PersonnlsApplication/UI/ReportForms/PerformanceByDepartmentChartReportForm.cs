using System;
using System.Collections;
using System.Collections.Generic;
using Jamsaz.Common;
using Microsoft.Reporting.WinForms;

namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    public partial class PerformanceByDepartmentChartReportForm : BasePersianForm
    {
        public PerformanceByDepartmentChartReportForm()
        {
            InitializeComponent();
        }

        public string DepartmentName;
        public IList Source;
        public double Average { get; set; }
        public int Sum { get; set; }
        public double Variance { get; set; }
        public double Enheraf { get; set; }

        private void PerformanceReportForm_Load(object sender, EventArgs e)
        {

            PerformanceByDepartmentResultBindingSource.DataSource = Source;
            reportViewer1.LocalReport.SetParameters(new List<ReportParameter>
            {
                new ReportParameter("DepartmentName", DepartmentName),
                new ReportParameter("Average", Average.ToString("N")),
                new ReportParameter("Sum", Sum.ToString("N")),
                new ReportParameter("Variance", Variance.ToString("N")),
                new ReportParameter("Enheraf", Enheraf.ToString("N")),
            });

            reportViewer1.RefreshReport();
        }

        
    }
}
