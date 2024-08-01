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
    public partial class HagheGhazaReportForm : BasePersianForm
    {
        public HagheGhazaReportForm()
        {
            InitializeComponent();
        }
        JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        private void HagheGhazaReportForm_Load(object sender, EventArgs e)
        {
            HagheGhazaReportResultBindingSource.DataSource = db.HagheGhazaReport();
            reportViewer.RefreshReport();
        }
    }
}
