namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class RolesStructureDialogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RolesStructureDialogForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.activeOrganizationStructureVersionLabel = new System.Windows.Forms.Label();
            this.organizationStructureVersionComboBox = new System.Windows.Forms.ComboBox();
            this.organizationStructureVersionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectOrganizationStructureVersionButton = new System.Windows.Forms.Button();
            this.selectDepartmentVersionLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.imageListControls = new System.Windows.Forms.ImageList(this.components);
            this.nextButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.passNullCheckBox = new System.Windows.Forms.CheckBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.collapseAndExpandButton = new System.Windows.Forms.Button();
            this.rolesStructuretreeView = new System.Windows.Forms.TreeView();
            this.imageListTree = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.organizationStructureVersionBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.rolesStructuretreeView, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(666, 497);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.groupBox1.Controls.Add(this.activeOrganizationStructureVersionLabel);
            this.groupBox1.Controls.Add(this.organizationStructureVersionComboBox);
            this.groupBox1.Controls.Add(this.selectOrganizationStructureVersionButton);
            this.groupBox1.Controls.Add(this.selectDepartmentVersionLabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.SearchButton);
            this.groupBox1.Controls.Add(this.nextButton);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 73);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // activeOrganizationStructureVersionLabel
            // 
            this.activeOrganizationStructureVersionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.activeOrganizationStructureVersionLabel.AutoSize = true;
            this.activeOrganizationStructureVersionLabel.BackColor = System.Drawing.Color.SandyBrown;
            this.activeOrganizationStructureVersionLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.activeOrganizationStructureVersionLabel.ForeColor = System.Drawing.Color.Black;
            this.activeOrganizationStructureVersionLabel.Location = new System.Drawing.Point(117, 51);
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
            this.organizationStructureVersionComboBox.Location = new System.Drawing.Point(436, 47);
            this.organizationStructureVersionComboBox.Name = "organizationStructureVersionComboBox";
            this.organizationStructureVersionComboBox.Size = new System.Drawing.Size(115, 21);
            this.organizationStructureVersionComboBox.TabIndex = 28;
            this.organizationStructureVersionComboBox.ValueMember = "ID";
            // 
            // organizationStructureVersionBindingSource
            // 
            this.organizationStructureVersionBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.OrganizationStructureVersion);
            // 
            // selectOrganizationStructureVersionButton
            // 
            this.selectOrganizationStructureVersionButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.selectOrganizationStructureVersionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.selectOrganizationStructureVersionButton.Location = new System.Drawing.Point(347, 47);
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
            this.selectDepartmentVersionLabel.Location = new System.Drawing.Point(556, 53);
            this.selectDepartmentVersionLabel.Name = "selectDepartmentVersionLabel";
            this.selectDepartmentVersionLabel.Size = new System.Drawing.Size(67, 13);
            this.selectDepartmentVersionLabel.TabIndex = 29;
            this.selectDepartmentVersionLabel.Text = "انتخاب نسخه";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nameTextBox.Location = new System.Drawing.Point(347, 11);
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
            this.SearchButton.Location = new System.Drawing.Point(258, 10);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(84, 21);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "جستجو";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
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
            // nextButton
            // 
            this.nextButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nextButton.Enabled = false;
            this.nextButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nextButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nextButton.ImageIndex = 5;
            this.nextButton.ImageList = this.imageListControls;
            this.nextButton.Location = new System.Drawing.Point(169, 10);
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
            this.nameLabel.Location = new System.Drawing.Point(555, 14);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(99, 13);
            this.nameLabel.TabIndex = 23;
            this.nameLabel.Text = "جستجو براساس نام";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.passNullCheckBox);
            this.groupBox2.Controls.Add(this.cancelButton);
            this.groupBox2.Controls.Add(this.selectButton);
            this.groupBox2.Controls.Add(this.collapseAndExpandButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 440);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 54);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // passNullCheckBox
            // 
            this.passNullCheckBox.AutoSize = true;
            this.passNullCheckBox.Location = new System.Drawing.Point(392, 23);
            this.passNullCheckBox.Name = "passNullCheckBox";
            this.passNullCheckBox.Size = new System.Drawing.Size(79, 17);
            this.passNullCheckBox.TabIndex = 12;
            this.passNullCheckBox.Text = "بدون انتخاب";
            this.passNullCheckBox.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(490, 20);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "لغو";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectButton.Location = new System.Drawing.Point(571, 20);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 10;
            this.selectButton.Text = "انتخاب";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // collapseAndExpandButton
            // 
            this.collapseAndExpandButton.Location = new System.Drawing.Point(9, 17);
            this.collapseAndExpandButton.Name = "collapseAndExpandButton";
            this.collapseAndExpandButton.Size = new System.Drawing.Size(75, 23);
            this.collapseAndExpandButton.TabIndex = 9;
            this.collapseAndExpandButton.Text = "جمع کردن";
            this.collapseAndExpandButton.UseVisualStyleBackColor = true;
            this.collapseAndExpandButton.Click += new System.EventHandler(this.collapseAndExpandButton_Click);
            // 
            // rolesStructuretreeView
            // 
            this.rolesStructuretreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.rolesStructuretreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rolesStructuretreeView.HideSelection = false;
            this.rolesStructuretreeView.HotTracking = true;
            this.rolesStructuretreeView.ImageIndex = 0;
            this.rolesStructuretreeView.ImageList = this.imageListTree;
            this.rolesStructuretreeView.Location = new System.Drawing.Point(3, 88);
            this.rolesStructuretreeView.Name = "rolesStructuretreeView";
            this.rolesStructuretreeView.RightToLeftLayout = true;
            this.rolesStructuretreeView.SelectedImageIndex = 5;
            this.rolesStructuretreeView.Size = new System.Drawing.Size(660, 346);
            this.rolesStructuretreeView.TabIndex = 31;
            this.rolesStructuretreeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rolesStructuretreeView_MouseDown);
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
            // RolesStructureDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 497);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RolesStructureDialogForm";
            this.ShowIcon = false;
            this.Text = "ساختار سازمانی";
            this.Load += new System.EventHandler(this.RolesStructureDialogForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.organizationStructureVersionBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label activeOrganizationStructureVersionLabel;
        private System.Windows.Forms.ComboBox organizationStructureVersionComboBox;
        private System.Windows.Forms.Button selectOrganizationStructureVersionButton;
        private System.Windows.Forms.Label selectDepartmentVersionLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox passNullCheckBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button collapseAndExpandButton;
        private System.Windows.Forms.TreeView rolesStructuretreeView;
        private System.Windows.Forms.BindingSource organizationStructureVersionBindingSource;
        private System.Windows.Forms.ImageList imageListControls;
        private System.Windows.Forms.ImageList imageListTree;
    }
}