namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    partial class PersonnelsList1ReportForm
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
            this.SelectPersonnels1ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.SelectPersonnels1ResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectPersonnels1ResultBindingSource
            // 
            this.SelectPersonnels1ResultBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.SelectPersonnels1Result);
            // 
            // reportViewer
            // 
            this.reportViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(218)))), ((int)(((byte)(254)))));
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Jamsaz_PersonnlsApplication_BusinessObjects_Data_SelectPersonnels1Result";
            reportDataSource1.Value = this.SelectPersonnels1ResultBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "Jamsaz.PersonnlsApplication.Reports.PersonnelsList1.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(875, 723);
            this.reportViewer.TabIndex = 0;
            // 
            // PersonnelsList1ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(218)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(875, 723);
            this.Controls.Add(this.reportViewer);
            this.Name = "PersonnelsList1ReportForm";
            this.ShowIcon = false;
            this.Text = "لیست پرسنل (با حق اولاد)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonnelsList1ReportForm_FormClosing);
            this.Load += new System.EventHandler(this.PersonnelsList1ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SelectPersonnels1ResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource SelectPersonnels1ResultBindingSource;
    }
}