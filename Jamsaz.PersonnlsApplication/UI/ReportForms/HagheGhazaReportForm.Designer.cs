namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    partial class HagheGhazaReportForm
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
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HagheGhazaReportResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.HagheGhazaReportResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(218)))), ((int)(((byte)(254)))));
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HagheGhazaReportResultBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "Jamsaz.PersonnlsApplication.Reports.HagheGhazaReport.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(800, 450);
            this.reportViewer.TabIndex = 1;
            // 
            // HagheGhazaReportResultBindingSource
            // 
            this.HagheGhazaReportResultBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.HagheGhazaReportResult);
            // 
            // HagheGhazaReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer);
            this.Name = "HagheGhazaReportForm";
            this.ShowIcon = false;
            this.Text = "لیست پرسنل با حق ناهار";
            this.Load += new System.EventHandler(this.HagheGhazaReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HagheGhazaReportResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource HagheGhazaReportResultBindingSource;
    }
}