namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    partial class PersonnelsFunctionReportForm
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
            this.EmployeeDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.showButton = new System.Windows.Forms.Button();
            this.selectDepartmentButton = new System.Windows.Forms.Button();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeDataBindingSource
            // 
            this.EmployeeDataBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.EmployeeData);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(796, 627);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EmployeeDataBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Jamsaz.PersonnlsApplication.Reports.TaradodInWeekReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 125);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(790, 499);
            this.reportViewer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateDatePicker);
            this.groupBox1.Controls.Add(this.showButton);
            this.groupBox1.Controls.Add(this.selectDepartmentButton);
            this.groupBox1.Controls.Add(this.departmentTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 116);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(705, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "تاریخ:";
            // 
            // dateDatePicker
            // 
            this.dateDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateDatePicker.Location = new System.Drawing.Point(503, 51);
            this.dateDatePicker.Name = "dateDatePicker";
            this.dateDatePicker.Size = new System.Drawing.Size(196, 20);
            this.dateDatePicker.TabIndex = 4;
            // 
            // showButton
            // 
            this.showButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.showButton.Location = new System.Drawing.Point(6, 79);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 3;
            this.showButton.Text = "نمایش";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // selectDepartmentButton
            // 
            this.selectDepartmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectDepartmentButton.Location = new System.Drawing.Point(417, 23);
            this.selectDepartmentButton.Name = "selectDepartmentButton";
            this.selectDepartmentButton.Size = new System.Drawing.Size(37, 23);
            this.selectDepartmentButton.TabIndex = 2;
            this.selectDepartmentButton.Text = "...";
            this.selectDepartmentButton.UseVisualStyleBackColor = true;
            this.selectDepartmentButton.Click += new System.EventHandler(this.selectDepartmentButton_Click);
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.departmentTextBox.Location = new System.Drawing.Point(460, 24);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.ReadOnly = true;
            this.departmentTextBox.Size = new System.Drawing.Size(239, 21);
            this.departmentTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(705, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "واحد سازمانی:";
            // 
            // PersonnelsFunctionReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 627);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PersonnelsFunctionReportForm";
            this.Text = "گزارش تردد پرسنل-هفتگی";
            this.Load += new System.EventHandler(this.PersonnelsFunctionReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button selectDepartmentButton;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label2;
        private FarsiLibrary.Win.Controls.FADatePicker dateDatePicker;
        private System.Windows.Forms.BindingSource EmployeeDataBindingSource;
    }
}