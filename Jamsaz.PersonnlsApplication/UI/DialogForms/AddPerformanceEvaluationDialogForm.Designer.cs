namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class AddPerformanceEvaluationDialogForm
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
            System.Windows.Forms.Label personnelIDLabel;
            System.Windows.Forms.Label startDateAssessmentLabel;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stepComboBox = new System.Windows.Forms.ComboBox();
            this.evaluationStepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.positiontextBox = new System.Windows.Forms.TextBox();
            this.performancEvaluationMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.startDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.workStartTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DepartmenttextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.personnelNumbertextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.personnelListButton = new System.Windows.Forms.Button();
            this.personnelIDTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.performancEvaluationDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evalutionIndexIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.performancEvaluationDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.directorOfAdministrationTextBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.unitManagerTextBox = new System.Windows.Forms.TextBox();
            this.valuatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.trainingRequiredTextBox = new System.Windows.Forms.TextBox();
            personnelIDLabel = new System.Windows.Forms.Label();
            startDateAssessmentLabel = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.evaluationStepBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performancEvaluationMasterBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performancEvaluationDetailsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performancEvaluationDetailsBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valuatorBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // personnelIDLabel
            // 
            personnelIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            personnelIDLabel.AutoSize = true;
            personnelIDLabel.Location = new System.Drawing.Point(1003, 35);
            personnelIDLabel.Name = "personnelIDLabel";
            personnelIDLabel.Size = new System.Drawing.Size(91, 13);
            personnelIDLabel.TabIndex = 0;
            personnelIDLabel.Text = "نام ارزیابی شونده:";
            // 
            // startDateAssessmentLabel
            // 
            startDateAssessmentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            startDateAssessmentLabel.AutoSize = true;
            startDateAssessmentLabel.Location = new System.Drawing.Point(477, 65);
            startDateAssessmentLabel.Name = "startDateAssessmentLabel";
            startDateAssessmentLabel.Size = new System.Drawing.Size(66, 13);
            startDateAssessmentLabel.TabIndex = 28;
            startDateAssessmentLabel.Text = "تاریخ ارزیابی:";
            // 
            // label6
            // 
            label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(478, 97);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(39, 13);
            label6.TabIndex = 34;
            label6.Text = "مرحله:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1118, 540);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stepComboBox);
            this.groupBox1.Controls.Add(label6);
            this.groupBox1.Controls.Add(this.positiontextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.startDatePicker);
            this.groupBox1.Controls.Add(startDateAssessmentLabel);
            this.groupBox1.Controls.Add(this.workStartTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DepartmenttextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.personnelNumbertextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.personnelListButton);
            this.groupBox1.Controls.Add(personnelIDLabel);
            this.groupBox1.Controls.Add(this.personnelIDTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1112, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات";
            // 
            // stepComboBox
            // 
            this.stepComboBox.DataSource = this.evaluationStepBindingSource;
            this.stepComboBox.DisplayMember = "Name";
            this.stepComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stepComboBox.FormattingEnabled = true;
            this.stepComboBox.Location = new System.Drawing.Point(327, 94);
            this.stepComboBox.Name = "stepComboBox";
            this.stepComboBox.Size = new System.Drawing.Size(145, 21);
            this.stepComboBox.TabIndex = 35;
            this.stepComboBox.ValueMember = "ID";
            // 
            // evaluationStepBindingSource
            // 
            this.evaluationStepBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.EvaluationStep);
            // 
            // positiontextBox
            // 
            this.positiontextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.positiontextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performancEvaluationMasterBindingSource, "Positon", true));
            this.positiontextBox.Location = new System.Drawing.Point(595, 65);
            this.positiontextBox.Name = "positiontextBox";
            this.positiontextBox.ReadOnly = true;
            this.positiontextBox.Size = new System.Drawing.Size(134, 21);
            this.positiontextBox.TabIndex = 33;
            // 
            // performancEvaluationMasterBindingSource
            // 
            this.performancEvaluationMasterBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.PerformancEvaluationMaster);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(735, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "سمت شغلی:";
            // 
            // startDatePicker
            // 
            this.startDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startDatePicker.DataBindings.Add(new System.Windows.Forms.Binding("SelectedDateTime", this.performancEvaluationMasterBindingSource, "StartDateAssessment", true));
            this.startDatePicker.Location = new System.Drawing.Point(327, 65);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(145, 20);
            this.startDatePicker.TabIndex = 30;
            this.startDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // workStartTextBox
            // 
            this.workStartTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.workStartTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performancEvaluationMasterBindingSource, "WorkStartDate", true));
            this.workStartTextBox.Location = new System.Drawing.Point(867, 69);
            this.workStartTextBox.Name = "workStartTextBox";
            this.workStartTextBox.ReadOnly = true;
            this.workStartTextBox.Size = new System.Drawing.Size(131, 21);
            this.workStartTextBox.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1002, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "تاریخ شروع به کار:";
            // 
            // DepartmenttextBox
            // 
            this.DepartmenttextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DepartmenttextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performancEvaluationMasterBindingSource, "Department", true));
            this.DepartmenttextBox.Location = new System.Drawing.Point(327, 30);
            this.DepartmenttextBox.Name = "DepartmenttextBox";
            this.DepartmenttextBox.ReadOnly = true;
            this.DepartmenttextBox.Size = new System.Drawing.Size(145, 21);
            this.DepartmenttextBox.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "نام واحد سازمانی:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1129, 520);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "نام واحد سازمانی:";
            // 
            // personnelNumbertextBox
            // 
            this.personnelNumbertextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.personnelNumbertextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performancEvaluationMasterBindingSource, "PersonnelNumber", true));
            this.personnelNumbertextBox.Location = new System.Drawing.Point(595, 30);
            this.personnelNumbertextBox.Name = "personnelNumbertextBox";
            this.personnelNumbertextBox.ReadOnly = true;
            this.personnelNumbertextBox.Size = new System.Drawing.Size(134, 21);
            this.personnelNumbertextBox.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(735, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "شماره پرسنلی:";
            // 
            // personnelListButton
            // 
            this.personnelListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.personnelListButton.Location = new System.Drawing.Point(833, 30);
            this.personnelListButton.Name = "personnelListButton";
            this.personnelListButton.Size = new System.Drawing.Size(28, 23);
            this.personnelListButton.TabIndex = 20;
            this.personnelListButton.Text = "...";
            this.personnelListButton.UseVisualStyleBackColor = true;
            this.personnelListButton.Click += new System.EventHandler(this.personnelListButton_Click);
            // 
            // personnelIDTextBox
            // 
            this.personnelIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.personnelIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performancEvaluationMasterBindingSource, "FullName", true));
            this.personnelIDTextBox.Location = new System.Drawing.Point(867, 32);
            this.personnelIDTextBox.Name = "personnelIDTextBox";
            this.personnelIDTextBox.ReadOnly = true;
            this.personnelIDTextBox.Size = new System.Drawing.Size(130, 21);
            this.personnelIDTextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.performancEvaluationDetailsDataGridView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1112, 154);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ارزیابی عملکرد";
            // 
            // performancEvaluationDetailsDataGridView
            // 
            this.performancEvaluationDetailsDataGridView.AllowUserToAddRows = false;
            this.performancEvaluationDetailsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.performancEvaluationDetailsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.performancEvaluationDetailsDataGridView.AutoGenerateColumns = false;
            this.performancEvaluationDetailsDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.performancEvaluationDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.performancEvaluationDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Title,
            this.Description,
            this.ID,
            this.evalutionIndexIDDataGridViewTextBoxColumn});
            this.performancEvaluationDetailsDataGridView.DataSource = this.performancEvaluationDetailsBindingSource;
            this.performancEvaluationDetailsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.performancEvaluationDetailsDataGridView.Location = new System.Drawing.Point(3, 17);
            this.performancEvaluationDetailsDataGridView.Name = "performancEvaluationDetailsDataGridView";
            this.performancEvaluationDetailsDataGridView.Size = new System.Drawing.Size(1106, 134);
            this.performancEvaluationDetailsDataGridView.TabIndex = 0;
            this.performancEvaluationDetailsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.performancEvaluationDetailsDataGridView_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CategoryTitle";
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "شاخص ارزیابی ";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 200;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "شرح علت";
            this.Description.Name = "Description";
            this.Description.Width = 200;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // evalutionIndexIDDataGridViewTextBoxColumn
            // 
            this.evalutionIndexIDDataGridViewTextBoxColumn.DataPropertyName = "EvalutionIndexID";
            this.evalutionIndexIDDataGridViewTextBoxColumn.HeaderText = "EvalutionIndexID";
            this.evalutionIndexIDDataGridViewTextBoxColumn.Name = "evalutionIndexIDDataGridViewTextBoxColumn";
            this.evalutionIndexIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // performancEvaluationDetailsBindingSource
            // 
            this.performancEvaluationDetailsBindingSource.DataMember = "PerformancEvaluationDetails";
            this.performancEvaluationDetailsBindingSource.DataSource = this.performancEvaluationMasterBindingSource;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cancelButton);
            this.groupBox3.Controls.Add(this.saveButton);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 493);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1112, 44);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.arrow_up;
            this.cancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelButton.Location = new System.Drawing.Point(9, 15);
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
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.arrow_down;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveButton.Location = new System.Drawing.Point(90, 15);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "تایید";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox5, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 293);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1112, 94);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.directorOfAdministrationTextBox);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(550, 88);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "نقاط قابل بهبود";
            // 
            // directorOfAdministrationTextBox
            // 
            this.directorOfAdministrationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performancEvaluationMasterBindingSource, "ImprovedPoints", true));
            this.directorOfAdministrationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directorOfAdministrationTextBox.Location = new System.Drawing.Point(3, 17);
            this.directorOfAdministrationTextBox.Multiline = true;
            this.directorOfAdministrationTextBox.Name = "directorOfAdministrationTextBox";
            this.directorOfAdministrationTextBox.Size = new System.Drawing.Size(544, 68);
            this.directorOfAdministrationTextBox.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.unitManagerTextBox);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(559, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(550, 88);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "نقاط قوت";
            // 
            // unitManagerTextBox
            // 
            this.unitManagerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performancEvaluationMasterBindingSource, "Strengths", true));
            this.unitManagerTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitManagerTextBox.Location = new System.Drawing.Point(3, 17);
            this.unitManagerTextBox.Multiline = true;
            this.unitManagerTextBox.Name = "unitManagerTextBox";
            this.unitManagerTextBox.Size = new System.Drawing.Size(544, 68);
            this.unitManagerTextBox.TabIndex = 1;
            // 
            // valuatorBindingSource
            // 
            this.valuatorBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.Valuator);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.trainingRequiredTextBox);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 393);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1112, 94);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "برنامه های آموزشی مورد نیاز";
            // 
            // trainingRequiredTextBox
            // 
            this.trainingRequiredTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performancEvaluationMasterBindingSource, "TrainingRequired", true));
            this.trainingRequiredTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trainingRequiredTextBox.Location = new System.Drawing.Point(3, 17);
            this.trainingRequiredTextBox.Multiline = true;
            this.trainingRequiredTextBox.Name = "trainingRequiredTextBox";
            this.trainingRequiredTextBox.Size = new System.Drawing.Size(1106, 74);
            this.trainingRequiredTextBox.TabIndex = 1;
            // 
            // AddPerformanceEvaluationDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 540);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddPerformanceEvaluationDialogForm";
            this.ShowIcon = false;
            this.Text = "ثبت جدید";
            this.Load += new System.EventHandler(this.AddPerformanceEvaluationDialogForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.evaluationStepBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performancEvaluationMasterBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.performancEvaluationDetailsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performancEvaluationDetailsBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valuatorBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button personnelListButton;
        private System.Windows.Forms.BindingSource performancEvaluationMasterBindingSource;
        private System.Windows.Forms.TextBox personnelIDTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox personnelNumbertextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox workStartTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DepartmenttextBox;
        private System.Windows.Forms.Label label3;
        private FarsiLibrary.Win.Controls.FADatePicker startDatePicker;
        private System.Windows.Forms.DataGridView performancEvaluationDetailsDataGridView;
        private System.Windows.Forms.BindingSource performancEvaluationDetailsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource valuatorBindingSource;
        private System.Windows.Forms.TextBox positiontextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox directorOfAdministrationTextBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox unitManagerTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn evalutionIndexIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox stepComboBox;
        private System.Windows.Forms.BindingSource evaluationStepBindingSource;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox trainingRequiredTextBox;
    }
}