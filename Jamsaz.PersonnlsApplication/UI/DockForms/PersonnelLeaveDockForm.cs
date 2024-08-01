using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.PersonnlsApplication.BusinessObjects.Definitions;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class PersonnelLeaveDockForm : BasePersianForm
    {
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        private DateTime firstDayOfMonth;
        private int month;
        private List<GetLeavesResult> leavesResults;
        private PersianCalendar calendar = new PersianCalendar();

        public PersonnelLeaveDockForm()
        {
            InitializeComponent();
        }

        private void PersonnelLeaveDockForm_Load(object sender, EventArgs e)
        {
            datePicker.SelectedDateTime = DateTime.Now;

            acivityDepartmentBindingSource.DataSource = db.AcivityDepartments.Where(c => c.ID == 14 || c.ParentID == 14 || c.ID == 13);

            LoadData();
        }

        private void LoadData()
        {
            if (activityDepartmentComboBox.SelectedValue != null)
            {
                db = new JamsazERPLiteDataClassesDataContext();

                leavesResults = db.GetLeaves(month > 6 ? 30 : 31, firstDayOfMonth,
                                             (int)activityDepartmentComboBox.SelectedValue).OrderBy(
                                                 c => Convert.ToInt32(c.PersonnelNumber)).ToList();

                int index = 1;

                leavesResults.Where(c => c.ShiftType == (int)ShiftType.Static).OrderBy(c => Convert.ToInt32(c.PersonnelNumber)).ToList().ForEach(c => c.Index = index++);

                index = 1;

                leavesResults.Where(c => c.ShiftID == 1 && c.ShiftType != (int)ShiftType.Static).OrderBy(c => Convert.ToInt32(c.PersonnelNumber)).ToList().ForEach(c => c.Index = index++);

                index = 1;

                leavesResults.Where(c => c.ShiftID == 2 && c.ShiftType != (int)ShiftType.Static).OrderBy(c => Convert.ToInt32(c.PersonnelNumber)).ToList().ForEach(c => c.Index = index++);

                index = 1;

                leavesResults.Where(c => c.ShiftID == 3 && c.ShiftType != (int)ShiftType.Static).OrderBy(c => Convert.ToInt32(c.PersonnelNumber)).ToList().ForEach(c => c.Index = index++);

                getLeavesResultBindingSource.DataSource = leavesResults.OrderBy(c => c.Shift).ThenBy(c => c.Index);

                if (month > 6)
                    getLeavesResultDataGridView.Columns["D31Column"].Visible = false;
                else
                    getLeavesResultDataGridView.Columns["D31Column"].Visible = true;
            }
        }

        private void datePicker_SelectedDateTimeChanged(object sender, EventArgs e)
        {
            DateTime date = datePicker.SelectedDateTime.Value.Date;

            month = calendar.GetMonth(date);

            firstDayOfMonth = calendar.ToDateTime(calendar.GetYear(date), calendar.GetMonth(date), 1, 0, 0, 0, 0);

            LoadData();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            getLeavesResultBindingSource.DataSource = leavesResults.Where(c => c.PersonnelNumber.Contains(personnelNumberTextBox.Text));
        }

        private void personnelNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                searchButton_Click(null, null);
            else if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void activityDepartmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}