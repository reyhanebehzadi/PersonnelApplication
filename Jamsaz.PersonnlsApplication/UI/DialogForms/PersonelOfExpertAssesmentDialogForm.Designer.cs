namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class PersonelOfExpertAssesmentDialogForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expertIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expertAssesmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelOfExpertAsseementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.expertDepartmentText = new System.Windows.Forms.TextBox();
            this.expertNumberText = new System.Windows.Forms.TextBox();
            this.expertFullNameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.personelNumberText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fullNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelOfExpertAsseementBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.80223F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.19777F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(724, 683);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.expertIDDataGridViewTextBoxColumn,
            this.personelIDDataGridViewTextBoxColumn,
            this.sectionIDDataGridViewTextBoxColumn,
            this.PersonelNumber,
            this.departmentDataGridViewTextBoxColumn,
            this.expertAssesmentDataGridViewTextBoxColumn,
            this.personnelDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.departmentNameDataGridViewTextBoxColumn,
            this.sectionNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personelOfExpertAsseementBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(718, 547);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // expertIDDataGridViewTextBoxColumn
            // 
            this.expertIDDataGridViewTextBoxColumn.DataPropertyName = "ExpertID";
            this.expertIDDataGridViewTextBoxColumn.HeaderText = "ExpertID";
            this.expertIDDataGridViewTextBoxColumn.Name = "expertIDDataGridViewTextBoxColumn";
            this.expertIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.expertIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // personelIDDataGridViewTextBoxColumn
            // 
            this.personelIDDataGridViewTextBoxColumn.DataPropertyName = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.HeaderText = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.Name = "personelIDDataGridViewTextBoxColumn";
            this.personelIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.personelIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // sectionIDDataGridViewTextBoxColumn
            // 
            this.sectionIDDataGridViewTextBoxColumn.DataPropertyName = "SectionID";
            this.sectionIDDataGridViewTextBoxColumn.HeaderText = "SectionID";
            this.sectionIDDataGridViewTextBoxColumn.Name = "sectionIDDataGridViewTextBoxColumn";
            this.sectionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sectionIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // PersonelNumber
            // 
            this.PersonelNumber.DataPropertyName = "PersonelNumber";
            this.PersonelNumber.HeaderText = "شماره پرسنلی";
            this.PersonelNumber.Name = "PersonelNumber";
            this.PersonelNumber.ReadOnly = true;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
            this.departmentDataGridViewTextBoxColumn.Visible = false;
            // 
            // expertAssesmentDataGridViewTextBoxColumn
            // 
            this.expertAssesmentDataGridViewTextBoxColumn.DataPropertyName = "ExpertAssesment";
            this.expertAssesmentDataGridViewTextBoxColumn.HeaderText = "ExpertAssesment";
            this.expertAssesmentDataGridViewTextBoxColumn.Name = "expertAssesmentDataGridViewTextBoxColumn";
            this.expertAssesmentDataGridViewTextBoxColumn.ReadOnly = true;
            this.expertAssesmentDataGridViewTextBoxColumn.Visible = false;
            // 
            // personnelDataGridViewTextBoxColumn
            // 
            this.personnelDataGridViewTextBoxColumn.DataPropertyName = "Personnel";
            this.personnelDataGridViewTextBoxColumn.HeaderText = "Personnel";
            this.personnelDataGridViewTextBoxColumn.Name = "personnelDataGridViewTextBoxColumn";
            this.personnelDataGridViewTextBoxColumn.ReadOnly = true;
            this.personnelDataGridViewTextBoxColumn.Visible = false;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "نام و نام خانوادگی";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // departmentNameDataGridViewTextBoxColumn
            // 
            this.departmentNameDataGridViewTextBoxColumn.DataPropertyName = "DepartmentName";
            this.departmentNameDataGridViewTextBoxColumn.HeaderText = "نام واحد";
            this.departmentNameDataGridViewTextBoxColumn.Name = "departmentNameDataGridViewTextBoxColumn";
            this.departmentNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.departmentNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // sectionNameDataGridViewTextBoxColumn
            // 
            this.sectionNameDataGridViewTextBoxColumn.DataPropertyName = "SectionName";
            this.sectionNameDataGridViewTextBoxColumn.HeaderText = "نام بخش";
            this.sectionNameDataGridViewTextBoxColumn.Name = "sectionNameDataGridViewTextBoxColumn";
            this.sectionNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.sectionNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // personelOfExpertAsseementBindingSource
            // 
            this.personelOfExpertAsseementBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.PersonelOfExpertAsseement);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.expertDepartmentText);
            this.groupBox1.Controls.Add(this.expertNumberText);
            this.groupBox1.Controls.Add(this.expertFullNameText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.personelNumberText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.fullNameText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 68);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // expertDepartmentText
            // 
            this.expertDepartmentText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.expertDepartmentText.Location = new System.Drawing.Point(186, 14);
            this.expertDepartmentText.Name = "expertDepartmentText";
            this.expertDepartmentText.ReadOnly = true;
            this.expertDepartmentText.Size = new System.Drawing.Size(169, 21);
            this.expertDepartmentText.TabIndex = 12;
            // 
            // expertNumberText
            // 
            this.expertNumberText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.expertNumberText.Location = new System.Drawing.Point(547, 14);
            this.expertNumberText.Name = "expertNumberText";
            this.expertNumberText.ReadOnly = true;
            this.expertNumberText.Size = new System.Drawing.Size(67, 21);
            this.expertNumberText.TabIndex = 11;
            // 
            // expertFullNameText
            // 
            this.expertFullNameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.expertFullNameText.Location = new System.Drawing.Point(361, 14);
            this.expertFullNameText.Name = "expertFullNameText";
            this.expertFullNameText.ReadOnly = true;
            this.expertFullNameText.Size = new System.Drawing.Size(180, 21);
            this.expertFullNameText.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(620, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "پرسنل مربوط به :";
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(186, 39);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "جستجو";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // personelNumberText
            // 
            this.personelNumberText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.personelNumberText.Location = new System.Drawing.Point(267, 41);
            this.personelNumberText.Name = "personelNumberText";
            this.personelNumberText.Size = new System.Drawing.Size(83, 21);
            this.personelNumberText.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "شماره پرسنلی:";
            // 
            // fullNameText
            // 
            this.fullNameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fullNameText.Location = new System.Drawing.Point(461, 41);
            this.fullNameText.Name = "fullNameText";
            this.fullNameText.Size = new System.Drawing.Size(153, 21);
            this.fullNameText.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(620, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "نام و نام خانوادگی:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cancelButton);
            this.groupBox2.Controls.Add(this.deleteButton);
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 630);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(718, 50);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(472, 18);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "انصراف";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(553, 18);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "حذف";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(634, 18);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "اضافه";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // PersonelOfExpertAssesmentDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 683);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PersonelOfExpertAssesmentDialogForm";
            this.Text = "تخصیص پرسنل به کارشناس ارزیابی";
            this.Load += new System.EventHandler(this.PersonelOfExpertAssesmentDialogForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelOfExpertAsseementBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox personelNumberText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fullNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expertIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expertAssesmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource personelOfExpertAsseementBindingSource;
        private System.Windows.Forms.TextBox expertDepartmentText;
        private System.Windows.Forms.TextBox expertNumberText;
        private System.Windows.Forms.TextBox expertFullNameText;
        private System.Windows.Forms.Label label3;
    }
}