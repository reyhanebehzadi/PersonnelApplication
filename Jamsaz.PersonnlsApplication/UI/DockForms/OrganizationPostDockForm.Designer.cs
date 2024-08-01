namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    partial class OrganizationPostDockForm
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.organizationPostDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organizationPostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.organizationPostDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationPostBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.editButton);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 393);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.l_cancel;
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteButton.Location = new System.Drawing.Point(548, 20);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "حذف";
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.kedit;
            this.editButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editButton.Location = new System.Drawing.Point(629, 20);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "ویرایش ";
            this.editButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.l_add;
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addButton.Location = new System.Drawing.Point(710, 20);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "اضافه";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.organizationPostDataGridView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(794, 384);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // organizationPostDataGridView
            // 
            this.organizationPostDataGridView.AllowUserToAddRows = false;
            this.organizationPostDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.organizationPostDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.organizationPostDataGridView.AutoGenerateColumns = false;
            this.organizationPostDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.organizationPostDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.organizationPostDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.organizationPostDataGridView.DataSource = this.organizationPostBindingSource;
            this.organizationPostDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.organizationPostDataGridView.Location = new System.Drawing.Point(3, 17);
            this.organizationPostDataGridView.Name = "organizationPostDataGridView";
            this.organizationPostDataGridView.ReadOnly = true;
            this.organizationPostDataGridView.Size = new System.Drawing.Size(788, 364);
            this.organizationPostDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Code";
            this.dataGridViewTextBoxColumn2.HeaderText = "کد";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn3.HeaderText = "عنوان";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // organizationPostBindingSource
            // 
            this.organizationPostBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.OrganizationPost);
            // 
            // OrganizationPostDockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OrganizationPostDockForm";
            this.ShowIcon = false;
            this.Text = "سمت ";
            this.Load += new System.EventHandler(this.OrganizationPostDockForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.organizationPostDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationPostBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView organizationPostDataGridView;
        private System.Windows.Forms.BindingSource organizationPostBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
    }
}