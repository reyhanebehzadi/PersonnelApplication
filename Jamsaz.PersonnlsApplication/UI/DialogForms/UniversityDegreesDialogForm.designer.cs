namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class UniversityDegreesDialogForm
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
            this.universityDegreesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.universityDegreesDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.paasNullCheckBox = new System.Windows.Forms.CheckBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.filterNameLabel = new System.Windows.Forms.Label();
            this.filterNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.universityDegreesBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.universityDegreesDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // universityDegreesBindingSource
            // 
            this.universityDegreesBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.UniversityDegree);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.universityDegreesDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 252);
            this.panel1.TabIndex = 0;
            // 
            // universityDegreesDataGridView
            // 
            this.universityDegreesDataGridView.AllowUserToAddRows = false;
            this.universityDegreesDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.universityDegreesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.universityDegreesDataGridView.AutoGenerateColumns = false;
            this.universityDegreesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.universityDegreesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.universityDegreesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.universityDegreesDataGridView.DataSource = this.universityDegreesBindingSource;
            this.universityDegreesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.universityDegreesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.universityDegreesDataGridView.MultiSelect = false;
            this.universityDegreesDataGridView.Name = "universityDegreesDataGridView";
            this.universityDegreesDataGridView.ReadOnly = true;
            this.universityDegreesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.universityDegreesDataGridView.Size = new System.Drawing.Size(407, 252);
            this.universityDegreesDataGridView.TabIndex = 0;
            this.universityDegreesDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.universityDegreesDataGridView_CellMouseDoubleClick);
            this.universityDegreesDataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.universityDegreesDataGridView_KeyPress);
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
            this.codeDataGridViewTextBoxColumn.HeaderText = "کد ";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 101F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "نام مدرک ";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cancelButton.Location = new System.Drawing.Point(124, 6);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 24);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "لغو";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.76159F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.23841F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(413, 344);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.paasNullCheckBox);
            this.panel2.Controls.Add(this.cancelButton);
            this.panel2.Controls.Add(this.selectButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 303);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 38);
            this.panel2.TabIndex = 1;
            // 
            // paasNullCheckBox
            // 
            this.paasNullCheckBox.AutoSize = true;
            this.paasNullCheckBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.paasNullCheckBox.Location = new System.Drawing.Point(296, 8);
            this.paasNullCheckBox.Name = "paasNullCheckBox";
            this.paasNullCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.paasNullCheckBox.Size = new System.Drawing.Size(103, 18);
            this.paasNullCheckBox.TabIndex = 4;
            this.paasNullCheckBox.Text = "خالی بودن فیلد";
            this.paasNullCheckBox.UseVisualStyleBackColor = true;
            // 
            // selectButton
            // 
            this.selectButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.selectButton.Location = new System.Drawing.Point(205, 6);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 24);
            this.selectButton.TabIndex = 0;
            this.selectButton.Text = "انتخاب";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.filterNameLabel);
            this.panel3.Controls.Add(this.filterNameTextBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(407, 36);
            this.panel3.TabIndex = 2;
            // 
            // filterNameLabel
            // 
            this.filterNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterNameLabel.AutoSize = true;
            this.filterNameLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.filterNameLabel.Location = new System.Drawing.Point(288, 13);
            this.filterNameLabel.Name = "filterNameLabel";
            this.filterNameLabel.Size = new System.Drawing.Size(112, 13);
            this.filterNameLabel.TabIndex = 3;
            this.filterNameLabel.Text = "جستجو مدرک تحصیلی";
            // 
            // filterNameTextBox
            // 
            this.filterNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterNameTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.filterNameTextBox.Location = new System.Drawing.Point(124, 9);
            this.filterNameTextBox.Name = "filterNameTextBox";
            this.filterNameTextBox.Size = new System.Drawing.Size(156, 22);
            this.filterNameTextBox.TabIndex = 2;
            this.filterNameTextBox.TextChanged += new System.EventHandler(this.txtFilterName_TextChanged);
            // 
            // UniversityDegreesDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(413, 344);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UniversityDegreesDialogForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "انتخاب مدرک تحصیلی";
            this.Load += new System.EventHandler(this.universityDegreesDialogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.universityDegreesBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.universityDegreesDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource universityDegreesBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label filterNameLabel;
        private System.Windows.Forms.TextBox filterNameTextBox;
        private System.Windows.Forms.CheckBox paasNullCheckBox;
        private System.Windows.Forms.DataGridView universityDegreesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;

    }
}