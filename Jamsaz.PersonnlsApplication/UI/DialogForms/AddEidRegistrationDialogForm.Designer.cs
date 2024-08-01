namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class AddEidRegistrationDialogForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fiscalyearComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.personnelNumberTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.fiscalYearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eidRegistrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.m1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m9DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m10DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m11DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m12DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fiscalYearBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eidRegistrationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.02439F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.97561F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(864, 328);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancelButton);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(858, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.arrow_up;
            this.cancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelButton.Location = new System.Drawing.Point(90, 16);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "لغو";
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.arrow_down;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveButton.Location = new System.Drawing.Point(9, 16);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "تایید";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.selectButton);
            this.groupBox2.Controls.Add(this.FullNameTextBox);
            this.groupBox2.Controls.Add(this.personnelNumberTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.fiscalyearComboBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(858, 98);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // fiscalyearComboBox
            // 
            this.fiscalyearComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fiscalyearComboBox.DataSource = this.fiscalYearBindingSource;
            this.fiscalyearComboBox.DisplayMember = "Title";
            this.fiscalyearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fiscalyearComboBox.FormattingEnabled = true;
            this.fiscalyearComboBox.Location = new System.Drawing.Point(649, 29);
            this.fiscalyearComboBox.Name = "fiscalyearComboBox";
            this.fiscalyearComboBox.Size = new System.Drawing.Size(121, 21);
            this.fiscalyearComboBox.TabIndex = 0;
            this.fiscalyearComboBox.ValueMember = "ID";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(776, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "سال مالی:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(776, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "پرسنل:";
            // 
            // personnelNumberTextBox
            // 
            this.personnelNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.personnelNumberTextBox.Location = new System.Drawing.Point(713, 57);
            this.personnelNumberTextBox.Name = "personnelNumberTextBox";
            this.personnelNumberTextBox.ReadOnly = true;
            this.personnelNumberTextBox.Size = new System.Drawing.Size(57, 21);
            this.personnelNumberTextBox.TabIndex = 3;
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextBox.Location = new System.Drawing.Point(508, 57);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.ReadOnly = true;
            this.FullNameTextBox.Size = new System.Drawing.Size(204, 21);
            this.FullNameTextBox.TabIndex = 4;
            // 
            // selectButton
            // 
            this.selectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectButton.Location = new System.Drawing.Point(478, 56);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(28, 23);
            this.selectButton.TabIndex = 5;
            this.selectButton.Text = "...";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // fiscalYearBindingSource
            // 
            this.fiscalYearBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.FiscalYear);
            // 
            // eidRegistrationBindingSource
            // 
            this.eidRegistrationBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.EidRegistration);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m1DataGridViewTextBoxColumn,
            this.m2DataGridViewTextBoxColumn,
            this.m3DataGridViewTextBoxColumn,
            this.m4DataGridViewTextBoxColumn,
            this.m5DataGridViewTextBoxColumn,
            this.m6DataGridViewTextBoxColumn,
            this.m7DataGridViewTextBoxColumn,
            this.m8DataGridViewTextBoxColumn,
            this.m9DataGridViewTextBoxColumn,
            this.m10DataGridViewTextBoxColumn,
            this.m11DataGridViewTextBoxColumn,
            this.m12DataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eidRegistrationBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(858, 157);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // m1DataGridViewTextBoxColumn
            // 
            this.m1DataGridViewTextBoxColumn.DataPropertyName = "M1";
            this.m1DataGridViewTextBoxColumn.HeaderText = "فروردین";
            this.m1DataGridViewTextBoxColumn.Name = "m1DataGridViewTextBoxColumn";
            this.m1DataGridViewTextBoxColumn.Width = 60;
            // 
            // m2DataGridViewTextBoxColumn
            // 
            this.m2DataGridViewTextBoxColumn.DataPropertyName = "M2";
            this.m2DataGridViewTextBoxColumn.HeaderText = "اردیبهشت";
            this.m2DataGridViewTextBoxColumn.Name = "m2DataGridViewTextBoxColumn";
            this.m2DataGridViewTextBoxColumn.Width = 60;
            // 
            // m3DataGridViewTextBoxColumn
            // 
            this.m3DataGridViewTextBoxColumn.DataPropertyName = "M3";
            this.m3DataGridViewTextBoxColumn.HeaderText = "خرداد";
            this.m3DataGridViewTextBoxColumn.Name = "m3DataGridViewTextBoxColumn";
            this.m3DataGridViewTextBoxColumn.Width = 60;
            // 
            // m4DataGridViewTextBoxColumn
            // 
            this.m4DataGridViewTextBoxColumn.DataPropertyName = "M4";
            this.m4DataGridViewTextBoxColumn.HeaderText = "تیر";
            this.m4DataGridViewTextBoxColumn.Name = "m4DataGridViewTextBoxColumn";
            this.m4DataGridViewTextBoxColumn.Width = 60;
            // 
            // m5DataGridViewTextBoxColumn
            // 
            this.m5DataGridViewTextBoxColumn.DataPropertyName = "M5";
            this.m5DataGridViewTextBoxColumn.HeaderText = "مرداد";
            this.m5DataGridViewTextBoxColumn.Name = "m5DataGridViewTextBoxColumn";
            this.m5DataGridViewTextBoxColumn.Width = 60;
            // 
            // m6DataGridViewTextBoxColumn
            // 
            this.m6DataGridViewTextBoxColumn.DataPropertyName = "M6";
            this.m6DataGridViewTextBoxColumn.HeaderText = "شهریور";
            this.m6DataGridViewTextBoxColumn.Name = "m6DataGridViewTextBoxColumn";
            this.m6DataGridViewTextBoxColumn.Width = 60;
            // 
            // m7DataGridViewTextBoxColumn
            // 
            this.m7DataGridViewTextBoxColumn.DataPropertyName = "M7";
            this.m7DataGridViewTextBoxColumn.HeaderText = "مهر";
            this.m7DataGridViewTextBoxColumn.Name = "m7DataGridViewTextBoxColumn";
            this.m7DataGridViewTextBoxColumn.Width = 60;
            // 
            // m8DataGridViewTextBoxColumn
            // 
            this.m8DataGridViewTextBoxColumn.DataPropertyName = "M8";
            this.m8DataGridViewTextBoxColumn.HeaderText = "آبان";
            this.m8DataGridViewTextBoxColumn.Name = "m8DataGridViewTextBoxColumn";
            this.m8DataGridViewTextBoxColumn.Width = 60;
            // 
            // m9DataGridViewTextBoxColumn
            // 
            this.m9DataGridViewTextBoxColumn.DataPropertyName = "M9";
            this.m9DataGridViewTextBoxColumn.HeaderText = "آذر";
            this.m9DataGridViewTextBoxColumn.Name = "m9DataGridViewTextBoxColumn";
            this.m9DataGridViewTextBoxColumn.Width = 60;
            // 
            // m10DataGridViewTextBoxColumn
            // 
            this.m10DataGridViewTextBoxColumn.DataPropertyName = "M10";
            this.m10DataGridViewTextBoxColumn.HeaderText = "دی";
            this.m10DataGridViewTextBoxColumn.Name = "m10DataGridViewTextBoxColumn";
            this.m10DataGridViewTextBoxColumn.Width = 60;
            // 
            // m11DataGridViewTextBoxColumn
            // 
            this.m11DataGridViewTextBoxColumn.DataPropertyName = "M11";
            this.m11DataGridViewTextBoxColumn.HeaderText = "بهمن";
            this.m11DataGridViewTextBoxColumn.Name = "m11DataGridViewTextBoxColumn";
            this.m11DataGridViewTextBoxColumn.Width = 60;
            // 
            // m12DataGridViewTextBoxColumn
            // 
            this.m12DataGridViewTextBoxColumn.DataPropertyName = "M12";
            this.m12DataGridViewTextBoxColumn.HeaderText = "اسفند";
            this.m12DataGridViewTextBoxColumn.Name = "m12DataGridViewTextBoxColumn";
            this.m12DataGridViewTextBoxColumn.Width = 60;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "جمع";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.Width = 60;
            // 
            // AddEidRegistrationDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 328);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddEidRegistrationDialogForm";
            this.ShowIcon = false;
            this.Text = "ثبت";
            this.Load += new System.EventHandler(this.AddEidRegistrationDialogForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fiscalYearBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eidRegistrationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.TextBox personnelNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox fiscalyearComboBox;
        private System.Windows.Forms.BindingSource fiscalYearBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn m1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m9DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m10DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m11DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m12DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource eidRegistrationBindingSource;
    }
}