using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.UI.DialogForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Microsoft.Reporting.WinForms;
using System.Globalization;

namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    public partial class PersonnelsFunctionReportForm : BasePersianForm
    {
        private JamsazERPLiteDataClassesDataContext db;
        private PwKaraDataContext pwKaraDB = new PwKaraDataContext();
        OriginalDepartment originalDepartment;

        public PersonnelsFunctionReportForm()
        {
            InitializeComponent();
        }

        

        private void PersonnelsFunctionReportForm_Load(object sender, EventArgs e)
        {
            db = new JamsazERPLiteDataClassesDataContext();
        }

        private void selectDepartmentButton_Click(object sender, EventArgs e)
        {
            OriginalDepartmentListDialogForm form = new OriginalDepartmentListDialogForm() { db = db };

            if (form.ShowDialog() == DialogResult.OK)
            {
                originalDepartment = form.SelectOriginalDepartment;
                departmentTextBox.Text = originalDepartment.Name;
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (originalDepartment == null)
            {
                Helper.Error("واحد سازمانی را مشخص نمایید");
                return;
            }

            if (dateDatePicker.SelectedDateTime == null)
            {
                Helper.Error("تاریخ را مشخص نمایید");
                return;
            }
            List<SelectChildDepartmentsPersonnelResult> list = new List<SelectChildDepartmentsPersonnelResult>();

            PersonnelListDialogForm form = new PersonnelListDialogForm() { OrginalDepartmentID = originalDepartment.ID };

            if (form.ShowDialog() == DialogResult.OK)            
                list = form.SelectdPersonnels;            

            List<string> personnelNumbersList = new List<string>();

            foreach (var result in list)
                personnelNumbersList.Add(result.PersonnelNumber);

            string personnelNumbers = string.Join(",", personnelNumbersList.ToArray());
            string year = dateDatePicker.SelectedDateTime.Value.Year.ToString();
            string month = dateDatePicker.SelectedDateTime.Value.Month.ToString();
            string day = dateDatePicker.SelectedDateTime.Value.Day.ToString();

            string startDate = year + "-" + month + "-" + day;
            DateTime sDate = dateDatePicker.SelectedDateTime.GetValueOrDefault();
            DateTime eDate = sDate.AddDays(6);

            string persianStartDate = ToPersianDateString(sDate);
            string persianEndDate = ToPersianDateString(eDate);

            List<GetTaradodInWeekResult> getTradodInWeekList = pwKaraDB.GetTaradodInWeek(startDate, personnelNumbers).ToList();

            var list2 = getTradodInWeekList;

            double totalDays = list.Count() * 7;
            double countDays = pwKaraDB.GetTotalDaysForTaradodInWeek(startDate, personnelNumbers).First().TotalDays.GetValueOrDefault();

            
            string percent = Math.Round(((countDays * 100) / totalDays), 0).ToString() + "%";


            List<EmployeeData> EmployeeDatas = new List<EmployeeData>(from t1 in list
                                                                      join t2 in getTradodInWeekList on t1.PersonnelNumber equals t2.Emp_no.ToString()
                                                                      select new EmployeeData
                                                                      {
                                                                          PersonnelID = t1.PersonnelID,
                                                                          PersonnelNumber = t1.PersonnelNumber,
                                                                          FullName = t1.FullName,
                                                                          Position = t1.Position,
                                                                          Saturday = t2.Saturday.GetValueOrDefault(),
                                                                          Sunday = t2.Sunday.GetValueOrDefault(),
                                                                          Monday = t2.Monday.GetValueOrDefault(),
                                                                          TuseDay = t2.TuseDay.GetValueOrDefault(),
                                                                          WendsDay = t2.WendsDay.GetValueOrDefault(),
                                                                          Tuersday = t2.Tuersday.GetValueOrDefault(),
                                                                          Friday = t2.Friday.GetValueOrDefault()
                                                                      });

            EmployeeDataBindingSource.DataSource = EmployeeDatas;
            ReportParameter departmentName = new ReportParameter("DepartmentName", originalDepartment.Name);
            ReportParameter startDateTime = new ReportParameter("StartDate", persianStartDate);
            ReportParameter endDateTime = new ReportParameter("EndDate", persianEndDate);
            ReportParameter totalDay = new ReportParameter("TotalDays", totalDays.ToString());
            ReportParameter countDay = new ReportParameter("CountDays", countDays.ToString());
            ReportParameter percentValue = new ReportParameter("PercentValue", percent);
            reportViewer1.LocalReport.SetParameters(new[] { departmentName,startDateTime,endDateTime,totalDay,countDay,percentValue });
            reportViewer1.RefreshReport();
        }

        public DateTime ToGeorgianDateTime( string persianDate)
        {
            int year = Convert.ToInt32(persianDate.Substring(0, 4));
            int month = Convert.ToInt32(persianDate.Substring(5, 2));
            int day = Convert.ToInt32(persianDate.Substring(8, 2));
            DateTime georgianDateTime = new DateTime(year, month, day, new PersianCalendar());
            return georgianDateTime;
        }

        public  string ToPersianDateString( DateTime georgianDate)
        {
            PersianCalendar persianCalendar = new PersianCalendar();

            string year = persianCalendar.GetYear(georgianDate).ToString();
            string month = persianCalendar.GetMonth(georgianDate).ToString().PadLeft(2, '0');
            string day = persianCalendar.GetDayOfMonth(georgianDate).ToString().PadLeft(2, '0');
            string persianDateString = string.Format("{0}/{1}/{2}", year, month, day);
            return persianDateString;
        }


    }
}
