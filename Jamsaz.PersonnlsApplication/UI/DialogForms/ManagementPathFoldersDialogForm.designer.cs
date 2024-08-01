namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class ManagementPathFoldersDialogForm
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
            this.selectFolderPathImageButton = new System.Windows.Forms.Button();
            this.selectFolderPathTemplateButton = new System.Windows.Forms.Button();
            this.pathPersonnelImageTextBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pathTemplateTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pathTemplateLabel = new System.Windows.Forms.Label();
            this.pathImageLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // selectFolderPathImageButton
            // 
            this.selectFolderPathImageButton.Location = new System.Drawing.Point(15, 18);
            this.selectFolderPathImageButton.Name = "selectFolderPathImageButton";
            this.selectFolderPathImageButton.Size = new System.Drawing.Size(33, 25);
            this.selectFolderPathImageButton.TabIndex = 0;
            this.selectFolderPathImageButton.Text = "...";
            this.selectFolderPathImageButton.UseVisualStyleBackColor = true;
            this.selectFolderPathImageButton.Click += new System.EventHandler(this.selectFolderPathImageButton_Click);
            // 
            // selectFolderPathTemplateButton
            // 
            this.selectFolderPathTemplateButton.Location = new System.Drawing.Point(16, 57);
            this.selectFolderPathTemplateButton.Name = "selectFolderPathTemplateButton";
            this.selectFolderPathTemplateButton.Size = new System.Drawing.Size(33, 25);
            this.selectFolderPathTemplateButton.TabIndex = 1;
            this.selectFolderPathTemplateButton.Text = "...";
            this.selectFolderPathTemplateButton.UseVisualStyleBackColor = true;
            this.selectFolderPathTemplateButton.Click += new System.EventHandler(this.selectFolderPathTemplateButton_Click);
            // 
            // pathPersonnelImageTextBox
            // 
            this.pathPersonnelImageTextBox.Location = new System.Drawing.Point(58, 20);
            this.pathPersonnelImageTextBox.Name = "pathPersonnelImageTextBox";
            this.pathPersonnelImageTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pathPersonnelImageTextBox.Size = new System.Drawing.Size(392, 22);
            this.pathPersonnelImageTextBox.TabIndex = 2;
            // 
            // pathTemplateTextBox
            // 
            this.pathTemplateTextBox.Location = new System.Drawing.Point(56, 59);
            this.pathTemplateTextBox.Name = "pathTemplateTextBox";
            this.pathTemplateTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pathTemplateTextBox.Size = new System.Drawing.Size(392, 22);
            this.pathTemplateTextBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pathTemplateLabel);
            this.groupBox1.Controls.Add(this.pathImageLabel);
            this.groupBox1.Controls.Add(this.pathPersonnelImageTextBox);
            this.groupBox1.Controls.Add(this.pathTemplateTextBox);
            this.groupBox1.Controls.Add(this.selectFolderPathImageButton);
            this.groupBox1.Controls.Add(this.selectFolderPathTemplateButton);
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 108);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "انتخاب مسیر";
            // 
            // pathTemplateLabel
            // 
            this.pathTemplateLabel.AutoSize = true;
            this.pathTemplateLabel.Location = new System.Drawing.Point(452, 62);
            this.pathTemplateLabel.Name = "pathTemplateLabel";
            this.pathTemplateLabel.Size = new System.Drawing.Size(99, 14);
            this.pathTemplateLabel.TabIndex = 5;
            this.pathTemplateLabel.Text = "مسیر قالب گزارش";
            // 
            // pathImageLabel
            // 
            this.pathImageLabel.AutoSize = true;
            this.pathImageLabel.Location = new System.Drawing.Point(479, 23);
            this.pathImageLabel.Name = "pathImageLabel";
            this.pathImageLabel.Size = new System.Drawing.Size(68, 14);
            this.pathImageLabel.TabIndex = 4;
            this.pathImageLabel.Text = "مسیر عکس";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cancelButton);
            this.groupBox2.Controls.Add(this.saveButton);
            this.groupBox2.Location = new System.Drawing.Point(14, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(562, 54);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(100, 22);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "لغو";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(19, 22);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "ذخیره";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ManagementPathFoldersDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(590, 194);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManagementPathFoldersDialogForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "انتخاب مسیر ها";
            this.Load += new System.EventHandler(this.ManagePathFoldersForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button selectFolderPathImageButton;
        private System.Windows.Forms.Button selectFolderPathTemplateButton;
        private System.Windows.Forms.TextBox pathPersonnelImageTextBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox pathTemplateTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label pathTemplateLabel;
        private System.Windows.Forms.Label pathImageLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}