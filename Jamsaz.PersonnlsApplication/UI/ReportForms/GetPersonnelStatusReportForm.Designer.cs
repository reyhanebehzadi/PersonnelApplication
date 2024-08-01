namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    partial class GetPersonnelStatusReportForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.stiViewerControl1 = new Stimulsoft.Report.Viewer.StiViewerControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reportButton = new System.Windows.Forms.Button();
            this.retiredCheckBox = new System.Windows.Forms.CheckBox();
            this.specialCheckBox = new System.Windows.Forms.CheckBox();
            this.employCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.stiViewerControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // stiViewerControl1
            // 
            this.stiViewerControl1.AllowDrop = true;
            this.stiViewerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stiViewerControl1.Location = new System.Drawing.Point(3, 63);
            this.stiViewerControl1.Name = "stiViewerControl1";
            this.stiViewerControl1.PageViewMode = Stimulsoft.Report.Viewer.StiPageViewMode.Continuous;
            this.stiViewerControl1.Report = null;
            this.stiViewerControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stiViewerControl1.ShowZoom = true;
            this.stiViewerControl1.Size = new System.Drawing.Size(794, 384);
            this.stiViewerControl1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reportButton);
            this.groupBox1.Controls.Add(this.retiredCheckBox);
            this.groupBox1.Controls.Add(this.specialCheckBox);
            this.groupBox1.Controls.Add(this.employCheckBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(9, 14);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(75, 23);
            this.reportButton.TabIndex = 3;
            this.reportButton.Text = "گزارش";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // retiredCheckBox
            // 
            this.retiredCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.retiredCheckBox.AutoSize = true;
            this.retiredCheckBox.Location = new System.Drawing.Point(519, 20);
            this.retiredCheckBox.Name = "retiredCheckBox";
            this.retiredCheckBox.Size = new System.Drawing.Size(73, 17);
            this.retiredCheckBox.TabIndex = 2;
            this.retiredCheckBox.Text = "بازنشسته";
            this.retiredCheckBox.UseVisualStyleBackColor = true;
            // 
            // specialCheckBox
            // 
            this.specialCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.specialCheckBox.AutoSize = true;
            this.specialCheckBox.Location = new System.Drawing.Point(618, 20);
            this.specialCheckBox.Name = "specialCheckBox";
            this.specialCheckBox.Size = new System.Drawing.Size(49, 17);
            this.specialCheckBox.TabIndex = 1;
            this.specialCheckBox.Text = "خاص";
            this.specialCheckBox.UseVisualStyleBackColor = true;
            // 
            // employCheckBox
            // 
            this.employCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.employCheckBox.AutoSize = true;
            this.employCheckBox.Location = new System.Drawing.Point(697, 20);
            this.employCheckBox.Name = "employCheckBox";
            this.employCheckBox.Size = new System.Drawing.Size(55, 17);
            this.employCheckBox.TabIndex = 0;
            this.employCheckBox.Text = "شاغل";
            this.employCheckBox.UseVisualStyleBackColor = true;
            // 
            // GetPersonnelStatusReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GetPersonnelStatusReportForm";
            this.ShowIcon = false;
            this.Text = "لیست پرسنل به تفکیک بخش";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox employCheckBox;
        private System.Windows.Forms.CheckBox specialCheckBox;
        private System.Windows.Forms.CheckBox retiredCheckBox;
        private System.Windows.Forms.Button reportButton;
        private Stimulsoft.Report.Viewer.StiViewerControl stiViewerControl1;
    }
}