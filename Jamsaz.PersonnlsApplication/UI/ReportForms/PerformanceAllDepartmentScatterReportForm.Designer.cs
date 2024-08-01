namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    partial class PerformanceAllDepartmentScatterReportForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerformanceAllDepartmentScatterReportForm));
            this.PerformanceAllDepartmentResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.performanceByDepartmentResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chartprint = new System.Windows.Forms.Button();
            this.listprintBtn = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.RowNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descriptor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PerformanceAllDepartmentResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceByDepartmentResultBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PerformanceAllDepartmentResultBindingSource
            // 
            this.PerformanceAllDepartmentResultBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.PerformanceAllDepartmentResult);
            // 
            // performanceByDepartmentResultBindingSource
            // 
            this.performanceByDepartmentResultBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.PerformanceByDepartmentResult);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.chart1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.68421F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 621);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(3, 210);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(994, 408);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowNum,
            this.Descriptor,
            this.departmentNameDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn,
            this.averageDataGridViewTextBoxColumn,
            this.personelIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.performanceByDepartmentResultBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(3, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(994, 141);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chartprint);
            this.groupBox1.Controls.Add(this.listprintBtn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(994, 54);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // chartprint
            // 
            this.chartprint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chartprint.Location = new System.Drawing.Point(829, 20);
            this.chartprint.Name = "chartprint";
            this.chartprint.Size = new System.Drawing.Size(75, 23);
            this.chartprint.TabIndex = 1;
            this.chartprint.Tag = "";
            this.chartprint.Text = "چاپ نمودار";
            this.chartprint.UseVisualStyleBackColor = true;
            this.chartprint.Click += new System.EventHandler(this.chartprint_Click);
            // 
            // listprintBtn
            // 
            this.listprintBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listprintBtn.Location = new System.Drawing.Point(910, 20);
            this.listprintBtn.Name = "listprintBtn";
            this.listprintBtn.Size = new System.Drawing.Size(75, 23);
            this.listprintBtn.TabIndex = 0;
            this.listprintBtn.Tag = "";
            this.listprintBtn.Text = "چاپ لیست";
            this.listprintBtn.UseVisualStyleBackColor = true;
            this.listprintBtn.Click += new System.EventHandler(this.listprintBtn_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // RowNum
            // 
            this.RowNum.DataPropertyName = "RowNum";
            this.RowNum.HeaderText = "ردیف";
            this.RowNum.Name = "RowNum";
            this.RowNum.ReadOnly = true;
            // 
            // Descriptor
            // 
            this.Descriptor.DataPropertyName = "Descriptor";
            this.Descriptor.HeaderText = "نام و نام خانوادگی";
            this.Descriptor.Name = "Descriptor";
            this.Descriptor.ReadOnly = true;
            this.Descriptor.Width = 200;
            // 
            // departmentNameDataGridViewTextBoxColumn
            // 
            this.departmentNameDataGridViewTextBoxColumn.DataPropertyName = "DepartmentChildName";
            this.departmentNameDataGridViewTextBoxColumn.HeaderText = "نام واحد";
            this.departmentNameDataGridViewTextBoxColumn.Name = "departmentNameDataGridViewTextBoxColumn";
            this.departmentNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.departmentNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "نمره";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            this.scoreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // averageDataGridViewTextBoxColumn
            // 
            this.averageDataGridViewTextBoxColumn.DataPropertyName = "Average";
            this.averageDataGridViewTextBoxColumn.HeaderText = "معدل";
            this.averageDataGridViewTextBoxColumn.Name = "averageDataGridViewTextBoxColumn";
            this.averageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personelIDDataGridViewTextBoxColumn
            // 
            this.personelIDDataGridViewTextBoxColumn.DataPropertyName = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.HeaderText = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.Name = "personelIDDataGridViewTextBoxColumn";
            this.personelIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.personelIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // PerformanceAllDepartmentScatterReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 621);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PerformanceAllDepartmentScatterReportForm";
            this.ShowIcon = false;
            this.Text = "گزارش عملکرد پرسنل بر اساس واحد";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PerformanceReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PerformanceAllDepartmentResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceByDepartmentResultBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource PerformanceAllDepartmentResultBindingSource;
        private System.Windows.Forms.BindingSource performanceByDepartmentResultBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button chartprint;
        private System.Windows.Forms.Button listprintBtn;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnelNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnelNumberAsIntDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn childDepartmentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiscalYearIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descriptor;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn averageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIDDataGridViewTextBoxColumn;
    }
}