namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    partial class BaseInformationMilitaryServiceForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.filterNameTextBox = new System.Windows.Forms.TextBox();
            this.lblFilterName = new System.Windows.Forms.Label();
            this.militaryServiceStatusDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.militaryServiceStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.militaryServiceStatusDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.militaryServiceStatusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(872, 614);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.deleteButton);
            this.panel2.Controls.Add(this.editButton);
            this.panel2.Controls.Add(this.AddButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 570);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 41);
            this.panel2.TabIndex = 5;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.l_cancel;
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteButton.Location = new System.Drawing.Point(613, 7);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 25);
            this.deleteButton.TabIndex = 7;
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
            this.editButton.Location = new System.Drawing.Point(694, 7);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 25);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "ویرایش";
            this.editButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.l_add;
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddButton.Location = new System.Drawing.Point(775, 7);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 25);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "اضافه";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(866, 561);
            this.panel3.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(866, 561);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "وضعیت نظام وظیفه";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.militaryServiceStatusDataGridView, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(860, 541);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.filterNameTextBox);
            this.groupBox2.Controls.Add(this.lblFilterName);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(854, 54);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // filterNameTextBox
            // 
            this.filterNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterNameTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.filterNameTextBox.Location = new System.Drawing.Point(540, 20);
            this.filterNameTextBox.Name = "filterNameTextBox";
            this.filterNameTextBox.Size = new System.Drawing.Size(156, 22);
            this.filterNameTextBox.TabIndex = 4;
            this.filterNameTextBox.TextChanged += new System.EventHandler(this.filterNameTextBox_TextChanged);
            // 
            // lblFilterName
            // 
            this.lblFilterName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilterName.AutoSize = true;
            this.lblFilterName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblFilterName.Location = new System.Drawing.Point(700, 24);
            this.lblFilterName.Name = "lblFilterName";
            this.lblFilterName.Size = new System.Drawing.Size(134, 13);
            this.lblFilterName.TabIndex = 5;
            this.lblFilterName.Text = "جستجو وضعیت نظام وظیفه";
            // 
            // militaryServiceStatusDataGridView
            // 
            this.militaryServiceStatusDataGridView.AllowUserToAddRows = false;
            this.militaryServiceStatusDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.militaryServiceStatusDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.militaryServiceStatusDataGridView.AutoGenerateColumns = false;
            this.militaryServiceStatusDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.militaryServiceStatusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.militaryServiceStatusDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.Title});
            this.militaryServiceStatusDataGridView.DataSource = this.militaryServiceStatusBindingSource;
            this.militaryServiceStatusDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.militaryServiceStatusDataGridView.Location = new System.Drawing.Point(3, 63);
            this.militaryServiceStatusDataGridView.Name = "militaryServiceStatusDataGridView";
            this.militaryServiceStatusDataGridView.ReadOnly = true;
            this.militaryServiceStatusDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.militaryServiceStatusDataGridView.Size = new System.Drawing.Size(854, 475);
            this.militaryServiceStatusDataGridView.TabIndex = 7;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "کد";
            this.codeDataGridViewTextBoxColumn.MaxInputLength = 6;
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.FillWeight = 250F;
            this.Title.HeaderText = "عنوان";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 250;
            // 
            // militaryServiceStatusBindingSource
            // 
            this.militaryServiceStatusBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.MilitaryServiceStatus);
            // 
            // BaseInformationMilitaryServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(872, 614);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BaseInformationMilitaryServiceForm";
            this.Text = "قوانین نظام وظیفه";
            this.Load += new System.EventHandler(this.BaseInformationMilitaryServiceForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.militaryServiceStatusDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.militaryServiceStatusBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView militaryServiceStatusDataGridView;
        private System.Windows.Forms.BindingSource militaryServiceStatusBindingSource;
        private System.Windows.Forms.Label lblFilterName;
        private System.Windows.Forms.TextBox filterNameTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}