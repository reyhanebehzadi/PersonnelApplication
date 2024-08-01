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
using Stimulsoft.Report.Viewer;

namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    public partial class KarkardServicesReportForm : BasePersianForm
    {
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        public KarkardServicesReportForm()
        {
            InitializeComponent();
        }

        private void KarkardServicesReportForm_Load(object sender, EventArgs e)
        {
            monthBindingSource.DataSource = db.MonthTables.ToList();
           
           
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            if (!(monthBindingSource.Current is MonthTable selected)) return;

            List<GetReportServiceKarkardResult> selectedList = db.GetReportServiceKarkard(User.FiscalYearID, selected.ID).ToList();

          

            var report = new Stimulsoft.Report.StiReport();

            FiscalYear current = db.FiscalYears.SingleOrDefault(c => c.ID == User.FiscalYearID);
            //report.Load(@"D:\ServiceReport.mrt");
            report.Load(Properties.Resources.ServiceReport);
            report.Dictionary.Variables["Month"].Value = selected.Title;
            report.Dictionary.Variables["Year"].Value = current.ID > 35 ? $"14{current.Title}" : "13{current.Title}";

            report.RegBusinessObject("items", selectedList);

            report.Render();
            stiViewerControl1.PageViewMode = StiPageViewMode.SinglePage;
            stiViewerControl1.Report = report;



            stiViewerControl1.Show();
            //report.Design();
            //report.Show(true);
        }
    }
}
