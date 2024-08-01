namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    partial class AccidentsReportForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fiscalyearComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fiscalYearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.AccidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fiscalYearBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccidentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.reportViewer, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(817, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.fiscalyearComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(811, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "فیلتر";
            // 
            // fiscalyearComboBox
            // 
            this.fiscalyearComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fiscalyearComboBox.DataSource = this.fiscalYearBindingSource;
            this.fiscalyearComboBox.DisplayMember = "Title";
            this.fiscalyearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fiscalyearComboBox.FormattingEnabled = true;
            this.fiscalyearComboBox.Location = new System.Drawing.Point(605, 30);
            this.fiscalyearComboBox.Name = "fiscalyearComboBox";
            this.fiscalyearComboBox.Size = new System.Drawing.Size(121, 21);
            this.fiscalyearComboBox.TabIndex = 1;
            this.fiscalyearComboBox.ValueMember = "ID";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(732, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "سال مالی:";
            // 
            // fiscalYearBindingSource
            // 
            this.fiscalYearBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.FiscalYear);
            // 
            // reportViewer
            // 
            this.reportViewer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AccidentBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "Jamsaz.PersonnlsApplication.Reports.AccidentsReport.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(3, 83);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(811, 364);
            this.reportViewer.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "گزارش";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AccidentBindingSource
            // 
            this.AccidentBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.Accident);
            // 
            // AccidentsReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AccidentsReportForm";
            this.ShowIcon = false;
            this.Text = "گزارش وقوع حادثه";
            this.Load += new System.EventHandler(this.AccidentsReportForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fiscalYearBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccidentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox fiscalyearComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource fiscalYearBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource AccidentBindingSource;
    }
}