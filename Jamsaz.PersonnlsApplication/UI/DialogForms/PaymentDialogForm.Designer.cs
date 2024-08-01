namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class PaymentDialogForm
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
            System.Windows.Forms.Label personnelNumberLabel;
            System.Windows.Forms.Label fullNameLabel;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.eidRegistrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personnelNumberTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.allcheckBox = new System.Windows.Forms.CheckBox();
            this.p12CheckBox = new System.Windows.Forms.CheckBox();
            this.p11CheckBox = new System.Windows.Forms.CheckBox();
            this.p10CheckBox = new System.Windows.Forms.CheckBox();
            this.p9CheckBox = new System.Windows.Forms.CheckBox();
            this.p8CheckBox = new System.Windows.Forms.CheckBox();
            this.p7CheckBox = new System.Windows.Forms.CheckBox();
            this.p6CheckBox = new System.Windows.Forms.CheckBox();
            this.p5CheckBox = new System.Windows.Forms.CheckBox();
            this.p4CheckBox = new System.Windows.Forms.CheckBox();
            this.p3CheckBox = new System.Windows.Forms.CheckBox();
            this.p2CheckBox = new System.Windows.Forms.CheckBox();
            this.p1CheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.payTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            personnelNumberLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eidRegistrationBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // personnelNumberLabel
            // 
            personnelNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            personnelNumberLabel.AutoSize = true;
            personnelNumberLabel.Location = new System.Drawing.Point(427, 24);
            personnelNumberLabel.Name = "personnelNumberLabel";
            personnelNumberLabel.Size = new System.Drawing.Size(82, 13);
            personnelNumberLabel.TabIndex = 0;
            personnelNumberLabel.Text = "شماره پرسنلی:";
            // 
            // fullNameLabel
            // 
            fullNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(427, 49);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(42, 13);
            fullNameLabel.TabIndex = 2;
            fullNameLabel.Text = "پرسنل:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(529, 413);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(fullNameLabel);
            this.groupBox1.Controls.Add(this.fullNameTextBox);
            this.groupBox1.Controls.Add(personnelNumberLabel);
            this.groupBox1.Controls.Add(this.personnelNumberTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eidRegistrationBindingSource, "FullName", true));
            this.fullNameTextBox.Location = new System.Drawing.Point(172, 49);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.ReadOnly = true;
            this.fullNameTextBox.Size = new System.Drawing.Size(249, 21);
            this.fullNameTextBox.TabIndex = 3;
            // 
            // eidRegistrationBindingSource
            // 
            this.eidRegistrationBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.EidRegistration);
            // 
            // personnelNumberTextBox
            // 
            this.personnelNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.personnelNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eidRegistrationBindingSource, "PersonnelNumber", true));
            this.personnelNumberTextBox.Location = new System.Drawing.Point(172, 21);
            this.personnelNumberTextBox.Name = "personnelNumberTextBox";
            this.personnelNumberTextBox.ReadOnly = true;
            this.personnelNumberTextBox.Size = new System.Drawing.Size(249, 21);
            this.personnelNumberTextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.allcheckBox);
            this.groupBox2.Controls.Add(this.p12CheckBox);
            this.groupBox2.Controls.Add(this.p11CheckBox);
            this.groupBox2.Controls.Add(this.p10CheckBox);
            this.groupBox2.Controls.Add(this.p9CheckBox);
            this.groupBox2.Controls.Add(this.p8CheckBox);
            this.groupBox2.Controls.Add(this.p7CheckBox);
            this.groupBox2.Controls.Add(this.p6CheckBox);
            this.groupBox2.Controls.Add(this.p5CheckBox);
            this.groupBox2.Controls.Add(this.p4CheckBox);
            this.groupBox2.Controls.Add(this.p3CheckBox);
            this.groupBox2.Controls.Add(this.p2CheckBox);
            this.groupBox2.Controls.Add(this.p1CheckBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 246);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // allcheckBox
            // 
            this.allcheckBox.AutoSize = true;
            this.allcheckBox.Location = new System.Drawing.Point(444, 55);
            this.allcheckBox.Name = "allcheckBox";
            this.allcheckBox.Size = new System.Drawing.Size(47, 17);
            this.allcheckBox.TabIndex = 24;
            this.allcheckBox.Text = "همه";
            this.allcheckBox.UseVisualStyleBackColor = true;
            this.allcheckBox.CheckedChanged += new System.EventHandler(this.allcheckBox_CheckedChanged);
            // 
            // p12CheckBox
            // 
            this.p12CheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.p12CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.eidRegistrationBindingSource, "P12", true));
            this.p12CheckBox.Location = new System.Drawing.Point(198, 201);
            this.p12CheckBox.Name = "p12CheckBox";
            this.p12CheckBox.Size = new System.Drawing.Size(104, 24);
            this.p12CheckBox.TabIndex = 23;
            this.p12CheckBox.Text = "اسفند";
            this.p12CheckBox.UseVisualStyleBackColor = true;
            // 
            // p11CheckBox
            // 
            this.p11CheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.p11CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.eidRegistrationBindingSource, "P11", true));
            this.p11CheckBox.Location = new System.Drawing.Point(198, 174);
            this.p11CheckBox.Name = "p11CheckBox";
            this.p11CheckBox.Size = new System.Drawing.Size(104, 24);
            this.p11CheckBox.TabIndex = 21;
            this.p11CheckBox.Text = "بهمن";
            this.p11CheckBox.UseVisualStyleBackColor = true;
            // 
            // p10CheckBox
            // 
            this.p10CheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.p10CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.eidRegistrationBindingSource, "P10", true));
            this.p10CheckBox.Location = new System.Drawing.Point(198, 152);
            this.p10CheckBox.Name = "p10CheckBox";
            this.p10CheckBox.Size = new System.Drawing.Size(104, 24);
            this.p10CheckBox.TabIndex = 19;
            this.p10CheckBox.Text = "دی";
            this.p10CheckBox.UseVisualStyleBackColor = true;
            // 
            // p9CheckBox
            // 
            this.p9CheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.p9CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.eidRegistrationBindingSource, "P9", true));
            this.p9CheckBox.Location = new System.Drawing.Point(198, 128);
            this.p9CheckBox.Name = "p9CheckBox";
            this.p9CheckBox.Size = new System.Drawing.Size(104, 24);
            this.p9CheckBox.TabIndex = 17;
            this.p9CheckBox.Text = "آذر";
            this.p9CheckBox.UseVisualStyleBackColor = true;
            // 
            // p8CheckBox
            // 
            this.p8CheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.p8CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.eidRegistrationBindingSource, "P8", true));
            this.p8CheckBox.Location = new System.Drawing.Point(198, 103);
            this.p8CheckBox.Name = "p8CheckBox";
            this.p8CheckBox.Size = new System.Drawing.Size(104, 24);
            this.p8CheckBox.TabIndex = 15;
            this.p8CheckBox.Text = "آبان";
            this.p8CheckBox.UseVisualStyleBackColor = true;
            // 
            // p7CheckBox
            // 
            this.p7CheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.p7CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.eidRegistrationBindingSource, "P7", true));
            this.p7CheckBox.Location = new System.Drawing.Point(198, 78);
            this.p7CheckBox.Name = "p7CheckBox";
            this.p7CheckBox.Size = new System.Drawing.Size(104, 24);
            this.p7CheckBox.TabIndex = 13;
            this.p7CheckBox.Text = "مهر";
            this.p7CheckBox.UseVisualStyleBackColor = true;
            // 
            // p6CheckBox
            // 
            this.p6CheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.p6CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.eidRegistrationBindingSource, "P6", true));
            this.p6CheckBox.Location = new System.Drawing.Point(387, 201);
            this.p6CheckBox.Name = "p6CheckBox";
            this.p6CheckBox.Size = new System.Drawing.Size(104, 24);
            this.p6CheckBox.TabIndex = 11;
            this.p6CheckBox.Text = "شهریور";
            this.p6CheckBox.UseVisualStyleBackColor = true;
            // 
            // p5CheckBox
            // 
            this.p5CheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.p5CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.eidRegistrationBindingSource, "P5", true));
            this.p5CheckBox.Location = new System.Drawing.Point(387, 174);
            this.p5CheckBox.Name = "p5CheckBox";
            this.p5CheckBox.Size = new System.Drawing.Size(104, 24);
            this.p5CheckBox.TabIndex = 9;
            this.p5CheckBox.Text = "مرداد";
            this.p5CheckBox.UseVisualStyleBackColor = true;
            // 
            // p4CheckBox
            // 
            this.p4CheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.p4CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.eidRegistrationBindingSource, "P4", true));
            this.p4CheckBox.Location = new System.Drawing.Point(387, 152);
            this.p4CheckBox.Name = "p4CheckBox";
            this.p4CheckBox.Size = new System.Drawing.Size(104, 24);
            this.p4CheckBox.TabIndex = 7;
            this.p4CheckBox.Text = "تیر";
            this.p4CheckBox.UseVisualStyleBackColor = true;
            // 
            // p3CheckBox
            // 
            this.p3CheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.p3CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.eidRegistrationBindingSource, "P3", true));
            this.p3CheckBox.Location = new System.Drawing.Point(387, 128);
            this.p3CheckBox.Name = "p3CheckBox";
            this.p3CheckBox.Size = new System.Drawing.Size(104, 24);
            this.p3CheckBox.TabIndex = 5;
            this.p3CheckBox.Text = "خرداد";
            this.p3CheckBox.UseVisualStyleBackColor = true;
            // 
            // p2CheckBox
            // 
            this.p2CheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.p2CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.eidRegistrationBindingSource, "P2", true));
            this.p2CheckBox.Location = new System.Drawing.Point(387, 103);
            this.p2CheckBox.Name = "p2CheckBox";
            this.p2CheckBox.Size = new System.Drawing.Size(104, 24);
            this.p2CheckBox.TabIndex = 3;
            this.p2CheckBox.Text = "اردیبهشت";
            this.p2CheckBox.UseVisualStyleBackColor = true;
            // 
            // p1CheckBox
            // 
            this.p1CheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.p1CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.eidRegistrationBindingSource, "P1", true));
            this.p1CheckBox.Location = new System.Drawing.Point(387, 78);
            this.p1CheckBox.Name = "p1CheckBox";
            this.p1CheckBox.Size = new System.Drawing.Size(104, 24);
            this.p1CheckBox.TabIndex = 1;
            this.p1CheckBox.Text = "فروردین";
            this.p1CheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cancelButton);
            this.groupBox3.Controls.Add(this.saveButton);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 355);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(523, 55);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(99, 20);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "لغو";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.Location = new System.Drawing.Point(18, 20);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "ذخیره";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.eidRegistrationBindingSource, "PayType", true));
            this.comboBox1.DataSource = this.payTypeBindingSource;
            this.comboBox1.DisplayMember = "Title";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(300, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.ValueMember = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "وضعیت پرداخت:";
            // 
            // payTypeBindingSource
            // 
            this.payTypeBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.PayType);
            // 
            // PaymentDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 413);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PaymentDialogForm";
            this.ShowIcon = false;
            this.Text = "پرداخت";
            this.Load += new System.EventHandler(this.PaymentDialogForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eidRegistrationBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.payTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.BindingSource eidRegistrationBindingSource;
        private System.Windows.Forms.TextBox personnelNumberTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox p12CheckBox;
        private System.Windows.Forms.CheckBox p11CheckBox;
        private System.Windows.Forms.CheckBox p10CheckBox;
        private System.Windows.Forms.CheckBox p9CheckBox;
        private System.Windows.Forms.CheckBox p8CheckBox;
        private System.Windows.Forms.CheckBox p7CheckBox;
        private System.Windows.Forms.CheckBox p6CheckBox;
        private System.Windows.Forms.CheckBox p5CheckBox;
        private System.Windows.Forms.CheckBox p4CheckBox;
        private System.Windows.Forms.CheckBox p3CheckBox;
        private System.Windows.Forms.CheckBox p2CheckBox;
        private System.Windows.Forms.CheckBox p1CheckBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox allcheckBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource payTypeBindingSource;
        private System.Windows.Forms.Label label1;
    }
}