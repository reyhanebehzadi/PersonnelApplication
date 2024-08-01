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
namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    public partial class GetPaySanavatReportForm : BasePersianForm
    {
        public GetPaySanavatReportForm()
        {
            InitializeComponent();
        }
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();

        private void GetPaySanavatReportForm_Load(object sender, EventArgs e)
        {
            GetPaySanavatReportResultBindingSource.DataSource = db.GetPaySanavatReport().OrderBy(c => Convert.ToInt32(c.PersonnelNumber));
            this.reportViewer1.RefreshReport();
        }

        private void allRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            GetPaySanavatReportResultBindingSource.DataSource = db.GetPaySanavatReport().OrderBy(c=> Convert.ToInt32( c.PersonnelNumber));
            this.reportViewer1.RefreshReport();
        }

        private void payRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            GetPaySanavatReportResultBindingSource.DataSource = db.GetPaySanavatReport().Where(c=>c.Payment>0).OrderBy(c => Convert.ToInt32(c.PersonnelNumber));
            this.reportViewer1.RefreshReport();
        }

        private void dontPayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            GetPaySanavatReportResultBindingSource.DataSource = db.GetPaySanavatReport().Where(c=>c.Payment==0).OrderBy(c => Convert.ToInt32(c.PersonnelNumber));
            this.reportViewer1.RefreshReport();
        }
    }
}
