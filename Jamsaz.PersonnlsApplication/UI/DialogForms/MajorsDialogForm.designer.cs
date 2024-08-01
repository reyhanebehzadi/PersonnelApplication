namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class MajorsDialogForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cancelButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.passNullCheckBox = new System.Windows.Forms.CheckBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.majorsDataGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.filterNameLabel = new System.Windows.Forms.Label();
            this.filterNameTextBox = new System.Windows.Forms.TextBox();
            this.majorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.majorsDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.majorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cancelButton.Location = new System.Drawing.Point(125, 14);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 24);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "لغو";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.passNullCheckBox);
            this.panel2.Controls.Add(this.cancelButton);
            this.panel2.Controls.Add(this.selectButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 349);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 54);
            this.panel2.TabIndex = 1;
            // 
            // passNullCheckBox
            // 
            this.passNullCheckBox.AutoSize = true;
            this.passNullCheckBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.passNullCheckBox.Location = new System.Drawing.Point(290, 18);
            this.passNullCheckBox.Name = "passNullCheckBox";
            this.passNullCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passNullCheckBox.Size = new System.Drawing.Size(103, 18);
            this.passNullCheckBox.TabIndex = 2;
            this.passNullCheckBox.Text = "خالی بودن فیلد";
            this.passNullCheckBox.UseVisualStyleBackColor = true;
            // 
            // selectButton
            // 
            this.selectButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.selectButton.Location = new System.Drawing.Point(206, 14);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 24);
            this.selectButton.TabIndex = 0;
            this.selectButton.Text = "انتخاب";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.cmdSelect_Click);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.4891F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.5109F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(408, 406);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.majorsDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 295);
            this.panel1.TabIndex = 0;
            // 
            // majorsDataGridView
            // 
            this.majorsDataGridView.AllowUserToAddRows = false;
            this.majorsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.majorsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.majorsDataGridView.AutoGenerateColumns = false;
            this.majorsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.majorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.majorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.IsSelect,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.majorsDataGridView.DataSource = this.majorsBindingSource;
            this.majorsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.majorsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.majorsDataGridView.MultiSelect = false;
            this.majorsDataGridView.Name = "majorsDataGridView";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.majorsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.majorsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.majorsDataGridView.Size = new System.Drawing.Size(402, 295);
            this.majorsDataGridView.TabIndex = 0;
            this.majorsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.majorsDataGridView_CellDoubleClick);
            this.majorsDataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.majorsDataGridView_KeyPress);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.filterNameLabel);
            this.panel3.Controls.Add(this.filterNameTextBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(402, 39);
            this.panel3.TabIndex = 2;
            // 
            // filterNameLabel
            // 
            this.filterNameLabel.AutoSize = true;
            this.filterNameLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.filterNameLabel.Location = new System.Drawing.Point(319, 11);
            this.filterNameLabel.Name = "filterNameLabel";
            this.filterNameLabel.Size = new System.Drawing.Size(70, 13);
            this.filterNameLabel.TabIndex = 1;
            this.filterNameLabel.Text = "جستجو رشته";
            // 
            // filterNameTextBox
            // 
            this.filterNameTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.filterNameTextBox.Location = new System.Drawing.Point(136, 9);
            this.filterNameTextBox.Name = "filterNameTextBox";
            this.filterNameTextBox.Size = new System.Drawing.Size(174, 22);
            this.filterNameTextBox.TabIndex = 0;
            this.filterNameTextBox.TextChanged += new System.EventHandler(this.filterNameTextBox_TextChanged);
            // 
            // majorsBindingSource
            // 
            this.majorsBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.Major);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // IsSelect
            // 
            this.IsSelect.DataPropertyName = "IsSelect";
            this.IsSelect.HeaderText = "";
            this.IsSelect.Name = "IsSelect";
            this.IsSelect.Visible = false;
            this.IsSelect.Width = 50;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "کد";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeDataGridViewTextBoxColumn.Width = 110;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 200F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "نام";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // MajorsDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(408, 406);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MajorsDialogForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم انتخاب رشته تحصیلی شخص";
            this.Load += new System.EventHandler(this.majorsDialogForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.majorsDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.majorsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource majorsBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label filterNameLabel;
        private System.Windows.Forms.TextBox filterNameTextBox;
        private System.Windows.Forms.CheckBox passNullCheckBox;
        private System.Windows.Forms.DataGridView majorsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}