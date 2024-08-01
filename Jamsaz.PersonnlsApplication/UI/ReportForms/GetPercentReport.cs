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
    public partial class GetPercentReport : BasePersianForm
    {
        public GetPercentReport()
        {
            InitializeComponent();
        }
        public List<GetPercentResult> Result { get; set; }
        private void GetPercentReport_Load(object sender, EventArgs e)
        {
            GetPercentResultBindingSource.DataSource = Result;
            this.reportViewer1.RefreshReport();
        }
    }
}
