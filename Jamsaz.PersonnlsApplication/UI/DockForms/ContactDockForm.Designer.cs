namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    partial class ContactDockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactDockForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.getContactsResultDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getContactsResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getContactsResultDataGridView)).BeginInit();
            this.buttonGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getContactsResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.buttonGroupBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.getContactsResultDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(949, 620);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // getContactsResultDataGridView
            // 
            this.getContactsResultDataGridView.AllowUserToAddRows = false;
            this.getContactsResultDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.getContactsResultDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.getContactsResultDataGridView.AutoGenerateColumns = false;
            this.getContactsResultDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.getContactsResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getContactsResultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn19});
            this.getContactsResultDataGridView.DataSource = this.getContactsResultBindingSource;
            this.getContactsResultDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.getContactsResultDataGridView.Location = new System.Drawing.Point(3, 86);
            this.getContactsResultDataGridView.MultiSelect = false;
            this.getContactsResultDataGridView.Name = "getContactsResultDataGridView";
            this.getContactsResultDataGridView.ReadOnly = true;
            this.getContactsResultDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.getContactsResultDataGridView.Size = new System.Drawing.Size(943, 471);
            this.getContactsResultDataGridView.TabIndex = 1;
            // 
            // buttonGroupBox
            // 
            this.buttonGroupBox.Controls.Add(this.deleteButton);
            this.buttonGroupBox.Controls.Add(this.editButton);
            this.buttonGroupBox.Controls.Add(this.addButton);
            this.buttonGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGroupBox.Location = new System.Drawing.Point(3, 563);
            this.buttonGroupBox.Name = "buttonGroupBox";
            this.buttonGroupBox.Size = new System.Drawing.Size(943, 54);
            this.buttonGroupBox.TabIndex = 1;
            this.buttonGroupBox.TabStop = false;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteButton.Location = new System.Drawing.Point(697, 19);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 25);
            this.deleteButton.TabIndex = 26;
            this.deleteButton.Text = "حذف";
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Image = ((System.Drawing.Image)(resources.GetObject("editButton.Image")));
            this.editButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editButton.Location = new System.Drawing.Point(778, 20);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 25);
            this.editButton.TabIndex = 27;
            this.editButton.Text = "ویرایش";
            this.editButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addButton.Location = new System.Drawing.Point(859, 20);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 25);
            this.addButton.TabIndex = 25;
            this.addButton.Text = "اضافه";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.refreshButton);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.companyTextBox);
            this.groupBox1.Controls.Add(this.contactTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(943, 77);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجوی مخاطب";
            // 
            // contactTextBox
            // 
            this.contactTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contactTextBox.Location = new System.Drawing.Point(682, 34);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(159, 21);
            this.contactTextBox.TabIndex = 0;
            this.contactTextBox.TextChanged += new System.EventHandler(this.contactTextBox_TextChanged);
            // 
            // companyTextBox
            // 
            this.companyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.companyTextBox.Location = new System.Drawing.Point(400, 34);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(192, 21);
            this.companyTextBox.TabIndex = 1;
            this.companyTextBox.TextChanged += new System.EventHandler(this.companyTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(847, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "نام مخاطب :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(598, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "نام شرکت :";
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchButton.Location = new System.Drawing.Point(301, 31);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(83, 25);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "جستجو";
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.Location = new System.Drawing.Point(265, 31);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(31, 25);
            this.refreshButton.TabIndex = 5;
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ContactName";
            this.dataGridViewTextBoxColumn2.HeaderText = "نام مخاطب";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "CompanyName";
            this.dataGridViewTextBoxColumn18.HeaderText = "شرکت";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "AddressLine1";
            this.dataGridViewTextBoxColumn5.HeaderText = "آدرس";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 250;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "TelephonNumbers";
            this.dataGridViewTextBoxColumn19.HeaderText = "شماره های تماس";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 600;
            // 
            // getContactsResultBindingSource
            // 
            this.getContactsResultBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.GetContactsResult);
            // 
            // ContactDockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(949, 620);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ContactDockForm";
            this.ShowIcon = false;
            this.Text = "مخاطبین";
            this.Load += new System.EventHandler(this.ContactDockForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.getContactsResultDataGridView)).EndInit();
            this.buttonGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getContactsResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox buttonGroupBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView getContactsResultDataGridView;
        private System.Windows.Forms.BindingSource getContactsResultBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
    }
}