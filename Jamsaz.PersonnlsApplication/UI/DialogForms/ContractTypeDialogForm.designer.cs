namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class ContractTypeDialogForm
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
            this.contractTypeDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kindsOfContractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.passNullCheckBox = new System.Windows.Forms.CheckBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.filterNameLabel = new System.Windows.Forms.Label();
            this.filterNameTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractTypeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindsOfContractBindingSource)).BeginInit();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.37864F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.62136F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(406, 352);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.contractTypeDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 263);
            this.panel1.TabIndex = 0;
            // 
            // contractTypeDataGridView
            // 
            this.contractTypeDataGridView.AllowUserToAddRows = false;
            this.contractTypeDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue;
            this.contractTypeDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.contractTypeDataGridView.AutoGenerateColumns = false;
            this.contractTypeDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.contractTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contractTypeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.contractTypeDataGridView.DataSource = this.kindsOfContractBindingSource;
            this.contractTypeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contractTypeDataGridView.Location = new System.Drawing.Point(0, 0);
            this.contractTypeDataGridView.MultiSelect = false;
            this.contractTypeDataGridView.Name = "contractTypeDataGridView";
            this.contractTypeDataGridView.ReadOnly = true;
            this.contractTypeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contractTypeDataGridView.Size = new System.Drawing.Size(400, 263);
            this.contractTypeDataGridView.TabIndex = 0;
            this.contractTypeDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contractTypeDataGridView_CellDoubleClick);
            this.contractTypeDataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contractTypeDataGridView_KeyPress);
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
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 200F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "نام قرارداد";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // kindsOfContractBindingSource
            // 
            this.kindsOfContractBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.ContractType);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.passNullCheckBox);
            this.panel2.Controls.Add(this.cancelButton);
            this.panel2.Controls.Add(this.selectButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 315);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 34);
            this.panel2.TabIndex = 1;
            // 
            // passNullCheckBox
            // 
            this.passNullCheckBox.AutoSize = true;
            this.passNullCheckBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.passNullCheckBox.Location = new System.Drawing.Point(294, 10);
            this.passNullCheckBox.Name = "passNullCheckBox";
            this.passNullCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passNullCheckBox.Size = new System.Drawing.Size(103, 18);
            this.passNullCheckBox.TabIndex = 5;
            this.passNullCheckBox.Text = "خالی بودن فیلد";
            this.passNullCheckBox.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cancelButton.Location = new System.Drawing.Point(107, 6);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 24);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "لغو";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.selectButton.Location = new System.Drawing.Point(188, 6);
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
            this.panel3.Size = new System.Drawing.Size(400, 37);
            this.panel3.TabIndex = 2;
            // 
            // filterNameLabel
            // 
            this.filterNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterNameLabel.AutoSize = true;
            this.filterNameLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.filterNameLabel.Location = new System.Drawing.Point(297, 11);
            this.filterNameLabel.Name = "filterNameLabel";
            this.filterNameLabel.Size = new System.Drawing.Size(75, 13);
            this.filterNameLabel.TabIndex = 3;
            this.filterNameLabel.Text = "جستجو قرارداد";
            // 
            // filterNameTextBox
            // 
            this.filterNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterNameTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.filterNameTextBox.Location = new System.Drawing.Point(58, 9);
            this.filterNameTextBox.Name = "filterNameTextBox";
            this.filterNameTextBox.Size = new System.Drawing.Size(230, 22);
            this.filterNameTextBox.TabIndex = 2;
            this.filterNameTextBox.TextChanged += new System.EventHandler(this.txtFilterName_TextChanged);
            // 
            // ContractTypeDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(406, 352);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContractTypeDialogForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "فرم انتخاب قرارداد های رایج در کشور";
            this.Load += new System.EventHandler(this.frmpopkindsofcontract_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contractTypeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindsOfContractBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource kindsOfContractBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label filterNameLabel;
        private System.Windows.Forms.TextBox filterNameTextBox;
        private System.Windows.Forms.CheckBox passNullCheckBox;
        private System.Windows.Forms.DataGridView contractTypeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}