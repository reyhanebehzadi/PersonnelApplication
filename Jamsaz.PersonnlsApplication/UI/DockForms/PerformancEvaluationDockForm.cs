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
using Jamsaz.PersonnlsApplication.BusinessObjects.Definitions;
using Jamsaz.PersonnlsApplication.UI.DialogForms;
using Jamsaz.PersonnlsApplication.UI.ReportForms;
namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class PerformancEvaluationDockForm : BasePersianForm
    {
        public PerformancEvaluationDockForm()
        {
            InitializeComponent();
        }
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();


        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            var addPerformanceEvalutionDialogForm = new AddPerformanceEvaluationDialogForm()
            {
                FormStatus = FormStatus.Add
            };
            if (addPerformanceEvalutionDialogForm.ShowDialog() == DialogResult.OK)
            {
                LoadPage();
                performancEvaluationMasterDataGridView.Refresh();
            }
        }

        private void PerformancEvaluationDockForm_Load(object sender, EventArgs e)
        {
            LoadPage();
        }

        public void LoadPage()
        {

            try
            {
               
                #region ایجاد شرط برای نمایش کاربران زیر مجموعه

                //دپارتمان کاربر لاگین شده
                var currentUserDepartmentId = db.DepartmentPersonnels
                    .FirstOrDefault(p => p.PersonnelID == User.Personnel.Id && p.IsActiveDepartment == true)?.DepartmentID ?? 0;
                if (currentUserDepartmentId == 0)
                {
                    Helper.ShowMessage("شما عضو هیچ دپارتمانی نیستید");
                    return;
                }
                //دپارتمان هایی که زیر مجموعه کاربری جاری هستند
                var allDepartment = GetDepartmentChild(currentUserDepartmentId); // لیست آی دی دپارتمان های زیر مجموعه
                var condition = $"A.PersonnelID in(select  PersonnelID from com.DepartmentPersonnel where DepartmentID in ({string.Join(",", allDepartment.ToArray())}))";

                #endregion
                evaluationStepBindingSource.DataSource =
                    db.EvaluationSteps.Where(x => x.FiscalYearID == User.FiscalYearID).ToList();
                var step = (EvaluationStep)stepComboBox.SelectedItem;
                if (step == null)
                {
                    Helper.ShowMessage("برای این سال مالی هیچ مرحله ای تعریف نشده است");
                    return;
                }


                //var query = "Select A.* From[hrm].[PerformancEvaluationMaster] A " + //لیست ارزیابی ها
                //            "Inner Join[hrm].[Personnel] B On A.PersonnelID = B.Id " + // مشخصات ارزیابی شونده ها
                //            $"Where A.FiscalYearID = {User.FiscalYearID} "+ //در سال مالی جاری
                //            $"And A.StepID = {step.ID} and " + condition; //مرحله




                var query = "Select A.* From[hrm].[PerformancEvaluationMaster] A " + //لیست ارزیابی ها
                           "Inner Join[hrm].[Personnel] B On A.PersonnelID = B.Id " + // مشخصات ارزیابی شونده ها
                           $"Where A.FiscalYearID = {User.FiscalYearID} " + //در سال مالی جاری
                           $"And A.StepID = {step.ID} "; //مرحله



                if (!string.IsNullOrEmpty(nameTextBox.Text))
                    query += $"And (B.Descriptor Like N'%{nameTextBox.Text}%') ";

                if (!string.IsNullOrEmpty(codeTextBox.Text))
                    query += $"And B.PersonnelNumber = {codeTextBox.Text} ";
                performancEvaluationMasterBindingSource.DataSource =
                    db.ExecuteQuery<PerformancEvaluationMaster>(query).ToList();

            }
            catch (Exception e)
            {
                Helper.ShowMessage(e.InnerException?.Message ?? e.Message);
            }


        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            PerformancEvaluationMaster current = (PerformancEvaluationMaster)performancEvaluationMasterBindingSource.Current;

            if (Helper.Confirm("آیا مایل به حذف  می باشید؟!"))
            {
                try
                {
                    db.PerformancEvaluationMasters.DeleteOnSubmit(current);
                    db.SubmitChanges();
                    LoadPage();

                }
                catch (Exception)
                {

                    Helper.Error("امکان حذف وجود ندارد!");
                }

            }
        }

        private void performancEvaluationMasterBindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            PerformancEvaluationMaster current = (PerformancEvaluationMaster)performancEvaluationMasterBindingSource.Current;
            if (current != null)
            {
                AddPerformanceEvaluationDialogForm addPerformanceEvalutionDialogForm = new AddPerformanceEvaluationDialogForm()
                {
                    FormStatus = FormStatus.Edit,
                    Master = current
                };
                if (addPerformanceEvalutionDialogForm.ShowDialog() == DialogResult.OK)
                {
                    db = new JamsazERPLiteDataClassesDataContext();
                    LoadPage();
                    performancEvaluationMasterDataGridView.Refresh();
             

                }
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var current = (PerformancEvaluationMaster)performancEvaluationMasterBindingSource.Current;

            //لیست تشویق ها را از دیتابیس جدا می کند
            //در یک آرایه از رشته میریزد
            //به وسیله / از هم جدا می کند
            var encouragements = db.Encouragements
                .Where(p => p.PersonnelID == current.Personnel.Id && p.FiscalYearID == User.FiscalYearID).ToList(); 
            current.Encouragement = current.Punishment = string.Empty;
            foreach (var item in encouragements)
            {
                current.Encouragement += $"{item.Reason} : {item.Description} / ";
            }
            //لیست تنبیه  ها را از دیتابیس جدا می کند
            //در یک آرایه از رشته میریزد
            //به وسیله / از هم جدا می کند
            var punishment = db.Punishments.Where(p => p.PersonnelID == current.Personnel.Id && p.FiscalYearID == User.FiscalYearID); 

            foreach (var item in punishment)
            {
                current.Punishment += $"{item.Reason} : {item.Description} / ";
            }
            var performanceReportForm = new PerformanceReportForm() { Master = current };
            performanceReportForm.ShowDialog();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            LoadPage();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                LoadPage();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private List<int> GetDepartmentChild(int departmentId)
        {
            try
            {
                var allChild = new List<int>();
                GetAllDepartmentChildRecursive(departmentId, allChild);
                return allChild;
            }
            catch (Exception e)
            {
                throw new Exception(e.InnerException?.Message ?? e.Message);
            }
        }
        private void GetAllDepartmentChildRecursive(int departmentId, List<int> allChild)
        {
            try
            {
                //لیست چایلدها
                var childs = db.Departments.Where(p => p.ParentId == departmentId).Select(p => p.Id).ToList();
                if (childs.Count == 0)
                    allChild.Add(departmentId);
                else
                {
                    foreach (var child in childs)
                    {
                        GetAllDepartmentChildRecursive(child, allChild);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.InnerException?.Message ?? e.Message);
            }
        }
    }
}
