namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    partial class StaffPayrollReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffPayrollReportForm));
            this.searchResultDataGridView = new Janus.Windows.GridEX.GridEX();
            this.getStaffPayrollResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.organizationPostComboBox = new System.Windows.Forms.ComboBox();
            this.organizationPostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.familyTextBox = new System.Windows.Forms.TextBox();
            this.departmentComboboxChilds = new System.Windows.Forms.ComboBox();
            this.childrenOfDepartmentbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchButton = new System.Windows.Forms.Button();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.personnelNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.perssonelNumberLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getStaffPayrollResultBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.organizationPostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenOfDepartmentbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // searchResultDataGridView
            // 
            this.searchResultDataGridView.BackColor = System.Drawing.Color.SlateGray;
            this.searchResultDataGridView.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.searchResultDataGridView.DataSource = this.getStaffPayrollResultBindingSource;
            searchResultDataGridView_DesignTimeLayout.LayoutString = resources.GetString("searchResultDataGridView_DesignTimeLayout.LayoutString");
            this.searchResultDataGridView.DesignTimeLayout = searchResultDataGridView_DesignTimeLayout;
            this.searchResultDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchResultDataGridView.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.searchResultDataGridView.GroupByBoxVisible = false;
            this.searchResultDataGridView.Location = new System.Drawing.Point(3, 103);
            this.searchResultDataGridView.Name = "searchResultDataGridView";
            this.searchResultDataGridView.RecordNavigator = true;
            this.searchResultDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchResultDataGridView.RowFormatStyle.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.searchResultDataGridView.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
            this.searchResultDataGridView.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.searchResultDataGridView.Size = new System.Drawing.Size(794, 344);
            this.searchResultDataGridView.TabIndex = 10;
            this.searchResultDataGridView.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.searchResultDataGridView.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // getStaffPayrollResultBindingSource
            // 
            this.getStaffPayrollResultBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.GetStaffPayrollResult);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.organizationPostComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.familyTextBox);
            this.groupBox1.Controls.Add(this.departmentComboboxChilds);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.departmentComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.personnelNumberTextBox);
            this.groupBox1.Controls.Add(this.perssonelNumberLabel);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 94);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو";
            // 
            // organizationPostComboBox
            // 
            this.organizationPostComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.organizationPostComboBox.DataSource = this.organizationPostBindingSource;
            this.organizationPostComboBox.DisplayMember = "Title";
            this.organizationPostComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.organizationPostComboBox.FormattingEnabled = true;
            this.organizationPostComboBox.Location = new System.Drawing.Point(224, 47);
            this.organizationPostComboBox.Name = "organizationPostComboBox";
            this.organizationPostComboBox.Size = new System.Drawing.Size(109, 21);
            this.organizationPostComboBox.TabIndex = 62;
            this.organizationPostComboBox.ValueMember = "ID";
            // 
            // organizationPostBindingSource
            // 
            this.organizationPostBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.OrganizationPost);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(375, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 14);
            this.label3.TabIndex = 61;
            this.label3.Text = "نام خانوادگی";
            // 
            // familyTextBox
            // 
            this.familyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.familyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.familyTextBox.Location = new System.Drawing.Point(272, 17);
            this.familyTextBox.Name = "familyTextBox";
            this.familyTextBox.Size = new System.Drawing.Size(97, 21);
            this.familyTextBox.TabIndex = 60;
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
            this.departmentComboboxChilds.Location = new System.Drawing.Point(409, 47);
            this.departmentComboboxChilds.Name = "departmentComboboxChilds";
            this.departmentComboboxChilds.Size = new System.Drawing.Size(139, 21);
            this.departmentComboboxChilds.TabIndex = 59;
            this.departmentComboboxChilds.ValueMember = "Id";
            // 
            // childrenOfDepartmentbindingSource
            // 
            this.childrenOfDepartmentbindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.Department);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(9, 44);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 24);
            this.searchButton.TabIndex = 58;
            this.searchButton.Text = "نمایش";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
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
            this.departmentComboBox.Location = new System.Drawing.Point(554, 47);
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(694, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 14);
            this.label1.TabIndex = 56;
            this.label1.Text = "واحد";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(339, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 14);
            this.label2.TabIndex = 45;
            this.label2.Text = "سمت";
            // 
            // personnelNumberTextBox
            // 
            this.personnelNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.personnelNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.personnelNumberTextBox.Location = new System.Drawing.Point(644, 20);
            this.personnelNumberTextBox.Mask = "0000";
            this.personnelNumberTextBox.Name = "personnelNumberTextBox";
            this.personnelNumberTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.personnelNumberTextBox.Size = new System.Drawing.Size(50, 21);
            this.personnelNumberTextBox.TabIndex = 41;
            this.personnelNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // perssonelNumberLabel
            // 
            this.perssonelNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.perssonelNumberLabel.AutoSize = true;
            this.perssonelNumberLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perssonelNumberLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.perssonelNumberLabel.Location = new System.Drawing.Point(695, 24);
            this.perssonelNumberLabel.Name = "perssonelNumberLabel";
            this.perssonelNumberLabel.Size = new System.Drawing.Size(84, 14);
            this.perssonelNumberLabel.TabIndex = 40;
            this.perssonelNumberLabel.Text = "شماره پرسنلی";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.nameLabel.Location = new System.Drawing.Point(583, 21);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(21, 14);
            this.nameLabel.TabIndex = 38;
            this.nameLabel.Text = "نام";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.Location = new System.Drawing.Point(480, 17);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(97, 21);
            this.NameTextBox.TabIndex = 36;
            // 
            // StaffPayrollReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StaffPayrollReportForm";
            this.ShowIcon = false;
            this.Text = "گزارش حقوق و دستمزد";
            this.Load += new System.EventHandler(this.StaffPayrollReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchResultDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getStaffPayrollResultBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.organizationPostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenOfDepartmentbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.GridEX searchResultDataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource getStaffPayrollResultBindingSource;
        private System.Windows.Forms.MaskedTextBox personnelNumberTextBox;
        private System.Windows.Forms.Label perssonelNumberLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private System.Windows.Forms.ComboBox departmentComboboxChilds;
        private System.Windows.Forms.BindingSource childrenOfDepartmentbindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox familyTextBox;
        private System.Windows.Forms.ComboBox organizationPostComboBox;
        private System.Windows.Forms.BindingSource organizationPostBindingSource;
    }
}