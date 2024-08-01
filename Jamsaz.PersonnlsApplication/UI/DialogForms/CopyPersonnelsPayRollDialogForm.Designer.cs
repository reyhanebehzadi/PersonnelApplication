namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class CopyPersonnelsPayRollDialogForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.faDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.copyButton = new System.Windows.Forms.Button();
            this.voidButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            this.messageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.messageLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.messageLabel.Location = new System.Drawing.Point(12, 18);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(468, 89);
            this.messageLabel.TabIndex = 0;
            this.messageLabel.Text = "با این امکان آخرین وضعیت قرارداد های همه پرسنل فعال و شاغل در جمع ساز در تاریخ مش" +
    "خص شده کپی می شود و سپس تغییرات لازم اعمال شده و اقدام به پرینت از کلیه قرارداد " +
    "ها می کنیم.";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "تاریخ :";
            // 
            // faDatePicker
            // 
            this.faDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.faDatePicker.Location = new System.Drawing.Point(71, 105);
            this.faDatePicker.Name = "faDatePicker";
            this.faDatePicker.Size = new System.Drawing.Size(165, 20);
            this.faDatePicker.TabIndex = 2;
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(355, 102);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(125, 23);
            this.copyButton.TabIndex = 3;
            this.copyButton.Text = "کپی";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // voidButton
            // 
            this.voidButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.voidButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.voidButton.Location = new System.Drawing.Point(355, 235);
            this.voidButton.Name = "voidButton";
            this.voidButton.Size = new System.Drawing.Size(125, 23);
            this.voidButton.TabIndex = 4;
            this.voidButton.Text = "بستن";
            this.voidButton.UseVisualStyleBackColor = true;
            this.voidButton.Click += new System.EventHandler(this.voidButton_Click);
            // 
            // CopyPersonnelsPayRollDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(218)))), ((int)(((byte)(254)))));
            this.CancelButton = this.voidButton;
            this.ClientSize = new System.Drawing.Size(492, 270);
            this.Controls.Add(this.voidButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.faDatePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "CopyPersonnelsPayRollDialogForm";
            this.ShowIcon = false;
            this.Text = "کپی همه قراردادهای فعلی پرسنل به تاریخ بعدی";
            this.Load += new System.EventHandler(this.CopyPersonnelsPayRollDialogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label label1;
        private FarsiLibrary.Win.Controls.FADatePicker faDatePicker;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button voidButton;
    }
}