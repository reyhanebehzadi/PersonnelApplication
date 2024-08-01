namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    partial class HagheOladReportForm
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
            this.UniversityStudentCheckBox = new System.Windows.Forms.CheckBox();
            this.reportButton = new System.Windows.Forms.Button();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.stiViewerControl1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UniversityStudentCheckBox);
            this.groupBox1.Controls.Add(this.reportButton);
            this.groupBox1.Controls.Add(this.ageTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 54);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو";
            // 
            // UniversityStudentCheckBox
            // 
            this.UniversityStudentCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UniversityStudentCheckBox.AutoSize = true;
            this.UniversityStudentCheckBox.Location = new System.Drawing.Point(560, 21);
            this.UniversityStudentCheckBox.Name = "UniversityStudentCheckBox";
            this.UniversityStudentCheckBox.Size = new System.Drawing.Size(61, 17);
            this.UniversityStudentCheckBox.TabIndex = 3;
            this.UniversityStudentCheckBox.Text = "داشنجو";
            this.UniversityStudentCheckBox.UseVisualStyleBackColor = true;
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(9, 17);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(95, 23);
            this.reportButton.TabIndex = 2;
            this.reportButton.Text = "گزارش";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // ageTextBox
            // 
            this.ageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ageTextBox.Location = new System.Drawing.Point(641, 20);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 21);
            this.ageTextBox.TabIndex = 1;
            this.ageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ageTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(744, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "سن:";
            // 
            // HagheOladReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "HagheOladReportForm";
            this.ShowIcon = false;
            this.Text = "گزارش فرزندان پرسنل";
            this.Load += new System.EventHandler(this.HagheOladReportForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Stimulsoft.Report.Viewer.StiViewerControl stiViewerControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox UniversityStudentCheckBox;
    }
}