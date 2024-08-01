namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    partial class ListPersonnelByEducationReportForm
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
            this.TemplatePersonnelEducationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.statusStudyingComboBox = new System.Windows.Forms.ComboBox();
            this.showReportButton = new System.Windows.Forms.Button();
            this.statusStudyingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TemplatePersonnelEducationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TemplatePersonnelEducationBindingSource
            // 
            this.TemplatePersonnelEducationBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.TemplatePersonnelEducation);
            // 
            // mainReportViewer
            // 
            this.mainReportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mainReportViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            reportDataSource1.Name = "Jamsaz_PersonnlsApplication_BusinessObjects_Data_TemplatePersonnelEducation";
            reportDataSource1.Value = this.TemplatePersonnelEducationBindingSource;
            this.mainReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.mainReportViewer.LocalReport.ReportEmbeddedResource = "Jamsaz.PersonnlsApplication.Reports.ListPersonnelbyEducationReport.rdlc";
            this.mainReportViewer.Location = new System.Drawing.Point(0, 51);
            this.mainReportViewer.Name = "mainReportViewer";
            this.mainReportViewer.Size = new System.Drawing.Size(750, 442);
            this.mainReportViewer.TabIndex = 0;
            // 
            // statusStudyingComboBox
            // 
            this.statusStudyingComboBox.DisplayMember = "Name";
            this.statusStudyingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusStudyingComboBox.FormattingEnabled = true;
            this.statusStudyingComboBox.Items.AddRange(new object[] {
            "درحال تحصیل",
            "فارغ التحصیل"});
            this.statusStudyingComboBox.Location = new System.Drawing.Point(113, 12);
            this.statusStudyingComboBox.Name = "statusStudyingComboBox";
            this.statusStudyingComboBox.Size = new System.Drawing.Size(175, 21);
            this.statusStudyingComboBox.TabIndex = 23;
            this.statusStudyingComboBox.ValueMember = "ID";
            // 
            // showReportButton
            // 
            this.showReportButton.Location = new System.Drawing.Point(310, 12);
            this.showReportButton.Name = "showReportButton";
            this.showReportButton.Size = new System.Drawing.Size(75, 23);
            this.showReportButton.TabIndex = 24;
            this.showReportButton.Text = "نمایش";
            this.showReportButton.UseVisualStyleBackColor = true;
            this.showReportButton.Click += new System.EventHandler(this.showReportButton_Click);
            // 
            // statusStudyingLabel
            // 
            this.statusStudyingLabel.AutoSize = true;
            this.statusStudyingLabel.Location = new System.Drawing.Point(23, 15);
            this.statusStudyingLabel.Name = "statusStudyingLabel";
            this.statusStudyingLabel.Size = new System.Drawing.Size(84, 13);
            this.statusStudyingLabel.TabIndex = 25;
            this.statusStudyingLabel.Text = "وضعیت تحصیلات";
            // 
            // ListPersonnelByEducationReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(745, 493);
            this.Controls.Add(this.statusStudyingLabel);
            this.Controls.Add(this.showReportButton);
            this.Controls.Add(this.statusStudyingComboBox);
            this.Controls.Add(this.mainReportViewer);
            this.Name = "ListPersonnelByEducationReportForm";
            this.Text = "گزارش پرسنل در حال تحصیل";
            this.Load += new System.EventHandler(this.ListPersonnelByEducationReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TemplatePersonnelEducationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer mainReportViewer;
        private System.Windows.Forms.BindingSource TemplatePersonnelEducationBindingSource;
        private System.Windows.Forms.ComboBox statusStudyingComboBox;
        private System.Windows.Forms.Button showReportButton;
        private System.Windows.Forms.Label statusStudyingLabel;
    }
}