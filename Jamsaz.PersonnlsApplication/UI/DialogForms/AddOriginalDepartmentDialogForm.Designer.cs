namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class AddOriginalDepartmentDialogForm
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.voidBbutton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage = new System.Windows.Forms.TabPage();
            this.enghlishNameTextBox = new System.Windows.Forms.TextBox();
            this.originalDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.enghlishNameLabel = new System.Windows.Forms.Label();
            this.codeLabel = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalDepartmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.voidBbutton);
            this.groupBox.Controls.Add(this.saveButton);
            this.groupBox.Controls.Add(this.tabControl);
            this.groupBox.Location = new System.Drawing.Point(3, -2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(517, 328);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            // 
            // voidBbutton
            // 
            this.voidBbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.voidBbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.voidBbutton.Location = new System.Drawing.Point(97, 297);
            this.voidBbutton.Name = "voidBbutton";
            this.voidBbutton.Size = new System.Drawing.Size(82, 23);
            this.voidBbutton.TabIndex = 2;
            this.voidBbutton.Text = "لغو";
            this.voidBbutton.UseVisualStyleBackColor = true;
            this.voidBbutton.Click += new System.EventHandler(this.voidBbutton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.Location = new System.Drawing.Point(9, 297);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(82, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "ذخیره";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage);
            this.tabControl.Location = new System.Drawing.Point(0, 14);
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeftLayout = true;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(511, 280);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.enghlishNameTextBox);
            this.tabPage.Controls.Add(this.nameTextBox);
            this.tabPage.Controls.Add(this.codeTextBox);
            this.tabPage.Controls.Add(this.nameLabel);
            this.tabPage.Controls.Add(this.enghlishNameLabel);
            this.tabPage.Controls.Add(this.codeLabel);
            this.tabPage.Location = new System.Drawing.Point(4, 22);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage.Size = new System.Drawing.Size(503, 254);
            this.tabPage.TabIndex = 0;
            this.tabPage.Text = "واحد سازمانی";
            this.tabPage.UseVisualStyleBackColor = true;
            // 
            // enghlishNameTextBox
            // 
            this.enghlishNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.originalDepartmentBindingSource, "EnghlishName", true));
            this.enghlishNameTextBox.Location = new System.Drawing.Point(152, 88);
            this.enghlishNameTextBox.Name = "enghlishNameTextBox";
            this.enghlishNameTextBox.Size = new System.Drawing.Size(254, 21);
            this.enghlishNameTextBox.TabIndex = 5;
            // 
            // originalDepartmentBindingSource
            // 
            this.originalDepartmentBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.OriginalDepartment);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.originalDepartmentBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(152, 61);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(254, 21);
            this.nameTextBox.TabIndex = 4;
            // 
            // codeTextBox
            // 
            this.codeTextBox.BackColor = System.Drawing.Color.White;
            this.codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.originalDepartmentBindingSource, "Code", true));
            this.codeTextBox.Location = new System.Drawing.Point(152, 32);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.ReadOnly = true;
            this.codeTextBox.Size = new System.Drawing.Size(254, 21);
            this.codeTextBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(429, 64);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "نام واحد";
            // 
            // enghlishNameLabel
            // 
            this.enghlishNameLabel.AutoSize = true;
            this.enghlishNameLabel.Location = new System.Drawing.Point(428, 91);
            this.enghlishNameLabel.Name = "enghlishNameLabel";
            this.enghlishNameLabel.Size = new System.Drawing.Size(45, 13);
            this.enghlishNameLabel.TabIndex = 1;
            this.enghlishNameLabel.Text = "نام لاتین";
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(455, 35);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(18, 13);
            this.codeLabel.TabIndex = 0;
            this.codeLabel.Text = "کد";
            // 
            // AddOriginalDepartmentDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.voidBbutton;
            this.ClientSize = new System.Drawing.Size(523, 330);
            this.Controls.Add(this.groupBox);
            this.MaximizeBox = false;
            this.Name = "AddOriginalDepartmentDialogForm";
            this.ShowIcon = false;
            this.Text = "نسخه اصلی  واحد سازمانی";
            this.Load += new System.EventHandler(this.AddOriginalDepartmentDialogForm_Load);
            this.groupBox.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalDepartmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button voidBbutton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.TextBox enghlishNameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label enghlishNameLabel;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.BindingSource originalDepartmentBindingSource;
    }
}