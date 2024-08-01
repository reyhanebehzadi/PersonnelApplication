using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.PersonnlsApplication.UI.DialogForms;
using Jamsaz.PersonnlsApplication.UI.ReportForms;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class WithoutOvertimePersonnelsDockForm : BasePersianForm
    {
        public WithoutOvertimePersonnelsDockForm()
        {
            InitializeComponent();
        }

        private void WithoutOvertimePersonnelsDockForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private JamsazERPLiteDataClassesDataContext db;

        private void LoadData()
        {
            db = new JamsazERPLiteDataClassesDataContext();
            withoutOvertimePersonnelBindingSource.DataSource = db.WithoutOvertimePersonnels.OrderBy(c => Convert.ToInt32(c.Personnel.PersonnelNumber));
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            PersonnelListForm listForm = new PersonnelListForm(db);

            if (listForm.ShowDialog() == DialogResult.OK)
            {
                if (db.WithoutOvertimePersonnels.Any(c => c.PersonnelID == listForm.Personnel.Id))
                    return;

                WithoutOvertimePersonnel withoutOvertimePersonnel = new WithoutOvertimePersonnel()
                {
                    Personnel = db.Personnels.SingleOrDefault(c => c.Id == listForm.Personnel.Id)
                };

                db.WithoutOvertimePersonnels.InsertOnSubmit(withoutOvertimePersonnel);
                db.SubmitChanges();

                LoadData();

            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            WithoutOvertimePersonnel withoutOvertimePersonnel = (WithoutOvertimePersonnel)withoutOvertimePersonnelBindingSource.Current;

            if (withoutOvertimePersonnel != null)
            {
                if (Helper.Confirm("آیا مایل به حذف پرسنل جاری هستید؟"))
                {
                    db.WithoutOvertimePersonnels.DeleteOnSubmit(withoutOvertimePersonnel);
                    db.SubmitChanges();
                    LoadData();
                }
            }
        }

        private void ChangeFileToolStripButton_Click(object sender, EventArgs e)
        {
            //if (Helper.Confirm("دریافت اطلاعات از یانک اظلاعاتی؟" + Environment.NewLine + "خیر: DBF خواندن فایل"))
            //{
            //    SelectMonthDialogForm selectMonth = new SelectMonthDialogForm();

            //    selectMonth.ShowDialog();

            //    SqlConnection connection = new SqlConnection("Data Source=blue;Initial Catalog=PwKara;User ID=sa;Password=123a!@#");

            //    SqlCommand command = new SqlCommand("Select * From [PwKara].[dbo].[KARKERD] Where   YEAR_=13" + selectMonth.Year + " And MONTH_=" + selectMonth.Month, connection);

            //    SqlDataAdapter adapter = new SqlDataAdapter(command);

            //    try
            //    {
            //        if (connection.State == ConnectionState.Closed)
            //            connection.Open();

            //        DataSet dataSet = new DataSet();

            //        adapter.Fill(dataSet);

            //        connection.Close();

            //        List<int> personnelList = db.WithoutOvertimePersonnels.Select(c => c.PersonnelID ?? 0).ToList();

            //        StringBuilder sb = new StringBuilder();

            //        string
            //            h1 = "EMP_NO",
            //            h2 = "TOTAL_R",
            //            h3 = "KASR_R",
            //            h4 = "KASR_S",
            //            h5 = "EZ_PAY",
            //            h6 = "NAME";
            //        sb.Append(string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}{6}", h1, h2, h3, h4, h5, h6, Environment.NewLine));

            //        if (dataSet.Tables[0].Rows.Count == 0)
            //        {
            //            Helper.Error("اطلاعات برای ماه " + selectMonth.Month + " سال " + selectMonth.Year+"ثبت نشده است");

            //            return;
            //        }

            //        foreach (DataRow row in dataSet.Tables[0].Rows)
            //        {
            //            string personnelNumber = row["EMP_NO"].ToString();

            //            string ezafe;

            //            int personnelID = db.Personnels.Single(c => c.PersonnelNumber == personnelNumber).Id;

            //            if (personnelList.Contains(personnelID))
            //                ezafe = "0.00";
            //            else
            //            {

            //                ezafe = row["EZ_PAY"].ToString();

            //                int temp = int.Parse(ezafe);

            //                ezafe = string.Format("{0}.{1}", (int)temp / 100, (int)(((temp % 100) / 6.0) * 10));

            //            }


            //            sb.Append(string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}{6}", row["EMP_NO"].ToString().PadRight(h1.Length, ' '),
            //                                                                       row["NAKHALES"].ToString().PadRight(h2.Length, ' '),
            //                                                                       row["ABS_DAYS"].ToString().PadRight(h3.Length, ' '),
            //                                                                       row["DELAY_TIM"].ToString().PadRight(h4.Length, ' '),
            //                                                                       ezafe.ToString().PadRight(h5.Length, ' '),
            //                                                                       "".PadRight(h6.Length, ' '),
            //                                                                       Environment.NewLine));
            //        }

            //        SaveFileDialog saveFileDialog = new SaveFileDialog();
            //        saveFileDialog.Filter = "(*.txt)|*.txt";

            //        if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //        {
            //            File.WriteAllText(saveFileDialog.FileName, sb.ToString());

            //            Helper.ShowMessage("تغییرات انجام شد");
            //        }
            //    }
            //    catch (Exception)
            //    {

            //    }
            //}
            //else
            //{
            //    OpenFileDialog openFile = new OpenFileDialog();
            //    openFile.Filter = "(*.DBF)|*.dbf";

            //    if (openFile.ShowDialog() == DialogResult.OK)
            //    {
            //        string fileName = openFile.FileName;

            //        string readString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Path.GetDirectoryName(fileName) + "; Extended Properties=DBASE IV;";

            //        //string writeString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Path.GetDirectoryName(fileName)+"\\Edited" + "; Extended Properties=DBASE IV;";

            //        if (!Directory.Exists(Path.GetDirectoryName(fileName) + "\\Edited"))
            //            Directory.CreateDirectory(Path.GetDirectoryName(fileName) + "\\Edited");

            //        //string createStatement = "Create Table " + Path.GetFileName(fileName) + " ( [EMP_NO] varchar(8), [TOTAL_R] varchar(2), [KASR_R] varchar(2), [KASR_S] varchar(6), [EZ_PAY] varchar(6), [NAME] varchar(80) )";
            //        //string insertStatement = "Insert Into " + Path.GetFileName(fileName) + " Values ( ";
            //        //string insertTemp = string.Empty;

            //        OleDbConnection readConnection = new OleDbConnection(readString);
            //        //OleDbConnection writeConnection = new OleDbConnection(writeString);

            //        StringBuilder sb = new StringBuilder();

            //        string
            //            h1 = "EMP_NO",
            //            h2 = "TOTAL_R",
            //            h3 = "KASR_R",
            //            h4 = "KASR_S",
            //            h5 = "EZ_PAY",
            //            h6 = "NAME";
            //        sb.Append(string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}{6}", h1, h2, h3, h4, h5, h6, Environment.NewLine));

            //        try
            //        {
            //            if (readConnection.State == ConnectionState.Closed)
            //            {
            //                readConnection.Open();
            //            }

            //            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("select * from " + Path.GetFileName(fileName), readConnection);
            //            DataSet dataSet = new DataSet();
            //            dataAdapter.Fill(dataSet);
            //            readConnection.Close();

            //            ////Write
            //            //writeConnection.Open();

            //            //DataSet dsFill = new DataSet();

            //            //OleDbDataAdapter daInsertTable = new OleDbDataAdapter(createStatement, writeConnection);

            //            //daInsertTable.Fill(dsFill);
            //            ////Write

            //            List<int> personnelList = db.WithoutOvertimePersonnels.Select(c => c.PersonnelID ?? 0).ToList();

            //            foreach (DataRow row in dataSet.Tables[0].Rows)
            //            {
            //                string personnelNumber = row[0].ToString();

            //                string ezafe;

            //                int personnelID = db.Personnels.Single(c => c.PersonnelNumber == personnelNumber).Id;

            //                if (personnelList.Contains(personnelID))
            //                    ezafe = "0.00";
            //                else
            //                    ezafe = row[4].ToString();

            //                //insertTemp = insertStatement;

            //                //insertTemp += "'" + row[0] + "' , ";
            //                //insertTemp += "'" + row[1] + "' , ";
            //                //insertTemp += "'" + row[2] + "' , ";
            //                //insertTemp += "'" + row[3] + "' , ";
            //                //insertTemp += "'" + ezafe + "' , ";
            //                //insertTemp += "'' ) ;";

            //                sb.Append(string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}{6}", row[0].ToString().PadRight(h1.Length, ' '),
            //                                                                           row[1].ToString().PadRight(h2.Length, ' '),
            //                                                                           row[2].ToString().PadRight(h3.Length, ' '),
            //                                                                           row[3].ToString().PadRight(h4.Length, ' '),
            //                                                                           ezafe.ToString().PadRight(h5.Length, ' '),
            //                                                                           "".PadRight(h6.Length, ' '),
            //                                                                           Environment.NewLine));

            //                //daInsertTable = new OleDbDataAdapter(insertTemp, writeConnection);

            //                //daInsertTable.Fill(dsFill);
            //            }

            //            File.WriteAllText(Path.GetDirectoryName(fileName) + "\\Edited\\" + Path.GetFileName(fileName) + ".txt", sb.ToString());

            //            Helper.ShowMessage("تغییرات انجام شد");
            //        }
            //        catch
            //        {
            //            Helper.Error("بروز خطا");
            //        }
            //        finally
            //        {
            //            readConnection.Close();
            //            readConnection.Dispose();

            //            //writeConnection.Close();
            //            //writeConnection.Dispose();
            //        }
            //    }
            //}


            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "(*.dbf)|*.dbf";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFile.FileName;

                string readString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Path.GetDirectoryName(fileName) + "; Extended Properties=DBASE IV;";

                string writeString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Path.GetDirectoryName(fileName) + "\\Edited" + "; Extended Properties=DBASE IV;";

                if (!Directory.Exists(Path.GetDirectoryName(fileName) + "\\Edited"))
                    Directory.CreateDirectory(Path.GetDirectoryName(fileName) + "\\Edited");

                string createStatement = "Create Table " + Path.GetFileName(fileName) + " ( [EMP_NO] varchar(10), [TOTAL_R] varchar(10), [KASR_R] varchar(10), [KASR_S] varchar(10), [EZ_PAY] varchar(10) )";
                string insertStatement = "Insert Into " + Path.GetFileName(fileName) + " Values ( ";
                string insertTemp = string.Empty;

                OleDbConnection readConnection = new OleDbConnection(readString);
                OleDbConnection writeConnection = new OleDbConnection(writeString);

                try
                {
                    if (readConnection.State == ConnectionState.Closed)
                    {
                        readConnection.Open();
                    }

                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter("select * from " + Path.GetFileName(fileName), readConnection);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    readConnection.Close();

                    //Write
                    writeConnection.Open();

                    DataSet dsFill = new DataSet();

                    OleDbDataAdapter daInsertTable = new OleDbDataAdapter(createStatement, writeConnection);

                    daInsertTable.Fill(dsFill);
                    //Write

                    List<int> personnelList = db.WithoutOvertimePersonnels.Select(c => c.PersonnelID ?? 0).ToList();

                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        string personnelNumber = row[0].ToString();

                        object ezafe;

                        int personnelID = db.Personnels.Single(c => c.PersonnelNumber == personnelNumber).Id;

                        if (personnelList.Contains(personnelID))
                            ezafe = 0;
                        else
                            ezafe = row[4];

                        insertTemp = insertStatement;

                        insertTemp += "'" + row[0] + "' , ";
                        insertTemp += "'" + row[1] + "' , ";
                        insertTemp += "'" + row[2] + "' , ";

                        insertTemp += "'" + row[3] + "' , ";
                        insertTemp += "'" + ezafe + "' ) ;";

                        daInsertTable = new OleDbDataAdapter(insertTemp, writeConnection);

                        daInsertTable.Fill(dsFill);
                    }
                }
                catch
                {
                    MessageBox.Show("Error ...");
                }
                finally
                {
                    readConnection.Close();
                    readConnection.Dispose();

                    writeConnection.Close();
                    writeConnection.Dispose();
                    Helper.ShowMessage("تغییرات انجام شد");
                }
            }

        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            WithoutOvertimePersonnelReportForm withoutOvertimePersonnelReportForm = new WithoutOvertimePersonnelReportForm();

            withoutOvertimePersonnelReportForm.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ////zamani estefade mishe ke mikhaim be ezaye ye seri personnel faghat tarikhe asarbakhshishono vase gharadade jadid ezafe konim
            //foreach (Sheet1_ sheet1 in db.Sheet1_s)
            //{
            //    PayRoll payRoll = new PayRoll();
            //    payRoll.PersonnelID =
            //        db.Personnels.SingleOrDefault(c => Convert.ToDouble(c.PersonnelNumber) == sheet1.شماره_پرسنلی).Id;
            //    payRoll.Salary = db.PayRolls.Where(c => c.PersonnelID == payRoll.PersonnelID).ToList().Last().Salary;
            //    payRoll.EffectiveDate = db.Personnels.SingleOrDefault(c => c.Id == 3609).CurrentContractStartDate;
            //    payRoll.HagheMaskan = db.PayRolls.Where(c => c.PersonnelID == payRoll.PersonnelID).ToList().Last().HagheMaskan;
            //    payRoll.HagheOlad = db.PayRolls.Where(c => c.PersonnelID == payRoll.PersonnelID).ToList().Last().HagheOlad;
            //    payRoll.HagheSakhtiKar = db.PayRolls.Where(c => c.PersonnelID == payRoll.PersonnelID).ToList().Last().HagheSakhtiKar;
            //    payRoll.HagheSarparsti = db.PayRolls.Where(c => c.PersonnelID == payRoll.PersonnelID).ToList().Last().HagheSarparsti;
            //    payRoll.Haghekharobar = db.PayRolls.Where(c => c.PersonnelID == payRoll.PersonnelID).ToList().Last().Haghekharobar;
            //    payRoll.ShiftPercent = db.PayRolls.Where(c => c.PersonnelID == payRoll.PersonnelID).ToList().Last().ShiftPercent;
            //    payRoll.MablagheNobateKari = db.PayRolls.Where(c => c.PersonnelID == payRoll.PersonnelID).ToList().Last().MablagheNobateKari;

            //    db.PayRolls.InsertOnSubmit(payRoll);
            //    db.SubmitChanges();


            //}
            //Helper.ShowMessage("ثبت شد");

            

            ////query database ke bayad ejra shavad
            ////            select * from hrm.personnel 
            ////where PersonnelNumber in (select  [شماره پرسنلی] from  [dbo].[Sheet1$])

            ////select * from hrm.Personnel where id = 3609


            ////Update  hrm.personnel set CurrentContractStartDate = cast('2015-12-22' as datetime),CurrentContractEndDate = cast('2016-01-20' as datetime) 
            ////where PersonnelNumber in (select  [شماره پرسنلی] from  [dbo].[Sheet1$])
        }

      
    }
}
