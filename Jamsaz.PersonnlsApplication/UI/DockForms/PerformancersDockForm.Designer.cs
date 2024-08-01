namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    partial class PerformancersDockForm
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
            this.personelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expertAssesmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.personelNumberText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fullNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.setPersonelOfExpertButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertAssesmentBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(945, 657);
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
            this.personelIDDataGridViewTextBoxColumn,
            this.departmentIdDataGridViewTextBoxColumn,
            this.sectionIdDataGridViewTextBoxColumn,
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4});
            this.dataGridView1.DataSource = this.expertAssesmentBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(939, 544);
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
            // personelIDDataGridViewTextBoxColumn
            // 
            this.personelIDDataGridViewTextBoxColumn.DataPropertyName = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.HeaderText = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.Name = "personelIDDataGridViewTextBoxColumn";
            this.personelIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.personelIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // departmentIdDataGridViewTextBoxColumn
            // 
            this.departmentIdDataGridViewTextBoxColumn.DataPropertyName = "DepartmentId";
            this.departmentIdDataGridViewTextBoxColumn.HeaderText = "DepartmentId";
            this.departmentIdDataGridViewTextBoxColumn.Name = "departmentIdDataGridViewTextBoxColumn";
            this.departmentIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.departmentIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // sectionIdDataGridViewTextBoxColumn
            // 
            this.sectionIdDataGridViewTextBoxColumn.DataPropertyName = "SectionId";
            this.sectionIdDataGridViewTextBoxColumn.HeaderText = "SectionId";
            this.sectionIdDataGridViewTextBoxColumn.Name = "sectionIdDataGridViewTextBoxColumn";
            this.sectionIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.sectionIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PersonelNumber";
            this.Column2.HeaderText = "شماره پرسنلی";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "FullName";
            this.Column1.HeaderText = "نام و نام خانوادگی";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DepartmentName";
            this.Column3.HeaderText = "واحد";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SectionName";
            this.Column4.HeaderText = "بخش";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // expertAssesmentBindingSource
            // 
            this.expertAssesmentBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.ExpertAssesment);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.personelNumberText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.fullNameText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(939, 52);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(403, 17);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "جستجو";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // personelNumberText
            // 
            this.personelNumberText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.personelNumberText.Location = new System.Drawing.Point(484, 19);
            this.personelNumberText.Name = "personelNumberText";
            this.personelNumberText.Size = new System.Drawing.Size(83, 21);
            this.personelNumberText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "شماره پرسنلی:";
            // 
            // fullNameText
            // 
            this.fullNameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fullNameText.Location = new System.Drawing.Point(678, 19);
            this.fullNameText.Name = "fullNameText";
            this.fullNameText.Size = new System.Drawing.Size(153, 21);
            this.fullNameText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(837, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام و نام خانوادگی:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deleteButton);
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Controls.Add(this.setPersonelOfExpertButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 611);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(939, 43);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.arrow_up;
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteButton.Location = new System.Drawing.Point(777, 13);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "حذف";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.arrow_down;
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addButton.Location = new System.Drawing.Point(858, 13);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "اضافه";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // setPersonelOfExpertButton
            // 
            this.setPersonelOfExpertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setPersonelOfExpertButton.Location = new System.Drawing.Point(9, 14);
            this.setPersonelOfExpertButton.Name = "setPersonelOfExpertButton";
            this.setPersonelOfExpertButton.Size = new System.Drawing.Size(75, 23);
            this.setPersonelOfExpertButton.TabIndex = 4;
            this.setPersonelOfExpertButton.Text = "تخصیص افراد";
            this.setPersonelOfExpertButton.UseVisualStyleBackColor = true;
            this.setPersonelOfExpertButton.Visible = false;
            this.setPersonelOfExpertButton.Click += new System.EventHandler(this.setPersonelOfExpertButton_Click);
            // 
            // PerformancersDockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 657);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PerformancersDockForm";
            this.Text = "کارشناسان ارزیابی";
            this.Load += new System.EventHandler(this.PerformancersDockForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expertAssesmentBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox personelNumberText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fullNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button setPersonelOfExpertButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.BindingSource expertAssesmentBindingSource;
    }
}