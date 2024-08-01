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
    public partial class IncreaseManagementReportForm : BasePersianForm 
    {
        public IncreaseManagementReportForm()
        {
            InitializeComponent();
        }

        public List<BusinessObjects.Data.GetIncreaseManagementDetailResult> List { get; set; }

        public BusinessObjects.Data.IncreaseManagement IncreaseManagement { get; set; }

        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();

        private void IncreaseManagementReportForm_Load(object sender, EventArgs e)
        {
            IncreaseManagementBindingSource.DataSource = db.IncreaseManagements.SingleOrDefault(c => c.ID == IncreaseManagement.ID);
            GetIncreaseManagementDetailResultBindingSource.DataSource = List;

            this.reportViewer1.RefreshReport();
        }

        
    }
}
