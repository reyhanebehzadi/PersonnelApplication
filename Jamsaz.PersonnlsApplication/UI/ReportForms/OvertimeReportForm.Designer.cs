namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    partial class OvertimeReportForm
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
            Janus.Windows.GridEX.GridEXLayout searchResultDataGridView_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OvertimeReportForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.searchResultDataGridView = new Janus.Windows.GridEX.GridEX();
            this.getOvertimeReportResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MaxTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.departmentComboboxChilds = new System.Windows.Forms.ComboBox();
            this.childrenOfDepartmentbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.reportButton = new System.Windows.Forms.Button();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.monthTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.fiscalyearComboBox = new System.Windows.Forms.ComboBox();
            this.fiscalYearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getOvertimeReportResultBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.childrenOfDepartmentbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiscalYearBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.searchResultDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1244, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // searchResultDataGridView
            // 
            this.searchResultDataGridView.BackColor = System.Drawing.Color.SlateGray;
            this.searchResultDataGridView.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.searchResultDataGridView.DataSource = this.getOvertimeReportResultBindingSource;
            searchResultDataGridView_DesignTimeLayout.LayoutString = resources.GetString("searchResultDataGridView_DesignTimeLayout.LayoutString");
            this.searchResultDataGridView.DesignTimeLayout = searchResultDataGridView_DesignTimeLayout;
            this.searchResultDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchResultDataGridView.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.searchResultDataGridView.GroupByBoxVisible = false;
            this.searchResultDataGridView.Location = new System.Drawing.Point(3, 123);
            this.searchResultDataGridView.Name = "searchResultDataGridView";
            this.searchResultDataGridView.RecordNavigator = true;
            this.searchResultDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchResultDataGridView.RowFormatStyle.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.searchResultDataGridView.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
            this.searchResultDataGridView.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.searchResultDataGridView.Size = new System.Drawing.Size(1238, 435);
            this.searchResultDataGridView.TabIndex = 9;
            this.searchResultDataGridView.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.searchResultDataGridView.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // getOvertimeReportResultBindingSource
            // 
            this.getOvertimeReportResultBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.GetOvertimeReportResult);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.MaxTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.departmentComboboxChilds);
            this.groupBox1.Controls.Add(this.departmentComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.reportButton);
            this.groupBox1.Controls.Add(this.monthComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.fiscalyearComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1238, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "فیلتر";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 62;
            this.button2.Text = "مجوز اضافه کاری";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 61;
            this.button1.Text = "گزارش اضافه کاری";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MaxTextBox
            // 
            this.MaxTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxTextBox.Location = new System.Drawing.Point(892, 18);
            this.MaxTextBox.Name = "MaxTextBox";
            this.MaxTextBox.Size = new System.Drawing.Size(50, 21);
            this.MaxTextBox.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(948, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "بیشتر از:";
            // 
            // departmentComboboxChilds
            // 
            this.departmentComboboxChilds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentComboboxChilds.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.departmentComboboxChilds.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.departmentComboboxChilds.DataSource = this.childrenOfDepartmentbindingSource;
            this.departmentComboboxChilds.DisplayMember = "Name";
            this.departmentComboboxChilds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentComboboxChilds.FormattingEnabled = true;
            this.departmentComboboxChilds.Location = new System.Drawing.Point(792, 73);
            this.departmentComboboxChilds.Name = "departmentComboboxChilds";
            this.departmentComboboxChilds.Size = new System.Drawing.Size(228, 21);
            this.departmentComboboxChilds.TabIndex = 58;
            this.departmentComboboxChilds.ValueMember = "Id";
            // 
            // childrenOfDepartmentbindingSource
            // 
            this.childrenOfDepartmentbindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.Department);
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.departmentComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.departmentComboBox.DataSource = this.departmentBindingSource;
            this.departmentComboBox.DisplayMember = "Name";
            this.departmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(1026, 72);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(140, 21);
            this.departmentComboBox.TabIndex = 57;
            this.departmentComboBox.ValueMember = "Id";
            this.departmentComboBox.SelectedIndexChanged += new System.EventHandler(this.departmentComboBox_SelectedIndexChanged);
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.Department);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1169, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "واحد:";
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(9, 22);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(105, 23);
            this.reportButton.TabIndex = 4;
            this.reportButton.Text = "گزارش ";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // monthComboBox
            // 
            this.monthComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthComboBox.DataSource = this.monthTableBindingSource;
            this.monthComboBox.DisplayMember = "Title";
            this.monthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Location = new System.Drawing.Point(1026, 45);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(140, 21);
            this.monthComboBox.TabIndex = 3;
            this.monthComboBox.ValueMember = "ID";
            // 
            // monthTableBindingSource
            // 
            this.monthTableBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.MonthTable);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(1172, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ماه:";
            // 
            // fiscalyearComboBox
            // 
            this.fiscalyearComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fiscalyearComboBox.DataSource = this.fiscalYearBindingSource;
            this.fiscalyearComboBox.DisplayMember = "Title";
            this.fiscalyearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fiscalyearComboBox.FormattingEnabled = true;
            this.fiscalyearComboBox.Location = new System.Drawing.Point(1026, 18);
            this.fiscalyearComboBox.Name = "fiscalyearComboBox";
            this.fiscalyearComboBox.Size = new System.Drawing.Size(140, 21);
            this.fiscalyearComboBox.TabIndex = 1;
            this.fiscalyearComboBox.ValueMember = "ID";
            // 
            // fiscalYearBindingSource
            // 
            this.fiscalYearBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.FiscalYear);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(1169, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "سال مالی:";
            // 
            // OvertimeReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OvertimeReportForm";
            this.ShowIcon = false;
            this.Text = "اضافه کار ماهیانه";
            this.Load += new System.EventHandler(this.OvertimeReportForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchResultDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getOvertimeReportResultBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.childrenOfDepartmentbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiscalYearBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox fiscalyearComboBox;
        private System.Windows.Forms.BindingSource fiscalYearBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource monthTableBindingSource;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.BindingSource getOvertimeReportResultBindingSource;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox departmentComboboxChilds;
        private System.Windows.Forms.BindingSource childrenOfDepartmentbindingSource;
        private System.Windows.Forms.TextBox MaxTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Janus.Windows.GridEX.GridEX searchResultDataGridView;
    }
}