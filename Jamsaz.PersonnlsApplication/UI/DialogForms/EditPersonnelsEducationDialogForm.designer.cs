using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class editPersonnelsEducationDialogForm
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
            this.personnelNumberTextbox = new System.Windows.Forms.TextBox();
            this.personnelsEducationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.personnelsNumberLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.graduationDateTextBox = new FarsiLibrary.Win.Controls.FADatePicker();
            this.startDateDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.GPATextBox = new System.Windows.Forms.MaskedTextBox();
            this.selectDegreeLevelButton = new System.Windows.Forms.Button();
            this.selectMajorButton = new System.Windows.Forms.Button();
            this.statusStudyingComboBox = new System.Windows.Forms.ComboBox();
            this.ItemsStatusStudyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStudyingLabel = new System.Windows.Forms.Label();
            this.GPALabel = new System.Windows.Forms.Label();
            this.degreeLevelLabel = new System.Windows.Forms.Label();
            this.degreeLevelTextBox = new System.Windows.Forms.TextBox();
            this.majorNameTextBox = new System.Windows.Forms.TextBox();
            this.majorNameLabel = new System.Windows.Forms.Label();
            this.educationalOrganaizationNameTextBox = new System.Windows.Forms.TextBox();
            this.educationalOrganaizationNameLabel = new System.Windows.Forms.Label();
            this.graduationDateLabel = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.personnelsEducationBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsStatusStudyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // personnelNumberTextbox
            // 
            this.personnelNumberTextbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.personnelNumberTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personnelsEducationBindingSource, "PersonnelNumber", true));
            this.personnelNumberTextbox.Location = new System.Drawing.Point(477, 36);
            this.personnelNumberTextbox.Name = "personnelNumberTextbox";
            this.personnelNumberTextbox.ReadOnly = true;
            this.personnelNumberTextbox.Size = new System.Drawing.Size(178, 22);
            this.personnelNumberTextbox.TabIndex = 0;
            // 
            // personnelsEducationBindingSource
            // 
            this.personnelsEducationBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.PersonnalsEducation);
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personnelsEducationBindingSource, "FullName", true));
            this.fullNameTextBox.Location = new System.Drawing.Point(477, 71);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.ReadOnly = true;
            this.fullNameTextBox.Size = new System.Drawing.Size(178, 22);
            this.fullNameTextBox.TabIndex = 1;
            // 
            // personnelsNumberLabel
            // 
            this.personnelsNumberLabel.AutoSize = true;
            this.personnelsNumberLabel.Location = new System.Drawing.Point(681, 36);
            this.personnelsNumberLabel.Name = "personnelsNumberLabel";
            this.personnelsNumberLabel.Size = new System.Drawing.Size(84, 14);
            this.personnelsNumberLabel.TabIndex = 4;
            this.personnelsNumberLabel.Text = "شماره پرسنلی";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(681, 74);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(95, 14);
            this.fullNameLabel.TabIndex = 5;
            this.fullNameLabel.Text = "نام ونام خانوادگی";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(711, 114);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(53, 14);
            this.startDateLabel.TabIndex = 7;
            this.startDateLabel.Text = "تاریخ ورود";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.46753F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.53247F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(801, 308);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 49);
            this.panel1.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(711, 17);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "ذخیره";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(630, 17);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "لغو";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.graduationDateTextBox);
            this.panel2.Controls.Add(this.startDateDatePicker);
            this.panel2.Controls.Add(this.GPATextBox);
            this.panel2.Controls.Add(this.selectDegreeLevelButton);
            this.panel2.Controls.Add(this.selectMajorButton);
            this.panel2.Controls.Add(this.statusStudyingComboBox);
            this.panel2.Controls.Add(this.statusStudyingLabel);
            this.panel2.Controls.Add(this.GPALabel);
            this.panel2.Controls.Add(this.degreeLevelLabel);
            this.panel2.Controls.Add(this.degreeLevelTextBox);
            this.panel2.Controls.Add(this.majorNameTextBox);
            this.panel2.Controls.Add(this.majorNameLabel);
            this.panel2.Controls.Add(this.educationalOrganaizationNameTextBox);
            this.panel2.Controls.Add(this.educationalOrganaizationNameLabel);
            this.panel2.Controls.Add(this.graduationDateLabel);
            this.panel2.Controls.Add(this.startDateLabel);
            this.panel2.Controls.Add(this.personnelNumberTextbox);
            this.panel2.Controls.Add(this.fullNameTextBox);
            this.panel2.Controls.Add(this.fullNameLabel);
            this.panel2.Controls.Add(this.personnelsNumberLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 247);
            this.panel2.TabIndex = 1;
            // 
            // graduationDateTextBox
            // 
            this.graduationDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedDateTime", this.personnelsEducationBindingSource, "GraduationDate", true));
            this.graduationDateTextBox.Location = new System.Drawing.Point(476, 150);
            this.graduationDateTextBox.Name = "graduationDateTextBox";
            this.graduationDateTextBox.Size = new System.Drawing.Size(177, 20);
            this.graduationDateTextBox.TabIndex = 29;
            // 
            // startDateDatePicker
            // 
            this.startDateDatePicker.DataBindings.Add(new System.Windows.Forms.Binding("SelectedDateTime", this.personnelsEducationBindingSource, "StartDate", true));
            this.startDateDatePicker.Location = new System.Drawing.Point(477, 108);
            this.startDateDatePicker.Name = "startDateDatePicker";
            this.startDateDatePicker.Size = new System.Drawing.Size(177, 20);
            this.startDateDatePicker.TabIndex = 28;
            // 
            // GPATextBox
            // 
            this.GPATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personnelsEducationBindingSource, "GPA", true));
            this.GPATextBox.Location = new System.Drawing.Point(195, 106);
            this.GPATextBox.Mask = "00.00";
            this.GPATextBox.Name = "GPATextBox";
            this.GPATextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GPATextBox.Size = new System.Drawing.Size(100, 22);
            this.GPATextBox.TabIndex = 27;
            // 
            // selectDegreeLevelButton
            // 
            this.selectDegreeLevelButton.Location = new System.Drawing.Point(80, 70);
            this.selectDegreeLevelButton.Name = "selectDegreeLevelButton";
            this.selectDegreeLevelButton.Size = new System.Drawing.Size(31, 23);
            this.selectDegreeLevelButton.TabIndex = 25;
            this.selectDegreeLevelButton.Text = "...";
            this.selectDegreeLevelButton.UseVisualStyleBackColor = true;
            this.selectDegreeLevelButton.Click += new System.EventHandler(this.SelectDegreeLevelButton_Click);
            // 
            // selectMajorButton
            // 
            this.selectMajorButton.Location = new System.Drawing.Point(80, 34);
            this.selectMajorButton.Name = "selectMajorButton";
            this.selectMajorButton.Size = new System.Drawing.Size(31, 23);
            this.selectMajorButton.TabIndex = 24;
            this.selectMajorButton.Text = "...";
            this.selectMajorButton.UseVisualStyleBackColor = true;
            this.selectMajorButton.Click += new System.EventHandler(this.SelectMajorButton_Click);
            // 
            // statusStudyingComboBox
            // 
            this.statusStudyingComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.personnelsEducationBindingSource, "StatusStudying", true));
            this.statusStudyingComboBox.DataSource = this.ItemsStatusStudyBindingSource;
            this.statusStudyingComboBox.DisplayMember = "Name";
            this.statusStudyingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusStudyingComboBox.FormattingEnabled = true;
            this.statusStudyingComboBox.Location = new System.Drawing.Point(117, 143);
            this.statusStudyingComboBox.Name = "statusStudyingComboBox";
            this.statusStudyingComboBox.Size = new System.Drawing.Size(175, 22);
            this.statusStudyingComboBox.TabIndex = 22;
            this.statusStudyingComboBox.ValueMember = "ID";
            // 
            // ItemsStatusStudyBindingSource
            // 
            this.ItemsStatusStudyBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.Classes.AnyItemsForlist);
            // 
            // statusStudyingLabel
            // 
            this.statusStudyingLabel.AutoSize = true;
            this.statusStudyingLabel.Location = new System.Drawing.Point(309, 146);
            this.statusStudyingLabel.Name = "statusStudyingLabel";
            this.statusStudyingLabel.Size = new System.Drawing.Size(89, 14);
            this.statusStudyingLabel.TabIndex = 21;
            this.statusStudyingLabel.Text = "وضعیت تحصیلات";
            // 
            // GPALabel
            // 
            this.GPALabel.AutoSize = true;
            this.GPALabel.Location = new System.Drawing.Point(364, 114);
            this.GPALabel.Name = "GPALabel";
            this.GPALabel.Size = new System.Drawing.Size(34, 14);
            this.GPALabel.TabIndex = 19;
            this.GPALabel.Text = "معدل";
            // 
            // degreeLevelLabel
            // 
            this.degreeLevelLabel.AutoSize = true;
            this.degreeLevelLabel.Location = new System.Drawing.Point(318, 75);
            this.degreeLevelLabel.Name = "degreeLevelLabel";
            this.degreeLevelLabel.Size = new System.Drawing.Size(82, 14);
            this.degreeLevelLabel.TabIndex = 17;
            this.degreeLevelLabel.Text = "سطح تحصیلات";
            // 
            // degreeLevelTextBox
            // 
            this.degreeLevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personnelsEducationBindingSource, "DegreeLevelName", true));
            this.degreeLevelTextBox.Location = new System.Drawing.Point(117, 68);
            this.degreeLevelTextBox.Name = "degreeLevelTextBox";
            this.degreeLevelTextBox.Size = new System.Drawing.Size(177, 22);
            this.degreeLevelTextBox.TabIndex = 16;
            // 
            // majorNameTextBox
            // 
            this.majorNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personnelsEducationBindingSource, "MajorName", true));
            this.majorNameTextBox.Location = new System.Drawing.Point(117, 34);
            this.majorNameTextBox.Name = "majorNameTextBox";
            this.majorNameTextBox.Size = new System.Drawing.Size(178, 22);
            this.majorNameTextBox.TabIndex = 14;
            // 
            // majorNameLabel
            // 
            this.majorNameLabel.AutoSize = true;
            this.majorNameLabel.Location = new System.Drawing.Point(348, 39);
            this.majorNameLabel.Name = "majorNameLabel";
            this.majorNameLabel.Size = new System.Drawing.Size(52, 14);
            this.majorNameLabel.TabIndex = 15;
            this.majorNameLabel.Text = "نام رشته";
            // 
            // educationalOrganaizationNameTextBox
            // 
            this.educationalOrganaizationNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personnelsEducationBindingSource, "EducationalOrganaizationName", true));
            this.educationalOrganaizationNameTextBox.Location = new System.Drawing.Point(477, 184);
            this.educationalOrganaizationNameTextBox.Name = "educationalOrganaizationNameTextBox";
            this.educationalOrganaizationNameTextBox.Size = new System.Drawing.Size(178, 22);
            this.educationalOrganaizationNameTextBox.TabIndex = 12;
            // 
            // educationalOrganaizationNameLabel
            // 
            this.educationalOrganaizationNameLabel.AutoSize = true;
            this.educationalOrganaizationNameLabel.Location = new System.Drawing.Point(688, 184);
            this.educationalOrganaizationNameLabel.Name = "educationalOrganaizationNameLabel";
            this.educationalOrganaizationNameLabel.Size = new System.Drawing.Size(72, 14);
            this.educationalOrganaizationNameLabel.TabIndex = 13;
            this.educationalOrganaizationNameLabel.Text = "نام موسسه ";
            // 
            // graduationDateLabel
            // 
            this.graduationDateLabel.AutoSize = true;
            this.graduationDateLabel.Location = new System.Drawing.Point(661, 151);
            this.graduationDateLabel.Name = "graduationDateLabel";
            this.graduationDateLabel.Size = new System.Drawing.Size(104, 14);
            this.graduationDateLabel.TabIndex = 10;
            this.graduationDateLabel.Text = "تاریخ فارغ التحصیلی";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // editPersonnelsEducationDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(801, 308);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editPersonnelsEducationDialogForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "فرم ویرایش و اضافه سوابق تحصیلی";
            this.Load += new System.EventHandler(this.frmEditPersonnelsEducation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personnelsEducationBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsStatusStudyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox personnelNumberTextbox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Label personnelsNumberLabel;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource personnelsEducationBindingSource;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label graduationDateLabel;
        private System.Windows.Forms.TextBox majorNameTextBox;
        private System.Windows.Forms.Label majorNameLabel;
        private System.Windows.Forms.TextBox educationalOrganaizationNameTextBox;
        private System.Windows.Forms.Label educationalOrganaizationNameLabel;
        private System.Windows.Forms.Label degreeLevelLabel;
        private System.Windows.Forms.TextBox degreeLevelTextBox;
        private System.Windows.Forms.Label GPALabel;
        private System.Windows.Forms.Label statusStudyingLabel;
        private System.Windows.Forms.ComboBox statusStudyingComboBox;
        private System.Windows.Forms.Button selectDegreeLevelButton;
        private System.Windows.Forms.Button selectMajorButton;
        private System.Windows.Forms.MaskedTextBox GPATextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private FarsiLibrary.Win.Controls.FADatePicker startDateDatePicker;
        private FarsiLibrary.Win.Controls.FADatePicker graduationDateTextBox;
        private System.Windows.Forms.BindingSource ItemsStatusStudyBindingSource;
    }
}