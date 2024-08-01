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
    public partial class PersonnelEmailListReportForm : BasePersianForm
    {
        public PersonnelEmailListReportForm()
        {
            InitializeComponent();
        }
        private JamsazERPLiteDataClassesDataContext db = new BusinessObjects.Data.JamsazERPLiteDataClassesDataContext();
        private void PersonnelEmailListReportForm_Load(object sender, EventArgs e)
        {
            GetPersonnelEmailListResultBindingSource.DataSource = db.GetPersonnelEmailList();
            this.reportViewer1.RefreshReport();
        }


    }
}
