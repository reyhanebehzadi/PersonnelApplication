namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    partial class OvertimeLicenseReportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.overtimeLicenseDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersianDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PursonelNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdministrativeStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Confirm = new Stimulsoft.Controls.Win.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.overtimeLicenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectPersonButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.personelNumberTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.endDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.printButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.DatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.overtimeLicenseDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overtimeLicenseDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            dateLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overtimeLicenseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overtimeLicenseBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overtimeLicenseDetailsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overtimeLicenseDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(776, 24);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(42, 13);
            dateLabel.TabIndex = 12;
            dateLabel.Text = "از تاریخ:";
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(579, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(41, 13);
            label1.TabIndex = 16;
            label1.Text = "تا تاریخ:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.overtimeLicenseDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.overtimeLicenseDetailsDataGridView, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(834, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // overtimeLicenseDataGridView
            // 
            this.overtimeLicenseDataGridView.AllowUserToAddRows = false;
            this.overtimeLicenseDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.overtimeLicenseDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.overtimeLicenseDataGridView.AutoGenerateColumns = false;
            this.overtimeLicenseDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.overtimeLicenseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.overtimeLicenseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.PersianDate,
            this.FullName,
            this.PursonelNumber,
            this.Department,
            this.AdministrativeStatus,
            this.Confirm});
            this.overtimeLicenseDataGridView.DataSource = this.overtimeLicenseBindingSource;
            this.overtimeLicenseDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overtimeLicenseDataGridView.Location = new System.Drawing.Point(3, 83);
            this.overtimeLicenseDataGridView.Name = "overtimeLicenseDataGridView";
            this.overtimeLicenseDataGridView.ReadOnly = true;
            this.overtimeLicenseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.overtimeLicenseDataGridView.Size = new System.Drawing.Size(828, 179);
            this.overtimeLicenseDataGridView.TabIndex = 1;
            this.overtimeLicenseDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.overtimeLicenseDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Code";
            this.dataGridViewTextBoxColumn2.HeaderText = "شماره";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // PersianDate
            // 
            this.PersianDate.DataPropertyName = "PersianDate";
            this.PersianDate.HeaderText = "تاریخ";
            this.PersianDate.Name = "PersianDate";
            this.PersianDate.ReadOnly = true;
            this.PersianDate.Width = 80;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "مسئول";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 150;
            // 
            // PursonelNumber
            // 
            this.PursonelNumber.DataPropertyName = "PursonelNumber";
            this.PursonelNumber.HeaderText = "شماره پرسنلی";
            this.PursonelNumber.Name = "PursonelNumber";
            this.PursonelNumber.ReadOnly = true;
            this.PursonelNumber.Width = 130;
            // 
            // Department
            // 
            this.Department.DataPropertyName = "Department";
            this.Department.HeaderText = "واحد";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            this.Department.Width = 150;
            // 
            // AdministrativeStatus
            // 
            this.AdministrativeStatus.DataPropertyName = "AdministrativeStatus";
            this.AdministrativeStatus.HeaderText = "وضعیت";
            this.AdministrativeStatus.Name = "AdministrativeStatus";
            this.AdministrativeStatus.ReadOnly = true;
            this.AdministrativeStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AdministrativeStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AdministrativeStatus.Width = 80;
            // 
            // Confirm
            // 
            this.Confirm.DataPropertyName = "Confirm";
            this.Confirm.HeaderText = "";
            this.Confirm.Name = "Confirm";
            this.Confirm.ReadOnly = true;
            this.Confirm.Text = null;
            // 
            // overtimeLicenseBindingSource
            // 
            this.overtimeLicenseBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.OvertimeLicense);
            this.overtimeLicenseBindingSource.PositionChanged += new System.EventHandler(this.overtimeLicenseBindingSource_PositionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectPersonButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.personelNumberTextBox);
            this.groupBox1.Controls.Add(this.fullNameTextBox);
            this.groupBox1.Controls.Add(this.endDatePicker);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.printButton);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.DatePicker);
            this.groupBox1.Controls.Add(dateLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(828, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "فیلتر";
            // 
            // selectPersonButton
            // 
            this.selectPersonButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectPersonButton.Location = new System.Drawing.Point(518, 43);
            this.selectPersonButton.Name = "selectPersonButton";
            this.selectPersonButton.Size = new System.Drawing.Size(32, 23);
            this.selectPersonButton.TabIndex = 21;
            this.selectPersonButton.Text = "...";
            this.selectPersonButton.UseVisualStyleBackColor = true;
            this.selectPersonButton.Click += new System.EventHandler(this.selectPersonButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(776, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "پرسنل:";
            // 
            // personelNumberTextBox
            // 
            this.personelNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.personelNumberTextBox.Location = new System.Drawing.Point(710, 45);
            this.personelNumberTextBox.Name = "personelNumberTextBox";
            this.personelNumberTextBox.ReadOnly = true;
            this.personelNumberTextBox.Size = new System.Drawing.Size(60, 21);
            this.personelNumberTextBox.TabIndex = 19;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fullNameTextBox.Location = new System.Drawing.Point(556, 45);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.ReadOnly = true;
            this.fullNameTextBox.Size = new System.Drawing.Size(148, 21);
            this.fullNameTextBox.TabIndex = 18;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.endDatePicker.Location = new System.Drawing.Point(453, 17);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(120, 20);
            this.endDatePicker.TabIndex = 17;
            this.endDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(9, 34);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 23);
            this.printButton.TabIndex = 15;
            this.printButton.Text = "چاپ";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(89, 34);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 14;
            this.searchButton.Text = "نمایش";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // DatePicker
            // 
            this.DatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DatePicker.Location = new System.Drawing.Point(650, 20);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(120, 20);
            this.DatePicker.TabIndex = 13;
            this.DatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // overtimeLicenseDetailsDataGridView
            // 
            this.overtimeLicenseDetailsDataGridView.AllowUserToAddRows = false;
            this.overtimeLicenseDetailsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.overtimeLicenseDetailsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.overtimeLicenseDetailsDataGridView.AutoGenerateColumns = false;
            this.overtimeLicenseDetailsDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.overtimeLicenseDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.overtimeLicenseDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.overtimeLicenseDetailsDataGridView.DataSource = this.overtimeLicenseDetailsBindingSource;
            this.overtimeLicenseDetailsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overtimeLicenseDetailsDataGridView.Location = new System.Drawing.Point(3, 268);
            this.overtimeLicenseDetailsDataGridView.Name = "overtimeLicenseDetailsDataGridView";
            this.overtimeLicenseDetailsDataGridView.ReadOnly = true;
            this.overtimeLicenseDetailsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.overtimeLicenseDetailsDataGridView.Size = new System.Drawing.Size(828, 179);
            this.overtimeLicenseDetailsDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PursonelNumber";
            this.dataGridViewTextBoxColumn3.HeaderText = "شماره پرسنلی";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 130;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn1.HeaderText = "پرسنل";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "From";
            this.dataGridViewTextBoxColumn12.HeaderText = "از ساعت";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 80;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "To";
            this.dataGridViewTextBoxColumn13.HeaderText = "تا ساعت";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 80;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn14.HeaderText = "توضیحات";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 300;
            // 
            // overtimeLicenseDetailsBindingSource
            // 
            this.overtimeLicenseDetailsBindingSource.DataMember = "OvertimeLicenseDetails";
            this.overtimeLicenseDetailsBindingSource.DataSource = this.overtimeLicenseBindingSource;
            // 
            // OvertimeLicenseReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OvertimeLicenseReportForm";
            this.ShowIcon = false;
            this.Text = "مجوز اضافه کاری";
            this.Load += new System.EventHandler(this.OvertimeLicenseReportForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.overtimeLicenseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overtimeLicenseBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overtimeLicenseDetailsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overtimeLicenseDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView overtimeLicenseDataGridView;
        private System.Windows.Forms.BindingSource overtimeLicenseBindingSource;
        private System.Windows.Forms.DataGridView overtimeLicenseDetailsDataGridView;
        private System.Windows.Forms.BindingSource overtimeLicenseDetailsBindingSource;
        private System.Windows.Forms.Button searchButton;
        private FarsiLibrary.Win.Controls.FADatePicker DatePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersianDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PursonelNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AdministrativeStatus;
        private Stimulsoft.Controls.Win.DotNetBar.Controls.DataGridViewButtonXColumn Confirm;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private FarsiLibrary.Win.Controls.FADatePicker endDatePicker;
        private System.Windows.Forms.Button selectPersonButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox personelNumberTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
    }
}