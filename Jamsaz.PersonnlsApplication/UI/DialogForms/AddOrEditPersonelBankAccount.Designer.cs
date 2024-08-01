namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class AddOrEditPersonelBankAccount
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
            System.Windows.Forms.Label personnelNumberLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.accountNumber = new Jamsaz.PersonnlsApplication.Classes.NullableTextBox();
            this.shebaNumber = new Jamsaz.PersonnlsApplication.Classes.NullableTextBox();
            this.bankCombobox = new System.Windows.Forms.ComboBox();
            this.bankBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountType = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.shabaProduction = new System.Windows.Forms.Button();
            personnelNumberLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // personnelNumberLabel
            // 
            personnelNumberLabel.AutoSize = true;
            personnelNumberLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            personnelNumberLabel.Location = new System.Drawing.Point(9, 72);
            personnelNumberLabel.Name = "personnelNumberLabel";
            personnelNumberLabel.Size = new System.Drawing.Size(78, 13);
            personnelNumberLabel.TabIndex = 2;
            personnelNumberLabel.Text = "شماره حساب :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label1.Location = new System.Drawing.Point(9, 99);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(65, 13);
            label1.TabIndex = 4;
            label1.Text = "شماره شبا :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label2.Location = new System.Drawing.Point(9, 18);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(52, 13);
            label2.TabIndex = 14;
            label2.Text = "نوع بانک :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label3.Location = new System.Drawing.Point(9, 45);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(63, 13);
            label3.TabIndex = 16;
            label3.Text = "نوع حساب :";
            // 
            // accountNumber
            // 
            this.accountNumber.IsNumeric = true;
            this.accountNumber.Location = new System.Drawing.Point(97, 69);
            this.accountNumber.Name = "accountNumber";
            this.accountNumber.NullableText = null;
            this.accountNumber.Size = new System.Drawing.Size(234, 21);
            this.accountNumber.TabIndex = 3;
            // 
            // shebaNumber
            // 
            this.shebaNumber.IsNumeric = true;
            this.shebaNumber.Location = new System.Drawing.Point(97, 96);
            this.shebaNumber.Name = "shebaNumber";
            this.shebaNumber.NullableText = null;
            this.shebaNumber.Size = new System.Drawing.Size(234, 21);
            this.shebaNumber.TabIndex = 5;
            // 
            // bankCombobox
            // 
            this.bankCombobox.DataSource = this.bankBindingSource;
            this.bankCombobox.DisplayMember = "Name";
            this.bankCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bankCombobox.FormattingEnabled = true;
            this.bankCombobox.Location = new System.Drawing.Point(97, 15);
            this.bankCombobox.Name = "bankCombobox";
            this.bankCombobox.Size = new System.Drawing.Size(234, 21);
            this.bankCombobox.TabIndex = 13;
            this.bankCombobox.ValueMember = "ID";
            // 
            // bankBindingSource
            // 
            this.bankBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.Bank);
            // 
            // accountType
            // 
            this.accountType.DisplayMember = "ToString";
            this.accountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountType.FormattingEnabled = true;
            this.accountType.Location = new System.Drawing.Point(97, 42);
            this.accountType.Name = "accountType";
            this.accountType.Size = new System.Drawing.Size(234, 21);
            this.accountType.TabIndex = 15;
            this.accountType.ValueMember = "intValue";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(97, 136);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "ذخیره سازی";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(178, 136);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "انصراف";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // shabaProduction
            // 
            this.shabaProduction.Location = new System.Drawing.Point(334, 95);
            this.shabaProduction.Name = "shabaProduction";
            this.shabaProduction.Size = new System.Drawing.Size(63, 23);
            this.shabaProduction.TabIndex = 19;
            this.shabaProduction.Text = "تولید شبا";
            this.shabaProduction.UseVisualStyleBackColor = true;
            this.shabaProduction.Click += new System.EventHandler(this.shabaProduction_Click);
            // 
            // AddOrEditPersonelBankAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(399, 171);
            this.Controls.Add(this.shabaProduction);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(label3);
            this.Controls.Add(this.accountType);
            this.Controls.Add(label2);
            this.Controls.Add(this.bankCombobox);
            this.Controls.Add(this.shebaNumber);
            this.Controls.Add(label1);
            this.Controls.Add(this.accountNumber);
            this.Controls.Add(personnelNumberLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOrEditPersonelBankAccount";
            this.Text = "مدیریت حساب بانکی";
            this.Load += new System.EventHandler(this.AddOrEditPersonelBankAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Classes.NullableTextBox accountNumber;
        private Classes.NullableTextBox shebaNumber;
        private System.Windows.Forms.ComboBox bankCombobox;
        private System.Windows.Forms.ComboBox accountType;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.BindingSource bankBindingSource;
        private System.Windows.Forms.Button shabaProduction;
    }
}