namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    partial class IncreaseManagementReportForm
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GetIncreaseManagementDetailResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IncreaseManagementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GetIncreaseManagementDetailResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncreaseManagementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GetIncreaseManagementDetailResultBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.IncreaseManagementBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Jamsaz.PersonnlsApplication.Reports.IncreaseManagementReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(740, 593);
            this.reportViewer1.TabIndex = 0;
            // 
            // GetIncreaseManagementDetailResultBindingSource
            // 
            this.GetIncreaseManagementDetailResultBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.GetIncreaseManagementDetailResult);
            // 
            // IncreaseManagementBindingSource
            // 
            this.IncreaseManagementBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.IncreaseManagement);
            // 
            // IncreaseManagementReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 593);
            this.Controls.Add(this.reportViewer1);
            this.Name = "IncreaseManagementReportForm";
            this.ShowIcon = false;
            this.Text = "پرینت";
            this.Load += new System.EventHandler(this.IncreaseManagementReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GetIncreaseManagementDetailResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncreaseManagementBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GetIncreaseManagementDetailResultBindingSource;
        private System.Windows.Forms.BindingSource IncreaseManagementBindingSource;
    }
}