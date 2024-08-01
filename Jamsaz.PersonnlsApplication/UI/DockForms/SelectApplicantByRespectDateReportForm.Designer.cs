namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    partial class SelectApplicantByRespectDateReportForm
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
            this.reportFillButton = new System.Windows.Forms.Button();
            this.mainReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.respectDateDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.respectDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ResultSearchAdvencedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultSearchAdvencedBindingSource
            // 
            this.ResultSearchAdvencedBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.ResultSearchAdvenced);
            // 
            // reportFillButton
            // 
            this.reportFillButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reportFillButton.Location = new System.Drawing.Point(426, 11);
            this.reportFillButton.Name = "reportFillButton";
            this.reportFillButton.Size = new System.Drawing.Size(75, 23);
            this.reportFillButton.TabIndex = 0;
            this.reportFillButton.Text = "نمایش";
            this.reportFillButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.reportFillButton.UseVisualStyleBackColor = true;
            this.reportFillButton.Click += new System.EventHandler(this.reportFillButton_Click);
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
            this.mainReportViewer.LocalReport.ReportEmbeddedResource = "Jamsaz.PersonnlsApplication.Reports.SelectApplicantByRespectDateReport.rdlc";
            this.mainReportViewer.Location = new System.Drawing.Point(-1, 42);
            this.mainReportViewer.Name = "mainReportViewer";
            this.mainReportViewer.Size = new System.Drawing.Size(767, 457);
            this.mainReportViewer.TabIndex = 1;
            // 
            // respectDateDatePicker
            // 
            this.respectDateDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.respectDateDatePicker.Location = new System.Drawing.Point(507, 13);
            this.respectDateDatePicker.Name = "respectDateDatePicker";
            this.respectDateDatePicker.Size = new System.Drawing.Size(120, 20);
            this.respectDateDatePicker.TabIndex = 2;
            // 
            // respectDateLabel
            // 
            this.respectDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.respectDateLabel.AutoSize = true;
            this.respectDateLabel.Location = new System.Drawing.Point(636, 16);
            this.respectDateLabel.Name = "respectDateLabel";
            this.respectDateLabel.Size = new System.Drawing.Size(118, 13);
            this.respectDateLabel.TabIndex = 3;
            this.respectDateLabel.Text = "انتخاب تاریخ مراجعه کنید";
            // 
            // SelectApplicantByRespectDateReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(766, 499);
            this.Controls.Add(this.respectDateLabel);
            this.Controls.Add(this.respectDateDatePicker);
            this.Controls.Add(this.mainReportViewer);
            this.Controls.Add(this.reportFillButton);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "SelectApplicantByRespectDateReportForm";
            this.Text = "لیست کارجویان به تفکیک تاریخ مراجعه";
            this.Load += new System.EventHandler(this.SelectApplicantByRespectDateReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultSearchAdvencedBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reportFillButton;
        private Microsoft.Reporting.WinForms.ReportViewer mainReportViewer;
        private FarsiLibrary.Win.Controls.FADatePicker respectDateDatePicker;
        private System.Windows.Forms.Label respectDateLabel;
        private System.Windows.Forms.BindingSource ResultSearchAdvencedBindingSource;
    }
}