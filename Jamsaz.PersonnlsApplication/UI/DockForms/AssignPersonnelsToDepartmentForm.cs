using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.PersonnlsApplication.Classes;
using Jamsaz.Common;
using System.Data.Linq;
namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class AssignPersonnelsToDepartmentForm : Jamsaz.Common.BasePersianForm
    {
        public AssignPersonnelsToDepartmentForm()
        {
            InitializeComponent();
        }

        #region definitions

        bool isChangedDepartmentVersion = false;

        private List<TreeNode> departmentTreeViewSearchResult = new List<TreeNode>();

        IEnumerable<Department> departments;

        Department currentDepartment = new Department();

        DepartmentVersion currentDepartmentVersion = new DepartmentVersion();

        JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
        #endregion

        private void AssignPersonnelsToDepartmentForm_Load(object sender, EventArgs e)
        {



            departmentVersionBindingSource.DataSource = from c in db.DepartmentVersions orderby c.Code descending select c;
        }

        private void selectDepartmentversionButton_Click(object sender, EventArgs e)
        {
            if (departmentVersionComboBox.SelectedItem == null)
            {
                Jamsaz.Common.Helper.ShowMessage("لطفا نسخه را انتخاب کنید");
                return;
            }



            currentDepartmentVersion = (DepartmentVersion)departmentVersionComboBox.SelectedItem;
            if (currentDepartmentVersion.IsActive == true)
                activeDepartmentVersionLabel.Visible = true;
            else activeDepartmentVersionLabel.Visible = false;

            departments = db.Departments.Where(c => c.DepartmentVersionID == currentDepartmentVersion.ID).AsEnumerable();
            MakeTree<Department> makeTree = new MakeTree<Department>();
            if (departments.Count() != 0)
            {
                Department departmentRoot = departments.Single(c => currentDepartmentVersion.ID == c.DepartmentVersionID && c.ParentId == null);
                makeTree.NodeTitlePropertyName = "Name";
                makeTree.NodeParentKeyPropertyName = "ParentId";
                makeTree.NodeKeyPropertyName = "Id";
                departmentTreeView.Nodes.Clear();
                makeTree.CreateChartTree(departmentRoot, departments, departmentTreeView, departmentRoot);
                isChangedDepartmentVersion = false;
            }
        }

        private void departmentVersionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            isChangedDepartmentVersion = true;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameTextBox.Text))
            {
                departmentTreeViewSearchResult = departmentTreeView.GetAllNodes().Where(c => c.Text.Contains(nameTextBox.Text)).ToList();
                if (departmentTreeViewSearchResult.Count() != 0)
                    departmentTreeView.SelectedNode = departmentTreeViewSearchResult.First();
                departmentTreeView.Focus();
                if (departmentTreeViewSearchResult.Count > 1)
                    nextButton.Enabled = true;
                else
                    nextButton.Enabled = false;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            int lastIndex = departmentTreeViewSearchResult.FindIndex(c => c == departmentTreeView.SelectedNode);
            lastIndex = lastIndex + 1;
            if (departmentTreeViewSearchResult.Count() > 1 && (departmentTreeViewSearchResult.Count() - 1) >= lastIndex)
                departmentTreeView.SelectedNode = departmentTreeViewSearchResult.Skip(lastIndex).First();
            else
            {
                lastIndex = 0;
                departmentTreeView.SelectedNode = departmentTreeViewSearchResult.First();
            }

            departmentTreeView.Focus();
        }

        private void departmentTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                currentDepartment = (Department)e.Node.Tag;
                //Why ? !!!!!!!!! Commented by mostafa
             //   db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
                allAssignDepartmentForCurrentPersonnleBindingSource.DataSource = null;
                departmentPersonnelBindingSource.DataSource = db.DepartmentPersonnels.Where(c => c.DepartmentID == currentDepartment.Id);
            }
        }

        private void assignPersonnelsButton_Click(object sender, EventArgs e)
        {
            List<int> hassPersonnelFromCurrentDepartment = new List<int>();
            foreach (DepartmentPersonnel departmentPersonnel in departmentPersonnelBindingSource.List)
            {
                hassPersonnelFromCurrentDepartment.Add(departmentPersonnel.PersonnelID);
            }


            Jamsaz.PersonnlsApplication.UI.DockForms.PersonnelsListForAssignForm personnelsListForAssignFrom = new PersonnelsListForAssignForm();
            personnelsListForAssignFrom.HassPersonnles = hassPersonnelFromCurrentDepartment;

            if (personnelsListForAssignFrom.ShowDialog() == DialogResult.OK)
            {
                foreach (Personnels_FullSearchAdvanced1Result resultSearchAdenced in personnelsListForAssignFrom.GetPersonnels)
                {

                    DepartmentPersonnel departmentPersonnel = (DepartmentPersonnel)departmentPersonnelBindingSource.AddNew();
                    departmentPersonnel.PersonnelName = resultSearchAdenced.FullNameFa;
                    departmentPersonnel.DepartmentID = currentDepartment.Id;
                    departmentPersonnel.PersonnelID = resultSearchAdenced.Id;
                    if (currentDepartmentVersion.IsActive == true)
                    {
                        SetActiveDepartmentForCurrentPersonnel(resultSearchAdenced.Id, true, currentDepartmentVersion.ID);
                        departmentPersonnel.IsActiveDepartment = true;
                    }
                    departmentPersonnel.IsActiveDepartment = false;
                    departmentPersonnelBindingSource.EndEdit();

                }
                db.SubmitChanges();
            }
            RefreshDataGrid();

        }

        private void deletePersonnelFromCurrentDepartmentButton_Click(object sender, EventArgs e)
        {
            if (departmentPersonnelBindingSource.Current != null)
            {
                if (Helper.Confirm("آیا مایل به حذف رکورد جاری هستید؟"))
                {
                    departmentPersonnelBindingSource.RemoveCurrent();
                    db.SubmitChanges();
                    RefreshDataGrid();
                }
            }
        }

        private void departmentPersonnelBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (departmentPersonnelBindingSource.Current != null)
            {
                DepartmentPersonnel currentDepartmentPersonnel = (DepartmentPersonnel)departmentPersonnelBindingSource.Current;
                allAssignDepartmentForCurrentPersonnleGroupBox.Text = " تمام بخش های که پرسنل " + currentDepartmentPersonnel.PersonnelName + " در آن مشغول به کار بوده ";
                allAssignDepartmentForCurrentPersonnleBindingSource.DataSource = db.DepartmentPersonnels.Where(c => c.PersonnelID == currentDepartmentPersonnel.PersonnelID);
            }
            else
            {
                allAssignDepartmentForCurrentPersonnleGroupBox.Text = "تمام بخش های که پرسنل در آن مشغول به کار بوده";
                allAssignDepartmentForCurrentPersonnleBindingSource.DataSource = null;
            }
        }
        #region functions
        private void RefreshDataGrid()
        {
            if (departmentPersonnelBindingSource.Current != null)
            {
                DepartmentPersonnel currentDepartmentPersonnel = (DepartmentPersonnel)departmentPersonnelBindingSource.Current;
                allAssignDepartmentForCurrentPersonnleGroupBox.Text = " تمام بخش های که پرسنل " + currentDepartmentPersonnel.PersonnelName + " در آن مشغول به کار بوده ";
                allAssignDepartmentForCurrentPersonnleBindingSource.DataSource = db.DepartmentPersonnels.Where(c => c.PersonnelID == currentDepartmentPersonnel.PersonnelID);
            }
        }
        private void SetActiveDepartmentForCurrentPersonnel(int? personnelID, bool isApplyNullForAllDepartments, int currentDepartmentVersionID)
        {
            Jamsaz.PersonnlsApplication.BusinessObjects.Data.JamsazERPLiteDataClassesDataContext db2 = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);

            IQueryable<DepartmentPersonnel> departmentPersonnels = db2.DepartmentPersonnels.Where(c => c.PersonnelID == personnelID && c.Department.DepartmentVersionID == currentDepartmentVersionID);
            DepartmentPersonnel CurrentDepartmentPersonnel = (DepartmentPersonnel)departmentPersonnelBindingSource.Current;

            foreach (DepartmentPersonnel departmentPersonnel in departmentPersonnels)
            {
                if (isApplyNullForAllDepartments == false)
                {
                    departmentPersonnel.IsActiveDepartment = false;
                    if (CurrentDepartmentPersonnel.ID == departmentPersonnel.ID)
                        departmentPersonnel.IsActiveDepartment = true;
                }
                else
                {
                    departmentPersonnel.IsActiveDepartment = false;
                }
            }
            db2.SubmitChanges();

        }

        #endregion

        private void setActiveDepartmentButton_Click(object sender, EventArgs e)
        {
            if (departmentPersonnelBindingSource.Current != null)
            {
                if (currentDepartmentVersion.IsActive == true)
                {
                    SetActiveDepartmentForCurrentPersonnel(((DepartmentPersonnel)departmentPersonnelBindingSource.Current).PersonnelID, false, currentDepartmentVersion.ID);
                    db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
                    departmentPersonnelBindingSource.DataSource = db.DepartmentPersonnels.Where(c => c.DepartmentID == currentDepartment.Id);
                }
                else
                    Helper.ShowMessage("این نسخه بخش ها در سیستم فعال نیست ");
            }
        }

        private void departmentPersonnelBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            departmentPersonnelBindingSource_PositionChanged(null, null);
        }



    }
}
