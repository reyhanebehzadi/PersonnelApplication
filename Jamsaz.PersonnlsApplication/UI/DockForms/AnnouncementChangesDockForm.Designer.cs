namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    partial class AnnouncementChangesDockForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.announcementChangeDataGridView = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersianDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mounth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangeTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.printButton = new System.Windows.Forms.Button();
            this.fiscalYearComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.announcementChangeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fiscalYearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monthsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.monthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.announcementChangeDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.announcementChangeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiscalYearBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.announcementChangeDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(817, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.editButton);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 393);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(811, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.kedit;
            this.editButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editButton.Location = new System.Drawing.Point(646, 20);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "ویرایش";
            this.editButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.l_cancel;
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteButton.Location = new System.Drawing.Point(565, 20);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "حذف";
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.l_add;
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addButton.Location = new System.Drawing.Point(727, 20);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "اضافه";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // announcementChangeDataGridView
            // 
            this.announcementChangeDataGridView.AllowUserToAddRows = false;
            this.announcementChangeDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.announcementChangeDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.announcementChangeDataGridView.AutoGenerateColumns = false;
            this.announcementChangeDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.announcementChangeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.announcementChangeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.PersianDate,
            this.Mounth,
            this.Column1,
            this.ChangeTitle,
            this.dataGridViewTextBoxColumn6});
            this.announcementChangeDataGridView.DataSource = this.announcementChangeBindingSource;
            this.announcementChangeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.announcementChangeDataGridView.Location = new System.Drawing.Point(3, 63);
            this.announcementChangeDataGridView.Name = "announcementChangeDataGridView";
            this.announcementChangeDataGridView.ReadOnly = true;
            this.announcementChangeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.announcementChangeDataGridView.Size = new System.Drawing.Size(811, 324);
            this.announcementChangeDataGridView.TabIndex = 1;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "شماره";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // PersianDate
            // 
            this.PersianDate.DataPropertyName = "PersianDate";
            this.PersianDate.HeaderText = "تاریخ";
            this.PersianDate.Name = "PersianDate";
            this.PersianDate.ReadOnly = true;
            // 
            // Mounth
            // 
            this.Mounth.DataPropertyName = "Mounth";
            this.Mounth.HeaderText = "ماه";
            this.Mounth.Name = "Mounth";
            this.Mounth.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PersonnelName";
            this.Column1.HeaderText = "پرسنل";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // ChangeTitle
            // 
            this.ChangeTitle.DataPropertyName = "ChangeTitle";
            this.ChangeTitle.HeaderText = "تغییر";
            this.ChangeTitle.Name = "ChangeTitle";
            this.ChangeTitle.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.monthsComboBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.printButton);
            this.groupBox2.Controls.Add(this.fiscalYearComboBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(811, 54);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(9, 18);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 23);
            this.printButton.TabIndex = 2;
            this.printButton.Text = "چاپ";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // fiscalYearComboBox
            // 
            this.fiscalYearComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fiscalYearComboBox.DataSource = this.fiscalYearBindingSource;
            this.fiscalYearComboBox.DisplayMember = "Title";
            this.fiscalYearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fiscalYearComboBox.FormattingEnabled = true;
            this.fiscalYearComboBox.Location = new System.Drawing.Point(610, 20);
            this.fiscalYearComboBox.Name = "fiscalYearComboBox";
            this.fiscalYearComboBox.Size = new System.Drawing.Size(121, 21);
            this.fiscalYearComboBox.TabIndex = 1;
            this.fiscalYearComboBox.ValueMember = "ID";
            this.fiscalYearComboBox.SelectedIndexChanged += new System.EventHandler(this.fiscalYearComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(737, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "سال مالی:";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn6.HeaderText = "توضیحات";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 350;
            // 
            // announcementChangeBindingSource
            // 
            this.announcementChangeBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.AnnouncementChange);
            // 
            // fiscalYearBindingSource
            // 
            this.fiscalYearBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.FiscalYear);
            // 
            // monthsComboBox
            // 
            this.monthsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthsComboBox.DataSource = this.monthBindingSource;
            this.monthsComboBox.DisplayMember = "Title";
            this.monthsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthsComboBox.FormattingEnabled = true;
            this.monthsComboBox.Location = new System.Drawing.Point(398, 20);
            this.monthsComboBox.Name = "monthsComboBox";
            this.monthsComboBox.Size = new System.Drawing.Size(121, 21);
            this.monthsComboBox.TabIndex = 4;
            this.monthsComboBox.ValueMember = "ID";
            this.monthsComboBox.SelectedIndexChanged += new System.EventHandler(this.monthsComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ماه:";
            // 
            // monthBindingSource
            // 
            this.monthBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.MonthTable);
            // 
            // AnnouncementChangesDockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AnnouncementChangesDockForm";
            this.ShowIcon = false;
            this.Text = "اعلام تغییرات";
            this.Load += new System.EventHandler(this.AnnouncementChangesDockForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.announcementChangeDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.announcementChangeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiscalYearBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView announcementChangeDataGridView;
        private System.Windows.Forms.BindingSource announcementChangeBindingSource;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox fiscalYearComboBox;
        private System.Windows.Forms.BindingSource fiscalYearBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersianDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mounth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChangeTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ComboBox monthsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource monthBindingSource;
    }
}