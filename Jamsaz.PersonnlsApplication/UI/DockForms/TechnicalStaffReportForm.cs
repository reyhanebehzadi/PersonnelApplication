using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Microsoft.Reporting.WinForms;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class TechnicalStaffReportForm : Jamsaz.Common.BasePersianForm
    {
        public TechnicalStaffReportForm()
        {
            InitializeComponent();
        }

        private void TechnicalStaffReportForm_Load(object sender, EventArgs e)
        {

        }
        Jamsaz.PersonnlsApplication.BusinessObjects.Data.JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
        private void reportFillButton_Click(object sender, EventArgs e)
        {
            string reportTitle = string.Empty;
            bool isTechnicalPersonnel = false;
            if (technicalStaffRadioButton.Checked)
            {
                reportTitle = technicalStaffRadioButton.Text;
                isTechnicalPersonnel = true;
            }
            else if (NotTechnicalStaffRadioButton.Checked)
            {
                reportTitle = NotTechnicalStaffRadioButton.Text;
                isTechnicalPersonnel = false;
            }

            ResultSearchAdvencedBindingSource.DataSource = from c in db.Personnels
                                                           where c.IsTechnicalStaff == isTechnicalPersonnel
                                                           orderby Convert.ToInt32(c.PersonnelNumber)
                                                           select new ResultSearchAdvenced
                                                           {

                                                              PersonnelNumber = c.PersonnelNumber,
                                                              FullNameFa = c.FirstName + " " + c.LastName,
                                                              Gender = c.Gender == 1 ? "مرد" : "زن",
                                                              BirthCertPlaceOfIssue = c.BirthCertPlaceOfIssue,
                                                              BrithDateToPersianDate = c.BrithDate.Value, 
                                                              IssueNo = c.IssueNo,
                                                              OccupationTitle =  db.OrganizationStructurePersonnels.First(d=>d.PersonnelId == c.Id && d.IsMainPosition == true).OrganizationStructure.Name 

                                                           };
            ReportParameter ReportDateParameter = new ReportParameter("ReportDate", Jamsaz.Common.Helper.GetPersianDate(DateTime.Now));
           

            ReportParameter ReportTitleParameter = new ReportParameter("ReportTitle", reportTitle);
            mainReportViewer.LocalReport.SetParameters(new ReportParameter[] { ReportDateParameter, ReportTitleParameter });
            this.mainReportViewer.RefreshReport();
        }
    }
}
