namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    partial class GetPercentReportForm
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
            Janus.Windows.GridEX.GridEXLayout searchResultDataGridView_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetPercentReportForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.searchResultDataGridView = new Janus.Windows.GridEX.GridEX();
            this.getPercentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.printButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.percentComboBox = new System.Windows.Forms.ComboBox();
            this.reportButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPercentBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.searchResultDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(757, 660);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // searchResultDataGridView
            // 
            this.searchResultDataGridView.BackColor = System.Drawing.Color.SlateGray;
            this.searchResultDataGridView.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.searchResultDataGridView.DataSource = this.getPercentBindingSource;
            searchResultDataGridView_DesignTimeLayout.LayoutString = resources.GetString("searchResultDataGridView_DesignTimeLayout.LayoutString");
            this.searchResultDataGridView.DesignTimeLayout = searchResultDataGridView_DesignTimeLayout;
            this.searchResultDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchResultDataGridView.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.searchResultDataGridView.GroupByBoxVisible = false;
            this.searchResultDataGridView.Location = new System.Drawing.Point(3, 83);
            this.searchResultDataGridView.Name = "searchResultDataGridView";
            this.searchResultDataGridView.RecordNavigator = true;
            this.searchResultDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchResultDataGridView.RowFormatStyle.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.searchResultDataGridView.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
            this.searchResultDataGridView.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.searchResultDataGridView.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelectionSameTable;
            this.searchResultDataGridView.Size = new System.Drawing.Size(751, 574);
            this.searchResultDataGridView.TabIndex = 9;
            this.searchResultDataGridView.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.searchResultDataGridView.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.searchResultDataGridView.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // getPercentBindingSource
            // 
            this.getPercentBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.GetPercentResult);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.printButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.percentComboBox);
            this.groupBox1.Controls.Add(this.reportButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(9, 45);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 23);
            this.printButton.TabIndex = 3;
            this.printButton.Text = "چاپ";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(660, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "درصد نوبت کاری:";
            // 
            // percentComboBox
            // 
            this.percentComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.percentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.percentComboBox.FormattingEnabled = true;
            this.percentComboBox.Items.AddRange(new object[] {
            "0",
            "10",
            "15"});
            this.percentComboBox.Location = new System.Drawing.Point(533, 20);
            this.percentComboBox.Name = "percentComboBox";
            this.percentComboBox.Size = new System.Drawing.Size(121, 21);
            this.percentComboBox.TabIndex = 1;
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(9, 20);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(75, 23);
            this.reportButton.TabIndex = 0;
            this.reportButton.Text = "گزارش";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // GetPercentReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 660);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GetPercentReportForm";
            this.ShowIcon = false;
            this.Text = "گزارش درصد نوبت کاری";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchResultDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getPercentBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox percentComboBox;
        private System.Windows.Forms.Button reportButton;
        private Janus.Windows.GridEX.GridEX searchResultDataGridView;
        private System.Windows.Forms.BindingSource getPercentBindingSource;
        private System.Windows.Forms.Button printButton;
    }
}