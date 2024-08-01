using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.Classes;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using System.Collections;
using Jamsaz.PersonnlsApplication.UI.DialogForms;
using Jamsaz.PersonnlsApplication.Classes;
using System.IO;
using System.Drawing.Imaging;


namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class PersonnelFingerPrintsDialogForm : Form
    {
        int personnelID;
        byte[] template = new byte[384];
        JamsazERPLiteDataClassesDataContext db = new Jamsaz.PersonnlsApplication.BusinessObjects.Data.JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
        Personnel personnel = new Personnel();
        public PersonnelFingerPrintsDialogForm(int personnelID)
        {
            InitializeComponent();
            this.personnelID = personnelID;
            personnel = db.Personnels.Single(c => c.Id == personnelID);
            fullNameLabel.Text = personnel.FirstName + " " + personnel.LastName;
            personnelNumberLabel.Text = personnel.PersonnelNumber;
        }

        private void FingerPrintsPersonnelDialogForm_Load(object sender, EventArgs e)
        {
            try
            {
                SFRControl.loadDeviceFingerScanner();
                SFRControl.SetValueAttributes();

                personnelFingerPrintsBindingSource.DataSource = db.PersonnelFingerPrints.Where(c => c.PersonnelID == this.personnelID);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }

            //     this.personnelFingerPrintsTableAdapter.FillByPersonnelID(this.dataSetFinger1.PersonnelFingerPrints,valPersonnelID);


        }

        private void ScanTemplateButton_Click(object sender, EventArgs e)
        {
            template = SFRControl.LoadTemplate();

            currentFingerFromScannerPictureBox.Image = SFRControl.GetLastImage;
            qualityCurrentFingerTextBox.Text = SFRControl.GetQuality.ToString();
            if (SFRControl.ReturnCodeMessage == 1)
            {
                statusTemplateLabel.BackColor = Color.Green;
                statusTemplateLabel.ForeColor = Color.White;
                statusTemplateLabel.Text = SFRControl.GetMessage;
            }
            else if (SFRControl.ReturnCodeMessage != 1)
            {
                statusTemplateLabel.BackColor = Color.Red;
                statusTemplateLabel.ForeColor = Color.White;
                statusTemplateLabel.Text = SFRControl.GetMessage;
            }
        }

        private void MatchFingerButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentFingerFromScannerPictureBox.Image != null)
                {
                    SFRControl.LoadCurrentFinger();

                    confirmFingerPictureBox.Image = SFRControl.GetLastImage;
                    qualityconfirmFingerTextBox1.Text = SFRControl.GetQuality.ToString();


                    if (SFRControl.ReturnCodeMessage == 1)
                    {
                        statusConfirmLabel.BackColor = Color.Green;
                        statusConfirmLabel.ForeColor = Color.White;
                        statusConfirmLabel.Text = SFRControl.GetMessage;
                    }
                    else if (SFRControl.ReturnCodeMessage != 1)
                    {
                        statusConfirmLabel.BackColor = Color.Red;
                        statusConfirmLabel.ForeColor = Color.White;
                        statusConfirmLabel.Text = SFRControl.GetMessage;
                    }
                }
                else

                { MessageBox.Show("لطفا اثر انگشت را با دستگاه اسکن کنید"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InsertFingerTemplateButton_Click(object sender, EventArgs e)
        {
            if (currentFingerFromScannerPictureBox.Image != null)
            {
                if (statusTemplateLabel.BackColor == Color.Green)
                {
                    int lastFingerIndex = 0;
                    if (db.PersonnelFingerPrints.Count(d => d.PersonnelID == this.personnelID) != 0)
                    {
                        lastFingerIndex = db.PersonnelFingerPrints.Where(d => d.PersonnelID == this.personnelID).Max(c => (short)c.FingerIndex) + 1;
                    }
                    else
                        lastFingerIndex = 1;

                    FingerPrintImage fingerPrintImage = new FingerPrintImage();
                    Bitmap imageFinger = (Bitmap)currentFingerFromScannerPictureBox.Image;
                    fingerPrintImage.ImageData = BitmapToBytes(imageFinger);
                    db.FingerPrintImages.InsertOnSubmit(fingerPrintImage);
                    db.SubmitChanges();

                    PersonnelFingerPrint personnelFingerPrint = new PersonnelFingerPrint();
                    personnelFingerPrint.FingerIndex = (short)lastFingerIndex;
                    personnelFingerPrint.FingerPrintImageID = fingerPrintImage.ID;
                    personnelFingerPrint.PersonnelID = this.personnelID;
                    personnelFingerPrint.TemplateData = template;
                    db.PersonnelFingerPrints.InsertOnSubmit(personnelFingerPrint);
                    db.SubmitChanges();

                    db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
                    personnelFingerPrintsBindingSource.DataSource = db.PersonnelFingerPrints.Where(c => c.PersonnelID == this.personnelID);
                    Helper.ShowMessage("اثر انگشت ثبت شد");
                    nullStatusLable();
                    qualityCurrentFingerTextBox.Text = string.Empty;
                    qualityconfirmFingerTextBox1.Text = string.Empty;
                    currentFingerFromScannerPictureBox.Image = null;
                }
                else MessageBox.Show(statusTemplateLabel.Text);

            }
            else
                MessageBox.Show("لطفا اثر انگشت را با دستگاه اسکن کنید");
        }

        private void personnelFingerPrintsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (personnelFingerPrintsBindingSource.Current == null)
                return;

            PersonnelFingerPrint personnelFingerPrint = (PersonnelFingerPrint)personnelFingerPrintsBindingSource.Current;
            FingerPrintImage fingerPrintImage = db.FingerPrintImages.Single(c => c.ID == personnelFingerPrint.FingerPrintImageID);
            fingerPictureBox.Image = byteArrayToImage(fingerPrintImage.ImageData.ToArray());
        }

        private void EditCurrentFingerButton_Click(object sender, EventArgs e)
        {
            PersonnelFingerPrint personnelFingerPrint = (PersonnelFingerPrint)personnelFingerPrintsBindingSource.Current;
            if (personnelFingerPrint != null)
            {
                if (currentFingerFromScannerPictureBox.Image != null)
                {
                    if (statusTemplateLabel.BackColor == Color.Green)
                    {
                        FingerPrintImage fingerPrintImage = new FingerPrintImage();
                        fingerPrintImage = db.FingerPrintImages.Single(c => c.ID == personnelFingerPrint.FingerPrintImageID);
                        fingerPrintImage.ImageData = BitmapToBytes((Bitmap)currentFingerFromScannerPictureBox.Image);
                        personnelFingerPrint.TemplateData = template;
                        fingerPictureBox.Image = currentFingerFromScannerPictureBox.Image;
                        currentFingerFromScannerPictureBox.Image = null;
                        confirmFingerPictureBox.Image = null;
                        qualityconfirmFingerTextBox1.Text = string.Empty;
                        qualityCurrentFingerTextBox.Text = string.Empty;
                        nullStatusLable();
                        db.SubmitChanges();
                        MessageBox.Show("ثبت شد");
                    }
                    else MessageBox.Show(statusTemplateLabel.Text);
                }
                else
                    MessageBox.Show("لطفا اثر انگشت را با دستگاه اسکن کنید");
            }
            else
                MessageBox.Show("اثر انگشتی برای ویرایش وجود ندارد");
        }

        private byte[] BitmapToBytes(Bitmap bmp)
        {

            MemoryStream stream = new MemoryStream();

            bmp.Save(stream, ImageFormat.Bmp);

            return stream.ToArray();

        }

        private Bitmap byteArrayToImage(byte[] byteArrayIn)
        {
            Bitmap temp = null;
            if (byteArrayIn != null)
            {
                using (MemoryStream stream = new MemoryStream(byteArrayIn))
                {
                    temp = (Bitmap)Image.FromStream(stream);
                }

            }
            return temp;
        }

        private void ConfirmFromDataTabelButton_Click(object sender, EventArgs e)
        {
            PersonnelFingerPrint personnelFingerPrint = (PersonnelFingerPrint)personnelFingerPrintsBindingSource.Current;
            if (personnelFingerPrintsBindingSource.Current != null)
            {
                confirmFingerPictureBox.Image = null;
                qualityCurrentFingerTextBox.Text = string.Empty;
                nullStatusLable();
                byte[] tempconfirm = new byte[384];
                tempconfirm = personnelFingerPrint.TemplateData.ToArray();
                SFRControl.ConfirmCurrentFinger(tempconfirm);
                confirmFingerPictureBox.Image = SFRControl.GetLastImage;
                qualityconfirmFingerTextBox1.Text = SFRControl.GetQuality.ToString();

                if (SFRControl.ReturnCodeMessage == 1)
                {
                    statusConfirmLabel.BackColor = Color.Green;
                    statusConfirmLabel.ForeColor = Color.White;
                    statusConfirmLabel.Text = SFRControl.GetMessage;
                }
                else if (SFRControl.ReturnCodeMessage != 1)
                {
                    statusConfirmLabel.BackColor = Color.Red;
                    statusConfirmLabel.ForeColor = Color.White;
                    statusConfirmLabel.Text = SFRControl.GetMessage;
                }
            }
            else
                MessageBox.Show("اثر انگشتی برای مقایسه در لیست وجود ندارد");

        }

        private void DeletecurremtFingerButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (personnelFingerPrintsBindingSource.Current != null)
                {
                    PersonnelFingerPrint personnelFingerPrint = (PersonnelFingerPrint)personnelFingerPrintsBindingSource.Current;
                    db.FingerPrintImages.DeleteOnSubmit(db.FingerPrintImages.Single(c => c.ID == personnelFingerPrint.FingerPrintImageID));
                    personnelFingerPrintsBindingSource.RemoveCurrent();
                    db.SubmitChanges();
                    fingerPictureBox.Image = null;
                    MessageBox.Show("اثر انگشت جاری حذف شد");
                }
                else
                    MessageBox.Show("اثر انگشتی برای حذف  وجود ندارد");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        private void nullStatusLable()
        {
            statusTemplateLabel.BackColor = Color.White;
            statusTemplateLabel.Text = "";

            statusConfirmLabel.BackColor = Color.White;
            statusConfirmLabel.Text = "";
        }

        private void nullPictureBox()
        {
            confirmFingerPictureBox.Image = null;
            currentFingerFromScannerPictureBox.Image = null;
            fingerPictureBox.Image = null;
        }

        private void ClearControlButton_Click(object sender, EventArgs e)
        {
            nullStatusLable();
            qualityconfirmFingerTextBox1.Text = "";
            qualityCurrentFingerTextBox.Text = "";
            confirmFingerPictureBox.Image = null;
            currentFingerFromScannerPictureBox.Image = null;
            fingerPictureBox.Image = null;
        }


    }
}