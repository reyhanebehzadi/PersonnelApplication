namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class AddAccidentDialogForm
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
            System.Windows.Forms.Label personnelNumberLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label injuredMemberLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label descriptionLabel;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.accidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectToUseCheckBox = new System.Windows.Forms.CheckBox();
            this.selectPersonnelButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.InjuredMemberTextBox = new System.Windows.Forms.TextBox();
            this.firstContractStartDateDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.personnelNumberTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            codeLabel = new System.Windows.Forms.Label();
            personnelNumberLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            injuredMemberLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accidentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codeLabel
            // 
            codeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(539, 24);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(22, 13);
            codeLabel.TabIndex = 0;
            codeLabel.Text = "کد:";
            // 
            // personnelNumberLabel
            // 
            personnelNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            personnelNumberLabel.AutoSize = true;
            personnelNumberLabel.Location = new System.Drawing.Point(539, 60);
            personnelNumberLabel.Name = "personnelNumberLabel";
            personnelNumberLabel.Size = new System.Drawing.Size(42, 13);
            personnelNumberLabel.TabIndex = 2;
            personnelNumberLabel.Text = "پرسنل:";
            // 
            // dateLabel
            // 
            dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(539, 91);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(32, 13);
            dateLabel.TabIndex = 5;
            dateLabel.Text = "تاریخ:";
            // 
            // injuredMemberLabel
            // 
            injuredMemberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            injuredMemberLabel.AutoSize = true;
            injuredMemberLabel.Location = new System.Drawing.Point(539, 123);
            injuredMemberLabel.Name = "injuredMemberLabel";
            injuredMemberLabel.Size = new System.Drawing.Size(81, 13);
            injuredMemberLabel.TabIndex = 7;
            injuredMemberLabel.Text = "عضو حادثه دیده:";
            // 
            // priceLabel
            // 
            priceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(539, 191);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(69, 13);
            priceLabel.TabIndex = 9;
            priceLabel.Text = "مبلغ خسارت:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(544, 248);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(51, 13);
            descriptionLabel.TabIndex = 11;
            descriptionLabel.Text = "توضیحات:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(655, 471);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.cancelButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 414);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // saveButton
            // 
            this.saveButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.arrow_down;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveButton.Location = new System.Drawing.Point(100, 20);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "تایید";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.arrow_up;
            this.cancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelButton.Location = new System.Drawing.Point(19, 20);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "لغو";
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.subjectToUseCheckBox);
            this.groupBox2.Controls.Add(this.selectPersonnelButton);
            this.groupBox2.Controls.Add(this.descriptionTextBox);
            this.groupBox2.Controls.Add(this.priceTextBox);
            this.groupBox2.Controls.Add(this.InjuredMemberTextBox);
            this.groupBox2.Controls.Add(this.firstContractStartDateDatePicker);
            this.groupBox2.Controls.Add(this.personnelNumberTextBox);
            this.groupBox2.Controls.Add(this.fullNameTextBox);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(descriptionLabel);
            this.groupBox2.Controls.Add(priceLabel);
            this.groupBox2.Controls.Add(injuredMemberLabel);
            this.groupBox2.Controls.Add(dateLabel);
            this.groupBox2.Controls.Add(personnelNumberLabel);
            this.groupBox2.Controls.Add(codeLabel);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(649, 405);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.accidentBindingSource, "PaymentSatus", true));
            this.checkBox1.Location = new System.Drawing.Point(450, 225);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 17);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "پرداخت شده";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // accidentBindingSource
            // 
            this.accidentBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.Accident);
            // 
            // subjectToUseCheckBox
            // 
            this.subjectToUseCheckBox.AutoSize = true;
            this.subjectToUseCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.accidentBindingSource, "SubjectToUse", true));
            this.subjectToUseCheckBox.Location = new System.Drawing.Point(321, 156);
            this.subjectToUseCheckBox.Name = "subjectToUseCheckBox";
            this.subjectToUseCheckBox.Size = new System.Drawing.Size(212, 17);
            this.subjectToUseCheckBox.TabIndex = 21;
            this.subjectToUseCheckBox.Text = "مشمول استفاده از بیمه مسئولیت مدنی";
            this.subjectToUseCheckBox.UseVisualStyleBackColor = true;
            // 
            // selectPersonnelButton
            // 
            this.selectPersonnelButton.Location = new System.Drawing.Point(176, 56);
            this.selectPersonnelButton.Name = "selectPersonnelButton";
            this.selectPersonnelButton.Size = new System.Drawing.Size(29, 23);
            this.selectPersonnelButton.TabIndex = 20;
            this.selectPersonnelButton.Text = "...";
            this.selectPersonnelButton.UseVisualStyleBackColor = true;
            this.selectPersonnelButton.Click += new System.EventHandler(this.selectPersonnelButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accidentBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(82, 248);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(451, 133);
            this.descriptionTextBox.TabIndex = 19;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accidentBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(346, 188);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(187, 21);
            this.priceTextBox.TabIndex = 18;
            this.priceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTextBox_KeyPress);
            // 
            // InjuredMemberTextBox
            // 
            this.InjuredMemberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InjuredMemberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accidentBindingSource, "InjuredMember", true));
            this.InjuredMemberTextBox.Location = new System.Drawing.Point(82, 120);
            this.InjuredMemberTextBox.Name = "InjuredMemberTextBox";
            this.InjuredMemberTextBox.Size = new System.Drawing.Size(451, 21);
            this.InjuredMemberTextBox.TabIndex = 17;
            // 
            // firstContractStartDateDatePicker
            // 
            this.firstContractStartDateDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.firstContractStartDateDatePicker.DataBindings.Add(new System.Windows.Forms.Binding("SelectedDateTime", this.accidentBindingSource, "Date", true));
            this.firstContractStartDateDatePicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.firstContractStartDateDatePicker.Location = new System.Drawing.Point(377, 91);
            this.firstContractStartDateDatePicker.Name = "firstContractStartDateDatePicker";
            this.firstContractStartDateDatePicker.Size = new System.Drawing.Size(156, 20);
            this.firstContractStartDateDatePicker.TabIndex = 16;
            // 
            // personnelNumberTextBox
            // 
            this.personnelNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.personnelNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accidentBindingSource, "PersonnelNumber", true));
            this.personnelNumberTextBox.Location = new System.Drawing.Point(450, 57);
            this.personnelNumberTextBox.Name = "personnelNumberTextBox";
            this.personnelNumberTextBox.ReadOnly = true;
            this.personnelNumberTextBox.Size = new System.Drawing.Size(83, 21);
            this.personnelNumberTextBox.TabIndex = 15;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accidentBindingSource, "FullName", true));
            this.fullNameTextBox.Location = new System.Drawing.Point(209, 57);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.ReadOnly = true;
            this.fullNameTextBox.Size = new System.Drawing.Size(235, 21);
            this.fullNameTextBox.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accidentBindingSource, "Code", true));
            this.textBox1.Location = new System.Drawing.Point(450, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(83, 21);
            this.textBox1.TabIndex = 13;
            // 
            // AddAccidentDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 471);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddAccidentDialogForm";
            this.ShowIcon = false;
            this.Text = "ثبت";
            this.Load += new System.EventHandler(this.AddAccidentDialogForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accidentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource accidentBindingSource;
        private System.Windows.Forms.TextBox personnelNumberTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Button selectPersonnelButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox InjuredMemberTextBox;
        private FarsiLibrary.Win.Controls.FADatePicker firstContractStartDateDatePicker;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox subjectToUseCheckBox;
    }
}