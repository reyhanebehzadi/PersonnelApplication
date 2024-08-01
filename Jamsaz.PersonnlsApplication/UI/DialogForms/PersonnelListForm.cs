using System;
using System.Linq;
using System.Windows.Forms;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class PersonnelListForm : BasePersianForm
    {
        private readonly int stepID;
        private JamsazERPLiteDataClassesDataContext db;
        private List<Personnel> personnels;
        private bool allPersonnel;
        public bool All { get; set; }
        public bool AllPersonnel { get; set; }
        public PersonnelListForm(JamsazERPLiteDataClassesDataContext DB)
        {
            InitializeComponent();
            db = DB;
            allPersonnel = true;
        }

        public PersonnelListForm(JamsazERPLiteDataClassesDataContext DB, int stepId)
        {
            InitializeComponent();
            db = DB;
            this.stepID = stepId;
        }

        public Personnel Personnel { get; set; }
        public bool IsActive { get; set; }

        public bool DepartmentList { get; set; }
        public bool NewMethod { get; set; }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            var persons = await GetAllMemberPersonelCurrentUser(allPersonnel);
            if (IsActive == true)
            {
                if (familyTextBox.Text != string.Empty)
                    this.personnelBindingSource.DataSource = persons.Where(c => (c.LastName.Contains(familyTextBox.Text) || c.FirstName.Contains(familyTextBox.Text) || c.PersonnelNumber == familyTextBox.Text) && c.IsActive == true).OrderBy(d => Convert.ToInt32(d.PersonnelNumber));
                else
                    this.LoadData(allPersonnel);
            }
            else
            {
                if (familyTextBox.Text != string.Empty)
                    this.personnelBindingSource.DataSource = persons.Where(c => c.LastName.Contains(familyTextBox.Text) || c.FirstName.Contains(familyTextBox.Text) || c.PersonnelNumber == familyTextBox.Text).OrderBy(d => Convert.ToInt32(d.PersonnelNumber));
                else
                    this.LoadData(allPersonnel);
            }

            //if (DepartmentList == true)
            //{
            //    if (familyTextBox.Text != string.Empty)
            //        this.personnelBindingSource.DataSource = TempList.Where(c => c.LastName.Contains(familyTextBox.Text) || c.FirstName.Contains(familyTextBox.Text) || c.PersonnelNumber == familyTextBox.Text).OrderBy(d => Convert.ToInt32(d.PersonnelNumber));
            //    else
            //        this.personnelBindingSource.DataSource = TempList;
            //}


        }

        private void PersonnelListForm_Load(object sender, EventArgs e)
        {
            LoadData(allPersonnel);
        }

        private async void LoadData(bool allOersonnel)
        {
            if (All)
            {
                try
                {
                    personnels = db.Personnels.Where(c => c.IsActive == true).ToList();
                    personnelBindingSource.DataSource = IsActive ? personnels.Where(c => c.IsActive == true).OrderBy(c => Convert.ToInt32(c.PersonnelNumber)) : personnels.OrderBy(c => Convert.ToInt32(c.PersonnelNumber));
                }
                catch (Exception e)
                {
                    Helper.ShowMessage(e.InnerException?.Message ?? e.Message);
                }
            }
            else
            if (AllPersonnel)
            {
                try
                {
                    personnels = db.Personnels.ToList();
                    personnelBindingSource.DataSource = IsActive ? personnels.Where(c => c.IsActive == true).OrderBy(c => Convert.ToInt32(c.PersonnelNumber)) : personnels.OrderBy(c => Convert.ToInt32(c.PersonnelNumber));
                }
                catch (Exception e)
                {
                    Helper.ShowMessage(e.InnerException?.Message ?? e.Message);
                }
            }
            else
            {
                try
                {
                    personnels = await GetAllMemberPersonelCurrentUser(allOersonnel);
                    personnelBindingSource.DataSource = IsActive ? personnels.Where(c => c.IsActive == true).OrderBy(c => Convert.ToInt32(c.PersonnelNumber)) : personnels.OrderBy(c => Convert.ToInt32(c.PersonnelNumber));
                }
                catch (Exception e)
                {
                    Helper.ShowMessage(e.InnerException?.Message ?? e.Message);
                }
            }
                
          
            




        }

        private void familyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (IsActive)
                {
                    if (familyTextBox.Text != string.Empty)
                        personnelBindingSource.DataSource = personnels.Where(c => (c.LastName.Contains(familyTextBox.Text) || c.FirstName.Contains(familyTextBox.Text) || c.PersonnelNumber == familyTextBox.Text) && c.IsActive == true).OrderBy(d => Convert.ToInt32(d.PersonnelNumber));
                    else
                        LoadData(allPersonnel);
                }
                else
                {
                    if (familyTextBox.Text != string.Empty)
                        personnelBindingSource.DataSource = personnels.Where(c => c.LastName.Contains(familyTextBox.Text) || c.FirstName.Contains(familyTextBox.Text) || c.PersonnelNumber == familyTextBox.Text).OrderBy(d => Convert.ToInt32(d.PersonnelNumber));
                    else
                        LoadData(allPersonnel);
                }
            }

        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (personnelBindingSource.Current != null)
            {
                this.Personnel = (Personnel)this.personnelBindingSource.Current;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void personnelDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (personnelBindingSource.Current != null)
            {
                this.Personnel = (Personnel)this.personnelBindingSource.Current;
                this.DialogResult = DialogResult.OK;
            }
        }

        private async Task<List<Personnel>> GetAllMemberPersonelCurrentUser(bool allPersonnel)
        {
            try
            {
                if (allPersonnel)
                    return await Task.FromResult(db.Personnels.ToList());
                //دپارتمان کاربر لاگین شده
                var currentUserDepartmentId = db.DepartmentPersonnels
                                                .FirstOrDefault(p => p.PersonnelID == User.Personnel.Id && p.IsActiveDepartment == true)
                                                ?.DepartmentID ?? 0;
                if (currentUserDepartmentId == 0)
                    throw new Exception("شما عضو هیچ دپارتمانی نیستید");
                //دپارتمان هایی که زیر مجموعه کاربری جاری هستند
                //اگر کاربر جاری زیرمجموعه نداشته باشد یعنی مدیر نباشد
                //لیست دپارتامان همکارانش را نشان میدهد در دپارتمان خودش
                var allDepartment = GetDepartmentChild(currentUserDepartmentId); // لیست آی دی دپارتمان های زیر مجموعه
                //لیست دپارتمان خودش و دپارتمان زیر مجموع ها یش را می دهد
                //سپس لیستی از کاربرانی که عضو این دپارتمان ها هستند را می دهد
                var usersPersonnelsInDepartmentList = (from persons in db.Personnels
                                                       join departmentpersons in db.DepartmentPersonnels
                                                       on persons.Id
                                                       equals departmentpersons.PersonnelID
                                                       where allDepartment.Contains(departmentpersons.DepartmentID) &&  //  کاربرانی که جزو این دپارتمان ها باشند
                                                             departmentpersons.IsActiveDepartment == true  //و دپارتمان آن فعال باشد
                                                       select persons).ToList();
                //لیست کاربرانی که در این سال مالی با این مرحله از ارزیابی قبلا ارزیابی شده اند
                //نمی خواهیم کاربری که قبلا ارزیابی شده در این لیست وجود داشته باشد
                var alreadyPerformEvaPersonsList = (from alreadyPerson in db.PerformancEvaluationMasters
                                                    where usersPersonnelsInDepartmentList.Contains(alreadyPerson.Personnel) &&
                                                          alreadyPerson.FiscalYearID == User.FiscalYearID &&
                                                          alreadyPerson.StepID == stepID
                                                    select alreadyPerson.Personnel).ToList();
                //خارج کردن ارزیابی شده ها از لیست کاربران
                var returnpersonnels = usersPersonnelsInDepartmentList.Except(alreadyPerformEvaPersonsList).ToList();
                return await Task.FromResult(returnpersonnels);
            }
            catch (Exception e)
            {
                throw new Exception(e.InnerException?.Message ?? e.Message);
            }
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
