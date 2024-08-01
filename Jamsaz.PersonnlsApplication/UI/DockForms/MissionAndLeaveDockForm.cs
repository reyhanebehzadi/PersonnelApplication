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
using Jamsaz.PersonnlsApplication.BusinessObjects.Definitions;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class MissionAndLeaveDockForm : BasePersianForm
    {
        public MissionAndLeaveDockForm()
        {
            InitializeComponent();
        }
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        private List<Department> DepartmentList = new List<Department>();
        private List<DepartmentApprovalCategoryPersonnel> departmentApprovalCategoryPersonnels = new List<DepartmentApprovalCategoryPersonnel>();
        private bool hasRepeatedRow = false;

        private void MissionAndLeaveDockForm_Load(object sender, EventArgs e)
        {
            this.treeView.Nodes.Clear();
            var currentVersion = db.DepartmentVersions.SingleOrDefault(c => c.IsActive == true);
            this.DepartmentList = db.Departments.Where(c => c.DepartmentVersionID == currentVersion.ID).ToList();
            foreach (Department item in this.DepartmentList)
            {
                if (item.ParentId == null)
                {
                    TreeNode node = new TreeNode(item.Name);
                    node.Tag = item;
                    this.treeView.Nodes.Add(node);
                    this.LoadChild(node, this.DepartmentList.Where(c => c.ParentId == item.Id).ToList());
                }
            }
        }

        private void LoadChild(TreeNode parentNode, List<Department> childList)
        {
            foreach (Department child in childList)
            {
                TreeNode node = new TreeNode(child.Name);
                node.Tag = child;
                parentNode.Nodes.Add(node);
                this.LoadChild(node, this.DepartmentList.Where(c => c.ParentId == child.Id).ToList());
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Department department = (Department)this.treeView.SelectedNode.Tag;
            if (department == null)
                return;


            AddMissionAndLeaveDialogForm addMissionAndLeaveDialogForm = new AddMissionAndLeaveDialogForm() { FormStatus = FormStatus.Add };
            if (addMissionAndLeaveDialogForm.ShowDialog() == DialogResult.OK)
            {
                if (this.departmentApprovalCategoryPersonnels.Exists(c => c.PersonnelID == addMissionAndLeaveDialogForm.Personnel.Id))
                {
                    Helper.ShowMessage("پرسنل انتخابی در حال حاضر در لیست وجود دارد");
                    return;
                }

                DepartmentApprovalCategoryPersonnel departmentApprovalCategoryPersonnel = new DepartmentApprovalCategoryPersonnel();
                departmentApprovalCategoryPersonnel.DepartmentID = department.Id;

                if (addMissionAndLeaveDialogForm.Personnel != null)
                    departmentApprovalCategoryPersonnel.PersonnelID = addMissionAndLeaveDialogForm.Personnel.Id;

                if (addMissionAndLeaveDialogForm.ReplacementPersonnel != null)
                    departmentApprovalCategoryPersonnel.ReplacementPersonnelID = addMissionAndLeaveDialogForm.ReplacementPersonnel.Id;

                if(addMissionAndLeaveDialogForm.ReplacementPersonnel2 != null)
                    departmentApprovalCategoryPersonnel.ReplacementPersonnelID2 = addMissionAndLeaveDialogForm.ReplacementPersonnel2.Id;

                departmentApprovalCategoryPersonnel.IsNew = true;
                if (this.departmentApprovalCategoryPersonnels.Count != 0)
                    departmentApprovalCategoryPersonnel.Order = this.departmentApprovalCategoryPersonnels.Max(c => c.Order) + 1;
                else
                    departmentApprovalCategoryPersonnel.Order = 1;
                this.departmentApprovalCategoryPersonnels.Add(departmentApprovalCategoryPersonnel);
                this.departmentApprovalCategoryPersonnelBindingSource.DataSource = this.departmentApprovalCategoryPersonnels.OrderBy(c => c.Order);

            }


            this.saveButton.Enabled = true;

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DepartmentApprovalCategoryPersonnel current = (DepartmentApprovalCategoryPersonnel)this.departmentApprovalCategoryPersonnelBindingSource.Current;
            if (current == null)
                return;

            //if (db.LeaveRequestAppovals.Any(c => c.DepartmentApprovalCategoryPersonnelID == current.ID))
            //{
            //    Helper.ShowMessage("امکان حذف وجود ندارد");
            //    return;
            //}


            if (Helper.Confirm("آیا مایل به حذف رکورد انتخاب شده هستید؟") == false)
                return;

            int currentOrder = current.Order;

            try
            {
                if (current.ID != 0)
                {
                    db.DepartmentApprovalCategoryPersonnels.DeleteOnSubmit(current);
                    this.departmentApprovalCategoryPersonnels.Remove(current);
                }

                else
                    this.departmentApprovalCategoryPersonnels.Remove(current);

                //this.departmentApprovalCategoryPersonnelBindingSource.RemoveCurrent();
                departmentApprovalCategoryPersonnelBindingSource.DataSource = departmentApprovalCategoryPersonnels;

                foreach (DepartmentApprovalCategoryPersonnel item in this.departmentApprovalCategoryPersonnels.Where(c => c.Order > currentOrder))
                {
                    item.Order = item.Order - 1;

                }
                this.departmentApprovalCategoryPersonnelBindingSource.DataSource = this.departmentApprovalCategoryPersonnels.Count > 0 ? this.departmentApprovalCategoryPersonnels.OrderBy(c => c.Order) : null;
                this.saveButton.Enabled = true;


            }
            catch (Exception ex)
            {
                Helper.ShowMessage(string.Format("{0}{1}{2}"
                                                            , "بروز خطا"
                                                            , "\n"
                                                            , ex.Message));
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            DepartmentApprovalCategoryPersonnel current = (DepartmentApprovalCategoryPersonnel)this.departmentApprovalCategoryPersonnelBindingSource.Current;
            if (current == null)
                return;


            DepartmentApprovalCategoryPersonnel[] except = new DepartmentApprovalCategoryPersonnel[] { current };
            AddMissionAndLeaveDialogForm addMissionAndLeaveDialogForm = new AddMissionAndLeaveDialogForm() { FormStatus = FormStatus.Edit, DepartmentApprovalCategoryPersonnel = current };
            if (addMissionAndLeaveDialogForm.ShowDialog() == DialogResult.OK)
            {

                if (this.departmentApprovalCategoryPersonnels.Except(except).Where(c => c.PersonnelID == addMissionAndLeaveDialogForm.Personnel.Id).Count() > 0)
                {
                    Helper.ShowMessage("پرسنل انتخابی در حال حاضر در لیست وجود دارد");
                    return;
                }

                current.Personnel = db.Personnels.SingleOrDefault(c => c.Id == addMissionAndLeaveDialogForm.Personnel.Id);
                current.Personnel2 = addMissionAndLeaveDialogForm.ReplacementPersonnel != null ? db.Personnels.SingleOrDefault(c => c.Id == addMissionAndLeaveDialogForm.ReplacementPersonnel.Id) : null;
                current.Personnel1 = addMissionAndLeaveDialogForm.ReplacementPersonnel2 != null ? db.Personnels.SingleOrDefault(c => c.Id == addMissionAndLeaveDialogForm.ReplacementPersonnel2.Id) : null;

                this.departmentApprovalCategoryPersonnelBindingSource.DataSource = this.departmentApprovalCategoryPersonnels.OrderBy(c => c.Order);


                this.saveButton.Enabled = true;

            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (DepartmentApprovalCategoryPersonnel item in this.departmentApprovalCategoryPersonnels)
                {
                    if (item.IsNew)
                    {
                        db.DepartmentApprovalCategoryPersonnels.InsertOnSubmit(item);
                        item.IsNew = false;
                    }
                }

                db.SubmitChanges();
                Helper.ShowMessage("تغییرات ثبت شد");
                this.saveButton.Enabled = false;



            }
            catch (Exception ex)
            {
                Helper.ShowMessage(string.Format("{0}{1}{2}"
                                                            , "بروز خطا"
                                                            , "\n"
                                                            , ex.Message));
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                Department department = (Department)this.treeView.SelectedNode.Tag;
                if (department == null)
                    return;

                db = new JamsazERPLiteDataClassesDataContext();

                this.departmentApprovalCategoryPersonnels = db.DepartmentApprovalCategoryPersonnels.Where(c => c.DepartmentID == department.Id).OrderBy(c => c.Order).ToList();
                this.departmentApprovalCategoryPersonnelBindingSource.DataSource = this.departmentApprovalCategoryPersonnels;


                //this.isChangedToPersonnelList = false;
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(string.Format("{0}{1}{2}"
                                                            , "بروز خطا"
                                                            , "\n"
                                                            , ex.Message));
            }
        }

        private void topButton_Click(object sender, EventArgs e)
        {
            DepartmentApprovalCategoryPersonnel current = (DepartmentApprovalCategoryPersonnel)this.departmentApprovalCategoryPersonnelBindingSource.Current;
            if (current == null)
                return;

            DepartmentApprovalCategoryPersonnel[] except = new DepartmentApprovalCategoryPersonnel[] { current };

            int currentOrder = current.Order;

            current.Order = 1;

            foreach (DepartmentApprovalCategoryPersonnel item in this.departmentApprovalCategoryPersonnels.Except(except).Where(c => c.Order < currentOrder))
            {
                item.Order = item.Order + 1;

            }
            this.departmentApprovalCategoryPersonnelBindingSource.DataSource = this.departmentApprovalCategoryPersonnels.OrderBy(c => c.Order);
            this.saveButton.Enabled = true;
        }

        private void upperButton_Click(object sender, EventArgs e)
        {
            DepartmentApprovalCategoryPersonnel current = (DepartmentApprovalCategoryPersonnel)this.departmentApprovalCategoryPersonnelBindingSource.Current;
            if (current == null)
                return;

            if (current.Order == 1)
                return;


            this.departmentApprovalCategoryPersonnels.Single(c => c.Order == current.Order - 1).Order = current.Order;
            current.Order--;
            this.departmentApprovalCategoryPersonnelBindingSource.DataSource = this.departmentApprovalCategoryPersonnels.OrderBy(c => c.Order);
            this.saveButton.Enabled = true;
        }

        private void lowerbutton_Click(object sender, EventArgs e)
        {
            DepartmentApprovalCategoryPersonnel current = (DepartmentApprovalCategoryPersonnel)this.departmentApprovalCategoryPersonnelBindingSource.Current;
            if (current == null)
                return;

            if (current.Order == this.departmentApprovalCategoryPersonnels.Max(c => c.Order))
                return;

            this.departmentApprovalCategoryPersonnels.Single(c => c.Order == current.Order + 1).Order = current.Order;
            current.Order++;
            this.departmentApprovalCategoryPersonnelBindingSource.DataSource = this.departmentApprovalCategoryPersonnels.OrderBy(c => c.Order);
            this.saveButton.Enabled = true;

        }

        private void lowestButton_Click(object sender, EventArgs e)
        {
            DepartmentApprovalCategoryPersonnel current = (DepartmentApprovalCategoryPersonnel)this.departmentApprovalCategoryPersonnelBindingSource.Current;
            if (current == null)
                return;

            DepartmentApprovalCategoryPersonnel[] except = new DepartmentApprovalCategoryPersonnel[] { current };

            int currentOrder = current.Order;

            current.Order = this.departmentApprovalCategoryPersonnels.Max(c => c.Order);

            foreach (DepartmentApprovalCategoryPersonnel item in this.departmentApprovalCategoryPersonnels.Except(except).Where(c => c.Order > currentOrder))
            {
                item.Order = item.Order - 1;

            }
            this.departmentApprovalCategoryPersonnelBindingSource.DataSource = this.departmentApprovalCategoryPersonnels.OrderBy(c => c.Order);
            this.saveButton.Enabled = true;
        }

        private void departmentApprovalCategoryPersonnelBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DepartmentApprovalCategoryPersonnel current = (DepartmentApprovalCategoryPersonnel)departmentApprovalCategoryPersonnelBindingSource.Current;
            if (current != null && current.ID == 0)
            
                editButton.Enabled = false;
            
            else
                editButton.Enabled = true;
        }
    }
}

