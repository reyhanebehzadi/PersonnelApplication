﻿namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    partial class PersonnelBankAccountReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PersonnelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GetPersonnelAccountNumberResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PersonnelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetPersonnelAccountNumberResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Jamsaz_PersonnlsApplication_BusinessObjects_Data_Personnel";
            reportDataSource1.Value = this.PersonnelBindingSource;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.GetPersonnelAccountNumberResultBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Jamsaz.PersonnlsApplication.Reports.PersonnelBankAccount.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(911, 511);
            this.reportViewer1.TabIndex = 0;
            // 
            // PersonnelBindingSource
            // 
            this.PersonnelBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.Personnel);
            // 
            // GetPersonnelAccountNumberResultBindingSource
            // 
            this.GetPersonnelAccountNumberResultBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.GetPersonnelAccountNumberResult);
            // 
            // PersonnelBankAccountReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 511);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PersonnelBankAccountReportForm";
            this.Text = "لیست شماره حساب پرسنل";
            this.Load += new System.EventHandler(this.PersonnelBankAccountReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonnelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetPersonnelAccountNumberResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PersonnelBindingSource;
        private System.Windows.Forms.BindingSource GetPersonnelAccountNumberResultBindingSource;
    }
}