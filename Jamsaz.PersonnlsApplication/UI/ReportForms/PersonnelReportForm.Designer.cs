namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    partial class PersonnelReportForm
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
            this.GetPersonnelReportResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tolidicheckBox = new System.Windows.Forms.CheckBox();
            this.setadicheckBox = new System.Windows.Forms.CheckBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.getUnitsHaveStaffResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.showButton = new System.Windows.Forms.Button();
            this.majorComboBox = new System.Windows.Forms.ComboBox();
            this.majorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.universityComboBox = new System.Windows.Forms.ComboBox();
            this.universityDegreeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.occupationCmboBox = new System.Windows.Forms.ComboBox();
            this.responsibilityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.departmentComboboxChilds = new System.Windows.Forms.ComboBox();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.childrenOfDepartmentbindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GetPersonnelReportResultBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getUnitsHaveStaffResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.majorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDegreeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsibilityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenOfDepartmentbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GetPersonnelReportResultBindingSource
            // 
            this.GetPersonnelReportResultBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.GetPersonnelReportResult);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1338, 512);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.departmentComboboxChilds);
            this.groupBox1.Controls.Add(this.departmentComboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.refreshButton);
            this.groupBox1.Controls.Add(this.showButton);
            this.groupBox1.Controls.Add(this.majorComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.universityComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.occupationCmboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1332, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tolidicheckBox);
            this.groupBox2.Controls.Add(this.setadicheckBox);
            this.groupBox2.Location = new System.Drawing.Point(621, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 42);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "نوع فعالیت";
            // 
            // tolidicheckBox
            // 
            this.tolidicheckBox.AutoSize = true;
            this.tolidicheckBox.Location = new System.Drawing.Point(90, 17);
            this.tolidicheckBox.Name = "tolidicheckBox";
            this.tolidicheckBox.Size = new System.Drawing.Size(57, 17);
            this.tolidicheckBox.TabIndex = 1;
            this.tolidicheckBox.Text = "تولیدی";
            this.tolidicheckBox.UseVisualStyleBackColor = true;
            // 
            // setadicheckBox
            // 
            this.setadicheckBox.AutoSize = true;
            this.setadicheckBox.Location = new System.Drawing.Point(181, 17);
            this.setadicheckBox.Name = "setadicheckBox";
            this.setadicheckBox.Size = new System.Drawing.Size(59, 17);
            this.setadicheckBox.TabIndex = 0;
            this.setadicheckBox.Text = "ستادی";
            this.setadicheckBox.UseVisualStyleBackColor = true;
            // 
            // refreshButton
            // 
            this.refreshButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.refresh;
            this.refreshButton.Location = new System.Drawing.Point(9, 72);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(30, 25);
            this.refreshButton.TabIndex = 8;
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // getUnitsHaveStaffResultBindingSource
            // 
            this.getUnitsHaveStaffResultBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.GetUnitsHaveStaffResult);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(45, 74);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(124, 23);
            this.showButton.TabIndex = 1;
            this.showButton.Text = "نمایش";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // majorComboBox
            // 
            this.majorComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.majorComboBox.DataSource = this.majorBindingSource;
            this.majorComboBox.DisplayMember = "Name";
            this.majorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.majorComboBox.FormattingEnabled = true;
            this.majorComboBox.Location = new System.Drawing.Point(657, 72);
            this.majorComboBox.Name = "majorComboBox";
            this.majorComboBox.Size = new System.Drawing.Size(144, 21);
            this.majorComboBox.TabIndex = 5;
            this.majorComboBox.ValueMember = "Id";
            // 
            // majorBindingSource
            // 
            this.majorBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.Major);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(807, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "رشته تحصیلی:";
            // 
            // universityComboBox
            // 
            this.universityComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.universityComboBox.DataSource = this.universityDegreeBindingSource;
            this.universityComboBox.DisplayMember = "Name";
            this.universityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.universityComboBox.FormattingEnabled = true;
            this.universityComboBox.Location = new System.Drawing.Point(1087, 45);
            this.universityComboBox.Name = "universityComboBox";
            this.universityComboBox.Size = new System.Drawing.Size(144, 21);
            this.universityComboBox.TabIndex = 3;
            this.universityComboBox.ValueMember = "Id";
            this.universityComboBox.SelectedIndexChanged += new System.EventHandler(this.universityComboBox_SelectedIndexChanged);
            // 
            // universityDegreeBindingSource
            // 
            this.universityDegreeBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.UniversityDegree);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1234, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "تحصیلات:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // occupationCmboBox
            // 
            this.occupationCmboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.occupationCmboBox.DataSource = this.responsibilityBindingSource;
            this.occupationCmboBox.DisplayMember = "Title";
            this.occupationCmboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.occupationCmboBox.FormattingEnabled = true;
            this.occupationCmboBox.Location = new System.Drawing.Point(1087, 19);
            this.occupationCmboBox.Name = "occupationCmboBox";
            this.occupationCmboBox.Size = new System.Drawing.Size(143, 21);
            this.occupationCmboBox.TabIndex = 1;
            this.occupationCmboBox.ValueMember = "Id";
            // 
            // responsibilityBindingSource
            // 
            this.responsibilityBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.Responsibility);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1236, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "سمت:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.GetPersonnelReportResultBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Jamsaz.PersonnlsApplication.Reports.PersonnelReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 123);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1332, 386);
            this.reportViewer1.TabIndex = 1;
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
            this.departmentComboboxChilds.Location = new System.Drawing.Point(943, 72);
            this.departmentComboboxChilds.Name = "departmentComboboxChilds";
            this.departmentComboboxChilds.Size = new System.Drawing.Size(139, 21);
            this.departmentComboboxChilds.TabIndex = 62;
            this.departmentComboboxChilds.ValueMember = "Id";
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
            this.departmentComboBox.Location = new System.Drawing.Point(1087, 72);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(144, 21);
            this.departmentComboBox.TabIndex = 61;
            this.departmentComboBox.ValueMember = "Id";
            this.departmentComboBox.SelectedIndexChanged += new System.EventHandler(this.departmentComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(1236, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 14);
            this.label5.TabIndex = 60;
            this.label5.Text = "واحد:";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.Department);
            // 
            // childrenOfDepartmentbindingSource
            // 
            this.childrenOfDepartmentbindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.Department);
            // 
            // PersonnelReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 512);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PersonnelReportForm";
            this.ShowIcon = false;
            this.Text = "گزارش پرسنل ";
            this.Load += new System.EventHandler(this.PersonnelReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GetPersonnelReportResultBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getUnitsHaveStaffResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.majorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDegreeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsibilityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenOfDepartmentbindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox majorComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox universityComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.BindingSource majorBindingSource;
        private System.Windows.Forms.BindingSource universityDegreeBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GetPersonnelReportResultBindingSource;
        private System.Windows.Forms.ComboBox occupationCmboBox;
        private System.Windows.Forms.BindingSource responsibilityBindingSource;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.BindingSource getUnitsHaveStaffResultBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox tolidicheckBox;
        private System.Windows.Forms.CheckBox setadicheckBox;
        private System.Windows.Forms.ComboBox departmentComboboxChilds;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource childrenOfDepartmentbindingSource;
        private System.Windows.Forms.BindingSource departmentBindingSource;
    }
}