namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    partial class MissionAndLeaveDockForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.treeView = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.departmentApprovalCategoryPersonnelDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReplacementPersonnelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReplacementPersonnel2Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.departmentApprovalCategoryPersonnelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lowestButton = new System.Windows.Forms.Button();
            this.lowerbutton = new System.Windows.Forms.Button();
            this.upperButton = new System.Windows.Forms.Button();
            this.topButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentApprovalCategoryPersonnelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentApprovalCategoryPersonnelBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel1.Controls.Add(this.treeView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(218)))), ((int)(((byte)(254)))));
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(503, 3);
            this.treeView.Name = "treeView";
            this.treeView.RightToLeftLayout = true;
            this.treeView.Size = new System.Drawing.Size(294, 444);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 444);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تایید کنندگان";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(488, 424);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoScroll = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel3.Controls.Add(this.departmentApprovalCategoryPersonnelDataGridView, -1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(482, 368);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // departmentApprovalCategoryPersonnelDataGridView
            // 
            this.departmentApprovalCategoryPersonnelDataGridView.AllowUserToAddRows = false;
            this.departmentApprovalCategoryPersonnelDataGridView.AllowUserToDeleteRows = false;
            this.departmentApprovalCategoryPersonnelDataGridView.AutoGenerateColumns = false;
            this.departmentApprovalCategoryPersonnelDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(218)))), ((int)(((byte)(254)))));
            this.departmentApprovalCategoryPersonnelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departmentApprovalCategoryPersonnelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn1,
            this.ReplacementPersonnelName,
            this.ReplacementPersonnel2Name,
            this.dataGridViewTextBoxColumn6});
            this.departmentApprovalCategoryPersonnelDataGridView.DataSource = this.departmentApprovalCategoryPersonnelBindingSource;
            this.departmentApprovalCategoryPersonnelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departmentApprovalCategoryPersonnelDataGridView.Location = new System.Drawing.Point(123, 3);
            this.departmentApprovalCategoryPersonnelDataGridView.Name = "departmentApprovalCategoryPersonnelDataGridView";
            this.departmentApprovalCategoryPersonnelDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.departmentApprovalCategoryPersonnelDataGridView.Size = new System.Drawing.Size(356, 362);
            this.departmentApprovalCategoryPersonnelDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Order";
            this.dataGridViewTextBoxColumn5.HeaderText = "الویت";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PersonnelName";
            this.dataGridViewTextBoxColumn1.HeaderText = "نام پرسنل";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // ReplacementPersonnelName
            // 
            this.ReplacementPersonnelName.DataPropertyName = "ReplacementPersonnelName";
            this.ReplacementPersonnelName.HeaderText = "جانشین اول";
            this.ReplacementPersonnelName.Name = "ReplacementPersonnelName";
            this.ReplacementPersonnelName.ReadOnly = true;
            // 
            // ReplacementPersonnel2Name
            // 
            this.ReplacementPersonnel2Name.DataPropertyName = "ReplacementPersonnel2Name";
            this.ReplacementPersonnel2Name.HeaderText = "جانشین دوم";
            this.ReplacementPersonnel2Name.Name = "ReplacementPersonnel2Name";
            this.ReplacementPersonnel2Name.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IsAllow";
            this.dataGridViewTextBoxColumn6.HeaderText = "دسترسی";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // departmentApprovalCategoryPersonnelBindingSource
            // 
            this.departmentApprovalCategoryPersonnelBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.DepartmentApprovalCategoryPersonnel);
            this.departmentApprovalCategoryPersonnelBindingSource.PositionChanged += new System.EventHandler(this.departmentApprovalCategoryPersonnelBindingSource_PositionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lowestButton);
            this.panel1.Controls.Add(this.lowerbutton);
            this.panel1.Controls.Add(this.upperButton);
            this.panel1.Controls.Add(this.topButton);
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 362);
            this.panel1.TabIndex = 1;
            // 
            // lowestButton
            // 
            this.lowestButton.Location = new System.Drawing.Point(20, 270);
            this.lowestButton.Name = "lowestButton";
            this.lowestButton.Size = new System.Drawing.Size(75, 23);
            this.lowestButton.TabIndex = 6;
            this.lowestButton.Text = "پایین ترین";
            this.lowestButton.UseVisualStyleBackColor = true;
            this.lowestButton.Click += new System.EventHandler(this.lowestButton_Click);
            // 
            // lowerbutton
            // 
            this.lowerbutton.Location = new System.Drawing.Point(20, 241);
            this.lowerbutton.Name = "lowerbutton";
            this.lowerbutton.Size = new System.Drawing.Size(75, 23);
            this.lowerbutton.TabIndex = 5;
            this.lowerbutton.Text = "پایین تر";
            this.lowerbutton.UseVisualStyleBackColor = true;
            this.lowerbutton.Click += new System.EventHandler(this.lowerbutton_Click);
            // 
            // upperButton
            // 
            this.upperButton.Location = new System.Drawing.Point(20, 212);
            this.upperButton.Name = "upperButton";
            this.upperButton.Size = new System.Drawing.Size(75, 23);
            this.upperButton.TabIndex = 4;
            this.upperButton.Text = "بالاتر";
            this.upperButton.UseVisualStyleBackColor = true;
            this.upperButton.Click += new System.EventHandler(this.upperButton_Click);
            // 
            // topButton
            // 
            this.topButton.Location = new System.Drawing.Point(20, 183);
            this.topButton.Name = "topButton";
            this.topButton.Size = new System.Drawing.Size(75, 23);
            this.topButton.TabIndex = 3;
            this.topButton.Text = "بالاترین";
            this.topButton.UseVisualStyleBackColor = true;
            this.topButton.Click += new System.EventHandler(this.topButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(20, 122);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "حذف";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(20, 93);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "ویرایش";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(20, 64);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "اضافه";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.saveButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 377);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(482, 44);
            this.panel2.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(387, 10);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "ذخیره";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // MissionAndLeaveDockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(218)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MissionAndLeaveDockForm";
            this.ShowIcon = false;
            this.Text = "طبقه بندی واحدهای سازمانی براساس روند تایید مرخصی ";
            this.Load += new System.EventHandler(this.MissionAndLeaveDockForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.departmentApprovalCategoryPersonnelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentApprovalCategoryPersonnelBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView departmentApprovalCategoryPersonnelDataGridView;
        private System.Windows.Forms.BindingSource departmentApprovalCategoryPersonnelBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button lowestButton;
        private System.Windows.Forms.Button lowerbutton;
        private System.Windows.Forms.Button upperButton;
        private System.Windows.Forms.Button topButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReplacementPersonnelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReplacementPersonnel2Name;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn6;
    }
}