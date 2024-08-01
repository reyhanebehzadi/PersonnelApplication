using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Jamsaz.Common;
using Jamsaz.Common.UI.DialogForms;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.PersonnlsApplication.Classes;
using Jamsaz.PersonnlsApplication.Definitions;
using Jamsaz.PersonnlsApplication.Properties;
using Jamsaz.PersonnlsApplication.UI.DialogForms;
using Janus.Windows.GridEX;
using Stimulsoft.Report;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class PersonnelSearchForm : BasePersianForm
    {
        public PersonnelSearchForm()
        {
            InitializeComponent();
            tableLayoutPanel.RowStyles[1].Height = 30;
            hideMiddlePanelButton.ImageIndex = 6;
            //Jamsaz.Common.UserAuthenticationManager.SetAccessContorls.ModifyControl(this);
            contractFieldsComboBox.DataSource = enumFieldsContract.getItems();
        }
        bool hideTopPanel = true;
        bool hideMiddlePanel;
        Point clickPointShowContextMenuStripButton = new Point();
        readonly JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext(Settings.Default.JamsazERPLiteConnectionString);
        List<vwMainPersonnely_SearchAdvancedResult> resultSearchAdvenceds = new List<vwMainPersonnely_SearchAdvancedResult>();
        private void hideTopPanelButton_Click(object sender, EventArgs e)
        {
            if (hideTopPanel) { tableLayoutPanel.RowStyles[0].Height = 30; hideTopPanel = false; hideTopPanelButton.ImageIndex = 6; topPanel.AutoScroll = false; }
            else { tableLayoutPanel.RowStyles[0].Height = 109; hideTopPanel = true; hideTopPanelButton.ImageIndex = 5; topPanel.AutoScroll = true; }

        }

        private void hideMiddlePanelButton_Click(object sender, EventArgs e)
        {
            if (hideMiddlePanel) { tableLayoutPanel.RowStyles[1].Height = 30; hideMiddlePanel = false; hideMiddlePanelButton.ImageIndex = 6; }
            else { tableLayoutPanel.RowStyles[1].Height = 176; hideMiddlePanel = true; hideMiddlePanelButton.ImageIndex = 5; }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SubSearch();
        }
        private void SubSearch()
        {
            try
            {
                errorProvider1.Clear();
                //   chkSelectToallRecord.Checked = false;
                int? isActive = null;
                int? personnelStatus;
                int? contractContractTypeId;
                int? organizationPostId=null;
                var getIssueNo = string.IsNullOrEmpty(issueNoTextBox.Text) ? null : issueNoTextBox.Text;

                int? getPerssonelNumber;
                if (string.IsNullOrEmpty(personnelNumberTextBox.Text))
                    getPerssonelNumber = null;
                else
                    getPerssonelNumber = int.Parse(personnelNumberTextBox.Text);

                var brithDateStart = brithDateStartDatePicker.SelectedDateTime == null ? "1900/01/01" : brithDateStartDatePicker.SelectedDateTime.Value.Date.ToShortDateString();

                var brithDateEnd = brithDateEndDatePicker.SelectedDateTime == null ? "3000/01/01" : brithDateEndDatePicker.SelectedDateTime.Value.Date.ToShortDateString();

                var currentContractEndDateStart = "1900/01/01";
                var currentContractEndDateEnd = "3000/01/01";


                var currentContractStartDateStart = "1900/01/01";
                var currentContractStartDateEnd = "3000/01/01";

                var firstContractStartDateStart = "1900/01/01";
                var firstContractStartDateEnd = "3000/01/01";

                switch (contractFieldsComboBox.SelectedIndex)
                {
                    case 0:
                        currentContractEndDateStart = GetDate("start");
                        currentContractEndDateEnd = GetDate("end");
                        break;
                    case 1:
                        currentContractStartDateStart = GetDate("start");
                        currentContractStartDateEnd = GetDate("end");
                        break;
                    case 2:
                        firstContractStartDateStart = GetDate("start");
                        firstContractStartDateEnd = GetDate("end");
                        break;
                }
                string getValFemaleMan = "";

                if (manRadioButton.Checked)
                    getValFemaleMan = "مرد";

                if (femaleRadioButton.Checked)
                    getValFemaleMan = "زن";

                if (employeRadioButton.Checked)
                    isActive = 1;

                if (dismissRadioButton.Checked)
                    isActive = 0;

                if (employRadioButton.Checked)
                    personnelStatus = (int)BusinessObjects.Definitions.PersonnelStatus.employe;
                else if (dismissRadioButton1.Checked)
                    personnelStatus = (int)BusinessObjects.Definitions.PersonnelStatus.dismiss;
                else if (specialRadioButton.Checked)
                    personnelStatus = (int)BusinessObjects.Definitions.PersonnelStatus.Special;
                else if (RetiredRadioButton.Checked)
                    personnelStatus = (int)BusinessObjects.Definitions.PersonnelStatus.Retired;
                else
                    personnelStatus = null;

                if (contractTypeComboBox.SelectedIndex == -1)
                    contractContractTypeId = null;
                else
                    contractContractTypeId = ((ContractType)contractTypeBindingSource.Current).Id;
                if (organizationPostComboBox.SelectedValue != null)
                    organizationPostId = (int)organizationPostComboBox.SelectedValue;

     var department = departmentComboBox.SelectedItem as Department;
                var query =
                    db.vwMainPersonnely_SearchAdvanced(NameTextBox.Text, lastNameTextBox.Text
                        ,getPerssonelNumber, getIssueNo, getValFemaleMan, fatherNameTextBox.Text, isActive,
                        personnelStatus, contractContractTypeId,
                        brithDateStart, brithDateEnd, currentContractEndDateStart
                        , currentContractEndDateEnd, currentContractStartDateStart, currentContractStartDateEnd,
                        firstContractStartDateStart, firstContractStartDateEnd,organizationPostId).AsQueryable();
               

                if (department != null && department.Code != "-1")
                {
                    var chDepartments = departmentComboboxChilds.SelectedItem as SelectAllChildDepartmentsResult;
                    if (chDepartments != null && chDepartments.Code == "-1")
                    {
                        query = query.Where(x => x.DepartmentId == department.Id);
                    }
                    else if (chDepartments != null)
                    {
                        query = query.Where(x => x.DepartmentChildOrginalId == chDepartments.OriginalDepartmentID);
                    }
                }

                resultSearchAdvenceds = query.ToList();

                vwMainPersonnelySearchAdvancedResultBindingSource.DataSource = resultSearchAdvenceds;
                //.OrderBy(c => int.Parse(c.PersonnelNumber));
                personnelCounterTextBox.Text = searchResultDataGridView.RowCount.ToString();
                //position grid row
            }
            catch (Exception exp)
            {
                if (exp.GetType() == typeof(SqlException))
                    MessageBox.Show(exp.Message);//SendMessageToNofityIcon.MessageToShowBalloon("خطا در ارتباط با بانک اطلاعاتی", " اتصال به بانک اطلاعاتی برقرار نیست " + "\n لطفا مشکل را به مسئول شبکه گزارش دهید\n ");
                else
                    MessageBox.Show(exp.Message);
            }
        }

        private string GetDate(string startEnd)
        {
            if (startEnd == "start")
            {
                if (contractStartDatePicker.SelectedDateTime == null)
                    return "1900/01/01";
                return //contractStartDatePicker.SelectedDateTime.Value.Date.ToShortDateString();
                        string.Format("{0}/{1}/{2}", contractStartDatePicker.SelectedDateTime.Value.Date.Month, contractStartDatePicker.SelectedDateTime.Value.Date.Day, contractStartDatePicker.SelectedDateTime.Value.Date.Year);
            }

            if (contractEndDatePicker.SelectedDateTime == null)
                return "3000/01/01";
            return //contractEndDatePicker.SelectedDateTime.Value.Date.ToShortDateString();
            string.Format("{0}/{1}/{2}", contractEndDatePicker.SelectedDateTime.Value.Date.Month, contractEndDatePicker.SelectedDateTime.Value.Date.Day, contractEndDatePicker.SelectedDateTime.Value.Date.Year);
        }

        private void clearControlsButton_Click(object sender, EventArgs e)
        {
            personnelNumberTextBox.Text = string.Empty;
            NameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            issueNoTextBox.Text = string.Empty;
            fatherNameTextBox.Text = string.Empty;
            //brithDateEndDatePicker.IsNull = true;
            //brithDateStartDatePicker.IsNull = true;
            //contractStartDatePicker.IsNull = true;
            //contractEndDatePicker.IsNull = true;
            BothRadioButton.Checked = true;
            employeRadioButton.Checked = true;
            organizationPostComboBox.SelectedIndex = -1;
            SubSearch();
            personnelCounterTextBox.Text = searchResultDataGridView.RowCount.ToString();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Keys valKeys = (Keys)(short)keyData;
            if (valKeys == Keys.Enter)
                SubSearch();
            if (valKeys == Keys.Escape)
            {
                clearControlsButton_Click(null, null);
                personnelNumberTextBox.Focus();
            }
            if (valKeys == Keys.F2)
                editPersonnelButton_Click(null, null);

            if (valKeys == Keys.F9)
                payrollForCurrentPersonnelToolStripMenuItem_Click(null, null);

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void showContextMenuStripButton_Click(object sender, EventArgs e)
        {
            showContextMenuStripButton.ContextMenuStrip.Show(showContextMenuStripButton, new Point(clickPointShowContextMenuStripButton.X
                , clickPointShowContextMenuStripButton.Y), ToolStripDropDownDirection.AboveLeft);
        }

        private void PersonnelSearchForm_Load(object sender, EventArgs e)
        {
            var lst = new List<Department> { new Department { Code = "-1", Name = "همه واحد ها" } };
            lst.AddRange(
                db.Departments.Join(db.DepartmentVersions, d => d.DepartmentVersionID, dv => dv.ID,
                    (d, dv) => new { d, dv }).Where(x => x.dv.IsActive.Value && !x.d.Code.Contains("-")).Select(x => x.d).ToList());
            departmentBindingSource.DataSource = lst;
            User.AuthenticationManager.SetFormControlPropertiesByAvailableActions(Name, this);

            employRadioButton.Checked = true;
            contractTypeBindingSource.DataSource = db.ContractTypes.ToList();
            contractTypeComboBox.SelectedIndex = -1;
            organizationPostBindingSource.DataSource = db.OrganizationPosts;
            organizationPostComboBox.SelectedIndex = -1;
        }
        private int RowSelected(out string personnelsNumbers)
        {
            int rowSelectedCounter = 0;
            personnelsNumbers = string.Empty;
            foreach (var row in searchResultDataGridView.GetRows())
            {

                if (row.Cells[8].Value != null)
                {
                    bool result;
                    bool.TryParse(row.Cells[8].Value.ToString(), out result);

                    if (result)
                    {
                        rowSelectedCounter = +1;
                        personnelsNumbers = personnelsNumbers + "," + row.Cells[1].Value;
                    }
                }
            }

            return rowSelectedCounter;
        }

        private void showContextMenuStripButton_MouseClick(object sender, MouseEventArgs e)
        {
            Point clickPointShowContextMenuStripButton = new Point(e.X, e.Y);
        }

        private void editPersonnelButton_Click(object sender, EventArgs e)
        {
            if (vwMainPersonnelySearchAdvancedResultBindingSource.Current != null)
            {
                vwMainPersonnely_SearchAdvancedResult resultSearchAdvenced = (vwMainPersonnely_SearchAdvancedResult)vwMainPersonnelySearchAdvancedResultBindingSource.Current;

                EditesPeronnelDialogForm editesPersonnelDialogForm = new EditesPeronnelDialogForm(resultSearchAdvenced.Id, true);

                editesPersonnelDialogForm.ShowDialog();
            }
        }

        private void personnelFingerPrintsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vwMainPersonnely_SearchAdvancedResult resultSearchAdvenced = (vwMainPersonnely_SearchAdvancedResult)vwMainPersonnelySearchAdvancedResultBindingSource.Current;

            if (resultSearchAdvenced != null)
            {
                PersonnelFingerPrintsDialogForm personnelFingerPrintsDialogForm = new PersonnelFingerPrintsDialogForm(resultSearchAdvenced.Id);
                if (personnelFingerPrintsDialogForm.ShowDialog() == DialogResult.OK)
                {

                }
            }

        }

        private void personnelEducationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vwMainPersonnely_SearchAdvancedResult resultSearchAdvenced = (vwMainPersonnely_SearchAdvancedResult)vwMainPersonnelySearchAdvancedResultBindingSource.Current;

            if (resultSearchAdvenced != null)
            {
                PersonnelEducationDialogForm personnelEducationDialogForm = new PersonnelEducationDialogForm(resultSearchAdvenced.Id);
                if (personnelEducationDialogForm.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void selectToAllRecordCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            //if (searchResultDataGridView.RowCount != 0)
            //{
            //    if (selectedPersonnelByRange.Checked)
            //       foreach (DataGridViewRow  row in searchResultDataGridView.Rows)
            //       {
            //           if (!string.IsNullOrEmpty(row.Cells[7].Value.ToString()))
            //               row.Cells[8].Value = true;
            //       }
            //    else
            //        foreach (DataGridViewRow row in searchResultDataGridView.Rows)
            //        {
            //            if (!string.IsNullOrEmpty(row.Cells[7].Value.ToString()))
            //                row.Cells[8].Value = false;
            //        }
            //}
        }

        private void searchResultDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                if (string.IsNullOrEmpty(searchResultDataGridView.GetRows()[e.RowIndex].Cells[7].Value.ToString()))
                    e.Cancel = true;
            }
        }

        private void printCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string documentPath = Settings.Default.PathTemplate + "PersonnelCard.Doc";

            WordManager wordmanager = new WordManager();
            int? currentPersonnelNumber = null;

            vwMainPersonnely_SearchAdvancedResult resultSearchAdvenced = (vwMainPersonnely_SearchAdvancedResult)vwMainPersonnelySearchAdvancedResultBindingSource.Current;

            if (resultSearchAdvenced != null)
                currentPersonnelNumber = Helper.GetInt(resultSearchAdvenced.PersonnelNumber);

            selectedPersonnelNumberWithRangeDialogForm selectedPersonnelNumberWithRangeDialogForm = new selectedPersonnelNumberWithRangeDialogForm(currentPersonnelNumber);
            if (selectedPersonnelNumberWithRangeDialogForm.ShowDialog() == DialogResult.OK)
            {
                wordmanager.showdocument(documentPath, 1, selectedPersonnelNumberWithRangeDialogForm.GetFrom, selectedPersonnelNumberWithRangeDialogForm.GetTo, selectedPersonnelNumberWithRangeDialogForm.PersonnelNumbers, DateTime.Now, null, DateTime.Now);
            }
        }

        private void printedCardBarcodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string documentPath = Settings.Default.PathTemplate + "tempbarcode.doc";

            WordManager wordmanager = new WordManager();
            int? currentPersonnelNumber = null;

            vwMainPersonnely_SearchAdvancedResult resultSearchAdvenced = (vwMainPersonnely_SearchAdvancedResult)vwMainPersonnelySearchAdvancedResultBindingSource.Current;

            if (resultSearchAdvenced != null)
                currentPersonnelNumber = Helper.GetInt(resultSearchAdvenced.PersonnelNumber);
            selectedPersonnelNumberWithRangeDialogForm selectedPersonnelNumberWithRangeDialogForm = new selectedPersonnelNumberWithRangeDialogForm(currentPersonnelNumber);
            if (selectedPersonnelNumberWithRangeDialogForm.ShowDialog() == DialogResult.OK)
            {
                wordmanager.showdocument(documentPath, 1, selectedPersonnelNumberWithRangeDialogForm.GetFrom, selectedPersonnelNumberWithRangeDialogForm.GetTo, selectedPersonnelNumberWithRangeDialogForm.PersonnelNumbers, DateTime.Now.Date, null, DateTime.Now);
            }

        }

        private void previewFormContractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Settings.Default.PathTemplate;
                string documentPath = path + "TempContract.doc";
                WordManager wordmanager = new WordManager();
                int? currentPersonnelNumber = null;

                vwMainPersonnely_SearchAdvancedResult resultSearchAdvenced = (vwMainPersonnely_SearchAdvancedResult)vwMainPersonnelySearchAdvancedResultBindingSource.Current;

                if (resultSearchAdvenced != null)
                    currentPersonnelNumber = Helper.GetInt(resultSearchAdvenced.PersonnelNumber);
                selectedPersonnelNumberWithRangeDialogForm selectedPersonnelNumberWithRangeDialogForm = new selectedPersonnelNumberWithRangeDialogForm(currentPersonnelNumber);
                if (selectedPersonnelNumberWithRangeDialogForm.ShowDialog() == DialogResult.OK)
                {
                    int? isInFactory = null;
                    if (!User.AuthenticationManager.IsActionAvailable("PersonnelSearchForm-HeadOfficeSalary"))
                        isInFactory = 1;

                    wordmanager.showdocument(documentPath, 2, selectedPersonnelNumberWithRangeDialogForm.GetFrom, selectedPersonnelNumberWithRangeDialogForm.GetTo, selectedPersonnelNumberWithRangeDialogForm.PersonnelNumbers, selectedPersonnelNumberWithRangeDialogForm.EffectiveDate.Date, isInFactory, DateTime.Now);
                }
            }
            catch (Exception ex)
            {

                ex.ToString();
            }

        }

        private void decreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string documentPath = Settings.Default.PathTemplate + "tempDecree.doc";
            WordManager wordmanager = new WordManager();
            int? currentPersonnelNumber = null;

            vwMainPersonnely_SearchAdvancedResult resultSearchAdvenced = (vwMainPersonnely_SearchAdvancedResult)vwMainPersonnelySearchAdvancedResultBindingSource.Current;

            if (resultSearchAdvenced != null)
                currentPersonnelNumber = Helper.GetInt(resultSearchAdvenced.PersonnelNumber);

            selectedPersonnelNumberWithRangeDialogForm selectedPersonnelNumberWithRangeDialogForm = new selectedPersonnelNumberWithRangeDialogForm(currentPersonnelNumber);
            if (selectedPersonnelNumberWithRangeDialogForm.ShowDialog() == DialogResult.OK)
            {
                int? isInFactory = null;
                if (!User.AuthenticationManager.IsActionAvailable("PersonnelSearchForm-HeadOfficeSalary"))
                    isInFactory = 1;

                wordmanager.showdocument(documentPath, 3, selectedPersonnelNumberWithRangeDialogForm.GetFrom, selectedPersonnelNumberWithRangeDialogForm.GetTo, selectedPersonnelNumberWithRangeDialogForm.PersonnelNumbers, selectedPersonnelNumberWithRangeDialogForm.EffectiveDate.Date, isInFactory, DateTime.Now);
            }
        }

        private void personnelReportByInSuranceNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrsonnelReportByInSuranceNoReportForm prsonnelReportByInSuranceNoReportForm =
                new PrsonnelReportByInSuranceNoReportForm(resultSearchAdvenceds) { MdiParent = MainForm.mainParentForm };
            prsonnelReportByInSuranceNoReportForm.Show();
        }

        private void reportPersonnelProfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personnelProfilesReportForm personnelProfilesReportForm =
                new personnelProfilesReportForm(resultSearchAdvenceds) { MdiParent = MainForm.mainParentForm };
            personnelProfilesReportForm.Show();
        }

        private void payrollForCurrentPersonnelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vwMainPersonnely_SearchAdvancedResult current = (vwMainPersonnely_SearchAdvancedResult)vwMainPersonnelySearchAdvancedResultBindingSource.Current;

            if (current != null)
            {
                Personnel personnel = db.Personnels.Single(c => c.Id == current.Id);

                //HeadOffice
                if (personnel.IsInFactory == 2)
                {
                    if (User.AuthenticationManager.IsActionAvailable("PersonnelSearchForm-HeadOfficeSalary"))
                    {
                        PersonnelPayRollDialogForm personnelPayRollDialogForm = new PersonnelPayRollDialogForm { Current = personnel };

                        personnelPayRollDialogForm.ShowDialog();
                    }
                    else
                    {
                        MessageDialogForm messageDialogForm = new MessageDialogForm();

                        messageDialogForm.ShowDialog();
                    }
                }
                else
                {
                    PersonnelPayRollDialogForm personnelPayRollDialogForm = new PersonnelPayRollDialogForm { Current = personnel };

                    personnelPayRollDialogForm.ShowDialog();
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (Helper.Confirm("آیا مایل به حذف پرسنل جاری هستید؟"))
            {
                try
                {

                    vwMainPersonnely_SearchAdvancedResult resultSearchAdvenced = (vwMainPersonnely_SearchAdvancedResult)vwMainPersonnelySearchAdvancedResultBindingSource.Current;
                    if (resultSearchAdvenced != null)
                    {
                        Personnel personnel = db.Personnels.Single(c => c.Id == resultSearchAdvenced.Id);
                        db.Personnels.DeleteOnSubmit(personnel);
                        db.SubmitChanges();
                        MessageBox.Show(@"حذف پرسنل با موفقیت انجام شد ");
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
        }

        private void insertPersonnelButton_Click(object sender, EventArgs e)
        {
            EditesPeronnelDialogForm editesPersonnelDialogForm = new EditesPeronnelDialogForm(0, false);

            if (editesPersonnelDialogForm.ShowDialog() == DialogResult.OK)
            {
                SearchButton_Click(null, null);
            }
        }

        private void expottoExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToExcel<vwMainPersonnely_SearchAdvancedResult>.Export(resultSearchAdvenceds);
        }

        private void copyPayrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyPersonnelsPayRollDialogForm copyPersonnelsPayRollDialogForm = new CopyPersonnelsPayRollDialogForm();

            copyPersonnelsPayRollDialogForm.ShowDialog();
        }

        private void personnelByBirthDay_Click(object sender, EventArgs e)
        {
            PersonnelByBirthDayDialogForm personnelByBirthDayDialogForm = new PersonnelByBirthDayDialogForm();

            personnelByBirthDayDialogForm.ShowDialog();

        }

        private void updateCurrentContractDatesButton_Click(object sender, EventArgs e)
        {
            if (User.AuthenticationManager.IsActionAvailable("PersonnelSearchForm-UpdateContract"))
            {
                CurrentContractDialogForm currentContractDialogForm = new CurrentContractDialogForm();

                currentContractDialogForm.ShowDialog();
            }
            else
            {
                Helper.ShowMessage("شما به این بخش دسترسی ندارید");
            }
           

        }

        private void evalutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = string.Concat(Settings.Default.PathTemplate, "Evaluation.Doc");
            WordManager wordManager = new WordManager();
            int? nullable = null;
            vwMainPersonnely_SearchAdvancedResult current = (vwMainPersonnely_SearchAdvancedResult)vwMainPersonnelySearchAdvancedResultBindingSource.Current;
            if (current != null)
            {
                nullable = Helper.GetInt(current.PersonnelNumber);
            }
            selectedPersonnelNumberWithRangeDialogForm selectedPersonnelNumberWithRangeDialogForm = new selectedPersonnelNumberWithRangeDialogForm(nullable);
            if (selectedPersonnelNumberWithRangeDialogForm.ShowDialog() == DialogResult.OK)
            {
                int? nullable1 = null;
                wordManager.showdocument(str, 4, selectedPersonnelNumberWithRangeDialogForm.GetFrom, selectedPersonnelNumberWithRangeDialogForm.GetTo,
                    selectedPersonnelNumberWithRangeDialogForm.PersonnelNumbers, DateTime.Now, nullable1, selectedPersonnelNumberWithRangeDialogForm.ADate);
            }
        }

        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchResultDataGridView_RowDoubleClick(object sender, RowActionEventArgs e)
        {
            editPersonnelButton_Click(null, null);
        }

        private void departmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentDepartmentSelected = (Department)departmentComboBox.SelectedItem;
            if (currentDepartmentSelected == null) return;
            var lst = new List<SelectAllChildDepartmentsResult> { new SelectAllChildDepartmentsResult { Code = "-1", Name = "همه بخش ها" } };
            lst.AddRange(db.SelectAllChildDepartments(currentDepartmentSelected.Id)
                .Join(db.DepartmentVersions, d => d.DepartmentVersionID, dv => dv.ID,
                (d, dv) => new { d, dv })
                .Where(
                    x =>
                       x.dv.IsActive.GetValueOrDefault()  )// && x.d.OriginalDepartmentID != currentDepartmentSelected.OriginalDepartmentID
                .Select(x => x.d)
                .ToList());
            childrenOfDepartmentbindingSource.DataSource = lst;
        }

        private void printTrainingPersonnelCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string documentPath = Settings.Default.PathTemplate + "TrainingPersonnelCard.Docx";

            WordManager wordmanager = new WordManager();
            int? currentPersonnelNumber = null;

            vwMainPersonnely_SearchAdvancedResult resultSearchAdvenced = (vwMainPersonnely_SearchAdvancedResult)vwMainPersonnelySearchAdvancedResultBindingSource.Current;

            if (resultSearchAdvenced != null)
                currentPersonnelNumber = Helper.GetInt(resultSearchAdvenced.PersonnelNumber);

            selectedPersonnelNumberWithRangeDialogForm selectedPersonnelNumberWithRangeDialogForm = new selectedPersonnelNumberWithRangeDialogForm(currentPersonnelNumber);
            if (selectedPersonnelNumberWithRangeDialogForm.ShowDialog() == DialogResult.OK)
            {
                wordmanager.showdocument(documentPath, 6, selectedPersonnelNumberWithRangeDialogForm.GetFrom, selectedPersonnelNumberWithRangeDialogForm.GetTo, selectedPersonnelNumberWithRangeDialogForm.PersonnelNumbers, DateTime.Now, null, DateTime.Now);
            }
        }

        private void ResumeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(vwMainPersonnelySearchAdvancedResultBindingSource.Current is vwMainPersonnely_SearchAdvancedResult selected)) return;

                var vmPerson = db.vwMainPersonnelies.FirstOrDefault(p => p.Id == selected.Id);
                if (vmPerson == null) return;
                var personnel = db.Personnels.Where(p => p.PersonnelNumber == vmPerson.PersonnelNumber).ToList().First();
                var payrol = db.PayRolls.Where(p => p.PersonnelID == personnel.Id).OrderBy(p => p.ID).ToList().LastOrDefault();
                var encouragements = db.Encouragements.Where(p => p.PersonnelID == personnel.Id).ToList();
                var punishments = db.Punishments.Where(p => p.PersonnelID == personnel.Id).ToList();
                var departments = db.OrganizationStructurePersonnels.Where(p => p.PersonnelId == personnel.Id).ToList();
                var imageUrl = Path.Combine(Properties.Settings.Default.PathPersonnelsImage, personnel.PersonnelNumber + ".jpg");
                vmPerson.ImageUrl = imageUrl; //استفاده جهت ارسال عکس به ریپورت

                using (var report = new StiReport())
                {
                    // report.Load(@"D:\JamsazERP\Main\Source\PersonnlsApplication\Jamsaz.PersonnlsApplication\Reports\Stimul\ResumeReport.mrt");
                    report.Load(Properties.Resources.ResumeReport);
                    report.RegBusinessObject("vwMain", selected);
                    report.RegBusinessObject("vmPerson", vmPerson);
                    report.RegBusinessObject("Person", personnel);
                    report.RegBusinessObject("PayRol", payrol);
                    report.RegBusinessObject("encouragements", encouragements);
                    report.RegBusinessObject("punishments", punishments);
                    report.RegBusinessObject("Structure", departments);
                    report.Dictionary.SynchronizeBusinessObjects();
                    //report.Design(true);
                    report.Show(true);
                }
            }
            catch (Exception exception)
            {
                Helper.Error(exception.Message);
            }
        }

        private void چاپژتونToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string documentPath = Settings.Default.PathTemplate + "Jeton.Doc";

            WordManager wordmanager = new WordManager();
            int? currentPersonnelNumber = null;

            vwMainPersonnely_SearchAdvancedResult resultSearchAdvenced = (vwMainPersonnely_SearchAdvancedResult)vwMainPersonnelySearchAdvancedResultBindingSource.Current;
            //SelectPersonnelForZhetonDialogForm selectPersonnelForZhetonDialogForm = new SelectPersonnelForZhetonDialogForm();
            //if (selectPersonnelForZhetonDialogForm.ShowDialog()==DialogResult.OK)
            //{
            //    wordmanager.showdocument(documentPath, 7, selectPersonnelForZhetonDialogForm.DepartmentID, selectPersonnelForZhetonDialogForm.ChildID,User.Personnel.PersonnelNumber, DateTime.Now, null, DateTime.Now);
            //}

            if (resultSearchAdvenced != null)
                currentPersonnelNumber = Helper.GetInt(resultSearchAdvenced.PersonnelNumber);

            selectedPersonnelNumberWithRangeDialogForm selectedPersonnelNumberWithRangeDialogForm = new selectedPersonnelNumberWithRangeDialogForm(currentPersonnelNumber);
            if (selectedPersonnelNumberWithRangeDialogForm.ShowDialog() == DialogResult.OK)
            {
                wordmanager.showdocument(documentPath, 7, selectedPersonnelNumberWithRangeDialogForm.GetFrom, selectedPersonnelNumberWithRangeDialogForm.GetTo, selectedPersonnelNumberWithRangeDialogForm.PersonnelNumbers, DateTime.Now, null, DateTime.Now);
            }
        }

        //private void personnelDescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //string str = string.Concat(Settings.Default.PathTemplate, "Description.Doc");
        //WordManager wordManager = new WordManager();
        //int? nullable = null;
        //vwMainPersonnely_SearchAdvancedResult current = (vwMainPersonnely_SearchAdvancedResult)this.vwMainPersonnelySearchAdvancedResultBindingSource.Current;
        //if (current != null)
        //{
        //    nullable = new int?(Helper.GetInt(current.PersonnelNumber));
        //}
        //selectedPersonnelNumberWithRangeDialogForm _selectedPersonnelNumberWithRangeDialogForm = new selectedPersonnelNumberWithRangeDialogForm(nullable);
        //if (_selectedPersonnelNumberWithRangeDialogForm.ShowDialog() == DialogResult.OK)
        //{
        //    int? nullable1 = null;
        //    wordManager.showdocument(str, 4, _selectedPersonnelNumberWithRangeDialogForm.GetFrom, _selectedPersonnelNumberWithRangeDialogForm.GetTo, _selectedPersonnelNumberWithRangeDialogForm.PersonnelNumbers, DateTime.Now, nullable1);
        //}
        //}




    }
}
