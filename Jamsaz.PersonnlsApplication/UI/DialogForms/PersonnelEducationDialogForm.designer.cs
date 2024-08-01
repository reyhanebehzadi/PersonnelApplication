namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class PersonnelEducationDialogForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.personnelEducationDataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.returnButton = new System.Windows.Forms.Button();
            this.deletedButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.titlePersonnelFullNameLabel = new System.Windows.Forms.Label();
            this.titlePersonnelNumberLabel = new System.Windows.Forms.Label();
            this.personnelFullNameLabel = new System.Windows.Forms.Label();
            this.personnelNumberLabel = new System.Windows.Forms.Label();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.graduationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.educationalOrganaizationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStudyingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnelsEducationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personnelEducationDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personnelsEducationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.8357F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.18062F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.81938F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(785, 516);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.personnelEducationDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 376);
            this.panel1.TabIndex = 1;
            // 
            // personnelEducationDataGridView
            // 
            this.personnelEducationDataGridView.AllowUserToAddRows = false;
            this.personnelEducationDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.personnelEducationDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.personnelEducationDataGridView.AutoGenerateColumns = false;
            this.personnelEducationDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.personnelEducationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personnelEducationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.personnelIDDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.graduationDateDataGridViewTextBoxColumn,
            this.educationalOrganaizationNameDataGridViewTextBoxColumn,
            this.gPADataGridViewTextBoxColumn,
            this.statusStudyingDataGridViewTextBoxColumn});
            this.personnelEducationDataGridView.DataSource = this.personnelsEducationBindingSource;
            this.personnelEducationDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personnelEducationDataGridView.Location = new System.Drawing.Point(0, 0);
            this.personnelEducationDataGridView.MultiSelect = false;
            this.personnelEducationDataGridView.Name = "personnelEducationDataGridView";
            this.personnelEducationDataGridView.ReadOnly = true;
            this.personnelEducationDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.personnelEducationDataGridView.Size = new System.Drawing.Size(779, 376);
            this.personnelEducationDataGridView.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.returnButton);
            this.panel2.Controls.Add(this.deletedButton);
            this.panel2.Controls.Add(this.addButton);
            this.panel2.Controls.Add(this.editButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panel2.Location = new System.Drawing.Point(3, 464);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 49);
            this.panel2.TabIndex = 2;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(9, 11);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 29);
            this.returnButton.TabIndex = 3;
            this.returnButton.Text = "برگشت";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click_1);
            // 
            // deletedButton
            // 
            this.deletedButton.Location = new System.Drawing.Point(530, 11);
            this.deletedButton.Name = "deletedButton";
            this.deletedButton.Size = new System.Drawing.Size(75, 29);
            this.deletedButton.TabIndex = 2;
            this.deletedButton.Text = "حذف";
            this.deletedButton.UseVisualStyleBackColor = true;
            this.deletedButton.Click += new System.EventHandler(this.deletedButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(692, 11);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 29);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "اضافه";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(611, 11);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 29);
            this.editButton.TabIndex = 0;
            this.editButton.Text = "ویرایش";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.panel3.Controls.Add(this.titlePersonnelFullNameLabel);
            this.panel3.Controls.Add(this.titlePersonnelNumberLabel);
            this.panel3.Controls.Add(this.personnelFullNameLabel);
            this.panel3.Controls.Add(this.personnelNumberLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel3.Size = new System.Drawing.Size(779, 73);
            this.panel3.TabIndex = 3;
            // 
            // titlePersonnelFullNameLabel
            // 
            this.titlePersonnelFullNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.titlePersonnelFullNameLabel.Location = new System.Drawing.Point(287, 38);
            this.titlePersonnelFullNameLabel.Name = "titlePersonnelFullNameLabel";
            this.titlePersonnelFullNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.titlePersonnelFullNameLabel.Size = new System.Drawing.Size(352, 23);
            this.titlePersonnelFullNameLabel.TabIndex = 3;
            // 
            // titlePersonnelNumberLabel
            // 
            this.titlePersonnelNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.titlePersonnelNumberLabel.Location = new System.Drawing.Point(309, 6);
            this.titlePersonnelNumberLabel.Name = "titlePersonnelNumberLabel";
            this.titlePersonnelNumberLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.titlePersonnelNumberLabel.Size = new System.Drawing.Size(329, 23);
            this.titlePersonnelNumberLabel.TabIndex = 2;
            // 
            // personnelFullNameLabel
            // 
            this.personnelFullNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.personnelFullNameLabel.Location = new System.Drawing.Point(635, 38);
            this.personnelFullNameLabel.Name = "personnelFullNameLabel";
            this.personnelFullNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.personnelFullNameLabel.Size = new System.Drawing.Size(136, 23);
            this.personnelFullNameLabel.TabIndex = 1;
            this.personnelFullNameLabel.Text = "نام و نام خانوادگی:";
            // 
            // personnelNumberLabel
            // 
            this.personnelNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.personnelNumberLabel.Location = new System.Drawing.Point(657, 6);
            this.personnelNumberLabel.Name = "personnelNumberLabel";
            this.personnelNumberLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.personnelNumberLabel.Size = new System.Drawing.Size(113, 23);
            this.personnelNumberLabel.TabIndex = 0;
            this.personnelNumberLabel.Text = "شماره پرسنلی:";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // personnelIDDataGridViewTextBoxColumn
            // 
            this.personnelIDDataGridViewTextBoxColumn.DataPropertyName = "PersonnelID";
            this.personnelIDDataGridViewTextBoxColumn.HeaderText = "PersonnelID";
            this.personnelIDDataGridViewTextBoxColumn.Name = "personnelIDDataGridViewTextBoxColumn";
            this.personnelIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.personnelIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDatePersianDate";
            this.startDateDataGridViewTextBoxColumn.FillWeight = 90F;
            this.startDateDataGridViewTextBoxColumn.HeaderText = "تاریخ ورودی";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.startDateDataGridViewTextBoxColumn.Width = 90;
            // 
            // graduationDateDataGridViewTextBoxColumn
            // 
            this.graduationDateDataGridViewTextBoxColumn.DataPropertyName = "GraduationDatePersianDate";
            this.graduationDateDataGridViewTextBoxColumn.FillWeight = 130F;
            this.graduationDateDataGridViewTextBoxColumn.HeaderText = "تاریخ فارغ التحصیلی";
            this.graduationDateDataGridViewTextBoxColumn.Name = "graduationDateDataGridViewTextBoxColumn";
            this.graduationDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.graduationDateDataGridViewTextBoxColumn.Width = 130;
            // 
            // educationalOrganaizationNameDataGridViewTextBoxColumn
            // 
            this.educationalOrganaizationNameDataGridViewTextBoxColumn.DataPropertyName = "EducationalOrganaizationName";
            this.educationalOrganaizationNameDataGridViewTextBoxColumn.HeaderText = "نام موسسه";
            this.educationalOrganaizationNameDataGridViewTextBoxColumn.Name = "educationalOrganaizationNameDataGridViewTextBoxColumn";
            this.educationalOrganaizationNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gPADataGridViewTextBoxColumn
            // 
            this.gPADataGridViewTextBoxColumn.DataPropertyName = "GPA";
            this.gPADataGridViewTextBoxColumn.HeaderText = "معدل";
            this.gPADataGridViewTextBoxColumn.Name = "gPADataGridViewTextBoxColumn";
            this.gPADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusStudyingDataGridViewTextBoxColumn
            // 
            this.statusStudyingDataGridViewTextBoxColumn.DataPropertyName = "StatusStudyingTitle";
            this.statusStudyingDataGridViewTextBoxColumn.HeaderText = "وضعیت تحصیل";
            this.statusStudyingDataGridViewTextBoxColumn.Name = "statusStudyingDataGridViewTextBoxColumn";
            this.statusStudyingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personnelsEducationBindingSource
            // 
            this.personnelsEducationBindingSource.AllowNew = true;
            this.personnelsEducationBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.PersonnalsEducation);
            // 
            // PersonnelEducationDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(785, 516);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonnelEducationDialogForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "فرم سوابق تحصیلی";
            this.Load += new System.EventHandler(this.frmPersonnelEducation_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personnelEducationDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personnelsEducationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource personnelsEducationBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deletedButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label personnelNumberLabel;
        private System.Windows.Forms.Label personnelFullNameLabel;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label titlePersonnelFullNameLabel;
        private System.Windows.Forms.Label titlePersonnelNumberLabel;
        private System.Windows.Forms.DataGridView personnelEducationDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn degreeLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn graduationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn educationalOrganaizationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusStudyingDataGridViewTextBoxColumn;

    }
}