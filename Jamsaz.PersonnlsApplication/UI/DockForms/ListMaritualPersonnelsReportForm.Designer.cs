namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    partial class ListMaritualPersonnelsReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ResultSearchAdvencedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.allRadioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.ResultSearchAdvencedBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultSearchAdvencedBindingSource
            // 
            this.ResultSearchAdvencedBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.ResultSearchAdvenced);
            // 
            // mainReportViewer
            // 
            this.mainReportViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.mainReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "Jamsaz_PersonnlsApplication_BusinessObjects_Data_ResultSearchAdvenced";
            reportDataSource2.Value = this.ResultSearchAdvencedBindingSource;
            this.mainReportViewer.LocalReport.DataSources.Add(reportDataSource2);
            this.mainReportViewer.LocalReport.ReportEmbeddedResource = "Jamsaz.PersonnlsApplication.Reports.ListMaritualPersonnelsReport.rdlc";
            this.mainReportViewer.Location = new System.Drawing.Point(3, 53);
            this.mainReportViewer.Name = "mainReportViewer";
            this.mainReportViewer.ServerReport.BearerToken = null;
            this.mainReportViewer.Size = new System.Drawing.Size(777, 508);
            this.mainReportViewer.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.mainReportViewer, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(783, 564);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.allRadioButton1);
            this.groupBox1.Controls.Add(this.femaleRadioButton);
            this.groupBox1.Controls.Add(this.maleRadioButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 44);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جنسیت";
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(619, 20);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(36, 17);
            this.femaleRadioButton.TabIndex = 0;
            this.femaleRadioButton.Text = "زن";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            this.femaleRadioButton.CheckedChanged += new System.EventHandler(this.femaleRadioButton_CheckedChanged);
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Checked = true;
            this.maleRadioButton.Location = new System.Drawing.Point(687, 20);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(41, 17);
            this.maleRadioButton.TabIndex = 0;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "مرد";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            this.maleRadioButton.CheckedChanged += new System.EventHandler(this.maleRadioButton_CheckedChanged);
            // 
            // allRadioButton1
            // 
            this.allRadioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.allRadioButton1.AutoSize = true;
            this.allRadioButton1.Location = new System.Drawing.Point(551, 20);
            this.allRadioButton1.Name = "allRadioButton1";
            this.allRadioButton1.Size = new System.Drawing.Size(46, 17);
            this.allRadioButton1.TabIndex = 1;
            this.allRadioButton1.Text = "همه";
            this.allRadioButton1.UseVisualStyleBackColor = true;
            this.allRadioButton1.CheckedChanged += new System.EventHandler(this.allRadioButton1_CheckedChanged);
            // 
            // ListMaritualPersonnelsReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 564);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ListMaritualPersonnelsReportForm";
            this.ShowIcon = false;
            this.Text = "لیست متاهلین";
            this.Load += new System.EventHandler(this.ListMaritualPersonnelsReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultSearchAdvencedBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer mainReportViewer;
        private System.Windows.Forms.BindingSource ResultSearchAdvencedBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.RadioButton allRadioButton1;
    }
}