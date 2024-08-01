namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    partial class GetCountReportForm
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
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label label1;
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.GetCountPersonelReportResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GetInputPersonelResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GetExitPersonelResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.endDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.StartDateDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.reportButton = new System.Windows.Forms.Button();
            dateLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GetCountPersonelReportResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetInputPersonelResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetExitPersonelResultBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GetCountPersonelReportResultBindingSource
            // 
            this.GetCountPersonelReportResultBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.GetCountPersonelReportResult);
            // 
            // GetInputPersonelResultBindingSource
            // 
            this.GetInputPersonelResultBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.GetInputPersonelResult);
            // 
            // GetExitPersonelResultBindingSource
            // 
            this.GetExitPersonelResultBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.GetExitPersonelResult);
            // 
            // dateLabel
            // 
            dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(727, 24);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(42, 13);
            dateLabel.TabIndex = 17;
            dateLabel.Text = "از تاریخ:";
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(500, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(32, 13);
            label1.TabIndex = 19;
            label1.Text = "تاریخ:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GetCountPersonelReportResultBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.GetInputPersonelResultBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.GetExitPersonelResultBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Jamsaz.PersonnlsApplication.Reports.CountPersonnelReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(794, 384);
            this.reportViewer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.reportViewer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reportButton);
            this.groupBox1.Controls.Add(this.endDatePicker);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.StartDateDatePicker);
            this.groupBox1.Controls.Add(dateLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.endDatePicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.endDatePicker.Location = new System.Drawing.Point(338, 19);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(156, 20);
            this.endDatePicker.TabIndex = 20;
            // 
            // StartDateDatePicker
            // 
            this.StartDateDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartDateDatePicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.StartDateDatePicker.Location = new System.Drawing.Point(565, 19);
            this.StartDateDatePicker.Name = "StartDateDatePicker";
            this.StartDateDatePicker.Size = new System.Drawing.Size(156, 20);
            this.StartDateDatePicker.TabIndex = 18;
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(9, 14);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(90, 23);
            this.reportButton.TabIndex = 21;
            this.reportButton.Text = "گزارش";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // GetCountReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GetCountReportForm";
            this.ShowIcon = false;
            this.Text = "گزارش تعداد پرسنل";
            this.Load += new System.EventHandler(this.GetCountReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GetCountPersonelReportResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetInputPersonelResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetExitPersonelResultBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GetCountPersonelReportResultBindingSource;
        private System.Windows.Forms.BindingSource GetInputPersonelResultBindingSource;
        private System.Windows.Forms.BindingSource GetExitPersonelResultBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private FarsiLibrary.Win.Controls.FADatePicker endDatePicker;
        private FarsiLibrary.Win.Controls.FADatePicker StartDateDatePicker;
        private System.Windows.Forms.Button reportButton;
    }
}