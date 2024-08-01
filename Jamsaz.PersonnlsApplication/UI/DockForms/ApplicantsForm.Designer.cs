namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    partial class ApplicantsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicantsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.insertApplicantButton = new System.Windows.Forms.Button();
            this.imageListControl = new System.Windows.Forms.ImageList(this.components);
            this.lblCountpersonnel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.applicantDataGridView = new System.Windows.Forms.DataGridView();
            this.RespectDate = new FarsiLibrary.Win.Controls.DataGridViewFADateTimePickerColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.majorSelectButton = new System.Windows.Forms.Button();
            this.majorNameTextBox = new System.Windows.Forms.TextBox();
            this.majorLabel = new System.Windows.Forms.Label();
            this.countPersonnelTextBox = new System.Windows.Forms.TextBox();
            this.clearControlsButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.fatherNameLabel = new System.Windows.Forms.Label();
            this.issueNoLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.fatherNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.importToTablePersonnelsButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editApplicantButton = new System.Windows.Forms.Button();
            this.applicantsWorkExperiencesDataGridView = new System.Windows.Forms.DataGridView();
            this.applicantsWorkExperiencesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.selfRegistrationCheckbox = new System.Windows.Forms.CheckBox();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new FarsiLibrary.Win.Controls.DataGridViewFADateTimePickerColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new FarsiLibrary.Win.Controls.DataGridViewFADateTimePickerColumn();
            this.dataGridViewTextBoxColumn14 = new FarsiLibrary.Win.Controls.DataGridViewFADateTimePickerColumn();
            this.issueNoLabelTextBox = new Jamsaz.PersonnlsApplication.Classes.NullableTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicantDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicantsWorkExperiencesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantsWorkExperiencesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // insertApplicantButton
            // 
            this.insertApplicantButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.insertApplicantButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.insertApplicantButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.insertApplicantButton.ImageIndex = 0;
            this.insertApplicantButton.ImageList = this.imageListControl;
            this.insertApplicantButton.Location = new System.Drawing.Point(970, 13);
            this.insertApplicantButton.Name = "insertApplicantButton";
            this.insertApplicantButton.Size = new System.Drawing.Size(125, 30);
            this.insertApplicantButton.TabIndex = 0;
            this.insertApplicantButton.Text = "اضافه کردن";
            this.insertApplicantButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.insertApplicantButton.UseVisualStyleBackColor = true;
            this.insertApplicantButton.Click += new System.EventHandler(this.insertApplicantButton_Click);
            // 
            // imageListControl
            // 
            this.imageListControl.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListControl.ImageStream")));
            this.imageListControl.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListControl.Images.SetKeyName(0, "l_add.gif");
            this.imageListControl.Images.SetKeyName(1, "l_cancel.gif");
            this.imageListControl.Images.SetKeyName(2, "l_clear.gif");
            this.imageListControl.Images.SetKeyName(3, "l_filesearch.gif");
            this.imageListControl.Images.SetKeyName(4, "is_halfcmtbad.gif");
            this.imageListControl.Images.SetKeyName(5, "downloading.gif");
            this.imageListControl.Images.SetKeyName(6, "Save.ico");
            // 
            // lblCountpersonnel
            // 
            this.lblCountpersonnel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountpersonnel.AutoSize = true;
            this.lblCountpersonnel.Location = new System.Drawing.Point(118, 31);
            this.lblCountpersonnel.Name = "lblCountpersonnel";
            this.lblCountpersonnel.Size = new System.Drawing.Size(33, 13);
            this.lblCountpersonnel.TabIndex = 41;
            this.lblCountpersonnel.Text = "تعداد ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.applicantsWorkExperiencesDataGridView, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.31992F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.68008F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1109, 673);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.applicantDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 127);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(1103, 259);
            this.panel1.TabIndex = 0;
            // 
            // applicantDataGridView
            // 
            this.applicantDataGridView.AllowUserToAddRows = false;
            this.applicantDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.applicantDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.applicantDataGridView.AutoGenerateColumns = false;
            this.applicantDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.applicantDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.applicantDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn12,
            this.RespectDate});
            this.applicantDataGridView.DataSource = this.applicantBindingSource;
            this.applicantDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applicantDataGridView.Location = new System.Drawing.Point(1, 1);
            this.applicantDataGridView.MultiSelect = false;
            this.applicantDataGridView.Name = "applicantDataGridView";
            this.applicantDataGridView.ReadOnly = true;
            this.applicantDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.applicantDataGridView.Size = new System.Drawing.Size(1101, 257);
            this.applicantDataGridView.TabIndex = 0;
            this.applicantDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.applicantDataGridView_CellDoubleClick);
            // 
            // RespectDate
            // 
            this.RespectDate.DataPropertyName = "RespectDate";
            this.RespectDate.FillWeight = 85F;
            this.RespectDate.HeaderText = "تاریخ مراجعه";
            this.RespectDate.Name = "RespectDate";
            this.RespectDate.ReadOnly = true;
            this.RespectDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RespectDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.RespectDate.VerticalAlignment = System.Drawing.StringAlignment.Near;
            this.RespectDate.Width = 80;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.groupBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel3.Size = new System.Drawing.Size(1103, 118);
            this.panel3.TabIndex = 2;
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox.Controls.Add(this.selfRegistrationCheckbox);
            this.groupBox.Controls.Add(this.majorSelectButton);
            this.groupBox.Controls.Add(this.majorNameTextBox);
            this.groupBox.Controls.Add(this.majorLabel);
            this.groupBox.Controls.Add(this.issueNoLabelTextBox);
            this.groupBox.Controls.Add(this.countPersonnelTextBox);
            this.groupBox.Controls.Add(this.lblCountpersonnel);
            this.groupBox.Controls.Add(this.clearControlsButton);
            this.groupBox.Controls.Add(this.searchButton);
            this.groupBox.Controls.Add(this.fatherNameLabel);
            this.groupBox.Controls.Add(this.issueNoLabel);
            this.groupBox.Controls.Add(this.lastNameLabel);
            this.groupBox.Controls.Add(this.nameLabel);
            this.groupBox.Controls.Add(this.fatherNameTextBox);
            this.groupBox.Controls.Add(this.lastNameTextBox);
            this.groupBox.Controls.Add(this.nameTextbox);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.errorProvider1.SetIconAlignment(this.groupBox, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.groupBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.groupBox.Location = new System.Drawing.Point(159, 4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(939, 110);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "           جستجو کارجو            ";
            // 
            // majorSelectButton
            // 
            this.majorSelectButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.majorSelectButton.ImageList = this.imageListControl;
            this.majorSelectButton.Location = new System.Drawing.Point(570, 63);
            this.majorSelectButton.Name = "majorSelectButton";
            this.majorSelectButton.Size = new System.Drawing.Size(36, 21);
            this.majorSelectButton.TabIndex = 46;
            this.majorSelectButton.Text = "...";
            this.majorSelectButton.UseVisualStyleBackColor = true;
            this.majorSelectButton.Click += new System.EventHandler(this.majorSelectButton_Click);
            // 
            // majorNameTextBox
            // 
            this.majorNameTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.majorNameTextBox.Location = new System.Drawing.Point(612, 63);
            this.majorNameTextBox.MaxLength = 64;
            this.majorNameTextBox.Name = "majorNameTextBox";
            this.majorNameTextBox.ReadOnly = true;
            this.majorNameTextBox.Size = new System.Drawing.Size(227, 21);
            this.majorNameTextBox.TabIndex = 45;
            // 
            // majorLabel
            // 
            this.majorLabel.AutoSize = true;
            this.majorLabel.Location = new System.Drawing.Point(838, 67);
            this.majorLabel.Name = "majorLabel";
            this.majorLabel.Size = new System.Drawing.Size(80, 13);
            this.majorLabel.TabIndex = 44;
            this.majorLabel.Text = "رشته تحصیلی: ";
            // 
            // countPersonnelTextBox
            // 
            this.countPersonnelTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.countPersonnelTextBox.BackColor = System.Drawing.Color.Pink;
            this.countPersonnelTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.countPersonnelTextBox.Location = new System.Drawing.Point(26, 28);
            this.countPersonnelTextBox.Multiline = true;
            this.countPersonnelTextBox.Name = "countPersonnelTextBox";
            this.countPersonnelTextBox.ReadOnly = true;
            this.countPersonnelTextBox.Size = new System.Drawing.Size(86, 19);
            this.countPersonnelTextBox.TabIndex = 42;
            this.countPersonnelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clearControlsButton
            // 
            this.clearControlsButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearControlsButton.ImageIndex = 4;
            this.clearControlsButton.ImageList = this.imageListControl;
            this.clearControlsButton.Location = new System.Drawing.Point(35, 67);
            this.clearControlsButton.Name = "clearControlsButton";
            this.clearControlsButton.Size = new System.Drawing.Size(49, 28);
            this.clearControlsButton.TabIndex = 37;
            this.clearControlsButton.UseVisualStyleBackColor = true;
            this.clearControlsButton.Click += new System.EventHandler(this.clearControlsButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchButton.ImageIndex = 3;
            this.searchButton.ImageList = this.imageListControl;
            this.searchButton.Location = new System.Drawing.Point(90, 67);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(97, 28);
            this.searchButton.TabIndex = 30;
            this.searchButton.Text = "جستجو";
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // fatherNameLabel
            // 
            this.fatherNameLabel.AutoSize = true;
            this.fatherNameLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatherNameLabel.Location = new System.Drawing.Point(290, 30);
            this.fatherNameLabel.Name = "fatherNameLabel";
            this.fatherNameLabel.Size = new System.Drawing.Size(39, 14);
            this.fatherNameLabel.TabIndex = 28;
            this.fatherNameLabel.Text = "نام پدر";
            // 
            // issueNoLabel
            // 
            this.issueNoLabel.AutoSize = true;
            this.issueNoLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueNoLabel.Location = new System.Drawing.Point(452, 31);
            this.issueNoLabel.Name = "issueNoLabel";
            this.issueNoLabel.Size = new System.Drawing.Size(97, 14);
            this.issueNoLabel.TabIndex = 27;
            this.issueNoLabel.Text = "شماره شناسنامه";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(679, 29);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(72, 14);
            this.lastNameLabel.TabIndex = 26;
            this.lastNameLabel.Text = "نام خانوادگی";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(897, 33);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(21, 14);
            this.nameLabel.TabIndex = 25;
            this.nameLabel.Text = "نام";
            // 
            // fatherNameTextBox
            // 
            this.fatherNameTextBox.Location = new System.Drawing.Point(169, 27);
            this.fatherNameTextBox.MaxLength = 64;
            this.fatherNameTextBox.Name = "fatherNameTextBox";
            this.fatherNameTextBox.Size = new System.Drawing.Size(116, 21);
            this.fatherNameTextBox.TabIndex = 24;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(557, 26);
            this.lastNameTextBox.MaxLength = 64;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(116, 21);
            this.lastNameTextBox.TabIndex = 23;
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(757, 26);
            this.nameTextbox.MaxLength = 64;
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(128, 21);
            this.nameTextbox.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.SaveButton);
            this.panel2.Controls.Add(this.importToTablePersonnelsButton);
            this.panel2.Controls.Add(this.deleteButton);
            this.panel2.Controls.Add(this.editApplicantButton);
            this.panel2.Controls.Add(this.insertApplicantButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 624);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Size = new System.Drawing.Size(1103, 46);
            this.panel2.TabIndex = 1;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveButton.ImageIndex = 6;
            this.SaveButton.ImageList = this.imageListControl;
            this.SaveButton.Location = new System.Drawing.Point(608, 13);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(111, 30);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "ذخیره (F5) ";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // importToTablePersonnelsButton
            // 
            this.importToTablePersonnelsButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.importToTablePersonnelsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.importToTablePersonnelsButton.ImageIndex = 5;
            this.importToTablePersonnelsButton.ImageList = this.imageListControl;
            this.importToTablePersonnelsButton.Location = new System.Drawing.Point(19, 9);
            this.importToTablePersonnelsButton.Name = "importToTablePersonnelsButton";
            this.importToTablePersonnelsButton.Size = new System.Drawing.Size(136, 30);
            this.importToTablePersonnelsButton.TabIndex = 3;
            this.importToTablePersonnelsButton.Text = "انتقال به لیست پرسنل";
            this.importToTablePersonnelsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.importToTablePersonnelsButton.UseVisualStyleBackColor = true;
            this.importToTablePersonnelsButton.Click += new System.EventHandler(this.importToTablePersonnelsButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteButton.ImageIndex = 1;
            this.deleteButton.ImageList = this.imageListControl;
            this.deleteButton.Location = new System.Drawing.Point(725, 13);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(111, 30);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "حذف";
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editApplicantButton
            // 
            this.editApplicantButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editApplicantButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.editApplicantButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editApplicantButton.ImageIndex = 2;
            this.editApplicantButton.ImageList = this.imageListControl;
            this.editApplicantButton.Location = new System.Drawing.Point(843, 13);
            this.editApplicantButton.Name = "editApplicantButton";
            this.editApplicantButton.Size = new System.Drawing.Size(124, 30);
            this.editApplicantButton.TabIndex = 1;
            this.editApplicantButton.Text = "ویرایش (F2)";
            this.editApplicantButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editApplicantButton.UseVisualStyleBackColor = true;
            this.editApplicantButton.Click += new System.EventHandler(this.editApplicantButton_Click);
            // 
            // applicantsWorkExperiencesDataGridView
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.applicantsWorkExperiencesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.applicantsWorkExperiencesDataGridView.AutoGenerateColumns = false;
            this.applicantsWorkExperiencesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.applicantsWorkExperiencesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.applicantsWorkExperiencesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.applicantsWorkExperiencesDataGridView.DataSource = this.applicantsWorkExperiencesBindingSource;
            this.applicantsWorkExperiencesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applicantsWorkExperiencesDataGridView.Location = new System.Drawing.Point(3, 392);
            this.applicantsWorkExperiencesDataGridView.Name = "applicantsWorkExperiencesDataGridView";
            this.applicantsWorkExperiencesDataGridView.Size = new System.Drawing.Size(1103, 226);
            this.applicantsWorkExperiencesDataGridView.TabIndex = 3;
            // 
            // applicantsWorkExperiencesBindingSource
            // 
            this.applicantsWorkExperiencesBindingSource.DataMember = "ApplicantsWorkExperiences";
            this.applicantsWorkExperiencesBindingSource.DataSource = this.applicantBindingSource;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // selfRegistrationCheckbox
            // 
            this.selfRegistrationCheckbox.AutoSize = true;
            this.selfRegistrationCheckbox.Location = new System.Drawing.Point(445, 65);
            this.selfRegistrationCheckbox.Name = "selfRegistrationCheckbox";
            this.selfRegistrationCheckbox.Size = new System.Drawing.Size(101, 17);
            this.selfRegistrationCheckbox.TabIndex = 47;
            this.selfRegistrationCheckbox.Text = "ثبت نام در سایت";
            this.selfRegistrationCheckbox.UseVisualStyleBackColor = true;
            this.selfRegistrationCheckbox.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "نام";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "نام خانوادگی";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IssueNo";
            this.dataGridViewTextBoxColumn4.HeaderText = "ش.شناسنامه";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NationalCode";
            this.dataGridViewTextBoxColumn5.HeaderText = "کد ملی";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "FatherName";
            this.dataGridViewTextBoxColumn8.HeaderText = "نام پدر";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "BrithDate";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn6.FillWeight = 80F;
            this.dataGridViewTextBoxColumn6.HeaderText = "تاریخ تولد";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.VerticalAlignment = System.Drawing.StringAlignment.Near;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "GenderName";
            this.dataGridViewTextBoxColumn7.HeaderText = "جنسیت";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "MaritalStatusName";
            this.dataGridViewTextBoxColumn12.HeaderText = "تاهل";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // applicantBindingSource
            // 
            this.applicantBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.Applicant);
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CompanyName";
            this.dataGridViewTextBoxColumn10.FillWeight = 200F;
            this.dataGridViewTextBoxColumn10.HeaderText = "نام شرکت";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 200;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "ReasonOfLeaving";
            this.dataGridViewTextBoxColumn15.FillWeight = 200F;
            this.dataGridViewTextBoxColumn15.HeaderText = "علت ترک";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 200;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Role";
            this.dataGridViewTextBoxColumn11.FillWeight = 200F;
            this.dataGridViewTextBoxColumn11.HeaderText = "سمت";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 200;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "StartDate";
            this.dataGridViewTextBoxColumn13.HeaderText = "تاریخ شروع";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn13.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "EndDate";
            this.dataGridViewTextBoxColumn14.HeaderText = "تاریخ پایان";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn14.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // issueNoLabelTextBox
            // 
            this.issueNoLabelTextBox.Location = new System.Drawing.Point(346, 27);
            this.issueNoLabelTextBox.Name = "issueNoLabelTextBox";
            this.issueNoLabelTextBox.NullableText = null;
            this.issueNoLabelTextBox.Size = new System.Drawing.Size(100, 21);
            this.issueNoLabelTextBox.TabIndex = 43;
            // 
            // ApplicantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1109, 673);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ApplicantsForm";
            this.Text = "کارجو";
            this.Load += new System.EventHandler(this.ApplicantsForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.applicantDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.applicantsWorkExperiencesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantsWorkExperiencesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insertApplicantButton;
        private System.Windows.Forms.ImageList imageListControl;
        private System.Windows.Forms.Label lblCountpersonnel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button importToTablePersonnelsButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editApplicantButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox countPersonnelTextBox;
        private System.Windows.Forms.Button clearControlsButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label fatherNameLabel;
        private System.Windows.Forms.Label issueNoLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox fatherNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource applicantsWorkExperiencesBindingSource;
        private System.Windows.Forms.BindingSource applicantBindingSource;
        private System.Windows.Forms.DataGridView applicantDataGridView;
        private System.Windows.Forms.Button SaveButton;
        private Jamsaz.PersonnlsApplication.Classes.NullableTextBox issueNoLabelTextBox;
        private System.Windows.Forms.DataGridView applicantsWorkExperiencesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private FarsiLibrary.Win.Controls.DataGridViewFADateTimePickerColumn dataGridViewTextBoxColumn13;
        private FarsiLibrary.Win.Controls.DataGridViewFADateTimePickerColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private FarsiLibrary.Win.Controls.DataGridViewFADateTimePickerColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private FarsiLibrary.Win.Controls.DataGridViewFADateTimePickerColumn RespectDate;
        private System.Windows.Forms.TextBox majorNameTextBox;
        private System.Windows.Forms.Label majorLabel;
        private System.Windows.Forms.Button majorSelectButton;
        private System.Windows.Forms.CheckBox selfRegistrationCheckbox;
    }
}