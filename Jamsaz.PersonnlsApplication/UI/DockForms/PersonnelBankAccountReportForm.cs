using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class PersonnelBankAccountReportForm : BasePersianForm
    {
        public PersonnelBankAccountReportForm()
            : base()
        {
            InitializeComponent();
        }

        JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);

        private void PersonnelBankAccountReportForm_Load(object sender, EventArgs e)
        {
            //PersonnelBindingSource.DataSource = db.Personnels.Where(c => c.IsActive == true).OrderBy(d => Convert.ToInt32(d.PersonnelNumber)).ToList();
            GetPersonnelAccountNumberResultBindingSource.DataSource= db.GetPersonnelAccountNumber();
            this.reportViewer1.RefreshReport();
        }
    }
}
