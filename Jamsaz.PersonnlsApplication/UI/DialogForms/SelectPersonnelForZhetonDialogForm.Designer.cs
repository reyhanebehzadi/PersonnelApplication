namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class SelectPersonnelForZhetonDialogForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SelectedButton = new System.Windows.Forms.Button();
            this.departmentComboboxChilds = new System.Windows.Forms.ComboBox();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.childrenOfDepartmentbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.childrenOfDepartmentbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.departmentComboboxChilds);
            this.groupBox1.Controls.Add(this.departmentComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 84);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "انتخاب پرسنل بر اساس بخش";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(315, 94);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "لغو";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // SelectedButton
            // 
            this.SelectedButton.Location = new System.Drawing.Point(396, 94);
            this.SelectedButton.Name = "SelectedButton";
            this.SelectedButton.Size = new System.Drawing.Size(75, 23);
            this.SelectedButton.TabIndex = 4;
            this.SelectedButton.Text = "انتخاب";
            this.SelectedButton.UseVisualStyleBackColor = true;
            this.SelectedButton.Click += new System.EventHandler(this.SelectedButton_Click);
            // 
            // departmentComboboxChilds
            // 
            this.departmentComboboxChilds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentComboboxChilds.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.departmentComboboxChilds.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.departmentComboboxChilds.DataSource = this.childrenOfDepartmentbindingSource;
            this.departmentComboboxChilds.DisplayMember = "Name";
            this.departmentComboboxChilds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentComboboxChilds.FormattingEnabled = true;
            this.departmentComboboxChilds.Location = new System.Drawing.Point(119, 30);
            this.departmentComboboxChilds.Name = "departmentComboboxChilds";
            this.departmentComboboxChilds.Size = new System.Drawing.Size(139, 21);
            this.departmentComboboxChilds.TabIndex = 59;
            this.departmentComboboxChilds.ValueMember = "Id";
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.departmentComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.departmentComboBox.DataSource = this.departmentBindingSource;
            this.departmentComboBox.DisplayMember = "Name";
            this.departmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(264, 30);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(140, 21);
            this.departmentComboBox.TabIndex = 58;
            this.departmentComboBox.ValueMember = "Id";
            this.departmentComboBox.SelectedIndexChanged += new System.EventHandler(this.departmentComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(410, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 14);
            this.label2.TabIndex = 57;
            this.label2.Text = "واحد";
            // 
            // childrenOfDepartmentbindingSource
            // 
            this.childrenOfDepartmentbindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.Department);
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.Department);
            // 
            // SelectPersonnelForZhetonDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 127);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.SelectedButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "SelectPersonnelForZhetonDialogForm";
            this.ShowIcon = false;
            this.Text = "";
            this.Load += new System.EventHandler(this.SelectPersonnelForZhetonDialogForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.childrenOfDepartmentbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button SelectedButton;
        private System.Windows.Forms.ComboBox departmentComboboxChilds;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource childrenOfDepartmentbindingSource;
        private System.Windows.Forms.BindingSource departmentBindingSource;
    }
}