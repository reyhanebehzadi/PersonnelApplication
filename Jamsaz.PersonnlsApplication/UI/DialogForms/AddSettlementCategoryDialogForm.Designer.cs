namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class AddSettlementCategoryDialogForm
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
            System.Windows.Forms.Label titleLabel;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.settlementCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            codeLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settlementCategoryBindingSource)).BeginInit();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 176);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cancelButton);
            this.groupBox2.Controls.Add(this.saveButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 44);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.arrow_up;
            this.cancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelButton.Location = new System.Drawing.Point(9, 15);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "لغو";
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
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
            this.saveButton.Text = "تایید";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(titleLabel);
            this.groupBox1.Controls.Add(this.titleTextBox);
            this.groupBox1.Controls.Add(codeLabel);
            this.groupBox1.Controls.Add(this.codeTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // settlementCategoryBindingSource
            // 
            this.settlementCategoryBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.SettlementCategory);
            // 
            // codeLabel
            // 
            codeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(391, 32);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(22, 13);
            codeLabel.TabIndex = 0;
            codeLabel.Text = "کد:";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settlementCategoryBindingSource, "Code", true));
            this.codeTextBox.Location = new System.Drawing.Point(103, 32);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(287, 21);
            this.codeTextBox.TabIndex = 1;
            // 
            // titleLabel
            // 
            titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(396, 75);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(37, 13);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "عنوان:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settlementCategoryBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(103, 72);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(287, 21);
            this.titleTextBox.TabIndex = 3;
            // 
            // AddSettlementCategoryDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 176);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddSettlementCategoryDialogForm";
            this.ShowIcon = false;
            this.Text = "ثبت جدید";
            this.Load += new System.EventHandler(this.AddSettlementCategoryDialogForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settlementCategoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.BindingSource settlementCategoryBindingSource;
        private System.Windows.Forms.TextBox codeTextBox;
    }
}