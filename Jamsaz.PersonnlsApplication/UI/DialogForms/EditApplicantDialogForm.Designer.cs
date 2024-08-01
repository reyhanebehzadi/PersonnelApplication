namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class EditApplicantDialogForm
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
            System.Windows.Forms.Label lblMobileNumber;
            System.Windows.Forms.Label lblMilitaryServiceStatusId;
            System.Windows.Forms.Label brithDateLabel;
            System.Windows.Forms.Label lblName;
            System.Windows.Forms.Label lblLastName;
            System.Windows.Forms.Label lblIssueNo;
            System.Windows.Forms.Label nationalCodeLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label fatherNameLabel;
            System.Windows.Forms.Label lblUniversityDegreeId;
            System.Windows.Forms.Label lblMajorId;
            System.Windows.Forms.Label lblMaritalStatus;
            System.Windows.Forms.Label lblAddress;
            System.Windows.Forms.Label lblTel;
            System.Windows.Forms.Label lblUniversityName;
            System.Windows.Forms.Label lblStatus;
            System.Windows.Forms.Label lblDescription;
            System.Windows.Forms.Label respectDateLabel;
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.applicantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblSetPersonnel = new System.Windows.Forms.Label();
            this.militaryServiceStatusNameTextBox = new System.Windows.Forms.TextBox();
            this.selectUniversityDegreeButton = new System.Windows.Forms.Button();
            this.selectMajorsButton = new System.Windows.Forms.Button();
            this.selectMilitaryServiceStatusButton = new System.Windows.Forms.Button();
            this.maritalStatusComboBox = new System.Windows.Forms.ComboBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.fatherNameTextBox = new System.Windows.Forms.TextBox();
            this.universityDegreeNameTextbox = new System.Windows.Forms.TextBox();
            this.majorNameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.universityNameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.brithDateDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.respectDateFaDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.issueNoTextBox = new System.Windows.Forms.TextBox();
            this.NationalCodeTextBox = new System.Windows.Forms.TextBox();
            this.tellTextBox = new System.Windows.Forms.TextBox();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            lblMobileNumber = new System.Windows.Forms.Label();
            lblMilitaryServiceStatusId = new System.Windows.Forms.Label();
            brithDateLabel = new System.Windows.Forms.Label();
            lblName = new System.Windows.Forms.Label();
            lblLastName = new System.Windows.Forms.Label();
            lblIssueNo = new System.Windows.Forms.Label();
            nationalCodeLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            fatherNameLabel = new System.Windows.Forms.Label();
            lblUniversityDegreeId = new System.Windows.Forms.Label();
            lblMajorId = new System.Windows.Forms.Label();
            lblMaritalStatus = new System.Windows.Forms.Label();
            lblAddress = new System.Windows.Forms.Label();
            lblTel = new System.Windows.Forms.Label();
            lblUniversityName = new System.Windows.Forms.Label();
            lblStatus = new System.Windows.Forms.Label();
            lblDescription = new System.Windows.Forms.Label();
            respectDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.applicantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMobileNumber
            // 
            lblMobileNumber.AutoSize = true;
            lblMobileNumber.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            lblMobileNumber.Location = new System.Drawing.Point(344, 48);
            lblMobileNumber.Name = "lblMobileNumber";
            lblMobileNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            lblMobileNumber.Size = new System.Drawing.Size(39, 13);
            lblMobileNumber.TabIndex = 79;
            lblMobileNumber.Text = "موبایل:";
            // 
            // lblMilitaryServiceStatusId
            // 
            lblMilitaryServiceStatusId.AutoSize = true;
            lblMilitaryServiceStatusId.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            lblMilitaryServiceStatusId.Location = new System.Drawing.Point(627, 204);
            lblMilitaryServiceStatusId.Name = "lblMilitaryServiceStatusId";
            lblMilitaryServiceStatusId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            lblMilitaryServiceStatusId.Size = new System.Drawing.Size(77, 13);
            lblMilitaryServiceStatusId.TabIndex = 74;
            lblMilitaryServiceStatusId.Text = "وضعیت خدمت:";
            // 
            // brithDateLabel
            // 
            brithDateLabel.AutoSize = true;
            brithDateLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            brithDateLabel.Location = new System.Drawing.Point(626, 67);
            brithDateLabel.Name = "brithDateLabel";
            brithDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            brithDateLabel.Size = new System.Drawing.Size(55, 14);
            brithDateLabel.TabIndex = 73;
            brithDateLabel.Text = "تاریخ تولد:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            lblName.Location = new System.Drawing.Point(626, 15);
            lblName.Name = "lblName";
            lblName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            lblName.Size = new System.Drawing.Size(25, 14);
            lblName.TabIndex = 47;
            lblName.Text = "نام:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            lblLastName.Location = new System.Drawing.Point(626, 41);
            lblLastName.Name = "lblLastName";
            lblLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            lblLastName.Size = new System.Drawing.Size(76, 14);
            lblLastName.TabIndex = 50;
            lblLastName.Text = "نام خانوادگی:";
            // 
            // lblIssueNo
            // 
            lblIssueNo.AutoSize = true;
            lblIssueNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            lblIssueNo.Location = new System.Drawing.Point(626, 94);
            lblIssueNo.Name = "lblIssueNo";
            lblIssueNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            lblIssueNo.Size = new System.Drawing.Size(101, 14);
            lblIssueNo.TabIndex = 51;
            lblIssueNo.Text = "شماره شناسنامه:";
            // 
            // nationalCodeLabel
            // 
            nationalCodeLabel.AutoSize = true;
            nationalCodeLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            nationalCodeLabel.Location = new System.Drawing.Point(626, 120);
            nationalCodeLabel.Name = "nationalCodeLabel";
            nationalCodeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            nationalCodeLabel.Size = new System.Drawing.Size(50, 14);
            nationalCodeLabel.TabIndex = 54;
            nationalCodeLabel.Text = "کد ملی:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            genderLabel.Location = new System.Drawing.Point(626, 146);
            genderLabel.Name = "genderLabel";
            genderLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            genderLabel.Size = new System.Drawing.Size(39, 14);
            genderLabel.TabIndex = 57;
            genderLabel.Text = "جنس:";
            // 
            // fatherNameLabel
            // 
            fatherNameLabel.AutoSize = true;
            fatherNameLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            fatherNameLabel.Location = new System.Drawing.Point(626, 172);
            fatherNameLabel.Name = "fatherNameLabel";
            fatherNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            fatherNameLabel.Size = new System.Drawing.Size(43, 14);
            fatherNameLabel.TabIndex = 60;
            fatherNameLabel.Text = "نام پدر:";
            // 
            // lblUniversityDegreeId
            // 
            lblUniversityDegreeId.AutoSize = true;
            lblUniversityDegreeId.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            lblUniversityDegreeId.Location = new System.Drawing.Point(626, 229);
            lblUniversityDegreeId.Name = "lblUniversityDegreeId";
            lblUniversityDegreeId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            lblUniversityDegreeId.Size = new System.Drawing.Size(83, 14);
            lblUniversityDegreeId.TabIndex = 62;
            lblUniversityDegreeId.Text = "مدرک تحصیلی:";
            // 
            // lblMajorId
            // 
            lblMajorId.AutoSize = true;
            lblMajorId.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            lblMajorId.Location = new System.Drawing.Point(626, 255);
            lblMajorId.Name = "lblMajorId";
            lblMajorId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            lblMajorId.Size = new System.Drawing.Size(82, 14);
            lblMajorId.TabIndex = 65;
            lblMajorId.Text = "رشته تحصیلی:";
            // 
            // lblMaritalStatus
            // 
            lblMaritalStatus.AutoSize = true;
            lblMaritalStatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            lblMaritalStatus.Location = new System.Drawing.Point(626, 279);
            lblMaritalStatus.Name = "lblMaritalStatus";
            lblMaritalStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            lblMaritalStatus.Size = new System.Drawing.Size(74, 14);
            lblMaritalStatus.TabIndex = 67;
            lblMaritalStatus.Text = "وضعیت تاهل:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            lblAddress.Location = new System.Drawing.Point(344, 79);
            lblAddress.Name = "lblAddress";
            lblAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            lblAddress.Size = new System.Drawing.Size(39, 14);
            lblAddress.TabIndex = 68;
            lblAddress.Text = "آدرس:";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            lblTel.Location = new System.Drawing.Point(344, 20);
            lblTel.Name = "lblTel";
            lblTel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            lblTel.Size = new System.Drawing.Size(33, 14);
            lblTel.TabIndex = 69;
            lblTel.Text = "تلفن:";
            // 
            // lblUniversityName
            // 
            lblUniversityName.AutoSize = true;
            lblUniversityName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            lblUniversityName.Location = new System.Drawing.Point(626, 307);
            lblUniversityName.Name = "lblUniversityName";
            lblUniversityName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            lblUniversityName.Size = new System.Drawing.Size(121, 14);
            lblUniversityName.TabIndex = 70;
            lblUniversityName.Text = "نام آخرین محل تحصیل:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            lblStatus.Location = new System.Drawing.Point(344, 234);
            lblStatus.Name = "lblStatus";
            lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            lblStatus.Size = new System.Drawing.Size(50, 14);
            lblStatus.TabIndex = 71;
            lblStatus.Text = "وضعیت :";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            lblDescription.Location = new System.Drawing.Point(344, 144);
            lblDescription.Name = "lblDescription";
            lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            lblDescription.Size = new System.Drawing.Size(54, 14);
            lblDescription.TabIndex = 72;
            lblDescription.Text = "توضیحات:";
            // 
            // respectDateLabel
            // 
            respectDateLabel.AutoSize = true;
            respectDateLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            respectDateLabel.Location = new System.Drawing.Point(344, 265);
            respectDateLabel.Name = "respectDateLabel";
            respectDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            respectDateLabel.Size = new System.Drawing.Size(72, 14);
            respectDateLabel.TabIndex = 87;
            respectDateLabel.Text = "تاریخ مراجعه:";
            // 
            // statusComboBox
            // 
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.applicantBindingSource, "Status", true));
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(120, 233);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusComboBox.Size = new System.Drawing.Size(209, 22);
            this.statusComboBox.TabIndex = 66;
            // 
            // applicantBindingSource
            // 
            this.applicantBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.Applicant);
            // 
            // lblSetPersonnel
            // 
            this.lblSetPersonnel.AutoSize = true;
            this.lblSetPersonnel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSetPersonnel.Location = new System.Drawing.Point(200, 234);
            this.lblSetPersonnel.Name = "lblSetPersonnel";
            this.lblSetPersonnel.Size = new System.Drawing.Size(128, 14);
            this.lblSetPersonnel.TabIndex = 78;
            this.lblSetPersonnel.Text = "پرسنل شاغل در شرکت";
            // 
            // militaryServiceStatusNameTextBox
            // 
            this.militaryServiceStatusNameTextBox.BackColor = System.Drawing.Color.White;
            this.militaryServiceStatusNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantBindingSource, "MilitaryServiceStatusName", true));
            this.militaryServiceStatusNameTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.militaryServiceStatusNameTextBox.Location = new System.Drawing.Point(472, 198);
            this.militaryServiceStatusNameTextBox.Name = "militaryServiceStatusNameTextBox";
            this.militaryServiceStatusNameTextBox.ReadOnly = true;
            this.militaryServiceStatusNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.militaryServiceStatusNameTextBox.Size = new System.Drawing.Size(139, 22);
            this.militaryServiceStatusNameTextBox.TabIndex = 55;
            // 
            // selectUniversityDegreeButton
            // 
            this.selectUniversityDegreeButton.Location = new System.Drawing.Point(436, 225);
            this.selectUniversityDegreeButton.Name = "selectUniversityDegreeButton";
            this.selectUniversityDegreeButton.Size = new System.Drawing.Size(27, 23);
            this.selectUniversityDegreeButton.TabIndex = 77;
            this.selectUniversityDegreeButton.Text = "...";
            this.selectUniversityDegreeButton.UseVisualStyleBackColor = true;
            this.selectUniversityDegreeButton.Click += new System.EventHandler(this.selectUniversityDegreeButton_Click);
            // 
            // selectMajorsButton
            // 
            this.selectMajorsButton.Location = new System.Drawing.Point(436, 252);
            this.selectMajorsButton.Name = "selectMajorsButton";
            this.selectMajorsButton.Size = new System.Drawing.Size(27, 23);
            this.selectMajorsButton.TabIndex = 76;
            this.selectMajorsButton.Text = "...";
            this.selectMajorsButton.UseVisualStyleBackColor = true;
            this.selectMajorsButton.Click += new System.EventHandler(this.selectMajorsButton_Click);
            // 
            // selectMilitaryServiceStatusButton
            // 
            this.selectMilitaryServiceStatusButton.Location = new System.Drawing.Point(436, 198);
            this.selectMilitaryServiceStatusButton.Name = "selectMilitaryServiceStatusButton";
            this.selectMilitaryServiceStatusButton.Size = new System.Drawing.Size(27, 23);
            this.selectMilitaryServiceStatusButton.TabIndex = 75;
            this.selectMilitaryServiceStatusButton.Text = "...";
            this.selectMilitaryServiceStatusButton.UseVisualStyleBackColor = true;
            this.selectMilitaryServiceStatusButton.Click += new System.EventHandler(this.selectMilitaryServiceStatusButton_Click);
            // 
            // maritalStatusComboBox
            // 
            this.maritalStatusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.applicantBindingSource, "MaritalStatus", true));
            this.maritalStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.maritalStatusComboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.maritalStatusComboBox.FormattingEnabled = true;
            this.maritalStatusComboBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.maritalStatusComboBox.Location = new System.Drawing.Point(472, 278);
            this.maritalStatusComboBox.Name = "maritalStatusComboBox";
            this.maritalStatusComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.maritalStatusComboBox.Size = new System.Drawing.Size(139, 22);
            this.maritalStatusComboBox.TabIndex = 59;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.applicantBindingSource, "Gender", true));
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.genderComboBox.Location = new System.Drawing.Point(472, 143);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.genderComboBox.Size = new System.Drawing.Size(139, 22);
            this.genderComboBox.TabIndex = 52;
            // 
            // NameTextBox
            // 
            this.NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantBindingSource, "Name", true));
            this.NameTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NameTextBox.Location = new System.Drawing.Point(472, 12);
            this.NameTextBox.MaxLength = 64;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NameTextBox.Size = new System.Drawing.Size(139, 22);
            this.NameTextBox.TabIndex = 46;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantBindingSource, "LastName", true));
            this.lastNameTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lastNameTextBox.Location = new System.Drawing.Point(472, 38);
            this.lastNameTextBox.MaxLength = 64;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lastNameTextBox.Size = new System.Drawing.Size(139, 22);
            this.lastNameTextBox.TabIndex = 48;
            // 
            // fatherNameTextBox
            // 
            this.fatherNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantBindingSource, "FatherName", true));
            this.fatherNameTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.fatherNameTextBox.Location = new System.Drawing.Point(472, 169);
            this.fatherNameTextBox.MaxLength = 60;
            this.fatherNameTextBox.Name = "fatherNameTextBox";
            this.fatherNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fatherNameTextBox.Size = new System.Drawing.Size(139, 22);
            this.fatherNameTextBox.TabIndex = 53;
            // 
            // universityDegreeNameTextbox
            // 
            this.universityDegreeNameTextbox.BackColor = System.Drawing.Color.White;
            this.universityDegreeNameTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantBindingSource, "UniversityDegreeName", true));
            this.universityDegreeNameTextbox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.universityDegreeNameTextbox.Location = new System.Drawing.Point(472, 226);
            this.universityDegreeNameTextbox.Name = "universityDegreeNameTextbox";
            this.universityDegreeNameTextbox.ReadOnly = true;
            this.universityDegreeNameTextbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.universityDegreeNameTextbox.Size = new System.Drawing.Size(139, 22);
            this.universityDegreeNameTextbox.TabIndex = 56;
            // 
            // majorNameTextBox
            // 
            this.majorNameTextBox.BackColor = System.Drawing.Color.White;
            this.majorNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantBindingSource, "MajorName", true));
            this.majorNameTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.majorNameTextBox.Location = new System.Drawing.Point(472, 252);
            this.majorNameTextBox.MaxLength = 64;
            this.majorNameTextBox.Name = "majorNameTextBox";
            this.majorNameTextBox.ReadOnly = true;
            this.majorNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.majorNameTextBox.Size = new System.Drawing.Size(139, 22);
            this.majorNameTextBox.TabIndex = 58;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantBindingSource, "Address", true));
            this.addressTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.addressTextBox.Location = new System.Drawing.Point(36, 74);
            this.addressTextBox.MaxLength = 510;
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addressTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.addressTextBox.Size = new System.Drawing.Size(293, 59);
            this.addressTextBox.TabIndex = 63;
            // 
            // universityNameTextBox
            // 
            this.universityNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantBindingSource, "UniversityName", true));
            this.universityNameTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.universityNameTextBox.Location = new System.Drawing.Point(344, 304);
            this.universityNameTextBox.MaxLength = 64;
            this.universityNameTextBox.Multiline = true;
            this.universityNameTextBox.Name = "universityNameTextBox";
            this.universityNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.universityNameTextBox.Size = new System.Drawing.Size(267, 46);
            this.universityNameTextBox.TabIndex = 61;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantBindingSource, "Description", true));
            this.descriptionTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.descriptionTextBox.Location = new System.Drawing.Point(36, 141);
            this.descriptionTextBox.MaxLength = 510;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.descriptionTextBox.Size = new System.Drawing.Size(293, 82);
            this.descriptionTextBox.TabIndex = 64;
            // 
            // cancelButton
            // 
            this.cancelButton.CausesValidation = false;
            this.cancelButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelButton.ImageIndex = 3;
            this.cancelButton.Location = new System.Drawing.Point(7, 349);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(107, 23);
            this.cancelButton.TabIndex = 85;
            this.cancelButton.Text = "لغو (esc)";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveButton.ImageIndex = 1;
            this.saveButton.Location = new System.Drawing.Point(120, 349);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 23);
            this.saveButton.TabIndex = 84;
            this.saveButton.Text = "ذخیره (F5)";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // brithDateDatePicker
            // 
            this.brithDateDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.brithDateDatePicker.DataBindings.Add(new System.Windows.Forms.Binding("SelectedDateTime", this.applicantBindingSource, "BrithDate", true));
            this.brithDateDatePicker.Location = new System.Drawing.Point(472, 67);
            this.brithDateDatePicker.Name = "brithDateDatePicker";
            this.brithDateDatePicker.Size = new System.Drawing.Size(139, 20);
            this.brithDateDatePicker.TabIndex = 89;
            this.brithDateDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // respectDateFaDatePicker
            // 
            this.respectDateFaDatePicker.DataBindings.Add(new System.Windows.Forms.Binding("SelectedDateTime", this.applicantBindingSource, "RespectDate", true));
            this.respectDateFaDatePicker.Location = new System.Drawing.Point(179, 261);
            this.respectDateFaDatePicker.Name = "respectDateFaDatePicker";
            this.respectDateFaDatePicker.Size = new System.Drawing.Size(150, 20);
            this.respectDateFaDatePicker.TabIndex = 90;
            this.respectDateFaDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // issueNoTextBox
            // 
            this.issueNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantBindingSource, "IssueNo", true));
            this.issueNoTextBox.Location = new System.Drawing.Point(472, 92);
            this.issueNoTextBox.Name = "issueNoTextBox";
            this.issueNoTextBox.Size = new System.Drawing.Size(139, 21);
            this.issueNoTextBox.TabIndex = 91;
            // 
            // NationalCodeTextBox
            // 
            this.NationalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantBindingSource, "NationalCode", true));
            this.NationalCodeTextBox.Location = new System.Drawing.Point(472, 118);
            this.NationalCodeTextBox.Name = "NationalCodeTextBox";
            this.NationalCodeTextBox.Size = new System.Drawing.Size(139, 21);
            this.NationalCodeTextBox.TabIndex = 92;
            // 
            // tellTextBox
            // 
            this.tellTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantBindingSource, "Tel", true));
            this.tellTextBox.Location = new System.Drawing.Point(179, 13);
            this.tellTextBox.Name = "tellTextBox";
            this.tellTextBox.Size = new System.Drawing.Size(150, 21);
            this.tellTextBox.TabIndex = 93;
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.applicantBindingSource, "MobileNumber", true));
            this.mobileTextBox.Location = new System.Drawing.Point(179, 45);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(150, 21);
            this.mobileTextBox.TabIndex = 94;
            // 
            // EditApplicantDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(767, 384);
            this.Controls.Add(this.mobileTextBox);
            this.Controls.Add(this.tellTextBox);
            this.Controls.Add(this.NationalCodeTextBox);
            this.Controls.Add(this.issueNoTextBox);
            this.Controls.Add(this.respectDateFaDatePicker);
            this.Controls.Add(this.brithDateDatePicker);
            this.Controls.Add(respectDateLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(lblMobileNumber);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.lblSetPersonnel);
            this.Controls.Add(this.militaryServiceStatusNameTextBox);
            this.Controls.Add(this.selectUniversityDegreeButton);
            this.Controls.Add(this.selectMajorsButton);
            this.Controls.Add(this.selectMilitaryServiceStatusButton);
            this.Controls.Add(lblMilitaryServiceStatusId);
            this.Controls.Add(brithDateLabel);
            this.Controls.Add(this.maritalStatusComboBox);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(lblName);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(lblLastName);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(lblIssueNo);
            this.Controls.Add(nationalCodeLabel);
            this.Controls.Add(genderLabel);
            this.Controls.Add(fatherNameLabel);
            this.Controls.Add(this.fatherNameTextBox);
            this.Controls.Add(lblUniversityDegreeId);
            this.Controls.Add(this.universityDegreeNameTextbox);
            this.Controls.Add(lblMajorId);
            this.Controls.Add(this.majorNameTextBox);
            this.Controls.Add(lblMaritalStatus);
            this.Controls.Add(lblAddress);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(lblTel);
            this.Controls.Add(lblUniversityName);
            this.Controls.Add(this.universityNameTextBox);
            this.Controls.Add(lblStatus);
            this.Controls.Add(lblDescription);
            this.Controls.Add(this.descriptionTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditApplicantDialogForm";
            this.RightToLeftLayout = false;
            this.ShowInTaskbar = false;
            this.Text = "ویرایش کارجو";
            this.Load += new System.EventHandler(this.EditApplicantDialogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.applicantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label lblSetPersonnel;
        private System.Windows.Forms.TextBox militaryServiceStatusNameTextBox;
        private System.Windows.Forms.Button selectUniversityDegreeButton;
        private System.Windows.Forms.Button selectMajorsButton;
        private System.Windows.Forms.Button selectMilitaryServiceStatusButton;
        private System.Windows.Forms.ComboBox maritalStatusComboBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox fatherNameTextBox;
        private System.Windows.Forms.TextBox universityDegreeNameTextbox;
        private System.Windows.Forms.TextBox majorNameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox universityNameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.BindingSource applicantBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private FarsiLibrary.Win.Controls.FADatePicker respectDateFaDatePicker;
        private FarsiLibrary.Win.Controls.FADatePicker brithDateDatePicker;
        private System.Windows.Forms.TextBox issueNoTextBox;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.TextBox tellTextBox;
        private System.Windows.Forms.TextBox NationalCodeTextBox;
    }
}