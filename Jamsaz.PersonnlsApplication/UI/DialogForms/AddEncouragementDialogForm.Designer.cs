namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class AddEncouragementDialogForm
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
            System.Windows.Forms.Label personnelNameLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label applicantNameLabel;
            System.Windows.Forms.Label confirmorNameLabel;
            System.Windows.Forms.Label reasonLabel;
            System.Windows.Forms.Label descriptionLabel;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.firstContractStartDateDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.encouragementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectConfirmorButton = new System.Windows.Forms.Button();
            this.selectApplicantButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.reasonTextBox = new System.Windows.Forms.TextBox();
            this.confirmorNameTextBox = new System.Windows.Forms.TextBox();
            this.applicantNameTextBox = new System.Windows.Forms.TextBox();
            this.personnelNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            personnelNameLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            applicantNameLabel = new System.Windows.Forms.Label();
            confirmorNameLabel = new System.Windows.Forms.Label();
            reasonLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.encouragementBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // personnelNameLabel
            // 
            personnelNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            personnelNameLabel.AutoSize = true;
            personnelNameLabel.Location = new System.Drawing.Point(517, 29);
            personnelNameLabel.Name = "personnelNameLabel";
            personnelNameLabel.Size = new System.Drawing.Size(54, 13);
            personnelNameLabel.TabIndex = 0;
            personnelNameLabel.Text = "نام پرسنل";
            // 
            // dateLabel
            // 
            dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(536, 57);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(35, 13);
            dateLabel.TabIndex = 2;
            dateLabel.Text = "تاریخ :";
            // 
            // applicantNameLabel
            // 
            applicantNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            applicantNameLabel.AutoSize = true;
            applicantNameLabel.Location = new System.Drawing.Point(488, 92);
            applicantNameLabel.Name = "applicantNameLabel";
            applicantNameLabel.Size = new System.Drawing.Size(83, 13);
            applicantNameLabel.TabIndex = 4;
            applicantNameLabel.Text = "درخواست کننده:";
            // 
            // confirmorNameLabel
            // 
            confirmorNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            confirmorNameLabel.AutoSize = true;
            confirmorNameLabel.Location = new System.Drawing.Point(514, 114);
            confirmorNameLabel.Name = "confirmorNameLabel";
            confirmorNameLabel.Size = new System.Drawing.Size(57, 13);
            confirmorNameLabel.TabIndex = 7;
            confirmorNameLabel.Text = "تایید کننده:";
            // 
            // reasonLabel
            // 
            reasonLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            reasonLabel.AutoSize = true;
            reasonLabel.Location = new System.Drawing.Point(540, 138);
            reasonLabel.Name = "reasonLabel";
            reasonLabel.Size = new System.Drawing.Size(31, 13);
            reasonLabel.TabIndex = 10;
            reasonLabel.Text = "دلیل:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(502, 210);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(69, 13);
            descriptionLabel.TabIndex = 12;
            descriptionLabel.Text = "نوع نشویقی‌:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(616, 353);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.firstContractStartDateDatePicker);
            this.groupBox1.Controls.Add(this.selectConfirmorButton);
            this.groupBox1.Controls.Add(this.selectApplicantButton);
            this.groupBox1.Controls.Add(descriptionLabel);
            this.groupBox1.Controls.Add(this.descriptionTextBox);
            this.groupBox1.Controls.Add(reasonLabel);
            this.groupBox1.Controls.Add(this.reasonTextBox);
            this.groupBox1.Controls.Add(confirmorNameLabel);
            this.groupBox1.Controls.Add(this.confirmorNameTextBox);
            this.groupBox1.Controls.Add(applicantNameLabel);
            this.groupBox1.Controls.Add(this.applicantNameTextBox);
            this.groupBox1.Controls.Add(dateLabel);
            this.groupBox1.Controls.Add(personnelNameLabel);
            this.groupBox1.Controls.Add(this.personnelNameTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 287);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // firstContractStartDateDatePicker
            // 
            this.firstContractStartDateDatePicker.DataBindings.Add(new System.Windows.Forms.Binding("SelectedDateTime", this.encouragementBindingSource, "Date", true));
            this.firstContractStartDateDatePicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.firstContractStartDateDatePicker.Location = new System.Drawing.Point(315, 53);
            this.firstContractStartDateDatePicker.Name = "firstContractStartDateDatePicker";
            this.firstContractStartDateDatePicker.Size = new System.Drawing.Size(164, 23);
            this.firstContractStartDateDatePicker.TabIndex = 3;
            // 
            // encouragementBindingSource
            // 
            this.encouragementBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.Encouragement);
            // 
            // selectConfirmorButton
            // 
            this.selectConfirmorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectConfirmorButton.Location = new System.Drawing.Point(279, 109);
            this.selectConfirmorButton.Name = "selectConfirmorButton";
            this.selectConfirmorButton.Size = new System.Drawing.Size(30, 23);
            this.selectConfirmorButton.TabIndex = 9;
            this.selectConfirmorButton.Text = "...";
            this.selectConfirmorButton.UseVisualStyleBackColor = true;
            this.selectConfirmorButton.Click += new System.EventHandler(this.selectConfirmorButton_Click);
            // 
            // selectApplicantButton
            // 
            this.selectApplicantButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectApplicantButton.Location = new System.Drawing.Point(279, 82);
            this.selectApplicantButton.Name = "selectApplicantButton";
            this.selectApplicantButton.Size = new System.Drawing.Size(30, 23);
            this.selectApplicantButton.TabIndex = 6;
            this.selectApplicantButton.Text = "...";
            this.selectApplicantButton.UseVisualStyleBackColor = true;
            this.selectApplicantButton.Click += new System.EventHandler(this.selectApplicantButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.encouragementBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(43, 207);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(436, 63);
            this.descriptionTextBox.TabIndex = 13;
            // 
            // reasonTextBox
            // 
            this.reasonTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reasonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.encouragementBindingSource, "Reason", true));
            this.reasonTextBox.Location = new System.Drawing.Point(43, 138);
            this.reasonTextBox.Multiline = true;
            this.reasonTextBox.Name = "reasonTextBox";
            this.reasonTextBox.Size = new System.Drawing.Size(436, 63);
            this.reasonTextBox.TabIndex = 11;
            // 
            // confirmorNameTextBox
            // 
            this.confirmorNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmorNameTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.confirmorNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.encouragementBindingSource, "ConfirmorName", true));
            this.confirmorNameTextBox.Location = new System.Drawing.Point(315, 111);
            this.confirmorNameTextBox.Name = "confirmorNameTextBox";
            this.confirmorNameTextBox.ReadOnly = true;
            this.confirmorNameTextBox.Size = new System.Drawing.Size(164, 21);
            this.confirmorNameTextBox.TabIndex = 8;
            // 
            // applicantNameTextBox
            // 
            this.applicantNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.applicantNameTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.applicantNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.encouragementBindingSource, "ApplicantName", true));
            this.applicantNameTextBox.Location = new System.Drawing.Point(315, 84);
            this.applicantNameTextBox.Name = "applicantNameTextBox";
            this.applicantNameTextBox.ReadOnly = true;
            this.applicantNameTextBox.Size = new System.Drawing.Size(164, 21);
            this.applicantNameTextBox.TabIndex = 5;
            // 
            // personnelNameTextBox
            // 
            this.personnelNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.personnelNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.encouragementBindingSource, "PersonnelName", true));
            this.personnelNameTextBox.Location = new System.Drawing.Point(315, 26);
            this.personnelNameTextBox.Name = "personnelNameTextBox";
            this.personnelNameTextBox.ReadOnly = true;
            this.personnelNameTextBox.Size = new System.Drawing.Size(164, 21);
            this.personnelNameTextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cancelButton);
            this.groupBox2.Controls.Add(this.saveButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(610, 54);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.arrow_up;
            this.cancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelButton.Location = new System.Drawing.Point(91, 20);
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
            this.saveButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.arrow_down;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveButton.Location = new System.Drawing.Point(10, 21);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "تایید";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // AddEncouragementDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 353);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddEncouragementDialogForm";
            this.Text = "ثبت تشویقی پرسنل";
            this.Load += new System.EventHandler(this.AddEncouragementDialogForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.encouragementBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button selectConfirmorButton;
        private System.Windows.Forms.Button selectApplicantButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.BindingSource encouragementBindingSource;
        private System.Windows.Forms.TextBox reasonTextBox;
        private System.Windows.Forms.TextBox confirmorNameTextBox;
        private System.Windows.Forms.TextBox applicantNameTextBox;
        private System.Windows.Forms.TextBox personnelNameTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private FarsiLibrary.Win.Controls.FADatePicker firstContractStartDateDatePicker;
    }
}