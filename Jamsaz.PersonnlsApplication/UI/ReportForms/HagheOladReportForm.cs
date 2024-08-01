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
    public partial class HagheOladReportForm : BasePersianForm
    {
        public HagheOladReportForm()
        {
            InitializeComponent();
        }
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        private void HagheOladReportForm_Load(object sender, EventArgs e)
        {



        }

        private void ageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))

            {
                e.Handled = true;
            }

        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            List<HagheOladReportResult> list = new List<HagheOladReportResult>();

            if (string.IsNullOrEmpty(ageTextBox.Text) && UniversityStudentCheckBox.Checked == false)

                list = db.HagheOladReport(null, null).ToList();
            else
                if (string.IsNullOrEmpty(ageTextBox.Text) && UniversityStudentCheckBox.Checked == true)
                list = db.HagheOladReport(null, true).ToList();
            else
                if (!string.IsNullOrEmpty(ageTextBox.Text) && UniversityStudentCheckBox.Checked == false)
                list = db.HagheOladReport(Convert.ToInt32(ageTextBox.Text), null).ToList();
            else
                 if (!string.IsNullOrEmpty(ageTextBox.Text) && UniversityStudentCheckBox.Checked == true)
                list = db.HagheOladReport(Convert.ToInt32(ageTextBox.Text), true).ToList();


            var report = new Stimulsoft.Report.StiReport();


            //report.Load(@"D:\PersonnelChildReport.mrt");
            report.Load(Properties.Resources.PersonnelChildReport);

            report.Dictionary.Variables["ReportDate"].Value = DateTime.Now.ToPersianDate();
            //report.Dictionary.Variables["toDate"].Value = faDatePickerEndDate.SelectedDateTime.Value.Date.ToPersianDate();

            report.RegBusinessObject("items", list);
            report.Render();
            stiViewerControl1.PageViewMode = StiPageViewMode.SinglePage;
            stiViewerControl1.Report = report;



            //stiViewerControl1.Show();
            //report.Design();
            report.Show(true);

        }
    }
}
