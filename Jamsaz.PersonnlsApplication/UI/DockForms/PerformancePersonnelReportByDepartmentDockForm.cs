using System;
using System.Collections.Generic;
using System.Linq;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.PersonnlsApplication.UI.ReportForms;
using Janus.Windows.GridEX;
using Microsoft.SqlServer.Server;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class PerformancePersonnelReportByDepartmentDockForm : BasePersianForm
    {
        private readonly JamsazERPLiteDataClassesDataContext _db = new JamsazERPLiteDataClassesDataContext();
        List<PerformanceByDepartmentResult> Data = new List<PerformanceByDepartmentResult>();
        public PerformancePersonnelReportByDepartmentDockForm()
        {
            InitializeComponent();
            startAcumelateCombobox.SelectedIndex = 0;
            endAcumelateCombobox.SelectedIndex = 0;
        }

        #region Events

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                Data = new List<PerformanceByDepartmentResult>();
                var step = (EvaluationStep)stepComboBox.SelectedItem;
                var department = departmentComboBox.SelectedItem as Department;
                var chDepartments = departmentComboboxChilds.SelectedItem as SelectAllChildDepartmentsResult;
                var currentDepartment = (chDepartments != null && chDepartments.Code != "-1") ? new Department { Code = chDepartments.Code, OriginalDepartmentID = chDepartments.OriginalDepartmentID } : department;
                if (currentDepartment == null) return;
                if (currentDepartment.Code == "-1")
                {
                    if (startAcumelateCombobox.SelectedIndex != 0 || endAcumelateCombobox.SelectedIndex != 0)
                    {
                        scatterReportButton.Enabled = false;
                        foreach (Department dp in departmentBindingSource.List)
                        {
                            var stepOneData = _db.PerformanceByDepartment(dp.OriginalDepartmentID,
                            ((chDepartments != null && chDepartments.Code != "-1")
                                ? currentDepartment.OriginalDepartmentID
                                : 0),
                            User.FiscalYearID, step.ID).Select((x, i) => new PerformanceByDepartmentResult
                            {
                                Score = x.Score,
                                PersonelNumber = x.PersonelNumber,
                                Descriptor = x.Descriptor,
                                DepartmentId = x.DepartmentId,
                                PersonelID = x.PersonelID,
                                Average = x.Average,
                                DepartmentName = x.DepartmentName,
                                DepartmentChildName = x.DepartmentChildName,
                                OriginalDepartmentID = x.OriginalDepartmentID,
                                RowNum = i + 1
                            }).ToList();
                            Data.AddRange(SearchWithAcumulation(startAcumelateCombobox.SelectedIndex,
                                endAcumelateCombobox.SelectedIndex, stepOneData));
                        }
                    }
                    else
                    {
                        scatterReportButton.Enabled = true;
                        Data =
                            _db.PerformanceAllDepartment(User.FiscalYearID, step.ID, false)
                                .Select((x, i) => new PerformanceByDepartmentResult
                                {
                                    Score = x.Score,
                                    PersonelNumber = x.PersonelNumber,
                                    Descriptor = x.Descriptor,
                                    DepartmentId = x.DepartmentId,
                                    PersonelID = x.PersonelID,
                                    Average = x.Average,
                                    DepartmentName = x.DepartmentName,
                                    DepartmentChildName = x.DepartmentChildName,
                                    OriginalDepartmentID = x.OriginalDepartmentID,
                                    RowNum = i + 1
                                }).ToList();
                    }
                }
                else
                {
                    if (startAcumelateCombobox.SelectedIndex != 0 || endAcumelateCombobox.SelectedIndex != 0)
                    {
                        scatterReportButton.Enabled = false;
                        var stepOneData = _db.PerformanceByDepartment(currentDepartment.OriginalDepartmentID,
                            ((chDepartments != null && chDepartments.Code != "-1")
                                ? currentDepartment.OriginalDepartmentID
                                : 0),
                            User.FiscalYearID, step.ID).Select((x, i) => new PerformanceByDepartmentResult
                            {
                                Score = x.Score,
                                PersonelNumber = x.PersonelNumber,
                                Descriptor = x.Descriptor,
                                DepartmentId = x.DepartmentId,
                                PersonelID = x.PersonelID,
                                Average = x.Average,
                                DepartmentName = x.DepartmentName,
                                DepartmentChildName = x.DepartmentChildName,
                                OriginalDepartmentID = x.OriginalDepartmentID,
                                RowNum = i + 1
                            }).ToList();
                        Data = SearchWithAcumulation(startAcumelateCombobox.SelectedIndex, endAcumelateCombobox.SelectedIndex, stepOneData);
                    }
                    else
                    {
                        scatterReportButton.Enabled = true;
                        Data =
                            _db.PerformanceByDepartment(currentDepartment.OriginalDepartmentID,
                                ((chDepartments != null && chDepartments.Code != "-1")
                                    ? currentDepartment.OriginalDepartmentID
                                    : 0),
                                User.FiscalYearID, step.ID).Select((x, i) => new PerformanceByDepartmentResult
                                {
                                    Score = x.Score,
                                    PersonelNumber = x.PersonelNumber,
                                    Descriptor = x.Descriptor,
                                    DepartmentId = x.DepartmentId,
                                    PersonelID = x.PersonelID,
                                    Average = x.Average,
                                    DepartmentName = x.DepartmentName,
                                    DepartmentChildName = x.DepartmentChildName,
                                    OriginalDepartmentID = x.OriginalDepartmentID,
                                    RowNum = i + 1
                                }).ToList();
                    }
                }
                performanceByDepartmentResultBindingSource.DataSource = Data;
                scoreSumText.Text = Data.Sum(x => x.Score).ToString();
                averageText.Text = (int.Parse(scoreSumText.Text) / Data.Count).ToString("N");
            }
            catch (Exception)
            {

            }
        }

        private void PerformancePersonnelReportByDepartmentDockForm_Load(object sender, EventArgs e)
        {
            var lst = new List<Department> { new Department { Code = "-1", Name = "همه واحد ها" } };
            lst.AddRange(
                _db.Departments.Join(_db.DepartmentVersions, d => d.DepartmentVersionID, dv => dv.ID,
                    (d, dv) => new { d, dv }).Where(x => x.dv.IsActive.Value && !x.d.Code.Contains("-")).Select(x => x.d).ToList());
            departmentBindingSource.DataSource = lst;
            evaluationStepBindingSource.DataSource =
                _db.EvaluationSteps.Where(x => x.FiscalYearID == User.FiscalYearID).ToList();

            var currentDepartmentSelected = (Department)departmentComboBox.SelectedItem;
            if (currentDepartmentSelected.Code.Equals("-1"))
            {
                reportButton.Text = "چاپ نمودار";
                reportButtonAllDepartmentList.Visible = true;
            }
            else
            {
                reportButton.Text = "چاپ گزارش";
                reportButtonAllDepartmentList.Visible = false;
            }
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            try
            {
                var step = (EvaluationStep)stepComboBox.SelectedItem;
                var department = departmentComboBox.SelectedItem as Department;
                if (department != null)
                {
                    if (department.Code != "-1" || (department.Code == "-1" && scatterReportButton.Enabled == false))
                    {
                        SortChanged();
                        var reportform = new PerformanceByDepartmentReportForm
                        {
                            DepartmentName = department.Name,
                            Source = Data
                        };
                        reportform.Show();
                    }
                    else if (department.Code == "-1" && scatterReportButton.Enabled)
                    {
                        var reportform = new PerformanceAllDepartmentReportForm
                        {
                            StepId = step.ID,
                            DepartmentName = department.Name
                        };
                        reportform.Show();
                    }
                }
                else
                {
                    Helper.ShowMessage("لطفا ابتدا واحد مورد نظر را انتخاب کنید");
                }
            }
            catch (Exception)
            {

            }
        }

        private void reportButtonAllDepartmentList_Click(object sender, EventArgs e)
        {
            var step = (EvaluationStep)stepComboBox.SelectedItem;
            var department = departmentComboBox.SelectedItem as Department;
            if (department == null) return;
            var reportform = new PerformanceAllDepartmentListReportForm
            {
                StepId = step.ID,
                Source = (IList<PerformanceByDepartmentResult>)performanceByDepartmentResultBindingSource.List
            };
            reportform.Show();
        }

        private void departmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentDepartmentSelected = (Department)departmentComboBox.SelectedItem;
            if (currentDepartmentSelected == null) return;
            var lst = new List<SelectAllChildDepartmentsResult> { new SelectAllChildDepartmentsResult { Code = "-1", Name = "همه بخش ها" } };
            lst.AddRange(_db.SelectAllChildDepartments(currentDepartmentSelected.Id).Join(_db.DepartmentVersions, d => d.DepartmentVersionID, dv => dv.ID,
                (d, dv) => new { d, dv })
                .Where(
                    x =>
                       x.dv.IsActive.Value &&
                        x.d.OriginalDepartmentID != currentDepartmentSelected.OriginalDepartmentID)
                .Select(x => x.d)
                .ToList());
            childrenOfDepartmentbindingSource.DataSource = lst;
            if (currentDepartmentSelected.Code.Equals("-1"))
            {
                reportButton.Text = "چاپ نمودار";
                reportButtonAllDepartmentList.Visible = true;
            }
            else
            {
                reportButton.Text = "چاپ گزارش";
                reportButtonAllDepartmentList.Visible = false;
            }
        }

        private void scatterReportButton_Click(object sender, EventArgs e)
        {
            try
            {
                var department = departmentComboBox.SelectedItem as Department;
                if (department != null)
                {
                    if (department.Code != "-1")
                    {
                        SortChanged();
                        var reportform = new PerformanceAllDepartmentScatterReportForm
                        {
                            DepartmentName = department.Name,
                            Source = Data
                        };
                        reportform.Show();
                    }
                    else
                    {
                        Helper.ShowMessage("لطفا واحد مورد نظر خود را انتخاب نمایید و دکمه جستجو را انتخاب کنید");
                    }
                }
                else
                {
                    Helper.ShowMessage("لطفا ابتدا واحد مورد نظر را انتخاب کنید");
                }
            }
            catch (Exception)
            {

            }
        }

        private void listGroupGrid_SortKeysChanged(object sender, EventArgs e)
        {
            SortChanged();
            performanceByDepartmentResultBindingSource.DataSource = Data;
        }

        private void startAcumelateCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (startAcumelateCombobox.SelectedIndex == 1 || startAcumelateCombobox.SelectedIndex == 8)
            {
                endAcumelateCombobox.SelectedIndex = 0;
            }
        }

        private void endAcumelateCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (endAcumelateCombobox.SelectedIndex != 0 && (startAcumelateCombobox.SelectedIndex == 1 || startAcumelateCombobox.SelectedIndex == 8))
            {
                endAcumelateCombobox.SelectedIndex = 0;
                Helper.ShowMessage("هنگامی که موارد بیشترین مقدار و کمترین مقدار را انتخاب کرده باشید نمی توانید بر اساس بازه خاصی جستجو کنید!");
            }
        }

        #endregion

        #region Methods

        private void SortChanged()
        {
            foreach (
                var column in
                    listGroupGrid.RootTable.Columns.Cast<GridEXColumn>().Where(column => column.IsSorted))
            {
                Data = column.SortOrder == SortOrder.Ascending
                    ? Data.OrderBy(x => x.GetType().GetProperty(column.DataMember).GetValue(x, null)).ToList()
                    : Data.OrderByDescending(x => x.GetType().GetProperty(column.DataMember).GetValue(x, null))
                        .ToList();
                Data = Data.Select((x, i) => new PerformanceByDepartmentResult
                {
                    Score = x.Score,
                    PersonelNumber = x.PersonelNumber,
                    Descriptor = x.Descriptor,
                    DepartmentId = x.DepartmentId,
                    PersonelID = x.PersonelID,
                    Average = x.Average,
                    DepartmentName = x.DepartmentName,
                    DepartmentChildName = x.DepartmentChildName,
                    OriginalDepartmentID = x.OriginalDepartmentID,
                    RowNum = i + 1
                }).ToList();

                break;
            }
        }

        private List<PerformanceByDepartmentResult> SearchWithAcumulation(int startIndex, int endIndex, ICollection<PerformanceByDepartmentResult> stepOneData)
        {
            var d = stepOneData.Average(x => x.Score);
            if (d != null)
            {
                var average = d.Value;
                var variance = stepOneData.Sum(x => Math.Pow((x.Score - average).Value, 2)) / stepOneData.Count;
                var enheraf = Math.Sqrt(variance);

                var mMinesA = average - enheraf;
                var mMines2A = mMinesA - enheraf;
                var mMines3A = mMines2A - enheraf;

                var mPlusA = average + enheraf;
                var mPlus2A = mPlusA + enheraf;
                var mPlus3A = mPlus2A + enheraf;

                double start = 0, end = 0;

                switch (startIndex)
                {
                    case 1:
                        start = mPlus3A;
                        end = -1;
                        break;
                    case 2:
                        start = mPlus3A;
                        break;
                    case 3:
                        start = mPlus2A;
                        break;
                    case 4:
                        start = mPlusA;
                        break;
                    case 5:
                        start = mMines3A;
                        break;
                    case 6:
                        start = mMines2A;
                        break;
                    case 7:
                        start = mMinesA;
                        break;
                    case 8:
                        start = -1;
                        end = mMines3A;
                        break;
                }

                switch (endIndex)
                {
                    case 1:
                        end = -2;
                        break;
                    case 2:
                        end = mPlus3A;
                        break;
                    case 3:
                        end = mPlus2A;
                        break;
                    case 4:
                        end = mPlusA;
                        break;
                    case 5:
                        end = mMines3A;
                        break;
                    case 6:
                        end = mMines2A;
                        break;
                    case 7:
                        end = mMinesA;
                        break;
                    case 8:
                        end = -3;
                        break;
                }

                if ((start == -1 && (end != -2 || end != -3)) || end == -1)
                {
                    return start == -1
                        ? stepOneData.Where(x => x.Score < end).ToList()
                        : stepOneData.Where(x => x.Score > start).ToList();
                }

                if (end == -2 || end == -3)
                {
                    return end == -2
                        ? stepOneData.Where(x => x.Score >= start).ToList()
                        : stepOneData.Where(x => x.Score <= start).ToList();
                }

                if (start < end)
                {
                    var temp = start;
                    start = end;
                    end = temp;
                }

                return stepOneData.Where(x => x.Score <= start && x.Score > end).ToList();
            }
            return new List<PerformanceByDepartmentResult>();
        }

        #endregion

    }
}
