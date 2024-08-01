using System;
using System.Collections.Generic;
using System.Linq;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Microsoft.Reporting.WinForms;

namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    public partial class PersonelShebaReportForm : BasePersianForm
    {
        public IList<vwAccountNumberPersonnely_SearchAdvancedResult> Personnels { get; set; }
        public string BankName { get; set; }

        public PersonelShebaReportForm()
        {
            InitializeComponent();
        }

        private void PersonelShebaReportForm_Load(object sender, EventArgs e)
        {
            PersonnelBindingSource.DataSource = Personnels;
            var bankNameParameter = new ReportParameter("BankName", BankName);
            reportViewer1.LocalReport.SetParameters(new[] { bankNameParameter });
            reportViewer1.RefreshReport();
        }
    }
}
