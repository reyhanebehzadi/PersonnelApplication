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
    public partial class MissionReportForm : BasePersianForm
    {
        public MissionReportForm()
        {
            InitializeComponent();
        }
        private JamsazERPLiteDataClassesDataContext db;
        private List<PersonnelMissionReportResult> List = new List<PersonnelMissionReportResult>();
        private List<PersonnelMissionReportResult> printList = new List<PersonnelMissionReportResult>();
        private int personnelID;
        private void MissionReportForm_Load(object sender, EventArgs e)
        {
            DatePicker.SelectedDateTime = toDatePicker.SelectedDateTime = DateTime.Now;
            LoadData();
        }
        private void LoadData()
        {
            db = new JamsazERPLiteDataClassesDataContext();
            List = db.PersonnelMissionReport(User.FiscalYearID, DatePicker.SelectedDateTime, toDatePicker.SelectedDateTime).Where(c => c.Result == 1).OrderByDescending(d => d.Date).ToList();
            personnelMissionReportResultBindingSource.DataSource = List.Count > 0 ? List.OrderByDescending(c => c.Date) : null;
        }


        private void showButton_Click(object sender, EventArgs e)
        {

            List = db.PersonnelMissionReport(User.FiscalYearID, DatePicker.SelectedDateTime, toDatePicker.SelectedDateTime).OrderByDescending(d => d.Date).ToList();
            if (List.Count > 0)
            {
                if (statusInOfficialComboBox.SelectedIndex == 1)
                    List = List.Where(c => c.StatusInOfficial == true).ToList();
                else
               if (statusInOfficialComboBox.SelectedIndex == 2)
                    List = List.Where(c => c.StatusInOfficial != true).ToList();

                if (statusInGuardComboBox.SelectedIndex == 1)
                    List = List.Where(c => c.StatusInGuard == true).ToList();
                else
               if (statusInGuardComboBox.SelectedIndex == 2)
                    List = List.Where(c => c.StatusInGuard != true).ToList();



                if (statusComboBox.SelectedIndex == 1)
                    List = List.Where(c => c.countApproval == c.CountApprover && c.Result == 1).ToList();
                else
                   if (statusComboBox.SelectedIndex == 2)
                    List = List.Where(c => c.countApproval == c.CountApprover && c.Result == 0).ToList();
                else
                   if (statusComboBox.SelectedIndex == 3)
                    List = List.Where(c => c.countApproval == 0).ToList();
                else
                   if (statusComboBox.SelectedIndex == 4)
                    List = List.Where(c => c.countApproval < c.CountApprover && c.countApproval > 0).ToList();

                if (isCanceledCheckBox.Checked)
                    List = List.Where(c => c.IsCancel == true).ToList();
            }


            if (personnelID != 0)
            {
                personnelMissionReportResultBindingSource.DataSource = List.Where(c => c.PersonnelID == personnelID).Count() > 0 ? List.Where(c => c.PersonnelID == personnelID).OrderBy(c => int.Parse(c.PersonnelNumber)) : null;
                printList = List.Where(c => c.PersonnelID == personnelID).Count() > 0 ? List.Where(c => c.PersonnelID == personnelID).OrderBy(c => int.Parse(c.PersonnelNumber)).ToList() : null;
            }


            else
            {
                personnelMissionReportResultBindingSource.DataSource = List.Count > 0 ? List.OrderBy(c => int.Parse(c.PersonnelNumber)) : null;
                printList= List.Count > 0 ? List.OrderBy(c => int.Parse(c.PersonnelNumber)).ToList() : null;

            }



        }



        private void selectPersonnelButton_Click(object sender, EventArgs e)
        {
            PersonnelListForm personnelListForm = new PersonnelListForm(db = db) { IsActive = true };
            if (personnelListForm.ShowDialog() == DialogResult.OK)
            {
                personnelNameTextBox.Text = string.Format("{0} {1}", personnelListForm.Personnel.FirstName, personnelListForm.Personnel.LastName);
                personnelID = personnelListForm.Personnel.Id;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            personnelID = 0;
            personnelNameTextBox.Text = string.Empty;
            statusInOfficialComboBox.SelectedIndex = statusInGuardComboBox.SelectedIndex = -1;
            DatePicker.SelectedDateTime = toDatePicker.SelectedDateTime = null;
            isCanceledCheckBox.Checked = false;
            LoadData();
        }

        private void personnelMissionReportResultDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 19)
            {
                PersonnelMissionReportResult current = (PersonnelMissionReportResult)personnelMissionReportResultBindingSource.Current;
                if (current != null)
                {
                    Mission mission = db.Missions.SingleOrDefault(c => c.ID == current.ID);
                    //if (mission.StatusInGuard != true)
                    //{
                    //    Helper.ShowMessage(" ! مأموریت مورد نظر در نگهبانی تایید نشده ");
                    //    return;
                    //}
                    if (mission.StatusInOfficial != true)
                        if (Helper.Confirm(" آیا مایل به تایید مأموریت هستید؟"))
                            if (mission.FinalApproval == true)

                            {
                                //if (mission.StatusInGuard != true)
                                //    mission.StatusInGuard = true;

                                mission.StatusInOfficial = true;

                                db.SubmitChanges();
                            }
                            else
                            {
                                Helper.ShowMessage("ماموریت مورد نظر تایید نهایی نشده");
                                return;
                            }

                }
                db = new JamsazERPLiteDataClassesDataContext();
                showButton_Click(null, null);
            }
        }

        private void personnelMissionReportResultDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in personnelMissionReportResultDataGridView.Rows)

                if (Convert.ToBoolean(row.Cells[20].Value) == true)
                    row.DefaultCellStyle.BackColor = Color.Red;
            personnelMissionReportResultDataGridView.Refresh();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            MissionReportPrintForm missionReportPrintForm = new MissionReportPrintForm(printList);
            missionReportPrintForm.ShowDialog();
        }
    }
}
