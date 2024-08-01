namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class AddEvaluationIndexDialogForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleTextbox = new Jamsaz.CustomTextBox.CustomTextbox();
            this.CodeTextbox = new Jamsaz.CustomTextBox.CustomTextbox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(512, 147);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cancelButton);
            this.groupBox2.Controls.Add(this.saveButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 44);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.arrow_up;
            this.cancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelButton.Location = new System.Drawing.Point(9, 15);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "لغو";
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.arrow_down;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveButton.Location = new System.Drawing.Point(90, 15);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "تائید";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TitleTextbox);
            this.groupBox1.Controls.Add(this.CodeTextbox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "کد  :  ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "عنوان  :  ";
            // 
            // TitleTextbox
            // 
            this.TitleTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleTextbox.Decimals = false;
            this.TitleTextbox.Farsi = true;
            this.TitleTextbox.Location = new System.Drawing.Point(9, 51);
            this.TitleTextbox.Name = "TitleTextbox";
            this.TitleTextbox.NextControlFocuswhenPressEnter = true;
            this.TitleTextbox.SelectAllTextWhenFocus = false;
            this.TitleTextbox.Seperator = false;
            this.TitleTextbox.Size = new System.Drawing.Size(436, 21);
            this.TitleTextbox.TabIndex = 1;
            this.TitleTextbox.TextType = Jamsaz.CustomTextBox.TxtType.Any;
            // 
            // CodeTextbox
            // 
            this.CodeTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CodeTextbox.Decimals = false;
            this.CodeTextbox.Farsi = false;
            this.CodeTextbox.Location = new System.Drawing.Point(374, 20);
            this.CodeTextbox.Name = "CodeTextbox";
            this.CodeTextbox.NextControlFocuswhenPressEnter = true;
            this.CodeTextbox.SelectAllTextWhenFocus = false;
            this.CodeTextbox.Seperator = false;
            this.CodeTextbox.Size = new System.Drawing.Size(71, 21);
            this.CodeTextbox.TabIndex = 0;
            this.CodeTextbox.TextType = Jamsaz.CustomTextBox.TxtType.Digit;
            // 
            // AddEvaluationIndexDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 147);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(528, 186);
            this.Name = "AddEvaluationIndexDialogForm";
            this.ShowIcon = false;
            this.Text = "ثبت جدید";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private CustomTextBox.CustomTextbox TitleTextbox;
        private CustomTextBox.CustomTextbox CodeTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}