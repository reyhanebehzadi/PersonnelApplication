using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.PersonnlsApplication.UI.DialogForms;

namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    public partial class PersonnelLeaveReportForm : BasePersianForm
    {
        public PersonnelLeaveReportForm()
        {
            InitializeComponent();
        }
        private JamsazERPLiteDataClassesDataContext db;
        private List<LeaveRequestsReportResult> Temp = new List<LeaveRequestsReportResult>();
        private int PersonnelID;
        private void PersonnelLeaveReportForm_Load(object sender, EventArgs e)
        {
            string last;
            var current = DateTime.Now.ToPersianDate();
            string first = current.Insert(current.Length - 2, "01");
            first = first.Remove(first.Length - 2, 2);
            DatePicker.SelectedDateTime = ConvertPersianToEnglish(first);

            int month;
            var currentMonth = current.Substring(5, 2);
            month = int.Parse(currentMonth);

            if (month <= 6)
                last = current.Insert(current.Length - 2, "31");
            else
                if (month > 6 && month < 12)
                last = current.Insert(current.Length - 2, "30");
            else
                last = current.Insert(current.Length - 2, "29");

            last = last.Remove(last.Length - 2, 2);

            toDatePicker.SelectedDateTime = ConvertPersianToEnglish(last);
            LoadData();
        }

        public DateTime ConvertPersianToEnglish(string persianDate)
        {

            System.DateTime date = System.DateTime.Today;
            System.Globalization.PersianCalendar p = new System.Globalization.PersianCalendar();

            int year = p.GetYear(date);
            int m = p.GetMonth(date);
            int day = p.GetDayOfMonth(date);
            System.DateTime currentDate = new System.DateTime(year, m, day, p);

            System.String[] userDateParts = persianDate.Split(new[] { "/" }, System.StringSplitOptions.None);
            int userYear = int.Parse(userDateParts[0]);
            int userMonth = int.Parse(userDateParts[1]);
            int userDay = int.Parse(userDateParts[2]);
            System.DateTime userDate = new System.DateTime(userYear, userMonth, userDay, p);

            return userDate;
        }

        private void LoadData()
        {
            db = new JamsazERPLiteDataClassesDataContext();
            Temp = db.LeaveRequestsReport(User.FiscalYearID, null, DatePicker.SelectedDateTime, toDatePicker.SelectedDateTime).ToList();
            if (Temp.Count > 0)

                leaveRequestsReportResultBindingSource.DataSource = Temp.OrderBy(c => int.Parse(c.PersonnelNumbler));
            else
                leaveRequestsReportResultBindingSource.DataSource = null;



        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (toDatePicker.SelectedDateTime < DatePicker.SelectedDateTime)
            {
                Helper.ShowMessage("تاریخ را به درستی وارد نمایید");
                return;
            }


            if (endDatePicker.SelectedDateTime < fromDatePicker.SelectedDateTime)
            {
                Helper.ShowMessage("تاریخ را به درستی وارد نمایید");
                return;
            }

            if (PersonnelID != 0)
                Temp = db.LeaveRequestsReport(User.FiscalYearID, PersonnelID, DatePicker.SelectedDateTime, toDatePicker.SelectedDateTime).ToList();
            else
                Temp = db.LeaveRequestsReport(User.FiscalYearID, null, DatePicker.SelectedDateTime, toDatePicker.SelectedDateTime).ToList();

            if (Temp != null)
            {

                if (statusInGuardComboBox.SelectedIndex == 1)
                    Temp = Temp.Where(c => c.StatusInGuard == 1).ToList();
                else
                if (statusInGuardComboBox.SelectedIndex == 2)
                    Temp = Temp.Where(c => c.StatusInGuard == 0).ToList();

                if (statusInOfficialComboBox.SelectedIndex == 1)
                    Temp = Temp.Where(c => c.StatusInOfficial == true).ToList();
                else
                if (statusInOfficialComboBox.SelectedIndex == 2)
                    Temp = Temp.Where(c => c.StatusInOfficial != true).ToList();

                if (statusComboBox.SelectedIndex == 1)
                    Temp = Temp.Where(c => c.countApproval == c.CountApprover && c.Result == 1).ToList();
                else
                    if (statusComboBox.SelectedIndex == 2)
                    Temp = Temp.Where(c => c.countApproval == c.CountApprover && c.Result == 0).ToList();
                else
                    if (statusComboBox.SelectedIndex == 3)
                    Temp = Temp.Where(c => c.countApproval == 0).ToList();
                else
                    if (statusComboBox.SelectedIndex == 4)
                    Temp = Temp.Where(c => c.countApproval < c.CountApprover).ToList();

                if (isCanceledCheckBox.Checked)
                {
                    Temp = Temp.Where(c => c.IsCancel == true).ToList();
                }

                if (fromDatePicker.SelectedDateTime != null && endDatePicker.SelectedDateTime != null)
                {
                    Temp = Temp.Where(p => p.StartDate >= fromDatePicker.SelectedDateTime && p.EndDate <= endDatePicker.SelectedDateTime).ToList();
                }

                leaveRequestsReportResultBindingSource.DataSource = Temp.Count > 0 ? Temp.OrderBy(c => int.Parse(c.PersonnelNumbler)) : null;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            statusComboBox.SelectedIndex = statusInOfficialComboBox.SelectedIndex = statusInGuardComboBox.SelectedIndex = -1;
            PersonnelID = 0;
            isCanceledCheckBox.Checked = false;
            LoadData();
        }

        private void selectPersonnelButton_Click(object sender, EventArgs e)
        {
            PersonnelListForm personnelListForm = new PersonnelListForm(db = db) { IsActive = true };
            if (personnelListForm.ShowDialog() == DialogResult.OK)
            {
                PersonnelID = personnelListForm.Personnel.Id;
                personnelNameTextBox.Text = string.Format("{0} {1}", personnelListForm.Personnel.FirstName, personnelListForm.Personnel.LastName);
            }
        }

        private void leaveRequestsReportResultDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 15)
            {
                LeaveRequestsReportResult current = (LeaveRequestsReportResult)leaveRequestsReportResultBindingSource.Current;
                if (current != null)
                {
                    LeaveRequest leaveRequest = db.LeaveRequests.SingleOrDefault(c => c.ID == current.ID);
                    //if (leaveRequest.StatusInGuard != 1)
                    //{
                    //    Helper.ShowMessage("! مرخصی مورد نظر در نگهبانی تایید نشده ");
                    //    return;
                    //}
                    if (leaveRequest.StatusInOfficial != true)
                        if (Helper.Confirm(" آیا مایل به تایید مرخصی هستید؟"))
                        {
                            if (leaveRequest.StatusInGuard != 1)
                                leaveRequest.StatusInGuard = 1;

                            leaveRequest.StatusInOfficial = true;

                            db.SubmitChanges();
                        }

                }
                LoadData();
                showButton_Click(null, null);
            }
            else if (e.ColumnIndex == 12)
            {
                LeaveRequestsReportResult current =
                    (LeaveRequestsReportResult)
                    this.leaveRequestsReportResultBindingSource.Current;


                if (current == null)
                    return;

                LeaveRequestDetailApprovalProcessDialogForm leaveRequestDetailApprovalProcessDialogForm = new LeaveRequestDetailApprovalProcessDialogForm() { Current = current, db = db };

                leaveRequestDetailApprovalProcessDialogForm.ShowDialog();
            }
        }

        private void leaveRequestsReportResultDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in leaveRequestsReportResultDataGridView.Rows)

                if (Convert.ToBoolean(row.Cells[16].Value) == true)
                    row.DefaultCellStyle.BackColor = Color.Red;
            leaveRequestsReportResultDataGridView.Refresh();
        }

        private void تاییدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<LeaveRequestsReportResult> selected = new List<LeaveRequestsReportResult>();

            foreach (LeaveRequestsReportResult item in leaveRequestsReportResultBindingSource.List)
            {
                if (item.IsSelect == true)
                    selected.Add(item);
            }
            if (selected.Count > 0)
            {
                if (Helper.Confirm(" آیا مایل به تایید مرخصی هستید؟"))
                {

                    foreach (var item in selected)
                    {
                        LeaveRequest leaveRequest = db.LeaveRequests.SingleOrDefault(c => c.ID == item.ID);
                        if (leaveRequest.StatusInGuard != 1)
                            leaveRequest.StatusInGuard = 1;
                        leaveRequest.StatusInOfficial = true;
                    }
                    db.SubmitChanges();
                }
            }
            else
            {
                if (!(leaveRequestsReportResultBindingSource.Current is LeaveRequestsReportResult current)) return;
                if (Helper.Confirm(" آیا مایل به تایید مرخصی هستید؟"))
                {
                    LeaveRequest leaveRequest = db.LeaveRequests.SingleOrDefault(c => c.ID == current.ID);
                    if (leaveRequest.StatusInGuard != 1)
                        leaveRequest.StatusInGuard = 1;
                    leaveRequest.StatusInOfficial = true;

                    db.SubmitChanges();
                }
            }
            LoadData();
            showButton_Click(null, null);

        }

        private void printButton_Click(object sender, EventArgs e)
        {
            LeaveReportForm leaveReportForm = new LeaveReportForm(Temp);
            leaveReportForm.ShowDialog();
        }
    }
}
