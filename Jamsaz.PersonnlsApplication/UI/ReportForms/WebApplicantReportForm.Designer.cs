namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    partial class WebApplicantReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ApplicantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ApplicantsEducationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ApplicantsWorkExperienceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ApplicantCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ApplicantSkillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ApplicantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplicantsEducationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplicantsWorkExperienceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplicantCourseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplicantSkillBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ApplicantBindingSource
            // 
            this.ApplicantBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.Applicant);
            // 
            // ApplicantsEducationBindingSource
            // 
            this.ApplicantsEducationBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.ApplicantsEducation);
            // 
            // ApplicantsWorkExperienceBindingSource
            // 
            this.ApplicantsWorkExperienceBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.ApplicantsWorkExperience);
            // 
            // ApplicantCourseBindingSource
            // 
            this.ApplicantCourseBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.ApplicantCourse);
            // 
            // ApplicantSkillBindingSource
            // 
            this.ApplicantSkillBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.ApplicantSkill);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ApplicantBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.ApplicantsEducationBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.ApplicantsWorkExperienceBindingSource;
            reportDataSource4.Name = "DataSet4";
            reportDataSource4.Value = this.ApplicantCourseBindingSource;
            reportDataSource5.Name = "DataSet5";
            reportDataSource5.Value = this.ApplicantSkillBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Jamsaz.PersonnlsApplication.Reports.WebApplicantReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(674, 688);
            this.reportViewer1.TabIndex = 0;
            // 
            // WebApplicantReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 688);
            this.Controls.Add(this.reportViewer1);
            this.Name = "WebApplicantReportForm";
            this.ShowIcon = false;
            this.Text = "پرینت رزومه";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WebApplicantReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ApplicantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplicantsEducationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplicantsWorkExperienceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplicantCourseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplicantSkillBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ApplicantBindingSource;
        private System.Windows.Forms.BindingSource ApplicantsEducationBindingSource;
        private System.Windows.Forms.BindingSource ApplicantsWorkExperienceBindingSource;
        private System.Windows.Forms.BindingSource ApplicantCourseBindingSource;
        private System.Windows.Forms.BindingSource ApplicantSkillBindingSource;
    }
}