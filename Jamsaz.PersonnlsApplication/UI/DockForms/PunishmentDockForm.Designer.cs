namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    partial class PunishmentDockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PunishmentDockForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.personnelTextBox = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.personnelDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn80 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.punishmentDataGridView = new System.Windows.Forms.DataGridView();
            this.punishmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personnelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.punishmentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.punishmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 365F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(768, 665);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(406, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(359, 659);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.refreshButton);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.personnelTextBox);
            this.groupBox1.Controls.Add(this.a);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو پرسنل";
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.refresh;
            this.refreshButton.Location = new System.Drawing.Point(15, 23);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(37, 24);
            this.refreshButton.TabIndex = 7;
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.search1;
            this.searchButton.Location = new System.Drawing.Point(58, 23);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(37, 24);
            this.searchButton.TabIndex = 6;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // personnelTextBox
            // 
            this.personnelTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.personnelTextBox.Location = new System.Drawing.Point(101, 25);
            this.personnelTextBox.Name = "personnelTextBox";
            this.personnelTextBox.Size = new System.Drawing.Size(185, 21);
            this.personnelTextBox.TabIndex = 5;
            this.personnelTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.personnelTextBox_KeyPress);
            // 
            // a
            // 
            this.a.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(292, 28);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(45, 13);
            this.a.TabIndex = 4;
            this.a.Text = "پرسنل :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.personnelDataGridView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 589);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "لیست پرسنل";
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
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn80});
            this.personnelDataGridView.DataSource = this.personnelBindingSource;
            this.personnelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personnelDataGridView.Location = new System.Drawing.Point(3, 17);
            this.personnelDataGridView.MultiSelect = false;
            this.personnelDataGridView.Name = "personnelDataGridView";
            this.personnelDataGridView.ReadOnly = true;
            this.personnelDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.personnelDataGridView.Size = new System.Drawing.Size(347, 569);
            this.personnelDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "PersonnelNumber";
            this.dataGridViewTextBoxColumn19.HeaderText = "ش پرسنلی";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 90;
            // 
            // dataGridViewTextBoxColumn80
            // 
            this.dataGridViewTextBoxColumn80.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn80.HeaderText = "نام پرسنل";
            this.dataGridViewTextBoxColumn80.Name = "dataGridViewTextBoxColumn80";
            this.dataGridViewTextBoxColumn80.ReadOnly = true;
            this.dataGridViewTextBoxColumn80.Width = 210;
            // 
            // personnelBindingSource
            // 
            this.personnelBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.Personnel);
            this.personnelBindingSource.CurrentChanged += new System.EventHandler(this.personnelBindingSource_CurrentChanged);
            this.personnelBindingSource.PositionChanged += new System.EventHandler(this.personnelBindingSource_PositionChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.deleteButton);
            this.groupBox3.Controls.Add(this.editButton);
            this.groupBox3.Controls.Add(this.addButton);
            this.groupBox3.Controls.Add(this.punishmentDataGridView);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(397, 659);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "لیست تنبیه پرسنل";
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.l_cancel;
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteButton.Location = new System.Drawing.Point(154, 630);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "حذف";
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.edit;
            this.editButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editButton.Location = new System.Drawing.Point(235, 630);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "ویرایش";
            this.editButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addButton.Location = new System.Drawing.Point(316, 630);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "اضافه";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // punishmentDataGridView
            // 
            this.punishmentDataGridView.AllowUserToAddRows = false;
            this.punishmentDataGridView.AllowUserToDeleteRows = false;
            this.punishmentDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.punishmentDataGridView.AutoGenerateColumns = false;
            this.punishmentDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.punishmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.punishmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.punishmentDataGridView.DataSource = this.punishmentBindingSource;
            this.punishmentDataGridView.Location = new System.Drawing.Point(6, 20);
            this.punishmentDataGridView.MultiSelect = false;
            this.punishmentDataGridView.Name = "punishmentDataGridView";
            this.punishmentDataGridView.ReadOnly = true;
            this.punishmentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.punishmentDataGridView.Size = new System.Drawing.Size(385, 601);
            this.punishmentDataGridView.TabIndex = 0;
            // 
            // punishmentBindingSource
            // 
            this.punishmentBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.Punishment);
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "PersianDate";
            this.dataGridViewTextBoxColumn14.HeaderText = "تاریخ";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 80;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "ApplicantName";
            this.dataGridViewTextBoxColumn16.HeaderText = "درخواست کننده";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 150;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "ConfirmorName";
            this.dataGridViewTextBoxColumn17.HeaderText = "تایید کننده";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Reason";
            this.dataGridViewTextBoxColumn5.HeaderText = "دلیل";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 250;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PunishmentType";
            this.dataGridViewTextBoxColumn6.HeaderText = "نوع تنبیه";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn7.HeaderText = "توضیحات";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // PunishmentDockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 665);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PunishmentDockForm";
            this.ShowIcon = false;
            this.Text = "لیست تنبیه پرسنل";
            this.Load += new System.EventHandler(this.PunishmentDockForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personnelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.punishmentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.punishmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView personnelDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn80;
        private System.Windows.Forms.BindingSource personnelBindingSource;
        private System.Windows.Forms.DataGridView punishmentDataGridView;
        private System.Windows.Forms.BindingSource punishmentBindingSource;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox personnelTextBox;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}