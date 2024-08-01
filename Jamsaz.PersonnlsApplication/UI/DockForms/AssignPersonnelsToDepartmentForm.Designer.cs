namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    partial class AssignPersonnelsToDepartmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignPersonnelsToDepartmentForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.activeDepartmentVersionLabel = new System.Windows.Forms.Label();
            this.departmentVersionComboBox = new System.Windows.Forms.ComboBox();
            this.departmentVersionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectDepartmentversionButton = new System.Windows.Forms.Button();
            this.imageListControls = new System.Windows.Forms.ImageList(this.components);
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.selectDepartmentVersionLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.departmentTreeView = new System.Windows.Forms.TreeView();
            this.imageListTree = new System.Windows.Forms.ImageList(this.components);
            this.allAssignDepartmentForCurrentPersonnleGroupBox = new System.Windows.Forms.GroupBox();
            this.allAssignDepartmentForCurrentPersonnleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentVersionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentVersionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allAssignDepartmentForCurrentPersonnleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentPersonnelGroupBox = new System.Windows.Forms.GroupBox();
            this.setActiveDepartmentButton = new System.Windows.Forms.Button();
            this.personnelFromToCurrentDepartmentDataGridView = new System.Windows.Forms.DataGridView();
            this.departmentPersonnelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deletePersonnelFromCurrentDepartmentButton = new System.Windows.Forms.Button();
            this.assignPersonnelsButton = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonnelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentVersionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.allAssignDepartmentForCurrentPersonnleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allAssignDepartmentForCurrentPersonnleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allAssignDepartmentForCurrentPersonnleBindingSource)).BeginInit();
            this.departmentPersonnelGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personnelFromToCurrentDepartmentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentPersonnelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelTop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mainSplitContainer, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.33447F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.66553F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 643);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.groupBox1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(3, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(994, 78);
            this.panelTop.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.activeDepartmentVersionLabel);
            this.groupBox1.Controls.Add(this.departmentVersionComboBox);
            this.groupBox1.Controls.Add(this.selectDepartmentversionButton);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.selectDepartmentVersionLabel);
            this.groupBox1.Controls.Add(this.SearchButton);
            this.groupBox1.Controls.Add(this.nextButton);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Location = new System.Drawing.Point(273, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 70);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // activeDepartmentVersionLabel
            // 
            this.activeDepartmentVersionLabel.AutoSize = true;
            this.activeDepartmentVersionLabel.BackColor = System.Drawing.Color.SandyBrown;
            this.activeDepartmentVersionLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.activeDepartmentVersionLabel.ForeColor = System.Drawing.Color.Black;
            this.activeDepartmentVersionLabel.Location = new System.Drawing.Point(172, 43);
            this.activeDepartmentVersionLabel.Name = "activeDepartmentVersionLabel";
            this.activeDepartmentVersionLabel.Size = new System.Drawing.Size(224, 14);
            this.activeDepartmentVersionLabel.TabIndex = 27;
            this.activeDepartmentVersionLabel.Text = "این نسخه , نسخه فعال سیستم می باشد";
            this.activeDepartmentVersionLabel.Visible = false;
            // 
            // departmentVersionComboBox
            // 
            this.departmentVersionComboBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.departmentVersionComboBox.DataSource = this.departmentVersionBindingSource;
            this.departmentVersionComboBox.DisplayMember = "Code";
            this.departmentVersionComboBox.FormattingEnabled = true;
            this.departmentVersionComboBox.Location = new System.Drawing.Point(491, 40);
            this.departmentVersionComboBox.Name = "departmentVersionComboBox";
            this.departmentVersionComboBox.Size = new System.Drawing.Size(115, 21);
            this.departmentVersionComboBox.TabIndex = 24;
            this.departmentVersionComboBox.ValueMember = "ID";
            this.departmentVersionComboBox.SelectedIndexChanged += new System.EventHandler(this.departmentVersionComboBox_SelectedIndexChanged);
            // 
            // departmentVersionBindingSource
            // 
            this.departmentVersionBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.DepartmentVersion);
            // 
            // selectDepartmentversionButton
            // 
            this.selectDepartmentversionButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.selectDepartmentversionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.selectDepartmentversionButton.ImageList = this.imageListControls;
            this.selectDepartmentversionButton.Location = new System.Drawing.Point(402, 40);
            this.selectDepartmentversionButton.Name = "selectDepartmentversionButton";
            this.selectDepartmentversionButton.Size = new System.Drawing.Size(83, 21);
            this.selectDepartmentversionButton.TabIndex = 26;
            this.selectDepartmentversionButton.Text = "انتخاب نسخه";
            this.selectDepartmentversionButton.UseVisualStyleBackColor = true;
            this.selectDepartmentversionButton.Click += new System.EventHandler(this.selectDepartmentversionButton_Click);
            // 
            // imageListControls
            // 
            this.imageListControls.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListControls.ImageStream")));
            this.imageListControls.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListControls.Images.SetKeyName(0, "arrow_up.gif");
            this.imageListControls.Images.SetKeyName(1, "l_add.gif");
            this.imageListControls.Images.SetKeyName(2, "l_none.gif");
            this.imageListControls.Images.SetKeyName(3, "l_clear.gif");
            this.imageListControls.Images.SetKeyName(4, "l_filesearch.gif");
            this.imageListControls.Images.SetKeyName(5, "t_uploading.gif");
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nameTextBox.Location = new System.Drawing.Point(403, 14);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(204, 21);
            this.nameTextBox.TabIndex = 0;
            // 
            // selectDepartmentVersionLabel
            // 
            this.selectDepartmentVersionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.selectDepartmentVersionLabel.AutoSize = true;
            this.selectDepartmentVersionLabel.Location = new System.Drawing.Point(611, 46);
            this.selectDepartmentVersionLabel.Name = "selectDepartmentVersionLabel";
            this.selectDepartmentVersionLabel.Size = new System.Drawing.Size(67, 13);
            this.selectDepartmentVersionLabel.TabIndex = 25;
            this.selectDepartmentVersionLabel.Text = "انتخاب نسخه";
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchButton.ImageIndex = 4;
            this.SearchButton.ImageList = this.imageListControls;
            this.SearchButton.Location = new System.Drawing.Point(314, 13);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(84, 21);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "جستجو";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nextButton.Enabled = false;
            this.nextButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nextButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nextButton.ImageIndex = 5;
            this.nextButton.ImageList = this.imageListControls;
            this.nextButton.Location = new System.Drawing.Point(225, 13);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(84, 21);
            this.nextButton.TabIndex = 22;
            this.nextButton.Text = "بعدي";
            this.nextButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(611, 17);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(99, 13);
            this.nameLabel.TabIndex = 23;
            this.nameLabel.Text = "جستجو براساس نام";
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(3, 87);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.departmentTreeView);
            this.mainSplitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.allAssignDepartmentForCurrentPersonnleGroupBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.departmentPersonnelGroupBox);
            this.mainSplitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mainSplitContainer.Size = new System.Drawing.Size(994, 496);
            this.mainSplitContainer.SplitterDistance = 450;
            this.mainSplitContainer.TabIndex = 0;
            // 
            // departmentTreeView
            // 
            this.departmentTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.departmentTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departmentTreeView.FullRowSelect = true;
            this.departmentTreeView.HideSelection = false;
            this.departmentTreeView.HotTracking = true;
            this.departmentTreeView.ImageIndex = 5;
            this.departmentTreeView.ImageList = this.imageListTree;
            this.departmentTreeView.Location = new System.Drawing.Point(0, 0);
            this.departmentTreeView.Name = "departmentTreeView";
            this.departmentTreeView.RightToLeftLayout = true;
            this.departmentTreeView.SelectedImageIndex = 4;
            this.departmentTreeView.Size = new System.Drawing.Size(450, 496);
            this.departmentTreeView.TabIndex = 1;
            this.departmentTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.departmentTreeView_AfterSelect);
            // 
            // imageListTree
            // 
            this.imageListTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTree.ImageStream")));
            this.imageListTree.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTree.Images.SetKeyName(0, "group.png");
            this.imageListTree.Images.SetKeyName(1, "shape.png");
            this.imageListTree.Images.SetKeyName(2, "switch.png");
            this.imageListTree.Images.SetKeyName(3, "help_w.gif");
            this.imageListTree.Images.SetKeyName(4, "suche.gif");
            this.imageListTree.Images.SetKeyName(5, "l_stop.gif");
            this.imageListTree.Images.SetKeyName(6, "l_static.gif");
            this.imageListTree.Images.SetKeyName(7, "home.gif");
            // 
            // allAssignDepartmentForCurrentPersonnleGroupBox
            // 
            this.allAssignDepartmentForCurrentPersonnleGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allAssignDepartmentForCurrentPersonnleGroupBox.Controls.Add(this.allAssignDepartmentForCurrentPersonnleDataGridView);
            this.allAssignDepartmentForCurrentPersonnleGroupBox.Location = new System.Drawing.Point(9, 298);
            this.allAssignDepartmentForCurrentPersonnleGroupBox.Name = "allAssignDepartmentForCurrentPersonnleGroupBox";
            this.allAssignDepartmentForCurrentPersonnleGroupBox.Size = new System.Drawing.Size(518, 178);
            this.allAssignDepartmentForCurrentPersonnleGroupBox.TabIndex = 4;
            this.allAssignDepartmentForCurrentPersonnleGroupBox.TabStop = false;
            this.allAssignDepartmentForCurrentPersonnleGroupBox.Text = "تمام بخش های که پرسنل در آن مشغول به کار بوده ";
            // 
            // allAssignDepartmentForCurrentPersonnleDataGridView
            // 
            this.allAssignDepartmentForCurrentPersonnleDataGridView.AllowUserToAddRows = false;
            this.allAssignDepartmentForCurrentPersonnleDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.allAssignDepartmentForCurrentPersonnleDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.allAssignDepartmentForCurrentPersonnleDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allAssignDepartmentForCurrentPersonnleDataGridView.AutoGenerateColumns = false;
            this.allAssignDepartmentForCurrentPersonnleDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.allAssignDepartmentForCurrentPersonnleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allAssignDepartmentForCurrentPersonnleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.DepartmentName,
            this.DepartmentVersionName,
            this.DepartmentVersionDate});
            this.allAssignDepartmentForCurrentPersonnleDataGridView.DataSource = this.allAssignDepartmentForCurrentPersonnleBindingSource;
            this.allAssignDepartmentForCurrentPersonnleDataGridView.Location = new System.Drawing.Point(6, 20);
            this.allAssignDepartmentForCurrentPersonnleDataGridView.Name = "allAssignDepartmentForCurrentPersonnleDataGridView";
            this.allAssignDepartmentForCurrentPersonnleDataGridView.ReadOnly = true;
            this.allAssignDepartmentForCurrentPersonnleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allAssignDepartmentForCurrentPersonnleDataGridView.Size = new System.Drawing.Size(506, 137);
            this.allAssignDepartmentForCurrentPersonnleDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PersonnelName";
            this.dataGridViewTextBoxColumn2.FillWeight = 140F;
            this.dataGridViewTextBoxColumn2.HeaderText = "نام پرسنل";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 140;
            // 
            // DepartmentName
            // 
            this.DepartmentName.DataPropertyName = "DepartmentName";
            this.DepartmentName.FillWeight = 120F;
            this.DepartmentName.HeaderText = "نام بخش";
            this.DepartmentName.Name = "DepartmentName";
            this.DepartmentName.ReadOnly = true;
            this.DepartmentName.Width = 120;
            // 
            // DepartmentVersionName
            // 
            this.DepartmentVersionName.DataPropertyName = "DepartmentVersionName";
            this.DepartmentVersionName.FillWeight = 60F;
            this.DepartmentVersionName.HeaderText = "نسخه";
            this.DepartmentVersionName.Name = "DepartmentVersionName";
            this.DepartmentVersionName.ReadOnly = true;
            this.DepartmentVersionName.Width = 60;
            // 
            // DepartmentVersionDate
            // 
            this.DepartmentVersionDate.DataPropertyName = "DepartmentVersionDate";
            this.DepartmentVersionDate.FillWeight = 125F;
            this.DepartmentVersionDate.HeaderText = "تاریخ نسخه یا فعالیت";
            this.DepartmentVersionDate.Name = "DepartmentVersionDate";
            this.DepartmentVersionDate.ReadOnly = true;
            this.DepartmentVersionDate.Width = 125;
            // 
            // allAssignDepartmentForCurrentPersonnleBindingSource
            // 
            this.allAssignDepartmentForCurrentPersonnleBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.DepartmentPersonnel);
            // 
            // departmentPersonnelGroupBox
            // 
            this.departmentPersonnelGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentPersonnelGroupBox.Controls.Add(this.setActiveDepartmentButton);
            this.departmentPersonnelGroupBox.Controls.Add(this.personnelFromToCurrentDepartmentDataGridView);
            this.departmentPersonnelGroupBox.Controls.Add(this.deletePersonnelFromCurrentDepartmentButton);
            this.departmentPersonnelGroupBox.Controls.Add(this.assignPersonnelsButton);
            this.departmentPersonnelGroupBox.Location = new System.Drawing.Point(9, -2);
            this.departmentPersonnelGroupBox.Name = "departmentPersonnelGroupBox";
            this.departmentPersonnelGroupBox.Size = new System.Drawing.Size(518, 285);
            this.departmentPersonnelGroupBox.TabIndex = 3;
            this.departmentPersonnelGroupBox.TabStop = false;
            this.departmentPersonnelGroupBox.Text = "پرسنل مربوط به بخش جاری";
            // 
            // setActiveDepartmentButton
            // 
            this.setActiveDepartmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.setActiveDepartmentButton.Location = new System.Drawing.Point(294, 256);
            this.setActiveDepartmentButton.Name = "setActiveDepartmentButton";
            this.setActiveDepartmentButton.Size = new System.Drawing.Size(106, 23);
            this.setActiveDepartmentButton.TabIndex = 3;
            this.setActiveDepartmentButton.Text = "تعیین بخش فعال";
            this.setActiveDepartmentButton.UseVisualStyleBackColor = true;
            this.setActiveDepartmentButton.Click += new System.EventHandler(this.setActiveDepartmentButton_Click);
            // 
            // personnelFromToCurrentDepartmentDataGridView
            // 
            this.personnelFromToCurrentDepartmentDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.personnelFromToCurrentDepartmentDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.personnelFromToCurrentDepartmentDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.personnelFromToCurrentDepartmentDataGridView.AutoGenerateColumns = false;
            this.personnelFromToCurrentDepartmentDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.personnelFromToCurrentDepartmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personnelFromToCurrentDepartmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.PersonnelName,
            this.personnelIDDataGridViewTextBoxColumn,
            this.departmentIDDataGridViewTextBoxColumn,
            this.isActiveDepartmentDataGridViewTextBoxColumn});
            this.personnelFromToCurrentDepartmentDataGridView.DataSource = this.departmentPersonnelBindingSource;
            this.personnelFromToCurrentDepartmentDataGridView.Location = new System.Drawing.Point(6, 20);
            this.personnelFromToCurrentDepartmentDataGridView.Name = "personnelFromToCurrentDepartmentDataGridView";
            this.personnelFromToCurrentDepartmentDataGridView.ReadOnly = true;
            this.personnelFromToCurrentDepartmentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.personnelFromToCurrentDepartmentDataGridView.Size = new System.Drawing.Size(506, 230);
            this.personnelFromToCurrentDepartmentDataGridView.TabIndex = 0;
            // 
            // departmentPersonnelBindingSource
            // 
            this.departmentPersonnelBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.DepartmentPersonnel);
            this.departmentPersonnelBindingSource.CurrentChanged += new System.EventHandler(this.departmentPersonnelBindingSource_CurrentChanged);
            this.departmentPersonnelBindingSource.PositionChanged += new System.EventHandler(this.departmentPersonnelBindingSource_PositionChanged);
            // 
            // deletePersonnelFromCurrentDepartmentButton
            // 
            this.deletePersonnelFromCurrentDepartmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deletePersonnelFromCurrentDepartmentButton.Location = new System.Drawing.Point(162, 256);
            this.deletePersonnelFromCurrentDepartmentButton.Name = "deletePersonnelFromCurrentDepartmentButton";
            this.deletePersonnelFromCurrentDepartmentButton.Size = new System.Drawing.Size(126, 23);
            this.deletePersonnelFromCurrentDepartmentButton.TabIndex = 2;
            this.deletePersonnelFromCurrentDepartmentButton.Text = "حذف از بخش جاری";
            this.deletePersonnelFromCurrentDepartmentButton.UseVisualStyleBackColor = true;
            this.deletePersonnelFromCurrentDepartmentButton.Click += new System.EventHandler(this.deletePersonnelFromCurrentDepartmentButton_Click);
            // 
            // assignPersonnelsButton
            // 
            this.assignPersonnelsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.assignPersonnelsButton.Location = new System.Drawing.Point(406, 256);
            this.assignPersonnelsButton.Name = "assignPersonnelsButton";
            this.assignPersonnelsButton.Size = new System.Drawing.Size(106, 23);
            this.assignPersonnelsButton.TabIndex = 1;
            this.assignPersonnelsButton.Text = "تخصیص پرسنل";
            this.assignPersonnelsButton.UseVisualStyleBackColor = true;
            this.assignPersonnelsButton.Click += new System.EventHandler(this.assignPersonnelsButton_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // PersonnelName
            // 
            this.PersonnelName.DataPropertyName = "PersonnelName";
            this.PersonnelName.HeaderText = "نام پرسنل";
            this.PersonnelName.Name = "PersonnelName";
            this.PersonnelName.ReadOnly = true;
            // 
            // personnelIDDataGridViewTextBoxColumn
            // 
            this.personnelIDDataGridViewTextBoxColumn.DataPropertyName = "PersonnelID";
            this.personnelIDDataGridViewTextBoxColumn.HeaderText = "PersonnelID";
            this.personnelIDDataGridViewTextBoxColumn.Name = "personnelIDDataGridViewTextBoxColumn";
            this.personnelIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.personnelIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // departmentIDDataGridViewTextBoxColumn
            // 
            this.departmentIDDataGridViewTextBoxColumn.DataPropertyName = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.HeaderText = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.Name = "departmentIDDataGridViewTextBoxColumn";
            this.departmentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.departmentIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // isActiveDepartmentDataGridViewTextBoxColumn
            // 
            this.isActiveDepartmentDataGridViewTextBoxColumn.DataPropertyName = "IsActiveDepartment";
            this.isActiveDepartmentDataGridViewTextBoxColumn.FillWeight = 105F;
            this.isActiveDepartmentDataGridViewTextBoxColumn.HeaderText = "وضعیت";
            this.isActiveDepartmentDataGridViewTextBoxColumn.Name = "isActiveDepartmentDataGridViewTextBoxColumn";
            this.isActiveDepartmentDataGridViewTextBoxColumn.ReadOnly = true;
            this.isActiveDepartmentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isActiveDepartmentDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isActiveDepartmentDataGridViewTextBoxColumn.Width = 105;
            // 
            // AssignPersonnelsToDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1000, 643);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AssignPersonnelsToDepartmentForm";
            this.Text = "تخصیص پرسنل برای هر بخش ";
            this.Load += new System.EventHandler(this.AssignPersonnelsToDepartmentForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentVersionBindingSource)).EndInit();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.allAssignDepartmentForCurrentPersonnleGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.allAssignDepartmentForCurrentPersonnleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allAssignDepartmentForCurrentPersonnleBindingSource)).EndInit();
            this.departmentPersonnelGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personnelFromToCurrentDepartmentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentPersonnelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.DataGridView personnelFromToCurrentDepartmentDataGridView;
        private System.Windows.Forms.BindingSource departmentPersonnelBindingSource;
        private System.Windows.Forms.ImageList imageListControls;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox departmentVersionComboBox;
        private System.Windows.Forms.Button selectDepartmentversionButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label selectDepartmentVersionLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.BindingSource departmentVersionBindingSource;
        private System.Windows.Forms.TreeView departmentTreeView;
        private System.Windows.Forms.ImageList imageListTree;
        private System.Windows.Forms.Button deletePersonnelFromCurrentDepartmentButton;
        private System.Windows.Forms.Button assignPersonnelsButton;
        private System.Windows.Forms.GroupBox departmentPersonnelGroupBox;
        private System.Windows.Forms.GroupBox allAssignDepartmentForCurrentPersonnleGroupBox;
        private System.Windows.Forms.DataGridView allAssignDepartmentForCurrentPersonnleDataGridView;
        private System.Windows.Forms.BindingSource allAssignDepartmentForCurrentPersonnleBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentVersionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentVersionDate;
        private System.Windows.Forms.Label activeDepartmentVersionLabel;
        private System.Windows.Forms.Button setActiveDepartmentButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonnelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDepartmentDataGridViewTextBoxColumn;
    }
}