namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    partial class PersonnelEvaluationNotRegisteredDockForm
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
            System.Windows.Forms.Label label6;
            Janus.Windows.GridEX.GridEXLayout listGroupGrid_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonnelEvaluationNotRegisteredDockForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listGroupGrid = new Janus.Windows.GridEX.GridEX();
            this.personnelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stepComboBox = new System.Windows.Forms.ComboBox();
            this.evaluationStepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.EvaluatiobRadioButton = new System.Windows.Forms.RadioButton();
            this.NotEvaluationRadioButton = new System.Windows.Forms.RadioButton();
            label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listGroupGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.evaluationStepBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(473, 23);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(39, 13);
            label6.TabIndex = 43;
            label6.Text = "مرحله:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.listGroupGrid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1071, 707);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listGroupGrid
            // 
            this.listGroupGrid.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.listGroupGrid.DataSource = this.personnelBindingSource;
            listGroupGrid_DesignTimeLayout.LayoutString = resources.GetString("listGroupGrid_DesignTimeLayout.LayoutString");
            this.listGroupGrid.DesignTimeLayout = listGroupGrid_DesignTimeLayout;
            this.listGroupGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listGroupGrid.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.listGroupGrid.GroupByBoxVisible = false;
            this.listGroupGrid.Location = new System.Drawing.Point(3, 63);
            this.listGroupGrid.Name = "listGroupGrid";
            this.listGroupGrid.RecordNavigator = true;
            this.listGroupGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listGroupGrid.RowFormatStyle.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.listGroupGrid.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.listGroupGrid.Size = new System.Drawing.Size(1065, 641);
            this.listGroupGrid.TabIndex = 7;
            this.listGroupGrid.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // personnelBindingSource
            // 
            this.personnelBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.PersonnelNotEvaluatedResult);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NotEvaluationRadioButton);
            this.groupBox1.Controls.Add(this.EvaluatiobRadioButton);
            this.groupBox1.Controls.Add(this.stepComboBox);
            this.groupBox1.Controls.Add(label6);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.codeTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1065, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // stepComboBox
            // 
            this.stepComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stepComboBox.DataSource = this.evaluationStepBindingSource;
            this.stepComboBox.DisplayMember = "Name";
            this.stepComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stepComboBox.FormattingEnabled = true;
            this.stepComboBox.Location = new System.Drawing.Point(322, 19);
            this.stepComboBox.Name = "stepComboBox";
            this.stepComboBox.Size = new System.Drawing.Size(145, 21);
            this.stepComboBox.TabIndex = 44;
            this.stepComboBox.ValueMember = "ID";
            // 
            // evaluationStepBindingSource
            // 
            this.evaluationStepBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.EvaluationStep);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchButton.Location = new System.Drawing.Point(8, 20);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(85, 23);
            this.searchButton.TabIndex = 42;
            this.searchButton.Text = "جستجو";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(706, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "کد پرسنلی:";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.codeTextBox.Location = new System.Drawing.Point(518, 20);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(185, 21);
            this.codeTextBox.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(967, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "نام و نام خانوادگی:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Location = new System.Drawing.Point(776, 20);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(185, 21);
            this.nameTextBox.TabIndex = 38;
            // 
            // EvaluatiobRadioButton
            // 
            this.EvaluatiobRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EvaluatiobRadioButton.AutoSize = true;
            this.EvaluatiobRadioButton.Location = new System.Drawing.Point(222, 21);
            this.EvaluatiobRadioButton.Name = "EvaluatiobRadioButton";
            this.EvaluatiobRadioButton.Size = new System.Drawing.Size(81, 17);
            this.EvaluatiobRadioButton.TabIndex = 45;
            this.EvaluatiobRadioButton.Text = "ارزیابی شده";
            this.EvaluatiobRadioButton.UseVisualStyleBackColor = true;
            // 
            // NotEvaluationRadioButton
            // 
            this.NotEvaluationRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NotEvaluationRadioButton.AutoSize = true;
            this.NotEvaluationRadioButton.Checked = true;
            this.NotEvaluationRadioButton.Location = new System.Drawing.Point(106, 21);
            this.NotEvaluationRadioButton.Name = "NotEvaluationRadioButton";
            this.NotEvaluationRadioButton.Size = new System.Drawing.Size(85, 17);
            this.NotEvaluationRadioButton.TabIndex = 46;
            this.NotEvaluationRadioButton.TabStop = true;
            this.NotEvaluationRadioButton.Text = "ارزیابی نشده";
            this.NotEvaluationRadioButton.UseVisualStyleBackColor = true;
            // 
            // PersonnelEvaluationNotRegisteredDockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 707);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PersonnelEvaluationNotRegisteredDockForm";
            this.Text = "گزارش پرسنل ارزیابی نشده";
            this.Load += new System.EventHandler(this.PersonnelEvaluationNotRegisteredDockForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listGroupGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.evaluationStepBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.BindingSource evaluationStepBindingSource;
        private System.Windows.Forms.BindingSource personnelBindingSource;
        private System.Windows.Forms.ComboBox stepComboBox;
        private Janus.Windows.GridEX.GridEX listGroupGrid;
        private System.Windows.Forms.RadioButton NotEvaluationRadioButton;
        private System.Windows.Forms.RadioButton EvaluatiobRadioButton;
    }
}