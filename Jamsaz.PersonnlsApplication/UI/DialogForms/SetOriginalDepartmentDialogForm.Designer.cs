namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class SetOriginalDepartmentDialogForm
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage = new System.Windows.Forms.TabPage();
            this.selectOriginalDepartmentButton = new System.Windows.Forms.Button();
            this.originalDepartmentTextBox = new System.Windows.Forms.TextBox();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.originalDepartmentLabel = new System.Windows.Forms.Label();
            this.currentDepartmentLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.voidButton = new System.Windows.Forms.Button();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.voidButton);
            this.groupBox.Controls.Add(this.saveButton);
            this.groupBox.Controls.Add(this.tabControl);
            this.groupBox.Location = new System.Drawing.Point(4, 2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(517, 326);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "برقراری ارتباط با نسخه اصلی";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage);
            this.tabControl.Location = new System.Drawing.Point(6, 20);
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeftLayout = true;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(505, 267);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.selectOriginalDepartmentButton);
            this.tabPage.Controls.Add(this.originalDepartmentTextBox);
            this.tabPage.Controls.Add(this.departmentTextBox);
            this.tabPage.Controls.Add(this.originalDepartmentLabel);
            this.tabPage.Controls.Add(this.currentDepartmentLabel);
            this.tabPage.Location = new System.Drawing.Point(4, 22);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage.Size = new System.Drawing.Size(497, 241);
            this.tabPage.TabIndex = 0;
            this.tabPage.Text = "ارتباط واحد های سازمانی نسخه جاری با نسخه اصلی";
            this.tabPage.UseVisualStyleBackColor = true;
            // 
            // selectOriginalDepartmentButton
            // 
            this.selectOriginalDepartmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectOriginalDepartmentButton.Location = new System.Drawing.Point(42, 75);
            this.selectOriginalDepartmentButton.Name = "selectOriginalDepartmentButton";
            this.selectOriginalDepartmentButton.Size = new System.Drawing.Size(30, 23);
            this.selectOriginalDepartmentButton.TabIndex = 4;
            this.selectOriginalDepartmentButton.Text = "...";
            this.selectOriginalDepartmentButton.UseVisualStyleBackColor = true;
            this.selectOriginalDepartmentButton.Click += new System.EventHandler(this.selectOriginalDepartmentButton_Click);
            // 
            // originalDepartmentTextBox
            // 
            this.originalDepartmentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.originalDepartmentTextBox.BackColor = System.Drawing.Color.White;
            this.originalDepartmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource, "OriginalDepartmentName", true));
            this.originalDepartmentTextBox.Location = new System.Drawing.Point(76, 76);
            this.originalDepartmentTextBox.Name = "originalDepartmentTextBox";
            this.originalDepartmentTextBox.ReadOnly = true;
            this.originalDepartmentTextBox.Size = new System.Drawing.Size(259, 21);
            this.originalDepartmentTextBox.TabIndex = 3;
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentTextBox.BackColor = System.Drawing.Color.White;
            this.departmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource, "Name", true));
            this.departmentTextBox.Location = new System.Drawing.Point(76, 49);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.ReadOnly = true;
            this.departmentTextBox.Size = new System.Drawing.Size(259, 21);
            this.departmentTextBox.TabIndex = 2;
            // 
            // originalDepartmentLabel
            // 
            this.originalDepartmentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.originalDepartmentLabel.AutoSize = true;
            this.originalDepartmentLabel.Location = new System.Drawing.Point(424, 79);
            this.originalDepartmentLabel.Name = "originalDepartmentLabel";
            this.originalDepartmentLabel.Size = new System.Drawing.Size(65, 13);
            this.originalDepartmentLabel.TabIndex = 1;
            this.originalDepartmentLabel.Text = "نسخه اصلی";
            // 
            // currentDepartmentLabel
            // 
            this.currentDepartmentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentDepartmentLabel.AutoSize = true;
            this.currentDepartmentLabel.Location = new System.Drawing.Point(351, 52);
            this.currentDepartmentLabel.Name = "currentDepartmentLabel";
            this.currentDepartmentLabel.Size = new System.Drawing.Size(138, 13);
            this.currentDepartmentLabel.TabIndex = 0;
            this.currentDepartmentLabel.Text = "واحد سازمانی (نسخه جاری)";
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.Location = new System.Drawing.Point(10, 293);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "ذخیره";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // voidButton
            // 
            this.voidButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.voidButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.voidButton.Location = new System.Drawing.Point(91, 293);
            this.voidButton.Name = "voidButton";
            this.voidButton.Size = new System.Drawing.Size(75, 23);
            this.voidButton.TabIndex = 2;
            this.voidButton.Text = "لغو";
            this.voidButton.UseVisualStyleBackColor = true;
            this.voidButton.Click += new System.EventHandler(this.voidButton_Click);
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.Department);
            // 
            // SetOriginalDepartmentDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.voidButton;
            this.ClientSize = new System.Drawing.Size(523, 330);
            this.Controls.Add(this.groupBox);
            this.MaximizeBox = false;
            this.Name = "SetOriginalDepartmentDialogForm";
            this.ShowIcon = false;
            this.Text = "ارتباط واحد های سازمانی نسخه جاری با نسخه اصلی";
            this.Load += new System.EventHandler(this.SetOriginalDepartmentDialogForm_Load);
            this.groupBox.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.tabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.Label originalDepartmentLabel;
        private System.Windows.Forms.Label currentDepartmentLabel;
        private System.Windows.Forms.Button selectOriginalDepartmentButton;
        private System.Windows.Forms.TextBox originalDepartmentTextBox;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.Button voidButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.BindingSource departmentBindingSource;
    }
}