namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class MilitaryServiceStatusDialogForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MilitaryServiceStatusDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.militaryServiceStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.passNullCheckBox = new System.Windows.Forms.CheckBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.filterNameLabel = new System.Windows.Forms.Label();
            this.filterNameTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MilitaryServiceStatusDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.militaryServiceStatusBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.51613F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.48387F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(459, 402);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MilitaryServiceStatusDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 298);
            this.panel1.TabIndex = 0;
            // 
            // MilitaryServiceStatusDataGridView
            // 
            this.MilitaryServiceStatusDataGridView.AllowUserToAddRows = false;
            this.MilitaryServiceStatusDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.MilitaryServiceStatusDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MilitaryServiceStatusDataGridView.AutoGenerateColumns = false;
            this.MilitaryServiceStatusDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.MilitaryServiceStatusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MilitaryServiceStatusDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn});
            this.MilitaryServiceStatusDataGridView.DataSource = this.militaryServiceStatusBindingSource;
            this.MilitaryServiceStatusDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MilitaryServiceStatusDataGridView.Location = new System.Drawing.Point(0, 0);
            this.MilitaryServiceStatusDataGridView.MultiSelect = false;
            this.MilitaryServiceStatusDataGridView.Name = "MilitaryServiceStatusDataGridView";
            this.MilitaryServiceStatusDataGridView.ReadOnly = true;
            this.MilitaryServiceStatusDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MilitaryServiceStatusDataGridView.Size = new System.Drawing.Size(453, 298);
            this.MilitaryServiceStatusDataGridView.TabIndex = 0;
            this.MilitaryServiceStatusDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.militaryServiceStatusDataGridView_CellDoubleClick);
            this.MilitaryServiceStatusDataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.militaryServiceStatusDataGridView_KeyPress);
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
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.FillWeight = 210F;
            this.titleDataGridViewTextBoxColumn.HeaderText = "عنوان";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 210;
            // 
            // militaryServiceStatusBindingSource
            // 
            this.militaryServiceStatusBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.MilitaryServiceStatus);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.passNullCheckBox);
            this.panel2.Controls.Add(this.cancelButton);
            this.panel2.Controls.Add(this.selectButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 349);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 50);
            this.panel2.TabIndex = 1;
            // 
            // passNullCheckBox
            // 
            this.passNullCheckBox.AutoSize = true;
            this.passNullCheckBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.passNullCheckBox.Location = new System.Drawing.Point(291, 14);
            this.passNullCheckBox.Name = "passNullCheckBox";
            this.passNullCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passNullCheckBox.Size = new System.Drawing.Size(103, 18);
            this.passNullCheckBox.TabIndex = 3;
            this.passNullCheckBox.Text = "خالی بودن فیلد";
            this.passNullCheckBox.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cancelButton.Location = new System.Drawing.Point(94, 10);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(87, 26);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "لغو";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.selectButton.Location = new System.Drawing.Point(188, 10);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(87, 26);
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
            this.panel3.Size = new System.Drawing.Size(453, 36);
            this.panel3.TabIndex = 2;
            // 
            // filterNameLabel
            // 
            this.filterNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterNameLabel.AutoSize = true;
            this.filterNameLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.filterNameLabel.Location = new System.Drawing.Point(361, 9);
            this.filterNameLabel.Name = "filterNameLabel";
            this.filterNameLabel.Size = new System.Drawing.Size(70, 13);
            this.filterNameLabel.TabIndex = 3;
            this.filterNameLabel.Text = "جستجو رشته";
            // 
            // filterNameTextBox
            // 
            this.filterNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterNameTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.filterNameTextBox.Location = new System.Drawing.Point(213, 5);
            this.filterNameTextBox.Name = "filterNameTextBox";
            this.filterNameTextBox.Size = new System.Drawing.Size(137, 22);
            this.filterNameTextBox.TabIndex = 2;
            this.filterNameTextBox.TextChanged += new System.EventHandler(this.txtFilterName_TextChanged);
            // 
            // MilitaryServiceStatusDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(459, 402);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MilitaryServiceStatusDialogForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم انتخاب وضعیت خدمت اشخاص";
            this.Load += new System.EventHandler(this.militaryServiceStatusDialogForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MilitaryServiceStatusDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.militaryServiceStatusBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.BindingSource militaryServiceStatusBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label filterNameLabel;
        private System.Windows.Forms.TextBox filterNameTextBox;
        private System.Windows.Forms.CheckBox passNullCheckBox;
        private System.Windows.Forms.DataGridView MilitaryServiceStatusDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
    }
}