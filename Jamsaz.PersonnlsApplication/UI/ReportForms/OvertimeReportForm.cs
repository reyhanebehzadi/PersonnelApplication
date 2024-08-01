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
namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    public partial class OvertimeReportForm : BasePersianForm
    {
        public OvertimeReportForm()
        {
            InitializeComponent();
        }
        private List<GetOvertimeReportResult> result = new List<GetOvertimeReportResult>();
        private List<GetOvertimeTotalReportResult> TotalResult = new List<GetOvertimeTotalReportResult>();
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        MonthTable selectedMonth;
        double lastMonth;
        private void OvertimeReportForm_Load(object sender, EventArgs e)
        {
            fiscalYearBindingSource.DataSource = db.FiscalYears;
            fiscalyearComboBox.SelectedItem = db.FiscalYears.SingleOrDefault(c => c.Status == 2);
            monthTableBindingSource.DataSource = db.MonthTables;

            var lst = new List<Department> { new Department { Code = "-1", Name = "همه واحد ها" } };
            lst.AddRange(
                db.Departments.Join(db.DepartmentVersions, d => d.DepartmentVersionID, dv => dv.ID,
                    (d, dv) => new { d, dv }).Where(x => x.dv.IsActive.Value && !x.d.Code.Contains("-")).Select(x => x.d).ToList());
            departmentBindingSource.DataSource = lst;
           

        }
        int max;
        private void reportButton_Click(object sender, EventArgs e)
        {
            result.Clear();
            
            if (!string.IsNullOrEmpty(MaxTextBox.Text))
            {
                max = Convert.ToInt32(MaxTextBox.Text.Trim());
            }

            if (!(monthTableBindingSource.Current is MonthTable selectMonth)) return;
            {
                selectedMonth = selectMonth;
                Department department = departmentBindingSource.Current as Department;
                SelectAllChildDepartmentsResult child = departmentComboboxChilds.SelectedItem as SelectAllChildDepartmentsResult;

                if (department != null && department.Code != "-1" && child != null  && child.Code != "-1")
                {
                    getOvertimeReportResultBindingSource.DataSource = db.GetOvertimeReport(((FiscalYear)fiscalyearComboBox.SelectedItem).ID, selectMonth.ID, department.Id, child.OriginalDepartmentID).Where(d => d.OvertimeHourse >= max);
                    result = db.GetOvertimeReport(((FiscalYear)fiscalyearComboBox.SelectedItem).ID, selectMonth.ID, department.Id, child.OriginalDepartmentID).Where(d => d.OvertimeHourse >= max).ToList();
                    TotalResult = db.GetOvertimeTotalReport(((FiscalYear)fiscalyearComboBox.SelectedItem).ID, selectMonth.ID, department.Id, child.OriginalDepartmentID).ToList();
                    lastMonth =Convert.ToDouble( db.GetOvertimeReport(((FiscalYear)fiscalyearComboBox.SelectedItem).ID, selectMonth.ID > 1 ? selectMonth.ID - 1 : 0, department.Id, child.OriginalDepartmentID).Sum(p => p.Total));
                    
                }
                    
                
                else
                     if (department != null && department.Code != "-1" && child !=null && child.Code == "-1")
                {
                    getOvertimeReportResultBindingSource.DataSource = db.GetOvertimeReport(((FiscalYear)fiscalyearComboBox.SelectedItem).ID, selectMonth.ID, department.Id, null).Where(d => d.OvertimeHourse >= max);
                    result= db.GetOvertimeReport(((FiscalYear)fiscalyearComboBox.SelectedItem).ID, selectMonth.ID, department.Id, null).Where(d => d.OvertimeHourse >= max).ToList();
                    TotalResult = db.GetOvertimeTotalReport(((FiscalYear)fiscalyearComboBox.SelectedItem).ID, selectMonth.ID, department.Id, null).ToList();

                    lastMonth =Convert.ToDouble( db.GetOvertimeReport(((FiscalYear)fiscalyearComboBox.SelectedItem).ID, selectMonth.ID > 1 ? selectMonth.ID - 1 : 0, department.Id, null).Sum(p => p.Total));

                }
                   
                else
                {
                    getOvertimeReportResultBindingSource.DataSource = db.GetOvertimeReport(((FiscalYear)fiscalyearComboBox.SelectedItem).ID, selectMonth.ID, null, null).Where(d => d.OvertimeHourse >= max);
                    result = db.GetOvertimeReport(((FiscalYear)fiscalyearComboBox.SelectedItem).ID, selectMonth.ID, null, null).Where(d => d.OvertimeHourse >= max).ToList();
                    TotalResult = db.GetOvertimeTotalReport(((FiscalYear)fiscalyearComboBox.SelectedItem).ID, selectMonth.ID, null, null).ToList();

                    if (selectMonth.ID>1)
                    
                    lastMonth =Convert.ToDouble( db.GetOvertimeReport(((FiscalYear)fiscalyearComboBox.SelectedItem).ID, selectMonth.ID > 1 ? selectMonth.ID - 1 : 0, null, null).Sum(p => p.Total));
                  
                    else
                    {
                        var lastYear = db.FiscalYears.Where(c => c.ID != ((FiscalYear)fiscalyearComboBox.SelectedItem).ID).OrderByDescending(p => p.ID).First().ID;
                        lastMonth = Convert.ToDouble(db.GetOvertimeReport(lastYear, 12, null, null).Sum(p => p.Total));
                    }
                        
                }
                    

            }

            
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
                       x.dv.IsActive.GetValueOrDefault())
                .Select(x => x.d)
                .ToList());
            childrenOfDepartmentbindingSource.DataSource = lst;
            departmentComboboxChilds.SelectedItem  = lst.SingleOrDefault(c=>c.Code=="-1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FirstOvertimeReportForm frm = new FirstOvertimeReportForm() { Result=result,Current= selectedMonth };
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SecoundOverTimeReportForm frm = new SecoundOverTimeReportForm() { Result = result, Current = selectedMonth ,LastMonth= lastMonth ,TotalResult=TotalResult};

           
            frm.ShowDialog();
        }
    }
}
