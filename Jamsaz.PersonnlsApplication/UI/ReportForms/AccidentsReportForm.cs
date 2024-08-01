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
    public partial class AccidentsReportForm : BasePersianForm
    {
        public AccidentsReportForm()
        {
            InitializeComponent();
        }
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        private void AccidentsReportForm_Load(object sender, EventArgs e)
        {
            fiscalYearBindingSource.DataSource = db.FiscalYears;
            fiscalyearComboBox.SelectedItem = (FiscalYear)db.FiscalYears.SingleOrDefault(c => c.Status == 2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccidentBindingSource.DataSource = db.Accidents.Where(c => c.FiscalYearID == ((FiscalYear)fiscalyearComboBox.SelectedItem).ID);
            reportViewer.RefreshReport();
        }
    }
}
