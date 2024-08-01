namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class DepartmentsDialogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentsDialogForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.passNullCheckBox = new System.Windows.Forms.CheckBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.collapseAndExpandButton = new System.Windows.Forms.Button();
            this.departmentTreeView = new System.Windows.Forms.TreeView();
            this.imageListTree = new System.Windows.Forms.ImageList(this.components);
            this.panelTop = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.departmentVersionComboBox = new System.Windows.Forms.ComboBox();
            this.departmentVersionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectDepartmentversionButton = new System.Windows.Forms.Button();
            this.imageListControls = new System.Windows.Forms.ImageList(this.components);
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.selectDepartmentVersionLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cuteToolStripMenuItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pastNodeToolStripMenuItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentVersionBindingSource)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelBottom, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.departmentTreeView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelTop, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(744, 527);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.passNullCheckBox);
            this.panelBottom.Controls.Add(this.cancelButton);
            this.panelBottom.Controls.Add(this.selectButton);
            this.panelBottom.Controls.Add(this.collapseAndExpandButton);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(3, 490);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(738, 34);
            this.panelBottom.TabIndex = 2;
            // 
            // passNullCheckBox
            // 
            this.passNullCheckBox.AutoSize = true;
            this.passNullCheckBox.Location = new System.Drawing.Point(475, 8);
            this.passNullCheckBox.Name = "passNullCheckBox";
            this.passNullCheckBox.Size = new System.Drawing.Size(79, 17);
            this.passNullCheckBox.TabIndex = 8;
            this.passNullCheckBox.Text = "بدون انتخاب";
            this.passNullCheckBox.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(573, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "لغو";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectButton.Location = new System.Drawing.Point(654, 5);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 6;
            this.selectButton.Text = "انتخاب";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // collapseAndExpandButton
            // 
            this.collapseAndExpandButton.Location = new System.Drawing.Point(8, 6);
            this.collapseAndExpandButton.Name = "collapseAndExpandButton";
            this.collapseAndExpandButton.Size = new System.Drawing.Size(75, 23);
            this.collapseAndExpandButton.TabIndex = 5;
            this.collapseAndExpandButton.Text = "جمع کردن";
            this.collapseAndExpandButton.UseVisualStyleBackColor = true;
            this.collapseAndExpandButton.Click += new System.EventHandler(this.collapseAndExpandButton_Click);
            // 
            // departmentTreeView
            // 
            this.departmentTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.departmentTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departmentTreeView.HideSelection = false;
            this.departmentTreeView.HotTracking = true;
            this.departmentTreeView.ImageIndex = 5;
            this.departmentTreeView.ImageList = this.imageListTree;
            this.departmentTreeView.Location = new System.Drawing.Point(3, 83);
            this.departmentTreeView.Name = "departmentTreeView";
            this.departmentTreeView.RightToLeftLayout = true;
            this.departmentTreeView.SelectedImageIndex = 4;
            this.departmentTreeView.Size = new System.Drawing.Size(738, 401);
            this.departmentTreeView.TabIndex = 0;
            this.departmentTreeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.departmentTreeView_MouseDown);
            this.departmentTreeView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.departmentTreeView_MouseUp);
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
            // panelTop
            // 
            this.panelTop.Controls.Add(this.groupBox1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(3, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(738, 74);
            this.panelTop.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.departmentVersionComboBox);
            this.groupBox1.Controls.Add(this.selectDepartmentversionButton);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.selectDepartmentVersionLabel);
            this.groupBox1.Controls.Add(this.SearchButton);
            this.groupBox1.Controls.Add(this.nextButton);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Location = new System.Drawing.Point(17, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 70);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
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
            this.departmentVersionComboBox.SelectedValueChanged += new System.EventHandler(this.departmentVersionComboBox_SelectedValueChanged);
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
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuteToolStripMenuItemToolStripMenuItem,
            this.pastNodeToolStripMenuItemToolStripMenuItem,
            this.insertNodeToolStripMenuItem,
            this.editNodeToolStripMenuItem,
            this.deletNodeToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip.Size = new System.Drawing.Size(144, 114);
            // 
            // cuteToolStripMenuItemToolStripMenuItem
            // 
            this.cuteToolStripMenuItemToolStripMenuItem.Name = "cuteToolStripMenuItemToolStripMenuItem";
            this.cuteToolStripMenuItemToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cuteToolStripMenuItemToolStripMenuItem.Text = "برش";
            this.cuteToolStripMenuItemToolStripMenuItem.Click += new System.EventHandler(this.cuteToolStripMenuItemToolStripMenuItem_Click);
            // 
            // pastNodeToolStripMenuItemToolStripMenuItem
            // 
            this.pastNodeToolStripMenuItemToolStripMenuItem.Enabled = false;
            this.pastNodeToolStripMenuItemToolStripMenuItem.Name = "pastNodeToolStripMenuItemToolStripMenuItem";
            this.pastNodeToolStripMenuItemToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.pastNodeToolStripMenuItemToolStripMenuItem.Text = "انتقال یافتن به";
            this.pastNodeToolStripMenuItemToolStripMenuItem.Click += new System.EventHandler(this.pastNodeToolStripMenuItemToolStripMenuItem_Click);
            // 
            // insertNodeToolStripMenuItem
            // 
            this.insertNodeToolStripMenuItem.Name = "insertNodeToolStripMenuItem";
            this.insertNodeToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.insertNodeToolStripMenuItem.Text = "درج";
            // 
            // editNodeToolStripMenuItem
            // 
            this.editNodeToolStripMenuItem.Name = "editNodeToolStripMenuItem";
            this.editNodeToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.editNodeToolStripMenuItem.Text = "ویرایش";
            // 
            // deletNodeToolStripMenuItem
            // 
            this.deletNodeToolStripMenuItem.Name = "deletNodeToolStripMenuItem";
            this.deletNodeToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.deletNodeToolStripMenuItem.Text = "حذف";
            // 
            // DepartmentsDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(744, 527);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DepartmentsDialogForm";
            this.Text = "واحد های سازمانی";
            this.Load += new System.EventHandler(this.DepartmentsDialogForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentVersionBindingSource)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TreeView departmentTreeView;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.ImageList imageListTree;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button collapseAndExpandButton;
        private System.Windows.Forms.ImageList imageListControls;
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
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.CheckBox passNullCheckBox;
    }
}