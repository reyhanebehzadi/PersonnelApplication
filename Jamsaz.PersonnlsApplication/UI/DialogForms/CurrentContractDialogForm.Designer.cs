namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class CurrentContractDialogForm
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
            this.messageLabel = new System.Windows.Forms.Label();
            this.startdatepicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.endDatepicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.headOfficeCheckbox = new System.Windows.Forms.CheckBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.voidButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            this.messageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.messageLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.messageLabel.Location = new System.Drawing.Point(12, 9);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(468, 58);
            this.messageLabel.TabIndex = 1;
            this.messageLabel.Text = "با این امکان تاریخ شروع و پایان قرارداد جاری همه پرسنل به تاریخ های انتخاب شده تغ" +
    "ییر خواهد کرد.";
            // 
            // startdatepicker
            // 
            this.startdatepicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startdatepicker.Location = new System.Drawing.Point(103, 70);
            this.startdatepicker.Name = "startdatepicker";
            this.startdatepicker.Size = new System.Drawing.Size(165, 20);
            this.startdatepicker.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "تاریخ شروع :";
            // 
            // endDatepicker
            // 
            this.endDatepicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.endDatepicker.Location = new System.Drawing.Point(103, 107);
            this.endDatepicker.Name = "endDatepicker";
            this.endDatepicker.Size = new System.Drawing.Size(165, 20);
            this.endDatepicker.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "تاریخ پایان :";
            // 
            // headOfficeCheckbox
            // 
            this.headOfficeCheckbox.AutoSize = true;
            this.headOfficeCheckbox.Location = new System.Drawing.Point(103, 152);
            this.headOfficeCheckbox.Name = "headOfficeCheckbox";
            this.headOfficeCheckbox.Size = new System.Drawing.Size(110, 17);
            this.headOfficeCheckbox.TabIndex = 7;
            this.headOfficeCheckbox.Text = "شامل دفتر مرکزی";
            this.headOfficeCheckbox.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(355, 146);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(125, 23);
            this.updateButton.TabIndex = 8;
            this.updateButton.Text = "بروزرسانی";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // voidButton
            // 
            this.voidButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.voidButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.voidButton.Location = new System.Drawing.Point(355, 235);
            this.voidButton.Name = "voidButton";
            this.voidButton.Size = new System.Drawing.Size(125, 23);
            this.voidButton.TabIndex = 9;
            this.voidButton.Text = "بستن";
            this.voidButton.UseVisualStyleBackColor = true;
            // 
            // CurrentContractDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(218)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(492, 270);
            this.Controls.Add(this.voidButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.headOfficeCheckbox);
            this.Controls.Add(this.endDatepicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startdatepicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "CurrentContractDialogForm";
            this.ShowIcon = false;
            this.Text = "بروزرسانی تاریخ قرارداد";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messageLabel;
        private FarsiLibrary.Win.Controls.FADatePicker startdatepicker;
        private System.Windows.Forms.Label label1;
        private FarsiLibrary.Win.Controls.FADatePicker endDatepicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox headOfficeCheckbox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button voidButton;
    }
}