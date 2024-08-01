namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    partial class BaseInformationDepartmentVersionForm
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.departmentDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effectiveStardDateDataGridViewTextBoxColumn = new FarsiLibrary.Win.Controls.DataGridViewFADateTimePickerColumn();
            this.effectiveEndDateDataGridViewTextBoxColumn = new FarsiLibrary.Win.Controls.DataGridViewFADateTimePickerColumn();
            this.isActiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.departmentVersionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.deletButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentVersionBindingSource)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.departmentDataGridView, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.bottomPanel, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(868, 581);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // departmentDataGridView
            // 
            this.departmentDataGridView.AllowUserToAddRows = false;
            this.departmentDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.departmentDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.departmentDataGridView.AutoGenerateColumns = false;
            this.departmentDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.departmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.effectiveStardDateDataGridViewTextBoxColumn,
            this.effectiveEndDateDataGridViewTextBoxColumn,
            this.isActiveDataGridViewTextBoxColumn});
            this.departmentDataGridView.DataSource = this.departmentVersionBindingSource;
            this.departmentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departmentDataGridView.Location = new System.Drawing.Point(3, 3);
            this.departmentDataGridView.Name = "departmentDataGridView";
            this.departmentDataGridView.ReadOnly = true;
            this.departmentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.departmentDataGridView.Size = new System.Drawing.Size(862, 525);
            this.departmentDataGridView.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "کد";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // effectiveStardDateDataGridViewTextBoxColumn
            // 
            this.effectiveStardDateDataGridViewTextBoxColumn.DataPropertyName = "effectiveStardDate";
            this.effectiveStardDateDataGridViewTextBoxColumn.HeaderText = "تاریخ شروع";
            this.effectiveStardDateDataGridViewTextBoxColumn.Name = "effectiveStardDateDataGridViewTextBoxColumn";
            this.effectiveStardDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.effectiveStardDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.effectiveStardDateDataGridViewTextBoxColumn.SelectedDateTime = new System.DateTime(((long)(0)));
            this.effectiveStardDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.effectiveStardDateDataGridViewTextBoxColumn.VerticalAlignment = System.Drawing.StringAlignment.Near;
            this.effectiveStardDateDataGridViewTextBoxColumn.Width = 82;
            // 
            // effectiveEndDateDataGridViewTextBoxColumn
            // 
            this.effectiveEndDateDataGridViewTextBoxColumn.DataPropertyName = "effectiveEndDate";
            this.effectiveEndDateDataGridViewTextBoxColumn.HeaderText = "تاریخ پایان";
            this.effectiveEndDateDataGridViewTextBoxColumn.Name = "effectiveEndDateDataGridViewTextBoxColumn";
            this.effectiveEndDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.effectiveEndDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.effectiveEndDateDataGridViewTextBoxColumn.SelectedDateTime = new System.DateTime(((long)(0)));
            this.effectiveEndDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.effectiveEndDateDataGridViewTextBoxColumn.VerticalAlignment = System.Drawing.StringAlignment.Near;
            this.effectiveEndDateDataGridViewTextBoxColumn.Width = 80;
            // 
            // isActiveDataGridViewTextBoxColumn
            // 
            this.isActiveDataGridViewTextBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewTextBoxColumn.HeaderText = "فعال";
            this.isActiveDataGridViewTextBoxColumn.Name = "isActiveDataGridViewTextBoxColumn";
            this.isActiveDataGridViewTextBoxColumn.ReadOnly = true;
            this.isActiveDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isActiveDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // departmentVersionBindingSource
            // 
            this.departmentVersionBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.DepartmentVersion);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.deletButton);
            this.bottomPanel.Controls.Add(this.editButton);
            this.bottomPanel.Controls.Add(this.addButton);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomPanel.Location = new System.Drawing.Point(3, 534);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(862, 44);
            this.bottomPanel.TabIndex = 1;
            // 
            // deletButton
            // 
            this.deletButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deletButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.l_cancel;
            this.deletButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deletButton.Location = new System.Drawing.Point(616, 11);
            this.deletButton.Name = "deletButton";
            this.deletButton.Size = new System.Drawing.Size(75, 23);
            this.deletButton.TabIndex = 2;
            this.deletButton.Text = "حذف";
            this.deletButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deletButton.UseVisualStyleBackColor = true;
            this.deletButton.Click += new System.EventHandler(this.deletButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.kedit;
            this.editButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editButton.Location = new System.Drawing.Point(697, 11);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 24);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "ویرایش";
            this.editButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.l_add;
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addButton.Location = new System.Drawing.Point(778, 11);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "اضافه";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // BaseInformationDepartmentVersionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(868, 581);
            this.Controls.Add(this.tableLayoutPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaseInformationDepartmentVersionForm";
            this.ShowIcon = false;
            this.Text = "نسخه بخش ها در سیستم";
            this.Load += new System.EventHandler(this.BaseInformationDepartmentVersionForm_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.departmentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentVersionBindingSource)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.DataGridView departmentDataGridView;
        private System.Windows.Forms.BindingSource departmentVersionBindingSource;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button deletButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private FarsiLibrary.Win.Controls.DataGridViewFADateTimePickerColumn effectiveStardDateDataGridViewTextBoxColumn;
        private FarsiLibrary.Win.Controls.DataGridViewFADateTimePickerColumn effectiveEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewTextBoxColumn;
    }
}