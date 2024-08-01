namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class PersonnelPayRollDialogForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.payrollDataGridView = new System.Windows.Forms.DataGridView();
            this.payRollBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sumToWrittenTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.voidButton = new System.Windows.Forms.Button();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hagheOladDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HagheTaahol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hagheMaskanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haghekharobarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hagheSarparstiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HagheJazb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hagheSakhtiKarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftPercentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mablagheNobateKariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HagheGhaza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HagheAyabZahab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effectiveDateDataGridViewTextBoxColumn = new FarsiLibrary.Win.Controls.DataGridViewFADateTimePickerColumn();
            this.EffectiveDateEnd = new FarsiLibrary.Win.Controls.DataGridViewFADateTimePickerColumn();
            this.payRollSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.payrollDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payRollBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // payrollDataGridView
            // 
            this.payrollDataGridView.AllowUserToAddRows = false;
            this.payrollDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            this.payrollDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.payrollDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.payrollDataGridView.AutoGenerateColumns = false;
            this.payrollDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(218)))), ((int)(((byte)(254)))));
            this.payrollDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payrollDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salaryDataGridViewTextBoxColumn,
            this.hagheOladDataGridViewTextBoxColumn,
            this.HagheTaahol,
            this.hagheMaskanDataGridViewTextBoxColumn,
            this.haghekharobarDataGridViewTextBoxColumn,
            this.hagheSarparstiDataGridViewTextBoxColumn,
            this.HagheJazb,
            this.hagheSakhtiKarDataGridViewTextBoxColumn,
            this.shiftPercentDataGridViewTextBoxColumn,
            this.mablagheNobateKariDataGridViewTextBoxColumn,
            this.HagheGhaza,
            this.HagheAyabZahab,
            this.effectiveDateDataGridViewTextBoxColumn,
            this.EffectiveDateEnd,
            this.payRollSumDataGridViewTextBoxColumn});
            this.payrollDataGridView.DataSource = this.payRollBindingSource;
            this.payrollDataGridView.Location = new System.Drawing.Point(3, 56);
            this.payrollDataGridView.Name = "payrollDataGridView";
            this.payrollDataGridView.RowHeadersWidth = 20;
            this.payrollDataGridView.RowTemplate.Height = 30;
            this.payrollDataGridView.Size = new System.Drawing.Size(926, 416);
            this.payrollDataGridView.TabIndex = 0;
            this.payrollDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.payrollDataGridView_CellEndEdit);
            // 
            // payRollBindingSource
            // 
            this.payRollBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.PayRoll);
            this.payRollBindingSource.PositionChanged += new System.EventHandler(this.payRollBindingSource_PositionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.sumToWrittenTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(926, 52);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "حقوق و دستمزد";
            // 
            // sumToWrittenTextBox
            // 
            this.sumToWrittenTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sumToWrittenTextBox.Location = new System.Drawing.Point(7, 20);
            this.sumToWrittenTextBox.Name = "sumToWrittenTextBox";
            this.sumToWrittenTextBox.Size = new System.Drawing.Size(812, 21);
            this.sumToWrittenTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(825, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "جمع حقوق و مزایا";
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButton.Location = new System.Drawing.Point(12, 478);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "اضافه";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteButton.Location = new System.Drawing.Point(93, 478);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "حذف";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(854, 478);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "ذخیره";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // voidButton
            // 
            this.voidButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.voidButton.Location = new System.Drawing.Point(773, 478);
            this.voidButton.Name = "voidButton";
            this.voidButton.Size = new System.Drawing.Size(75, 23);
            this.voidButton.TabIndex = 4;
            this.voidButton.Text = "لغو";
            this.voidButton.UseVisualStyleBackColor = true;
            this.voidButton.Click += new System.EventHandler(this.voidButton_Click);
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "C0";
            dataGridViewCellStyle2.NullValue = null;
            this.salaryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.salaryDataGridViewTextBoxColumn.HeaderText = "پایه حقوق";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // hagheOladDataGridViewTextBoxColumn
            // 
            this.hagheOladDataGridViewTextBoxColumn.DataPropertyName = "HagheOlad";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "C0";
            dataGridViewCellStyle3.NullValue = null;
            this.hagheOladDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.hagheOladDataGridViewTextBoxColumn.HeaderText = "حق اولاد";
            this.hagheOladDataGridViewTextBoxColumn.Name = "hagheOladDataGridViewTextBoxColumn";
            this.hagheOladDataGridViewTextBoxColumn.Width = 80;
            // 
            // HagheTaahol
            // 
            this.HagheTaahol.DataPropertyName = "HagheTaahol";
            dataGridViewCellStyle4.Format = "C0";
            this.HagheTaahol.DefaultCellStyle = dataGridViewCellStyle4;
            this.HagheTaahol.HeaderText = "حق تاهل";
            this.HagheTaahol.Name = "HagheTaahol";
            // 
            // hagheMaskanDataGridViewTextBoxColumn
            // 
            this.hagheMaskanDataGridViewTextBoxColumn.DataPropertyName = "HagheMaskan";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "C0";
            this.hagheMaskanDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.hagheMaskanDataGridViewTextBoxColumn.HeaderText = "حق مسکن";
            this.hagheMaskanDataGridViewTextBoxColumn.Name = "hagheMaskanDataGridViewTextBoxColumn";
            this.hagheMaskanDataGridViewTextBoxColumn.Width = 80;
            // 
            // haghekharobarDataGridViewTextBoxColumn
            // 
            this.haghekharobarDataGridViewTextBoxColumn.DataPropertyName = "Haghekharobar";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "C0";
            this.haghekharobarDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.haghekharobarDataGridViewTextBoxColumn.HeaderText = "کمک هزینه اقلام مصرفی";
            this.haghekharobarDataGridViewTextBoxColumn.Name = "haghekharobarDataGridViewTextBoxColumn";
            this.haghekharobarDataGridViewTextBoxColumn.Width = 140;
            // 
            // hagheSarparstiDataGridViewTextBoxColumn
            // 
            this.hagheSarparstiDataGridViewTextBoxColumn.DataPropertyName = "HagheSarparsti";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "C0";
            this.hagheSarparstiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.hagheSarparstiDataGridViewTextBoxColumn.HeaderText = "حق سرپرستی";
            this.hagheSarparstiDataGridViewTextBoxColumn.Name = "hagheSarparstiDataGridViewTextBoxColumn";
            this.hagheSarparstiDataGridViewTextBoxColumn.Width = 80;
            // 
            // HagheJazb
            // 
            this.HagheJazb.DataPropertyName = "HagheJazb";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Format = "C0";
            this.HagheJazb.DefaultCellStyle = dataGridViewCellStyle8;
            this.HagheJazb.HeaderText = "حق جذب";
            this.HagheJazb.Name = "HagheJazb";
            // 
            // hagheSakhtiKarDataGridViewTextBoxColumn
            // 
            this.hagheSakhtiKarDataGridViewTextBoxColumn.DataPropertyName = "HagheSakhtiKar";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Format = "C0";
            this.hagheSakhtiKarDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.hagheSakhtiKarDataGridViewTextBoxColumn.HeaderText = "حق سختی کار";
            this.hagheSakhtiKarDataGridViewTextBoxColumn.Name = "hagheSakhtiKarDataGridViewTextBoxColumn";
            this.hagheSakhtiKarDataGridViewTextBoxColumn.Width = 80;
            // 
            // shiftPercentDataGridViewTextBoxColumn
            // 
            this.shiftPercentDataGridViewTextBoxColumn.DataPropertyName = "ShiftPercent";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.NullValue = null;
            this.shiftPercentDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.shiftPercentDataGridViewTextBoxColumn.HeaderText = "درصد نوبت کاری";
            this.shiftPercentDataGridViewTextBoxColumn.Name = "shiftPercentDataGridViewTextBoxColumn";
            this.shiftPercentDataGridViewTextBoxColumn.Width = 80;
            // 
            // mablagheNobateKariDataGridViewTextBoxColumn
            // 
            this.mablagheNobateKariDataGridViewTextBoxColumn.DataPropertyName = "MablagheNobateKari";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Format = "C0";
            this.mablagheNobateKariDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.mablagheNobateKariDataGridViewTextBoxColumn.HeaderText = "مبلغ نوبت کاری";
            this.mablagheNobateKariDataGridViewTextBoxColumn.Name = "mablagheNobateKariDataGridViewTextBoxColumn";
            this.mablagheNobateKariDataGridViewTextBoxColumn.Width = 80;
            // 
            // HagheGhaza
            // 
            this.HagheGhaza.DataPropertyName = "HagheGhaza";
            dataGridViewCellStyle12.Format = "C0";
            this.HagheGhaza.DefaultCellStyle = dataGridViewCellStyle12;
            this.HagheGhaza.HeaderText = "حق غذا";
            this.HagheGhaza.Name = "HagheGhaza";
            // 
            // HagheAyabZahab
            // 
            this.HagheAyabZahab.DataPropertyName = "HagheAyabZahab";
            dataGridViewCellStyle13.Format = "C0";
            this.HagheAyabZahab.DefaultCellStyle = dataGridViewCellStyle13;
            this.HagheAyabZahab.HeaderText = "حق ایاب ذهاب";
            this.HagheAyabZahab.Name = "HagheAyabZahab";
            // 
            // effectiveDateDataGridViewTextBoxColumn
            // 
            this.effectiveDateDataGridViewTextBoxColumn.DataPropertyName = "EffectiveDate";
            this.effectiveDateDataGridViewTextBoxColumn.HeaderText = "تاریخ اثر بخشی";
            this.effectiveDateDataGridViewTextBoxColumn.Name = "effectiveDateDataGridViewTextBoxColumn";
            this.effectiveDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.effectiveDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // EffectiveDateEnd
            // 
            this.EffectiveDateEnd.DataPropertyName = "EffectiveDateEnd";
            this.EffectiveDateEnd.HeaderText = "پایان تاریخ اثربخشی";
            this.EffectiveDateEnd.Name = "EffectiveDateEnd";
            this.EffectiveDateEnd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EffectiveDateEnd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // payRollSumDataGridViewTextBoxColumn
            // 
            this.payRollSumDataGridViewTextBoxColumn.DataPropertyName = "PayRollSum";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Format = "C0";
            this.payRollSumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.payRollSumDataGridViewTextBoxColumn.HeaderText = "جمع حقوق و مزایا";
            this.payRollSumDataGridViewTextBoxColumn.Name = "payRollSumDataGridViewTextBoxColumn";
            this.payRollSumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PersonnelPayRollDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(218)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(934, 512);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.voidButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.payrollDataGridView);
            this.Name = "PersonnelPayRollDialogForm";
            this.ShowIcon = false;
            this.Text = "";
            this.Load += new System.EventHandler(this.PersonnelPayRollDialogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payrollDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payRollBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView payrollDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource payRollBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button voidButton;
        private System.Windows.Forms.TextBox sumToWrittenTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hagheOladDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HagheTaahol;
        private System.Windows.Forms.DataGridViewTextBoxColumn hagheMaskanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn haghekharobarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hagheSarparstiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HagheJazb;
        private System.Windows.Forms.DataGridViewTextBoxColumn hagheSakhtiKarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftPercentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mablagheNobateKariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HagheGhaza;
        private System.Windows.Forms.DataGridViewTextBoxColumn HagheAyabZahab;
        private FarsiLibrary.Win.Controls.DataGridViewFADateTimePickerColumn effectiveDateDataGridViewTextBoxColumn;
        private FarsiLibrary.Win.Controls.DataGridViewFADateTimePickerColumn EffectiveDateEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn payRollSumDataGridViewTextBoxColumn;
    }
}