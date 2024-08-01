using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;

namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    public partial class PerformanceAllDepartmentListReportForm : BasePersianForm
    {
        public int StepId;
        public IList<PerformanceByDepartmentResult> Source;
        public PerformanceAllDepartmentListReportForm()
        {
            InitializeComponent();
        }
        private void PerformanceReportForm_Load(object sender, EventArgs e)
        {
            PerformanceAllDepartmentResultBindingSource.DataSource = Source;


            reportViewer1.RefreshReport();
        }

    }
}
