namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    partial class TopPersonelEvaluationDockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopPersonelEvaluationDockForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listGroupGrid = new Janus.Windows.GridEX.GridEX();
            this.personelEvaluationByPercentResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reportButton = new System.Windows.Forms.Button();
            this.percentTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stepComboBox = new System.Windows.Forms.ComboBox();
            this.evaluationStepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listGroupGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelEvaluationByPercentResultBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.evaluationStepBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.listGroupGrid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.56F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1180, 625);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listGroupGrid
            // 
            this.listGroupGrid.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.listGroupGrid.DataSource = this.personelEvaluationByPercentResultBindingSource;
            listGroupGrid_DesignTimeLayout.LayoutString = resources.GetString("listGroupGrid_DesignTimeLayout.LayoutString");
            this.listGroupGrid.DesignTimeLayout = listGroupGrid_DesignTimeLayout;
            this.listGroupGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listGroupGrid.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.listGroupGrid.GroupByBoxVisible = false;
            this.listGroupGrid.Location = new System.Drawing.Point(3, 61);
            this.listGroupGrid.Name = "listGroupGrid";
            this.listGroupGrid.RecordNavigator = true;
            this.listGroupGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listGroupGrid.RowFormatStyle.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.listGroupGrid.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.listGroupGrid.Size = new System.Drawing.Size(1174, 561);
            this.listGroupGrid.TabIndex = 7;
            this.listGroupGrid.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // personelEvaluationByPercentResultBindingSource
            // 
            this.personelEvaluationByPercentResultBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.PersonelEvaluationByPercentResult);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reportButton);
            this.groupBox1.Controls.Add(this.percentTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.stepComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.departmentComboBox);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1174, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(9, 18);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(80, 23);
            this.reportButton.TabIndex = 50;
            this.reportButton.Text = "چاپ گزارش";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // percentTextBox
            // 
            this.percentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.percentTextBox.Location = new System.Drawing.Point(671, 20);
            this.percentTextBox.Mask = "0000";
            this.percentTextBox.Name = "percentTextBox";
            this.percentTextBox.Size = new System.Drawing.Size(100, 21);
            this.percentTextBox.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(928, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "مرحله:";
            // 
            // stepComboBox
            // 
            this.stepComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stepComboBox.DataSource = this.evaluationStepBindingSource;
            this.stepComboBox.DisplayMember = "Name";
            this.stepComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stepComboBox.FormattingEnabled = true;
            this.stepComboBox.Location = new System.Drawing.Point(777, 20);
            this.stepComboBox.Name = "stepComboBox";
            this.stepComboBox.Size = new System.Drawing.Size(145, 21);
            this.stepComboBox.TabIndex = 47;
            this.stepComboBox.ValueMember = "ID";
            // 
            // evaluationStepBindingSource
            // 
            this.evaluationStepBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.EvaluationStep);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1134, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 7;
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
            this.departmentComboBox.Location = new System.Drawing.Point(971, 20);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(157, 21);
            this.departmentComboBox.TabIndex = 6;
            this.departmentComboBox.ValueMember = "Id";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.Department);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(585, 18);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(80, 23);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "جستجو";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // TopPersonelEvaluationDockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 625);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TopPersonelEvaluationDockForm";
            this.Text = "گزارش درصدی ارزیابی";
            this.Load += new System.EventHandler(this.TopPersonelEvaluationDockForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listGroupGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelEvaluationByPercentResultBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.evaluationStepBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Janus.Windows.GridEX.GridEX listGroupGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox stepComboBox;
        private System.Windows.Forms.BindingSource evaluationStepBindingSource;
        private System.Windows.Forms.BindingSource personelEvaluationByPercentResultBindingSource;
        private System.Windows.Forms.MaskedTextBox percentTextBox;
        private System.Windows.Forms.Button reportButton;
    }
}