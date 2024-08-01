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
    public partial class PersonnelChildsReportForm : BasePersianForm
    {
        public PersonnelChildsReportForm()
        {
            InitializeComponent();
        }
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        private void PersonnelChildsReportForm_Load(object sender, EventArgs e)
        {
            GetPersonnelChildsResultBindingSource.DataSource = db.GetPersonnelChilds();
            this.reportViewer1.RefreshReport();
        }
    }
}
