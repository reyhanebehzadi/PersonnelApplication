namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class DepartmentVersionDialogForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.selectButton = new System.Windows.Forms.Button();
            this.voidButton = new System.Windows.Forms.Button();
            this.departmentVersionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effectiveStardDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effectiveEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentVersionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.effectiveStardDateDataGridViewTextBoxColumn,
            this.effectiveEndDateDataGridViewTextBoxColumn,
            this.isActiveDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.departmentVersionBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(2, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(419, 429);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDoubleClick);
            // 
            // selectButton
            // 
            this.selectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectButton.Location = new System.Drawing.Point(336, 438);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 1;
            this.selectButton.Text = "اضافه";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // voidButton
            // 
            this.voidButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.voidButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.voidButton.Location = new System.Drawing.Point(255, 438);
            this.voidButton.Name = "voidButton";
            this.voidButton.Size = new System.Drawing.Size(75, 23);
            this.voidButton.TabIndex = 2;
            this.voidButton.Text = "لغو";
            this.voidButton.UseVisualStyleBackColor = true;
            this.voidButton.Click += new System.EventHandler(this.voidButton_Click);
            // 
            // departmentVersionBindingSource
            // 
            this.departmentVersionBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.DepartmentVersion);
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
            this.codeDataGridViewTextBoxColumn.HeaderText = "کد نسخه";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeDataGridViewTextBoxColumn.Width = 125;
            // 
            // effectiveStardDateDataGridViewTextBoxColumn
            // 
            this.effectiveStardDateDataGridViewTextBoxColumn.DataPropertyName = "effectiveStardDate";
            this.effectiveStardDateDataGridViewTextBoxColumn.HeaderText = "effectiveStardDate";
            this.effectiveStardDateDataGridViewTextBoxColumn.Name = "effectiveStardDateDataGridViewTextBoxColumn";
            this.effectiveStardDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.effectiveStardDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // effectiveEndDateDataGridViewTextBoxColumn
            // 
            this.effectiveEndDateDataGridViewTextBoxColumn.DataPropertyName = "effectiveEndDate";
            this.effectiveEndDateDataGridViewTextBoxColumn.HeaderText = "effectiveEndDate";
            this.effectiveEndDateDataGridViewTextBoxColumn.Name = "effectiveEndDateDataGridViewTextBoxColumn";
            this.effectiveEndDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.effectiveEndDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // isActiveDataGridViewTextBoxColumn
            // 
            this.isActiveDataGridViewTextBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewTextBoxColumn.HeaderText = "فعال";
            this.isActiveDataGridViewTextBoxColumn.Name = "isActiveDataGridViewTextBoxColumn";
            this.isActiveDataGridViewTextBoxColumn.ReadOnly = true;
            this.isActiveDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isActiveDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isActiveDataGridViewTextBoxColumn.Width = 125;
            // 
            // DepartmentVersionDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.voidButton;
            this.ClientSize = new System.Drawing.Size(422, 471);
            this.Controls.Add(this.voidButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DepartmentVersionDialogForm";
            this.ShowIcon = false;
            this.Text = "نسخه های واحد ها";
            this.Load += new System.EventHandler(this.DepartmentVersionDialogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentVersionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button voidButton;
        private System.Windows.Forms.BindingSource departmentVersionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn effectiveStardDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn effectiveEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewTextBoxColumn;
    }
}