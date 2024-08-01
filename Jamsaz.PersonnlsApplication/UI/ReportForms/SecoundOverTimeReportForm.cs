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
    public partial class SecoundOverTimeReportForm : BasePersianForm
    {
        public SecoundOverTimeReportForm()
        {
            InitializeComponent();
        }
        public List<GetOvertimeReportResult> Result { get; set; }
        public List<GetOvertimeTotalReportResult> TotalResult { get; set; }
        public MonthTable Current { get; set; }

        public double LastMonth { get; set; }

        private void SecoundOverTimeReportForm_Load(object sender, EventArgs e)
        {
            
            TotalResult.Remove(TotalResult.SingleOrDefault(c => c.DepartmentID == null));
            var report = new Stimulsoft.Report.StiReport();
            TotalResult.Add(new GetOvertimeTotalReportResult()
            {
                Department ="جمع کل",
                Total=TotalResult.Sum(p=>p.Total)
            });

            //report.Load(@"D:\secounOverTimeReport.mrt");
            report.Load(Properties.Resources.secounOverTimeReport);
            report.Dictionary.Variables["Month"].Value = Current.Title;
            report.Dictionary.Variables["ReportDate"].Value = DateTime.Now.ToShortPersianDate();
            
            report.Dictionary.Variables["LastMonth"].Value = LastMonth.ToString("N0");
            report.Dictionary.Variables["Count"].Value = TotalResult.Count().ToString();

            report.RegBusinessObject("items", Result.OrderBy(c=> c.DepartmentChildOrginalId).OrderBy(d=>d.DepartmentID));
            report.RegBusinessObject("TotalList", TotalResult);
            report.Render();
            stiViewerControl1.PageViewMode = StiPageViewMode.SinglePage;
            stiViewerControl1.Report = report;



            stiViewerControl1.Show();
            //report.Design();
            //report.Show(true);
        }
    }
}
