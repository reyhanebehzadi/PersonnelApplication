namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    partial class GetPersonelByStructuerDockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetPersonelByStructuerDockForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rolesStructureTreeView = new System.Windows.Forms.TreeView();
            this.imageListTree = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.assignPersonnelsDataGridView = new System.Windows.Forms.DataGridView();
            this.personnelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnelNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorParentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organisationStructurePersonnelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageListControls = new System.Windows.Forms.ImageList(this.components);
            this.allAssignOrganisationStructureForCurrentPersonnleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assignPersonnelsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organisationStructurePersonnelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allAssignOrganisationStructureForCurrentPersonnleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rolesStructureTreeView
            // 
            this.rolesStructureTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.rolesStructureTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rolesStructureTreeView.FullRowSelect = true;
            this.rolesStructureTreeView.HideSelection = false;
            this.rolesStructureTreeView.ImageIndex = 0;
            this.rolesStructureTreeView.ImageList = this.imageListTree;
            this.rolesStructureTreeView.Location = new System.Drawing.Point(3, 3);
            this.rolesStructureTreeView.Name = "rolesStructureTreeView";
            this.rolesStructureTreeView.RightToLeftLayout = true;
            this.rolesStructureTreeView.SelectedImageIndex = 5;
            this.rolesStructureTreeView.Size = new System.Drawing.Size(1197, 304);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.assignPersonnelsDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rolesStructureTreeView, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 310F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1203, 720);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // assignPersonnelsDataGridView
            // 
            this.assignPersonnelsDataGridView.AllowUserToAddRows = false;
            this.assignPersonnelsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.assignPersonnelsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.assignPersonnelsDataGridView.AutoGenerateColumns = false;
            this.assignPersonnelsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.assignPersonnelsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assignPersonnelsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personnelIDDataGridViewTextBoxColumn,
            this.personnelNumberDataGridViewTextBoxColumn,
            this.descriptorDataGridViewTextBoxColumn,
            this.majorIdDataGridViewTextBoxColumn,
            this.majorDataGridViewTextBoxColumn,
            this.departmentNameDataGridViewTextBoxColumn,
            this.parentDataGridViewTextBoxColumn,
            this.majorParentIdDataGridViewTextBoxColumn});
            this.assignPersonnelsDataGridView.DataSource = this.organisationStructurePersonnelBindingSource;
            this.assignPersonnelsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assignPersonnelsDataGridView.Location = new System.Drawing.Point(3, 313);
            this.assignPersonnelsDataGridView.MultiSelect = false;
            this.assignPersonnelsDataGridView.Name = "assignPersonnelsDataGridView";
            this.assignPersonnelsDataGridView.ReadOnly = true;
            this.assignPersonnelsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.assignPersonnelsDataGridView.Size = new System.Drawing.Size(1197, 404);
            this.assignPersonnelsDataGridView.TabIndex = 5;
            // 
            // personnelIDDataGridViewTextBoxColumn
            // 
            this.personnelIDDataGridViewTextBoxColumn.DataPropertyName = "PersonnelID";
            this.personnelIDDataGridViewTextBoxColumn.HeaderText = "PersonnelID";
            this.personnelIDDataGridViewTextBoxColumn.Name = "personnelIDDataGridViewTextBoxColumn";
            this.personnelIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.personnelIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // personnelNumberDataGridViewTextBoxColumn
            // 
            this.personnelNumberDataGridViewTextBoxColumn.DataPropertyName = "PersonnelNumber";
            this.personnelNumberDataGridViewTextBoxColumn.HeaderText = "شماره پرسنلی";
            this.personnelNumberDataGridViewTextBoxColumn.Name = "personnelNumberDataGridViewTextBoxColumn";
            this.personnelNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptorDataGridViewTextBoxColumn
            // 
            this.descriptorDataGridViewTextBoxColumn.DataPropertyName = "Descriptor";
            this.descriptorDataGridViewTextBoxColumn.HeaderText = "نام و نام خانوادگی";
            this.descriptorDataGridViewTextBoxColumn.Name = "descriptorDataGridViewTextBoxColumn";
            this.descriptorDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptorDataGridViewTextBoxColumn.Width = 200;
            // 
            // majorIdDataGridViewTextBoxColumn
            // 
            this.majorIdDataGridViewTextBoxColumn.DataPropertyName = "MajorId";
            this.majorIdDataGridViewTextBoxColumn.HeaderText = "MajorId";
            this.majorIdDataGridViewTextBoxColumn.Name = "majorIdDataGridViewTextBoxColumn";
            this.majorIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.majorIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // majorDataGridViewTextBoxColumn
            // 
            this.majorDataGridViewTextBoxColumn.DataPropertyName = "Major";
            this.majorDataGridViewTextBoxColumn.HeaderText = "سمت";
            this.majorDataGridViewTextBoxColumn.Name = "majorDataGridViewTextBoxColumn";
            this.majorDataGridViewTextBoxColumn.ReadOnly = true;
            this.majorDataGridViewTextBoxColumn.Width = 200;
            // 
            // departmentNameDataGridViewTextBoxColumn
            // 
            this.departmentNameDataGridViewTextBoxColumn.DataPropertyName = "DepartmentName";
            this.departmentNameDataGridViewTextBoxColumn.HeaderText = "نام واحد";
            this.departmentNameDataGridViewTextBoxColumn.Name = "departmentNameDataGridViewTextBoxColumn";
            this.departmentNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.departmentNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // parentDataGridViewTextBoxColumn
            // 
            this.parentDataGridViewTextBoxColumn.DataPropertyName = "Parent";
            this.parentDataGridViewTextBoxColumn.HeaderText = "Parent";
            this.parentDataGridViewTextBoxColumn.Name = "parentDataGridViewTextBoxColumn";
            this.parentDataGridViewTextBoxColumn.ReadOnly = true;
            this.parentDataGridViewTextBoxColumn.Visible = false;
            // 
            // majorParentIdDataGridViewTextBoxColumn
            // 
            this.majorParentIdDataGridViewTextBoxColumn.DataPropertyName = "MajorParentId";
            this.majorParentIdDataGridViewTextBoxColumn.HeaderText = "MajorParentId";
            this.majorParentIdDataGridViewTextBoxColumn.Name = "majorParentIdDataGridViewTextBoxColumn";
            this.majorParentIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.majorParentIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // organisationStructurePersonnelBindingSource
            // 
            this.organisationStructurePersonnelBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.GetAllStructurePersonelsResult);
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
            // allAssignOrganisationStructureForCurrentPersonnleBindingSource
            // 
            this.allAssignOrganisationStructureForCurrentPersonnleBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.OrganizationStructurePersonnel);
            // 
            // GetPersonelByStructuerDockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 720);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GetPersonelByStructuerDockForm";
            this.Text = "گزارش پرسنل بر اساس چارت سازمانی";
            this.Load += new System.EventHandler(this.GetPersonelByStructuerDockForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.assignPersonnelsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organisationStructurePersonnelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allAssignOrganisationStructureForCurrentPersonnleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource allAssignOrganisationStructureForCurrentPersonnleBindingSource;
        private System.Windows.Forms.BindingSource organisationStructurePersonnelBindingSource;
        private System.Windows.Forms.TreeView rolesStructureTreeView;
        private System.Windows.Forms.ImageList imageListTree;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ImageList imageListControls;
        private System.Windows.Forms.DataGridView assignPersonnelsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnelNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorParentIdDataGridViewTextBoxColumn;
    }
}