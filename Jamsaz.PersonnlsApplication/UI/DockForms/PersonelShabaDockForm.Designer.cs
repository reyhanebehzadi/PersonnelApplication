namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    partial class PersonelShabaDockForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.personnelDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShebaNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.topPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.searchGroupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bankTypeCombo = new System.Windows.Forms.ComboBox();
            this.bankBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shabaButton = new System.Windows.Forms.Button();
            this.reportBtn = new System.Windows.Forms.Button();
            this.personnelNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.perssonelNumberLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personnelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).BeginInit();
            this.topPanel.SuspendLayout();
            this.searchGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.personnelDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.topPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.34623F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.65377F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1220, 517);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // personnelDataGridView
            // 
            this.personnelDataGridView.AllowUserToAddRows = false;
            this.personnelDataGridView.AllowUserToDeleteRows = false;
            this.personnelDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.personnelDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.personnelDataGridView.AutoGenerateColumns = false;
            this.personnelDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.personnelDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.personnelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personnelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.AccountNumber,
            this.ShebaNumber,
            this.BankType,
            this.BankID,
            this.Id});
            this.personnelDataGridView.DataSource = this.personnelBindingSource;
            this.personnelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personnelDataGridView.Location = new System.Drawing.Point(3, 72);
            this.personnelDataGridView.MultiSelect = false;
            this.personnelDataGridView.Name = "personnelDataGridView";
            this.personnelDataGridView.ReadOnly = true;
            this.personnelDataGridView.RowTemplate.Height = 25;
            this.personnelDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.personnelDataGridView.Size = new System.Drawing.Size(1214, 442);
            this.personnelDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PersonnelNumber";
            this.dataGridViewTextBoxColumn2.FillWeight = 30F;
            this.dataGridViewTextBoxColumn2.HeaderText = "شماره پرسنل";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn3.FillWeight = 80F;
            this.dataGridViewTextBoxColumn3.HeaderText = "نام";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LastName";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn4.HeaderText = "نام خانوادگی";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // AccountNumber
            // 
            this.AccountNumber.DataPropertyName = "AccountNumber";
            this.AccountNumber.HeaderText = "شماره حساب";
            this.AccountNumber.Name = "AccountNumber";
            this.AccountNumber.ReadOnly = true;
            // 
            // ShebaNumber
            // 
            this.ShebaNumber.DataPropertyName = "ShebaNumber";
            this.ShebaNumber.HeaderText = "شماره شبا";
            this.ShebaNumber.Name = "ShebaNumber";
            this.ShebaNumber.ReadOnly = true;
            // 
            // BankType
            // 
            this.BankType.DataPropertyName = "BankAccountType";
            this.BankType.HeaderText = "نوع حساب";
            this.BankType.Name = "BankType";
            this.BankType.ReadOnly = true;
            // 
            // BankID
            // 
            this.BankID.DataPropertyName = "BankID";
            this.BankID.HeaderText = "BankID";
            this.BankID.Name = "BankID";
            this.BankID.ReadOnly = true;
            this.BankID.Visible = false;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // personnelBindingSource
            // 
            this.personnelBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.vwAccountNumberPersonnely_SearchAdvancedResult);
            // 
            // topPanel
            // 
            this.topPanel.AutoScroll = true;
            this.topPanel.AutoScrollMinSize = new System.Drawing.Size(110, 0);
            this.topPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.searchGroupBox1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topPanel.Location = new System.Drawing.Point(3, 3);
            this.topPanel.Name = "topPanel";
            this.topPanel.Padding = new System.Windows.Forms.Padding(4);
            this.topPanel.Size = new System.Drawing.Size(1214, 63);
            this.topPanel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(891, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 14);
            this.label1.TabIndex = 56;
            this.label1.Text = " جستجو پرسنلی ";
            // 
            // searchGroupBox1
            // 
            this.searchGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.searchGroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchGroupBox1.Controls.Add(this.label2);
            this.searchGroupBox1.Controls.Add(this.bankTypeCombo);
            this.searchGroupBox1.Controls.Add(this.shabaButton);
            this.searchGroupBox1.Controls.Add(this.reportBtn);
            this.searchGroupBox1.Controls.Add(this.personnelNumberTextBox);
            this.searchGroupBox1.Controls.Add(this.perssonelNumberLabel);
            this.searchGroupBox1.Controls.Add(this.SearchButton);
            this.searchGroupBox1.Controls.Add(this.lastNameLabel);
            this.searchGroupBox1.Controls.Add(this.nameLabel);
            this.searchGroupBox1.Controls.Add(this.lastNameTextBox);
            this.searchGroupBox1.Controls.Add(this.NameTextBox);
            this.searchGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchGroupBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.searchGroupBox1.Location = new System.Drawing.Point(4, 4);
            this.searchGroupBox1.Name = "searchGroupBox1";
            this.searchGroupBox1.Size = new System.Drawing.Size(1206, 55);
            this.searchGroupBox1.TabIndex = 2;
            this.searchGroupBox1.TabStop = false;
            this.searchGroupBox1.Text = "          ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(654, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 14);
            this.label2.TabIndex = 39;
            this.label2.Text = "نوع بانک";
            // 
            // bankTypeCombo
            // 
            this.bankTypeCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bankTypeCombo.DataSource = this.bankBindingSource;
            this.bankTypeCombo.DisplayMember = "Name";
            this.bankTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bankTypeCombo.FormattingEnabled = true;
            this.bankTypeCombo.Location = new System.Drawing.Point(527, 19);
            this.bankTypeCombo.Name = "bankTypeCombo";
            this.bankTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.bankTypeCombo.TabIndex = 38;
            this.bankTypeCombo.ValueMember = "ID";
            // 
            // bankBindingSource
            // 
            this.bankBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.Bank);
            // 
            // shabaButton
            // 
            this.shabaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shabaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.shabaButton.ImageIndex = 3;
            this.shabaButton.Location = new System.Drawing.Point(333, 17);
            this.shabaButton.Name = "shabaButton";
            this.shabaButton.Size = new System.Drawing.Size(88, 26);
            this.shabaButton.TabIndex = 37;
            this.shabaButton.Text = "ثبت شماره شبا";
            this.shabaButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.shabaButton.UseVisualStyleBackColor = true;
            this.shabaButton.Visible = false;
            this.shabaButton.Click += new System.EventHandler(this.shabaButton_Click);
            // 
            // reportBtn
            // 
            this.reportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reportBtn.ImageIndex = 3;
            this.reportBtn.Location = new System.Drawing.Point(6, 14);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(70, 26);
            this.reportBtn.TabIndex = 36;
            this.reportBtn.Text = "چاپ گزارش";
            this.reportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // personnelNumberTextBox
            // 
            this.personnelNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.personnelNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.personnelNumberTextBox.Location = new System.Drawing.Point(1028, 19);
            this.personnelNumberTextBox.Mask = "0000";
            this.personnelNumberTextBox.Name = "personnelNumberTextBox";
            this.personnelNumberTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.personnelNumberTextBox.Size = new System.Drawing.Size(50, 21);
            this.personnelNumberTextBox.TabIndex = 35;
            this.personnelNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // perssonelNumberLabel
            // 
            this.perssonelNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.perssonelNumberLabel.AutoSize = true;
            this.perssonelNumberLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perssonelNumberLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.perssonelNumberLabel.Location = new System.Drawing.Point(1079, 23);
            this.perssonelNumberLabel.Name = "perssonelNumberLabel";
            this.perssonelNumberLabel.Size = new System.Drawing.Size(84, 14);
            this.perssonelNumberLabel.TabIndex = 34;
            this.perssonelNumberLabel.Text = "شماره پرسنلی";
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchButton.ImageIndex = 3;
            this.SearchButton.Location = new System.Drawing.Point(427, 17);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(94, 26);
            this.SearchButton.TabIndex = 30;
            this.SearchButton.Text = " جستجو  (Enter)";
            this.SearchButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lastNameLabel.Location = new System.Drawing.Point(815, 21);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(72, 14);
            this.lastNameLabel.TabIndex = 26;
            this.lastNameLabel.Text = "نام خانوادگی";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.nameLabel.Location = new System.Drawing.Point(1001, 22);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(21, 14);
            this.nameLabel.TabIndex = 25;
            this.nameLabel.Text = "نام";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameTextBox.Location = new System.Drawing.Point(709, 19);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 21);
            this.lastNameTextBox.TabIndex = 23;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.Location = new System.Drawing.Point(894, 19);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(99, 21);
            this.NameTextBox.TabIndex = 22;
            // 
            // PersonelShabaDockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 517);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PersonelShabaDockForm";
            this.Text = "مدیریت حساب بانکی پرسنل";
            this.Load += new System.EventHandler(this.PersonelShabaDockForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personnelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.searchGroupBox1.ResumeLayout(false);
            this.searchGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox searchGroupBox1;
        private System.Windows.Forms.MaskedTextBox personnelNumberTextBox;
        private System.Windows.Forms.Label perssonelNumberLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.BindingSource personnelBindingSource;
        private System.Windows.Forms.DataGridView personnelDataGridView;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.Button shabaButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox bankTypeCombo;
        private System.Windows.Forms.BindingSource bankBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShebaNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankType;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}