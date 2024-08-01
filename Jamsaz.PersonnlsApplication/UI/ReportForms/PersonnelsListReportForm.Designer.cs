namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    partial class PersonnelsListReportForm
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
            System.Windows.Forms.Label effectiveDateLabel;
            System.Windows.Forms.Label label1;
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.startDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.endDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.reportButton = new System.Windows.Forms.Button();
            this.SelectPersonnelsResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            effectiveDateLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectPersonnelsResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(218)))), ((int)(((byte)(254)))));
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Jamsaz_PersonnlsApplication_BusinessObjects_Data_SelectPersonnelsResult";
            reportDataSource1.Value = this.SelectPersonnelsResultBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "Jamsaz.PersonnlsApplication.Reports.PersonnelsList.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(3, 63);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(887, 667);
            this.reportViewer.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.reportViewer, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(893, 733);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reportButton);
            this.groupBox1.Controls.Add(this.endDatePicker);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.startDatePicker);
            this.groupBox1.Controls.Add(effectiveDateLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(887, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو";
            // 
            // startDatePicker
            // 
            this.startDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startDatePicker.Location = new System.Drawing.Point(667, 23);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(160, 20);
            this.startDatePicker.TabIndex = 5;
            this.startDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // effectiveDateLabel
            // 
            effectiveDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            effectiveDateLabel.AutoSize = true;
            effectiveDateLabel.Location = new System.Drawing.Point(833, 26);
            effectiveDateLabel.Name = "effectiveDateLabel";
            effectiveDateLabel.Size = new System.Drawing.Size(42, 13);
            effectiveDateLabel.TabIndex = 4;
            effectiveDateLabel.Text = "از تاریخ:";
            // 
            // endDatePicker
            // 
            this.endDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.endDatePicker.Location = new System.Drawing.Point(439, 23);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(160, 20);
            this.endDatePicker.TabIndex = 7;
            this.endDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(605, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(41, 13);
            label1.TabIndex = 6;
            label1.Text = "تا تاریخ:";
            // 
            // reportButton
            // 
            this.reportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.reportButton.Location = new System.Drawing.Point(9, 20);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(75, 23);
            this.reportButton.TabIndex = 8;
            this.reportButton.Text = "گزارش";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // SelectPersonnelsResultBindingSource
            // 
            this.SelectPersonnelsResultBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.SelectPersonnelsResult);
            // 
            // PersonnelsListReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(218)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(893, 733);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PersonnelsListReportForm";
            this.ShowIcon = false;
            this.Text = "لیست پرسنل";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonnelsListReportForm_FormClosing);
            this.Load += new System.EventHandler(this.PersonnelsListReportForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectPersonnelsResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource SelectPersonnelsResultBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button reportButton;
        private FarsiLibrary.Win.Controls.FADatePicker endDatePicker;
        private FarsiLibrary.Win.Controls.FADatePicker startDatePicker;
    }
}