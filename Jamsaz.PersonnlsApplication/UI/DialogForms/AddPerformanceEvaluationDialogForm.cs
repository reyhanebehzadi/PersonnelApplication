using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FarsiLibrary.Utils;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.PersonnlsApplication.BusinessObjects.Definitions;

namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class AddPerformanceEvaluationDialogForm : BasePersianForm
    {
        public AddPerformanceEvaluationDialogForm()
        {
            InitializeComponent();
        }
        private readonly JamsazERPLiteDataClassesDataContext _db = new JamsazERPLiteDataClassesDataContext();
        public FormStatus FormStatus { get; set; }
        public PerformancEvaluationMaster Master { get; set; }
        public PerformancEvaluationDetail Detail { get; set; }

        private readonly List<PerformancEvaluationDetail> _collection = new List<PerformancEvaluationDetail>();
        private void personnelListButton_Click(object sender, EventArgs e)
        {
            var personnelListForm = new PersonnelListForm(_db, ((EvaluationStep)stepComboBox.SelectedItem).ID) { IsActive = true , All=true};
            if (personnelListForm.ShowDialog() == DialogResult.OK)
            {
                Master.Personnel = _db.Personnels.SingleOrDefault(c=>c.Id== personnelListForm.Personnel.Id);
            }
        }

        private void AddPerformanceEvaluationDialogForm_Load(object sender, EventArgs e)
        {
            valuatorBindingSource.DataSource = _db.Valuators.ToList();
            evaluationStepBindingSource.DataSource = _db.EvaluationSteps.Where(c=>c.FiscalYearID == User.FiscalYearID).ToList();
            var index = 2;
            foreach (Valuator item in valuatorBindingSource.List)
            {
                AddDynamicCheckBox(index, item.Title, "ch_" + item.ID, item.ID);
                index++;
            }

            if (FormStatus == FormStatus.Add)
            {

                Master = new PerformancEvaluationMaster { StartDateAssessment = DateTime.Now };

                foreach (var item in _db.EvaluationIndexes.Where(c=>c.CategoriesIndexEvaluation.FiscalYearID==User.FiscalYearID).ToList())
                    //.Where(c => c.CategoriesIndexEvaluation.FiscalYearID == User.FiscalYearID).ToList())
                {
                    Detail = new PerformancEvaluationDetail()
                    {
                        EvaluationIndex = item,
                        ValuatorID = null,
                        PerformancEvaluationMaster = Master,
                        Description = null
                    };

                    _collection.Add(Detail);
                }

                performancEvaluationDetailsBindingSource.DataSource = _collection.OrderBy(c => c.EvaluationIndex.CategoriesIndexEvaluationID);
                performancEvaluationMasterBindingSource.DataSource = Master;
            }
            else
            {
                Master = _db.PerformancEvaluationMasters.SingleOrDefault(c => c.ID == Master.ID);
                performancEvaluationMasterBindingSource.DataSource = Master;
                if (Master == null) return;
                foreach (var detail in Master.PerformancEvaluationDetails)
                {
                    foreach (var row in performancEvaluationDetailsDataGridView.Rows.Cast<DataGridViewRow>().Where(row => row.Cells["ID"].Value.ToString() == detail.ID.ToString()))
                    {
                        if(detail.ValuatorID==null) continue;
                        row.Cells["ch_" + detail.ValuatorID].Value = true;
                    }
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var step = (EvaluationStep)stepComboBox.SelectedItem;
            if (personnelIDTextBox.Text == string.Empty)
            {
                Helper.ShowMessage("پرسنل مورد نظر را انتخاب کنید");
                return;
            }
            if (!Helper.Confirm("آیا مایل به ثبت اطلاعات هستید؟")) return;
            if (FormStatus == FormStatus.Add)
            {
                if (_db.PerformancEvaluationMasters.Any(x => x.StepID == step.ID && x.FiscalYearID == User.FiscalYearID && x.PersonnelID == Master.PersonnelID))
                {
                    Helper.ShowMessage("شخص انتخاب شده قبلا در این مرحله ثبت شده است");
                    return;
                }
                UpdateMasterFromCheckBoxes(false);
                Master.FiscalYearID = User.FiscalYearID;
                Master.StepID = step.ID;
                _db.PerformancEvaluationMasters.InsertOnSubmit(Master);
                _db.SubmitChanges();

            }
            else
            {
                Master.StepID = step.ID;
                UpdateMasterFromCheckBoxes(true);
                _db.SubmitChanges();
            }

            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void AddDynamicCheckBox(int index, string headerText, string name, int id)
        {
            var checkColumn = new DataGridViewCheckBoxColumn
            {
                Name = name,
                HeaderText = headerText,
                Width = 60,
                ReadOnly = false,
                FillWeight = 10,
                DisplayIndex = index,
                Tag = id
            };
            performancEvaluationDetailsDataGridView.Columns.Add(checkColumn);
        }

        private void performancEvaluationDetailsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridView = sender as DataGridView;
            if (!(dataGridView?.CurrentCell is DataGridViewCheckBoxCell)) return;
            var dataGridViewCheckBoxCell = ((DataGridView)sender).CurrentCell as DataGridViewCheckBoxCell;
            if (dataGridViewCheckBoxCell == null) return;
            if (dataGridView.CurrentRow == null) return;
            foreach (var cell in dataGridView.CurrentRow.Cells.Cast<DataGridViewCell>().Where(cell => cell is DataGridViewCheckBoxCell && cell != dataGridViewCheckBoxCell))
            {
                cell.Value = false;
            }
        }

        private void UpdateMasterFromCheckBoxes(bool isEdit)
        {
            foreach (var detail in Master.PerformancEvaluationDetails)
            {
                if (isEdit)
                {
                    foreach (
                        var cell in performancEvaluationDetailsDataGridView.Rows.Cast<DataGridViewRow>()
                            .Single(row => row.Cells["ID"].Value.ToString() == detail.ID.ToString())
                            .Cells.Cast<DataGridViewCell>()
                            .Where(cell => cell is DataGridViewCheckBoxCell && Convert.ToBoolean(cell.Value)))
                    {
                        detail.ValuatorID = int.Parse(cell.OwningColumn.Tag.ToString());
                    }
                }
                else
                {
                    foreach (
                        var cell in
                            performancEvaluationDetailsDataGridView.Rows.Cast<DataGridViewRow>()
                                .Where(
                                    row =>
                                        row.Cells["evalutionIndexIDDataGridViewTextBoxColumn"].Value.ToString()
                                            .Equals(detail.EvalutionIndexID.Value.ToString()))
                                .SelectMany(
                                    row =>
                                        row.Cells.Cast<DataGridViewCell>()
                                            .Where(
                                                cell =>
                                                    cell is DataGridViewCheckBoxCell && Convert.ToBoolean(cell.Value))))
                    {
                        detail.ValuatorID = int.Parse(cell.OwningColumn.Tag.ToString());
                    }
                }
            }
        }
    }
}