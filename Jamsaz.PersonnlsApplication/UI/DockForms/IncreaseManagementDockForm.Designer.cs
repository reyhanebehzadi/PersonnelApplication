namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    partial class IncreaseManagementDockForm
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
            System.Windows.Forms.Label codeLabel;
            System.Windows.Forms.Label effectiveDateLabel;
            System.Windows.Forms.Label flagLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncreaseManagementDockForm));
            Janus.Windows.GridEX.GridEXLayout getIncreaseManagementDetailResultDataGridView_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.editToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.applyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.newSalaryToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flagTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.getIncreaseManagementDetailResultDataGridView = new Janus.Windows.GridEX.GridEX();
            this.increaseManagementDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.increaseManagementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getIncreaseManagementDetailResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            codeLabel = new System.Windows.Forms.Label();
            effectiveDateLabel = new System.Windows.Forms.Label();
            flagLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getIncreaseManagementDetailResultDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.increaseManagementDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.increaseManagementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getIncreaseManagementDetailResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codeLabel
            // 
            codeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(940, 20);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(25, 13);
            codeLabel.TabIndex = 0;
            codeLabel.Text = "کد :";
            // 
            // effectiveDateLabel
            // 
            effectiveDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            effectiveDateLabel.AutoSize = true;
            effectiveDateLabel.Location = new System.Drawing.Point(930, 47);
            effectiveDateLabel.Name = "effectiveDateLabel";
            effectiveDateLabel.Size = new System.Drawing.Size(35, 13);
            effectiveDateLabel.TabIndex = 2;
            effectiveDateLabel.Text = "تاریخ :";
            // 
            // flagLabel
            // 
            flagLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            flagLabel.AutoSize = true;
            flagLabel.Location = new System.Drawing.Point(917, 74);
            flagLabel.Name = "flagLabel";
            flagLabel.Size = new System.Drawing.Size(48, 13);
            flagLabel.TabIndex = 4;
            flagLabel.Text = "وضعیت :";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.bindingNavigator1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.getIncreaseManagementDetailResultDataGridView, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(998, 701);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.increaseManagementBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.CountItemFormat = "از {0}";
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.editToolStripButton,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator1,
            this.applyToolStripButton,
            this.toolStripSeparator2,
            this.printToolStripButton,
            this.newSalaryToolStripButton});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(998, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(31, 22);
            this.bindingNavigatorCountItem.Text = "از {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "اضافه";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // editToolStripButton
            // 
            this.editToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editToolStripButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.kedit;
            this.editToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editToolStripButton.Name = "editToolStripButton";
            this.editToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.editToolStripButton.Text = "ویرایش";
            this.editToolStripButton.Click += new System.EventHandler(this.editToolStripButton_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "حذف";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // applyToolStripButton
            // 
            this.applyToolStripButton.BackColor = System.Drawing.Color.Honeydew;
            this.applyToolStripButton.Enabled = false;
            this.applyToolStripButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyToolStripButton.ForeColor = System.Drawing.Color.Teal;
            this.applyToolStripButton.Image = global::Jamsaz.PersonnlsApplication.Properties.Resources.check;
            this.applyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.applyToolStripButton.Name = "applyToolStripButton";
            this.applyToolStripButton.Size = new System.Drawing.Size(67, 22);
            this.applyToolStripButton.Text = "تأیید نهایی";
            this.applyToolStripButton.Click += new System.EventHandler(this.applyToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "پرینت";
            this.printToolStripButton.Click += new System.EventHandler(this.printToolStripButton_Click);
            // 
            // newSalaryToolStripButton
            // 
            this.newSalaryToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newSalaryToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newSalaryToolStripButton.Image")));
            this.newSalaryToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newSalaryToolStripButton.Name = "newSalaryToolStripButton";
            this.newSalaryToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newSalaryToolStripButton.Text = "toolStripButton1";
            this.newSalaryToolStripButton.Visible = false;
            this.newSalaryToolStripButton.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(flagLabel);
            this.groupBox1.Controls.Add(this.flagTextBox);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(effectiveDateLabel);
            this.groupBox1.Controls.Add(codeLabel);
            this.groupBox1.Controls.Add(this.codeTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 108);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // flagTextBox
            // 
            this.flagTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flagTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flagTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.increaseManagementBindingSource, "Status", true));
            this.flagTextBox.Location = new System.Drawing.Point(794, 71);
            this.flagTextBox.Name = "flagTextBox";
            this.flagTextBox.ReadOnly = true;
            this.flagTextBox.Size = new System.Drawing.Size(117, 21);
            this.flagTextBox.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.increaseManagementBindingSource, "PersianDate", true));
            this.textBox1.Location = new System.Drawing.Point(794, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(117, 21);
            this.textBox1.TabIndex = 3;
            // 
            // codeTextBox
            // 
            this.codeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.codeTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.increaseManagementBindingSource, "Code", true));
            this.codeTextBox.Location = new System.Drawing.Point(794, 17);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.ReadOnly = true;
            this.codeTextBox.Size = new System.Drawing.Size(117, 21);
            this.codeTextBox.TabIndex = 1;
            // 
            // getIncreaseManagementDetailResultDataGridView
            // 
            this.getIncreaseManagementDetailResultDataGridView.DataSource = this.getIncreaseManagementDetailResultBindingSource;
            getIncreaseManagementDetailResultDataGridView_DesignTimeLayout.LayoutString = resources.GetString("getIncreaseManagementDetailResultDataGridView_DesignTimeLayout.LayoutString");
            this.getIncreaseManagementDetailResultDataGridView.DesignTimeLayout = getIncreaseManagementDetailResultDataGridView_DesignTimeLayout;
            this.getIncreaseManagementDetailResultDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.getIncreaseManagementDetailResultDataGridView.GroupByBoxVisible = false;
            this.getIncreaseManagementDetailResultDataGridView.Location = new System.Drawing.Point(3, 142);
            this.getIncreaseManagementDetailResultDataGridView.Name = "getIncreaseManagementDetailResultDataGridView";
            this.getIncreaseManagementDetailResultDataGridView.Size = new System.Drawing.Size(992, 556);
            this.getIncreaseManagementDetailResultDataGridView.TabIndex = 3;
            this.getIncreaseManagementDetailResultDataGridView.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // increaseManagementDetailsBindingSource
            // 
            this.increaseManagementDetailsBindingSource.DataMember = "IncreaseManagementDetails";
            this.increaseManagementDetailsBindingSource.DataSource = this.increaseManagementBindingSource;
            // 
            // increaseManagementBindingSource
            // 
            this.increaseManagementBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.IncreaseManagement);
            this.increaseManagementBindingSource.CurrentChanged += new System.EventHandler(this.increaseManagementBindingSource_CurrentChanged);
            this.increaseManagementBindingSource.PositionChanged += new System.EventHandler(this.increaseManagementBindingSource_PositionChanged);
            // 
            // getIncreaseManagementDetailResultBindingSource
            // 
            this.getIncreaseManagementDetailResultBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.GetIncreaseManagementDetailResult);
            // 
            // IncreaseManagementDockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 701);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "IncreaseManagementDockForm";
            this.ShowIcon = false;
            this.Text = "افزایش مدیریت";
            this.Load += new System.EventHandler(this.IncreaseManagementDockForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getIncreaseManagementDetailResultDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.increaseManagementDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.increaseManagementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getIncreaseManagementDetailResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource increaseManagementDetailsBindingSource;
        private System.Windows.Forms.BindingSource increaseManagementBindingSource;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox flagTextBox;
        private System.Windows.Forms.BindingSource getIncreaseManagementDetailResultBindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton editToolStripButton;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton applyToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton newSalaryToolStripButton;
        private Janus.Windows.GridEX.GridEX getIncreaseManagementDetailResultDataGridView;
    }
}