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
    public partial class HagheSarparstiReportForm : BasePersianForm
    {
        public HagheSarparstiReportForm()
        {
            InitializeComponent();
        }
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        private void HagheSarparstiReportForm_Load(object sender, EventArgs e)
        {
            GetHagheSarparstiResultBindingSource.DataSource = db.GetHagheSarparsti();
            this.reportViewer1.RefreshReport();
        }
    }
}
