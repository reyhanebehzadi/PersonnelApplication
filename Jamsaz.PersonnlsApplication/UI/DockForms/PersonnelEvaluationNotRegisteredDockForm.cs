using System;
using System.Linq;
using System.Windows.Forms;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.Common;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class PersonnelEvaluationNotRegisteredDockForm : BasePersianForm
    {
        private JamsazERPLiteDataClassesDataContext _db;
        public PersonnelEvaluationNotRegisteredDockForm()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            LoadPage();
        }

        private void PersonnelEvaluationNotRegisteredDockForm_Load(object sender, EventArgs e)
        {
            LoadPage();
        }

        public void LoadPage()
        {
            _db = new JamsazERPLiteDataClassesDataContext();
            evaluationStepBindingSource.DataSource = _db.EvaluationSteps.Where(x => x.FiscalYearID == User.FiscalYearID).ToList();
            var step = (EvaluationStep)stepComboBox.SelectedItem;
            //وقتی اکسپت باشد کاربرانی که ارزیابی نشده اند را می آورد یعنی شامل لیست ارزیابی شده ها نیستند
            var condition = EvaluatiobRadioButton.Checked ? "and Id in" : "Except";
            var query = @"Select	R1.*,
							ROW_NUMBER() Over (Order By R1.PersonnelNumber Asc) As RowNum
							From
							(Select 
								Cast(A.PersonnelNumber as Int) As PersonnelNumber,
								A.Descriptor,
								(Select Top 1 DA.Name From [com].[Departments] DA Where DA.Id = A.DepartmentId) As DepartmentName,
								(Select Top 1 DA.Name From [com].[Departments] DA Inner Join [com].[DepartmentPersonnel] DB On DA.Id = DB.DepartmentID Where DB.PersonnelID = A.Id) As DepartmentChildName
								From
									[hrm].[Personnel] A
								Inner Join
									(Select 
											Id
											From
												[hrm].[Personnel]
										Where IsActive = 1 "+condition+
										@" (Select 
											A.PersonnelID 
										From 
											[hrm].[PerformancEvaluationMaster] A 
										Inner Join 
											[hrm].[Personnel] B 
										On A.PersonnelID = B.Id 
										Where A.FiscalYearID = " + User.FiscalYearID + " And A.StepID = " + step.ID + @")) B
								On A.Id = B.Id) R1 Where R1.PersonnelNumber <> 0 ";
            if (!string.IsNullOrEmpty(nameTextBox.Text))
                query += $"And (R1.Descriptor Like N'%{nameTextBox.Text}%') ";
            if (!string.IsNullOrEmpty(codeTextBox.Text))
                query += $"And R1.PersonnelNumber = {codeTextBox.Text} ";
            personnelBindingSource.DataSource =
                _db.ExecuteQuery<PersonnelNotEvaluatedResult>(query).ToList();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                LoadPage();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
