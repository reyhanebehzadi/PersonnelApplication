namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    partial class personnelProfilesReportForm
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
            this.ResultSearchAdvencedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inSuranceNoReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.returnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ResultSearchAdvencedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultSearchAdvencedBindingSource
            // 
            this.ResultSearchAdvencedBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.ResultSearchAdvenced);
            // 
            // inSuranceNoReportViewer
            // 
            this.inSuranceNoReportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.inSuranceNoReportViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            reportDataSource1.Name = "Jamsaz_PersonnlsApplication_BusinessObjects_Data_ResultSearchAdvenced";
            reportDataSource1.Value = this.ResultSearchAdvencedBindingSource;
            this.inSuranceNoReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.inSuranceNoReportViewer.LocalReport.ReportEmbeddedResource = "Jamsaz.PersonnlsApplication.Reports.PersonnelProfilesReport.rdlc";
            this.inSuranceNoReportViewer.Location = new System.Drawing.Point(0, -2);
            this.inSuranceNoReportViewer.Name = "inSuranceNoReportViewer";
            this.inSuranceNoReportViewer.Size = new System.Drawing.Size(871, 614);
            this.inSuranceNoReportViewer.TabIndex = 1;
            // 
            // returnButton
            // 
            this.returnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.returnButton.Location = new System.Drawing.Point(714, 618);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 2;
            this.returnButton.Text = "برگشت";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // personnelProfilesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(801, 652);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.inSuranceNoReportViewer);
            this.Name = "personnelProfilesReportForm";
            this.Text = "گزارش مشخصات پرسنل";
            this.Load += new System.EventHandler(this.personnelProfilesReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultSearchAdvencedBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer inSuranceNoReportViewer;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.BindingSource ResultSearchAdvencedBindingSource;
    }
}