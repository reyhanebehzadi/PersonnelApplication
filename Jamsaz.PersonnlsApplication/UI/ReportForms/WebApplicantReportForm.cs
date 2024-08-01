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
    public partial class WebApplicantReportForm : BasePersianForm 
    {
        public WebApplicantReportForm()
        {
            InitializeComponent();
        }
        public BusinessObjects.Data.Applicant Applicant { get; set; }
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();

        private void WebApplicantReportForm_Load(object sender, EventArgs e)
        {
            ApplicantBindingSource.DataSource = db.Applicants.Where(c => c.ID == Applicant.ID).First();
            ApplicantCourseBindingSource.DataSource = db.ApplicantCourses.Where(c => c.ApplicantID == Applicant.ID);
            ApplicantSkillBindingSource.DataSource = db.ApplicantSkills.Where(c => c.ApplicantID == this.Applicant.ID);
            ApplicantsWorkExperienceBindingSource.DataSource =db.ApplicantsWorkExperiences.Where(c => c.ApplicantID == this.Applicant.ID);
            ApplicantsEducationBindingSource.DataSource = db.ApplicantsEducations.Where(c => c.ApplicantID == this.Applicant.ID);
            this.reportViewer1.RefreshReport();
        }

       
    }
}
