
namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class CustomConnectionStringDialogForm
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
            this.saveButton = new System.Windows.Forms.Button();
            this.connectionStringTextBox = new System.Windows.Forms.TextBox();
            this.connectionStringLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.selectConnectionStringGroupBox = new System.Windows.Forms.GroupBox();
            this.dataBaseNameLabel = new System.Windows.Forms.Label();
            this.serverNameLabel = new System.Windows.Forms.Label();
            this.catalogTextBox = new System.Windows.Forms.TextBox();
            this.serverNameTextBox = new System.Windows.Forms.TextBox();
            this.defaultConnectionStringRadioButton = new System.Windows.Forms.RadioButton();
            this.setConnectionStringFactoryRadioButton = new System.Windows.Forms.RadioButton();
            this.setConnectionStringTehranRadioButton = new System.Windows.Forms.RadioButton();
            this.testConnectionButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.manualCheckBox = new System.Windows.Forms.CheckBox();
            this.setAmeriRadioButton = new System.Windows.Forms.RadioButton();
            this.selectConnectionStringGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(561, 182);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(87, 25);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "ذخیره";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // connectionStringTextBox
            // 
            this.connectionStringTextBox.BackColor = System.Drawing.Color.AntiqueWhite;
            this.connectionStringTextBox.Location = new System.Drawing.Point(93, 125);
            this.connectionStringTextBox.Name = "connectionStringTextBox";
            this.connectionStringTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.connectionStringTextBox.Size = new System.Drawing.Size(495, 22);
            this.connectionStringTextBox.TabIndex = 1;
            // 
            // connectionStringLabel
            // 
            this.connectionStringLabel.AutoSize = true;
            this.connectionStringLabel.Location = new System.Drawing.Point(594, 128);
            this.connectionStringLabel.Name = "connectionStringLabel";
            this.connectionStringLabel.Size = new System.Drawing.Size(37, 14);
            this.connectionStringLabel.TabIndex = 4;
            this.connectionStringLabel.Text = "مقدار ";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(365, 182);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(87, 25);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "برگشت";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // selectConnectionStringGroupBox
            // 
            this.selectConnectionStringGroupBox.Controls.Add(this.setAmeriRadioButton);
            this.selectConnectionStringGroupBox.Controls.Add(this.manualCheckBox);
            this.selectConnectionStringGroupBox.Controls.Add(this.dataBaseNameLabel);
            this.selectConnectionStringGroupBox.Controls.Add(this.serverNameLabel);
            this.selectConnectionStringGroupBox.Controls.Add(this.catalogTextBox);
            this.selectConnectionStringGroupBox.Controls.Add(this.serverNameTextBox);
            this.selectConnectionStringGroupBox.Controls.Add(this.defaultConnectionStringRadioButton);
            this.selectConnectionStringGroupBox.Controls.Add(this.setConnectionStringFactoryRadioButton);
            this.selectConnectionStringGroupBox.Controls.Add(this.setConnectionStringTehranRadioButton);
            this.selectConnectionStringGroupBox.Controls.Add(this.connectionStringTextBox);
            this.selectConnectionStringGroupBox.Controls.Add(this.connectionStringLabel);
            this.selectConnectionStringGroupBox.Location = new System.Drawing.Point(11, 12);
            this.selectConnectionStringGroupBox.Name = "selectConnectionStringGroupBox";
            this.selectConnectionStringGroupBox.Size = new System.Drawing.Size(637, 164);
            this.selectConnectionStringGroupBox.TabIndex = 9;
            this.selectConnectionStringGroupBox.TabStop = false;
            this.selectConnectionStringGroupBox.Text = "انتخاب اتصال به بانک";
            // 
            // dataBaseNameLabel
            // 
            this.dataBaseNameLabel.AutoSize = true;
            this.dataBaseNameLabel.Location = new System.Drawing.Point(529, 91);
            this.dataBaseNameLabel.Name = "dataBaseNameLabel";
            this.dataBaseNameLabel.Size = new System.Drawing.Size(97, 14);
            this.dataBaseNameLabel.TabIndex = 15;
            this.dataBaseNameLabel.Text = "نام بانک اطلاعاتی";
            // 
            // serverNameLabel
            // 
            this.serverNameLabel.AutoSize = true;
            this.serverNameLabel.Location = new System.Drawing.Point(574, 63);
            this.serverNameLabel.Name = "serverNameLabel";
            this.serverNameLabel.Size = new System.Drawing.Size(51, 14);
            this.serverNameLabel.TabIndex = 14;
            this.serverNameLabel.Text = "نام سرور";
            // 
            // catalogTextBox
            // 
            this.catalogTextBox.Location = new System.Drawing.Point(354, 88);
            this.catalogTextBox.Name = "catalogTextBox";
            this.catalogTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.catalogTextBox.Size = new System.Drawing.Size(171, 22);
            this.catalogTextBox.TabIndex = 13;
            this.catalogTextBox.TextChanged += new System.EventHandler(this.serverNameTextBox_TextChanged);
            // 
            // serverNameTextBox
            // 
            this.serverNameTextBox.Location = new System.Drawing.Point(354, 60);
            this.serverNameTextBox.Name = "serverNameTextBox";
            this.serverNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.serverNameTextBox.Size = new System.Drawing.Size(171, 22);
            this.serverNameTextBox.TabIndex = 11;
            this.serverNameTextBox.TextChanged += new System.EventHandler(this.serverNameTextBox_TextChanged);
            // 
            // defaultConnectionStringRadioButton
            // 
            this.defaultConnectionStringRadioButton.AutoSize = true;
            this.defaultConnectionStringRadioButton.Location = new System.Drawing.Point(546, 21);
            this.defaultConnectionStringRadioButton.Name = "defaultConnectionStringRadioButton";
            this.defaultConnectionStringRadioButton.Size = new System.Drawing.Size(76, 18);
            this.defaultConnectionStringRadioButton.TabIndex = 10;
            this.defaultConnectionStringRadioButton.TabStop = true;
            this.defaultConnectionStringRadioButton.Text = "پیش فرض";
            this.defaultConnectionStringRadioButton.UseVisualStyleBackColor = true;
            this.defaultConnectionStringRadioButton.CheckedChanged += new System.EventHandler(this.defaultConnectionStringRadioButton_CheckedChanged);
            // 
            // setConnectionStringFactoryRadioButton
            // 
            this.setConnectionStringFactoryRadioButton.AutoSize = true;
            this.setConnectionStringFactoryRadioButton.Location = new System.Drawing.Point(398, 21);
            this.setConnectionStringFactoryRadioButton.Name = "setConnectionStringFactoryRadioButton";
            this.setConnectionStringFactoryRadioButton.Size = new System.Drawing.Size(61, 18);
            this.setConnectionStringFactoryRadioButton.TabIndex = 1;
            this.setConnectionStringFactoryRadioButton.TabStop = true;
            this.setConnectionStringFactoryRadioButton.Text = "کارخانه";
            this.setConnectionStringFactoryRadioButton.UseVisualStyleBackColor = true;
            this.setConnectionStringFactoryRadioButton.CheckedChanged += new System.EventHandler(this.defaultConnectionStringRadioButton_CheckedChanged);
            // 
            // setConnectionStringTehranRadioButton
            // 
            this.setConnectionStringTehranRadioButton.AutoSize = true;
            this.setConnectionStringTehranRadioButton.Location = new System.Drawing.Point(465, 21);
            this.setConnectionStringTehranRadioButton.Name = "setConnectionStringTehranRadioButton";
            this.setConnectionStringTehranRadioButton.Size = new System.Drawing.Size(75, 18);
            this.setConnectionStringTehranRadioButton.TabIndex = 0;
            this.setConnectionStringTehranRadioButton.TabStop = true;
            this.setConnectionStringTehranRadioButton.Text = "دفتر تهران";
            this.setConnectionStringTehranRadioButton.UseVisualStyleBackColor = true;
            this.setConnectionStringTehranRadioButton.CheckedChanged += new System.EventHandler(this.defaultConnectionStringRadioButton_CheckedChanged);
            // 
            // testConnectionButton
            // 
            this.testConnectionButton.Location = new System.Drawing.Point(458, 183);
            this.testConnectionButton.Name = "testConnectionButton";
            this.testConnectionButton.Size = new System.Drawing.Size(97, 23);
            this.testConnectionButton.TabIndex = 10;
            this.testConnectionButton.Text = "آزمایش اتصال";
            this.testConnectionButton.UseVisualStyleBackColor = true;
            this.testConnectionButton.Click += new System.EventHandler(this.testConnectionButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // manualCheckBox
            // 
            this.manualCheckBox.AutoSize = true;
            this.manualCheckBox.Location = new System.Drawing.Point(27, 127);
            this.manualCheckBox.Name = "manualCheckBox";
            this.manualCheckBox.Size = new System.Drawing.Size(60, 18);
            this.manualCheckBox.TabIndex = 16;
            this.manualCheckBox.Text = "دستی";
            this.manualCheckBox.UseVisualStyleBackColor = true;
            // 
            // setAmeriRadioButton
            // 
            this.setAmeriRadioButton.AutoSize = true;
            this.setAmeriRadioButton.Location = new System.Drawing.Point(331, 21);
            this.setAmeriRadioButton.Name = "setAmeriRadioButton";
            this.setAmeriRadioButton.Size = new System.Drawing.Size(57, 18);
            this.setAmeriRadioButton.TabIndex = 17;
            this.setAmeriRadioButton.TabStop = true;
            this.setAmeriRadioButton.Text = "عامری";
            this.setAmeriRadioButton.UseVisualStyleBackColor = true;
            this.setAmeriRadioButton.CheckedChanged += new System.EventHandler(this.defaultConnectionStringRadioButton_CheckedChanged);
            // 
            // CustomConnectionStringDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(661, 216);
            this.Controls.Add(this.testConnectionButton);
            this.Controls.Add(this.selectConnectionStringGroupBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveButton);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomConnectionStringDialogForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت اتصال به بانک اطلاعاتی";
            this.Load += new System.EventHandler(this.FormCustomConnectionString_Load);
            this.selectConnectionStringGroupBox.ResumeLayout(false);
            this.selectConnectionStringGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox connectionStringTextBox;
        private System.Windows.Forms.Label connectionStringLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.GroupBox selectConnectionStringGroupBox;
        private System.Windows.Forms.RadioButton setConnectionStringTehranRadioButton;
        private System.Windows.Forms.RadioButton defaultConnectionStringRadioButton;
        private System.Windows.Forms.RadioButton setConnectionStringFactoryRadioButton;
        private System.Windows.Forms.Button testConnectionButton;
        private System.Windows.Forms.TextBox catalogTextBox;
        private System.Windows.Forms.TextBox serverNameTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label dataBaseNameLabel;
        private System.Windows.Forms.Label serverNameLabel;
        private System.Windows.Forms.CheckBox manualCheckBox;
        private System.Windows.Forms.RadioButton setAmeriRadioButton;
    }
}