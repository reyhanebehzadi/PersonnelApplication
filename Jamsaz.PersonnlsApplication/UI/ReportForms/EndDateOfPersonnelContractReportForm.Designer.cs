namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    partial class EndDateOfPersonnelContractReportForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label effectiveDateLabel;
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reportButton = new System.Windows.Forms.Button();
            this.endDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.startDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EndDateOfPersonnelContractResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            label1 = new System.Windows.Forms.Label();
            effectiveDateLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndDateOfPersonnelContractResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(512, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(41, 13);
            label1.TabIndex = 6;
            label1.Text = "تا تاریخ:";
            // 
            // effectiveDateLabel
            // 
            effectiveDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            effectiveDateLabel.AutoSize = true;
            effectiveDateLabel.Location = new System.Drawing.Point(740, 26);
            effectiveDateLabel.Name = "effectiveDateLabel";
            effectiveDateLabel.Size = new System.Drawing.Size(42, 13);
            effectiveDateLabel.TabIndex = 4;
            effectiveDateLabel.Text = "از تاریخ:";
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
            this.groupBox1.Size = new System.Drawing.Size(794, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو";
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
            // endDatePicker
            // 
            this.endDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.endDatePicker.Location = new System.Drawing.Point(346, 23);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(160, 20);
            this.endDatePicker.TabIndex = 7;
            this.endDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startDatePicker.Location = new System.Drawing.Point(574, 23);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(160, 20);
            this.startDatePicker.TabIndex = 5;
            this.startDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // reportViewer
            // 
            this.reportViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(218)))), ((int)(((byte)(254)))));
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.EndDateOfPersonnelContractResultBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "Jamsaz.PersonnlsApplication.Reports.EndDateOfPersonnelContractReprot.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(3, 63);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(794, 384);
            this.reportViewer.TabIndex = 0;
            // 
            // EndDateOfPersonnelContractResultBindingSource
            // 
            this.EndDateOfPersonnelContractResultBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.EndDateOfPersonnelContractResult);
            // 
            // EndDateOfPersonnelContractReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EndDateOfPersonnelContractReportForm";
            this.ShowIcon = false;
            this.Text = "لیست پرسنل(تاریخ پایان قرارداد جاری)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EndDateOfPersonnelContractReportForm_FormClosing);
            this.Load += new System.EventHandler(this.EndDateOfPersonnelContractReportForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EndDateOfPersonnelContractResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button reportButton;
        private FarsiLibrary.Win.Controls.FADatePicker endDatePicker;
        private FarsiLibrary.Win.Controls.FADatePicker startDatePicker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource EndDateOfPersonnelContractResultBindingSource;
    }
}