using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.Common;

namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    public partial class SakhtieKarReportForm : BasePersianForm 
    {
        public SakhtieKarReportForm()
        {
            InitializeComponent();
        }

        private void SakhtieKarReportForm_Load(object sender, EventArgs e)
        {

            db = new JamsazERPLiteDataClassesDataContext();

            this.GetHagheSakhtieKarResultBindingSource.DataSource = db.GetHagheSakhtieKar().ToList();

            this.reportViewer1.RefreshReport();
        }

        private JamsazERPLiteDataClassesDataContext db;

      
     
    }
}
