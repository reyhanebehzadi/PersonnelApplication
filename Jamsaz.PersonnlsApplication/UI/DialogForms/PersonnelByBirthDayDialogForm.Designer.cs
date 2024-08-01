namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class PersonnelByBirthDayDialogForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.voidButton = new System.Windows.Forms.Button();
            this.exportToExcelButton = new System.Windows.Forms.Button();
            this.factoryRadioButton = new System.Windows.Forms.RadioButton();
            this.headOfficeRadioButton = new System.Windows.Forms.RadioButton();
            this.faDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.personnelNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brithDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectPersonnelsByBirthdayResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectPersonnelsByBirthdayResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(218)))), ((int)(((byte)(254)))));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personnelNumberDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.brithDateDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.selectPersonnelsByBirthdayResultBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(2, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 30;
            this.dataGridView.Size = new System.Drawing.Size(728, 424);
            this.dataGridView.TabIndex = 0;
            // 
            // voidButton
            // 
            this.voidButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.voidButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.voidButton.Location = new System.Drawing.Point(645, 433);
            this.voidButton.Name = "voidButton";
            this.voidButton.Size = new System.Drawing.Size(85, 23);
            this.voidButton.TabIndex = 1;
            this.voidButton.Text = "بستن";
            this.voidButton.UseVisualStyleBackColor = true;
            this.voidButton.Click += new System.EventHandler(this.voidButton_Click);
            // 
            // exportToExcelButton
            // 
            this.exportToExcelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exportToExcelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exportToExcelButton.Location = new System.Drawing.Point(2, 433);
            this.exportToExcelButton.Name = "exportToExcelButton";
            this.exportToExcelButton.Size = new System.Drawing.Size(112, 23);
            this.exportToExcelButton.TabIndex = 2;
            this.exportToExcelButton.Text = "تبدیل به فایل Excel";
            this.exportToExcelButton.UseVisualStyleBackColor = true;
            this.exportToExcelButton.Click += new System.EventHandler(this.exportToExcelButton_Click);
            // 
            // factoryRadioButton
            // 
            this.factoryRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.factoryRadioButton.AutoSize = true;
            this.factoryRadioButton.Checked = true;
            this.factoryRadioButton.Location = new System.Drawing.Point(130, 439);
            this.factoryRadioButton.Name = "factoryRadioButton";
            this.factoryRadioButton.Size = new System.Drawing.Size(56, 17);
            this.factoryRadioButton.TabIndex = 3;
            this.factoryRadioButton.TabStop = true;
            this.factoryRadioButton.Text = "کارخانه";
            this.factoryRadioButton.UseVisualStyleBackColor = true;
            this.factoryRadioButton.CheckedChanged += new System.EventHandler(this.factoryRadioButton_CheckedChanged);
            // 
            // headOfficeRadioButton
            // 
            this.headOfficeRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.headOfficeRadioButton.AutoSize = true;
            this.headOfficeRadioButton.Location = new System.Drawing.Point(192, 439);
            this.headOfficeRadioButton.Name = "headOfficeRadioButton";
            this.headOfficeRadioButton.Size = new System.Drawing.Size(78, 17);
            this.headOfficeRadioButton.TabIndex = 4;
            this.headOfficeRadioButton.Text = "دفتر مرکزی";
            this.headOfficeRadioButton.UseVisualStyleBackColor = true;
            this.headOfficeRadioButton.CheckedChanged += new System.EventHandler(this.headOfficeRadioButton_CheckedChanged);
            // 
            // faDatePicker
            // 
            this.faDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.faDatePicker.Location = new System.Drawing.Point(276, 436);
            this.faDatePicker.Name = "faDatePicker";
            this.faDatePicker.ScrollOption = FarsiLibrary.Win.Enums.ScrollOptionTypes.Year;
            this.faDatePicker.Size = new System.Drawing.Size(135, 20);
            this.faDatePicker.TabIndex = 5;
            this.faDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            
            // 
            // personnelNumberDataGridViewTextBoxColumn
            // 
            this.personnelNumberDataGridViewTextBoxColumn.DataPropertyName = "PersonnelNumber";
            this.personnelNumberDataGridViewTextBoxColumn.HeaderText = "شماره پرسنلی";
            this.personnelNumberDataGridViewTextBoxColumn.Name = "personnelNumberDataGridViewTextBoxColumn";
            this.personnelNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.personnelNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "نام و نام خانوادگی";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullNameDataGridViewTextBoxColumn.Width = 225;
            // 
            // brithDateDataGridViewTextBoxColumn
            // 
            this.brithDateDataGridViewTextBoxColumn.DataPropertyName = "BrithDate";
            this.brithDateDataGridViewTextBoxColumn.HeaderText = "تاریخ تولد";
            this.brithDateDataGridViewTextBoxColumn.Name = "brithDateDataGridViewTextBoxColumn";
            this.brithDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "واحد";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
            this.departmentDataGridViewTextBoxColumn.Width = 200;
            // 
            // selectPersonnelsByBirthdayResultBindingSource
            // 
            this.selectPersonnelsByBirthdayResultBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.SelectPersonnelsByBirthdayResult);
            // 
            // PersonnelByBirthDayDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(218)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.faDatePicker);
            this.Controls.Add(this.headOfficeRadioButton);
            this.Controls.Add(this.factoryRadioButton);
            this.Controls.Add(this.exportToExcelButton);
            this.Controls.Add(this.voidButton);
            this.Controls.Add(this.dataGridView);
            this.Name = "PersonnelByBirthDayDialogForm";
            this.ShowIcon = false;
            this.Text = "";
            this.Load += new System.EventHandler(this.PersonnelByBirthDayDialogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectPersonnelsByBirthdayResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button voidButton;
        private System.Windows.Forms.Button exportToExcelButton;
        private System.Windows.Forms.BindingSource selectPersonnelsByBirthdayResultBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnelNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brithDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.RadioButton factoryRadioButton;
        private System.Windows.Forms.RadioButton headOfficeRadioButton;
        private FarsiLibrary.Win.Controls.FADatePicker faDatePicker;
    }
}