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

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class ListPersonnelByEducationReportForm : Jamsaz.Common.BasePersianForm
    {
        public ListPersonnelByEducationReportForm()
        {
            InitializeComponent();
        }
        Jamsaz.PersonnlsApplication.BusinessObjects.Data.JamsazERPLiteDataClassesDataContext db = new Jamsaz.PersonnlsApplication.BusinessObjects.Data.JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
        private void ListPersonnelByEducationReportForm_Load(object sender, EventArgs e)
        {
           
        }

        private void showReportButton_Click(object sender, EventArgs e)
        {
            if (statusStudyingComboBox.SelectedIndex == -1)
            {
                Jamsaz.Common.Helper.ShowMessage("وضعیت را انتخاب کنید");
                return;
            }

            List<TemplatePersonnelEducation> ListAllPersonnelsToGoingToStudy = new List<TemplatePersonnelEducation>();
            ListAllPersonnelsToGoingToStudy = (from c in db.PersonnalsEducations
                                               where c.StatusStudying == statusStudyingComboBox.SelectedIndex orderby Convert.ToInt32(c.Personnel.PersonnelNumber)
                                               select new TemplatePersonnelEducation
                                               {
                                                   DegreeLevel = c.UniversityDegree.Name,
                                                   EducationalOrganaizationName = c.EducationalOrganaizationName,
                                                   fullName = c.FullName,
                                                   GraduationDateEn = c.GraduationDate,
                                                   MajorName = c.Major1.Name,
                                                   StartDateEn = c.StartDate,
                                                   PersonnelNumber = c.Personnel.PersonnelNumber,
                                                   GPA = c.GPA.ToString()
                                               }).ToList();
            TemplatePersonnelEducationBindingSource.DataSource = ListAllPersonnelsToGoingToStudy;
            this.mainReportViewer.RefreshReport();
        }
    }
}
