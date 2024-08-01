namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class DefineEvaluationStepDialogForm
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
            System.Windows.Forms.Label startDateAssessmentLabel;
            System.Windows.Forms.Label label1;
            this.startDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.endDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            startDateAssessmentLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startDatePicker
            // 
            this.startDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startDatePicker.Location = new System.Drawing.Point(109, 50);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(145, 20);
            this.startDatePicker.TabIndex = 34;
            this.startDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // startDateAssessmentLabel
            // 
            startDateAssessmentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            startDateAssessmentLabel.AutoSize = true;
            startDateAssessmentLabel.Location = new System.Drawing.Point(12, 54);
            startDateAssessmentLabel.Name = "startDateAssessmentLabel";
            startDateAssessmentLabel.Size = new System.Drawing.Size(63, 13);
            startDateAssessmentLabel.TabIndex = 33;
            startDateAssessmentLabel.Text = "تاریخ شروع:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Location = new System.Drawing.Point(109, 22);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(145, 21);
            this.nameTextBox.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "عنوان:";
            // 
            // endDatePicker
            // 
            this.endDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.endDatePicker.Location = new System.Drawing.Point(109, 76);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(145, 20);
            this.endDatePicker.TabIndex = 36;
            this.endDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2007;
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 80);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(54, 13);
            label1.TabIndex = 35;
            label1.Text = "تاریخ پایان:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(109, 113);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 37;
            this.saveButton.Text = "ذخیره";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(190, 113);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 38;
            this.cancelButton.Text = "انصراف";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // DefineEvaluationStepDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 153);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(label1);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(startDateAssessmentLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DefineEvaluationStepDialogForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "تعریف مرحله ارزیابی";
            this.Load += new System.EventHandler(this.DefineEvaluationStepDialogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FarsiLibrary.Win.Controls.FADatePicker startDatePicker;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label3;
        private FarsiLibrary.Win.Controls.FADatePicker endDatePicker;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}