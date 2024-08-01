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
using Jamsaz.PersonnlsApplication.BusinessObjects.Definitions;
using Stimulsoft.Report.Viewer;

namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    public partial class GetPersonnelStatusReportForm : BasePersianForm
    {
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        private List<GetPersonnelStatusReportResult> List = new List<GetPersonnelStatusReportResult>();
        private List<GetPersonnelStatusReportResult> selectedList = new List<GetPersonnelStatusReportResult>();
        public GetPersonnelStatusReportForm()
        {
            InitializeComponent();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            selectedList.Clear();

            List = db.GetPersonnelStatusReport().ToList();

            if (employCheckBox.Checked)
                selectedList.AddRange(List.Where(c => c.PersonnelStatus == (int)PersonnelStatus.employe));
            if (specialCheckBox.Checked)
                selectedList.AddRange(List.Where(c => c.PersonnelStatus == (int)PersonnelStatus.Special));
            if (retiredCheckBox.Checked)
                selectedList.AddRange(List.Where(c => c.PersonnelStatus == (int)PersonnelStatus.Retired));
           
            var report = new Stimulsoft.Report.StiReport();


            //report.Load(@"D:\Report.mrt");
            report.Load(Properties.Resources.Report);
            report.Dictionary.Variables["TotalCount"].Value = selectedList.Count().ToString();
            report.Dictionary.Variables["CurrentDate"].Value = DateTime.Now.ToPersianDate();

            report.RegBusinessObject("items", selectedList.OrderBy(c => c.DepartmentChildName));
           
            report.Render();
            stiViewerControl1.PageViewMode = StiPageViewMode.SinglePage;
            stiViewerControl1.Report = report;



            stiViewerControl1.Show();
            //report.Design();
            //report.Show(true);
        }
    }
}
