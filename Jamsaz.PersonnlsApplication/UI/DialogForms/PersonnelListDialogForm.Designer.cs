namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class PersonnelListDialogForm
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
            this.selectChildDepartmentsPersonnelResultDataGridView = new System.Windows.Forms.DataGridView();
            this.selectChildDepartmentsPersonnelResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectAllCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectChildDepartmentsPersonnelResultDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectChildDepartmentsPersonnelResultBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.selectChildDepartmentsPersonnelResultDataGridView, -1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(466, 528);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // selectChildDepartmentsPersonnelResultDataGridView
            // 
            this.selectChildDepartmentsPersonnelResultDataGridView.AllowUserToAddRows = false;
            this.selectChildDepartmentsPersonnelResultDataGridView.AllowUserToDeleteRows = false;
            this.selectChildDepartmentsPersonnelResultDataGridView.AutoGenerateColumns = false;
            this.selectChildDepartmentsPersonnelResultDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.selectChildDepartmentsPersonnelResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectChildDepartmentsPersonnelResultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.selectChildDepartmentsPersonnelResultDataGridView.DataSource = this.selectChildDepartmentsPersonnelResultBindingSource;
            this.selectChildDepartmentsPersonnelResultDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectChildDepartmentsPersonnelResultDataGridView.Location = new System.Drawing.Point(3, 63);
            this.selectChildDepartmentsPersonnelResultDataGridView.Name = "selectChildDepartmentsPersonnelResultDataGridView";
            this.selectChildDepartmentsPersonnelResultDataGridView.Size = new System.Drawing.Size(460, 402);
            this.selectChildDepartmentsPersonnelResultDataGridView.TabIndex = 2;
            // 
            // selectChildDepartmentsPersonnelResultBindingSource
            // 
            this.selectChildDepartmentsPersonnelResultBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.SelectChildDepartmentsPersonnelResult);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectAllCheckBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // selectAllCheckBox
            // 
            this.selectAllCheckBox.AutoSize = true;
            this.selectAllCheckBox.Location = new System.Drawing.Point(300, 20);
            this.selectAllCheckBox.Name = "selectAllCheckBox";
            this.selectAllCheckBox.Size = new System.Drawing.Size(137, 17);
            this.selectAllCheckBox.TabIndex = 0;
            this.selectAllCheckBox.Text = "انتخاب همه پرسنل واحد";
            this.selectAllCheckBox.UseVisualStyleBackColor = true;
            this.selectAllCheckBox.CheckedChanged += new System.EventHandler(this.selectAllCheckBox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cancelButton);
            this.groupBox2.Controls.Add(this.okButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 471);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 54);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(90, 20);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "لغو";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(9, 20);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "تایید";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IsSelected";
            this.dataGridViewTextBoxColumn5.HeaderText = "انتخاب";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PersonnelNumber";
            this.dataGridViewTextBoxColumn3.HeaderText = "ش پرسنلی";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 90;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn2.HeaderText = "نام پرسنل";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Position";
            this.dataGridViewTextBoxColumn4.HeaderText = "سمت شغلی";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 155;
            // 
            // PersonnelListDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 528);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PersonnelListDialogForm";
            this.Text = "لیست پرسنل";
            this.Load += new System.EventHandler(this.PersonnelListDialogForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.selectChildDepartmentsPersonnelResultDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectChildDepartmentsPersonnelResultBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView selectChildDepartmentsPersonnelResultDataGridView;
        private System.Windows.Forms.BindingSource selectChildDepartmentsPersonnelResultBindingSource;
        private System.Windows.Forms.CheckBox selectAllCheckBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}