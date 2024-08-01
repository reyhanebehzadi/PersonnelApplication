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
    public partial class HagheJazbReportForm : BasePersianForm
    {
        public HagheJazbReportForm()
        {
            InitializeComponent();
        }
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        private void HagheJazbReportForm_Load(object sender, EventArgs e)
        {
            GetHagheJazbResultBindingSource.DataSource = db.GetHagheJazb().OrderBy(c=>Convert.ToInt32( c.PersonnelNumber));
            this.reportViewer1.RefreshReport();
        }
    }
}
