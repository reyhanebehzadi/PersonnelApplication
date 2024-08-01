namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class DepartmentVersionEditDialogForm
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
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.codeLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.IsActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.departmentVersionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.endDateDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.startDateDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentVersionBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(357, 20);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "ذخیره";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(276, 20);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "لغو";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.codeLabel);
            this.groupBox1.Controls.Add(this.startDateLabel);
            this.groupBox1.Controls.Add(this.endDateLabel);
            this.groupBox1.Controls.Add(this.IsActiveCheckBox);
            this.groupBox1.Controls.Add(this.endDateDatePicker);
            this.groupBox1.Controls.Add(this.startDateDatePicker);
            this.groupBox1.Controls.Add(this.codeTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 156);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(379, 23);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(18, 13);
            this.codeLabel.TabIndex = 6;
            this.codeLabel.Text = "کد";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(372, 59);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(59, 13);
            this.startDateLabel.TabIndex = 5;
            this.startDateLabel.Text = "تاریخ شروع";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(379, 88);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(50, 13);
            this.endDateLabel.TabIndex = 4;
            this.endDateLabel.Text = "تاریخ پایان";
            // 
            // IsActiveCheckBox
            // 
            this.IsActiveCheckBox.AutoSize = true;
            this.IsActiveCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.departmentVersionBindingSource, "IsActive", true));
            this.IsActiveCheckBox.Location = new System.Drawing.Point(207, 116);
            this.IsActiveCheckBox.Name = "IsActiveCheckBox";
            this.IsActiveCheckBox.Size = new System.Drawing.Size(160, 17);
            this.IsActiveCheckBox.TabIndex = 3;
            this.IsActiveCheckBox.Text = "آیا این نسخه بخش فعال باشد";
            this.IsActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // departmentVersionBindingSource
            // 
            this.departmentVersionBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.DepartmentVersion);
            // 
            // endDateDatePicker
            // 
            this.endDateDatePicker.DataBindings.Add(new System.Windows.Forms.Binding("SelectedDateTime", this.departmentVersionBindingSource, "effectiveEndDate", true));
            this.endDateDatePicker.Location = new System.Drawing.Point(243, 81);
            this.endDateDatePicker.Name = "endDateDatePicker";
            this.endDateDatePicker.Size = new System.Drawing.Size(127, 20);
            this.endDateDatePicker.TabIndex = 2;
            // 
            // startDateDatePicker
            // 
            this.startDateDatePicker.DataBindings.Add(new System.Windows.Forms.Binding("SelectedDateTime", this.departmentVersionBindingSource, "effectiveStardDate", true));
            this.startDateDatePicker.Location = new System.Drawing.Point(244, 55);
            this.startDateDatePicker.Name = "startDateDatePicker";
            this.startDateDatePicker.Size = new System.Drawing.Size(127, 20);
            this.startDateDatePicker.TabIndex = 1;
            // 
            // codeTextBox
            // 
            this.codeTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentVersionBindingSource, "Code", true));
            this.codeTextBox.Location = new System.Drawing.Point(246, 20);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.ReadOnly = true;
            this.codeTextBox.Size = new System.Drawing.Size(127, 21);
            this.codeTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.saveButton);
            this.groupBox2.Controls.Add(this.cancelButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 51);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // DepartmentVersionEditDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(463, 227);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DepartmentVersionEditDialogForm";
            this.Text = "ویرایش نسخه";
            this.Load += new System.EventHandler(this.departmentVersionEditDialogForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentVersionBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private FarsiLibrary.Win.Controls.FADatePicker startDateDatePicker;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.CheckBox IsActiveCheckBox;
        private FarsiLibrary.Win.Controls.FADatePicker endDateDatePicker;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.BindingSource departmentVersionBindingSource;
    }
}