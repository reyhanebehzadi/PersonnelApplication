namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class PersonelBankAccountDialogForm
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
            this.deleteAccountButton = new System.Windows.Forms.Button();
            this.editAccountButton = new System.Windows.Forms.Button();
            this.newAccountButton = new System.Windows.Forms.Button();
            this.bankAccountGridView = new System.Windows.Forms.DataGridView();
            this.personelBankAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shebaNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankAccountGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBankAccountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bankAccountGridView, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.80099F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.19901F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(711, 402);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancelButton);
            this.groupBox1.Controls.Add(this.deleteAccountButton);
            this.groupBox1.Controls.Add(this.editAccountButton);
            this.groupBox1.Controls.Add(this.newAccountButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 36);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // deleteAccountButton
            // 
            this.deleteAccountButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteAccountButton.Location = new System.Drawing.Point(465, 7);
            this.deleteAccountButton.Name = "deleteAccountButton";
            this.deleteAccountButton.Size = new System.Drawing.Size(60, 23);
            this.deleteAccountButton.TabIndex = 2;
            this.deleteAccountButton.Text = "حذف";
            this.deleteAccountButton.UseVisualStyleBackColor = true;
            this.deleteAccountButton.Click += new System.EventHandler(this.deleteAccountButton_Click);
            // 
            // editAccountButton
            // 
            this.editAccountButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editAccountButton.Location = new System.Drawing.Point(531, 7);
            this.editAccountButton.Name = "editAccountButton";
            this.editAccountButton.Size = new System.Drawing.Size(60, 23);
            this.editAccountButton.TabIndex = 1;
            this.editAccountButton.Text = "ویرایش";
            this.editAccountButton.UseVisualStyleBackColor = true;
            this.editAccountButton.Click += new System.EventHandler(this.editAccountButton_Click);
            // 
            // newAccountButton
            // 
            this.newAccountButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newAccountButton.Location = new System.Drawing.Point(597, 7);
            this.newAccountButton.Name = "newAccountButton";
            this.newAccountButton.Size = new System.Drawing.Size(99, 23);
            this.newAccountButton.TabIndex = 0;
            this.newAccountButton.Text = "ایجاد حساب جدید";
            this.newAccountButton.UseVisualStyleBackColor = true;
            this.newAccountButton.Click += new System.EventHandler(this.newAccountButton_Click);
            // 
            // bankAccountGridView
            // 
            this.bankAccountGridView.AllowUserToAddRows = false;
            this.bankAccountGridView.AllowUserToDeleteRows = false;
            this.bankAccountGridView.AutoGenerateColumns = false;
            this.bankAccountGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.bankAccountGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bankAccountGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.BankName,
            this.accountNumberDataGridViewTextBoxColumn,
            this.shebaNumberDataGridViewTextBoxColumn,
            this.Type,
            this.typeDataGridViewTextBoxColumn,
            this.bankIDDataGridViewTextBoxColumn,
            this.personelIDDataGridViewTextBoxColumn,
            this.bankDataGridViewTextBoxColumn,
            this.personnelDataGridViewTextBoxColumn});
            this.bankAccountGridView.DataSource = this.personelBankAccountBindingSource;
            this.bankAccountGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bankAccountGridView.Location = new System.Drawing.Point(3, 3);
            this.bankAccountGridView.Name = "bankAccountGridView";
            this.bankAccountGridView.ReadOnly = true;
            this.bankAccountGridView.Size = new System.Drawing.Size(705, 354);
            this.bankAccountGridView.TabIndex = 1;
            // 
            // personelBankAccountBindingSource
            // 
            this.personelBankAccountBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.PersonelBankAccount);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // BankName
            // 
            this.BankName.DataPropertyName = "BankName";
            this.BankName.HeaderText = "نام بانک";
            this.BankName.Name = "BankName";
            this.BankName.ReadOnly = true;
            this.BankName.Width = 150;
            // 
            // accountNumberDataGridViewTextBoxColumn
            // 
            this.accountNumberDataGridViewTextBoxColumn.DataPropertyName = "AccountNumber";
            this.accountNumberDataGridViewTextBoxColumn.HeaderText = "شماره حساب";
            this.accountNumberDataGridViewTextBoxColumn.Name = "accountNumberDataGridViewTextBoxColumn";
            this.accountNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.accountNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // shebaNumberDataGridViewTextBoxColumn
            // 
            this.shebaNumberDataGridViewTextBoxColumn.DataPropertyName = "ShebaNumber";
            this.shebaNumberDataGridViewTextBoxColumn.HeaderText = "شماره شبا";
            this.shebaNumberDataGridViewTextBoxColumn.Name = "shebaNumberDataGridViewTextBoxColumn";
            this.shebaNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.shebaNumberDataGridViewTextBoxColumn.Width = 250;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "BankAccountType";
            this.Type.HeaderText = "نوع حساب";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Visible = false;
            // 
            // bankIDDataGridViewTextBoxColumn
            // 
            this.bankIDDataGridViewTextBoxColumn.DataPropertyName = "BankID";
            this.bankIDDataGridViewTextBoxColumn.HeaderText = "BankID";
            this.bankIDDataGridViewTextBoxColumn.Name = "bankIDDataGridViewTextBoxColumn";
            this.bankIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bankIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // personelIDDataGridViewTextBoxColumn
            // 
            this.personelIDDataGridViewTextBoxColumn.DataPropertyName = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.HeaderText = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.Name = "personelIDDataGridViewTextBoxColumn";
            this.personelIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.personelIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // bankDataGridViewTextBoxColumn
            // 
            this.bankDataGridViewTextBoxColumn.DataPropertyName = "Bank";
            this.bankDataGridViewTextBoxColumn.HeaderText = "Bank";
            this.bankDataGridViewTextBoxColumn.Name = "bankDataGridViewTextBoxColumn";
            this.bankDataGridViewTextBoxColumn.ReadOnly = true;
            this.bankDataGridViewTextBoxColumn.Visible = false;
            // 
            // personnelDataGridViewTextBoxColumn
            // 
            this.personnelDataGridViewTextBoxColumn.DataPropertyName = "Personnel";
            this.personnelDataGridViewTextBoxColumn.HeaderText = "Personnel";
            this.personnelDataGridViewTextBoxColumn.Name = "personnelDataGridViewTextBoxColumn";
            this.personnelDataGridViewTextBoxColumn.ReadOnly = true;
            this.personnelDataGridViewTextBoxColumn.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(9, 7);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(73, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "انصراف";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // PersonelBankAccountDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 402);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonelBankAccountDialogForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "مدیریت حساب های بانکی";
            this.Load += new System.EventHandler(this.PersonelBankAccountDialogForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bankAccountGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBankAccountBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteAccountButton;
        private System.Windows.Forms.Button editAccountButton;
        private System.Windows.Forms.Button newAccountButton;
        private System.Windows.Forms.DataGridView bankAccountGridView;
        private System.Windows.Forms.BindingSource personelBankAccountBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shebaNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnelDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button cancelButton;
    }
}