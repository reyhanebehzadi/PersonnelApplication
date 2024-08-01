namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    partial class AnnualReportStaffForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.monthcomboBox = new System.Windows.Forms.ComboBox();
            this.monthTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.yearnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.reportButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GetPersounleCountResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetPersounleCountResultBindingSource)).BeginInit();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(901, 504);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.monthcomboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.yearnumericUpDown);
            this.groupBox1.Controls.Add(this.reportButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(895, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // monthcomboBox
            // 
            this.monthcomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthcomboBox.DataSource = this.monthTableBindingSource;
            this.monthcomboBox.DisplayMember = "Title";
            this.monthcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthcomboBox.FormattingEnabled = true;
            this.monthcomboBox.Location = new System.Drawing.Point(535, 32);
            this.monthcomboBox.Name = "monthcomboBox";
            this.monthcomboBox.Size = new System.Drawing.Size(121, 21);
            this.monthcomboBox.TabIndex = 8;
            this.monthcomboBox.ValueMember = "ID";
            // 
            // monthTableBindingSource
            // 
            this.monthTableBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.MonthTable);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(662, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ماه:";
            // 
            // yearnumericUpDown
            // 
            this.yearnumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yearnumericUpDown.Location = new System.Drawing.Point(747, 33);
            this.yearnumericUpDown.Maximum = new decimal(new int[] {
            1450,
            0,
            0,
            0});
            this.yearnumericUpDown.Minimum = new decimal(new int[] {
            1386,
            0,
            0,
            0});
            this.yearnumericUpDown.Name = "yearnumericUpDown";
            this.yearnumericUpDown.Size = new System.Drawing.Size(82, 21);
            this.yearnumericUpDown.TabIndex = 6;
            this.yearnumericUpDown.Value = new decimal(new int[] {
            1386,
            0,
            0,
            0});
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(9, 31);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(127, 23);
            this.reportButton.TabIndex = 5;
            this.reportButton.Text = "نمایش";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(833, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "سال:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GetPersounleCountResultBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Jamsaz.PersonnlsApplication.Reports.AnnualReportStaff.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 83);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(895, 418);
            this.reportViewer1.TabIndex = 1;
            // 
            // GetPersounleCountResultBindingSource
            // 
            this.GetPersounleCountResultBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.GetPersounleCountResult);
            // 
            // AnnualReportStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 504);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AnnualReportStaffForm";
            this.ShowIcon = false;
            this.Text = "گزارش سالانه پرسنل";
            this.Load += new System.EventHandler(this.AnnualReportStaffForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetPersounleCountResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.ComboBox monthcomboBox;
        private System.Windows.Forms.BindingSource monthTableBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown yearnumericUpDown;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GetPersounleCountResultBindingSource;
    }
}