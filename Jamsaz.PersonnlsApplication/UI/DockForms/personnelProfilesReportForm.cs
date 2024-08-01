using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.PersonnlsApplication.Classes;
using Jamsaz.Common;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class personnelProfilesReportForm : Jamsaz.Common.BasePersianForm
    {
        public personnelProfilesReportForm(List<vwMainPersonnely_SearchAdvancedResult> resultSearchAdvenceds)
        {
            InitializeComponent();
            this.resultSearchAdvenceds = resultSearchAdvenceds;
        }
        public personnelProfilesReportForm(OrganizationStructure value)
        {
            InitializeComponent();
            try
            {
                JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
                OrganizationStructure currentorganizationStructure = value.OrganizationStructureVersion.OrganizationStructures.Single(c => c.Id == value.Id);
            IEnumerable<int> personnelsID =  currentorganizationStructure.OrganizationStructurePersonnels.Select(c=>c.PersonnelId);
            string roleName = value.Name;
            if (personnelsID.Count() != 0)
            {
                this.resultSearchAdvenceds = (from c in db.Personnels
                                              where  personnelsID.Contains(c.Id)
                                              select new vwMainPersonnely_SearchAdvancedResult()
                                                  {
                                                      PersonnelNumber = c.PersonnelNumber,
                                                      FullNameFa = c.FirstName + " " + c.LastName,
                                                      Gender = c.Gender.Value.GetGenderName(),
                                                      IssueNo = c.IssueNo,
                                                      BirthCertPlaceOfIssue = c.BirthCertPlaceOfIssue,
                                                      BrithDateToPersianDate = c.BrithDate.Value,
                                                     PersianFirstContractStartDate = db.udfGetFarsiDate(c.FirstContractStartDate.Value.ToString()),
                                                      OccupationTitle = roleName
                                                  }).ToList();
            }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        
        List<vwMainPersonnely_SearchAdvancedResult> resultSearchAdvenceds = new List<vwMainPersonnely_SearchAdvancedResult>();

        private void personnelProfilesReportForm_Load(object sender, EventArgs e)
        {
            if (resultSearchAdvenceds != null)
            {
                ReportParameter reportParameter = new ReportParameter("ReportDate", Jamsaz.Common.Helper.GetPersianDate(DateTime.Now));
                inSuranceNoReportViewer.LocalReport.SetParameters(new ReportParameter[] { reportParameter });

                ResultSearchAdvencedBindingSource.DataSource = resultSearchAdvenceds;
                this.inSuranceNoReportViewer.RefreshReport();
            }
            else
                Jamsaz.Common.Helper.ShowMessage("ٍاطلاعاتی وجود ندارد");
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
