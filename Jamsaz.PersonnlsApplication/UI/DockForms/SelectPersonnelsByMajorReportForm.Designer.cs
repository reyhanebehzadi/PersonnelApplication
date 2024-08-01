namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    partial class SelectPersonnelsByMajorReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.mainReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.getReportButton = new System.Windows.Forms.Button();
            this.selectUniversityDegreeButton = new System.Windows.Forms.Button();
            this.universityDegreeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleMajorNameLabel = new System.Windows.Forms.Label();
            this.selectMajorButton = new System.Windows.Forms.Button();
            this.majorNameTextBox = new System.Windows.Forms.TextBox();
            this.menRadioButton = new System.Windows.Forms.RadioButton();
            this.womenRadioButton = new System.Windows.Forms.RadioButton();
            this.allRadioButton = new System.Windows.Forms.RadioButton();
            this.SelectPersonnelByMajorResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universityDegreeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectPersonnelByMajorResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDegreeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainReportViewer
            // 
            this.mainReportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainReportViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            reportDataSource1.Name = "Jamsaz_PersonnlsApplication_BusinessObjects_Data_SelectPersonnelByMajorResult";
            reportDataSource1.Value = this.SelectPersonnelByMajorResultBindingSource;
            this.mainReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.mainReportViewer.LocalReport.ReportEmbeddedResource = "Jamsaz.PersonnlsApplication.Reports.SelectPersonnelsByMajorReport.rdlc";
            this.mainReportViewer.Location = new System.Drawing.Point(-1, 84);
            this.mainReportViewer.Name = "mainReportViewer";
            this.mainReportViewer.Size = new System.Drawing.Size(893, 641);
            this.mainReportViewer.TabIndex = 0;
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchGroupBox.Controls.Add(this.allRadioButton);
            this.searchGroupBox.Controls.Add(this.womenRadioButton);
            this.searchGroupBox.Controls.Add(this.menRadioButton);
            this.searchGroupBox.Controls.Add(this.getReportButton);
            this.searchGroupBox.Controls.Add(this.selectUniversityDegreeButton);
            this.searchGroupBox.Controls.Add(this.universityDegreeTextBox);
            this.searchGroupBox.Controls.Add(this.label1);
            this.searchGroupBox.Controls.Add(this.TitleMajorNameLabel);
            this.searchGroupBox.Controls.Add(this.selectMajorButton);
            this.searchGroupBox.Controls.Add(this.majorNameTextBox);
            this.searchGroupBox.Location = new System.Drawing.Point(276, 1);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchGroupBox.Size = new System.Drawing.Size(616, 77);
            this.searchGroupBox.TabIndex = 4;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "فیلتر";
            // 
            // getReportButton
            // 
            this.getReportButton.Location = new System.Drawing.Point(6, 44);
            this.getReportButton.Name = "getReportButton";
            this.getReportButton.Size = new System.Drawing.Size(82, 23);
            this.getReportButton.TabIndex = 12;
            this.getReportButton.Text = "دریافت گزارش";
            this.getReportButton.UseVisualStyleBackColor = true;
            this.getReportButton.Click += new System.EventHandler(this.getReportButton_Click);
            // 
            // selectUniversityDegreeButton
            // 
            this.selectUniversityDegreeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectUniversityDegreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.selectUniversityDegreeButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.t_complete;
            this.selectUniversityDegreeButton.Location = new System.Drawing.Point(203, 45);
            this.selectUniversityDegreeButton.Name = "selectUniversityDegreeButton";
            this.selectUniversityDegreeButton.Size = new System.Drawing.Size(29, 23);
            this.selectUniversityDegreeButton.TabIndex = 11;
            this.selectUniversityDegreeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.selectUniversityDegreeButton.UseVisualStyleBackColor = true;
            this.selectUniversityDegreeButton.Click += new System.EventHandler(this.selectUniversityDegreeButton_Click);
            // 
            // universityDegreeTextBox
            // 
            this.universityDegreeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.universityDegreeTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.universityDegreeTextBox.Location = new System.Drawing.Point(238, 47);
            this.universityDegreeTextBox.Name = "universityDegreeTextBox";
            this.universityDegreeTextBox.ReadOnly = true;
            this.universityDegreeTextBox.Size = new System.Drawing.Size(240, 21);
            this.universityDegreeTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(498, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "انتخاب مقطع تحصیلی";
            // 
            // TitleMajorNameLabel
            // 
            this.TitleMajorNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleMajorNameLabel.AutoSize = true;
            this.TitleMajorNameLabel.Location = new System.Drawing.Point(486, 23);
            this.TitleMajorNameLabel.Name = "TitleMajorNameLabel";
            this.TitleMajorNameLabel.Size = new System.Drawing.Size(121, 13);
            this.TitleMajorNameLabel.TabIndex = 6;
            this.TitleMajorNameLabel.Text = "انتخاب نام رشته تحصیلی";
            // 
            // selectMajorButton
            // 
            this.selectMajorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectMajorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.selectMajorButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.t_complete;
            this.selectMajorButton.Location = new System.Drawing.Point(203, 19);
            this.selectMajorButton.Name = "selectMajorButton";
            this.selectMajorButton.Size = new System.Drawing.Size(29, 23);
            this.selectMajorButton.TabIndex = 5;
            this.selectMajorButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.selectMajorButton.UseVisualStyleBackColor = true;
            this.selectMajorButton.Click += new System.EventHandler(this.selectMajorButton_Click);
            // 
            // majorNameTextBox
            // 
            this.majorNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.majorNameTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.majorNameTextBox.Location = new System.Drawing.Point(238, 20);
            this.majorNameTextBox.Name = "majorNameTextBox";
            this.majorNameTextBox.ReadOnly = true;
            this.majorNameTextBox.Size = new System.Drawing.Size(240, 21);
            this.majorNameTextBox.TabIndex = 4;
            // 
            // menRadioButton
            // 
            this.menRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menRadioButton.AutoSize = true;
            this.menRadioButton.Checked = true;
            this.menRadioButton.Location = new System.Drawing.Point(156, 19);
            this.menRadioButton.Name = "menRadioButton";
            this.menRadioButton.Size = new System.Drawing.Size(41, 17);
            this.menRadioButton.TabIndex = 13;
            this.menRadioButton.TabStop = true;
            this.menRadioButton.Text = "مرد";
            this.menRadioButton.UseVisualStyleBackColor = true;
            // 
            // womenRadioButton
            // 
            this.womenRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.womenRadioButton.AutoSize = true;
            this.womenRadioButton.Location = new System.Drawing.Point(104, 19);
            this.womenRadioButton.Name = "womenRadioButton";
            this.womenRadioButton.Size = new System.Drawing.Size(36, 17);
            this.womenRadioButton.TabIndex = 14;
            this.womenRadioButton.Text = "زن";
            this.womenRadioButton.UseVisualStyleBackColor = true;
            // 
            // allRadioButton
            // 
            this.allRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.allRadioButton.AutoSize = true;
            this.allRadioButton.Location = new System.Drawing.Point(42, 19);
            this.allRadioButton.Name = "allRadioButton";
            this.allRadioButton.Size = new System.Drawing.Size(46, 17);
            this.allRadioButton.TabIndex = 15;
            this.allRadioButton.Text = "همه";
            this.allRadioButton.UseVisualStyleBackColor = true;
            // 
            // SelectPersonnelByMajorResultBindingSource
            // 
            this.SelectPersonnelByMajorResultBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.SelectPersonnelByMajorResult);
            // 
            // universityDegreeBindingSource
            // 
            this.universityDegreeBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.UniversityDegree);
            // 
            // SelectPersonnelsByMajorReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(892, 725);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.mainReportViewer);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "SelectPersonnelsByMajorReportForm";
            this.ShowIcon = false;
            this.Text = "گزارش پرسنل به تفکیک رشته ها";
            this.Load += new System.EventHandler(this.SelectPersonnelsByMajorReportForm_Load);
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectPersonnelByMajorResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDegreeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer mainReportViewer;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Label TitleMajorNameLabel;
        private System.Windows.Forms.Button selectMajorButton;
        private System.Windows.Forms.TextBox majorNameTextBox;
        private System.Windows.Forms.BindingSource SelectPersonnelByMajorResultBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource universityDegreeBindingSource;
        private System.Windows.Forms.Button selectUniversityDegreeButton;
        private System.Windows.Forms.TextBox universityDegreeTextBox;
        private System.Windows.Forms.Button getReportButton;
        private System.Windows.Forms.RadioButton allRadioButton;
        private System.Windows.Forms.RadioButton womenRadioButton;
        private System.Windows.Forms.RadioButton menRadioButton;
    }
}