using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jamsaz.PersonnlsApplication.Classes;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using System.Threading;
using Jamsaz.PersonnlsApplication.UI.DialogForms;
using Jamsaz.Common;


namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    public partial class PersonnelsList1ReportForm : BasePersianForm
    {
        public PersonnelsList1ReportForm()
        {
            InitializeComponent();
        }

        private JamsazERPLiteDataClassesDataContext db;

        private void PersonnelsList1ReportForm_Load(object sender, EventArgs e)
        {

            db = new JamsazERPLiteDataClassesDataContext();

            this.SelectPersonnels1ResultBindingSource.DataSource = db.SelectPersonnels1().ToList();

            this.reportViewer.RefreshReport();
        }

        private void PersonnelsList1ReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.reportViewer.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
