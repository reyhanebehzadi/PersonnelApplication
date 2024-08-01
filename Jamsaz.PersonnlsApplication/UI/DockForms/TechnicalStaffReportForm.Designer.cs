namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    partial class TechnicalStaffReportForm
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
            this.mainReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportFillButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NotTechnicalStaffRadioButton = new System.Windows.Forms.RadioButton();
            this.technicalStaffRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.ResultSearchAdvencedBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultSearchAdvencedBindingSource
            // 
            this.ResultSearchAdvencedBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.ResultSearchAdvenced);
            // 
            // mainReportViewer
            // 
            this.mainReportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mainReportViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            reportDataSource1.Name = "Jamsaz_PersonnlsApplication_BusinessObjects_Data_ResultSearchAdvenced";
            reportDataSource1.Value = this.ResultSearchAdvencedBindingSource;
            this.mainReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.mainReportViewer.LocalReport.ReportEmbeddedResource = "Jamsaz.PersonnlsApplication.Reports.TechnicalStaffReport.rdlc";
            this.mainReportViewer.Location = new System.Drawing.Point(0, 80);
            this.mainReportViewer.Name = "mainReportViewer";
            this.mainReportViewer.Size = new System.Drawing.Size(767, 422);
            this.mainReportViewer.TabIndex = 5;
            // 
            // reportFillButton
            // 
            this.reportFillButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reportFillButton.Location = new System.Drawing.Point(660, 26);
            this.reportFillButton.Name = "reportFillButton";
            this.reportFillButton.Size = new System.Drawing.Size(75, 23);
            this.reportFillButton.TabIndex = 4;
            this.reportFillButton.Text = "نمایش";
            this.reportFillButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.reportFillButton.UseVisualStyleBackColor = true;
            this.reportFillButton.Click += new System.EventHandler(this.reportFillButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NotTechnicalStaffRadioButton);
            this.groupBox1.Controls.Add(this.technicalStaffRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 49);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "انتخاب نوع گزارش";
            // 
            // NotTechnicalStaffRadioButton
            // 
            this.NotTechnicalStaffRadioButton.AutoSize = true;
            this.NotTechnicalStaffRadioButton.Location = new System.Drawing.Point(6, 20);
            this.NotTechnicalStaffRadioButton.Name = "NotTechnicalStaffRadioButton";
            this.NotTechnicalStaffRadioButton.Size = new System.Drawing.Size(176, 17);
            this.NotTechnicalStaffRadioButton.TabIndex = 1;
            this.NotTechnicalStaffRadioButton.Text = "گزارش پرسنل غیر فنی یا ستادی";
            this.NotTechnicalStaffRadioButton.UseVisualStyleBackColor = true;
            // 
            // technicalStaffRadioButton
            // 
            this.technicalStaffRadioButton.AutoSize = true;
            this.technicalStaffRadioButton.Checked = true;
            this.technicalStaffRadioButton.Location = new System.Drawing.Point(197, 20);
            this.technicalStaffRadioButton.Name = "technicalStaffRadioButton";
            this.technicalStaffRadioButton.Size = new System.Drawing.Size(112, 17);
            this.technicalStaffRadioButton.TabIndex = 0;
            this.technicalStaffRadioButton.TabStop = true;
            this.technicalStaffRadioButton.Text = "گزارش پرسنل فنی";
            this.technicalStaffRadioButton.UseVisualStyleBackColor = true;
            // 
            // TechnicalStaffReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(766, 499);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainReportViewer);
            this.Controls.Add(this.reportFillButton);
            this.Name = "TechnicalStaffReportForm";
            this.Text = "گزارش پرسنل فنی و غیر فنی";
            this.Load += new System.EventHandler(this.TechnicalStaffReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultSearchAdvencedBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer mainReportViewer;
        private System.Windows.Forms.Button reportFillButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton NotTechnicalStaffRadioButton;
        private System.Windows.Forms.RadioButton technicalStaffRadioButton;
        private System.Windows.Forms.BindingSource ResultSearchAdvencedBindingSource;
    }
}