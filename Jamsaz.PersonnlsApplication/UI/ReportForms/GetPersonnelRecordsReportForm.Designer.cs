namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    partial class GetPersonnelRecordsReportForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.a = new System.Windows.Forms.Label();
            this.toDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.encouragementRadioButton = new System.Windows.Forms.RadioButton();
            this.punishmentRadioButton = new System.Windows.Forms.RadioButton();
            this.personelNumberTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.reportButton = new System.Windows.Forms.Button();
            this.getPersonnelRecordsResultDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getPersonnelRecordsResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getPersonnelRecordsResultDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPersonnelRecordsResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.getPersonnelRecordsResultDataGridView, -1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(980, 568);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reportButton);
            this.groupBox1.Controls.Add(this.personelNumberTextBox);
            this.groupBox1.Controls.Add(this.fullNameTextBox);
            this.groupBox1.Controls.Add(this.punishmentRadioButton);
            this.groupBox1.Controls.Add(this.encouragementRadioButton);
            this.groupBox1.Controls.Add(this.toDatePicker);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DatePicker);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.refreshButton);
            this.groupBox1.Controls.Add(this.selectButton);
            this.groupBox1.Controls.Add(this.a);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(974, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refreshButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.refresh;
            this.refreshButton.Location = new System.Drawing.Point(9, 80);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(37, 24);
            this.refreshButton.TabIndex = 11;
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectButton.Location = new System.Drawing.Point(652, 74);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(37, 24);
            this.selectButton.TabIndex = 10;
            this.selectButton.Text = "...";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // a
            // 
            this.a.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(915, 80);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(42, 13);
            this.a.TabIndex = 8;
            this.a.Text = "پرسنل:";
            // 
            // toDatePicker
            // 
            this.toDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toDatePicker.Location = new System.Drawing.Point(512, 47);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(164, 20);
            this.toDatePicker.TabIndex = 55;
            this.toDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(682, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "تا تاریخ:";
            // 
            // DatePicker
            // 
            this.DatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DatePicker.Location = new System.Drawing.Point(745, 47);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(164, 20);
            this.DatePicker.TabIndex = 53;
            this.DatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(915, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "از تاریخ:";
            // 
            // encouragementRadioButton
            // 
            this.encouragementRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.encouragementRadioButton.AutoSize = true;
            this.encouragementRadioButton.Location = new System.Drawing.Point(896, 20);
            this.encouragementRadioButton.Name = "encouragementRadioButton";
            this.encouragementRadioButton.Size = new System.Drawing.Size(58, 17);
            this.encouragementRadioButton.TabIndex = 56;
            this.encouragementRadioButton.TabStop = true;
            this.encouragementRadioButton.Text = "تشویق";
            this.encouragementRadioButton.UseVisualStyleBackColor = true;
            // 
            // punishmentRadioButton
            // 
            this.punishmentRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.punishmentRadioButton.AutoSize = true;
            this.punishmentRadioButton.Location = new System.Drawing.Point(844, 20);
            this.punishmentRadioButton.Name = "punishmentRadioButton";
            this.punishmentRadioButton.Size = new System.Drawing.Size(46, 17);
            this.punishmentRadioButton.TabIndex = 57;
            this.punishmentRadioButton.TabStop = true;
            this.punishmentRadioButton.Text = "تنبیه";
            this.punishmentRadioButton.UseVisualStyleBackColor = true;
            // 
            // personelNumberTextBox
            // 
            this.personelNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.personelNumberTextBox.Location = new System.Drawing.Point(849, 75);
            this.personelNumberTextBox.Name = "personelNumberTextBox";
            this.personelNumberTextBox.ReadOnly = true;
            this.personelNumberTextBox.Size = new System.Drawing.Size(60, 21);
            this.personelNumberTextBox.TabIndex = 59;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fullNameTextBox.Location = new System.Drawing.Point(695, 75);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.ReadOnly = true;
            this.fullNameTextBox.Size = new System.Drawing.Size(148, 21);
            this.fullNameTextBox.TabIndex = 58;
            // 
            // reportButton
            // 
            this.reportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.reportButton.Location = new System.Drawing.Point(52, 80);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(75, 23);
            this.reportButton.TabIndex = 60;
            this.reportButton.Text = "گزارش";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // getPersonnelRecordsResultDataGridView
            // 
            this.getPersonnelRecordsResultDataGridView.AllowUserToAddRows = false;
            this.getPersonnelRecordsResultDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.getPersonnelRecordsResultDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.getPersonnelRecordsResultDataGridView.AutoGenerateColumns = false;
            this.getPersonnelRecordsResultDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.getPersonnelRecordsResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getPersonnelRecordsResultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.getPersonnelRecordsResultDataGridView.DataSource = this.getPersonnelRecordsResultBindingSource;
            this.getPersonnelRecordsResultDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.getPersonnelRecordsResultDataGridView.Location = new System.Drawing.Point(3, 123);
            this.getPersonnelRecordsResultDataGridView.Name = "getPersonnelRecordsResultDataGridView";
            this.getPersonnelRecordsResultDataGridView.ReadOnly = true;
            this.getPersonnelRecordsResultDataGridView.Size = new System.Drawing.Size(974, 442);
            this.getPersonnelRecordsResultDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PersonnelNumber";
            this.dataGridViewTextBoxColumn1.HeaderText = "شماره پرسنلی";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn2.HeaderText = "پرسنل";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PersianDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "تاریخ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Reason";
            this.dataGridViewTextBoxColumn4.HeaderText = "دلیل";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 300;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn5.HeaderText = "توضیحات";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 300;
            // 
            // getPersonnelRecordsResultBindingSource
            // 
            this.getPersonnelRecordsResultBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.GetPersonnelRecordsResult);
            // 
            // GetPersonnelRecordsReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 568);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GetPersonnelRecordsReportForm";
            this.ShowIcon = false;
            this.Text = "گزارش تشویق و تنبیه";
            this.Load += new System.EventHandler(this.GetPersonnelRecordsReportForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getPersonnelRecordsResultDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPersonnelRecordsResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.RadioButton punishmentRadioButton;
        private System.Windows.Forms.RadioButton encouragementRadioButton;
        private FarsiLibrary.Win.Controls.FADatePicker toDatePicker;
        private System.Windows.Forms.Label label4;
        private FarsiLibrary.Win.Controls.FADatePicker DatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox personelNumberTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.DataGridView getPersonnelRecordsResultDataGridView;
        private System.Windows.Forms.BindingSource getPersonnelRecordsResultBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}