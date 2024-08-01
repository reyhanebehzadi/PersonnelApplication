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
using Microsoft.Reporting.WinForms;

namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    public partial class GetCountReportForm : BasePersianForm
    {
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        public GetCountReportForm()
        {
            InitializeComponent();
        }

        private void GetCountReportForm_Load(object sender, EventArgs e)
        {

           
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            if (StartDateDatePicker.SelectedDateTime>= endDatePicker.SelectedDateTime)
            {
                Helper.ShowMessage("تاریخ را به درستی وارد کنید");
                return;
            }

            ReportParameter start = new ReportParameter("Start", StartDateDatePicker.SelectedDateTime.Value.Date.ToPersianDate());
            ReportParameter end = new ReportParameter("End", endDatePicker.SelectedDateTime.Value.Date.ToPersianDate());
            reportViewer1.LocalReport.SetParameters(new[] { start, end });

            GetCountPersonelReportResultBindingSource.DataSource = db.GetCountPersonelReport(StartDateDatePicker.SelectedDateTime, endDatePicker.SelectedDateTime);
            GetInputPersonelResultBindingSource.DataSource = db.GetInputPersonel(StartDateDatePicker.SelectedDateTime, endDatePicker.SelectedDateTime);
            GetExitPersonelResultBindingSource.DataSource = db.GetExitPersonel(StartDateDatePicker.SelectedDateTime, endDatePicker.SelectedDateTime);
            this.reportViewer1.RefreshReport();
        }
    }
}
