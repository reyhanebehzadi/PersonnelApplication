namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    partial class DepartmentVersionReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.getRepotButton = new System.Windows.Forms.Button();
            this.DepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentVersionComboBox = new System.Windows.Forms.ComboBox();
            this.departmentVersionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentVersionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource3.Name = "Jamsaz_PersonnlsApplication_BusinessObjects_Data_Department";
            reportDataSource3.Value = this.DepartmentBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "Jamsaz.PersonnlsApplication.Reports.DepartmentVersionReport.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(1, 43);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(796, 590);
            this.reportViewer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "نسخه واحد های سازمانی";
            // 
            // getRepotButton
            // 
            this.getRepotButton.Location = new System.Drawing.Point(268, 10);
            this.getRepotButton.Name = "getRepotButton";
            this.getRepotButton.Size = new System.Drawing.Size(83, 23);
            this.getRepotButton.TabIndex = 6;
            this.getRepotButton.Text = "دریافت گزارش";
            this.getRepotButton.UseVisualStyleBackColor = true;
            this.getRepotButton.Click += new System.EventHandler(this.getRepotButton_Click);
            // 
            // DepartmentBindingSource
            // 
            this.DepartmentBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.Department);
            // 
            // departmentVersionComboBox
            // 
            this.departmentVersionComboBox.DataSource = this.departmentVersionBindingSource;
            this.departmentVersionComboBox.DisplayMember = "Code";
            this.departmentVersionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentVersionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.departmentVersionComboBox.FormattingEnabled = true;
            this.departmentVersionComboBox.Location = new System.Drawing.Point(141, 12);
            this.departmentVersionComboBox.Name = "departmentVersionComboBox";
            this.departmentVersionComboBox.Size = new System.Drawing.Size(121, 21);
            this.departmentVersionComboBox.TabIndex = 7;
            this.departmentVersionComboBox.ValueMember = "ID";
            // 
            // departmentVersionBindingSource
            // 
            this.departmentVersionBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.DepartmentVersion);
            // 
            // DepartmentVersionReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 634);
            this.Controls.Add(this.departmentVersionComboBox);
            this.Controls.Add(this.getRepotButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer);
            this.Name = "DepartmentVersionReportForm";
            this.ShowIcon = false;
            this.Text = "لیست واحد ها";
            this.Load += new System.EventHandler(this.DepartmentVersionReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentVersionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getRepotButton;
        private System.Windows.Forms.BindingSource DepartmentBindingSource;
        private System.Windows.Forms.ComboBox departmentVersionComboBox;
        private System.Windows.Forms.BindingSource departmentVersionBindingSource;
    }
}