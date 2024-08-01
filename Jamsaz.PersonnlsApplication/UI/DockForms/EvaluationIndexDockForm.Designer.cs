namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    partial class EvaluationIndexDockForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DeleteEvaButton = new System.Windows.Forms.Button();
            this.EditEvaButton = new System.Windows.Forms.Button();
            this.AddEvaButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluationIndexBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FiscalYearsCombo = new System.Windows.Forms.ComboBox();
            this.fiscalYearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriesIndexEvaluationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DeleteCateguryButton = new System.Windows.Forms.Button();
            this.EditCateguryButton = new System.Windows.Forms.Button();
            this.AddCateguryButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluationIndexBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fiscalYearBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesIndexEvaluationBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(747, 719);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DeleteEvaButton);
            this.groupBox2.Controls.Add(this.EditEvaButton);
            this.groupBox2.Controls.Add(this.AddEvaButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 661);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(741, 55);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // DeleteEvaButton
            // 
            this.DeleteEvaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteEvaButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.l_cancel;
            this.DeleteEvaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteEvaButton.Location = new System.Drawing.Point(493, 20);
            this.DeleteEvaButton.Name = "DeleteEvaButton";
            this.DeleteEvaButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteEvaButton.TabIndex = 2;
            this.DeleteEvaButton.Text = "حذف";
            this.DeleteEvaButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteEvaButton.UseVisualStyleBackColor = true;
            this.DeleteEvaButton.Click += new System.EventHandler(this.DeleteEvaButton_Click);
            // 
            // EditEvaButton
            // 
            this.EditEvaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditEvaButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.kedit;
            this.EditEvaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditEvaButton.Location = new System.Drawing.Point(574, 20);
            this.EditEvaButton.Name = "EditEvaButton";
            this.EditEvaButton.Size = new System.Drawing.Size(75, 23);
            this.EditEvaButton.TabIndex = 1;
            this.EditEvaButton.Text = "ویرایش";
            this.EditEvaButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditEvaButton.UseVisualStyleBackColor = true;
            this.EditEvaButton.Click += new System.EventHandler(this.EditEvaButton_Click);
            // 
            // AddEvaButton
            // 
            this.AddEvaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddEvaButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.l_add;
            this.AddEvaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddEvaButton.Location = new System.Drawing.Point(655, 20);
            this.AddEvaButton.Name = "AddEvaButton";
            this.AddEvaButton.Size = new System.Drawing.Size(75, 23);
            this.AddEvaButton.TabIndex = 0;
            this.AddEvaButton.Text = "اضافه";
            this.AddEvaButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddEvaButton.UseVisualStyleBackColor = true;
            this.AddEvaButton.Click += new System.EventHandler(this.AddEvaButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.evaluationIndexBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 284);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(741, 371);
            this.dataGridView2.TabIndex = 4;
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
            this.titleDataGridViewTextBoxColumn.HeaderText = "عنوان";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 500;
            // 
            // evaluationIndexBindingSource
            // 
            this.evaluationIndexBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.EvaluationIndex);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FiscalYearsCombo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // FiscalYearsCombo
            // 
            this.FiscalYearsCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FiscalYearsCombo.DataSource = this.fiscalYearBindingSource;
            this.FiscalYearsCombo.DisplayMember = "Title";
            this.FiscalYearsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiscalYearsCombo.FormattingEnabled = true;
            this.FiscalYearsCombo.Location = new System.Drawing.Point(468, 20);
            this.FiscalYearsCombo.Name = "FiscalYearsCombo";
            this.FiscalYearsCombo.Size = new System.Drawing.Size(181, 21);
            this.FiscalYearsCombo.TabIndex = 1;
            this.FiscalYearsCombo.ValueMember = "ID";
            // 
            // fiscalYearBindingSource
            // 
            this.fiscalYearBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.FiscalYear);
            this.fiscalYearBindingSource.PositionChanged += new System.EventHandler(this.fiscalYearBindingSource_PositionChanged_1);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(653, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "سال مالی : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.DataSource = this.categoriesIndexEvaluationBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 63);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(741, 155);
            this.dataGridView1.TabIndex = 5;
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
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // categoriesIndexEvaluationBindingSource
            // 
            this.categoriesIndexEvaluationBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.CategoriesIndexEvaluation);
            this.categoriesIndexEvaluationBindingSource.PositionChanged += new System.EventHandler(this.categoriesIndexEvaluationBindingSource_PositionChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DeleteCateguryButton);
            this.groupBox3.Controls.Add(this.EditCateguryButton);
            this.groupBox3.Controls.Add(this.AddCateguryButton);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(741, 54);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // DeleteCateguryButton
            // 
            this.DeleteCateguryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteCateguryButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.l_cancel;
            this.DeleteCateguryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteCateguryButton.Location = new System.Drawing.Point(493, 20);
            this.DeleteCateguryButton.Name = "DeleteCateguryButton";
            this.DeleteCateguryButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteCateguryButton.TabIndex = 5;
            this.DeleteCateguryButton.Text = "حذف";
            this.DeleteCateguryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteCateguryButton.UseVisualStyleBackColor = true;
            this.DeleteCateguryButton.Click += new System.EventHandler(this.DeleteCateguryButton_Click);
            // 
            // EditCateguryButton
            // 
            this.EditCateguryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditCateguryButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.kedit;
            this.EditCateguryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditCateguryButton.Location = new System.Drawing.Point(574, 20);
            this.EditCateguryButton.Name = "EditCateguryButton";
            this.EditCateguryButton.Size = new System.Drawing.Size(75, 23);
            this.EditCateguryButton.TabIndex = 4;
            this.EditCateguryButton.Text = "ویرایش";
            this.EditCateguryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditCateguryButton.UseVisualStyleBackColor = true;
            this.EditCateguryButton.Click += new System.EventHandler(this.EditCateguryButton_Click);
            // 
            // AddCateguryButton
            // 
            this.AddCateguryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCateguryButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.l_add;
            this.AddCateguryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddCateguryButton.Location = new System.Drawing.Point(655, 20);
            this.AddCateguryButton.Name = "AddCateguryButton";
            this.AddCateguryButton.Size = new System.Drawing.Size(75, 23);
            this.AddCateguryButton.TabIndex = 3;
            this.AddCateguryButton.Text = "اضافه";
            this.AddCateguryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddCateguryButton.UseVisualStyleBackColor = true;
            this.AddCateguryButton.Click += new System.EventHandler(this.AddCateguryButton_Click);
            // 
            // EvaluationIndexDockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 719);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EvaluationIndexDockForm";
            this.ShowIcon = false;
            this.Text = "ثبت شاخص ارزیابی";
            this.Load += new System.EventHandler(this.EvaluationIndexDockForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluationIndexBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fiscalYearBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesIndexEvaluationBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DeleteEvaButton;
        private System.Windows.Forms.Button EditEvaButton;
        private System.Windows.Forms.Button AddEvaButton;
        private System.Windows.Forms.BindingSource evaluationIndexBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox FiscalYearsCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button DeleteCateguryButton;
        private System.Windows.Forms.Button EditCateguryButton;
        private System.Windows.Forms.Button AddCateguryButton;
        private System.Windows.Forms.BindingSource categoriesIndexEvaluationBindingSource;
        private System.Windows.Forms.BindingSource fiscalYearBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
    }
}