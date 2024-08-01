namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    partial class rolesStructureForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rolesStructureForm));
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
            this.activeOrganizationStructureVersionLabel = new System.Windows.Forms.Label();
            this.organizationStructureVersionComboBox = new System.Windows.Forms.ComboBox();
            this.organizationStructureVersionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectOrganizationStructureVersionButton = new System.Windows.Forms.Button();
            this.selectDepartmentVersionLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.rolesStructureTreeView = new System.Windows.Forms.TreeView();
            this.imageListTree = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cuteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pastNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportPersonnelsFromCurrentRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.organizationStructureVersionBindingSource)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelBottom, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelTop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rolesStructureTreeView, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(856, 630);
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
            this.panelBottom.Location = new System.Drawing.Point(3, 588);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(850, 39);
            this.panelBottom.TabIndex = 4;
            // 
            // copyButton
            // 
            this.copyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.copyButton.Image = ((System.Drawing.Image)(resources.GetObject("copyButton.Image")));
            this.copyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.copyButton.Location = new System.Drawing.Point(753, 7);
            this.copyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(92, 25);
            this.copyButton.TabIndex = 10;
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
            this.editButton.Location = new System.Drawing.Point(558, 7);
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
            this.deleteButton.Location = new System.Drawing.Point(462, 7);
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
            this.addButton.Location = new System.Drawing.Point(655, 7);
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
            this.collapseAndExpandButton.Location = new System.Drawing.Point(8, 11);
            this.collapseAndExpandButton.Name = "collapseAndExpandButton";
            this.collapseAndExpandButton.Size = new System.Drawing.Size(64, 21);
            this.collapseAndExpandButton.TabIndex = 5;
            this.collapseAndExpandButton.Text = "جمع کردن";
            this.collapseAndExpandButton.UseVisualStyleBackColor = true;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.groupBox1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(3, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(850, 84);
            this.panelTop.TabIndex = 2;
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
            this.groupBox1.Location = new System.Drawing.Point(133, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 73);
            this.groupBox1.TabIndex = 28;
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
            this.SearchButton.Click += new System.EventHandler(this.searchButton_Click);
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
            // rolesStructureTreeView
            // 
            this.rolesStructureTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.rolesStructureTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rolesStructureTreeView.HideSelection = false;
            this.rolesStructureTreeView.ImageIndex = 0;
            this.rolesStructureTreeView.ImageList = this.imageListTree;
            this.rolesStructureTreeView.Location = new System.Drawing.Point(3, 93);
            this.rolesStructureTreeView.Name = "rolesStructureTreeView";
            this.rolesStructureTreeView.RightToLeftLayout = true;
            this.rolesStructureTreeView.SelectedImageIndex = 5;
            this.rolesStructureTreeView.Size = new System.Drawing.Size(850, 489);
            this.rolesStructureTreeView.TabIndex = 3;
            this.rolesStructureTreeView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rolesStructureTreeView_MouseUp);
            this.rolesStructureTreeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rolesStructureTreeView_MouseDown);
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
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuteToolStripMenuItem,
            this.pastNodeToolStripMenuItem,
            this.reportPersonnelsFromCurrentRoleToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip.Size = new System.Drawing.Size(220, 70);
            // 
            // cuteToolStripMenuItem
            // 
            this.cuteToolStripMenuItem.Name = "cuteToolStripMenuItem";
            this.cuteToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.cuteToolStripMenuItem.Text = "برش";
            this.cuteToolStripMenuItem.Click += new System.EventHandler(this.cuteToolStripMenuItem_Click);
            // 
            // pastNodeToolStripMenuItem
            // 
            this.pastNodeToolStripMenuItem.Enabled = false;
            this.pastNodeToolStripMenuItem.Name = "pastNodeToolStripMenuItem";
            this.pastNodeToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.pastNodeToolStripMenuItem.Text = "انتقال یافتن به";
            this.pastNodeToolStripMenuItem.Click += new System.EventHandler(this.pastNodeToolStripMenuItem_Click);
            // 
            // reportPersonnelsFromCurrentRoleToolStripMenuItem
            // 
            this.reportPersonnelsFromCurrentRoleToolStripMenuItem.Name = "reportPersonnelsFromCurrentRoleToolStripMenuItem";
            this.reportPersonnelsFromCurrentRoleToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.reportPersonnelsFromCurrentRoleToolStripMenuItem.Text = "گزارش لیست پرسنل سمت جاری";
            this.reportPersonnelsFromCurrentRoleToolStripMenuItem.Click += new System.EventHandler(this.reportPersonnelsFromCurrentRoleToolStripMenuItem_Click);
            // 
            // rolesStructureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(856, 630);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "rolesStructureForm";
            this.ShowIcon = false;
            this.Text = "ساختار سازمانی";
            this.Load += new System.EventHandler(this.RolesStructureForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.organizationStructureVersionBindingSource)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ImageList imageListTree;
        private System.Windows.Forms.ImageList imageListControls;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TreeView rolesStructureTreeView;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button collapseAndExpandButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem cuteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pastNodeToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label activeOrganizationStructureVersionLabel;
        private System.Windows.Forms.ComboBox organizationStructureVersionComboBox;
        private System.Windows.Forms.Button selectOrganizationStructureVersionButton;
        private System.Windows.Forms.Label selectDepartmentVersionLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.BindingSource organizationStructureVersionBindingSource;
        private System.Windows.Forms.ToolStripMenuItem reportPersonnelsFromCurrentRoleToolStripMenuItem;
        private System.Windows.Forms.Button copyButton;
    }
}