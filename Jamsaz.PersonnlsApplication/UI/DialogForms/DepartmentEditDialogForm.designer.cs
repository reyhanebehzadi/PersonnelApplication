namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class departmentEditDialogForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.Namelabel = new System.Windows.Forms.Label();
            this.Codelabel = new System.Windows.Forms.Label();
            this.Descriptionlabel = new System.Windows.Forms.Label();
            this.confirmbutton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.TitleErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CodeErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.TitleEnlabel = new System.Windows.Forms.Label();
            this.titleEnTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new Jamsaz.Common.NullableTextBox();
            this.originalDepartmentLabel = new System.Windows.Forms.Label();
            this.originalDepartmentTextBox = new System.Windows.Forms.TextBox();
            this.selectOriginalDepartmentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TitleErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(139, 14);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.MaxLength = 64;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(424, 22);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.Leave += new System.EventHandler(this.CodeTextBox_Leave);
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBox_KeyPress);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(139, 103);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionTextBox.MaxLength = 256;
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(424, 83);
            this.descriptionTextBox.TabIndex = 4;
            this.descriptionTextBox.Leave += new System.EventHandler(this.CodeTextBox_Leave);
            this.descriptionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescriptionTextBox_KeyPress);
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(61, 17);
            this.Namelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(44, 16);
            this.Namelabel.TabIndex = 3;
            this.Namelabel.Text = "عنوان:";
            // 
            // Codelabel
            // 
            this.Codelabel.AutoSize = true;
            this.Codelabel.Location = new System.Drawing.Point(79, 78);
            this.Codelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Codelabel.Name = "Codelabel";
            this.Codelabel.Size = new System.Drawing.Size(26, 16);
            this.Codelabel.TabIndex = 4;
            this.Codelabel.Text = "کد:";
            // 
            // Descriptionlabel
            // 
            this.Descriptionlabel.AutoSize = true;
            this.Descriptionlabel.Location = new System.Drawing.Point(43, 106);
            this.Descriptionlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Descriptionlabel.Name = "Descriptionlabel";
            this.Descriptionlabel.Size = new System.Drawing.Size(62, 16);
            this.Descriptionlabel.TabIndex = 5;
            this.Descriptionlabel.Text = "توضیحات:";
            // 
            // confirmbutton
            // 
            this.confirmbutton.Location = new System.Drawing.Point(488, 270);
            this.confirmbutton.Name = "confirmbutton";
            this.confirmbutton.Size = new System.Drawing.Size(75, 25);
            this.confirmbutton.TabIndex = 3;
            this.confirmbutton.Text = "تایید";
            this.confirmbutton.UseVisualStyleBackColor = true;
            this.confirmbutton.Click += new System.EventHandler(this.ConfirmButton_Click);
            this.confirmbutton.Leave += new System.EventHandler(this.CodeTextBox_Leave);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(407, 270);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 25);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "انصراف";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            this.cancelButton.Leave += new System.EventHandler(this.CodeTextBox_Leave);
            // 
            // TitleErrorProvider
            // 
            this.TitleErrorProvider.ContainerControl = this;
            // 
            // CodeErrorProvider
            // 
            this.CodeErrorProvider.ContainerControl = this;
            // 
            // TitleEnlabel
            // 
            this.TitleEnlabel.AutoSize = true;
            this.TitleEnlabel.Location = new System.Drawing.Point(6, 49);
            this.TitleEnlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleEnlabel.Name = "TitleEnlabel";
            this.TitleEnlabel.Size = new System.Drawing.Size(99, 16);
            this.TitleEnlabel.TabIndex = 8;
            this.TitleEnlabel.Text = "عنوان انگلیسی:";
            // 
            // titleEnTextBox
            // 
            this.titleEnTextBox.Location = new System.Drawing.Point(139, 46);
            this.titleEnTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.titleEnTextBox.MaxLength = 64;
            this.titleEnTextBox.Name = "titleEnTextBox";
            this.titleEnTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.titleEnTextBox.Size = new System.Drawing.Size(424, 22);
            this.titleEnTextBox.TabIndex = 2;
            this.titleEnTextBox.Leave += new System.EventHandler(this.CodeTextBox_Leave);
            this.titleEnTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TitleEnTextBox_KeyPress);
            // 
            // codeTextBox
            // 
            this.codeTextBox.IsRolesCode = true;
            this.codeTextBox.Location = new System.Drawing.Point(139, 75);
            this.codeTextBox.MaxLength = 8;
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.NullableText = null;
            this.codeTextBox.Size = new System.Drawing.Size(125, 22);
            this.codeTextBox.TabIndex = 3;
            this.codeTextBox.Leave += new System.EventHandler(this.CodeTextBox_Leave);
            // 
            // originalDepartmentLabel
            // 
            this.originalDepartmentLabel.AutoSize = true;
            this.originalDepartmentLabel.Location = new System.Drawing.Point(13, 200);
            this.originalDepartmentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.originalDepartmentLabel.Name = "originalDepartmentLabel";
            this.originalDepartmentLabel.Size = new System.Drawing.Size(118, 16);
            this.originalDepartmentLabel.TabIndex = 9;
            this.originalDepartmentLabel.Text = "ارتباط با واحد اصلی:";
            // 
            // originalDepartmentTextBox
            // 
            this.originalDepartmentTextBox.Location = new System.Drawing.Point(139, 194);
            this.originalDepartmentTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.originalDepartmentTextBox.MaxLength = 64;
            this.originalDepartmentTextBox.Multiline = true;
            this.originalDepartmentTextBox.Name = "originalDepartmentTextBox";
            this.originalDepartmentTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.originalDepartmentTextBox.Size = new System.Drawing.Size(387, 48);
            this.originalDepartmentTextBox.TabIndex = 10;
            // 
            // selectOriginalDepartmentButton
            // 
            this.selectOriginalDepartmentButton.Location = new System.Drawing.Point(533, 196);
            this.selectOriginalDepartmentButton.Name = "selectOriginalDepartmentButton";
            this.selectOriginalDepartmentButton.Size = new System.Drawing.Size(30, 23);
            this.selectOriginalDepartmentButton.TabIndex = 11;
            this.selectOriginalDepartmentButton.Text = "...";
            this.selectOriginalDepartmentButton.UseVisualStyleBackColor = true;
            this.selectOriginalDepartmentButton.Click += new System.EventHandler(this.selectOriginalDepartmentButton_Click);
            // 
            // departmentEditDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(582, 307);
            this.Controls.Add(this.selectOriginalDepartmentButton);
            this.Controls.Add(this.originalDepartmentTextBox);
            this.Controls.Add(this.originalDepartmentLabel);
            this.Controls.Add(this.TitleEnlabel);
            this.Controls.Add(this.titleEnTextBox);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmbutton);
            this.Controls.Add(this.Descriptionlabel);
            this.Controls.Add(this.Codelabel);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Font = new System.Drawing.Font("Tahoma", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "departmentEditDialogForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "تعریف واحد سازمانی";
            this.Load += new System.EventHandler(this.DepartmentEditDialogForm_Load);
            this.Leave += new System.EventHandler(this.CodeTextBox_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.TitleErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label Codelabel;
        private System.Windows.Forms.Label Descriptionlabel;
        private System.Windows.Forms.Button confirmbutton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ErrorProvider TitleErrorProvider;
        private System.Windows.Forms.ErrorProvider CodeErrorProvider;
        private Jamsaz.Common.NullableTextBox codeTextBox;
        private System.Windows.Forms.Label TitleEnlabel;
        private System.Windows.Forms.TextBox titleEnTextBox;
        private System.Windows.Forms.Button selectOriginalDepartmentButton;
        private System.Windows.Forms.TextBox originalDepartmentTextBox;
        private System.Windows.Forms.Label originalDepartmentLabel;
    }
}