namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    partial class AccidentsDockForm
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
            this.accidentDataGridView = new System.Windows.Forms.DataGridView();
            this.accidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersianDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectToUseTitle = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentStatusTitle = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accidentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accidentBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.accidentDataGridView, -1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1213, 460);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // accidentDataGridView
            // 
            this.accidentDataGridView.AllowUserToAddRows = false;
            this.accidentDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.accidentDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.accidentDataGridView.AutoGenerateColumns = false;
            this.accidentDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.accidentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accidentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Column1,
            this.FullName,
            this.PersianDate,
            this.dataGridViewTextBoxColumn5,
            this.SubjectToUseTitle,
            this.dataGridViewTextBoxColumn7,
            this.PaymentStatusTitle,
            this.dataGridViewTextBoxColumn9});
            this.accidentDataGridView.DataSource = this.accidentBindingSource;
            this.accidentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accidentDataGridView.Location = new System.Drawing.Point(3, 3);
            this.accidentDataGridView.Name = "accidentDataGridView";
            this.accidentDataGridView.ReadOnly = true;
            this.accidentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.accidentDataGridView.Size = new System.Drawing.Size(1207, 394);
            this.accidentDataGridView.TabIndex = 1;
            // 
            // accidentBindingSource
            // 
            this.accidentBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.Accident);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.editButton);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 403);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1207, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.kedit;
            this.editButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editButton.Location = new System.Drawing.Point(1042, 20);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "ویرایش";
            this.editButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.l_cancel;
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteButton.Location = new System.Drawing.Point(961, 20);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "حذف";
            this.deleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.l_add;
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addButton.Location = new System.Drawing.Point(1123, 20);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "اضافه";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "کد";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PersonnelNumber";
            this.Column1.HeaderText = "شماره پرسنلی";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "پرسنل";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // PersianDate
            // 
            this.PersianDate.DataPropertyName = "PersianDate";
            this.PersianDate.HeaderText = "تاریخ";
            this.PersianDate.Name = "PersianDate";
            this.PersianDate.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "InjuredMember";
            this.dataGridViewTextBoxColumn5.HeaderText = "عضو حادثه دیده";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // SubjectToUseTitle
            // 
            this.SubjectToUseTitle.DataPropertyName = "SubjectToUse";
            this.SubjectToUseTitle.HeaderText = "مشمول استفاده از بیمه مسئولیت مدنی";
            this.SubjectToUseTitle.Name = "SubjectToUseTitle";
            this.SubjectToUseTitle.ReadOnly = true;
            this.SubjectToUseTitle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SubjectToUseTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SubjectToUseTitle.Width = 250;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "price";
            dataGridViewCellStyle2.Format = "N0";
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn7.HeaderText = "مبلغ خسارت";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // PaymentStatusTitle
            // 
            this.PaymentStatusTitle.DataPropertyName = "PaymentSatus";
            this.PaymentStatusTitle.HeaderText = "پرداخت ";
            this.PaymentStatusTitle.Name = "PaymentStatusTitle";
            this.PaymentStatusTitle.ReadOnly = true;
            this.PaymentStatusTitle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PaymentStatusTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn9.HeaderText = "توضیحات";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 200;
            // 
            // AccidentsDockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 460);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AccidentsDockForm";
            this.ShowIcon = false;
            this.Text = "وقوع حادثه";
            this.Load += new System.EventHandler(this.AccidentsDockForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accidentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accidentBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView accidentDataGridView;
        private System.Windows.Forms.BindingSource accidentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersianDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SubjectToUseTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PaymentStatusTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}