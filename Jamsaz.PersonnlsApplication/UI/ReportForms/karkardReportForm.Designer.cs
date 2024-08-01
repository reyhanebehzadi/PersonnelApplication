namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    partial class karkardReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.EidRegistrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectPersonelButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.personnelNameTextBox = new System.Windows.Forms.TextBox();
            this.personelNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GetSanavatReportResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EidRegistrationBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GetSanavatReportResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EidRegistrationBindingSource
            // 
            this.EidRegistrationBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.EidRegistration);
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
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectPersonelButton);
            this.groupBox1.Controls.Add(this.reportButton);
            this.groupBox1.Controls.Add(this.personnelNameTextBox);
            this.groupBox1.Controls.Add(this.personelNumberTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // selectPersonelButton
            // 
            this.selectPersonelButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.selectPersonelButton.Location = new System.Drawing.Point(295, 20);
            this.selectPersonelButton.Name = "selectPersonelButton";
            this.selectPersonelButton.Size = new System.Drawing.Size(32, 23);
            this.selectPersonelButton.TabIndex = 4;
            this.selectPersonelButton.Text = "...";
            this.selectPersonelButton.UseVisualStyleBackColor = true;
            this.selectPersonelButton.Click += new System.EventHandler(this.selectPersonelButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.reportButton.Location = new System.Drawing.Point(9, 18);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(75, 23);
            this.reportButton.TabIndex = 3;
            this.reportButton.Text = "گزارش";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // personnelNameTextBox
            // 
            this.personnelNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.personnelNameTextBox.Location = new System.Drawing.Point(333, 20);
            this.personnelNameTextBox.Name = "personnelNameTextBox";
            this.personnelNameTextBox.ReadOnly = true;
            this.personnelNameTextBox.Size = new System.Drawing.Size(253, 21);
            this.personnelNameTextBox.TabIndex = 2;
            // 
            // personelNumberTextBox
            // 
            this.personelNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.personelNumberTextBox.Location = new System.Drawing.Point(592, 20);
            this.personelNumberTextBox.Name = "personelNumberTextBox";
            this.personelNumberTextBox.ReadOnly = true;
            this.personelNumberTextBox.Size = new System.Drawing.Size(100, 21);
            this.personelNumberTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(698, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "پرسنل مورد نظر";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EidRegistrationBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.GetSanavatReportResultBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Jamsaz.PersonnlsApplication.Reports.karkardReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(794, 384);
            this.reportViewer1.TabIndex = 1;
            // 
            // GetSanavatReportResultBindingSource
            // 
            this.GetSanavatReportResultBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.GetSanavatReportResult);
            // 
            // karkardReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "karkardReportForm";
            this.ShowIcon = false;
            this.Text = "گزارش کارکرد پرسنل";
            this.Load += new System.EventHandler(this.karkardReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EidRegistrationBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GetSanavatReportResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.TextBox personnelNameTextBox;
        private System.Windows.Forms.TextBox personelNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selectPersonelButton;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EidRegistrationBindingSource;
        private System.Windows.Forms.BindingSource GetSanavatReportResultBindingSource;
    }
}