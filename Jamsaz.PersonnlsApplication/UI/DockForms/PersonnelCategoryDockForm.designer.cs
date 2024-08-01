namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    partial class PersonnelCategoryDockForm
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
            this.personnelCategoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnelCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.showButton = new System.Windows.Forms.Button();
            this.activityDepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.acivityDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.shiftComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.shiftTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personnelCategoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelCategoryBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acivityDepartmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.personnelCategoryDataGridView, -1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(904, 442);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // personnelCategoryDataGridView
            // 
            this.personnelCategoryDataGridView.AllowUserToAddRows = false;
            this.personnelCategoryDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.personnelCategoryDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.personnelCategoryDataGridView.AutoGenerateColumns = false;
            this.personnelCategoryDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.personnelCategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personnelCategoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10});
            this.personnelCategoryDataGridView.DataSource = this.personnelCategoryBindingSource;
            this.personnelCategoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personnelCategoryDataGridView.Location = new System.Drawing.Point(3, 53);
            this.personnelCategoryDataGridView.Name = "personnelCategoryDataGridView";
            this.personnelCategoryDataGridView.ReadOnly = true;
            this.personnelCategoryDataGridView.Size = new System.Drawing.Size(898, 386);
            this.personnelCategoryDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "PersonnelNumber";
            this.dataGridViewTextBoxColumn9.HeaderText = "شماره پرسنل";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PersonnelName";
            this.dataGridViewTextBoxColumn8.HeaderText = "نام پرسنل";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 300;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ActivityDepartmentName";
            this.dataGridViewTextBoxColumn10.HeaderText = "نام بخش";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 180;
            // 
            // personnelCategoryBindingSource
            // 
            this.personnelCategoryBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.PersonnelCategory);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.showButton);
            this.groupBox1.Controls.Add(this.activityDepartmentComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.shiftComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.shiftTypeComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(898, 44);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(9, 15);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 6;
            this.showButton.Text = "نمایش";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // activityDepartmentComboBox
            // 
            this.activityDepartmentComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.activityDepartmentComboBox.DataSource = this.acivityDepartmentBindingSource;
            this.activityDepartmentComboBox.DisplayMember = "Name";
            this.activityDepartmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activityDepartmentComboBox.FormattingEnabled = true;
            this.activityDepartmentComboBox.Location = new System.Drawing.Point(322, 18);
            this.activityDepartmentComboBox.Name = "activityDepartmentComboBox";
            this.activityDepartmentComboBox.Size = new System.Drawing.Size(155, 21);
            this.activityDepartmentComboBox.TabIndex = 5;
            this.activityDepartmentComboBox.ValueMember = "ID";
            this.activityDepartmentComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // acivityDepartmentBindingSource
            // 
            this.acivityDepartmentBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.AcivityDepartment);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "واحد";
            // 
            // shiftComboBox
            // 
            this.shiftComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shiftComboBox.DisplayMember = "Name";
            this.shiftComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shiftComboBox.FormattingEnabled = true;
            this.shiftComboBox.Location = new System.Drawing.Point(528, 17);
            this.shiftComboBox.Name = "shiftComboBox";
            this.shiftComboBox.Size = new System.Drawing.Size(121, 21);
            this.shiftComboBox.TabIndex = 3;
            this.shiftComboBox.ValueMember = "ID";
            this.shiftComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(655, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "شیفت";
            // 
            // shiftTypeComboBox
            // 
            this.shiftTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shiftTypeComboBox.DisplayMember = "ToString";
            this.shiftTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shiftTypeComboBox.FormattingEnabled = true;
            this.shiftTypeComboBox.Location = new System.Drawing.Point(705, 17);
            this.shiftTypeComboBox.Name = "shiftTypeComboBox";
            this.shiftTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.shiftTypeComboBox.TabIndex = 1;
            this.shiftTypeComboBox.ValueMember = "intValue";
            this.shiftTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(832, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "نوع شیفت";
            // 
            // PersonnelCategoryDockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 442);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PersonnelCategoryDockForm";
            this.Text = "گروه بندی پرسنل";
            this.Load += new System.EventHandler(this.PersonnelCategoryDockForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personnelCategoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelCategoryBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acivityDepartmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource personnelCategoryBindingSource;
        private System.Windows.Forms.DataGridView personnelCategoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.ComboBox activityDepartmentComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox shiftComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox shiftTypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource acivityDepartmentBindingSource;
        private System.Windows.Forms.Button showButton;
    }
}