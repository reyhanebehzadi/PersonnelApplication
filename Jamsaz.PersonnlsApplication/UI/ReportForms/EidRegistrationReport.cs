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
    public partial class EidRegistrationReport : BasePersianForm
    {
        public EidRegistrationReport()
        {
            InitializeComponent();
        }
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        public int fiscalyearID { get; set; }
        private void EidRegistrationReport_Load(object sender, EventArgs e)
        {
            GetKarkardResultBindingSource.DataSource = db.GetKarkard(fiscalyearID);
            ReportParameter year = new ReportParameter("Year", db.FiscalYears.SingleOrDefault(c=>c.ID==fiscalyearID).Title);
           
            reportViewer1.LocalReport.SetParameters(new[] { year });
            this.reportViewer1.RefreshReport();
        }
    }
}
