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
using Microsoft.Reporting.WinForms;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class SelectApplicantByRespectDateReportForm : Form
    {
        public SelectApplicantByRespectDateReportForm()
        {
            InitializeComponent();
        }
        JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);

        private void SelectApplicantByRespectDateReportForm_Load(object sender, EventArgs e)
        {

         
        }

        private void reportFillButton_Click(object sender, EventArgs e)
        {
            if (respectDateDatePicker.IsNull)
            {
                Helper.ShowMessage("لطفا تاریخ مراجعه را انتخاب کنید");
                return;
            }

            ResultSearchAdvencedBindingSource.DataSource = from c in db.Applicants
                                                           where c.RespectDate.Value.Date == respectDateDatePicker.SelectedDateTime.Value.Date
                                                           select new ResultSearchAdvenced
                                                           {

                                                               BrithDateToPersianDate = c.BrithDate.Value,
                                                              FatherName = c.FatherName,
                                                              FullNameFa = c.Name + " " + c.LastName,
                                                              Gender = c.Gender  ==1 ? "مرد":"زن",
                                                              MajorName = c.Major.Name,
                                                              UniversityDegreeName = c.UniversityDegree.Name,
                                                              IssueNo = c.IssueNo

                                                           };
            ReportParameter DateReportParameter = new ReportParameter("ReportDate", Jamsaz.Common.Helper.GetPersianDate(DateTime.Now));
            ReportParameter RespectDateParameter = new ReportParameter("RespectDateParameter", respectDateDatePicker.SelectedDateTime.Value.Date.ToPersianDate());
            mainReportViewer.LocalReport.SetParameters(new ReportParameter[] { DateReportParameter, RespectDateParameter });
            this.mainReportViewer.RefreshReport();
        }
    }
}
