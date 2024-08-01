namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    partial class ComprehensivePersonnelReportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contractEndDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.toLabel2 = new System.Windows.Forms.Label();
            this.contractStartDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnelNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthCertPlaceOfIssue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrithDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maritalStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persianStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentChildNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occupationTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.childCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnelchildsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HagheGhaza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HagheTaahol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HagheOlad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.personnelNumberDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.BirthCertPlaceOfIssue,
            this.BrithDate,
            this.FatherName,
            this.maritalStatusDataGridViewTextBoxColumn,
            this.mobileNumberDataGridViewTextBoxColumn,
            this.majorNameDataGridViewTextBoxColumn,
            this.persianStartDateDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.departmentChildNameDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.occupationTitleDataGridViewTextBoxColumn,
            this.childCountDataGridViewTextBoxColumn,
            this.personnelchildsDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.HagheGhaza,
            this.HagheTaahol,
            this.HagheOlad,
            this.totalSalaryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1452, 415);
            this.dataGridView1.TabIndex = 0;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(1458, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.microsoft_excel_16px;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(98, 22);
            this.toolStripButton1.Text = "ارسال به اکسل";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1458, 481);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.contractEndDatePicker);
            this.groupBox1.Controls.Add(this.toLabel2);
            this.groupBox1.Controls.Add(this.contractStartDatePicker);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1452, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(964, 18);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 51;
            this.searchButton.Text = "جستجو";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1340, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 14);
            this.label1.TabIndex = 50;
            this.label1.Text = "تاریخ شروع به کار";
            // 
            // contractEndDatePicker
            // 
            this.contractEndDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contractEndDatePicker.Location = new System.Drawing.Point(1067, 20);
            this.contractEndDatePicker.Name = "contractEndDatePicker";
            this.contractEndDatePicker.Size = new System.Drawing.Size(120, 20);
            this.contractEndDatePicker.TabIndex = 47;
            this.contractEndDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // toLabel2
            // 
            this.toLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toLabel2.AutoSize = true;
            this.toLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLabel2.Location = new System.Drawing.Point(1193, 22);
            this.toLabel2.Name = "toLabel2";
            this.toLabel2.Size = new System.Drawing.Size(14, 14);
            this.toLabel2.TabIndex = 49;
            this.toLabel2.Text = "تا";
            // 
            // contractStartDatePicker
            // 
            this.contractStartDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contractStartDatePicker.Location = new System.Drawing.Point(1214, 20);
            this.contractStartDatePicker.Name = "contractStartDatePicker";
            this.contractStartDatePicker.Size = new System.Drawing.Size(120, 20);
            this.contractStartDatePicker.TabIndex = 48;
            this.contractStartDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // dataBindingSource
            // 
            this.dataBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.GetComprehensivePersonnelReportResult);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Row_";
            this.Column1.HeaderText = "ردیف";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // personnelNumberDataGridViewTextBoxColumn
            // 
            this.personnelNumberDataGridViewTextBoxColumn.DataPropertyName = "PersonnelNumber";
            this.personnelNumberDataGridViewTextBoxColumn.HeaderText = "شماره پرسنلی";
            this.personnelNumberDataGridViewTextBoxColumn.Name = "personnelNumberDataGridViewTextBoxColumn";
            this.personnelNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.personnelNumberDataGridViewTextBoxColumn.Width = 120;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "پرسنل";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "جنسیت";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Width = 50;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "سن";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            this.ageDataGridViewTextBoxColumn.Width = 50;
            // 
            // BirthCertPlaceOfIssue
            // 
            this.BirthCertPlaceOfIssue.DataPropertyName = "BirthCertPlaceOfIssue";
            this.BirthCertPlaceOfIssue.HeaderText = "محل صدور";
            this.BirthCertPlaceOfIssue.Name = "BirthCertPlaceOfIssue";
            this.BirthCertPlaceOfIssue.ReadOnly = true;
            // 
            // BrithDate
            // 
            this.BrithDate.DataPropertyName = "BrithDate";
            this.BrithDate.HeaderText = "تاریخ تولد";
            this.BrithDate.Name = "BrithDate";
            this.BrithDate.ReadOnly = true;
            // 
            // FatherName
            // 
            this.FatherName.DataPropertyName = "FatherName";
            this.FatherName.HeaderText = "نام پدر";
            this.FatherName.Name = "FatherName";
            this.FatherName.ReadOnly = true;
            // 
            // maritalStatusDataGridViewTextBoxColumn
            // 
            this.maritalStatusDataGridViewTextBoxColumn.DataPropertyName = "MaritalStatus";
            this.maritalStatusDataGridViewTextBoxColumn.HeaderText = "وضعیت تـأهل";
            this.maritalStatusDataGridViewTextBoxColumn.Name = "maritalStatusDataGridViewTextBoxColumn";
            this.maritalStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.maritalStatusDataGridViewTextBoxColumn.Width = 80;
            // 
            // mobileNumberDataGridViewTextBoxColumn
            // 
            this.mobileNumberDataGridViewTextBoxColumn.DataPropertyName = "MobileNumber";
            this.mobileNumberDataGridViewTextBoxColumn.HeaderText = "موبایل";
            this.mobileNumberDataGridViewTextBoxColumn.Name = "mobileNumberDataGridViewTextBoxColumn";
            this.mobileNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.mobileNumberDataGridViewTextBoxColumn.Width = 80;
            // 
            // majorNameDataGridViewTextBoxColumn
            // 
            this.majorNameDataGridViewTextBoxColumn.DataPropertyName = "MajorName";
            this.majorNameDataGridViewTextBoxColumn.HeaderText = "تحصیلات";
            this.majorNameDataGridViewTextBoxColumn.Name = "majorNameDataGridViewTextBoxColumn";
            this.majorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // persianStartDateDataGridViewTextBoxColumn
            // 
            this.persianStartDateDataGridViewTextBoxColumn.DataPropertyName = "PersianStartDate";
            this.persianStartDateDataGridViewTextBoxColumn.HeaderText = "تاریخ شروع به کار";
            this.persianStartDateDataGridViewTextBoxColumn.Name = "persianStartDateDataGridViewTextBoxColumn";
            this.persianStartDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.persianStartDateDataGridViewTextBoxColumn.Width = 120;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "واحد";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentChildNameDataGridViewTextBoxColumn
            // 
            this.departmentChildNameDataGridViewTextBoxColumn.DataPropertyName = "DepartmentChildName";
            this.departmentChildNameDataGridViewTextBoxColumn.HeaderText = "بخش";
            this.departmentChildNameDataGridViewTextBoxColumn.Name = "departmentChildNameDataGridViewTextBoxColumn";
            this.departmentChildNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "سابقه";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.ReadOnly = true;
            this.durationDataGridViewTextBoxColumn.Width = 80;
            // 
            // occupationTitleDataGridViewTextBoxColumn
            // 
            this.occupationTitleDataGridViewTextBoxColumn.DataPropertyName = "OccupationTitle";
            this.occupationTitleDataGridViewTextBoxColumn.HeaderText = "سمت";
            this.occupationTitleDataGridViewTextBoxColumn.Name = "occupationTitleDataGridViewTextBoxColumn";
            this.occupationTitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // childCountDataGridViewTextBoxColumn
            // 
            this.childCountDataGridViewTextBoxColumn.DataPropertyName = "ChildCount";
            this.childCountDataGridViewTextBoxColumn.HeaderText = "تعداد فرزند";
            this.childCountDataGridViewTextBoxColumn.Name = "childCountDataGridViewTextBoxColumn";
            this.childCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.childCountDataGridViewTextBoxColumn.Width = 80;
            // 
            // personnelchildsDataGridViewTextBoxColumn
            // 
            this.personnelchildsDataGridViewTextBoxColumn.DataPropertyName = "Personnel_childs";
            this.personnelchildsDataGridViewTextBoxColumn.HeaderText = "اسامی فرزندان";
            this.personnelchildsDataGridViewTextBoxColumn.Name = "personnelchildsDataGridViewTextBoxColumn";
            this.personnelchildsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            dataGridViewCellStyle2.Format = "N0";
            this.salaryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.salaryDataGridViewTextBoxColumn.HeaderText = "پایه حقوق";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // HagheGhaza
            // 
            this.HagheGhaza.DataPropertyName = "HagheGhaza";
            dataGridViewCellStyle3.Format = "N0";
            this.HagheGhaza.DefaultCellStyle = dataGridViewCellStyle3;
            this.HagheGhaza.HeaderText = "حق غذا";
            this.HagheGhaza.Name = "HagheGhaza";
            this.HagheGhaza.ReadOnly = true;
            // 
            // HagheTaahol
            // 
            this.HagheTaahol.DataPropertyName = "HagheTaahol";
            dataGridViewCellStyle4.Format = "N0";
            this.HagheTaahol.DefaultCellStyle = dataGridViewCellStyle4;
            this.HagheTaahol.HeaderText = "حق تاهل";
            this.HagheTaahol.Name = "HagheTaahol";
            this.HagheTaahol.ReadOnly = true;
            // 
            // HagheOlad
            // 
            this.HagheOlad.DataPropertyName = "HagheOlad";
            dataGridViewCellStyle5.Format = "N0";
            this.HagheOlad.DefaultCellStyle = dataGridViewCellStyle5;
            this.HagheOlad.HeaderText = "حق اولاد";
            this.HagheOlad.Name = "HagheOlad";
            this.HagheOlad.ReadOnly = true;
            // 
            // totalSalaryDataGridViewTextBoxColumn
            // 
            this.totalSalaryDataGridViewTextBoxColumn.DataPropertyName = "TotalSalary";
            dataGridViewCellStyle6.Format = "N0";
            this.totalSalaryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.totalSalaryDataGridViewTextBoxColumn.HeaderText = "جمع حقوق و مزایا";
            this.totalSalaryDataGridViewTextBoxColumn.Name = "totalSalaryDataGridViewTextBoxColumn";
            this.totalSalaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ComprehensivePersonnelReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 506);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "ComprehensivePersonnelReportForm";
            this.ShowIcon = false;
            this.Text = "گزارش جامع پرسنل";
            this.Load += new System.EventHandler(this.ComprehensivePersonnelReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataBindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private FarsiLibrary.Win.Controls.FADatePicker contractEndDatePicker;
        private System.Windows.Forms.Label toLabel2;
        private FarsiLibrary.Win.Controls.FADatePicker contractStartDatePicker;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnelNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthCertPlaceOfIssue;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrithDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn maritalStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persianStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentChildNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn occupationTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn childCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnelchildsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HagheGhaza;
        private System.Windows.Forms.DataGridViewTextBoxColumn HagheTaahol;
        private System.Windows.Forms.DataGridViewTextBoxColumn HagheOlad;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSalaryDataGridViewTextBoxColumn;
    }
}