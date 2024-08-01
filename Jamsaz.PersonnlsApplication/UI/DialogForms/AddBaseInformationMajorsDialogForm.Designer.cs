namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class AddBaseInformationMajorsDialogForm
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
            System.Windows.Forms.Label codeLabel;
            System.Windows.Forms.Label nameLabel;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.majorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeTextBox = new System.Windows.Forms.TextBox();
            codeLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.majorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codeLabel
            // 
            codeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(358, 34);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(22, 13);
            codeLabel.TabIndex = 0;
            codeLabel.Text = "کد:";
            // 
            // nameLabel
            // 
            nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(358, 74);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(93, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "نام رشته تحصیلی:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(478, 178);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.cancelButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.arrow_down;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveButton.Location = new System.Drawing.Point(20, 20);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "تایید";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.arrow_up;
            this.cancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelButton.Location = new System.Drawing.Point(101, 20);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "لغو";
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(nameLabel);
            this.groupBox2.Controls.Add(this.nameTextBox);
            this.groupBox2.Controls.Add(codeLabel);
            this.groupBox2.Controls.Add(this.codeTextBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 112);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.majorBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(145, 66);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(207, 21);
            this.nameTextBox.TabIndex = 3;
            // 
            // majorBindingSource
            // 
            this.majorBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.Major);
            // 
            // codeTextBox
            // 
            this.codeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.majorBindingSource, "Code", true));
            this.codeTextBox.Location = new System.Drawing.Point(145, 31);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.ReadOnly = true;
            this.codeTextBox.Size = new System.Drawing.Size(207, 21);
            this.codeTextBox.TabIndex = 1;
            // 
            // AddBaseInformationMajorsDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 178);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBaseInformationMajorsDialogForm";
            this.ShowIcon = false;
            this.Text = "ثبت جدید";
            this.Load += new System.EventHandler(this.AddBaseInformationMajorsDialogForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.majorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.BindingSource majorBindingSource;
        private System.Windows.Forms.TextBox codeTextBox;
    }
}