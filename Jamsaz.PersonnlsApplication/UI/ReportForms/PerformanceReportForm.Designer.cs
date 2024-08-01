namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    partial class PerformanceReportForm
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
            this.PerformancEvaluationMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PerformancEvaluationDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.PerformancEvaluationMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PerformancEvaluationDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PerformancEvaluationMasterBindingSource
            // 
            this.PerformancEvaluationMasterBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.PerformancEvaluationMaster);
            // 
            // PerformancEvaluationDetailBindingSource
            // 
            this.PerformancEvaluationDetailBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.PerformancEvaluationDetail);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PerformancEvaluationMasterBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.PerformancEvaluationDetailBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Jamsaz.PersonnlsApplication.Reports.PerformanceReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(963, 621);
            this.reportViewer1.TabIndex = 1;
            // 
            // PerformanceReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 621);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PerformanceReportForm";
            this.ShowIcon = false;
            this.Text = "فرم ارزیابی عملکرد پرسنل";
            this.Load += new System.EventHandler(this.PerformanceReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PerformancEvaluationMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PerformancEvaluationDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PerformancEvaluationMasterBindingSource;
        private System.Windows.Forms.BindingSource PerformancEvaluationDetailBindingSource;
    }
}