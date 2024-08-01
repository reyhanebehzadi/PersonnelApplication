namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    partial class GetPaySanavatReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GetPaySanavatReportResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payRadioButton = new System.Windows.Forms.RadioButton();
            this.dontPayRadioButton = new System.Windows.Forms.RadioButton();
            this.allRadioButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GetPaySanavatReportResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.reportViewer1, 0, 1);
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
            this.groupBox1.Controls.Add(this.allRadioButton);
            this.groupBox1.Controls.Add(this.dontPayRadioButton);
            this.groupBox1.Controls.Add(this.payRadioButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "فیلتر";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.GetPaySanavatReportResultBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Jamsaz.PersonnlsApplication.Reports.GetPaySanavatRepor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(794, 384);
            this.reportViewer1.TabIndex = 1;
            // 
            // GetPaySanavatReportResultBindingSource
            // 
            this.GetPaySanavatReportResultBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.GetPaySanavatReportResult);
            // 
            // payRadioButton
            // 
            this.payRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.payRadioButton.AutoSize = true;
            this.payRadioButton.Location = new System.Drawing.Point(550, 20);
            this.payRadioButton.Name = "payRadioButton";
            this.payRadioButton.Size = new System.Drawing.Size(83, 17);
            this.payRadioButton.TabIndex = 0;
            this.payRadioButton.Text = "پرداخت شده";
            this.payRadioButton.UseVisualStyleBackColor = true;
            this.payRadioButton.CheckedChanged += new System.EventHandler(this.payRadioButton_CheckedChanged);
            // 
            // dontPayRadioButton
            // 
            this.dontPayRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dontPayRadioButton.AutoSize = true;
            this.dontPayRadioButton.Location = new System.Drawing.Point(639, 20);
            this.dontPayRadioButton.Name = "dontPayRadioButton";
            this.dontPayRadioButton.Size = new System.Drawing.Size(87, 17);
            this.dontPayRadioButton.TabIndex = 1;
            this.dontPayRadioButton.Text = "پرداخت نشده";
            this.dontPayRadioButton.UseVisualStyleBackColor = true;
            this.dontPayRadioButton.CheckedChanged += new System.EventHandler(this.dontPayRadioButton_CheckedChanged);
            // 
            // allRadioButton
            // 
            this.allRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.allRadioButton.AutoSize = true;
            this.allRadioButton.Checked = true;
            this.allRadioButton.Location = new System.Drawing.Point(732, 20);
            this.allRadioButton.Name = "allRadioButton";
            this.allRadioButton.Size = new System.Drawing.Size(46, 17);
            this.allRadioButton.TabIndex = 2;
            this.allRadioButton.TabStop = true;
            this.allRadioButton.Text = "همه";
            this.allRadioButton.UseVisualStyleBackColor = true;
            this.allRadioButton.CheckedChanged += new System.EventHandler(this.allRadioButton_CheckedChanged);
            // 
            // GetPaySanavatReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GetPaySanavatReportForm";
            this.ShowIcon = false;
            this.Text = "گزارش سنوات و عیدی";
            this.Load += new System.EventHandler(this.GetPaySanavatReportForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GetPaySanavatReportResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GetPaySanavatReportResultBindingSource;
        private System.Windows.Forms.RadioButton allRadioButton;
        private System.Windows.Forms.RadioButton dontPayRadioButton;
        private System.Windows.Forms.RadioButton payRadioButton;
    }
}