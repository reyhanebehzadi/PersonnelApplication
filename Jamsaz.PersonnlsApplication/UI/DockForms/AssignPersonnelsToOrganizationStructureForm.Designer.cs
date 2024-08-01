namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    partial class AssignPersonnelsToOrganizationStructureForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignPersonnelsToOrganizationStructureForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.activeOrganizationStructureVersionLabel = new System.Windows.Forms.Label();
            this.organizationStructureVersionComboBox = new System.Windows.Forms.ComboBox();
            this.organizationStructureVersionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectOrganizationStructureVersionButton = new System.Windows.Forms.Button();
            this.imageListControls = new System.Windows.Forms.ImageList(this.components);
            this.selectDepartmentVersionLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rolesStructureTreeView = new System.Windows.Forms.TreeView();
            this.imageListTree = new System.Windows.Forms.ImageList(this.components);
            this.allAssignDepartmentForCurrentPersonnleGroupBox = new System.Windows.Forms.GroupBox();
            this.allAssignDepartmentForCurrentPersonnleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentVersionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentVersionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allAssignOrganisationStructureForCurrentPersonnleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolsGroupBox = new System.Windows.Forms.GroupBox();
            this.setMainPositionButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addPersonnelTocurrentRolButton = new System.Windows.Forms.Button();
            this.gridRolsGroupBox = new System.Windows.Forms.GroupBox();
            this.assignPersonnelsDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonnelNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnelIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organisationStructureIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isMainPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organizationStructureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsMainPositionValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organisationStructurePersonnelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.organizationStructureVersionBindingSource)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.allAssignDepartmentForCurrentPersonnleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allAssignDepartmentForCurrentPersonnleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allAssignOrganisationStructureForCurrentPersonnleBindingSource)).BeginInit();
            this.toolsGroupBox.SuspendLayout();
            this.gridRolsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assignPersonnelsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organisationStructurePersonnelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelTop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 643);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.groupBox1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(3, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(994, 84);
            this.panelTop.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.activeOrganizationStructureVersionLabel);
            this.groupBox1.Controls.Add(this.organizationStructureVersionComboBox);
            this.groupBox1.Controls.Add(this.selectOrganizationStructureVersionButton);
            this.groupBox1.Controls.Add(this.selectDepartmentVersionLabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.SearchButton);
            this.groupBox1.Controls.Add(this.nextButton);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Location = new System.Drawing.Point(273, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 73);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // activeOrganizationStructureVersionLabel
            // 
            this.activeOrganizationStructureVersionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.activeOrganizationStructureVersionLabel.AutoSize = true;
            this.activeOrganizationStructureVersionLabel.BackColor = System.Drawing.Color.SandyBrown;
            this.activeOrganizationStructureVersionLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.activeOrganizationStructureVersionLabel.ForeColor = System.Drawing.Color.Black;
            this.activeOrganizationStructureVersionLabel.Location = new System.Drawing.Point(171, 51);
            this.activeOrganizationStructureVersionLabel.Name = "activeOrganizationStructureVersionLabel";
            this.activeOrganizationStructureVersionLabel.Size = new System.Drawing.Size(224, 14);
            this.activeOrganizationStructureVersionLabel.TabIndex = 31;
            this.activeOrganizationStructureVersionLabel.Text = "این نسخه , نسخه فعال سیستم می باشد";
            this.activeOrganizationStructureVersionLabel.Visible = false;
            // 
            // organizationStructureVersionComboBox
            // 
            this.organizationStructureVersionComboBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.organizationStructureVersionComboBox.DataSource = this.organizationStructureVersionBindingSource;
            this.organizationStructureVersionComboBox.DisplayMember = "Code";
            this.organizationStructureVersionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.organizationStructureVersionComboBox.FormattingEnabled = true;
            this.organizationStructureVersionComboBox.Location = new System.Drawing.Point(490, 47);
            this.organizationStructureVersionComboBox.Name = "organizationStructureVersionComboBox";
            this.organizationStructureVersionComboBox.Size = new System.Drawing.Size(115, 21);
            this.organizationStructureVersionComboBox.TabIndex = 28;
            this.organizationStructureVersionComboBox.ValueMember = "ID";
            this.organizationStructureVersionComboBox.SelectedIndexChanged += new System.EventHandler(this.organizationStructureVersionComboBox_SelectedIndexChanged);
            // 
            // organizationStructureVersionBindingSource
            // 
            this.organizationStructureVersionBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.OrganizationStructureVersion);
            // 
            // selectOrganizationStructureVersionButton
            // 
            this.selectOrganizationStructureVersionButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.selectOrganizationStructureVersionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.selectOrganizationStructureVersionButton.ImageList = this.imageListControls;
            this.selectOrganizationStructureVersionButton.Location = new System.Drawing.Point(401, 47);
            this.selectOrganizationStructureVersionButton.Name = "selectOrganizationStructureVersionButton";
            this.selectOrganizationStructureVersionButton.Size = new System.Drawing.Size(83, 21);
            this.selectOrganizationStructureVersionButton.TabIndex = 30;
            this.selectOrganizationStructureVersionButton.Text = "انتخاب نسخه";
            this.selectOrganizationStructureVersionButton.UseVisualStyleBackColor = true;
            this.selectOrganizationStructureVersionButton.Click += new System.EventHandler(this.selectOrganizationStructureVersionButton_Click);
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
            // selectDepartmentVersionLabel
            // 
            this.selectDepartmentVersionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.selectDepartmentVersionLabel.AutoSize = true;
            this.selectDepartmentVersionLabel.Location = new System.Drawing.Point(610, 53);
            this.selectDepartmentVersionLabel.Name = "selectDepartmentVersionLabel";
            this.selectDepartmentVersionLabel.Size = new System.Drawing.Size(67, 13);
            this.selectDepartmentVersionLabel.TabIndex = 29;
            this.selectDepartmentVersionLabel.Text = "انتخاب نسخه";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nameTextBox.Location = new System.Drawing.Point(401, 11);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(204, 21);
            this.nameTextBox.TabIndex = 0;
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchButton.ImageIndex = 4;
            this.SearchButton.ImageList = this.imageListControls;
            this.SearchButton.Location = new System.Drawing.Point(312, 10);
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
            this.nextButton.Location = new System.Drawing.Point(223, 10);
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
            this.nameLabel.Location = new System.Drawing.Point(609, 14);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(99, 13);
            this.nameLabel.TabIndex = 23;
            this.nameLabel.Text = "جستجو براساس نام";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 93);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rolesStructureTreeView);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.allAssignDepartmentForCurrentPersonnleGroupBox);
            this.splitContainer1.Panel2.Controls.Add(this.toolsGroupBox);
            this.splitContainer1.Panel2.Controls.Add(this.gridRolsGroupBox);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(994, 476);
            this.splitContainer1.SplitterDistance = 453;
            this.splitContainer1.TabIndex = 4;
            // 
            // rolesStructureTreeView
            // 
            this.rolesStructureTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.rolesStructureTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rolesStructureTreeView.FullRowSelect = true;
            this.rolesStructureTreeView.HideSelection = false;
            this.rolesStructureTreeView.ImageIndex = 0;
            this.rolesStructureTreeView.ImageList = this.imageListTree;
            this.rolesStructureTreeView.Location = new System.Drawing.Point(0, 0);
            this.rolesStructureTreeView.Name = "rolesStructureTreeView";
            this.rolesStructureTreeView.RightToLeftLayout = true;
            this.rolesStructureTreeView.SelectedImageIndex = 5;
            this.rolesStructureTreeView.Size = new System.Drawing.Size(453, 476);
            this.rolesStructureTreeView.TabIndex = 4;
            this.rolesStructureTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.rolesStructureTreeView_AfterSelect);
            // 
            // imageListTree
            // 
            this.imageListTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTree.ImageStream")));
            this.imageListTree.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTree.Images.SetKeyName(0, "l_users.gif");
            this.imageListTree.Images.SetKeyName(1, "group.png");
            this.imageListTree.Images.SetKeyName(2, "shape.png");
            this.imageListTree.Images.SetKeyName(3, "switch.png");
            this.imageListTree.Images.SetKeyName(4, "help_w.gif");
            this.imageListTree.Images.SetKeyName(5, "suche.gif");
            this.imageListTree.Images.SetKeyName(6, "l_stop.gif");
            this.imageListTree.Images.SetKeyName(7, "adim.ico");
            // 
            // allAssignDepartmentForCurrentPersonnleGroupBox
            // 
            this.allAssignDepartmentForCurrentPersonnleGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.allAssignDepartmentForCurrentPersonnleGroupBox.Controls.Add(this.allAssignDepartmentForCurrentPersonnleDataGridView);
            this.allAssignDepartmentForCurrentPersonnleGroupBox.Location = new System.Drawing.Point(3, 295);
            this.allAssignDepartmentForCurrentPersonnleGroupBox.Name = "allAssignDepartmentForCurrentPersonnleGroupBox";
            this.allAssignDepartmentForCurrentPersonnleGroupBox.Size = new System.Drawing.Size(525, 178);
            this.allAssignDepartmentForCurrentPersonnleGroupBox.TabIndex = 5;
            this.allAssignDepartmentForCurrentPersonnleGroupBox.TabStop = false;
            this.allAssignDepartmentForCurrentPersonnleGroupBox.Text = "تمام سمت های که پرسنل در آن مشغول به کار بوده ";
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
            this.dataGridViewTextBoxColumn2,
            this.DepartmentName,
            this.DepartmentVersionName,
            this.DepartmentVersionDate,
            this.idDataGridViewTextBoxColumn1});
            this.allAssignDepartmentForCurrentPersonnleDataGridView.DataSource = this.allAssignOrganisationStructureForCurrentPersonnleBindingSource;
            this.allAssignDepartmentForCurrentPersonnleDataGridView.Location = new System.Drawing.Point(6, 20);
            this.allAssignDepartmentForCurrentPersonnleDataGridView.Name = "allAssignDepartmentForCurrentPersonnleDataGridView";
            this.allAssignDepartmentForCurrentPersonnleDataGridView.ReadOnly = true;
            this.allAssignDepartmentForCurrentPersonnleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allAssignDepartmentForCurrentPersonnleDataGridView.Size = new System.Drawing.Size(513, 137);
            this.allAssignDepartmentForCurrentPersonnleDataGridView.TabIndex = 0;
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
            this.DepartmentName.DataPropertyName = "RoleName";
            this.DepartmentName.FillWeight = 120F;
            this.DepartmentName.HeaderText = "نام سمت";
            this.DepartmentName.Name = "DepartmentName";
            this.DepartmentName.ReadOnly = true;
            this.DepartmentName.Width = 120;
            // 
            // DepartmentVersionName
            // 
            this.DepartmentVersionName.DataPropertyName = "OrganizationStructureVersionCode";
            this.DepartmentVersionName.FillWeight = 60F;
            this.DepartmentVersionName.HeaderText = "نسخه";
            this.DepartmentVersionName.Name = "DepartmentVersionName";
            this.DepartmentVersionName.ReadOnly = true;
            this.DepartmentVersionName.Width = 60;
            // 
            // DepartmentVersionDate
            // 
            this.DepartmentVersionDate.DataPropertyName = "OrganizationStructureVersionDate";
            this.DepartmentVersionDate.FillWeight = 125F;
            this.DepartmentVersionDate.HeaderText = "تاریخ نسخه یا فعالیت";
            this.DepartmentVersionDate.Name = "DepartmentVersionDate";
            this.DepartmentVersionDate.ReadOnly = true;
            this.DepartmentVersionDate.Width = 125;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // allAssignOrganisationStructureForCurrentPersonnleBindingSource
            // 
            this.allAssignOrganisationStructureForCurrentPersonnleBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.OrganizationStructurePersonnel);
            // 
            // toolsGroupBox
            // 
            this.toolsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.toolsGroupBox.Controls.Add(this.setMainPositionButton);
            this.toolsGroupBox.Controls.Add(this.deleteButton);
            this.toolsGroupBox.Controls.Add(this.addPersonnelTocurrentRolButton);
            this.toolsGroupBox.Location = new System.Drawing.Point(6, 212);
            this.toolsGroupBox.Name = "toolsGroupBox";
            this.toolsGroupBox.Size = new System.Drawing.Size(524, 63);
            this.toolsGroupBox.TabIndex = 1;
            this.toolsGroupBox.TabStop = false;
            // 
            // setMainPositionButton
            // 
            this.setMainPositionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setMainPositionButton.Location = new System.Drawing.Point(244, 20);
            this.setMainPositionButton.Name = "setMainPositionButton";
            this.setMainPositionButton.Size = new System.Drawing.Size(108, 23);
            this.setMainPositionButton.TabIndex = 2;
            this.setMainPositionButton.Text = "تعیین سمت اصلی";
            this.setMainPositionButton.UseVisualStyleBackColor = true;
            this.setMainPositionButton.Click += new System.EventHandler(this.setMainPositionButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(358, 20);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "حذف";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addPersonnelTocurrentRolButton
            // 
            this.addPersonnelTocurrentRolButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addPersonnelTocurrentRolButton.Location = new System.Drawing.Point(442, 20);
            this.addPersonnelTocurrentRolButton.Name = "addPersonnelTocurrentRolButton";
            this.addPersonnelTocurrentRolButton.Size = new System.Drawing.Size(75, 23);
            this.addPersonnelTocurrentRolButton.TabIndex = 0;
            this.addPersonnelTocurrentRolButton.Text = "اضافه";
            this.addPersonnelTocurrentRolButton.UseVisualStyleBackColor = true;
            this.addPersonnelTocurrentRolButton.Click += new System.EventHandler(this.addPersonnelTocurrentRolButton_Click);
            // 
            // gridRolsGroupBox
            // 
            this.gridRolsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridRolsGroupBox.Controls.Add(this.assignPersonnelsDataGridView);
            this.gridRolsGroupBox.Location = new System.Drawing.Point(8, 3);
            this.gridRolsGroupBox.Name = "gridRolsGroupBox";
            this.gridRolsGroupBox.Size = new System.Drawing.Size(525, 209);
            this.gridRolsGroupBox.TabIndex = 0;
            this.gridRolsGroupBox.TabStop = false;
            this.gridRolsGroupBox.Text = "پرسنل های تخصیص داده شده در سمت جاری";
            // 
            // assignPersonnelsDataGridView
            // 
            this.assignPersonnelsDataGridView.AllowUserToAddRows = false;
            this.assignPersonnelsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.assignPersonnelsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.assignPersonnelsDataGridView.AutoGenerateColumns = false;
            this.assignPersonnelsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.assignPersonnelsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assignPersonnelsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.PersonnelNumber,
            this.personnelIdDataGridViewTextBoxColumn,
            this.organisationStructureIdDataGridViewTextBoxColumn,
            this.isMainPositionDataGridViewTextBoxColumn,
            this.organizationStructureDataGridViewTextBoxColumn,
            this.personnelDataGridViewTextBoxColumn,
            this.personnelNameDataGridViewTextBoxColumn,
            this.IsMainPositionValue});
            this.assignPersonnelsDataGridView.DataSource = this.organisationStructurePersonnelBindingSource;
            this.assignPersonnelsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assignPersonnelsDataGridView.Location = new System.Drawing.Point(3, 17);
            this.assignPersonnelsDataGridView.MultiSelect = false;
            this.assignPersonnelsDataGridView.Name = "assignPersonnelsDataGridView";
            this.assignPersonnelsDataGridView.ReadOnly = true;
            this.assignPersonnelsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.assignPersonnelsDataGridView.Size = new System.Drawing.Size(519, 189);
            this.assignPersonnelsDataGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // PersonnelNumber
            // 
            this.PersonnelNumber.DataPropertyName = "PersonnelNumber";
            this.PersonnelNumber.FillWeight = 120F;
            this.PersonnelNumber.HeaderText = "شماره پرسنلی";
            this.PersonnelNumber.Name = "PersonnelNumber";
            this.PersonnelNumber.ReadOnly = true;
            this.PersonnelNumber.Width = 120;
            // 
            // personnelIdDataGridViewTextBoxColumn
            // 
            this.personnelIdDataGridViewTextBoxColumn.DataPropertyName = "PersonnelId";
            this.personnelIdDataGridViewTextBoxColumn.HeaderText = "PersonnelId";
            this.personnelIdDataGridViewTextBoxColumn.Name = "personnelIdDataGridViewTextBoxColumn";
            this.personnelIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.personnelIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // organisationStructureIdDataGridViewTextBoxColumn
            // 
            this.organisationStructureIdDataGridViewTextBoxColumn.DataPropertyName = "OrganisationStructureId";
            this.organisationStructureIdDataGridViewTextBoxColumn.HeaderText = "OrganisationStructureId";
            this.organisationStructureIdDataGridViewTextBoxColumn.Name = "organisationStructureIdDataGridViewTextBoxColumn";
            this.organisationStructureIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.organisationStructureIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // isMainPositionDataGridViewTextBoxColumn
            // 
            this.isMainPositionDataGridViewTextBoxColumn.DataPropertyName = "IsMainPosition";
            this.isMainPositionDataGridViewTextBoxColumn.HeaderText = "IsMainPosition";
            this.isMainPositionDataGridViewTextBoxColumn.Name = "isMainPositionDataGridViewTextBoxColumn";
            this.isMainPositionDataGridViewTextBoxColumn.ReadOnly = true;
            this.isMainPositionDataGridViewTextBoxColumn.Visible = false;
            // 
            // organizationStructureDataGridViewTextBoxColumn
            // 
            this.organizationStructureDataGridViewTextBoxColumn.DataPropertyName = "OrganizationStructure";
            this.organizationStructureDataGridViewTextBoxColumn.HeaderText = "OrganizationStructure";
            this.organizationStructureDataGridViewTextBoxColumn.Name = "organizationStructureDataGridViewTextBoxColumn";
            this.organizationStructureDataGridViewTextBoxColumn.ReadOnly = true;
            this.organizationStructureDataGridViewTextBoxColumn.Visible = false;
            // 
            // personnelDataGridViewTextBoxColumn
            // 
            this.personnelDataGridViewTextBoxColumn.DataPropertyName = "Personnel";
            this.personnelDataGridViewTextBoxColumn.HeaderText = "Personnel";
            this.personnelDataGridViewTextBoxColumn.Name = "personnelDataGridViewTextBoxColumn";
            this.personnelDataGridViewTextBoxColumn.ReadOnly = true;
            this.personnelDataGridViewTextBoxColumn.Visible = false;
            // 
            // personnelNameDataGridViewTextBoxColumn
            // 
            this.personnelNameDataGridViewTextBoxColumn.DataPropertyName = "PersonnelName";
            this.personnelNameDataGridViewTextBoxColumn.FillWeight = 180F;
            this.personnelNameDataGridViewTextBoxColumn.HeaderText = "نام پرسنل";
            this.personnelNameDataGridViewTextBoxColumn.Name = "personnelNameDataGridViewTextBoxColumn";
            this.personnelNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.personnelNameDataGridViewTextBoxColumn.Width = 180;
            // 
            // IsMainPositionValue
            // 
            this.IsMainPositionValue.DataPropertyName = "IsMainPositionValue";
            this.IsMainPositionValue.HeaderText = "سمت اصلی";
            this.IsMainPositionValue.Name = "IsMainPositionValue";
            this.IsMainPositionValue.ReadOnly = true;
            // 
            // organisationStructurePersonnelBindingSource
            // 
            this.organisationStructurePersonnelBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.OrganizationStructurePersonnel);
            this.organisationStructurePersonnelBindingSource.CurrentChanged += new System.EventHandler(this.organisationStructurePersonnelBindingSource_CurrentChanged);
            this.organisationStructurePersonnelBindingSource.PositionChanged += new System.EventHandler(this.organisationStructurePersonnelBindingSource_PositionChanged);
            // 
            // AssignPersonnelsToOrganizationStructureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1000, 643);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AssignPersonnelsToOrganizationStructureForm";
            this.Text = "تخصیص پرسنل در سمت ها";
            this.Load += new System.EventHandler(this.AssignPersonnelsToOrganizationStructureForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.organizationStructureVersionBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.allAssignDepartmentForCurrentPersonnleGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.allAssignDepartmentForCurrentPersonnleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allAssignOrganisationStructureForCurrentPersonnleBindingSource)).EndInit();
            this.toolsGroupBox.ResumeLayout(false);
            this.gridRolsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.assignPersonnelsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organisationStructurePersonnelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageList imageListControls;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView rolesStructureTreeView;
        private System.Windows.Forms.ImageList imageListTree;
        private System.Windows.Forms.GroupBox toolsGroupBox;
        private System.Windows.Forms.GroupBox gridRolsGroupBox;
        private System.Windows.Forms.DataGridView assignPersonnelsDataGridView;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addPersonnelTocurrentRolButton;
        private System.Windows.Forms.BindingSource organisationStructurePersonnelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonnelNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnelIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn organisationStructureIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isMainPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn organizationStructureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsMainPositionValue;
        private System.Windows.Forms.Button setMainPositionButton;
        private System.Windows.Forms.Label activeOrganizationStructureVersionLabel;
        private System.Windows.Forms.ComboBox organizationStructureVersionComboBox;
        private System.Windows.Forms.Button selectOrganizationStructureVersionButton;
        private System.Windows.Forms.Label selectDepartmentVersionLabel;
        private System.Windows.Forms.GroupBox allAssignDepartmentForCurrentPersonnleGroupBox;
        private System.Windows.Forms.DataGridView allAssignDepartmentForCurrentPersonnleDataGridView;
        private System.Windows.Forms.BindingSource organizationStructureVersionBindingSource;
        private System.Windows.Forms.BindingSource allAssignOrganisationStructureForCurrentPersonnleBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentVersionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentVersionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
    }
}