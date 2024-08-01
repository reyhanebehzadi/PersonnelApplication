namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class AddIncreaseManagementDialogForm
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
            System.Windows.Forms.Label codeLabel;
            System.Windows.Forms.Label effectiveDateLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddIncreaseManagementDialogForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.faDatePicker1 = new FarsiLibrary.Win.Controls.FADatePicker();
            this.increaseManagementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.voidBbutton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.increaseManagementDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayeGhabli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncreaseAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.increaseManagementDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            codeLabel = new System.Windows.Forms.Label();
            effectiveDateLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.increaseManagementBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.increaseManagementDetailsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.increaseManagementDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(826, 20);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(25, 13);
            codeLabel.TabIndex = 0;
            codeLabel.Text = "کد :";
            // 
            // effectiveDateLabel
            // 
            effectiveDateLabel.AutoSize = true;
            effectiveDateLabel.Location = new System.Drawing.Point(816, 51);
            effectiveDateLabel.Name = "effectiveDateLabel";
            effectiveDateLabel.Size = new System.Drawing.Size(35, 13);
            effectiveDateLabel.TabIndex = 2;
            effectiveDateLabel.Text = "تاریخ :";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(866, 631);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.faDatePicker1);
            this.groupBox1.Controls.Add(effectiveDateLabel);
            this.groupBox1.Controls.Add(codeLabel);
            this.groupBox1.Controls.Add(this.codeTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // faDatePicker1
            // 
            this.faDatePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.faDatePicker1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedDateTime", this.increaseManagementBindingSource, "EffectiveDate", true));
            this.faDatePicker1.Location = new System.Drawing.Point(650, 44);
            this.faDatePicker1.Name = "faDatePicker1";
            this.faDatePicker1.Size = new System.Drawing.Size(160, 20);
            this.faDatePicker1.TabIndex = 3;
            this.faDatePicker1.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // increaseManagementBindingSource
            // 
            this.increaseManagementBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.IncreaseManagement);
            // 
            // codeTextBox
            // 
            this.codeTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.increaseManagementBindingSource, "Code", true));
            this.codeTextBox.Location = new System.Drawing.Point(710, 17);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.ReadOnly = true;
            this.codeTextBox.Size = new System.Drawing.Size(100, 21);
            this.codeTextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.voidBbutton);
            this.groupBox2.Controls.Add(this.saveButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 574);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(860, 54);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // voidBbutton
            // 
            this.voidBbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.voidBbutton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.arrow_up;
            this.voidBbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.voidBbutton.Location = new System.Drawing.Point(90, 20);
            this.voidBbutton.Name = "voidBbutton";
            this.voidBbutton.Size = new System.Drawing.Size(75, 23);
            this.voidBbutton.TabIndex = 1;
            this.voidBbutton.Text = "لغو";
            this.voidBbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.voidBbutton.UseVisualStyleBackColor = true;
            this.voidBbutton.Click += new System.EventHandler(this.voidBbutton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.arrow_down;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveButton.Location = new System.Drawing.Point(9, 20);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "تأیید";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.increaseManagementDetailsDataGridView);
            this.groupBox3.Controls.Add(this.deleteButton);
            this.groupBox3.Controls.Add(this.addButton);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(860, 483);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // increaseManagementDetailsDataGridView
            // 
            this.increaseManagementDetailsDataGridView.AllowUserToAddRows = false;
            this.increaseManagementDetailsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.increaseManagementDetailsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.increaseManagementDetailsDataGridView.AutoGenerateColumns = false;
            this.increaseManagementDetailsDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.increaseManagementDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.increaseManagementDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.PayeGhabli,
            this.IncreaseAmount,
            this.dataGridViewTextBoxColumn11});
            this.increaseManagementDetailsDataGridView.DataSource = this.increaseManagementDetailsBindingSource;
            this.increaseManagementDetailsDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.increaseManagementDetailsDataGridView.Location = new System.Drawing.Point(3, 17);
            this.increaseManagementDetailsDataGridView.Name = "increaseManagementDetailsDataGridView";
            this.increaseManagementDetailsDataGridView.Size = new System.Drawing.Size(854, 431);
            this.increaseManagementDetailsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PersonnelNumber";
            this.dataGridViewTextBoxColumn8.HeaderText = "ش پرسنلی";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "PersonnelName";
            this.dataGridViewTextBoxColumn9.HeaderText = "نام پرسنل";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 200;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Semat";
            this.dataGridViewTextBoxColumn10.HeaderText = "سمت سازمانی";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 200;
            // 
            // PayeGhabli
            // 
            this.PayeGhabli.DataPropertyName = "PayeGhabli";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.PayeGhabli.DefaultCellStyle = dataGridViewCellStyle2;
            this.PayeGhabli.HeaderText = "پایه حقوق قبلی";
            this.PayeGhabli.Name = "PayeGhabli";
            // 
            // IncreaseAmount
            // 
            this.IncreaseAmount.DataPropertyName = "IncreaseAmount";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.IncreaseAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.IncreaseAmount.HeaderText = "میزان افزایش";
            this.IncreaseAmount.Name = "IncreaseAmount";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "PayeHoghogh";
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn11.HeaderText = "پایه حقوق جدید";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // increaseManagementDetailsBindingSource
            // 
            this.increaseManagementDetailsBindingSource.DataMember = "IncreaseManagementDetails";
            this.increaseManagementDetailsBindingSource.DataSource = this.increaseManagementBindingSource;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteButton.Location = new System.Drawing.Point(710, 454);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(70, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "حذف";
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addButton.Location = new System.Drawing.Point(786, 454);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(70, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "اضافه";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IncreaseManagement";
            this.dataGridViewTextBoxColumn1.HeaderText = "IncreaseManagement";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // AddIncreaseManagementDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 631);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddIncreaseManagementDialogForm";
            this.ShowIcon = false;
            this.Text = "ثبت اطلاعات";
            this.Load += new System.EventHandler(this.AddIncreaseManagementDialogForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.increaseManagementBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.increaseManagementDetailsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.increaseManagementDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource increaseManagementBindingSource;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button voidBbutton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.BindingSource increaseManagementDetailsBindingSource;
        private System.Windows.Forms.DataGridView increaseManagementDetailsDataGridView;
        private FarsiLibrary.Win.Controls.FADatePicker faDatePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayeGhabli;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncreaseAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}