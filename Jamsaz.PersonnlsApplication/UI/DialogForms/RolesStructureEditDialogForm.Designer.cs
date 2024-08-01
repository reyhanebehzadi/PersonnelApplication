namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class RolesStructureEditDialogForm
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
            this.TitleEnlabel = new System.Windows.Forms.Label();
            this.titleEnTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new Jamsaz.Common.NullableTextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmbutton = new System.Windows.Forms.Button();
            this.Codelabel = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TitleErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CodeErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitleErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleEnlabel
            // 
            this.TitleEnlabel.AutoSize = true;
            this.TitleEnlabel.Location = new System.Drawing.Point(383, 49);
            this.TitleEnlabel.Name = "TitleEnlabel";
            this.TitleEnlabel.Size = new System.Drawing.Size(83, 13);
            this.TitleEnlabel.TabIndex = 18;
            this.TitleEnlabel.Text = "عنوان انگلیسی:";
            // 
            // titleEnTextBox
            // 
            this.titleEnTextBox.Location = new System.Drawing.Point(6, 44);
            this.titleEnTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.titleEnTextBox.MaxLength = 64;
            this.titleEnTextBox.Name = "titleEnTextBox";
            this.titleEnTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.titleEnTextBox.Size = new System.Drawing.Size(358, 21);
            this.titleEnTextBox.TabIndex = 10;
            this.titleEnTextBox.TextChanged += new System.EventHandler(this.titleEnTextBox_TextChanged);
            this.titleEnTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.titleEnTextBox_KeyPress);
            // 
            // codeTextBox
            // 
            this.codeTextBox.IsRolesCode = true;
            this.codeTextBox.Location = new System.Drawing.Point(240, 71);
            this.codeTextBox.MaxLength = 8;
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.NullableText = null;
            this.codeTextBox.Size = new System.Drawing.Size(124, 21);
            this.codeTextBox.TabIndex = 13;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(331, 110);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(64, 21);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "انصراف";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // confirmbutton
            // 
            this.confirmbutton.Location = new System.Drawing.Point(400, 110);
            this.confirmbutton.Name = "confirmbutton";
            this.confirmbutton.Size = new System.Drawing.Size(64, 21);
            this.confirmbutton.TabIndex = 11;
            this.confirmbutton.Text = "تایید";
            this.confirmbutton.UseVisualStyleBackColor = true;
            this.confirmbutton.Click += new System.EventHandler(this.confirmbutton_Click);
            // 
            // Codelabel
            // 
            this.Codelabel.AutoSize = true;
            this.Codelabel.Location = new System.Drawing.Point(383, 76);
            this.Codelabel.Name = "Codelabel";
            this.Codelabel.Size = new System.Drawing.Size(22, 13);
            this.Codelabel.TabIndex = 15;
            this.Codelabel.Text = "کد:";
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(383, 17);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(37, 13);
            this.Namelabel.TabIndex = 12;
            this.Namelabel.Text = "عنوان:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(6, 14);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTextBox.MaxLength = 64;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(358, 21);
            this.nameTextBox.TabIndex = 9;
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTextBox_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.TitleEnlabel);
            this.groupBox1.Controls.Add(this.Namelabel);
            this.groupBox1.Controls.Add(this.titleEnTextBox);
            this.groupBox1.Controls.Add(this.Codelabel);
            this.groupBox1.Controls.Add(this.codeTextBox);
            this.groupBox1.Location = new System.Drawing.Point(10, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(459, 102);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // TitleErrorProvider
            // 
            this.TitleErrorProvider.ContainerControl = this;
            // 
            // CodeErrorProvider
            // 
            this.CodeErrorProvider.ContainerControl = this;
            // 
            // RolesStructureEditDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(475, 138);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RolesStructureEditDialogForm";
            this.ShowInTaskbar = false;
            this.Text = "ویرایش ساختار سازمان";
            this.Load += new System.EventHandler(this.RolesStructureEditDialogForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitleErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleEnlabel;
        private System.Windows.Forms.TextBox titleEnTextBox;
        private Jamsaz.Common.NullableTextBox codeTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmbutton;
        private System.Windows.Forms.Label Codelabel;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider TitleErrorProvider;
        private System.Windows.Forms.ErrorProvider CodeErrorProvider;
    }
}