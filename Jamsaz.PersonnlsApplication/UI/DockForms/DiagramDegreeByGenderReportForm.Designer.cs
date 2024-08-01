namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    partial class DiagramDegreeByGenderReportForm
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
            this.DiagramDegreeByGenderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DiagramDegreeByGenderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DiagramDegreeByGenderBindingSource
            // 
            this.DiagramDegreeByGenderBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.DiagramDegreeByGender);
            // 
            // mainReportViewer
            // 
            this.mainReportViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.mainReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Jamsaz_PersonnlsApplication_BusinessObjects_Data_DiagramDegreeByGender";
            reportDataSource1.Value = this.DiagramDegreeByGenderBindingSource;
            this.mainReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.mainReportViewer.LocalReport.ReportEmbeddedResource = "Jamsaz.PersonnlsApplication.Reports.DiagramDegreeReport.rdlc";
            this.mainReportViewer.Location = new System.Drawing.Point(0, 0);
            this.mainReportViewer.Name = "mainReportViewer";
            this.mainReportViewer.Size = new System.Drawing.Size(790, 658);
            this.mainReportViewer.TabIndex = 1;
            // 
            // DiagramDegreeByGenderReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 658);
            this.Controls.Add(this.mainReportViewer);
            this.Name = "DiagramDegreeByGenderReportForm";
            this.ShowIcon = false;
            this.Text = "نمودار وضعیت تحصیلی پرسنل";
            this.Load += new System.EventHandler(this.DiagramDegreeByGenderReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DiagramDegreeByGenderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer mainReportViewer;
        private System.Windows.Forms.BindingSource DiagramDegreeByGenderBindingSource;
    }
}