namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    partial class DiagramMaritualStatusReportForm
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
            this.DiagramMaritualStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MainReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DiagramMaritualStatusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DiagramMaritualStatusBindingSource
            // 
            this.DiagramMaritualStatusBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.DiagramMaritualStatus);
            // 
            // MainReportViewer
            // 
            this.MainReportViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.MainReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Jamsaz_PersonnlsApplication_BusinessObjects_Data_DiagramMaritualStatus";
            reportDataSource1.Value = this.DiagramMaritualStatusBindingSource;
            this.MainReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.MainReportViewer.LocalReport.ReportEmbeddedResource = "Jamsaz.PersonnlsApplication.Reports.DigramMaritualStatusReport.rdlc";
            this.MainReportViewer.Location = new System.Drawing.Point(0, 0);
            this.MainReportViewer.Name = "MainReportViewer";
            this.MainReportViewer.Size = new System.Drawing.Size(810, 703);
            this.MainReportViewer.TabIndex = 0;
            // 
            // DiagramMaritualStatusReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 703);
            this.Controls.Add(this.MainReportViewer);
            this.Name = "DiagramMaritualStatusReportForm";
            this.ShowIcon = false;
            this.Text = "نمودار نسبت متاهلین و مجردین";
            this.Load += new System.EventHandler(this.DiagramMaritualStatusReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DiagramMaritualStatusBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer MainReportViewer;
        private System.Windows.Forms.BindingSource DiagramMaritualStatusBindingSource;
    }
}