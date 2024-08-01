namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    partial class PersonnelsListForAssignForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonnelsListForAssignForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.selectPersonnelsDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnelNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameEnDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatherNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internalTelDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selecedPersonnelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.topPanel = new System.Windows.Forms.Panel();
            this.clearControlsButton = new System.Windows.Forms.Button();
            this.imageListControl = new System.Windows.Forms.ImageList(this.components);
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.personnelNumberTextBox = new Jamsaz.PersonnlsApplication.Classes.NullableTextBox();
            this.personnelNumberLabel = new System.Windows.Forms.Label();
            this.middlePanel = new System.Windows.Forms.Panel();
            this.counterSelectedPersonnlesLabel = new System.Windows.Forms.Label();
            this.clearSelectionDataGrid = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.sourcePersonnelsDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnelNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameEnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internalTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourcePersonnelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectPersonnelsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selecedPersonnelsBindingSource)).BeginInit();
            this.topPanel.SuspendLayout();
            this.middlePanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourcePersonnelsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourcePersonnelsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.selectPersonnelsDataGridView, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.topPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.middlePanel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bottomPanel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.sourcePersonnelsDataGridView, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(771, 563);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // selectPersonnelsDataGridView
            // 
            this.selectPersonnelsDataGridView.AllowUserToAddRows = false;
            this.selectPersonnelsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.selectPersonnelsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.selectPersonnelsDataGridView.AutoGenerateColumns = false;
            this.selectPersonnelsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.selectPersonnelsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectPersonnelsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.personnelNumberDataGridViewTextBoxColumn1,
            this.firstNameDataGridViewTextBoxColumn1,
            this.lastNameDataGridViewTextBoxColumn1,
            this.fullNameEnDataGridViewTextBoxColumn1,
            this.issueNoDataGridViewTextBoxColumn1,
            this.fatherNameDataGridViewTextBoxColumn1,
            this.internalTelDataGridViewTextBoxColumn1});
            this.selectPersonnelsDataGridView.DataSource = this.selecedPersonnelsBindingSource;
            this.selectPersonnelsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectPersonnelsDataGridView.Location = new System.Drawing.Point(3, 327);
            this.selectPersonnelsDataGridView.MultiSelect = false;
            this.selectPersonnelsDataGridView.Name = "selectPersonnelsDataGridView";
            this.selectPersonnelsDataGridView.ReadOnly = true;
            this.selectPersonnelsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.selectPersonnelsDataGridView.Size = new System.Drawing.Size(765, 186);
            this.selectPersonnelsDataGridView.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // personnelNumberDataGridViewTextBoxColumn1
            // 
            this.personnelNumberDataGridViewTextBoxColumn1.DataPropertyName = "PersonnelNumber";
            this.personnelNumberDataGridViewTextBoxColumn1.FillWeight = 101F;
            this.personnelNumberDataGridViewTextBoxColumn1.HeaderText = "شماره پرسنلی";
            this.personnelNumberDataGridViewTextBoxColumn1.Name = "personnelNumberDataGridViewTextBoxColumn1";
            this.personnelNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            this.personnelNumberDataGridViewTextBoxColumn1.Width = 101;
            // 
            // firstNameDataGridViewTextBoxColumn1
            // 
            this.firstNameDataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.HeaderText = "نام";
            this.firstNameDataGridViewTextBoxColumn1.Name = "firstNameDataGridViewTextBoxColumn1";
            this.firstNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn1
            // 
            this.lastNameDataGridViewTextBoxColumn1.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.HeaderText = "نام خانوادگی";
            this.lastNameDataGridViewTextBoxColumn1.Name = "lastNameDataGridViewTextBoxColumn1";
            this.lastNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fullNameEnDataGridViewTextBoxColumn1
            // 
            this.fullNameEnDataGridViewTextBoxColumn1.DataPropertyName = "FullNameEn";
            this.fullNameEnDataGridViewTextBoxColumn1.HeaderText = "FullNameEn";
            this.fullNameEnDataGridViewTextBoxColumn1.Name = "fullNameEnDataGridViewTextBoxColumn1";
            this.fullNameEnDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fullNameEnDataGridViewTextBoxColumn1.Visible = false;
            // 
            // issueNoDataGridViewTextBoxColumn1
            // 
            this.issueNoDataGridViewTextBoxColumn1.DataPropertyName = "IssueNo";
            this.issueNoDataGridViewTextBoxColumn1.HeaderText = "ش.شناسنامه";
            this.issueNoDataGridViewTextBoxColumn1.Name = "issueNoDataGridViewTextBoxColumn1";
            this.issueNoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fatherNameDataGridViewTextBoxColumn1
            // 
            this.fatherNameDataGridViewTextBoxColumn1.DataPropertyName = "FatherName";
            this.fatherNameDataGridViewTextBoxColumn1.HeaderText = "نام پدر";
            this.fatherNameDataGridViewTextBoxColumn1.Name = "fatherNameDataGridViewTextBoxColumn1";
            this.fatherNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // internalTelDataGridViewTextBoxColumn1
            // 
            this.internalTelDataGridViewTextBoxColumn1.DataPropertyName = "InternalTel";
            this.internalTelDataGridViewTextBoxColumn1.HeaderText = "تلفن داخلی";
            this.internalTelDataGridViewTextBoxColumn1.Name = "internalTelDataGridViewTextBoxColumn1";
            this.internalTelDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // selecedPersonnelsBindingSource
            // 
            this.selecedPersonnelsBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.ResultSearchAdvenced);
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.clearControlsButton);
            this.topPanel.Controls.Add(this.firstNameLabel);
            this.topPanel.Controls.Add(this.firstNameTextBox);
            this.topPanel.Controls.Add(this.lastNameLabel);
            this.topPanel.Controls.Add(this.lastNameTextBox);
            this.topPanel.Controls.Add(this.searchButton);
            this.topPanel.Controls.Add(this.personnelNumberTextBox);
            this.topPanel.Controls.Add(this.personnelNumberLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topPanel.Location = new System.Drawing.Point(3, 3);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(765, 49);
            this.topPanel.TabIndex = 0;
            // 
            // clearControlsButton
            // 
            this.clearControlsButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearControlsButton.ImageIndex = 3;
            this.clearControlsButton.ImageList = this.imageListControl;
            this.clearControlsButton.Location = new System.Drawing.Point(9, 5);
            this.clearControlsButton.Name = "clearControlsButton";
            this.clearControlsButton.Size = new System.Drawing.Size(42, 26);
            this.clearControlsButton.TabIndex = 38;
            this.clearControlsButton.UseVisualStyleBackColor = true;
            this.clearControlsButton.Click += new System.EventHandler(this.clearControlsButton_Click);
            // 
            // imageListControl
            // 
            this.imageListControl.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListControl.ImageStream")));
            this.imageListControl.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListControl.Images.SetKeyName(0, "l_add.gif");
            this.imageListControl.Images.SetKeyName(1, "l_cancel.gif");
            this.imageListControl.Images.SetKeyName(2, "l_filesearch.gif");
            this.imageListControl.Images.SetKeyName(3, "is_halfcmtbad.gif");
            this.imageListControl.Images.SetKeyName(4, "l_clear.gif");
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(492, 13);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(20, 13);
            this.firstNameLabel.TabIndex = 6;
            this.firstNameLabel.Text = "نام";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameTextBox.Location = new System.Drawing.Point(358, 9);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(128, 21);
            this.firstNameTextBox.TabIndex = 5;
            this.firstNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.personnelNumberTextBox_KeyPress);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(290, 12);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(65, 13);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "نام خانوادگی";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameTextBox.Location = new System.Drawing.Point(156, 7);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(128, 21);
            this.lastNameTextBox.TabIndex = 3;
            this.lastNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.personnelNumberTextBox_KeyPress);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchButton.ImageIndex = 2;
            this.searchButton.ImageList = this.imageListControl;
            this.searchButton.Location = new System.Drawing.Point(57, 7);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(91, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "جستجو";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // personnelNumberTextBox
            // 
            this.personnelNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.personnelNumberTextBox.IsNumeric = true;
            this.personnelNumberTextBox.Location = new System.Drawing.Point(534, 9);
            this.personnelNumberTextBox.Name = "personnelNumberTextBox";
            this.personnelNumberTextBox.NullableText = null;
            this.personnelNumberTextBox.Size = new System.Drawing.Size(127, 21);
            this.personnelNumberTextBox.TabIndex = 1;
            this.personnelNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.personnelNumberTextBox_KeyPress);
            // 
            // personnelNumberLabel
            // 
            this.personnelNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.personnelNumberLabel.AutoSize = true;
            this.personnelNumberLabel.Location = new System.Drawing.Point(667, 14);
            this.personnelNumberLabel.Name = "personnelNumberLabel";
            this.personnelNumberLabel.Size = new System.Drawing.Size(78, 13);
            this.personnelNumberLabel.TabIndex = 0;
            this.personnelNumberLabel.Text = "شماره پرسنلی";
            // 
            // middlePanel
            // 
            this.middlePanel.Controls.Add(this.counterSelectedPersonnlesLabel);
            this.middlePanel.Controls.Add(this.clearSelectionDataGrid);
            this.middlePanel.Controls.Add(this.insertButton);
            this.middlePanel.Controls.Add(this.returnButton);
            this.middlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middlePanel.Location = new System.Drawing.Point(3, 266);
            this.middlePanel.Name = "middlePanel";
            this.middlePanel.Size = new System.Drawing.Size(765, 55);
            this.middlePanel.TabIndex = 1;
            // 
            // counterSelectedPersonnlesLabel
            // 
            this.counterSelectedPersonnlesLabel.AutoSize = true;
            this.counterSelectedPersonnlesLabel.Location = new System.Drawing.Point(659, 21);
            this.counterSelectedPersonnlesLabel.Name = "counterSelectedPersonnlesLabel";
            this.counterSelectedPersonnlesLabel.Size = new System.Drawing.Size(91, 13);
            this.counterSelectedPersonnlesLabel.TabIndex = 6;
            this.counterSelectedPersonnlesLabel.Text = "تعداد انتخاب شده:";
            // 
            // clearSelectionDataGrid
            // 
            this.clearSelectionDataGrid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearSelectionDataGrid.ImageIndex = 4;
            this.clearSelectionDataGrid.ImageList = this.imageListControl;
            this.clearSelectionDataGrid.Location = new System.Drawing.Point(18, 14);
            this.clearSelectionDataGrid.Name = "clearSelectionDataGrid";
            this.clearSelectionDataGrid.Size = new System.Drawing.Size(27, 27);
            this.clearSelectionDataGrid.TabIndex = 5;
            this.clearSelectionDataGrid.UseVisualStyleBackColor = true;
            this.clearSelectionDataGrid.Click += new System.EventHandler(this.clearSelectionDataGrid_Click);
            // 
            // insertButton
            // 
            this.insertButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.arrow_down;
            this.insertButton.Location = new System.Drawing.Point(354, 14);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 27);
            this.insertButton.TabIndex = 4;
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.arrow_up;
            this.returnButton.Location = new System.Drawing.Point(435, 14);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 27);
            this.returnButton.TabIndex = 3;
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.cancelButton);
            this.bottomPanel.Controls.Add(this.saveButton);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomPanel.Location = new System.Drawing.Point(3, 519);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(765, 41);
            this.bottomPanel.TabIndex = 2;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelButton.ImageIndex = 1;
            this.cancelButton.ImageList = this.imageListControl;
            this.cancelButton.Location = new System.Drawing.Point(563, 9);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(90, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "لغو";
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click_1);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveButton.ImageIndex = 0;
            this.saveButton.ImageList = this.imageListControl;
            this.saveButton.Location = new System.Drawing.Point(659, 9);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(91, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "ذخيره";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // sourcePersonnelsDataGridView
            // 
            this.sourcePersonnelsDataGridView.AllowUserToAddRows = false;
            this.sourcePersonnelsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.sourcePersonnelsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.sourcePersonnelsDataGridView.AutoGenerateColumns = false;
            this.sourcePersonnelsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.sourcePersonnelsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sourcePersonnelsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.personnelNumberDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.fullNameEnDataGridViewTextBoxColumn,
            this.issueNoDataGridViewTextBoxColumn,
            this.fatherNameDataGridViewTextBoxColumn,
            this.internalTelDataGridViewTextBoxColumn});
            this.sourcePersonnelsDataGridView.DataSource = this.sourcePersonnelsBindingSource;
            this.sourcePersonnelsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourcePersonnelsDataGridView.Location = new System.Drawing.Point(3, 58);
            this.sourcePersonnelsDataGridView.MultiSelect = false;
            this.sourcePersonnelsDataGridView.Name = "sourcePersonnelsDataGridView";
            this.sourcePersonnelsDataGridView.ReadOnly = true;
            this.sourcePersonnelsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sourcePersonnelsDataGridView.Size = new System.Drawing.Size(765, 202);
            this.sourcePersonnelsDataGridView.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // personnelNumberDataGridViewTextBoxColumn
            // 
            this.personnelNumberDataGridViewTextBoxColumn.DataPropertyName = "PersonnelNumber";
            this.personnelNumberDataGridViewTextBoxColumn.FillWeight = 101F;
            this.personnelNumberDataGridViewTextBoxColumn.HeaderText = "شماره پرسنلی";
            this.personnelNumberDataGridViewTextBoxColumn.Name = "personnelNumberDataGridViewTextBoxColumn";
            this.personnelNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.personnelNumberDataGridViewTextBoxColumn.Width = 101;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "نام";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "خانوادگی";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameEnDataGridViewTextBoxColumn
            // 
            this.fullNameEnDataGridViewTextBoxColumn.DataPropertyName = "FullNameEn";
            this.fullNameEnDataGridViewTextBoxColumn.HeaderText = "FullNameEn";
            this.fullNameEnDataGridViewTextBoxColumn.Name = "fullNameEnDataGridViewTextBoxColumn";
            this.fullNameEnDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullNameEnDataGridViewTextBoxColumn.Visible = false;
            // 
            // issueNoDataGridViewTextBoxColumn
            // 
            this.issueNoDataGridViewTextBoxColumn.DataPropertyName = "IssueNo";
            this.issueNoDataGridViewTextBoxColumn.HeaderText = "ش.شناسنامه";
            this.issueNoDataGridViewTextBoxColumn.Name = "issueNoDataGridViewTextBoxColumn";
            this.issueNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fatherNameDataGridViewTextBoxColumn
            // 
            this.fatherNameDataGridViewTextBoxColumn.DataPropertyName = "FatherName";
            this.fatherNameDataGridViewTextBoxColumn.HeaderText = "نام پدر";
            this.fatherNameDataGridViewTextBoxColumn.Name = "fatherNameDataGridViewTextBoxColumn";
            this.fatherNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // internalTelDataGridViewTextBoxColumn
            // 
            this.internalTelDataGridViewTextBoxColumn.DataPropertyName = "InternalTel";
            this.internalTelDataGridViewTextBoxColumn.HeaderText = "تلفن داخلی";
            this.internalTelDataGridViewTextBoxColumn.Name = "internalTelDataGridViewTextBoxColumn";
            this.internalTelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sourcePersonnelsBindingSource
            // 
            this.sourcePersonnelsBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.ResultSearchAdvenced);
            // 
            // PersonnelsListForAssignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(771, 563);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonnelsListForAssignForm";
            this.Text = "انتخاب پرسنل برای تخصیص";
            this.Load += new System.EventHandler(this.PersonnelsListForAssignForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.selectPersonnelsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selecedPersonnelsBindingSource)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.middlePanel.ResumeLayout(false);
            this.middlePanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sourcePersonnelsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourcePersonnelsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel middlePanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Label personnelNumberLabel;
        private Jamsaz.PersonnlsApplication.Classes.NullableTextBox personnelNumberTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView sourcePersonnelsDataGridView;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.BindingSource sourcePersonnelsBindingSource;
        private System.Windows.Forms.BindingSource selecedPersonnelsBindingSource;
        private System.Windows.Forms.Button clearSelectionDataGrid;
        private System.Windows.Forms.ImageList imageListControl;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label counterSelectedPersonnlesLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.DataGridView selectPersonnelsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnelNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameEnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internalTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnelNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameEnDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueNoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatherNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn internalTelDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button clearControlsButton;
    }
}