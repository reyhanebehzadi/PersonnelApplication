using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class PrsonnelReportByInSuranceNoReportForm : Jamsaz.Common.BasePersianForm
    {
        List<vwMainPersonnely_SearchAdvancedResult> resultSearchAdvenceds = new List<vwMainPersonnely_SearchAdvancedResult>();

        public PrsonnelReportByInSuranceNoReportForm(List<vwMainPersonnely_SearchAdvancedResult> resultSearchAdvenceds)
        {
            InitializeComponent();
            this.resultSearchAdvenceds = resultSearchAdvenceds;
        }

        private void PrsonnelReportByInSuranceNoReportForm_Load(object sender, EventArgs e)
        {
            if (resultSearchAdvenceds != null)
            {
                foreach (vwMainPersonnely_SearchAdvancedResult item in resultSearchAdvenceds)
                {
                    string _MainNationalCode = string.Empty;
                    if (!string.IsNullOrEmpty(item.NationalCode))
                    {
                            string[] valueNationalCode = item.NationalCode.Split('-');
                            _MainNationalCode = valueNationalCode[2] + '-' + valueNationalCode[1] + '-' + valueNationalCode[0];
                            item.NationalCode = _MainNationalCode;
                    }
                    
                }

                ResultSearchAdvencedBindingSource.DataSource = resultSearchAdvenceds;
                this.inSuranceNoReportViewer.RefreshReport();
            }
            else
                Jamsaz.Common.Helper.ShowMessage("ٍاطلاعاتی وجود ندارد");
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.CloseForm();
        }
    }
}
