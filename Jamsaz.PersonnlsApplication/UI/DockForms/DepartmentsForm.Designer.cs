namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    partial class departmentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(departmentsForm));
            Janus.Windows.ExplorerBar.ExplorerBarGroup explorerBarGroup1 = new Janus.Windows.ExplorerBar.ExplorerBarGroup();
            Janus.Windows.ExplorerBar.ExplorerBarGroup explorerBarGroup2 = new Janus.Windows.ExplorerBar.ExplorerBarGroup();
            this.explorerBarContainerControl1 = new Janus.Windows.ExplorerBar.ExplorerBarContainerControl();
            this.currentNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.explorerBarContainerControl2 = new Janus.Windows.ExplorerBar.ExplorerBarContainerControl();
            this.selectOriginalDepartmentButton = new System.Windows.Forms.Button();
            this.originalNameTextBox = new System.Windows.Forms.TextBox();
            this.originalCodeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.copyButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.imageListControls = new System.Windows.Forms.ImageList(this.components);
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.collapseAndExpandButton = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.activeDepartmentVersionLabel = new System.Windows.Forms.Label();
            this.departmentVersionComboBox = new System.Windows.Forms.ComboBox();
            this.departmentVersionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectDepartmentversionButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.selectDepartmentVersionLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.departmentTreeView = new System.Windows.Forms.TreeView();
            this.imageListTree = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.explorerBar1 = new Janus.Windows.ExplorerBar.ExplorerBar();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cuteToolStripMenuItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pastNodeToolStripMenuItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.explorerBarContainerControl1.SuspendLayout();
            this.explorerBarContainerControl2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentVersionBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.explorerBar1)).BeginInit();
            this.explorerBar1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // explorerBarContainerControl1
            // 
            this.explorerBarContainerControl1.Controls.Add(this.currentNameTextBox);
            this.explorerBarContainerControl1.Controls.Add(this.label4);
            this.explorerBarContainerControl1.Controls.Add(this.codeTextBox);
            this.explorerBarContainerControl1.Controls.Add(this.label1);
            this.explorerBarContainerControl1.Location = new System.Drawing.Point(9, 33);
            this.explorerBarContainerControl1.Name = "explorerBarContainerControl1";
            this.explorerBarContainerControl1.Size = new System.Drawing.Size(307, 149);
            this.explorerBarContainerControl1.TabIndex = 2;
            // 
            // currentNameTextBox
            // 
            this.currentNameTextBox.AcceptsReturn = true;
            this.currentNameTextBox.BackColor = System.Drawing.Color.White;
            this.currentNameTextBox.Location = new System.Drawing.Point(18, 57);
            this.currentNameTextBox.Name = "currentNameTextBox";
            this.currentNameTextBox.ReadOnly = true;
            this.currentNameTextBox.Size = new System.Drawing.Size(206, 21);
            this.currentNameTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "نام واحد جاری";
            // 
            // codeTextBox
            // 
            this.codeTextBox.BackColor = System.Drawing.Color.White;
            this.codeTextBox.Location = new System.Drawing.Point(18, 30);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.ReadOnly = true;
            this.codeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.codeTextBox.Size = new System.Drawing.Size(206, 21);
            this.codeTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "کد واحد جاری";
            // 
            // explorerBarContainerControl2
            // 
            this.explorerBarContainerControl2.Controls.Add(this.selectOriginalDepartmentButton);
            this.explorerBarContainerControl2.Controls.Add(this.originalNameTextBox);
            this.explorerBarContainerControl2.Controls.Add(this.originalCodeTextBox);
            this.explorerBarContainerControl2.Controls.Add(this.label2);
            this.explorerBarContainerControl2.Controls.Add(this.label3);
            this.explorerBarContainerControl2.Location = new System.Drawing.Point(9, 218);
            this.explorerBarContainerControl2.Name = "explorerBarContainerControl2";
            this.explorerBarContainerControl2.Size = new System.Drawing.Size(307, 149);
            this.explorerBarContainerControl2.TabIndex = 3;
            // 
            // selectOriginalDepartmentButton
            // 
            this.selectOriginalDepartmentButton.Location = new System.Drawing.Point(13, 110);
            this.selectOriginalDepartmentButton.Name = "selectOriginalDepartmentButton";
            this.selectOriginalDepartmentButton.Size = new System.Drawing.Size(100, 23);
            this.selectOriginalDepartmentButton.TabIndex = 6;
            this.selectOriginalDepartmentButton.Text = "انتخاب واحد اصلی";
            this.selectOriginalDepartmentButton.UseVisualStyleBackColor = true;
            this.selectOriginalDepartmentButton.Click += new System.EventHandler(this.selectOriginalDepartmentButton_Click);
            // 
            // originalNameTextBox
            // 
            this.originalNameTextBox.BackColor = System.Drawing.Color.White;
            this.originalNameTextBox.Location = new System.Drawing.Point(13, 69);
            this.originalNameTextBox.Name = "originalNameTextBox";
            this.originalNameTextBox.ReadOnly = true;
            this.originalNameTextBox.Size = new System.Drawing.Size(206, 21);
            this.originalNameTextBox.TabIndex = 5;
            // 
            // originalCodeTextBox
            // 
            this.originalCodeTextBox.BackColor = System.Drawing.Color.White;
            this.originalCodeTextBox.Location = new System.Drawing.Point(13, 42);
            this.originalCodeTextBox.Name = "originalCodeTextBox";
            this.originalCodeTextBox.ReadOnly = true;
            this.originalCodeTextBox.Size = new System.Drawing.Size(206, 21);
            this.originalCodeTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "کد واحد اصلی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "نام واحد اصلی";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelBottom, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelTop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1017, 709);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.copyButton);
            this.panelBottom.Controls.Add(this.editButton);
            this.panelBottom.Controls.Add(this.deleteButton);
            this.panelBottom.Controls.Add(this.addButton);
            this.panelBottom.Controls.Add(this.collapseAndExpandButton);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(3, 672);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1011, 34);
            this.panelBottom.TabIndex = 2;
            this.panelBottom.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBottom_Paint);
            // 
            // copyButton
            // 
            this.copyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.copyButton.Image = ((System.Drawing.Image)(resources.GetObject("copyButton.Image")));
            this.copyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.copyButton.Location = new System.Drawing.Point(911, 6);
            this.copyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(92, 25);
            this.copyButton.TabIndex = 9;
            this.copyButton.Text = "کپی نسخه";
            this.copyButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editButton.ImageIndex = 3;
            this.editButton.ImageList = this.imageListControls;
            this.editButton.Location = new System.Drawing.Point(716, 6);
            this.editButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(92, 25);
            this.editButton.TabIndex = 7;
            this.editButton.Text = "ویرایش";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
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
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteButton.ImageIndex = 2;
            this.deleteButton.ImageList = this.imageListControls;
            this.deleteButton.Location = new System.Drawing.Point(619, 6);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(92, 25);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "حذف";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addButton.ImageIndex = 1;
            this.addButton.ImageList = this.imageListControls;
            this.addButton.Location = new System.Drawing.Point(813, 6);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(92, 25);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "درج";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // collapseAndExpandButton
            // 
            this.collapseAndExpandButton.Location = new System.Drawing.Point(3, 10);
            this.collapseAndExpandButton.Name = "collapseAndExpandButton";
            this.collapseAndExpandButton.Size = new System.Drawing.Size(64, 21);
            this.collapseAndExpandButton.TabIndex = 5;
            this.collapseAndExpandButton.Text = "جمع کردن";
            this.collapseAndExpandButton.UseVisualStyleBackColor = true;
            this.collapseAndExpandButton.Click += new System.EventHandler(this.collapseAndExpandButton_Click);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.groupBox1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(3, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1011, 74);
            this.panelTop.TabIndex = 1;
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
            this.groupBox1.Location = new System.Drawing.Point(290, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 70);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // activeDepartmentVersionLabel
            // 
            this.activeDepartmentVersionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.activeDepartmentVersionLabel.AutoSize = true;
            this.activeDepartmentVersionLabel.BackColor = System.Drawing.Color.SandyBrown;
            this.activeDepartmentVersionLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.activeDepartmentVersionLabel.ForeColor = System.Drawing.Color.Black;
            this.activeDepartmentVersionLabel.Location = new System.Drawing.Point(172, 43);
            this.activeDepartmentVersionLabel.Name = "activeDepartmentVersionLabel";
            this.activeDepartmentVersionLabel.Size = new System.Drawing.Size(224, 14);
            this.activeDepartmentVersionLabel.TabIndex = 32;
            this.activeDepartmentVersionLabel.Text = "این نسخه , نسخه فعال سیستم می باشد";
            this.activeDepartmentVersionLabel.Visible = false;
            // 
            // departmentVersionComboBox
            // 
            this.departmentVersionComboBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.departmentVersionComboBox.DataSource = this.departmentVersionBindingSource;
            this.departmentVersionComboBox.DisplayMember = "Code";
            this.departmentVersionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentVersionComboBox.FormattingEnabled = true;
            this.departmentVersionComboBox.Location = new System.Drawing.Point(491, 40);
            this.departmentVersionComboBox.Name = "departmentVersionComboBox";
            this.departmentVersionComboBox.Size = new System.Drawing.Size(115, 21);
            this.departmentVersionComboBox.TabIndex = 24;
            this.departmentVersionComboBox.ValueMember = "ID";
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
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nameTextBox.Location = new System.Drawing.Point(403, 14);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(204, 21);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
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
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 325F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 80);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1017, 589);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.departmentTreeView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(325, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 589);
            this.panel1.TabIndex = 0;
            // 
            // departmentTreeView
            // 
            this.departmentTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.departmentTreeView.ContextMenuStrip = this.contextMenuStrip;
            this.departmentTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departmentTreeView.HideSelection = false;
            this.departmentTreeView.HotTracking = true;
            this.departmentTreeView.ImageIndex = 5;
            this.departmentTreeView.ImageList = this.imageListTree;
            this.departmentTreeView.Location = new System.Drawing.Point(0, 0);
            this.departmentTreeView.Name = "departmentTreeView";
            this.departmentTreeView.RightToLeftLayout = true;
            this.departmentTreeView.SelectedImageIndex = 4;
            this.departmentTreeView.Size = new System.Drawing.Size(692, 589);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.explorerBar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 589);
            this.panel2.TabIndex = 1;
            // 
            // explorerBar1
            // 
            this.explorerBar1.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.SpecialGroupHeader;
            this.explorerBar1.BlendColor = System.Drawing.SystemColors.InactiveBorder;
            this.explorerBar1.Controls.Add(this.explorerBarContainerControl1);
            this.explorerBar1.Controls.Add(this.explorerBarContainerControl2);
            this.explorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.explorerBar1.FlatBorderColor = System.Drawing.SystemColors.HotTrack;
            explorerBarGroup1.Container = true;
            explorerBarGroup1.ContainerControl = this.explorerBarContainerControl1;
            explorerBarGroup1.ContainerHeight = 150;
            explorerBarGroup1.Key = "Group1";
            explorerBarGroup1.Text = "واحد جاری";
            explorerBarGroup2.Container = true;
            explorerBarGroup2.ContainerControl = this.explorerBarContainerControl2;
            explorerBarGroup2.ContainerHeight = 150;
            explorerBarGroup2.Key = "Group2";
            explorerBarGroup2.Text = "ارتباط با واحد اصلی";
            this.explorerBar1.Groups.AddRange(new Janus.Windows.ExplorerBar.ExplorerBarGroup[] {
            explorerBarGroup1,
            explorerBarGroup2});
            this.explorerBar1.Location = new System.Drawing.Point(0, 0);
            this.explorerBar1.Name = "explorerBar1";
            this.explorerBar1.Office2007CustomColor = System.Drawing.SystemColors.ActiveBorder;
            this.explorerBar1.Size = new System.Drawing.Size(325, 589);
            this.explorerBar1.SpecialGroupsStateStyles.FormatStyle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.explorerBar1.TabIndex = 0;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuteToolStripMenuItemToolStripMenuItem,
            this.pastNodeToolStripMenuItemToolStripMenuItem,
            this.insertNodeToolStripMenuItem,
            this.editNodeToolStripMenuItem,
            this.deletNodeToolStripMenuItem,
            this.originalDepartmentToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip.Size = new System.Drawing.Size(234, 136);
            // 
            // cuteToolStripMenuItemToolStripMenuItem
            // 
            this.cuteToolStripMenuItemToolStripMenuItem.Name = "cuteToolStripMenuItemToolStripMenuItem";
            this.cuteToolStripMenuItemToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.cuteToolStripMenuItemToolStripMenuItem.Text = "برش";
            this.cuteToolStripMenuItemToolStripMenuItem.Click += new System.EventHandler(this.cuteToolStripMenuItemToolStripMenuItem_Click);
            // 
            // pastNodeToolStripMenuItemToolStripMenuItem
            // 
            this.pastNodeToolStripMenuItemToolStripMenuItem.Enabled = false;
            this.pastNodeToolStripMenuItemToolStripMenuItem.Name = "pastNodeToolStripMenuItemToolStripMenuItem";
            this.pastNodeToolStripMenuItemToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.pastNodeToolStripMenuItemToolStripMenuItem.Text = "انتقال یافتن به";
            this.pastNodeToolStripMenuItemToolStripMenuItem.Click += new System.EventHandler(this.pastNodeToolStripMenuItemToolStripMenuItem_Click);
            // 
            // insertNodeToolStripMenuItem
            // 
            this.insertNodeToolStripMenuItem.Name = "insertNodeToolStripMenuItem";
            this.insertNodeToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.insertNodeToolStripMenuItem.Text = "درج";
            this.insertNodeToolStripMenuItem.Click += new System.EventHandler(this.insertNodeToolStripMenuItem_Click);
            // 
            // editNodeToolStripMenuItem
            // 
            this.editNodeToolStripMenuItem.Name = "editNodeToolStripMenuItem";
            this.editNodeToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.editNodeToolStripMenuItem.Text = "ویرایش";
            this.editNodeToolStripMenuItem.Click += new System.EventHandler(this.editNodeToolStripMenuItem_Click);
            // 
            // deletNodeToolStripMenuItem
            // 
            this.deletNodeToolStripMenuItem.Name = "deletNodeToolStripMenuItem";
            this.deletNodeToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.deletNodeToolStripMenuItem.Text = "حذف";
            this.deletNodeToolStripMenuItem.Click += new System.EventHandler(this.deletNodeToolStripMenuItem_Click);
            // 
            // originalDepartmentToolStripMenuItem
            // 
            this.originalDepartmentToolStripMenuItem.Name = "originalDepartmentToolStripMenuItem";
            this.originalDepartmentToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.originalDepartmentToolStripMenuItem.Text = "ارتباط با واحد های سازمانی اصلی";
            this.originalDepartmentToolStripMenuItem.Click += new System.EventHandler(this.originalDepartmentToolStripMenuItem_Click);
            // 
            // departmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1017, 709);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "departmentsForm";
            this.Text = "واحد های سازمانی";
            this.Load += new System.EventHandler(this.departmentsForm_Load);
            this.explorerBarContainerControl1.ResumeLayout(false);
            this.explorerBarContainerControl1.PerformLayout();
            this.explorerBarContainerControl2.ResumeLayout(false);
            this.explorerBarContainerControl2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentVersionBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.explorerBar1)).EndInit();
            this.explorerBar1.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.ImageList imageListTree;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button collapseAndExpandButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.ImageList imageListControls;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem cuteToolStripMenuItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pastNodeToolStripMenuItemToolStripMenuItem;
        private System.Windows.Forms.Button selectDepartmentversionButton;
        private System.Windows.Forms.Label selectDepartmentVersionLabel;
        private System.Windows.Forms.ComboBox departmentVersionComboBox;
        private System.Windows.Forms.BindingSource departmentVersionBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem insertNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletNodeToolStripMenuItem;
        private System.Windows.Forms.Label activeDepartmentVersionLabel;
        private System.Windows.Forms.ToolStripMenuItem originalDepartmentToolStripMenuItem;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView departmentTreeView;
        private System.Windows.Forms.Panel panel2;
        private Janus.Windows.ExplorerBar.ExplorerBar explorerBar1;
        private Janus.Windows.ExplorerBar.ExplorerBarContainerControl explorerBarContainerControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox originalNameTextBox;
        private System.Windows.Forms.TextBox originalCodeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox currentNameTextBox;
        private System.Windows.Forms.Label label4;
        private Janus.Windows.ExplorerBar.ExplorerBarContainerControl explorerBarContainerControl2;
        private System.Windows.Forms.Button selectOriginalDepartmentButton;
    }
}