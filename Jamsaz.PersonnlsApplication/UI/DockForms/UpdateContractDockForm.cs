using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Microsoft.Office.Interop.Excel;
using Stimulsoft.Report.Components;


namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class UpdateContractDockForm : BasePersianForm
    {
        public UpdateContractDockForm()
        {
            InitializeComponent();
            xlApp = new Microsoft.Office.Interop.Excel.Application();
        }

        private readonly Microsoft.Office.Interop.Excel.Application xlApp;
        private Workbook xlWorkBook;
        private Worksheet xlWorkSheet;
        private Range range;
        List<Personel> PersonnelList = new List<Personel>();
        private DialogResult result;
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        Personel currentRow;
        private void selectButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter =
                "XML Files (*.xml; *.xls; *.xlsx; *.xlsm; *.xlsb) |*.xml; *.xls; *.xlsx; *.xlsm; *.xlsb"; //open file format define Excel Files(.xls)|*.xls| Excel Files(.xlsx)|*.xlsx| 
            openFileDialog1.Multiselect = false;

            result = openFileDialog1.ShowDialog();
            var fileExt = Path.GetExtension(openFileDialog1.FileName);
            if (!(fileExt.CompareTo(".xls") == 0 || fileExt.CompareTo(".xlsx") == 0))
            {
                openFileDialog1.FileName = "";
            }

            if (openFileDialog1.FileName != string.Empty && updateTypeCheckBox.Checked)
            {
                personnelColumnTextBox.Enabled = true;
                startDateTextBox.Enabled = true;
                endDateTextBox.Enabled = true;
                salaryTextBox.Enabled = shiftPercentTextBox.Enabled =
                    mablagheNobateKariTextBox.Enabled = hagheSarparstiTextBox.Enabled =
                        hagheSakhtiKarTextBox.Enabled = hagheMaskanTextBox.Enabled =
                            haghekharobarTextBox.Enabled = hagheOladTextBox.Enabled = hagheGhazaTextBox.Enabled = hagheAyabZahabTextBox.Enabled = true;
            }

            else if (openFileDialog1.FileName != string.Empty && !updateTypeCheckBox.Checked)
            {
                personnelColumnTextBox.Enabled = true;
                startDateTextBox.Enabled = true;
                endDateTextBox.Enabled = true;
                salaryTextBox.Enabled = shiftPercentTextBox.Enabled =
                    mablagheNobateKariTextBox.Enabled = hagheSarparstiTextBox.Enabled =
                        hagheSakhtiKarTextBox.Enabled = hagheMaskanTextBox.Enabled =
                            haghekharobarTextBox.Enabled = hagheOladTextBox.Enabled = hagheGhazaTextBox.Enabled = hagheAyabZahabTextBox.Enabled = false;
            }
            else if (openFileDialog1.FileName == string.Empty)
            {
                personnelColumnTextBox.Text = "";
                personnelColumnTextBox.Enabled = false;
                startDateTextBox.Enabled = false;
                endDateTextBox.Enabled = false;
                salaryTextBox.Enabled = shiftPercentTextBox.Enabled =
                    mablagheNobateKariTextBox.Enabled = hagheSarparstiTextBox.Enabled =
                        hagheSakhtiKarTextBox.Enabled = hagheMaskanTextBox.Enabled =
                            haghekharobarTextBox.Enabled = hagheOladTextBox.Enabled =  hagheGhazaTextBox.Enabled = hagheAyabZahabTextBox.Enabled=false;
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (result == DialogResult.OK && !string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                Process nativeProcess = new Process();
                nativeProcess.StartInfo.FileName = openFileDialog1.FileName;
                nativeProcess.Start();
            }
            else
            {
                Helper.ShowMessage("لطفا ابتدا فایل مورد نظر را انتخاب نمایید");

            }
        }

        private void UpdateContractDockForm_Load(object sender, EventArgs e)
        {
            updateButton.Enabled = false;
            updateOnlyLastPayRollButton.Enabled = false;
            personnelColumnTextBox.Enabled = false;
            startDateTextBox.Enabled = false;
            endDateTextBox.Enabled = false;
            openFileDialog1.FileName = string.Empty;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {


            try
            {


                
                if (PersonnelList.Count > 0 && personelBindingSource.List.Count > 0)
                {
                    try
                    {
                        
                        foreach (Personel item in PersonnelList)
                        {
                            currentRow = item;

                            var personnel =
                                db.Personnels.SingleOrDefault(
                                    c => Convert.ToInt32(c.PersonnelNumber) == Convert.ToInt32(item.PersonelNumbler));


                            if (personnel.ContractTypeId == 4) //age estekhdam daem bashe
                            {
                                item.StartDate =
                                    Helper.GetPersianDate(Convert.ToDateTime(db.FiscalYears
                                        .SingleOrDefault(c => c.Status == 2).StartDate));
                                item.EndDate =
                                    Helper.GetPersianDate(Convert.ToDateTime(db.FiscalYears
                                        .SingleOrDefault(c => c.Status == 2).EndDate));
                            }



                            //string ContractStartDate = Helper.GetPersianDate(personnel.CurrentContractStartDate.GetValueOrDefault()).Substring(2, (Helper.GetPersianDate(personnel.CurrentContractStartDate.GetValueOrDefault()).Length) - 2);
                            string ContractStartDate = Helper.GetPersianDate(personnel.CurrentContractStartDate.GetValueOrDefault());


                            // string ContractEndDate = Helper.GetPersianDate(personnel.CurrentContractEndDate.GetValueOrDefault()).Substring(2, (Helper.GetPersianDate(personnel.CurrentContractEndDate.GetValueOrDefault()).Length) - 2);
                            string ContractEndDate = Helper.GetPersianDate(personnel.CurrentContractEndDate.GetValueOrDefault());

                            //item.StartDate = item.StartDate.Length > 8
                            //        ? item.StartDate.Substring(2, item.StartDate.Length - 2)
                            //        : item.StartDate;

                           
                            //item.EndDate = item.EndDate.Length > 8
                            //    ? item.EndDate.Substring(2, item.EndDate.Length - 2)
                            //    : item.EndDate;


                            if (ContractStartDate == item.StartDate && ContractEndDate == item.EndDate)
                            {
                                Helper.Error(string.Format("در تاریخ مورد نظر اطلاعات برای شماره پرسنلی {0} به روز رسانی شده", item.PersonelNumbler));
                                groupBox1.Enabled = true;
                                return;
                            }


                        }
                    }
                    catch (Exception ex)
                    {

                        Helper.ShowMessage(string.Format("اطلاعات پرسنل  [{0}]  در فایل اکسل ناقص می باشد", currentRow.PersonelNumbler));
                    }


                    if (updateTypeCheckBox.Checked)
                    {

                        var document = new XElement("personels", from t in PersonnelList
                                                                 select new XElement("personel",
                                                                     new XElement("PersonelNumber", t.PersonelNumbler),
                                                                     new XElement("StartDate", t.StartDate),
                                                                     new XElement("EndDate", t.EndDate),
                                                                     new XElement("Salary", t.Salary),
                                                                     new XElement("ShiftPercent", t.ShiftPercent),
                                                                     new XElement("MablagheNobateKari", t.MablagheNobateKari),
                                                                     new XElement("HagheSarparsti", t.HagheSarparsti),
                                                                     new XElement("HagheSakhtiKar", t.HagheSakhtiKar),
                                                                     new XElement("HagheMaskan", t.HagheMaskan),
                                                                     new XElement("Haghekharobar", t.Haghekharobar),
                                                                     new XElement("HagheOlad", t.HagheOlad),
                                                                     new XElement("HagheJazb", t.HagheJazb),
                                                                     new XElement("HagheGhaza", t.HagheGhaza),
                                                                     new XElement("HagheAyabZahab", t.HagheAyabZahab),
                                                                     new XElement("HagheTaahol", t.HagheTaahol)

                                                                     ));


                        db.updateUserWithSalary(document);
                    }
                    else
                    {
                        var document = new XElement("personels", from t in PersonnelList
                                                                 select new XElement("personel",
                                                                     new XElement("PersonelNumber", t.PersonelNumbler),
                                                                     new XElement("StartDate", t.StartDate),
                                                                     new XElement("EndDate", t.EndDate)));

                        db.updateUser(document);
                    }


                    Helper.ShowMessage("اطلاعات با موفقیت به روز رسانی شد");
                    db = new JamsazERPLiteDataClassesDataContext();

                    groupBox1.Enabled = true;

                }
                else
                {
                    Helper.ShowMessage("اطلاعاتی برای به روزرسانی وجود ندارد");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void personnelColumnTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumber(sender, e);
        }

        private void startDateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumber(sender, e);
        }

        private void endDateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumber(sender, e);
        }

        private void showDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox2.Enabled = false;


                if (result == DialogResult.OK && !string.IsNullOrEmpty(personnelColumnTextBox.Text) &&
                    !string.IsNullOrEmpty(startDateTextBox.Text) && !string.IsNullOrEmpty(endDateTextBox.Text) && !string.IsNullOrEmpty(openFileDialog1.FileName))
                {

                    //Read From Excel file
                    
                    xlWorkBook = xlApp.Workbooks.Open(openFileDialog1.FileName, 0, true, 5, "", "", true,
                        XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                   
                    xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.Item[1];
                    range = xlWorkSheet.UsedRange;
                    var startRow = range.Row;


                    if (updateTypeCheckBox.Checked)

                    {

                        if (int.Parse(salaryTextBox.Text) > range.Columns.Count ||
                            int.Parse(salaryTextBox.Text) <= 0 ||
                            int.Parse(shiftPercentTextBox.Text) > range.Columns.Count ||
                            int.Parse(shiftPercentTextBox.Text) <= 0 ||
                            int.Parse(mablagheNobateKariTextBox.Text) > range.Columns.Count || int.Parse(mablagheNobateKariTextBox.Text) <= 0
                            || int.Parse(hagheSarparstiTextBox.Text) > range.Columns.Count || int.Parse(hagheSarparstiTextBox.Text) <= 0
                            || int.Parse(hagheSakhtiKarTextBox.Text) > range.Columns.Count || int.Parse(hagheSakhtiKarTextBox.Text) <= 0
                            || int.Parse(hagheMaskanTextBox.Text) > range.Columns.Count || int.Parse(hagheMaskanTextBox.Text) <= 0
                            || int.Parse(haghekharobarTextBox.Text) > range.Columns.Count || int.Parse(haghekharobarTextBox.Text) <= 0
                            || int.Parse(hagheOladTextBox.Text) > range.Columns.Count || int.Parse(hagheOladTextBox.Text) <= 0
                            || int.Parse(hagheJazbTextBox.Text) > range.Columns.Count || int.Parse(hagheJazbTextBox.Text) <= 0
                            || int.Parse(hagheTaaholTextBox.Text) > range.Columns.Count || int.Parse(hagheTaaholTextBox.Text) <= 0
                            || int.Parse(hagheGhazaTextBox.Text) <= 0 || int.Parse(hagheAyabZahabTextBox.Text) <= 0
                            )
                        {
                            Helper.ShowMessage("شماره ستون صحیح نیست");
                            groupBox2.Enabled = true;
                            return;

                        }


                        String salary =
                            (range.Cells[startRow, int.Parse(salaryTextBox.Text)] as Range)
                            ?.Value?.ToString();

                        String shiftPercent = (range.Cells[startRow, int.Parse(shiftPercentTextBox.Text)] as Range)
                            ?.Value?.ToString();

                        String mablagheNobateKari = (range.Cells[startRow, int.Parse(mablagheNobateKariTextBox.Text)] as Range)
                            ?.Value?.ToString();

                        String hagheSarparsti = (range.Cells[startRow, int.Parse(hagheSarparstiTextBox.Text)] as Range)
                            ?.Value?.ToString();

                        String hagheJazb = (range.Cells[startRow, int.Parse(hagheJazbTextBox.Text)] as Range)
                           ?.Value?.ToString();

                        String hagheSakhtiKar = (range.Cells[startRow, int.Parse(hagheSakhtiKarTextBox.Text)] as Range)
                            ?.Value?.ToString();

                        String hagheMaskan = (range.Cells[startRow, int.Parse(hagheMaskanTextBox.Text)] as Range)
                            ?.Value?.ToString();

                        String haghekharobar = (range.Cells[startRow, int.Parse(haghekharobarTextBox.Text)] as Range)
                            ?.Value?.ToString();

                        String hagheOlad = (range.Cells[startRow, int.Parse(hagheOladTextBox.Text)] as Range)
                            ?.Value?.ToString();

                        String hagheGhaza = (range.Cells[startRow, int.Parse(hagheGhazaTextBox.Text)] as Range)
                            ?.Value?.ToString();

                        String hagheAyabZahab = (range.Cells[startRow, int.Parse(hagheAyabZahabTextBox.Text)] as Range)
                           ?.Value?.ToString();

                        String hagheTaahol = (range.Cells[startRow, int.Parse(hagheTaaholTextBox.Text)] as Range)
                           ?.Value?.ToString();

                        if (salary == null || shiftPercent == null || mablagheNobateKari == null || hagheSarparsti == null || hagheSakhtiKar == null || hagheMaskan == null || haghekharobar == null || hagheOlad == null || hagheJazb == null || hagheGhaza == null || hagheAyabZahab == null || hagheTaahol==null)
                        {
                            Helper.ShowMessage("شماره ستون ها به درستی انتخاب نشده");
                            groupBox2.Enabled = true;
                            return;
                        }
                        if (!(salary.Trim().Equals("پایه حقوق") && shiftPercent.Trim().Equals("درصد نوبت کاری") &&
                              mablagheNobateKari.Trim().Equals("مبلغ نوبت کاری") && hagheSarparsti.Trim().Equals("حق سرپرستی") && hagheSakhtiKar.Trim().Equals("حق سختی کار") && hagheMaskan.Trim().Equals("حق مسکن") && haghekharobar.Trim().Equals("بن کارگری") && hagheOlad.Trim().Equals("حق اولاد") && hagheJazb.Trim().Equals("حق جذب") && hagheGhaza.Trim().Equals("حق غذا") && hagheAyabZahab.Trim().Equals("حق ایاب و ذهاب") && hagheTaahol.Trim().Equals("حق تاهل")))
                        {
                            Helper.ShowMessage("شماره ستون ها به درستی انتخاب نشده");
                            groupBox2.Enabled = true;
                            return;
                        }
                    }


                    if (int.Parse(personnelColumnTextBox.Text) > range.Columns.Count ||
                        int.Parse(personnelColumnTextBox.Text) <= 0 ||
                        int.Parse(startDateTextBox.Text) > range.Columns.Count ||
                        int.Parse(startDateTextBox.Text) <= 0 ||
                        int.Parse(endDateTextBox.Text) > range.Columns.Count || int.Parse(endDateTextBox.Text) <= 0)
                    {
                        Helper.ShowMessage("شماره ستون صحیح نیست");
                        groupBox2.Enabled = true;
                        return;

                    }


                    String personnelNumber =
                        (range.Cells[startRow, int.Parse(personnelColumnTextBox.Text)] as Range)
                        ?.Value?.ToString();

                    String startDate = (range.Cells[startRow, int.Parse(startDateTextBox.Text)] as Range)
                        ?.Value?.ToString();

                    String EndDate = (range.Cells[startRow, int.Parse(endDateTextBox.Text)] as Range)
                        ?.Value?.ToString();

                    if (personnelNumber == null || startDate == null || EndDate == null)
                    {
                        Helper.ShowMessage("شماره ستون ها به درستی انتخاب نشده");
                        groupBox2.Enabled = true;
                        return;
                    }
                    if (!(personnelNumber.Trim().Equals("شماره پرسنلی") && startDate.Trim().Equals("تاریخ شروع") &&
                          EndDate.Trim().Equals("تاریخ پایان")))
                    {
                        Helper.ShowMessage("شماره ستون ها به درستی انتخاب نشده");
                        groupBox2.Enabled = true;
                        return;
                    }

                    var endRow = range.Rows.Count;
                    PersonnelList.Clear();


                    if (updateTypeCheckBox.Checked)
                    {

                        for (var row = startRow + 1; row <= endRow; row++)
                        {
                            Personel temp = new Personel()
                            {
                                PersonelNumbler = (range.Cells[row, int.Parse(personnelColumnTextBox.Text)] as Range)
                                    ?.Value?.ToString(),
                                StartDate = (range.Cells[row, int.Parse(startDateTextBox.Text)] as Range)
                                    ?.Value?.ToString(),
                                EndDate = (range.Cells[row, int.Parse(endDateTextBox.Text)] as Range)
                                    ?.Value?.ToString(),
                                Salary = (range.Cells[row, int.Parse(salaryTextBox.Text)] as Range)
                                    ?.Value?.ToString(),
                                ShiftPercent = (range.Cells[row, int.Parse(shiftPercentTextBox.Text)] as Range)
                                    ?.Value?.ToString(),
                                MablagheNobateKari = (range.Cells[row, int.Parse(mablagheNobateKariTextBox.Text)] as Range)
                                    ?.Value?.ToString(),
                                HagheSarparsti = (range.Cells[row, int.Parse(hagheSarparstiTextBox.Text)] as Range)
                                    ?.Value?.ToString(),
                                HagheJazb= (range.Cells[row, int.Parse(hagheJazbTextBox.Text)] as Range)
                                    ?.Value?.ToString(),
                                HagheSakhtiKar = (range.Cells[row, int.Parse(hagheSakhtiKarTextBox.Text)] as Range)
                                    ?.Value?.ToString(),
                                HagheMaskan = (range.Cells[row, int.Parse(hagheMaskanTextBox.Text)] as Range)
                                    ?.Value?.ToString(),
                                Haghekharobar = (range.Cells[row, int.Parse(haghekharobarTextBox.Text)] as Range)
                                    ?.Value?.ToString(),
                                HagheOlad = (range.Cells[row, int.Parse(hagheOladTextBox.Text)] as Range)
                                    ?.Value?.ToString(),
                                HagheGhaza = (range.Cells[row, int.Parse(hagheGhazaTextBox.Text)] as Range)
                                    ?.Value?.ToString(),
                                HagheAyabZahab = (range.Cells[row, int.Parse(hagheAyabZahabTextBox.Text)] as Range)
                                    ?.Value?.ToString(),
                                HagheTaahol = (range.Cells[row, int.Parse(hagheTaaholTextBox.Text)] as Range)
                                    ?.Value?.ToString()



                            };

                            temp.FullName = db.Personnels.SingleOrDefault(c => c.PersonnelNumber == temp.PersonelNumbler)?.FullName;

                            PersonnelList.Add(temp);
                        }
                    }
                    else
                    {
                        for (var row = startRow + 1; row <= endRow; row++)
                        {
                            Personel temp = new Personel()
                            {
                                PersonelNumbler = (range.Cells[row, int.Parse(personnelColumnTextBox.Text)] as Range)
                                    ?.Value?.ToString(),
                                StartDate = (range.Cells[row, int.Parse(startDateTextBox.Text)] as Range)
                                    ?.Value?.ToString(),
                                EndDate = (range.Cells[row, int.Parse(endDateTextBox.Text)] as Range)
                                    ?.Value?.ToString()

                            };

                            temp.FullName = db.Personnels.SingleOrDefault(c => c.PersonnelNumber == temp.PersonelNumbler)?.FullName;

                            PersonnelList.Add(temp);
                        }
                    }




                    personelBindingSource.DataSource = PersonnelList;
                    groupBox2.Enabled = true;
                    showDataButton.Enabled = showButton.Enabled =
                        personnelColumnTextBox.Enabled = startDateTextBox.Enabled = endDateTextBox.Enabled = selectButton.Enabled = salaryTextBox.Enabled = shiftPercentTextBox.Enabled = mablagheNobateKariTextBox.Enabled = hagheSarparstiTextBox.Enabled = hagheJazbTextBox.Enabled = hagheGhazaTextBox.Enabled = hagheAyabZahabTextBox.Enabled = hagheSakhtiKarTextBox.Enabled = hagheMaskanTextBox.Enabled = haghekharobarTextBox.Enabled = hagheOladTextBox.Enabled = false;
                    updateButton.Enabled = true;
                    updateOnlyLastPayRollButton.Enabled = true;


                    //}
                    //else
                    //{
                    //    Helper.ShowMessage(" را انتخاب نمایید .xls یا  .xlsx لطفا فقط فایل هایی با پسوند");
                    //}

                }
                else if (string.IsNullOrEmpty(openFileDialog1.FileName) )
                {

                    Helper.ShowMessage(" فایل مورد نظر را انتخاب نمایید");
                    groupBox2.Enabled = true;
                }
                else
                {
                    Helper.ShowMessage(" شماره ستون ها را وارد نمایید");
                    groupBox2.Enabled = true;

                }

            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {

            openFileDialog1.FileName = "";
            showDataButton.Enabled = showButton.Enabled=selectButton.Enabled = true;

            personnelColumnTextBox.Enabled = startDateTextBox.Enabled = endDateTextBox.Enabled = salaryTextBox.Enabled = shiftPercentTextBox.Enabled = mablagheNobateKariTextBox.Enabled = hagheSarparstiTextBox.Enabled = hagheJazbTextBox.Enabled = hagheSakhtiKarTextBox.Enabled = hagheMaskanTextBox.Enabled = haghekharobarTextBox.Enabled = hagheOladTextBox.Enabled  = hagheGhazaTextBox.Enabled = hagheAyabZahabTextBox.Enabled =hagheTaaholTextBox.Enabled= false;

            personnelColumnTextBox.Text = startDateTextBox.Text = endDateTextBox.Text = salaryTextBox.Text = shiftPercentTextBox.Text = mablagheNobateKariTextBox.Text = hagheSarparstiTextBox.Text = hagheJazbTextBox.Text = hagheGhazaTextBox.Text = hagheAyabZahabTextBox.Text = hagheSakhtiKarTextBox.Text = hagheMaskanTextBox.Text = hagheOladTextBox.Text = haghekharobarTextBox.Text = hagheTaaholTextBox.Text = String.Empty;



            PersonnelList.Clear();
            personelBindingSource.DataSource = null;
            updateButton.Enabled = false;
            updateOnlyLastPayRollButton.Enabled = false;
            updateTypeCheckBox.Checked = false;
            

        }

        private void updateTypeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (updateTypeCheckBox.Checked && openFileDialog1.FileName != string.Empty)
            {
                salaryTextBox.Enabled = shiftPercentTextBox.Enabled =
                    mablagheNobateKariTextBox.Enabled = hagheSarparstiTextBox.Enabled = hagheJazbTextBox.Enabled =
                        hagheSakhtiKarTextBox.Enabled = hagheMaskanTextBox.Enabled =
                        hagheTaaholTextBox.Enabled=
                            haghekharobarTextBox.Enabled = hagheOladTextBox.Enabled =  hagheGhazaTextBox.Enabled = hagheAyabZahabTextBox.Enabled =true;
            }
            else
                salaryTextBox.Enabled = shiftPercentTextBox.Enabled =
                    mablagheNobateKariTextBox.Enabled = hagheSarparstiTextBox.Enabled = hagheJazbTextBox.Enabled =
                        hagheSakhtiKarTextBox.Enabled = hagheMaskanTextBox.Enabled =
                        hagheTaaholTextBox.Enabled=
                            haghekharobarTextBox.Enabled = hagheOladTextBox.Enabled =hagheGhazaTextBox.Enabled = hagheAyabZahabTextBox.Enabled = false;
        }

        private void updateOnlyLastPayRollButton_Click(object sender, EventArgs e)
        {
            try
            {


                if(Helper.Confirm("مطمئن هستید؟"))
                if (PersonnelList.Count > 0 && personelBindingSource.List.Count > 0)

                {

                    //try
                    //{

                    //    foreach (Personel item in PersonnelList)
                    //    {
                    //        if (item.PersonelNumbler != null)
                    //        {


                    //            currentRow = item;

                    //            var personnel =
                    //                db.Personnels.SingleOrDefault(
                    //                    c => Convert.ToInt32(c.PersonnelNumber) == Convert.ToInt32(item.PersonelNumbler));


                    //            if (personnel.ContractTypeId == 4) //age estekhdam daem bashe
                    //            {
                    //                item.StartDate =
                    //                    Helper.GetPersianDate(Convert.ToDateTime(db.FiscalYears
                    //                        .SingleOrDefault(c => c.Status == 2).StartDate));
                    //                item.EndDate =
                    //                    Helper.GetPersianDate(Convert.ToDateTime(db.FiscalYears
                    //                        .SingleOrDefault(c => c.Status == 2).EndDate));
                    //            }

                    //        }

                    //    }
                    //}
                    //catch (Exception ex)
                    //{

                    //    Helper.ShowMessage(string.Format("اطلاعات پرسنل  [{0}]  در فایل اکسل ناقص می باشد", currentRow.PersonelNumbler));
                    //}


                    if (updateTypeCheckBox.Checked)
                    {

                        var document = new XElement("personels", from t in PersonnelList
                                                                 select new XElement("personel",
                                                                     new XElement("PersonelNumber", t.PersonelNumbler),
                                                                     new XElement("StartDate", t.StartDate),
                                                                     new XElement("EndDate", t.EndDate),
                                                                     new XElement("Salary", t.Salary),
                                                                     new XElement("ShiftPercent", t.ShiftPercent),
                                                                     new XElement("MablagheNobateKari", t.MablagheNobateKari),
                                                                     new XElement("HagheSarparsti", t.HagheSarparsti),
                                                                     new XElement("HagheSakhtiKar", t.HagheSakhtiKar),
                                                                     new XElement("HagheMaskan", t.HagheMaskan),
                                                                     new XElement("Haghekharobar", t.Haghekharobar),
                                                                     new XElement("HagheOlad", t.HagheOlad),
                                                                     new XElement("HagheJazb", t.HagheJazb),
                                                                     new XElement("HagheGhaza", t.HagheGhaza),
                                                                     new XElement("HagheAyabZahab", t.HagheAyabZahab),
                                                                     new XElement("HagheTaahol", t.HagheTaahol)
                                                                     ));


                        db.updateOnlyLastPayRoll(document);
                    }

                    else
                        {
                            var document = new XElement("personels", from t in PersonnelList
                                                                     select new XElement("personel",
                                                                         new XElement("PersonelNumber", t.PersonelNumbler),
                                                                         new XElement("StartDate", t.StartDate),
                                                                         new XElement("EndDate", t.EndDate)
                                                                        

                                                                         ));


                            db.updateOnlyLastPersonnelInfo(document);

                        }
                   
                   

                    Helper.ShowMessage("اطلاعات با موفقیت به روز رسانی شد");
                    db = new JamsazERPLiteDataClassesDataContext();

                    groupBox1.Enabled = true;

                }
                else
                {
                    Helper.ShowMessage("اطلاعاتی برای به روزرسانی وجود ندارد");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
