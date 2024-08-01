namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    partial class SettlementReportForm
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personnelNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentChildNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persianDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complainedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.complainedAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paycomplaintDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.accidentComplaintDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.accidentComplaintAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payAccidentComplaintDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.unemploymentInsuranceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getSettlementReportResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.payCheckBox = new System.Windows.Forms.CheckBox();
            this.accidentComplaintCheckBox = new System.Windows.Forms.CheckBox();
            this.complainedCheckBox = new System.Windows.Forms.CheckBox();
            this.showButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.toDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.SettlementCategorycomboBox = new System.Windows.Forms.ComboBox();
            this.settlementCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fromDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            dateLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSettlementReportResultBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settlementCategoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(1434, 27);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(42, 13);
            dateLabel.TabIndex = 46;
            dateLabel.Text = "از تاریخ:";
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(1228, 27);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(41, 13);
            label2.TabIndex = 54;
            label2.Text = "تا تاریخ:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1517, 619);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personnelNumberDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.departmentNameDataGridViewTextBoxColumn,
            this.departmentChildNameDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.persianDateDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.complainedDataGridViewTextBoxColumn,
            this.complainedAmountDataGridViewTextBoxColumn,
            this.paycomplaintDataGridViewTextBoxColumn,
            this.accidentComplaintDataGridViewTextBoxColumn,
            this.accidentComplaintAmountDataGridViewTextBoxColumn,
            this.payAccidentComplaintDataGridViewTextBoxColumn,
            this.unemploymentInsuranceDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.getSettlementReportResultBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1511, 513);
            this.dataGridView1.TabIndex = 63;
            // 
            // personnelNumberDataGridViewTextBoxColumn
            // 
            this.personnelNumberDataGridViewTextBoxColumn.DataPropertyName = "PersonnelNumber";
            this.personnelNumberDataGridViewTextBoxColumn.HeaderText = "شماره پرسنلی";
            this.personnelNumberDataGridViewTextBoxColumn.Name = "personnelNumberDataGridViewTextBoxColumn";
            this.personnelNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "پرسنل";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentNameDataGridViewTextBoxColumn
            // 
            this.departmentNameDataGridViewTextBoxColumn.DataPropertyName = "DepartmentName";
            this.departmentNameDataGridViewTextBoxColumn.HeaderText = "واحد";
            this.departmentNameDataGridViewTextBoxColumn.Name = "departmentNameDataGridViewTextBoxColumn";
            this.departmentNameDataGridViewTextBoxColumn.ReadOnly = true;
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
            // 
            // persianDateDataGridViewTextBoxColumn
            // 
            this.persianDateDataGridViewTextBoxColumn.DataPropertyName = "PersianDate";
            this.persianDateDataGridViewTextBoxColumn.HeaderText = "تاریخ تسویه";
            this.persianDateDataGridViewTextBoxColumn.Name = "persianDateDataGridViewTextBoxColumn";
            this.persianDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.persianDateDataGridViewTextBoxColumn.Width = 80;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "علت تسویه";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            dataGridViewCellStyle6.Format = "N0";
            this.priceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.priceDataGridViewTextBoxColumn.HeaderText = "مبلغ محاسبه شده";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // complainedDataGridViewTextBoxColumn
            // 
            this.complainedDataGridViewTextBoxColumn.DataPropertyName = "Complained";
            this.complainedDataGridViewTextBoxColumn.HeaderText = "شکایت تسویه";
            this.complainedDataGridViewTextBoxColumn.Name = "complainedDataGridViewTextBoxColumn";
            this.complainedDataGridViewTextBoxColumn.ReadOnly = true;
            this.complainedDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.complainedDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // complainedAmountDataGridViewTextBoxColumn
            // 
            this.complainedAmountDataGridViewTextBoxColumn.DataPropertyName = "ComplainedAmount";
            dataGridViewCellStyle7.Format = "N0";
            this.complainedAmountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.complainedAmountDataGridViewTextBoxColumn.HeaderText = "مبلغ تسویه";
            this.complainedAmountDataGridViewTextBoxColumn.Name = "complainedAmountDataGridViewTextBoxColumn";
            this.complainedAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paycomplaintDataGridViewTextBoxColumn
            // 
            this.paycomplaintDataGridViewTextBoxColumn.DataPropertyName = "Pay_complaint";
            this.paycomplaintDataGridViewTextBoxColumn.HeaderText = "پرداخت تسویه";
            this.paycomplaintDataGridViewTextBoxColumn.Name = "paycomplaintDataGridViewTextBoxColumn";
            this.paycomplaintDataGridViewTextBoxColumn.ReadOnly = true;
            this.paycomplaintDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.paycomplaintDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // accidentComplaintDataGridViewTextBoxColumn
            // 
            this.accidentComplaintDataGridViewTextBoxColumn.DataPropertyName = "AccidentComplaint";
            this.accidentComplaintDataGridViewTextBoxColumn.HeaderText = "شکایت حادثه";
            this.accidentComplaintDataGridViewTextBoxColumn.Name = "accidentComplaintDataGridViewTextBoxColumn";
            this.accidentComplaintDataGridViewTextBoxColumn.ReadOnly = true;
            this.accidentComplaintDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.accidentComplaintDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.accidentComplaintDataGridViewTextBoxColumn.Width = 80;
            // 
            // accidentComplaintAmountDataGridViewTextBoxColumn
            // 
            this.accidentComplaintAmountDataGridViewTextBoxColumn.DataPropertyName = "AccidentComplaintAmount";
            dataGridViewCellStyle8.Format = "N0";
            this.accidentComplaintAmountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.accidentComplaintAmountDataGridViewTextBoxColumn.HeaderText = "مبلغ حادثه";
            this.accidentComplaintAmountDataGridViewTextBoxColumn.Name = "accidentComplaintAmountDataGridViewTextBoxColumn";
            this.accidentComplaintAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // payAccidentComplaintDataGridViewTextBoxColumn
            // 
            this.payAccidentComplaintDataGridViewTextBoxColumn.DataPropertyName = "Pay_AccidentComplaint";
            this.payAccidentComplaintDataGridViewTextBoxColumn.HeaderText = "پرداخت حادثه";
            this.payAccidentComplaintDataGridViewTextBoxColumn.Name = "payAccidentComplaintDataGridViewTextBoxColumn";
            this.payAccidentComplaintDataGridViewTextBoxColumn.ReadOnly = true;
            this.payAccidentComplaintDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.payAccidentComplaintDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // unemploymentInsuranceDataGridViewTextBoxColumn
            // 
            this.unemploymentInsuranceDataGridViewTextBoxColumn.DataPropertyName = "UnemploymentInsurance";
            this.unemploymentInsuranceDataGridViewTextBoxColumn.HeaderText = "بیمه بیکاری";
            this.unemploymentInsuranceDataGridViewTextBoxColumn.Name = "unemploymentInsuranceDataGridViewTextBoxColumn";
            this.unemploymentInsuranceDataGridViewTextBoxColumn.ReadOnly = true;
            this.unemploymentInsuranceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.unemploymentInsuranceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "توضیحات";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 250;
            // 
            // getSettlementReportResultBindingSource
            // 
            this.getSettlementReportResultBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.GetSettlementReportResult);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.payCheckBox);
            this.groupBox1.Controls.Add(this.accidentComplaintCheckBox);
            this.groupBox1.Controls.Add(this.complainedCheckBox);
            this.groupBox1.Controls.Add(this.showButton);
            this.groupBox1.Controls.Add(this.printButton);
            this.groupBox1.Controls.Add(this.toDatePicker);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.SettlementCategorycomboBox);
            this.groupBox1.Controls.Add(this.fromDatePicker);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(dateLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1511, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو";
            // 
            // payCheckBox
            // 
            this.payCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.payCheckBox.AutoSize = true;
            this.payCheckBox.Location = new System.Drawing.Point(970, 58);
            this.payCheckBox.Name = "payCheckBox";
            this.payCheckBox.Size = new System.Drawing.Size(91, 17);
            this.payCheckBox.TabIndex = 60;
            this.payCheckBox.Text = "پرداخت تسویه";
            this.payCheckBox.UseVisualStyleBackColor = true;
            // 
            // accidentComplaintCheckBox
            // 
            this.accidentComplaintCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.accidentComplaintCheckBox.AutoSize = true;
            this.accidentComplaintCheckBox.Location = new System.Drawing.Point(1076, 58);
            this.accidentComplaintCheckBox.Name = "accidentComplaintCheckBox";
            this.accidentComplaintCheckBox.Size = new System.Drawing.Size(86, 17);
            this.accidentComplaintCheckBox.TabIndex = 59;
            this.accidentComplaintCheckBox.Text = "شکایت حادثه";
            this.accidentComplaintCheckBox.UseVisualStyleBackColor = true;
            // 
            // complainedCheckBox
            // 
            this.complainedCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.complainedCheckBox.AutoSize = true;
            this.complainedCheckBox.Location = new System.Drawing.Point(1168, 58);
            this.complainedCheckBox.Name = "complainedCheckBox";
            this.complainedCheckBox.Size = new System.Drawing.Size(91, 17);
            this.complainedCheckBox.TabIndex = 58;
            this.complainedCheckBox.Text = "شکایت تسویه";
            this.complainedCheckBox.UseVisualStyleBackColor = true;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(6, 37);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(86, 23);
            this.showButton.TabIndex = 57;
            this.showButton.Text = "گزارش";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(6, 63);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(89, 23);
            this.printButton.TabIndex = 56;
            this.printButton.Text = "چاپ";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // toDatePicker
            // 
            this.toDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.toDatePicker.Location = new System.Drawing.Point(1076, 23);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(146, 20);
            this.toDatePicker.TabIndex = 55;
            this.toDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // SettlementCategorycomboBox
            // 
            this.SettlementCategorycomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SettlementCategorycomboBox.DataSource = this.settlementCategoryBindingSource;
            this.SettlementCategorycomboBox.DisplayMember = "Title";
            this.SettlementCategorycomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SettlementCategorycomboBox.FormattingEnabled = true;
            this.SettlementCategorycomboBox.Location = new System.Drawing.Point(1282, 56);
            this.SettlementCategorycomboBox.Name = "SettlementCategorycomboBox";
            this.SettlementCategorycomboBox.Size = new System.Drawing.Size(147, 21);
            this.SettlementCategorycomboBox.TabIndex = 49;
            this.SettlementCategorycomboBox.ValueMember = "ID";
            // 
            // settlementCategoryBindingSource
            // 
            this.settlementCategoryBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.SettlementCategory);
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fromDatePicker.IsDefault = true;
            this.fromDatePicker.Location = new System.Drawing.Point(1282, 23);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(146, 20);
            this.fromDatePicker.TabIndex = 48;
            this.fromDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1435, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "علت تسویه:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 61;
            this.button1.Text = "نمایش همه";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SettlementReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 619);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SettlementReportForm";
            this.ShowIcon = false;
            this.Text = "گزارش تسویه پرسنل";
            this.Load += new System.EventHandler(this.SettlementReportForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSettlementReportResultBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settlementCategoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private FarsiLibrary.Win.Controls.FADatePicker toDatePicker;
        private System.Windows.Forms.ComboBox SettlementCategorycomboBox;
        private FarsiLibrary.Win.Controls.FADatePicker fromDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource settlementCategoryBindingSource;
        private System.Windows.Forms.BindingSource getSettlementReportResultBindingSource;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.CheckBox accidentComplaintCheckBox;
        private System.Windows.Forms.CheckBox complainedCheckBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnelNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentChildNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persianDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn complainedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complainedAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn paycomplaintDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn accidentComplaintDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accidentComplaintAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn payAccidentComplaintDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn unemploymentInsuranceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox payCheckBox;
        private System.Windows.Forms.Button button1;
    }
}