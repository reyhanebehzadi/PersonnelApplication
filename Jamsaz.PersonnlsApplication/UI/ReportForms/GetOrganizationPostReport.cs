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
    public partial class GetOrganizationPostReport : BasePersianForm
    {
        public GetOrganizationPostReport()
        {
            InitializeComponent();
        }
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();

        private void GetOrganizationPostReport_Load(object sender, EventArgs e)
        {
            GetOrganizationPostReportResultBindingSource.DataSource = db.GetOrganizationPostReport().OrderBy(c=>(int.Parse)(c.PersonnelNumber));
            this.reportViewer1.RefreshReport();
        }
    }
}
