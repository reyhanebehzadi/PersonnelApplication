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
    public partial class FirstOvertimeReportForm : BasePersianForm
    {
        public FirstOvertimeReportForm()
        {
            InitializeComponent();
        }
        public List<GetOvertimeReportResult> Result { get; set; }
        public MonthTable Current { get; set; }

        private void FirstOvertimeReportForm_Load(object sender, EventArgs e)
        {
           

            var report = new Stimulsoft.Report.StiReport();


            //report.Load(@"D:\FirstOverTimeReport.mrt");

            report.Load(Properties.Resources.FirstOverTimeReport);



            report.RegBusinessObject("items", Result.OrderBy(c => c.DepartmentChildOrginalId).OrderBy(d => d.DepartmentID));//Result.OrderBy(p=>p.DepartmentID)
            report.Dictionary.Variables["Month"].Value = Current.Title;
            report.Dictionary.Variables["ReportDate"].Value = DateTime.Now.ToShortPersianDate();
            report.Render();
            stiViewerControl1.PageViewMode = StiPageViewMode.SinglePage;
            stiViewerControl1.Report = report;



            stiViewerControl1.Show();
            //report.Design();
            //report.Show(true);
        }
    }
}
