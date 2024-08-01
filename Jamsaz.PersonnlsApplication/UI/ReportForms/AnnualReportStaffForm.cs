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
using Microsoft.Reporting.WinForms;

namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    public partial class AnnualReportStaffForm : BasePersianForm
    {
        public AnnualReportStaffForm()
        {
            InitializeComponent();
        }
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();

        private void AnnualReportStaffForm_Load(object sender, EventArgs e)
        {
            monthTableBindingSource.DataSource = db.MonthTables.ToList();
           
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            
            ReportParameter date = new ReportParameter("Date",string.Format("{0}/{1}", Convert.ToInt32(yearnumericUpDown.Value), monthcomboBox.SelectedIndex + 1) );
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { date });
            GetPersounleCountResultBindingSource.DataSource = db.GetPersounleCount(Convert.ToInt32(yearnumericUpDown.Value), monthcomboBox.SelectedIndex + 1);
            this.reportViewer1.RefreshReport();
        }
    }
}
