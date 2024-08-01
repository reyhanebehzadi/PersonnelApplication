namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    partial class SecoundOverTimeReportForm
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
            this.stiViewerControl1 = new Stimulsoft.Report.Viewer.StiViewerControl();
            this.SuspendLayout();
            // 
            // stiViewerControl1
            // 
            this.stiViewerControl1.AllowDrop = true;
            this.stiViewerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stiViewerControl1.Location = new System.Drawing.Point(0, 0);
            this.stiViewerControl1.Name = "stiViewerControl1";
            this.stiViewerControl1.PageViewMode = Stimulsoft.Report.Viewer.StiPageViewMode.Continuous;
            this.stiViewerControl1.Report = null;
            this.stiViewerControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stiViewerControl1.ShowZoom = true;
            this.stiViewerControl1.Size = new System.Drawing.Size(800, 450);
            this.stiViewerControl1.TabIndex = 5;
            // 
            // SecoundOverTimeReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stiViewerControl1);
            this.Name = "SecoundOverTimeReportForm";
            this.ShowIcon = false;
            this.Text = "گزارش اضافه کاری";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SecoundOverTimeReportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Stimulsoft.Report.Viewer.StiViewerControl stiViewerControl1;
    }
}