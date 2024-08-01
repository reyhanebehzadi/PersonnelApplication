namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class SelectPersonnelListDialogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectPersonnelListDialogForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.personnelDataGridView = new System.Windows.Forms.DataGridView();
            this.IsSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.familyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectAllCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.voidButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.increaseAmountTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personnelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.personnelDataGridView, -1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(463, 548);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // personnelDataGridView
            // 
            this.personnelDataGridView.AllowUserToAddRows = false;
            this.personnelDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.personnelDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.personnelDataGridView.AutoGenerateColumns = false;
            this.personnelDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.personnelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personnelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsSelect,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.personnelDataGridView.DataSource = this.personnelBindingSource;
            this.personnelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personnelDataGridView.Location = new System.Drawing.Point(3, 113);
            this.personnelDataGridView.Name = "personnelDataGridView";
            this.personnelDataGridView.Size = new System.Drawing.Size(457, 372);
            this.personnelDataGridView.TabIndex = 2;
            // 
            // IsSelect
            // 
            this.IsSelect.DataPropertyName = "IsSelect";
            this.IsSelect.HeaderText = "";
            this.IsSelect.Name = "IsSelect";
            this.IsSelect.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PersonnelNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "شماره پرسنلی";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn3.HeaderText = "نام";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn4.HeaderText = "نام خانوادگی";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // personnelBindingSource
            // 
            this.personnelBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.Personnel);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.increaseAmountTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.familyTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.selectAllCheckBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchButton.Location = new System.Drawing.Point(54, 18);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "جستجو";
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // familyTextBox
            // 
            this.familyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.familyTextBox.Location = new System.Drawing.Point(135, 20);
            this.familyTextBox.Name = "familyTextBox";
            this.familyTextBox.Size = new System.Drawing.Size(225, 21);
            this.familyTextBox.TabIndex = 4;
            this.familyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.familyTextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "پرسنل موردنظر :";
            // 
            // selectAllCheckBox
            // 
            this.selectAllCheckBox.AutoSize = true;
            this.selectAllCheckBox.Location = new System.Drawing.Point(334, 78);
            this.selectAllCheckBox.Name = "selectAllCheckBox";
            this.selectAllCheckBox.Size = new System.Drawing.Size(113, 17);
            this.selectAllCheckBox.TabIndex = 0;
            this.selectAllCheckBox.Text = "انتخاب همه پرسنل";
            this.selectAllCheckBox.UseVisualStyleBackColor = true;
            this.selectAllCheckBox.CheckedChanged += new System.EventHandler(this.selectAllCheckBox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.voidButton);
            this.groupBox2.Controls.Add(this.selectButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 491);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 54);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // voidButton
            // 
            this.voidButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.voidButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.voidButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.arrow_up;
            this.voidButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.voidButton.Location = new System.Drawing.Point(90, 20);
            this.voidButton.Name = "voidButton";
            this.voidButton.Size = new System.Drawing.Size(75, 23);
            this.voidButton.TabIndex = 3;
            this.voidButton.Text = "لغو";
            this.voidButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.voidButton.UseVisualStyleBackColor = true;
            this.voidButton.Click += new System.EventHandler(this.voidButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.arrow_down;
            this.selectButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.selectButton.Location = new System.Drawing.Point(9, 20);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 2;
            this.selectButton.Text = "انتخاب";
            this.selectButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "میزان افزایش:";
            // 
            // increaseAmountTextBox
            // 
            this.increaseAmountTextBox.Location = new System.Drawing.Point(260, 51);
            this.increaseAmountTextBox.Name = "increaseAmountTextBox";
            this.increaseAmountTextBox.Size = new System.Drawing.Size(100, 21);
            this.increaseAmountTextBox.TabIndex = 7;
            // 
            // SelectPersonnelListDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 548);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SelectPersonnelListDialogForm";
            this.Text = "لیست پرسنل";
            this.Load += new System.EventHandler(this.SelectPersonnelListDialogForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personnelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView personnelDataGridView;
        private System.Windows.Forms.BindingSource personnelBindingSource;
        private System.Windows.Forms.CheckBox selectAllCheckBox;
        private System.Windows.Forms.Button voidButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox familyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox increaseAmountTextBox;
        private System.Windows.Forms.Label label2;
    }
}