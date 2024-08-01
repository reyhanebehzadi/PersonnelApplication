namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    partial class GetOvertimeLicenseReportForm
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
            System.Windows.Forms.Label dateLabel;
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.GetOvertimeLicenseReportResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.departmentComboboxChilds = new System.Windows.Forms.ComboBox();
            this.childrenOfDepartmentbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.selectPersonButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.personelNumberTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.endDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.DatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            label1 = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GetOvertimeLicenseReportResultBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.childrenOfDepartmentbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(544, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(41, 13);
            label1.TabIndex = 24;
            label1.Text = "تا تاریخ:";
            // 
            // dateLabel
            // 
            dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(741, 21);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(42, 13);
            dateLabel.TabIndex = 22;
            dateLabel.Text = "از تاریخ:";
            // 
            // GetOvertimeLicenseReportResultBindingSource
            // 
            this.GetOvertimeLicenseReportResultBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.GetOvertimeLicenseReportResult);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 522);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.departmentComboboxChilds);
            this.groupBox1.Controls.Add(this.departmentComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.selectPersonButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.personelNumberTextBox);
            this.groupBox1.Controls.Add(this.fullNameTextBox);
            this.groupBox1.Controls.Add(this.endDatePicker);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.DatePicker);
            this.groupBox1.Controls.Add(dateLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو";
            // 
            // departmentComboboxChilds
            // 
            this.departmentComboboxChilds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentComboboxChilds.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.departmentComboboxChilds.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.departmentComboboxChilds.DataSource = this.childrenOfDepartmentbindingSource;
            this.departmentComboboxChilds.DisplayMember = "Name";
            this.departmentComboboxChilds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentComboboxChilds.FormattingEnabled = true;
            this.departmentComboboxChilds.Location = new System.Drawing.Point(451, 71);
            this.departmentComboboxChilds.Name = "departmentComboboxChilds";
            this.departmentComboboxChilds.Size = new System.Drawing.Size(139, 21);
            this.departmentComboboxChilds.TabIndex = 62;
            this.departmentComboboxChilds.ValueMember = "Id";
            // 
            // childrenOfDepartmentbindingSource
            // 
            this.childrenOfDepartmentbindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.Department);
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.departmentComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.departmentComboBox.DataSource = this.departmentBindingSource;
            this.departmentComboBox.DisplayMember = "Name";
            this.departmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(596, 71);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(140, 21);
            this.departmentComboBox.TabIndex = 61;
            this.departmentComboBox.ValueMember = "Id";
            this.departmentComboBox.SelectedIndexChanged += new System.EventHandler(this.departmentComboBox_SelectedIndexChanged);
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.Department);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(741, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "واحد:";
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchButton.Location = new System.Drawing.Point(9, 80);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 30;
            this.searchButton.Text = "نمایش";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // selectPersonButton
            // 
            this.selectPersonButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectPersonButton.Location = new System.Drawing.Point(483, 40);
            this.selectPersonButton.Name = "selectPersonButton";
            this.selectPersonButton.Size = new System.Drawing.Size(32, 23);
            this.selectPersonButton.TabIndex = 29;
            this.selectPersonButton.Text = "...";
            this.selectPersonButton.UseVisualStyleBackColor = true;
            this.selectPersonButton.Click += new System.EventHandler(this.selectPersonButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(741, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "پرسنل:";
            // 
            // personelNumberTextBox
            // 
            this.personelNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.personelNumberTextBox.Location = new System.Drawing.Point(675, 42);
            this.personelNumberTextBox.Name = "personelNumberTextBox";
            this.personelNumberTextBox.ReadOnly = true;
            this.personelNumberTextBox.Size = new System.Drawing.Size(60, 21);
            this.personelNumberTextBox.TabIndex = 27;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fullNameTextBox.Location = new System.Drawing.Point(521, 42);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.ReadOnly = true;
            this.fullNameTextBox.Size = new System.Drawing.Size(148, 21);
            this.fullNameTextBox.TabIndex = 26;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.endDatePicker.Location = new System.Drawing.Point(418, 14);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(120, 20);
            this.endDatePicker.TabIndex = 25;
            this.endDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // DatePicker
            // 
            this.DatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DatePicker.Location = new System.Drawing.Point(615, 17);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(120, 20);
            this.DatePicker.TabIndex = 23;
            this.DatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GetOvertimeLicenseReportResultBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Jamsaz.PersonnlsApplication.Reports.GetOvertimeLicenseReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 123);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(794, 396);
            this.reportViewer1.TabIndex = 1;
            // 
            // GetOvertimeLicenseReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GetOvertimeLicenseReportForm";
            this.ShowIcon = false;
            this.Text = "گزارش اضافه کاری پرسنل";
            this.Load += new System.EventHandler(this.GetOvertimeLicenseReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GetOvertimeLicenseReportResultBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.childrenOfDepartmentbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button selectPersonButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox personelNumberTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private FarsiLibrary.Win.Controls.FADatePicker endDatePicker;
        private FarsiLibrary.Win.Controls.FADatePicker DatePicker;
        private System.Windows.Forms.Button searchButton;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GetOvertimeLicenseReportResultBindingSource;
        private System.Windows.Forms.ComboBox departmentComboboxChilds;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private System.Windows.Forms.BindingSource childrenOfDepartmentbindingSource;
    }
}