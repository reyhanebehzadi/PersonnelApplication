using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.Classes;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using System.Collections;
using Jamsaz.PersonnlsApplication.UI.DialogForms;
using Jamsaz.PersonnlsApplication.Classes;
using System.Data.Linq;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class departmentsForm : BasePersianForm
    {
        public departmentsForm()
        {
            InitializeComponent();
        }

        JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
        IEnumerable<Department> departments;
        Queue QColection = new Queue();
        bool treeviewNodeStatus = false;
        TreeNode sourceNodeForCute = new TreeNode();
        Department sourceDepartmentForCute = new Department();
        bool isChangedDepartmentVersion = false;
        private List<TreeNode> departmentTreeViewSearchResult = new List<TreeNode>();

        private void departmentsForm_Load(object sender, EventArgs e)
        {
            DataLoadOptions dataLoadOptions = new DataLoadOptions();
            dataLoadOptions.LoadWith<DepartmentVersion>(c => c.Departments);
            db.LoadOptions = dataLoadOptions;
            departmentVersionBindingSource.DataSource = from c in db.DepartmentVersions orderby c.Code descending select c;
            this.departmentVersionComboBox.SelectedValueChanged += new EventHandler(departmentVersionComboBox_SelectedValueChanged);
            if (db.Departments.Count(c => c.DepartmentVersionID == (int)this.departmentVersionComboBox.SelectedValue) != 0)
                this.copyButton.Enabled = false;
            else
                this.copyButton.Enabled = true;
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

        private void NextButton_Click(object sender, EventArgs e)
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

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                SearchButton_Click(null, null);
        }

        private void collapseAndExpandButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (treeviewNodeStatus == false)
                {
                    departmentTreeView.CollapseAll();
                    departmentTreeView.Nodes[0].Expand();
                    treeviewNodeStatus = true;
                    collapseAndExpandButton.Text = "باز کردن";
                }
                else
                {
                    departmentTreeView.ExpandAll();
                    departmentTreeView.Nodes[0].Expand();
                    treeviewNodeStatus = false;
                    collapseAndExpandButton.Text = "جمع کردن";
                }
            }
            catch { }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (departmentTreeView.Nodes.Count == 0)
                {
                    Helper.ShowMessage("نسخه بخش  را انتخاب کنید");
                    return;
                }

                if (isChangedDepartmentVersion)
                {
                    Helper.ShowMessage("نسخه بخش تغییر کرده لطفا دوباره نسخه را انتخاب کنید");
                    return;
                }

                if (departmentTreeView.SelectedNode == null)
                {
                    Helper.ShowMessage("ابتدا یک واحد سازمانی را انتخاب نمایید");
                    return;
                }
                TreeNode treeNode = new TreeNode();
                Department department = new Department();

                department.ParentId = ((Department)departmentTreeView.SelectedNode.Tag).Id;

                departmentEditDialogForm departmentEditDialogForm = new departmentEditDialogForm(departmentEditDialogForm.ActionForm.Insert, ((DepartmentVersion)departmentVersionComboBox.SelectedItem).ID) { db = db };
                departmentEditDialogForm.SelectDepartment = department;

                if (departmentEditDialogForm.ShowDialog() == DialogResult.OK)
                {
                    department.DepartmentVersionID = ((DepartmentVersion)departmentVersionComboBox.SelectedItem).ID;
                    db.Departments.InsertOnSubmit(department);
                    db.SubmitChanges();
                    treeNode.Tag = departmentEditDialogForm.SelectDepartment;
                    treeNode.Text = departmentEditDialogForm.SelectDepartment.Name;
                    departmentTreeView.SelectedNode.Nodes.Add(treeNode);
                    treeNode.ImageIndex = 0;
                    departmentTreeView.SelectedNode = treeNode;

                }
            }
            catch (Exception exp)
            {
                throw exp;
            }

        }

        private void EditNode()
        {
            if (departmentTreeView.SelectedNode != null)
            {
                departmentEditDialogForm departmentEditDialogForm = new departmentEditDialogForm(departmentEditDialogForm.ActionForm.Edit, ((DepartmentVersion)departmentVersionComboBox.SelectedItem).ID){ db = db };
                Department department = db.Departments.Single(c => c.Id == ((Department)departmentTreeView.SelectedNode.Tag).Id);
                departmentEditDialogForm.SelectDepartment = department;
                if (departmentEditDialogForm.ShowDialog() == DialogResult.OK)
                {
                   
                    department = departmentEditDialogForm.SelectDepartment;
                    departmentTreeView.SelectedNode.Text = department.Name;
                    db.SubmitChanges();

                    if (department.OriginalDepartmentID != null)
                        departmentTreeView.SelectedNode.ForeColor = Color.Green;
                }
            }
            else
            {
                Helper.ShowMessage("ابتدا یک واحد سازمانی را انتخاب نمایید");
                return;
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (departmentTreeView.Nodes.Count == 0)
            {
                Helper.ShowMessage("نسخه بخش  را انتخاب کنید");
                return;
            }

            if (isChangedDepartmentVersion)
            {
                Helper.ShowMessage("نسخه بخش تغییر کرده لطفا دوباره نسخه را انتخاب کنید");
                return;
            }

            EditNode();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (departmentTreeView.Nodes.Count == 0)
                {
                    Helper.ShowMessage("نسخه بخش  را انتخاب کنید");
                    return;
                }

                if (isChangedDepartmentVersion)
                {
                    Helper.ShowMessage("نسخه بخش تغییر کرده لطفا دوباره نسخه را انتخاب کنید");
                    return;
                }

                if (departmentTreeView.SelectedNode == null)
                {
                    Helper.ShowMessage("ابتدا یک واحد سازمانی را انتخاب نمایید");
                    return;
                }
                if (((Department)departmentTreeView.SelectedNode.Tag).ParentId == null)
                {
                    Helper.ShowMessage("شاخه اصلی غیر قابل پاک کردن می باشد");
                    return;
                }


                if (departmentTreeView.SelectedNode.Nodes.Count > 0)
                {
                    Helper.ShowMessage("ابتدا باید تمام واحدهای زیرمجموعه حذف شوند");
                    return;
                }

                if (Helper.Confirm("آيا می خواهید حذف شود؟", "حذف") == false)
                    return;

                int IDDepartment = ((Department)departmentTreeView.SelectedNode.Tag).Id;
                var ListPersonnels = from p in db.Personnels where p.DepartmentId == IDDepartment select new { PN = p.PersonnelNumber, FullName = p.FirstName + " " + p.LastName };

                int CountPersonal = ListPersonnels.Count();
                if (CountPersonal != 0)
                {
                    string Personnels = string.Empty;
                    foreach (var item in ListPersonnels)
                    {
                        CountPersonal += 1;
                        Personnels += item.PN + " " + item.FullName + "\n";
                    }
                    Helper.ShowMessage("در این واحد" + CountPersonal + " کاربر تخصیص داده شده!"
                                       + "ابتدا  باید تمام کاربران را در این واحد حذف کنید\n" + Personnels);
                    return;
                }

                Department department = (Department)departmentTreeView.SelectedNode.Tag;

                db.Departments.DeleteOnSubmit(department);
                db.SubmitChanges();
                departmentTreeView.SelectedNode.Remove();
            }
            catch (Exception exp)
            {
                Helper.ShowMessage(exp.Message);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool CtrlButton = false;

            Keys valKeys = (Keys)(int)((short)keyData);

            if ((keyData & Keys.Control) == Keys.Control)
            {
                CtrlButton = true;
            }

            if ((valKeys == Keys.A) && CtrlButton)
            {
                try
                {
                    if (nextButton.Enabled)
                    {
                        NextButton_Click(null, null);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if ((valKeys == Keys.S) && CtrlButton)
            {
                try
                {
                    if (this.ActiveControl == nameTextBox)
                        SearchButton_Click(null, null);
                    else
                        this.ActiveControl = nameTextBox;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void departmentTreeView_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:

                    contextMenuStrip.Show(departmentTreeView, new Point(e.X, e.Y));
                    return;

                default:
                    break;
            }
        }

        private void departmentTreeView_MouseDown(object sender, MouseEventArgs e)
        {
            SetSelectedNodeByPosition(departmentTreeView, e.X, e.Y);
            if (departmentTreeView.SelectedNode == null) { return; }
            if (e.Button == MouseButtons.Right) { return; }
        }

        public void SetSelectedNodeByPosition(TreeView treeview, int mouseX, int mouseY)
        {
            TreeNode node = null;
            try
            {
                Point pointNode = new Point(mouseX, mouseY);

                treeview.PointToClient(pointNode);

                node = treeview.GetNodeAt(pointNode);

                treeview.SelectedNode = node;

                if (node == null) return;

                if (!node.Bounds.Contains(pointNode)) { return; }

            }
            catch { }
            return;
        }

        private void cuteToolStripMenuItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (isChangedDepartmentVersion)
                {
                    Helper.ShowMessage("نسخه بخش تغییر کرده لطفا دوباره نسخه را انتخاب کنید");
                    return;
                }

                sourceDepartmentForCute = ((Department)departmentTreeView.SelectedNode.Tag);
                sourceNodeForCute = departmentTreeView.SelectedNode;



                pastNodeToolStripMenuItemToolStripMenuItem.Enabled = true;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        private void pastNodeToolStripMenuItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isChangedDepartmentVersion)
            {
                Helper.ShowMessage("نسخه بخش تغییر کرده لطفا دوباره نسخه را انتخاب کنید");
                return;
            }

            MakeTree<Department> makeTree = new MakeTree<Department>();
            makeTree.NodeTitlePropertyName = "Name";
            makeTree.NodeParentKeyPropertyName = "ParentId";
            makeTree.NodeKeyPropertyName = "Id";
            Department currentDepartment = (Department)departmentTreeView.SelectedNode.Tag;

            makeTree.FindNodeDetail(sourceDepartmentForCute, db.Departments.AsEnumerable(), currentDepartment.Id);
            if (!makeTree.IsFindeNode)
            {
                if (sourceDepartmentForCute.Id != 0 && sourceDepartmentForCute.Id != currentDepartment.Id)
                {
                    sourceDepartmentForCute.ParentId = currentDepartment.Id;
                    System.Data.Linq.ChangeSet changeSet = db.GetChangeSet();
                    db.SubmitChanges();
                    db.Refresh(System.Data.Linq.RefreshMode.KeepChanges, sourceDepartmentForCute);
                    sourceNodeForCute.Remove();
                    departmentTreeView.SelectedNode.Nodes.Insert(sourceNodeForCute.Index, sourceNodeForCute);
                    departmentTreeView.SelectedNode = sourceNodeForCute;
                }
            }
            else
                Helper.ShowMessage("انتقال به این  قسمت امکان پذیر نیست در بخش دیگر سعی کنید");

            pastNodeToolStripMenuItemToolStripMenuItem.Enabled = false;


        }

        private void selectDepartmentversionButton_Click(object sender, EventArgs e)
        {


            DepartmentVersion currentDepartmentVersion = (DepartmentVersion)departmentVersionComboBox.SelectedItem;
            if (currentDepartmentVersion.IsActive == true)
                activeDepartmentVersionLabel.Visible = true;
            else
                activeDepartmentVersionLabel.Visible = false;


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

            foreach (TreeNode node in this.departmentTreeView.GetAllNodes())
            {
                if (((Department)node.Tag).OriginalDepartmentID == null)
                    node.ForeColor = Color.Red;
                else
                    node.ForeColor = Color.Green;

            }
            this.departmentTreeView.ExpandAll();
        }

        private void departmentVersionComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            isChangedDepartmentVersion = true;
            if (this.departmentVersionComboBox.SelectedValue == null)
                return;

            if (db.Departments.Count(c => c.DepartmentVersionID == (int)this.departmentVersionComboBox.SelectedValue) != 0)
                this.copyButton.Enabled = false;
            else
                this.copyButton.Enabled = true;

        }

        private void insertNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addButton_Click(null, null);
        }

        private void editNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editButton_Click(null, null);
        }

        private void deletNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteButton_Click(null, null);
        }

        private void panelBottom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void originalDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.departmentTreeView.SelectedNode == null)
                return;

            if (this.departmentTreeView.SelectedNode.Tag == null)
                return;

            try
            {
                //Department department = db.Departments.Single(c => c.Id == ((Department)departmentTreeView.SelectedNode.Tag).Id);
                SetOriginalDepartmentDialogForm setOriginalDepartmentDialogForm = new SetOriginalDepartmentDialogForm() { db = db, Department = (Department)this.departmentTreeView.SelectedNode.Tag, CurrentDepartmentVersionID = (int)this.departmentVersionComboBox.SelectedValue };
                if (setOriginalDepartmentDialogForm.ShowDialog() == DialogResult.OK)
                {
                    this.departmentTreeView.SelectedNode.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(string.Format("{0}{1}{2}"
                                                            , "بروز خطا"
                                                            , "\n"
                                                            , ex.Message));
            }
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            DepartmentVersionDialogForm departmentVersionDialogForm = new DepartmentVersionDialogForm() { db = db, CurrentDepartmentVersionID = (int)this.departmentVersionComboBox.SelectedValue };
            if (departmentVersionDialogForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<DepartmentEX> departmentEXlist = (from c in db.Departments
                                                           where c.DepartmentVersion == departmentVersionDialogForm.SelectDepartmentVersion
                                                           select new DepartmentEX
                                                           {
                                                               Id = c.Id,
                                                               Name = c.Name,
                                                               NameEn = c.NameEn,
                                                               Code = c.Code,
                                                               Description = c.Description,
                                                               ParentId = c.ParentId,
                                                               DepartmentVersionID = c.DepartmentVersionID,
                                                               OriginalDepartmentID = c.OriginalDepartmentID,

                                                           }).OrderBy(c => c.Id).ToList();


                    List<Department> newDepartments = new List<Department>();

                    foreach (DepartmentEX item in departmentEXlist)
                    {
                        Department department = new Department();
                        department.Name = item.Name;
                        department.NameEn = item.NameEn;
                        department.Code = item.Code;
                        department.DepartmentVersionID = (int)this.departmentVersionComboBox.SelectedValue;
                        department.OriginalDepartmentID = item.OriginalDepartmentID;
                        item.ParentOfChildDepartment = department;
                        newDepartments.Add(department);
                    }

                    foreach (Department item in newDepartments)
                    {
                        if (departmentEXlist.Single(c => c.Code == item.Code).ParentId == null)
                            item.ParentId = null;
                        else
                        {
                            item.Department1 = departmentEXlist.Single(c => c.Id == departmentEXlist.Single(g => g.Code == item.Code).ParentId).ParentOfChildDepartment;
                        }
                    }

                    db.Departments.InsertAllOnSubmit(newDepartments);
                    db.SubmitChanges();
                    this.selectDepartmentversionButton_Click(null, null);
                }
                catch (Exception ex)
                {
                    Helper.ShowMessage(string.Format("{0}{1}{2}"
                                                                , "بروز خطا"
                                                                , "\n"
                                                                , ex.Message));
                }
            }
        }

        private void departmentTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag == null)
                return;

            Department department = (Department)e.Node.Tag;
            this.codeTextBox.Text = department.Code;
            this.currentNameTextBox.Text = department.Name;

            this.originalCodeTextBox.Text = department.OriginalCode;
            this.originalNameTextBox.Text = department.OriginalName;
        }

        private void selectOriginalDepartmentButton_Click(object sender, EventArgs e)
        {
            if (this.departmentTreeView.SelectedNode.Tag == null)
                return;

            try
            {
                Department department = (Department)this.departmentTreeView.SelectedNode.Tag;

                OriginalDepartmentListDialogForm originalDepartmentListDialogForm = new OriginalDepartmentListDialogForm() { db = db, CurrentDepartmentVersionID = (int)this.departmentVersionComboBox.SelectedValue };
                if (originalDepartmentListDialogForm.ShowDialog() == DialogResult.OK)
                {
                    department.OriginalDepartment = originalDepartmentListDialogForm.SelectOriginalDepartment;
                    originalDepartmentListDialogForm.SelectOriginalDepartment.LatestName = department.Name;
                    this.originalCodeTextBox.Text = department.OriginalCode;
                    this.originalNameTextBox.Text = department.OriginalName;
                    this.departmentTreeView.SelectedNode.ForeColor = Color.Green;
                }

                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(string.Format("{0}{1}{2}"
                                                            , "بروز خطا"
                                                            , "\n"
                                                            , ex.Message));
            }
        }
    }
}
