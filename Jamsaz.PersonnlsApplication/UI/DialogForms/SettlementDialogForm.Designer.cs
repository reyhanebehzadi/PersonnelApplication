namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class SettlementDialogForm
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
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label complainedAmountLabel;
            System.Windows.Forms.Label accidentComplaintAmountLabel;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.accidentComplaintCheckBox = new System.Windows.Forms.CheckBox();
            this.settlementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.complainedCheckBox = new System.Windows.Forms.CheckBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.personnelNumberTextBox = new System.Windows.Forms.TextBox();
            this.fullNametextBox = new System.Windows.Forms.TextBox();
            this.personnelNumberlabel = new System.Windows.Forms.Label();
            this.fullNamelabel = new System.Windows.Forms.Label();
            this.SettlementCategorycomboBox = new System.Windows.Forms.ComboBox();
            this.settlementCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.unemploymentInsuranceCheckBox = new System.Windows.Forms.CheckBox();
            this.pay_complaintCheckBox = new System.Windows.Forms.CheckBox();
            this.pay_AccidentComplaintCheckBox = new System.Windows.Forms.CheckBox();
            this.complainedAmountTextBox = new System.Windows.Forms.TextBox();
            this.accidentComplaintAmountTextBox = new System.Windows.Forms.TextBox();
            dateLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            complainedAmountLabel = new System.Windows.Forms.Label();
            accidentComplaintAmountLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settlementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settlementCategoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(424, 67);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(64, 13);
            dateLabel.TabIndex = 0;
            dateLabel.Text = "تاریخ تسویه:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(420, 104);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(96, 13);
            priceLabel.TabIndex = 45;
            priceLabel.Text = "مبلغ محاسبه شده:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(484, 252);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(51, 13);
            descriptionLabel.TabIndex = 47;
            descriptionLabel.Text = "توضیحات:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(559, 372);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cancelButton);
            this.groupBox2.Controls.Add(this.okButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 315);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(553, 54);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.l_cancel;
            this.cancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelButton.Location = new System.Drawing.Point(9, 20);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "لغو";
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.check;
            this.okButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.okButton.Location = new System.Drawing.Point(90, 20);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "تسویه";
            this.okButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.unemploymentInsuranceCheckBox);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(descriptionLabel);
            this.groupBox1.Controls.Add(this.descriptionTextBox);
            this.groupBox1.Controls.Add(priceLabel);
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Controls.Add(this.personnelNumberTextBox);
            this.groupBox1.Controls.Add(this.fullNametextBox);
            this.groupBox1.Controls.Add(this.personnelNumberlabel);
            this.groupBox1.Controls.Add(this.fullNamelabel);
            this.groupBox1.Controls.Add(this.SettlementCategorycomboBox);
            this.groupBox1.Controls.Add(this.DatePicker);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(dateLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 306);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(accidentComplaintAmountLabel);
            this.groupBox3.Controls.Add(this.accidentComplaintAmountTextBox);
            this.groupBox3.Controls.Add(complainedAmountLabel);
            this.groupBox3.Controls.Add(this.complainedAmountTextBox);
            this.groupBox3.Controls.Add(this.pay_AccidentComplaintCheckBox);
            this.groupBox3.Controls.Add(this.pay_complaintCheckBox);
            this.groupBox3.Controls.Add(this.accidentComplaintCheckBox);
            this.groupBox3.Controls.Add(this.complainedCheckBox);
            this.groupBox3.Location = new System.Drawing.Point(18, 135);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(507, 90);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "شکایت";
            // 
            // accidentComplaintCheckBox
            // 
            this.accidentComplaintCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.settlementBindingSource, "AccidentComplaint", true));
            this.accidentComplaintCheckBox.Location = new System.Drawing.Point(398, 53);
            this.accidentComplaintCheckBox.Name = "accidentComplaintCheckBox";
            this.accidentComplaintCheckBox.Size = new System.Drawing.Size(69, 24);
            this.accidentComplaintCheckBox.TabIndex = 48;
            this.accidentComplaintCheckBox.Text = "حادثه";
            this.accidentComplaintCheckBox.UseVisualStyleBackColor = true;
            // 
            // settlementBindingSource
            // 
            this.settlementBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.Settlement);
            // 
            // complainedCheckBox
            // 
            this.complainedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.settlementBindingSource, "Complained", true));
            this.complainedCheckBox.Location = new System.Drawing.Point(398, 23);
            this.complainedCheckBox.Name = "complainedCheckBox";
            this.complainedCheckBox.Size = new System.Drawing.Size(69, 24);
            this.complainedCheckBox.TabIndex = 47;
            this.complainedCheckBox.Text = "تسویه";
            this.complainedCheckBox.UseVisualStyleBackColor = true;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settlementBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(18, 235);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(460, 53);
            this.descriptionTextBox.TabIndex = 48;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settlementBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(271, 99);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(147, 21);
            this.priceTextBox.TabIndex = 46;
            this.priceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTextBox_KeyPress);
            // 
            // personnelNumberTextBox
            // 
            this.personnelNumberTextBox.Location = new System.Drawing.Point(18, 27);
            this.personnelNumberTextBox.Name = "personnelNumberTextBox";
            this.personnelNumberTextBox.ReadOnly = true;
            this.personnelNumberTextBox.Size = new System.Drawing.Size(147, 21);
            this.personnelNumberTextBox.TabIndex = 45;
            // 
            // fullNametextBox
            // 
            this.fullNametextBox.Location = new System.Drawing.Point(272, 30);
            this.fullNametextBox.Name = "fullNametextBox";
            this.fullNametextBox.ReadOnly = true;
            this.fullNametextBox.Size = new System.Drawing.Size(147, 21);
            this.fullNametextBox.TabIndex = 44;
            // 
            // personnelNumberlabel
            // 
            this.personnelNumberlabel.AutoSize = true;
            this.personnelNumberlabel.Location = new System.Drawing.Point(167, 30);
            this.personnelNumberlabel.Name = "personnelNumberlabel";
            this.personnelNumberlabel.Size = new System.Drawing.Size(82, 13);
            this.personnelNumberlabel.TabIndex = 43;
            this.personnelNumberlabel.Text = "شماره پرسنلی:";
            // 
            // fullNamelabel
            // 
            this.fullNamelabel.AutoSize = true;
            this.fullNamelabel.Location = new System.Drawing.Point(425, 33);
            this.fullNamelabel.Name = "fullNamelabel";
            this.fullNamelabel.Size = new System.Drawing.Size(93, 13);
            this.fullNamelabel.TabIndex = 42;
            this.fullNamelabel.Text = "نام و نام خانوادگی:";
            // 
            // SettlementCategorycomboBox
            // 
            this.SettlementCategorycomboBox.DataSource = this.settlementCategoryBindingSource;
            this.SettlementCategorycomboBox.DisplayMember = "Title";
            this.SettlementCategorycomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SettlementCategorycomboBox.FormattingEnabled = true;
            this.SettlementCategorycomboBox.Location = new System.Drawing.Point(18, 62);
            this.SettlementCategorycomboBox.Name = "SettlementCategorycomboBox";
            this.SettlementCategorycomboBox.Size = new System.Drawing.Size(147, 21);
            this.SettlementCategorycomboBox.TabIndex = 41;
            this.SettlementCategorycomboBox.ValueMember = "ID";
            // 
            // settlementCategoryBindingSource
            // 
            this.settlementCategoryBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.SettlementCategory);
            // 
            // DatePicker
            // 
            this.DatePicker.DataBindings.Add(new System.Windows.Forms.Binding("SelectedDateTime", this.settlementBindingSource, "Date", true));
            this.DatePicker.Location = new System.Drawing.Point(272, 63);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(146, 20);
            this.DatePicker.TabIndex = 40;
            this.DatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "علت تسویه:";
            // 
            // unemploymentInsuranceCheckBox
            // 
            this.unemploymentInsuranceCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.settlementBindingSource, "UnemploymentInsurance", true));
            this.unemploymentInsuranceCheckBox.Location = new System.Drawing.Point(61, 96);
            this.unemploymentInsuranceCheckBox.Name = "unemploymentInsuranceCheckBox";
            this.unemploymentInsuranceCheckBox.Size = new System.Drawing.Size(104, 24);
            this.unemploymentInsuranceCheckBox.TabIndex = 50;
            this.unemploymentInsuranceCheckBox.Text = "بیمه بیکاری";
            this.unemploymentInsuranceCheckBox.UseVisualStyleBackColor = true;
            // 
            // pay_complaintCheckBox
            // 
            this.pay_complaintCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.settlementBindingSource, "Pay_complaint", true));
            this.pay_complaintCheckBox.Location = new System.Drawing.Point(82, 20);
            this.pay_complaintCheckBox.Name = "pay_complaintCheckBox";
            this.pay_complaintCheckBox.Size = new System.Drawing.Size(104, 24);
            this.pay_complaintCheckBox.TabIndex = 49;
            this.pay_complaintCheckBox.Text = "پرداخت";
            this.pay_complaintCheckBox.UseVisualStyleBackColor = true;
            // 
            // pay_AccidentComplaintCheckBox
            // 
            this.pay_AccidentComplaintCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.settlementBindingSource, "Pay_AccidentComplaint", true));
            this.pay_AccidentComplaintCheckBox.Location = new System.Drawing.Point(82, 53);
            this.pay_AccidentComplaintCheckBox.Name = "pay_AccidentComplaintCheckBox";
            this.pay_AccidentComplaintCheckBox.Size = new System.Drawing.Size(104, 24);
            this.pay_AccidentComplaintCheckBox.TabIndex = 50;
            this.pay_AccidentComplaintCheckBox.Text = "پرداخت";
            this.pay_AccidentComplaintCheckBox.UseVisualStyleBackColor = true;
            // 
            // complainedAmountTextBox
            // 
            this.complainedAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settlementBindingSource, "ComplainedAmount", true));
            this.complainedAmountTextBox.Location = new System.Drawing.Point(221, 23);
            this.complainedAmountTextBox.Name = "complainedAmountTextBox";
            this.complainedAmountTextBox.Size = new System.Drawing.Size(100, 21);
            this.complainedAmountTextBox.TabIndex = 51;
            this.complainedAmountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.complainedAmountTextBox_KeyPress);
            // 
            // complainedAmountLabel
            // 
            complainedAmountLabel.AutoSize = true;
            complainedAmountLabel.Location = new System.Drawing.Point(327, 26);
            complainedAmountLabel.Name = "complainedAmountLabel";
            complainedAmountLabel.Size = new System.Drawing.Size(63, 13);
            complainedAmountLabel.TabIndex = 50;
            complainedAmountLabel.Text = "مبلغ تسویه:";
            // 
            // accidentComplaintAmountLabel
            // 
            accidentComplaintAmountLabel.AutoSize = true;
            accidentComplaintAmountLabel.Location = new System.Drawing.Point(327, 59);
            accidentComplaintAmountLabel.Name = "accidentComplaintAmountLabel";
            accidentComplaintAmountLabel.Size = new System.Drawing.Size(58, 13);
            accidentComplaintAmountLabel.TabIndex = 51;
            accidentComplaintAmountLabel.Text = "مبلغ حادثه:";
            // 
            // accidentComplaintAmountTextBox
            // 
            this.accidentComplaintAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settlementBindingSource, "AccidentComplaintAmount", true));
            this.accidentComplaintAmountTextBox.Location = new System.Drawing.Point(221, 53);
            this.accidentComplaintAmountTextBox.Name = "accidentComplaintAmountTextBox";
            this.accidentComplaintAmountTextBox.Size = new System.Drawing.Size(100, 21);
            this.accidentComplaintAmountTextBox.TabIndex = 52;
            this.accidentComplaintAmountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.accidentComplaintAmountTextBox_KeyPress);
            // 
            // SettlementDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 372);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SettlementDialogForm";
            this.ShowIcon = false;
            this.Text = "فرم تسویه";
            this.Load += new System.EventHandler(this.SettlementDialogForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settlementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settlementCategoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource settlementBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SettlementCategorycomboBox;
        private System.Windows.Forms.BindingSource settlementCategoryBindingSource;
        private FarsiLibrary.Win.Controls.FADatePicker DatePicker;
        private System.Windows.Forms.TextBox personnelNumberTextBox;
        private System.Windows.Forms.TextBox fullNametextBox;
        private System.Windows.Forms.Label personnelNumberlabel;
        private System.Windows.Forms.Label fullNamelabel;
        private System.Windows.Forms.CheckBox complainedCheckBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox accidentComplaintCheckBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.CheckBox unemploymentInsuranceCheckBox;
        private System.Windows.Forms.TextBox accidentComplaintAmountTextBox;
        private System.Windows.Forms.TextBox complainedAmountTextBox;
        private System.Windows.Forms.CheckBox pay_AccidentComplaintCheckBox;
        private System.Windows.Forms.CheckBox pay_complaintCheckBox;
    }
}