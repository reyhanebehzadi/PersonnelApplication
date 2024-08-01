namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    partial class GetPersonelSubEmployeeDockForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.assignPersonnelsDataGridView = new System.Windows.Forms.DataGridView();
            this.getStructurePersonelsResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personnelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnelNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorParentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.personelNumberText = new System.Windows.Forms.TextBox();
            this.FullNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assignPersonnelsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getStructurePersonelsResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.assignPersonnelsDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.794326F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.20567F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(949, 705);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.FullNameText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.personelNumberText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(943, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
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
            this.departmentNameDataGridViewTextBoxColumn,
            this.majorDataGridViewTextBoxColumn,
            this.parentDataGridViewTextBoxColumn,
            this.majorParentIdDataGridViewTextBoxColumn});
            this.assignPersonnelsDataGridView.DataSource = this.getStructurePersonelsResultBindingSource;
            this.assignPersonnelsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assignPersonnelsDataGridView.Location = new System.Drawing.Point(3, 64);
            this.assignPersonnelsDataGridView.MultiSelect = false;
            this.assignPersonnelsDataGridView.Name = "assignPersonnelsDataGridView";
            this.assignPersonnelsDataGridView.ReadOnly = true;
            this.assignPersonnelsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.assignPersonnelsDataGridView.Size = new System.Drawing.Size(943, 638);
            this.assignPersonnelsDataGridView.TabIndex = 6;
            // 
            // getStructurePersonelsResultBindingSource
            // 
            this.getStructurePersonelsResultBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.GetStructurePersonelsResult);
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
            this.personnelNumberDataGridViewTextBoxColumn.HeaderText = "کد پرسنلی";
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
            // departmentNameDataGridViewTextBoxColumn
            // 
            this.departmentNameDataGridViewTextBoxColumn.DataPropertyName = "DepartmentName";
            this.departmentNameDataGridViewTextBoxColumn.HeaderText = "نام واحد";
            this.departmentNameDataGridViewTextBoxColumn.Name = "departmentNameDataGridViewTextBoxColumn";
            this.departmentNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.departmentNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // majorDataGridViewTextBoxColumn
            // 
            this.majorDataGridViewTextBoxColumn.DataPropertyName = "Major";
            this.majorDataGridViewTextBoxColumn.HeaderText = "سمت";
            this.majorDataGridViewTextBoxColumn.Name = "majorDataGridViewTextBoxColumn";
            this.majorDataGridViewTextBoxColumn.ReadOnly = true;
            this.majorDataGridViewTextBoxColumn.Width = 200;
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(871, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "کد پرسنلی:";
            // 
            // personelNumberText
            // 
            this.personelNumberText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.personelNumberText.Location = new System.Drawing.Point(774, 24);
            this.personelNumberText.Name = "personelNumberText";
            this.personelNumberText.Size = new System.Drawing.Size(91, 21);
            this.personelNumberText.TabIndex = 8;
            // 
            // FullNameText
            // 
            this.FullNameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameText.Location = new System.Drawing.Point(475, 24);
            this.FullNameText.Name = "FullNameText";
            this.FullNameText.Size = new System.Drawing.Size(194, 21);
            this.FullNameText.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(675, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "نام و نام خانوادگی:";
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(394, 22);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "جستجو";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // GetPersonelSubEmployeeDockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 705);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GetPersonelSubEmployeeDockForm";
            this.Text = "گزارش پرسنل بر اساس چارت سازمانی";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assignPersonnelsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getStructurePersonelsResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView assignPersonnelsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnelNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorParentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource getStructurePersonelsResultBindingSource;
        private System.Windows.Forms.TextBox FullNameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox personelNumberText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
    }
}