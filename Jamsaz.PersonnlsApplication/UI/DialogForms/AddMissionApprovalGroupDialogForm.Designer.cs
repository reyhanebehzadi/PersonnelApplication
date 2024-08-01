namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class AddMissionApprovalGroupDialogForm
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
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label codeLabel;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.missionApprovalGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            titleLabel = new System.Windows.Forms.Label();
            codeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.missionApprovalGroupBindingSource)).BeginInit();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(372, 171);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.groupBox1.Size = new System.Drawing.Size(366, 105);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(295, 69);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(37, 13);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "عنوان:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.missionApprovalGroupBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(9, 61);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(280, 21);
            this.titleTextBox.TabIndex = 1;
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(295, 23);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(22, 13);
            codeLabel.TabIndex = 0;
            codeLabel.Text = "کد:";
            // 
            // codeTextBox
            // 
            this.codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.missionApprovalGroupBindingSource, "Code", true));
            this.codeTextBox.Location = new System.Drawing.Point(189, 20);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.ReadOnly = true;
            this.codeTextBox.Size = new System.Drawing.Size(100, 21);
            this.codeTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.okButton);
            this.groupBox2.Controls.Add(this.cancelButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 54);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // okButton
            // 
            this.okButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.arrow_down;
            this.okButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.okButton.Location = new System.Drawing.Point(90, 20);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "تایید";
            this.okButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.arrow_up;
            this.cancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelButton.Location = new System.Drawing.Point(9, 20);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "لغو";
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // missionApprovalGroupBindingSource
            // 
            this.missionApprovalGroupBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.MissionApprovalGroup);
            // 
            // AddMissionApprovalGroupDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 171);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddMissionApprovalGroupDialogForm";
            this.ShowIcon = false;
            this.Text = "ثبت";
            this.Load += new System.EventHandler(this.AddMissionApprovalGroupDialogForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.missionApprovalGroupBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.BindingSource missionApprovalGroupBindingSource;
    }
}