namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    partial class SettlementDockForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.settlementDataGridView = new System.Windows.Forms.DataGridView();
            this.settlementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.selectPersonnelButton = new System.Windows.Forms.Button();
            this.personnelNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PersonnelCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersianDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SettlementTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ComplainedAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pay_complaint = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AccidentComplaintAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pay_AccidentComplaint = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UnemploymentInsurance = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settlementDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settlementBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.settlementDataGridView, -1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1129, 486);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // settlementDataGridView
            // 
            this.settlementDataGridView.AllowUserToAddRows = false;
            this.settlementDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.settlementDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.settlementDataGridView.AutoGenerateColumns = false;
            this.settlementDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.settlementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.settlementDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonnelCode,
            this.PersianDate,
            this.SettlementTitle,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.ComplainedAmount,
            this.Pay_complaint,
            this.dataGridViewTextBoxColumn8,
            this.AccidentComplaintAmount,
            this.Pay_AccidentComplaint,
            this.UnemploymentInsurance,
            this.dataGridViewTextBoxColumn7});
            this.settlementDataGridView.DataSource = this.settlementBindingSource;
            this.settlementDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settlementDataGridView.Location = new System.Drawing.Point(3, 63);
            this.settlementDataGridView.Name = "settlementDataGridView";
            this.settlementDataGridView.ReadOnly = true;
            this.settlementDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.settlementDataGridView.Size = new System.Drawing.Size(1123, 360);
            this.settlementDataGridView.TabIndex = 2;
            // 
            // settlementBindingSource
            // 
            this.settlementBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.Settlement);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.editButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 429);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1123, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(958, 21);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "حذف";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Location = new System.Drawing.Point(1039, 20);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 0;
            this.editButton.Text = "ویرایش";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.selectPersonnelButton);
            this.groupBox2.Controls.Add(this.personnelNameTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1123, 54);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // selectPersonnelButton
            // 
            this.selectPersonnelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectPersonnelButton.Location = new System.Drawing.Point(818, 14);
            this.selectPersonnelButton.Name = "selectPersonnelButton";
            this.selectPersonnelButton.Size = new System.Drawing.Size(29, 23);
            this.selectPersonnelButton.TabIndex = 46;
            this.selectPersonnelButton.Text = "...";
            this.selectPersonnelButton.UseVisualStyleBackColor = true;
            this.selectPersonnelButton.Click += new System.EventHandler(this.selectPersonnelButton_Click);
            // 
            // personnelNameTextBox
            // 
            this.personnelNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.personnelNameTextBox.Location = new System.Drawing.Point(853, 16);
            this.personnelNameTextBox.Name = "personnelNameTextBox";
            this.personnelNameTextBox.ReadOnly = true;
            this.personnelNameTextBox.Size = new System.Drawing.Size(154, 21);
            this.personnelNameTextBox.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1013, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "پرسنل مورد نظر:";
            // 
            // PersonnelCode
            // 
            this.PersonnelCode.DataPropertyName = "PersonnelCode";
            this.PersonnelCode.HeaderText = "شماره پرسنلی";
            this.PersonnelCode.Name = "PersonnelCode";
            this.PersonnelCode.ReadOnly = true;
            // 
            // PersianDate
            // 
            this.PersianDate.DataPropertyName = "PersianDate";
            this.PersianDate.HeaderText = "تاریخ تسویه";
            this.PersianDate.Name = "PersianDate";
            this.PersianDate.ReadOnly = true;
            // 
            // SettlementTitle
            // 
            this.SettlementTitle.DataPropertyName = "SettlementTitle";
            this.SettlementTitle.HeaderText = "علت تسویه";
            this.SettlementTitle.Name = "SettlementTitle";
            this.SettlementTitle.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Price";
            dataGridViewCellStyle2.Format = "N0";
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn5.HeaderText = "مبلغ محاسبه شده";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Complained";
            this.dataGridViewTextBoxColumn6.HeaderText = "شکایت تسویه";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ComplainedAmount
            // 
            this.ComplainedAmount.DataPropertyName = "ComplainedAmount";
            dataGridViewCellStyle3.Format = "N0";
            this.ComplainedAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.ComplainedAmount.HeaderText = "مبلغ تسویه";
            this.ComplainedAmount.Name = "ComplainedAmount";
            this.ComplainedAmount.ReadOnly = true;
            // 
            // Pay_complaint
            // 
            this.Pay_complaint.DataPropertyName = "Pay_complaint";
            this.Pay_complaint.HeaderText = "پرداخت تسویه";
            this.Pay_complaint.Name = "Pay_complaint";
            this.Pay_complaint.ReadOnly = true;
            this.Pay_complaint.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Pay_complaint.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "AccidentComplaint";
            this.dataGridViewTextBoxColumn8.HeaderText = "شکایت حادثه";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // AccidentComplaintAmount
            // 
            this.AccidentComplaintAmount.DataPropertyName = "AccidentComplaintAmount";
            dataGridViewCellStyle4.Format = "N0";
            this.AccidentComplaintAmount.DefaultCellStyle = dataGridViewCellStyle4;
            this.AccidentComplaintAmount.HeaderText = "مبلغ حادثه";
            this.AccidentComplaintAmount.Name = "AccidentComplaintAmount";
            this.AccidentComplaintAmount.ReadOnly = true;
            // 
            // Pay_AccidentComplaint
            // 
            this.Pay_AccidentComplaint.DataPropertyName = "Pay_AccidentComplaint";
            this.Pay_AccidentComplaint.HeaderText = "پرداخت حادثه";
            this.Pay_AccidentComplaint.Name = "Pay_AccidentComplaint";
            this.Pay_AccidentComplaint.ReadOnly = true;
            this.Pay_AccidentComplaint.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Pay_AccidentComplaint.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // UnemploymentInsurance
            // 
            this.UnemploymentInsurance.DataPropertyName = "UnemploymentInsurance";
            this.UnemploymentInsurance.HeaderText = "بیمه بیکاری";
            this.UnemploymentInsurance.Name = "UnemploymentInsurance";
            this.UnemploymentInsurance.ReadOnly = true;
            this.UnemploymentInsurance.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UnemploymentInsurance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn7.HeaderText = "توضیحات";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // SettlementDockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 486);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SettlementDockForm";
            this.ShowIcon = false;
            this.Text = "تسویه پرسنل";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.settlementDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settlementBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selectPersonnelButton;
        private System.Windows.Forms.TextBox personnelNameTextBox;
        private System.Windows.Forms.BindingSource settlementBindingSource;
        private System.Windows.Forms.DataGridView settlementDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonnelCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersianDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SettlementTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComplainedAmount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Pay_complaint;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccidentComplaintAmount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Pay_AccidentComplaint;
        private System.Windows.Forms.DataGridViewCheckBoxColumn UnemploymentInsurance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}