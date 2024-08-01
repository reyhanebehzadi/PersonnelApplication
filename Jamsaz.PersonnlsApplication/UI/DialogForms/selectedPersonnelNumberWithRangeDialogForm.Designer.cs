namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class selectedPersonnelNumberWithRangeDialogForm
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
            this.SelectedButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.effectiveDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.FromPersonnelNumberLabel = new System.Windows.Forms.Label();
            this.ToTextBox = new Jamsaz.PersonnlsApplication.Classes.NullableTextBox();
            this.FromTextBox = new Jamsaz.PersonnlsApplication.Classes.NullableTextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pesonnelNumbersTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ADatepicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectedButton
            // 
            this.SelectedButton.Location = new System.Drawing.Point(396, 208);
            this.SelectedButton.Name = "SelectedButton";
            this.SelectedButton.Size = new System.Drawing.Size(75, 23);
            this.SelectedButton.TabIndex = 0;
            this.SelectedButton.Text = "انتخاب";
            this.SelectedButton.UseVisualStyleBackColor = true;
            this.SelectedButton.Click += new System.EventHandler(this.SelectedButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(315, 208);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "لغو";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ADatepicker);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.effectiveDatePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FromPersonnelNumberLabel);
            this.groupBox1.Controls.Add(this.ToTextBox);
            this.groupBox1.Controls.Add(this.FromTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 75);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "انتخاب شماره پرسنلی بر اساس محدوده";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "تاریخ قرارداد";
            // 
            // effectiveDatePicker
            // 
            this.effectiveDatePicker.Location = new System.Drawing.Point(220, 55);
            this.effectiveDatePicker.Name = "effectiveDatePicker";
            this.effectiveDatePicker.Size = new System.Drawing.Size(133, 20);
            this.effectiveDatePicker.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "تا";
            // 
            // FromPersonnelNumberLabel
            // 
            this.FromPersonnelNumberLabel.AutoSize = true;
            this.FromPersonnelNumberLabel.Location = new System.Drawing.Point(359, 27);
            this.FromPersonnelNumberLabel.Name = "FromPersonnelNumberLabel";
            this.FromPersonnelNumberLabel.Size = new System.Drawing.Size(88, 13);
            this.FromPersonnelNumberLabel.TabIndex = 2;
            this.FromPersonnelNumberLabel.Text = "از شماره پرسنلی";
            // 
            // ToTextBox
            // 
            this.ToTextBox.IsNumeric = true;
            this.ToTextBox.Location = new System.Drawing.Point(180, 24);
            this.ToTextBox.Name = "ToTextBox";
            this.ToTextBox.NullableText = null;
            this.ToTextBox.Size = new System.Drawing.Size(74, 21);
            this.ToTextBox.TabIndex = 1;
            // 
            // FromTextBox
            // 
            this.FromTextBox.IsNumeric = true;
            this.FromTextBox.Location = new System.Drawing.Point(279, 24);
            this.FromTextBox.Name = "FromTextBox";
            this.FromTextBox.NullableText = null;
            this.FromTextBox.Size = new System.Drawing.Size(74, 21);
            this.FromTextBox.TabIndex = 0;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pesonnelNumbersTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 108);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اضافه کردن شماره پرسنلی های مورد نظر";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "1010و1106و66و67";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "شماره پرسنلی های مورد نظر را بصورت تفکیک شده با کاما وارد کنید.";
            // 
            // pesonnelNumbersTextBox
            // 
            this.pesonnelNumbersTextBox.Location = new System.Drawing.Point(117, 25);
            this.pesonnelNumbersTextBox.Name = "pesonnelNumbersTextBox";
            this.pesonnelNumbersTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pesonnelNumbersTextBox.Size = new System.Drawing.Size(312, 21);
            this.pesonnelNumbersTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "شماره های پرسنلی";
            // 
            // ADatepicker
            // 
            this.ADatepicker.Location = new System.Drawing.Point(10, 55);
            this.ADatepicker.Name = "ADatepicker";
            this.ADatepicker.Size = new System.Drawing.Size(133, 20);
            this.ADatepicker.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "تاریخ ارزیابی";
            // 
            // selectedPersonnelNumberWithRangeDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(483, 244);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.SelectedButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "selectedPersonnelNumberWithRangeDialogForm";
            this.Text = "selectedPersonnelNumberWithRangeDialogForm";
            this.Load += new System.EventHandler(this.selectedPersonnelNumberWithRangeDialogForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectedButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FromPersonnelNumberLabel;
        private Jamsaz.PersonnlsApplication.Classes.NullableTextBox ToTextBox;
        private Jamsaz.PersonnlsApplication.Classes.NullableTextBox FromTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pesonnelNumbersTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private FarsiLibrary.Win.Controls.FADatePicker effectiveDatePicker;
        private System.Windows.Forms.Label label6;
        private FarsiLibrary.Win.Controls.FADatePicker ADatepicker;
    }
}