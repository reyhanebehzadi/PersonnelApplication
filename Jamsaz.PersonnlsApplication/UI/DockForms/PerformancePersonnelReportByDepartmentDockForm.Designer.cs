namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    partial class PerformancePersonnelReportByDepartmentDockForm
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
            Janus.Windows.GridEX.GridEXLayout listGroupGrid_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerformancePersonnelReportByDepartmentDockForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.averageText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.scoreSumText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listGroupGrid = new Janus.Windows.GridEX.GridEX();
            this.performanceByDepartmentResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.startAcumelateCombobox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.endAcumelateCombobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stepComboBox = new System.Windows.Forms.ComboBox();
            this.evaluationStepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scatterReportButton = new System.Windows.Forms.Button();
            this.departmentComboboxChilds = new System.Windows.Forms.ComboBox();
            this.childrenOfDepartmentbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportButtonAllDepartmentList = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listGroupGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceByDepartmentResultBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.evaluationStepBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenOfDepartmentbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.listGroupGrid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.82799F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.17201F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1006, 728);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.averageText);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.scoreSumText);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 689);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1000, 36);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // averageText
            // 
            this.averageText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.averageText.Location = new System.Drawing.Point(620, 12);
            this.averageText.Name = "averageText";
            this.averageText.ReadOnly = true;
            this.averageText.Size = new System.Drawing.Size(100, 21);
            this.averageText.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(726, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "میانگین امتیاز ها:";
            // 
            // scoreSumText
            // 
            this.scoreSumText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreSumText.Location = new System.Drawing.Point(816, 12);
            this.scoreSumText.Name = "scoreSumText";
            this.scoreSumText.ReadOnly = true;
            this.scoreSumText.Size = new System.Drawing.Size(100, 21);
            this.scoreSumText.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(922, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "جمع امتیاز ها:";
            // 
            // listGroupGrid
            // 
            this.listGroupGrid.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.listGroupGrid.DataSource = this.performanceByDepartmentResultBindingSource;
            listGroupGrid_DesignTimeLayout.LayoutString = resources.GetString("listGroupGrid_DesignTimeLayout.LayoutString");
            this.listGroupGrid.DesignTimeLayout = listGroupGrid_DesignTimeLayout;
            this.listGroupGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listGroupGrid.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.listGroupGrid.GroupByBoxVisible = false;
            this.listGroupGrid.Location = new System.Drawing.Point(3, 91);
            this.listGroupGrid.Name = "listGroupGrid";
            this.listGroupGrid.RecordNavigator = true;
            this.listGroupGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listGroupGrid.RowFormatStyle.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.listGroupGrid.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.listGroupGrid.Size = new System.Drawing.Size(1000, 592);
            this.listGroupGrid.TabIndex = 6;
            this.listGroupGrid.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.listGroupGrid.SortKeysChanged += new System.EventHandler(this.listGroupGrid_SortKeysChanged);
            // 
            // performanceByDepartmentResultBindingSource
            // 
            this.performanceByDepartmentResultBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.PerformanceByDepartmentResult);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reportButtonAllDepartmentList);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.startAcumelateCombobox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.endAcumelateCombobox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.stepComboBox);
            this.groupBox1.Controls.Add(this.scatterReportButton);
            this.groupBox1.Controls.Add(this.departmentComboboxChilds);
            this.groupBox1.Controls.Add(this.reportButton);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.departmentComboBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 82);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(601, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "تا:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(796, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "از امتیاز:";
            // 
            // startAcumelateCombobox
            // 
            this.startAcumelateCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startAcumelateCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startAcumelateCombobox.FormattingEnabled = true;
            this.startAcumelateCombobox.Items.AddRange(new object[] {
            "بدون فیلتر",
            "بیشتر از μ + 3a",
            "μ + 3a",
            "μ + 2a",
            "μ + a",
            "μ - a",
            "μ - 2a",
            "μ - 3a",
            "کمتر از μ - 3a"});
            this.startAcumelateCombobox.Location = new System.Drawing.Point(633, 49);
            this.startAcumelateCombobox.Name = "startAcumelateCombobox";
            this.startAcumelateCombobox.Size = new System.Drawing.Size(157, 21);
            this.startAcumelateCombobox.TabIndex = 49;
            this.startAcumelateCombobox.SelectedIndexChanged += new System.EventHandler(this.startAcumelateCombobox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(912, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "نوع امتیاز بندی:";
            // 
            // endAcumelateCombobox
            // 
            this.endAcumelateCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.endAcumelateCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endAcumelateCombobox.FormattingEnabled = true;
            this.endAcumelateCombobox.Items.AddRange(new object[] {
            "بدون فیلتر",
            "بیشتر از μ + 3a",
            "μ + 3a",
            "μ + 2a",
            "μ + a",
            "μ - a",
            "μ - 2a",
            "μ - 3a",
            "کمتر از μ + 3a"});
            this.endAcumelateCombobox.Location = new System.Drawing.Point(441, 49);
            this.endAcumelateCombobox.Name = "endAcumelateCombobox";
            this.endAcumelateCombobox.Size = new System.Drawing.Size(145, 21);
            this.endAcumelateCombobox.TabIndex = 47;
            this.endAcumelateCombobox.SelectedIndexChanged += new System.EventHandler(this.endAcumelateCombobox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(592, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "مرحله:";
            // 
            // stepComboBox
            // 
            this.stepComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stepComboBox.DataSource = this.evaluationStepBindingSource;
            this.stepComboBox.DisplayMember = "Name";
            this.stepComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stepComboBox.FormattingEnabled = true;
            this.stepComboBox.Location = new System.Drawing.Point(441, 18);
            this.stepComboBox.Name = "stepComboBox";
            this.stepComboBox.Size = new System.Drawing.Size(145, 21);
            this.stepComboBox.TabIndex = 45;
            this.stepComboBox.ValueMember = "ID";
            // 
            // evaluationStepBindingSource
            // 
            this.evaluationStepBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.EvaluationStep);
            // 
            // scatterReportButton
            // 
            this.scatterReportButton.Location = new System.Drawing.Point(92, 16);
            this.scatterReportButton.Name = "scatterReportButton";
            this.scatterReportButton.Size = new System.Drawing.Size(107, 23);
            this.scatterReportButton.TabIndex = 8;
            this.scatterReportButton.Text = "چاپ نمودار نقطه ای";
            this.scatterReportButton.UseVisualStyleBackColor = true;
            this.scatterReportButton.Click += new System.EventHandler(this.scatterReportButton_Click);
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
            this.departmentComboboxChilds.Location = new System.Drawing.Point(633, 18);
            this.departmentComboboxChilds.Name = "departmentComboboxChilds";
            this.departmentComboboxChilds.Size = new System.Drawing.Size(157, 21);
            this.departmentComboboxChilds.TabIndex = 7;
            this.departmentComboboxChilds.ValueMember = "Id";
            // 
            // childrenOfDepartmentbindingSource
            // 
            this.childrenOfDepartmentbindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.Department);
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(6, 16);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(80, 23);
            this.reportButton.TabIndex = 6;
            this.reportButton.Text = "چاپ گزارش";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(355, 32);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(80, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "جستجو";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(959, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "واحد:";
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
            this.departmentComboBox.Location = new System.Drawing.Point(796, 18);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(157, 21);
            this.departmentComboBox.TabIndex = 3;
            this.departmentComboBox.ValueMember = "Id";
            this.departmentComboBox.SelectedIndexChanged += new System.EventHandler(this.departmentComboBox_SelectedIndexChanged);
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.Department);
            // 
            // reportButtonAllDepartmentList
            // 
            this.reportButtonAllDepartmentList.Location = new System.Drawing.Point(6, 45);
            this.reportButtonAllDepartmentList.Name = "reportButtonAllDepartmentList";
            this.reportButtonAllDepartmentList.Size = new System.Drawing.Size(80, 23);
            this.reportButtonAllDepartmentList.TabIndex = 52;
            this.reportButtonAllDepartmentList.Text = "چاپ لیست";
            this.reportButtonAllDepartmentList.UseVisualStyleBackColor = true;
            this.reportButtonAllDepartmentList.Click += new System.EventHandler(this.reportButtonAllDepartmentList_Click);
            // 
            // PerformancePersonnelReportByDepartmentDockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 728);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PerformancePersonnelReportByDepartmentDockForm";
            this.Text = "گزارش عملکرد پرسنل";
            this.Load += new System.EventHandler(this.PerformancePersonnelReportByDepartmentDockForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listGroupGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceByDepartmentResultBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.evaluationStepBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenOfDepartmentbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private Janus.Windows.GridEX.GridEX listGroupGrid;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox averageText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox scoreSumText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox departmentComboboxChilds;
        private System.Windows.Forms.BindingSource childrenOfDepartmentbindingSource;
        private System.Windows.Forms.BindingSource performanceByDepartmentResultBindingSource;
        private System.Windows.Forms.Button scatterReportButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox stepComboBox;
        private System.Windows.Forms.BindingSource evaluationStepBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox endAcumelateCombobox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox startAcumelateCombobox;
        private System.Windows.Forms.Button reportButtonAllDepartmentList;
    }
}