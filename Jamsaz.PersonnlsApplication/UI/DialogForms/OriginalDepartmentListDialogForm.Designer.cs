namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class OriginalDepartmentListDialogForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.searchAllButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.departmentNameLabel = new System.Windows.Forms.Label();
            this.selectButton = new System.Windows.Forms.Button();
            this.voidButton = new System.Windows.Forms.Button();
            this.getOriginalDepartmentsResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enghlishNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getOriginalDepartmentsResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.enghlishNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.getOriginalDepartmentsResultBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(473, 432);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.searchAllButton);
            this.groupBox.Controls.Add(this.searchButton);
            this.groupBox.Controls.Add(this.departmentTextBox);
            this.groupBox.Controls.Add(this.departmentNameLabel);
            this.groupBox.Location = new System.Drawing.Point(1, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(473, 53);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "جستجو ";
            // 
            // searchAllButton
            // 
            this.searchAllButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.SearchAll;
            this.searchAllButton.Location = new System.Drawing.Point(6, 17);
            this.searchAllButton.Name = "searchAllButton";
            this.searchAllButton.Size = new System.Drawing.Size(31, 23);
            this.searchAllButton.TabIndex = 3;
            this.searchAllButton.UseVisualStyleBackColor = true;
            this.searchAllButton.Click += new System.EventHandler(this.searchAllButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(39, 18);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "جستجو";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentTextBox.Location = new System.Drawing.Point(120, 20);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(284, 21);
            this.departmentTextBox.TabIndex = 1;
            this.departmentTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.departmentTextBox_KeyPress);
            // 
            // departmentNameLabel
            // 
            this.departmentNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentNameLabel.AutoSize = true;
            this.departmentNameLabel.Location = new System.Drawing.Point(410, 25);
            this.departmentNameLabel.Name = "departmentNameLabel";
            this.departmentNameLabel.Size = new System.Drawing.Size(44, 13);
            this.departmentNameLabel.TabIndex = 0;
            this.departmentNameLabel.Text = "نام واحد";
            // 
            // selectButton
            // 
            this.selectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectButton.Location = new System.Drawing.Point(399, 497);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 2;
            this.selectButton.Text = "انتخاب";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // voidButton
            // 
            this.voidButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.voidButton.Location = new System.Drawing.Point(318, 497);
            this.voidButton.Name = "voidButton";
            this.voidButton.Size = new System.Drawing.Size(75, 23);
            this.voidButton.TabIndex = 3;
            this.voidButton.Text = "لغو";
            this.voidButton.UseVisualStyleBackColor = true;
            this.voidButton.Click += new System.EventHandler(this.voidButton_Click);
            // 
            // getOriginalDepartmentsResultBindingSource
            // 
            this.getOriginalDepartmentsResultBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.GetOriginalDepartmentsResult);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "کد";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeDataGridViewTextBoxColumn.Width = 70;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "نام ";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 225;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // enghlishNameDataGridViewTextBoxColumn
            // 
            this.enghlishNameDataGridViewTextBoxColumn.DataPropertyName = "EnghlishName";
            this.enghlishNameDataGridViewTextBoxColumn.HeaderText = "نام لاتین";
            this.enghlishNameDataGridViewTextBoxColumn.Name = "enghlishNameDataGridViewTextBoxColumn";
            this.enghlishNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.enghlishNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // OriginalDepartmentListDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 532);
            this.Controls.Add(this.voidButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OriginalDepartmentListDialogForm";
            this.Text = "لیست واحد های سازمانی اصلی";
            this.Load += new System.EventHandler(this.OriginalDepartmentListDialogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getOriginalDepartmentsResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.Label departmentNameLabel;
        private System.Windows.Forms.Button searchAllButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button voidButton;
        private System.Windows.Forms.BindingSource getOriginalDepartmentsResultBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enghlishNameDataGridViewTextBoxColumn;
    }
}