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
    public partial class GetPercentReportForm : BasePersianForm
    {
        public GetPercentReportForm()
        {
            InitializeComponent();
        }
        private List<GetPercentResult> List = new List<GetPercentResult>();

        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        private void reportButton_Click(object sender, EventArgs e)
        {
            var p = Convert.ToInt32(percentComboBox.SelectedItem);
                getPercentBindingSource.DataSource  = db.GetPercent(Convert.ToInt32(percentComboBox.SelectedItem));
            List = db.GetPercent(Convert.ToInt32(percentComboBox.SelectedItem)).ToList();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void printButton_Click(object sender, EventArgs e)
        {
            if (getPercentBindingSource.List.Count < 1)
                return;
            GetPercentReport report = new GetPercentReport() {Result=List };
            report.ShowDialog();
        }
    }
}
