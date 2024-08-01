using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.PersonnlsApplication.UI.ReportForms;
using Jamsaz.Common;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class TopPersonelEvaluationDockForm : BasePersianForm
    {
        private readonly JamsazERPLiteDataClassesDataContext _db = new JamsazERPLiteDataClassesDataContext();
        public TopPersonelEvaluationDockForm()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                //درصدی که وارد می شود یعنی چند درصد تعداد پیدا شده را نشان دهد  
                //برای نمایش همه 100 درصد را انتخاب کنید
                //نیم ساعت طول کشید تا اینو متوجه شم !!!!!!
                if (string.IsNullOrEmpty(percentTextBox.Text)) percentTextBox.Text = "10";
                var step = (EvaluationStep)stepComboBox.SelectedItem;
                var dep = (Department)departmentComboBox.SelectedItem;
                var percent = percentTextBox.Text;
                if (dep.Code == "-1")
                {
                    personelEvaluationByPercentResultBindingSource.DataSource =
                        _db.GetPersonelEvaluationByPercent(User.FiscalYearID, step.ID, percent);
                }
                else
                {
                    personelEvaluationByPercentResultBindingSource.DataSource =
                        _db.GetPersonelEvaluationByPercent(User.FiscalYearID, step.ID, percent)
                            .Where(x => x.OrginalDepartmentID == dep.OriginalDepartmentID);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void TopPersonelEvaluationDockForm_Load(object sender, EventArgs e)
        {
            try
            {
                percentTextBox.Text = "10";
                var lst = new List<Department> { new Department { Code = "-1", Name = "همه واحد ها" } };
                lst.AddRange(
                    _db.Departments.Join(_db.DepartmentVersions, d => d.DepartmentVersionID, dv => dv.ID,
                        (d, dv) => new { d, dv }).Where(x => x.dv.IsActive.Value && !x.d.Code.Contains("-")).Select(x => x.d).ToList());
                departmentBindingSource.DataSource = lst;
                evaluationStepBindingSource.DataSource =
                    _db.EvaluationSteps.Where(x => x.FiscalYearID == User.FiscalYearID).ToList();
            }
            catch (Exception ex)
            {


            }
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            var performancePercentReportForm = new PerformancePercentReportForm { Source = personelEvaluationByPercentResultBindingSource.List };
            performancePercentReportForm.ShowDialog();
        }
    }
}
