
namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    partial class PersonnelFingerPrintsDialogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonnelFingerPrintsDialogForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.exitButton = new System.Windows.Forms.Button();
            this.fingerPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupTemplate = new System.Windows.Forms.GroupBox();
            this.qualityLabel1 = new System.Windows.Forms.Label();
            this.scanTemplateButton = new System.Windows.Forms.Button();
            this.imageListControls = new System.Windows.Forms.ImageList(this.components);
            this.percentLabel1 = new System.Windows.Forms.Label();
            this.qualityCurrentFingerTextBox = new System.Windows.Forms.TextBox();
            this.currentFingerFromScannerPictureBox = new System.Windows.Forms.PictureBox();
            this.titleStatusConfirmLabel = new System.Windows.Forms.Label();
            this.titleStatusTemplateLabel = new System.Windows.Forms.Label();
            this.statusTemplateLabel = new System.Windows.Forms.Label();
            this.statusConfirmLabel = new System.Windows.Forms.Label();
            this.matchFingerButton = new System.Windows.Forms.Button();
            this.percentLabel = new System.Windows.Forms.Label();
            this.qualityconfirmFingerTextBox1 = new System.Windows.Forms.TextBox();
            this.qualityLabel2 = new System.Windows.Forms.Label();
            this.confirmFingerPictureBox = new System.Windows.Forms.PictureBox();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.personnelNumberLabel = new System.Windows.Forms.Label();
            this.titlePersonnelNumberLabel = new System.Windows.Forms.Label();
            this.titleFullNameLabel = new System.Windows.Forms.Label();
            this.personnelFingerPrintsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insertFingerTemplateButton = new System.Windows.Forms.Button();
            this.editCurrentFingerButton = new System.Windows.Forms.Button();
            this.deleteCurremtFingerButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.confirmFromDataTabelButton = new System.Windows.Forms.Button();
            this.clearControlButton = new System.Windows.Forms.Button();
            this.personnelFingerPrintsDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fingerIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.templateDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fingerPrintImageIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fingerPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.GroupTemplate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentFingerFromScannerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmFingerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelFingerPrintsBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personnelFingerPrintsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(612, 564);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(87, 25);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "برگشت";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // fingerPictureBox
            // 
            this.fingerPictureBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.fingerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fingerPictureBox.Location = new System.Drawing.Point(14, 21);
            this.fingerPictureBox.Name = "fingerPictureBox";
            this.fingerPictureBox.Size = new System.Drawing.Size(126, 150);
            this.fingerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fingerPictureBox.TabIndex = 1;
            this.fingerPictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.groupBox1.Controls.Add(this.fingerPictureBox);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(549, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 188);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "عکس اثر انگشت جاری";
            // 
            // GroupTemplate
            // 
            this.GroupTemplate.BackColor = System.Drawing.Color.Transparent;
            this.GroupTemplate.Controls.Add(this.qualityLabel1);
            this.GroupTemplate.Controls.Add(this.scanTemplateButton);
            this.GroupTemplate.Controls.Add(this.percentLabel1);
            this.GroupTemplate.Controls.Add(this.qualityCurrentFingerTextBox);
            this.GroupTemplate.Controls.Add(this.currentFingerFromScannerPictureBox);
            this.GroupTemplate.ForeColor = System.Drawing.Color.Black;
            this.GroupTemplate.Location = new System.Drawing.Point(20, 245);
            this.GroupTemplate.Name = "GroupTemplate";
            this.GroupTemplate.Size = new System.Drawing.Size(185, 242);
            this.GroupTemplate.TabIndex = 6;
            this.GroupTemplate.TabStop = false;
            this.GroupTemplate.Text = " دریافت اثر انگشت از اسکنر ";
            // 
            // qualityLabel1
            // 
            this.qualityLabel1.ForeColor = System.Drawing.Color.Black;
            this.qualityLabel1.Location = new System.Drawing.Point(34, 180);
            this.qualityLabel1.Name = "qualityLabel1";
            this.qualityLabel1.Size = new System.Drawing.Size(52, 21);
            this.qualityLabel1.TabIndex = 140;
            this.qualityLabel1.Text = "کیفیت";
            this.qualityLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scanTemplateButton
            // 
            this.scanTemplateButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.scanTemplateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.scanTemplateButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.scanTemplateButton.ForeColor = System.Drawing.Color.Black;
            this.scanTemplateButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.scanTemplateButton.ImageIndex = 4;
            this.scanTemplateButton.ImageList = this.imageListControls;
            this.scanTemplateButton.Location = new System.Drawing.Point(25, 213);
            this.scanTemplateButton.Name = "scanTemplateButton";
            this.scanTemplateButton.Size = new System.Drawing.Size(135, 22);
            this.scanTemplateButton.TabIndex = 137;
            this.scanTemplateButton.Text = "گرفتن اثر انگشت";
            this.scanTemplateButton.UseVisualStyleBackColor = false;
            this.scanTemplateButton.Click += new System.EventHandler(this.ScanTemplateButton_Click);
            // 
            // imageListControls
            // 
            this.imageListControls.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListControls.ImageStream")));
            this.imageListControls.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListControls.Images.SetKeyName(0, "Save3.ico");
            this.imageListControls.Images.SetKeyName(1, "save.ico");
            this.imageListControls.Images.SetKeyName(2, "remove.ico");
            this.imageListControls.Images.SetKeyName(3, "redo.ico");
            this.imageListControls.Images.SetKeyName(4, "Convert.ico");
            this.imageListControls.Images.SetKeyName(5, "network_find.ico");
            // 
            // percentLabel1
            // 
            this.percentLabel1.ForeColor = System.Drawing.Color.Black;
            this.percentLabel1.Location = new System.Drawing.Point(132, 183);
            this.percentLabel1.Name = "percentLabel1";
            this.percentLabel1.Size = new System.Drawing.Size(22, 15);
            this.percentLabel1.TabIndex = 136;
            this.percentLabel1.Text = "%";
            // 
            // qualityCurrentFingerTextBox
            // 
            this.qualityCurrentFingerTextBox.Location = new System.Drawing.Point(92, 179);
            this.qualityCurrentFingerTextBox.Name = "qualityCurrentFingerTextBox";
            this.qualityCurrentFingerTextBox.Size = new System.Drawing.Size(34, 22);
            this.qualityCurrentFingerTextBox.TabIndex = 134;
            // 
            // currentFingerFromScannerPictureBox
            // 
            this.currentFingerFromScannerPictureBox.BackColor = System.Drawing.Color.LemonChiffon;
            this.currentFingerFromScannerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.currentFingerFromScannerPictureBox.Location = new System.Drawing.Point(34, 21);
            this.currentFingerFromScannerPictureBox.Name = "currentFingerFromScannerPictureBox";
            this.currentFingerFromScannerPictureBox.Size = new System.Drawing.Size(126, 150);
            this.currentFingerFromScannerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.currentFingerFromScannerPictureBox.TabIndex = 1;
            this.currentFingerFromScannerPictureBox.TabStop = false;
            // 
            // titleStatusConfirmLabel
            // 
            this.titleStatusConfirmLabel.Location = new System.Drawing.Point(382, 58);
            this.titleStatusConfirmLabel.Name = "titleStatusConfirmLabel";
            this.titleStatusConfirmLabel.Size = new System.Drawing.Size(108, 21);
            this.titleStatusConfirmLabel.TabIndex = 142;
            this.titleStatusConfirmLabel.Text = "وضعیت مقایسه ";
            this.titleStatusConfirmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleStatusTemplateLabel
            // 
            this.titleStatusTemplateLabel.Location = new System.Drawing.Point(382, 24);
            this.titleStatusTemplateLabel.Name = "titleStatusTemplateLabel";
            this.titleStatusTemplateLabel.Size = new System.Drawing.Size(108, 21);
            this.titleStatusTemplateLabel.TabIndex = 141;
            this.titleStatusTemplateLabel.Text = "وضعیت اسکن جاری";
            this.titleStatusTemplateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusTemplateLabel
            // 
            this.statusTemplateLabel.BackColor = System.Drawing.Color.White;
            this.statusTemplateLabel.Location = new System.Drawing.Point(99, 25);
            this.statusTemplateLabel.Name = "statusTemplateLabel";
            this.statusTemplateLabel.Size = new System.Drawing.Size(277, 23);
            this.statusTemplateLabel.TabIndex = 139;
            this.statusTemplateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusConfirmLabel
            // 
            this.statusConfirmLabel.BackColor = System.Drawing.Color.White;
            this.statusConfirmLabel.Location = new System.Drawing.Point(99, 60);
            this.statusConfirmLabel.Name = "statusConfirmLabel";
            this.statusConfirmLabel.Size = new System.Drawing.Size(277, 23);
            this.statusConfirmLabel.TabIndex = 138;
            this.statusConfirmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // matchFingerButton
            // 
            this.matchFingerButton.BackColor = System.Drawing.Color.PaleGreen;
            this.matchFingerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.matchFingerButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.matchFingerButton.Location = new System.Drawing.Point(216, 350);
            this.matchFingerButton.Name = "matchFingerButton";
            this.matchFingerButton.Size = new System.Drawing.Size(117, 22);
            this.matchFingerButton.TabIndex = 133;
            this.matchFingerButton.Text = "مقایسه کردن";
            this.matchFingerButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.matchFingerButton.UseVisualStyleBackColor = false;
            this.matchFingerButton.Click += new System.EventHandler(this.MatchFingerButton_Click);
            // 
            // percentLabel
            // 
            this.percentLabel.ForeColor = System.Drawing.Color.Black;
            this.percentLabel.Location = new System.Drawing.Point(123, 182);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(20, 13);
            this.percentLabel.TabIndex = 132;
            this.percentLabel.Text = "%";
            // 
            // qualityconfirmFingerTextBox1
            // 
            this.qualityconfirmFingerTextBox1.Location = new System.Drawing.Point(83, 179);
            this.qualityconfirmFingerTextBox1.Name = "qualityconfirmFingerTextBox1";
            this.qualityconfirmFingerTextBox1.Size = new System.Drawing.Size(34, 22);
            this.qualityconfirmFingerTextBox1.TabIndex = 130;
            // 
            // qualityLabel2
            // 
            this.qualityLabel2.ForeColor = System.Drawing.Color.Black;
            this.qualityLabel2.Location = new System.Drawing.Point(28, 180);
            this.qualityLabel2.Name = "qualityLabel2";
            this.qualityLabel2.Size = new System.Drawing.Size(49, 21);
            this.qualityLabel2.TabIndex = 131;
            this.qualityLabel2.Text = "کیفیت";
            this.qualityLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmFingerPictureBox
            // 
            this.confirmFingerPictureBox.BackColor = System.Drawing.Color.DarkKhaki;
            this.confirmFingerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.confirmFingerPictureBox.ErrorImage = null;
            this.confirmFingerPictureBox.Location = new System.Drawing.Point(28, 21);
            this.confirmFingerPictureBox.Name = "confirmFingerPictureBox";
            this.confirmFingerPictureBox.Size = new System.Drawing.Size(126, 150);
            this.confirmFingerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.confirmFingerPictureBox.TabIndex = 2;
            this.confirmFingerPictureBox.TabStop = false;
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.BackColor = System.Drawing.Color.White;
            this.fullNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullNameLabel.ForeColor = System.Drawing.Color.Black;
            this.fullNameLabel.Location = new System.Drawing.Point(354, 15);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(311, 25);
            this.fullNameLabel.TabIndex = 8;
            this.fullNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // personnelNumberLabel
            // 
            this.personnelNumberLabel.BackColor = System.Drawing.Color.White;
            this.personnelNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.personnelNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.personnelNumberLabel.Location = new System.Drawing.Point(107, 15);
            this.personnelNumberLabel.Name = "personnelNumberLabel";
            this.personnelNumberLabel.Size = new System.Drawing.Size(117, 25);
            this.personnelNumberLabel.TabIndex = 9;
            this.personnelNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titlePersonnelNumberLabel
            // 
            this.titlePersonnelNumberLabel.AutoSize = true;
            this.titlePersonnelNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.titlePersonnelNumberLabel.Location = new System.Drawing.Point(18, 20);
            this.titlePersonnelNumberLabel.Name = "titlePersonnelNumberLabel";
            this.titlePersonnelNumberLabel.Size = new System.Drawing.Size(88, 14);
            this.titlePersonnelNumberLabel.TabIndex = 10;
            this.titlePersonnelNumberLabel.Text = "شماره پرسنلی:";
            // 
            // titleFullNameLabel
            // 
            this.titleFullNameLabel.AutoSize = true;
            this.titleFullNameLabel.ForeColor = System.Drawing.Color.Black;
            this.titleFullNameLabel.Location = new System.Drawing.Point(249, 20);
            this.titleFullNameLabel.Name = "titleFullNameLabel";
            this.titleFullNameLabel.Size = new System.Drawing.Size(103, 14);
            this.titleFullNameLabel.TabIndex = 11;
            this.titleFullNameLabel.Text = "نام و نام خانوادگی:";
            this.titleFullNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // personnelFingerPrintsBindingSource
            // 
            this.personnelFingerPrintsBindingSource.DataSource = typeof(Jamsaz.PersonnlsApplication.BusinessObjects.Data.PersonnelFingerPrint);
            // 
            // insertFingerTemplateButton
            // 
            this.insertFingerTemplateButton.BackColor = System.Drawing.Color.LightCyan;
            this.insertFingerTemplateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.insertFingerTemplateButton.Location = new System.Drawing.Point(21, 216);
            this.insertFingerTemplateButton.Name = "insertFingerTemplateButton";
            this.insertFingerTemplateButton.Size = new System.Drawing.Size(140, 23);
            this.insertFingerTemplateButton.TabIndex = 13;
            this.insertFingerTemplateButton.Text = "اضافه کردن اثر انگشت";
            this.insertFingerTemplateButton.UseVisualStyleBackColor = false;
            this.insertFingerTemplateButton.Click += new System.EventHandler(this.InsertFingerTemplateButton_Click);
            // 
            // editCurrentFingerButton
            // 
            this.editCurrentFingerButton.BackColor = System.Drawing.Color.Azure;
            this.editCurrentFingerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editCurrentFingerButton.Location = new System.Drawing.Point(167, 216);
            this.editCurrentFingerButton.Name = "editCurrentFingerButton";
            this.editCurrentFingerButton.Size = new System.Drawing.Size(127, 23);
            this.editCurrentFingerButton.TabIndex = 14;
            this.editCurrentFingerButton.Text = "ویرایش انگشت جاری";
            this.editCurrentFingerButton.UseVisualStyleBackColor = false;
            this.editCurrentFingerButton.Click += new System.EventHandler(this.EditCurrentFingerButton_Click);
            // 
            // deleteCurremtFingerButton
            // 
            this.deleteCurremtFingerButton.BackColor = System.Drawing.Color.Salmon;
            this.deleteCurremtFingerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteCurremtFingerButton.Location = new System.Drawing.Point(421, 215);
            this.deleteCurremtFingerButton.Name = "deleteCurremtFingerButton";
            this.deleteCurremtFingerButton.Size = new System.Drawing.Size(75, 23);
            this.deleteCurremtFingerButton.TabIndex = 15;
            this.deleteCurremtFingerButton.Text = "حذف";
            this.deleteCurremtFingerButton.UseVisualStyleBackColor = false;
            this.deleteCurremtFingerButton.Click += new System.EventHandler(this.DeletecurremtFingerButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.confirmFingerPictureBox);
            this.groupBox2.Controls.Add(this.qualityLabel2);
            this.groupBox2.Controls.Add(this.qualityconfirmFingerTextBox1);
            this.groupBox2.Controls.Add(this.percentLabel);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(347, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 242);
            this.groupBox2.TabIndex = 143;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "مقایسه اثر انگشت";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.titleStatusConfirmLabel);
            this.groupBox3.Controls.Add(this.statusConfirmLabel);
            this.groupBox3.Controls.Add(this.statusTemplateLabel);
            this.groupBox3.Controls.Add(this.titleStatusTemplateLabel);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(20, 493);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(512, 100);
            this.groupBox3.TabIndex = 144;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "وضعیت دریافت و مقایسه اثر انگشت از اسکنر";
            // 
            // confirmFromDataTabelButton
            // 
            this.confirmFromDataTabelButton.BackColor = System.Drawing.Color.PaleGreen;
            this.confirmFromDataTabelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirmFromDataTabelButton.Location = new System.Drawing.Point(300, 215);
            this.confirmFromDataTabelButton.Name = "confirmFromDataTabelButton";
            this.confirmFromDataTabelButton.Size = new System.Drawing.Size(115, 23);
            this.confirmFromDataTabelButton.TabIndex = 145;
            this.confirmFromDataTabelButton.Text = "مقایسه با اثر جاری ";
            this.confirmFromDataTabelButton.UseVisualStyleBackColor = false;
            this.confirmFromDataTabelButton.Click += new System.EventHandler(this.ConfirmFromDataTabelButton_Click);
            // 
            // clearControlButton
            // 
            this.clearControlButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.clearControlButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearControlButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.clearControlButton.Location = new System.Drawing.Point(216, 378);
            this.clearControlButton.Name = "clearControlButton";
            this.clearControlButton.Size = new System.Drawing.Size(117, 22);
            this.clearControlButton.TabIndex = 146;
            this.clearControlButton.Text = "پاک کردن ";
            this.clearControlButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearControlButton.UseVisualStyleBackColor = false;
            this.clearControlButton.Click += new System.EventHandler(this.ClearControlButton_Click);
            // 
            // personnelFingerPrintsDataGridView
            // 
            this.personnelFingerPrintsDataGridView.AllowUserToAddRows = false;
            this.personnelFingerPrintsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.personnelFingerPrintsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.personnelFingerPrintsDataGridView.AutoGenerateColumns = false;
            this.personnelFingerPrintsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(153)))), ((int)(((byte)(199)))));
            this.personnelFingerPrintsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personnelFingerPrintsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.personnelIDDataGridViewTextBoxColumn,
            this.fingerIndexDataGridViewTextBoxColumn,
            this.templateDataDataGridViewTextBoxColumn,
            this.fingerPrintImageIDDataGridViewTextBoxColumn});
            this.personnelFingerPrintsDataGridView.DataSource = this.personnelFingerPrintsBindingSource;
            this.personnelFingerPrintsDataGridView.Location = new System.Drawing.Point(21, 59);
            this.personnelFingerPrintsDataGridView.MultiSelect = false;
            this.personnelFingerPrintsDataGridView.Name = "personnelFingerPrintsDataGridView";
            this.personnelFingerPrintsDataGridView.ReadOnly = true;
            this.personnelFingerPrintsDataGridView.ShowCellErrors = false;
            this.personnelFingerPrintsDataGridView.Size = new System.Drawing.Size(511, 150);
            this.personnelFingerPrintsDataGridView.TabIndex = 147;
            this.personnelFingerPrintsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personnelFingerPrintsDataGridView_CellClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // personnelIDDataGridViewTextBoxColumn
            // 
            this.personnelIDDataGridViewTextBoxColumn.DataPropertyName = "PersonnelID";
            this.personnelIDDataGridViewTextBoxColumn.HeaderText = "PersonnelID";
            this.personnelIDDataGridViewTextBoxColumn.Name = "personnelIDDataGridViewTextBoxColumn";
            this.personnelIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.personnelIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // fingerIndexDataGridViewTextBoxColumn
            // 
            this.fingerIndexDataGridViewTextBoxColumn.DataPropertyName = "FingerIndex";
            this.fingerIndexDataGridViewTextBoxColumn.FillWeight = 150F;
            this.fingerIndexDataGridViewTextBoxColumn.HeaderText = "شماره انگشت";
            this.fingerIndexDataGridViewTextBoxColumn.Name = "fingerIndexDataGridViewTextBoxColumn";
            this.fingerIndexDataGridViewTextBoxColumn.ReadOnly = true;
            this.fingerIndexDataGridViewTextBoxColumn.Width = 150;
            // 
            // templateDataDataGridViewTextBoxColumn
            // 
            this.templateDataDataGridViewTextBoxColumn.DataPropertyName = "TemplateData";
            this.templateDataDataGridViewTextBoxColumn.HeaderText = "TemplateData";
            this.templateDataDataGridViewTextBoxColumn.Name = "templateDataDataGridViewTextBoxColumn";
            this.templateDataDataGridViewTextBoxColumn.ReadOnly = true;
            this.templateDataDataGridViewTextBoxColumn.Visible = false;
            // 
            // fingerPrintImageIDDataGridViewTextBoxColumn
            // 
            this.fingerPrintImageIDDataGridViewTextBoxColumn.DataPropertyName = "FingerPrintImageID";
            this.fingerPrintImageIDDataGridViewTextBoxColumn.HeaderText = "FingerPrintImageID";
            this.fingerPrintImageIDDataGridViewTextBoxColumn.Name = "fingerPrintImageIDDataGridViewTextBoxColumn";
            this.fingerPrintImageIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.fingerPrintImageIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // PersonnelFingerPrintsDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(725, 606);
            this.Controls.Add(this.personnelFingerPrintsDataGridView);
            this.Controls.Add(this.clearControlButton);
            this.Controls.Add(this.confirmFromDataTabelButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.deleteCurremtFingerButton);
            this.Controls.Add(this.matchFingerButton);
            this.Controls.Add(this.editCurrentFingerButton);
            this.Controls.Add(this.insertFingerTemplateButton);
            this.Controls.Add(this.titleFullNameLabel);
            this.Controls.Add(this.titlePersonnelNumberLabel);
            this.Controls.Add(this.personnelNumberLabel);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.GroupTemplate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exitButton);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonnelFingerPrintsDialogForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "فرم ذخیره اثر انگشت پرسنل در سیستم";
            this.Load += new System.EventHandler(this.FingerPrintsPersonnelDialogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fingerPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.GroupTemplate.ResumeLayout(false);
            this.GroupTemplate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentFingerFromScannerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmFingerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnelFingerPrintsBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personnelFingerPrintsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox fingerPictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox GroupTemplate;
        private System.Windows.Forms.PictureBox confirmFingerPictureBox;
        private System.Windows.Forms.PictureBox currentFingerFromScannerPictureBox;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label personnelNumberLabel;
        private System.Windows.Forms.Label titlePersonnelNumberLabel;
        private System.Windows.Forms.Label titleFullNameLabel;
        private System.Windows.Forms.BindingSource personnelFingerPrintsBindingSource;
        private System.Windows.Forms.Button insertFingerTemplateButton;
        private System.Windows.Forms.Button editCurrentFingerButton;
        private System.Windows.Forms.Button deleteCurremtFingerButton;
        private System.Windows.Forms.Label statusTemplateLabel;
        private System.Windows.Forms.Label statusConfirmLabel;
        private System.Windows.Forms.Button scanTemplateButton;
        private System.Windows.Forms.Label percentLabel1;
        private System.Windows.Forms.TextBox qualityCurrentFingerTextBox;
        private System.Windows.Forms.Button matchFingerButton;
        private System.Windows.Forms.Label percentLabel;
        private System.Windows.Forms.TextBox qualityconfirmFingerTextBox1;
        private System.Windows.Forms.Label qualityLabel2;
        private System.Windows.Forms.Label titleStatusTemplateLabel;
        private System.Windows.Forms.Label qualityLabel1;
        private System.Windows.Forms.Label titleStatusConfirmLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button confirmFromDataTabelButton;
        private System.Windows.Forms.Button clearControlButton;
        private System.Windows.Forms.ImageList imageListControls;
        private System.Windows.Forms.DataGridView personnelFingerPrintsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fingerIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn templateDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fingerPrintImageIDDataGridViewTextBoxColumn;
    }
}