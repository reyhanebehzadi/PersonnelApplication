namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class AllPersonnelListDialogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllPersonnelListDialogForm));
            this.personnelDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.familyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.voidButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.activeRadioButton = new System.Windows.Forms.RadioButton();
            this.inactiveRadioButton = new System.Windows.Forms.RadioButton();
            this.allRadioButton = new System.Windows.Forms.RadioButton();
            this.personnelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IsSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.personnelDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // personnelDataGridView
            // 
            this.personnelDataGridView.AllowUserToAddRows = false;
            this.personnelDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            this.personnelDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.personnelDataGridView.AutoGenerateColumns = false;
            this.personnelDataGridView.BackgroundColor = System.Drawing.Color.LightBlue;
            this.personnelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personnelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsSelect,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.personnelDataGridView.DataSource = this.personnelBindingSource;
            this.personnelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personnelDataGridView.Location = new System.Drawing.Point(3, 73);
            this.personnelDataGridView.Name = "personnelDataGridView";
            this.personnelDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.personnelDataGridView.Size = new System.Drawing.Size(589, 369);
            this.personnelDataGridView.TabIndex = 1;
            this.personnelDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.personnelDataGridView_CellFormatting);
            this.personnelDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.personnelDataGridView_ColumnHeaderMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.familyTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو";
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchButton.Location = new System.Drawing.Point(9, 26);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "جستجو";
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // familyTextBox
            // 
            this.familyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.familyTextBox.Location = new System.Drawing.Point(330, 26);
            this.familyTextBox.Name = "familyTextBox";
            this.familyTextBox.Size = new System.Drawing.Size(153, 21);
            this.familyTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "پرسنل موردنظر :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.voidButton);
            this.groupBox2.Controls.Add(this.selectButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 448);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(589, 54);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // voidButton
            // 
            this.voidButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.voidButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.voidButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.arrow_up;
            this.voidButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.voidButton.Location = new System.Drawing.Point(87, 20);
            this.voidButton.Name = "voidButton";
            this.voidButton.Size = new System.Drawing.Size(75, 23);
            this.voidButton.TabIndex = 1;
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
            this.selectButton.Location = new System.Drawing.Point(6, 20);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 0;
            this.selectButton.Text = "انتخاب";
            this.selectButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.personnelDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(595, 505);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.allRadioButton);
            this.groupBox3.Controls.Add(this.inactiveRadioButton);
            this.groupBox3.Controls.Add(this.activeRadioButton);
            this.groupBox3.Location = new System.Drawing.Point(130, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(194, 39);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "وضعیت پرسنل";
            // 
            // activeRadioButton
            // 
            this.activeRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.activeRadioButton.AutoSize = true;
            this.activeRadioButton.Location = new System.Drawing.Point(90, 15);
            this.activeRadioButton.Name = "activeRadioButton";
            this.activeRadioButton.Size = new System.Drawing.Size(46, 17);
            this.activeRadioButton.TabIndex = 0;
            this.activeRadioButton.Text = "فعال";
            this.activeRadioButton.UseVisualStyleBackColor = true;
            // 
            // inactiveRadioButton
            // 
            this.inactiveRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inactiveRadioButton.AutoSize = true;
            this.inactiveRadioButton.Location = new System.Drawing.Point(19, 16);
            this.inactiveRadioButton.Name = "inactiveRadioButton";
            this.inactiveRadioButton.Size = new System.Drawing.Size(65, 17);
            this.inactiveRadioButton.TabIndex = 1;
            this.inactiveRadioButton.Text = "غیر فعال";
            this.inactiveRadioButton.UseVisualStyleBackColor = true;
            // 
            // allRadioButton
            // 
            this.allRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.allRadioButton.AutoSize = true;
            this.allRadioButton.Checked = true;
            this.allRadioButton.Location = new System.Drawing.Point(140, 16);
            this.allRadioButton.Name = "allRadioButton";
            this.allRadioButton.Size = new System.Drawing.Size(46, 17);
            this.allRadioButton.TabIndex = 2;
            this.allRadioButton.TabStop = true;
            this.allRadioButton.Text = "همه";
            this.allRadioButton.UseVisualStyleBackColor = true;
            // 
            // personnelBindingSource
            // 
            this.personnelBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.Personnel);
            // 
            // IsSelect
            // 
            this.IsSelect.DataPropertyName = "IsSelect";
            this.IsSelect.HeaderText = "";
            this.IsSelect.Name = "IsSelect";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PersonnelNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "کد پرسنل";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn3.HeaderText = "نام";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn4.HeaderText = "نام خانوادگی";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // AllPersonnelListDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 505);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AllPersonnelListDialogForm";
            this.ShowIcon = false;
            this.Text = "";
            this.Load += new System.EventHandler(this.AllPersonnelListDialogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personnelDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView personnelDataGridView;
        private System.Windows.Forms.BindingSource personnelBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox familyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button voidButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton inactiveRadioButton;
        private System.Windows.Forms.RadioButton activeRadioButton;
        private System.Windows.Forms.RadioButton allRadioButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}