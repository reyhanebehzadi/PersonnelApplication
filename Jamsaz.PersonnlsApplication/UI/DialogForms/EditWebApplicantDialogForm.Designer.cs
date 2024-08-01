namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class EditWebApplicantDialogForm
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label brithDateLabel;
            System.Windows.Forms.Label issueNoLabel;
            System.Windows.Forms.Label nationalCodeLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label fatherNameLabel;
            System.Windows.Forms.Label militaryServiceStatusNameLabel;
            System.Windows.Forms.Label maritalStatusNameLabel;
            System.Windows.Forms.Label telLabel;
            System.Windows.Forms.Label mobileNumberLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label resultLabel;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.issueNoTextBox = new System.Windows.Forms.TextBox();
            this.nationalCodeTextBox = new System.Windows.Forms.TextBox();
            this.fatherNameTextBox = new System.Windows.Forms.TextBox();
            this.militaryServiceStatusNameTextBox = new System.Windows.Forms.TextBox();
            this.brithDateDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.maritalStatusComboBox = new System.Windows.Forms.ComboBox();
            this.telTextBox = new System.Windows.Forms.TextBox();
            this.mobileNumberTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.selectMilitaryServiceStatusButton = new System.Windows.Forms.Button();
            this.applicantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resultTextBox = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            brithDateLabel = new System.Windows.Forms.Label();
            issueNoLabel = new System.Windows.Forms.Label();
            nationalCodeLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            fatherNameLabel = new System.Windows.Forms.Label();
            militaryServiceStatusNameLabel = new System.Windows.Forms.Label();
            maritalStatusNameLabel = new System.Windows.Forms.Label();
            telLabel = new System.Windows.Forms.Label();
            mobileNumberLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            resultLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicantBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(713, 384);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(resultLabel);
            this.groupBox1.Controls.Add(this.resultTextBox);
            this.groupBox1.Controls.Add(this.selectMilitaryServiceStatusButton);
            this.groupBox1.Controls.Add(this.statusComboBox);
            this.groupBox1.Controls.Add(statusLabel);
            this.groupBox1.Controls.Add(addressLabel);
            this.groupBox1.Controls.Add(this.addressTextBox);
            this.groupBox1.Controls.Add(mobileNumberLabel);
            this.groupBox1.Controls.Add(this.mobileNumberTextBox);
            this.groupBox1.Controls.Add(telLabel);
            this.groupBox1.Controls.Add(this.telTextBox);
            this.groupBox1.Controls.Add(this.maritalStatusComboBox);
            this.groupBox1.Controls.Add(this.genderComboBox);
            this.groupBox1.Controls.Add(this.brithDateDatePicker);
            this.groupBox1.Controls.Add(maritalStatusNameLabel);
            this.groupBox1.Controls.Add(militaryServiceStatusNameLabel);
            this.groupBox1.Controls.Add(this.militaryServiceStatusNameTextBox);
            this.groupBox1.Controls.Add(fatherNameLabel);
            this.groupBox1.Controls.Add(this.fatherNameTextBox);
            this.groupBox1.Controls.Add(genderLabel);
            this.groupBox1.Controls.Add(nationalCodeLabel);
            this.groupBox1.Controls.Add(this.nationalCodeTextBox);
            this.groupBox1.Controls.Add(issueNoLabel);
            this.groupBox1.Controls.Add(this.issueNoTextBox);
            this.groupBox1.Controls.Add(brithDateLabel);
            this.groupBox1.Controls.Add(lastNameLabel);
            this.groupBox1.Controls.Add(this.lastNameTextBox);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 318);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "کارجو";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.okButton);
            this.groupBox2.Controls.Add(this.cancelButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 327);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(707, 54);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.arrow_up;
            this.cancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelButton.Location = new System.Drawing.Point(90, 20);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "لغو";
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.arrow_down;
            this.okButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.okButton.Location = new System.Drawing.Point(9, 20);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "تایید";
            this.okButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(615, 31);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(24, 13);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "نام:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(470, 28);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(139, 21);
            this.nameTextBox.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(615, 68);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(69, 13);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "نام خانوادگی:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(470, 65);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(139, 21);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // brithDateLabel
            // 
            brithDateLabel.AutoSize = true;
            brithDateLabel.Location = new System.Drawing.Point(617, 109);
            brithDateLabel.Name = "brithDateLabel";
            brithDateLabel.Size = new System.Drawing.Size(52, 13);
            brithDateLabel.TabIndex = 4;
            brithDateLabel.Text = "تاریخ تولد:";
            // 
            // issueNoLabel
            // 
            issueNoLabel.AutoSize = true;
            issueNoLabel.Location = new System.Drawing.Point(615, 140);
            issueNoLabel.Name = "issueNoLabel";
            issueNoLabel.Size = new System.Drawing.Size(75, 13);
            issueNoLabel.TabIndex = 6;
            issueNoLabel.Text = "ش شناسنامه:";
            // 
            // issueNoTextBox
            // 
            this.issueNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantBindingSource, "IssueNo", true));
            this.issueNoTextBox.Location = new System.Drawing.Point(470, 137);
            this.issueNoTextBox.Name = "issueNoTextBox";
            this.issueNoTextBox.Size = new System.Drawing.Size(139, 21);
            this.issueNoTextBox.TabIndex = 7;
            // 
            // nationalCodeLabel
            // 
            nationalCodeLabel.AutoSize = true;
            nationalCodeLabel.Location = new System.Drawing.Point(615, 172);
            nationalCodeLabel.Name = "nationalCodeLabel";
            nationalCodeLabel.Size = new System.Drawing.Size(46, 13);
            nationalCodeLabel.TabIndex = 8;
            nationalCodeLabel.Text = "کد ملی:";
            // 
            // nationalCodeTextBox
            // 
            this.nationalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantBindingSource, "NationalCode", true));
            this.nationalCodeTextBox.Location = new System.Drawing.Point(470, 169);
            this.nationalCodeTextBox.Name = "nationalCodeTextBox";
            this.nationalCodeTextBox.Size = new System.Drawing.Size(141, 21);
            this.nationalCodeTextBox.TabIndex = 9;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(617, 206);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(44, 13);
            genderLabel.TabIndex = 10;
            genderLabel.Text = "جنسیت";
            // 
            // fatherNameLabel
            // 
            fatherNameLabel.AutoSize = true;
            fatherNameLabel.Location = new System.Drawing.Point(617, 244);
            fatherNameLabel.Name = "fatherNameLabel";
            fatherNameLabel.Size = new System.Drawing.Size(40, 13);
            fatherNameLabel.TabIndex = 12;
            fatherNameLabel.Text = "نام پدر:";
            // 
            // fatherNameTextBox
            // 
            this.fatherNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantBindingSource, "FatherName", true));
            this.fatherNameTextBox.Location = new System.Drawing.Point(470, 241);
            this.fatherNameTextBox.Name = "fatherNameTextBox";
            this.fatherNameTextBox.Size = new System.Drawing.Size(141, 21);
            this.fatherNameTextBox.TabIndex = 13;
            // 
            // militaryServiceStatusNameLabel
            // 
            militaryServiceStatusNameLabel.AutoSize = true;
            militaryServiceStatusNameLabel.Location = new System.Drawing.Point(613, 279);
            militaryServiceStatusNameLabel.Name = "militaryServiceStatusNameLabel";
            militaryServiceStatusNameLabel.Size = new System.Drawing.Size(77, 13);
            militaryServiceStatusNameLabel.TabIndex = 14;
            militaryServiceStatusNameLabel.Text = "وضعیت خدمت:";
            // 
            // militaryServiceStatusNameTextBox
            // 
            this.militaryServiceStatusNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantBindingSource, "MilitaryServiceStatusName", true));
            this.militaryServiceStatusNameTextBox.Location = new System.Drawing.Point(470, 276);
            this.militaryServiceStatusNameTextBox.Name = "militaryServiceStatusNameTextBox";
            this.militaryServiceStatusNameTextBox.Size = new System.Drawing.Size(141, 21);
            this.militaryServiceStatusNameTextBox.TabIndex = 15;
            // 
            // maritalStatusNameLabel
            // 
            maritalStatusNameLabel.AutoSize = true;
            maritalStatusNameLabel.Location = new System.Drawing.Point(364, 31);
            maritalStatusNameLabel.Name = "maritalStatusNameLabel";
            maritalStatusNameLabel.Size = new System.Drawing.Size(70, 13);
            maritalStatusNameLabel.TabIndex = 16;
            maritalStatusNameLabel.Text = "وضعیت تاهل:";
            // 
            // brithDateDatePicker
            // 
            this.brithDateDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.brithDateDatePicker.DataBindings.Add(new System.Windows.Forms.Binding("SelectedDateTime", this.applicantBindingSource, "BrithDate", true));
            this.brithDateDatePicker.Location = new System.Drawing.Point(470, 102);
            this.brithDateDatePicker.Name = "brithDateDatePicker";
            this.brithDateDatePicker.Size = new System.Drawing.Size(139, 20);
            this.brithDateDatePicker.TabIndex = 90;
            this.brithDateDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.applicantBindingSource, "Gender", true));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.genderComboBox.Location = new System.Drawing.Point(470, 206);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(141, 21);
            this.genderComboBox.TabIndex = 91;
            // 
            // maritalStatusComboBox
            // 
            this.maritalStatusComboBox.FormattingEnabled = true;
            this.maritalStatusComboBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.maritalStatusComboBox.Location = new System.Drawing.Point(237, 28);
            this.maritalStatusComboBox.Name = "maritalStatusComboBox";
            this.maritalStatusComboBox.Size = new System.Drawing.Size(121, 21);
            this.maritalStatusComboBox.TabIndex = 92;
            // 
            // telLabel
            // 
            telLabel.AutoSize = true;
            telLabel.Location = new System.Drawing.Point(364, 68);
            telLabel.Name = "telLabel";
            telLabel.Size = new System.Drawing.Size(32, 13);
            telLabel.TabIndex = 92;
            telLabel.Text = "تلفن:";
            // 
            // telTextBox
            // 
            this.telTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantBindingSource, "Tel", true));
            this.telTextBox.Location = new System.Drawing.Point(258, 65);
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(100, 21);
            this.telTextBox.TabIndex = 93;
            // 
            // mobileNumberLabel
            // 
            mobileNumberLabel.AutoSize = true;
            mobileNumberLabel.Location = new System.Drawing.Point(364, 109);
            mobileNumberLabel.Name = "mobileNumberLabel";
            mobileNumberLabel.Size = new System.Drawing.Size(63, 13);
            mobileNumberLabel.TabIndex = 93;
            mobileNumberLabel.Text = "تلفن همراه:";
            // 
            // mobileNumberTextBox
            // 
            this.mobileNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantBindingSource, "MobileNumber", true));
            this.mobileNumberTextBox.Location = new System.Drawing.Point(258, 101);
            this.mobileNumberTextBox.Name = "mobileNumberTextBox";
            this.mobileNumberTextBox.Size = new System.Drawing.Size(100, 21);
            this.mobileNumberTextBox.TabIndex = 94;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(364, 140);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(36, 13);
            addressLabel.TabIndex = 94;
            addressLabel.Text = "آدرس:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(57, 137);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(301, 53);
            this.addressTextBox.TabIndex = 95;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(364, 275);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(45, 13);
            statusLabel.TabIndex = 95;
            statusLabel.Text = "وضعیت:";
            // 
            // statusComboBox
            // 
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.applicantBindingSource, "Status", true));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(237, 275);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 21);
            this.statusComboBox.TabIndex = 96;
            // 
            // selectMilitaryServiceStatusButton
            // 
            this.selectMilitaryServiceStatusButton.Location = new System.Drawing.Point(432, 276);
            this.selectMilitaryServiceStatusButton.Name = "selectMilitaryServiceStatusButton";
            this.selectMilitaryServiceStatusButton.Size = new System.Drawing.Size(32, 23);
            this.selectMilitaryServiceStatusButton.TabIndex = 97;
            this.selectMilitaryServiceStatusButton.Text = "...";
            this.selectMilitaryServiceStatusButton.UseVisualStyleBackColor = true;
            this.selectMilitaryServiceStatusButton.Click += new System.EventHandler(this.selectMilitaryServiceStatusButton_Click);
            // 
            // applicantBindingSource
            // 
            this.applicantBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.Applicant);
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new System.Drawing.Point(364, 214);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new System.Drawing.Size(51, 13);
            resultLabel.TabIndex = 97;
            resultLabel.Text = "توضیحات:";
            // 
            // resultTextBox
            // 
            this.resultTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantBindingSource, "Result", true));
            this.resultTextBox.Location = new System.Drawing.Point(57, 206);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(301, 51);
            this.resultTextBox.TabIndex = 98;
            // 
            // EditWebApplicantDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 384);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditWebApplicantDialogForm";
            this.ShowIcon = false;
            this.Text = "";
            this.Load += new System.EventHandler(this.EditWebApplicantDialogForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.applicantBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource applicantBindingSource;
        private System.Windows.Forms.TextBox militaryServiceStatusNameTextBox;
        private System.Windows.Forms.TextBox fatherNameTextBox;
        private System.Windows.Forms.TextBox nationalCodeTextBox;
        private System.Windows.Forms.TextBox issueNoTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private FarsiLibrary.Win.Controls.FADatePicker brithDateDatePicker;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.ComboBox maritalStatusComboBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox mobileNumberTextBox;
        private System.Windows.Forms.TextBox telTextBox;
        private System.Windows.Forms.Button selectMilitaryServiceStatusButton;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}