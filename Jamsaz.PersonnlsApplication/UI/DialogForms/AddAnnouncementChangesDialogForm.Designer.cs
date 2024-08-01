namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class AddAnnouncementChangesDialogForm
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
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label personnelNumberLabel;
            System.Windows.Forms.Label codeLabel;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.changeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.changeTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectPersonnelButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.firstContractStartDateDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.personnelNumberTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.announcementChangeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            descriptionLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            personnelNumberLabel = new System.Windows.Forms.Label();
            codeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.announcementChangeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(495, 151);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(51, 13);
            descriptionLabel.TabIndex = 28;
            descriptionLabel.Text = "توضیحات:";
            // 
            // priceLabel
            // 
            priceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(490, 116);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(33, 13);
            priceLabel.TabIndex = 27;
            priceLabel.Text = "تغییر:";
            // 
            // dateLabel
            // 
            dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(490, 84);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(32, 13);
            dateLabel.TabIndex = 25;
            dateLabel.Text = "تاریخ:";
            // 
            // personnelNumberLabel
            // 
            personnelNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            personnelNumberLabel.AutoSize = true;
            personnelNumberLabel.Location = new System.Drawing.Point(490, 53);
            personnelNumberLabel.Name = "personnelNumberLabel";
            personnelNumberLabel.Size = new System.Drawing.Size(42, 13);
            personnelNumberLabel.TabIndex = 24;
            personnelNumberLabel.Text = "پرسنل:";
            // 
            // codeLabel
            // 
            codeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(490, 17);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(22, 13);
            codeLabel.TabIndex = 23;
            codeLabel.Text = "کد:";
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(591, 376);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancelButton);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.arrow_up;
            this.cancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelButton.Location = new System.Drawing.Point(90, 20);
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
            this.saveButton.Location = new System.Drawing.Point(9, 20);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "تایید";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.changeTypeComboBox);
            this.groupBox2.Controls.Add(this.selectPersonnelButton);
            this.groupBox2.Controls.Add(this.descriptionTextBox);
            this.groupBox2.Controls.Add(this.firstContractStartDateDatePicker);
            this.groupBox2.Controls.Add(this.personnelNumberTextBox);
            this.groupBox2.Controls.Add(this.fullNameTextBox);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(descriptionLabel);
            this.groupBox2.Controls.Add(priceLabel);
            this.groupBox2.Controls.Add(dateLabel);
            this.groupBox2.Controls.Add(personnelNumberLabel);
            this.groupBox2.Controls.Add(codeLabel);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(585, 310);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // changeTypeComboBox
            // 
            this.changeTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeTypeComboBox.DataSource = this.changeTypeBindingSource;
            this.changeTypeComboBox.DisplayMember = "Title";
            this.changeTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.changeTypeComboBox.FormattingEnabled = true;
            this.changeTypeComboBox.Location = new System.Drawing.Point(327, 116);
            this.changeTypeComboBox.Name = "changeTypeComboBox";
            this.changeTypeComboBox.Size = new System.Drawing.Size(156, 21);
            this.changeTypeComboBox.TabIndex = 37;
            this.changeTypeComboBox.ValueMember = "ID";
            // 
            // changeTypeBindingSource
            // 
            this.changeTypeBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.ChangeType);
            // 
            // selectPersonnelButton
            // 
            this.selectPersonnelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectPersonnelButton.Location = new System.Drawing.Point(126, 49);
            this.selectPersonnelButton.Name = "selectPersonnelButton";
            this.selectPersonnelButton.Size = new System.Drawing.Size(29, 23);
            this.selectPersonnelButton.TabIndex = 36;
            this.selectPersonnelButton.Text = "...";
            this.selectPersonnelButton.UseVisualStyleBackColor = true;
            this.selectPersonnelButton.Click += new System.EventHandler(this.selectPersonnelButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.announcementChangeBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(33, 151);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(451, 133);
            this.descriptionTextBox.TabIndex = 35;
            // 
            // firstContractStartDateDatePicker
            // 
            this.firstContractStartDateDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.firstContractStartDateDatePicker.DataBindings.Add(new System.Windows.Forms.Binding("SelectedDateTime", this.announcementChangeBindingSource, "DateTime", true));
            this.firstContractStartDateDatePicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.firstContractStartDateDatePicker.Location = new System.Drawing.Point(328, 84);
            this.firstContractStartDateDatePicker.Name = "firstContractStartDateDatePicker";
            this.firstContractStartDateDatePicker.Size = new System.Drawing.Size(156, 20);
            this.firstContractStartDateDatePicker.TabIndex = 32;
            // 
            // personnelNumberTextBox
            // 
            this.personnelNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.personnelNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.announcementChangeBindingSource, "PersonnelNumber", true));
            this.personnelNumberTextBox.Location = new System.Drawing.Point(401, 50);
            this.personnelNumberTextBox.Name = "personnelNumberTextBox";
            this.personnelNumberTextBox.ReadOnly = true;
            this.personnelNumberTextBox.Size = new System.Drawing.Size(83, 21);
            this.personnelNumberTextBox.TabIndex = 31;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.announcementChangeBindingSource, "PersonnelName", true));
            this.fullNameTextBox.Location = new System.Drawing.Point(160, 50);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.ReadOnly = true;
            this.fullNameTextBox.Size = new System.Drawing.Size(235, 21);
            this.fullNameTextBox.TabIndex = 30;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.announcementChangeBindingSource, "Code", true));
            this.textBox1.Location = new System.Drawing.Point(401, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(83, 21);
            this.textBox1.TabIndex = 29;
            // 
            // announcementChangeBindingSource
            // 
            this.announcementChangeBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.AnnouncementChange);
            // 
            // AddAnnouncementChangesDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 376);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddAnnouncementChangesDialogForm";
            this.ShowIcon = false;
            this.Text = "ثبت";
            this.Load += new System.EventHandler(this.AddAnnouncementChangesDialogForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.announcementChangeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox changeTypeComboBox;
        private System.Windows.Forms.BindingSource changeTypeBindingSource;
        private System.Windows.Forms.Button selectPersonnelButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private FarsiLibrary.Win.Controls.FADatePicker firstContractStartDateDatePicker;
        private System.Windows.Forms.TextBox personnelNumberTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource announcementChangeBindingSource;
    }
}