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
namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    public partial class PerformanceReportForm : BasePersianForm
    {
        public PerformanceReportForm()
        {
            InitializeComponent();
        }
        public PerformancEvaluationMaster Master { get; set; }
        private readonly JamsazERPLiteDataClassesDataContext _db = new JamsazERPLiteDataClassesDataContext();
        private void PerformanceReportForm_Load(object sender, EventArgs e)
        {
            PerformancEvaluationMasterBindingSource.DataSource = Master;
         
            PerformancEvaluationDetailBindingSource.DataSource =
                _db.PerformancEvaluationDetails.Where(c => c.PerformancEvaluationMasterID == Master.ID)
                    .OrderBy(d => d.EvaluationIndex.CategoriesIndexEvaluationID);
            reportViewer1.RefreshReport();
        }
    }
}
