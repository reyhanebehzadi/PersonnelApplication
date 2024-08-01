namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class SelectMonthDialogForm
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
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yearComboBox
            // 
            this.yearComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(143, 35);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(65, 21);
            this.yearComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "سال";
            // 
            // monthComboBox
            // 
            this.monthComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.monthComboBox.Location = new System.Drawing.Point(17, 35);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(58, 21);
            this.monthComboBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ماه";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(17, 128);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(224, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "تایید";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // SelectMonthDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 184);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yearComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SelectMonthDialogForm";
            this.Text = "انتخاب ماه و سال";
            this.Load += new System.EventHandler(this.SelectMonthDialogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button okButton;
    }
}