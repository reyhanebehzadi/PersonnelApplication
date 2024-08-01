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

namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class DepartmentsDialogForm : BasePersianForm
    {

        public DepartmentsDialogForm(JamsazERPLiteDataClassesDataContext db, int? hassDepartmentID, int? hassDepartmentVersionID)
        {
            InitializeComponent();
            this.hassDepartmentID = hassDepartmentID;
            this.hassDepartmentVersionID = hassDepartmentVersionID;
            this.db = db;
        }

        int? hassDepartmentID = null;
        int? hassDepartmentVersionID = null;

        JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
        IEnumerable<Department> departments;
        bool treeviewNodeStatus = false;
        TreeNode sourceNodeForCute = new TreeNode();
        Department sourceDepartmentForCute = new Department();
        bool isChangedDepartmentVersion = false;
        private List<TreeNode> departmentTreeViewSearchResult = new List<TreeNode>();

        public Department SelectedDepartment { get; set; }
        
        private void DepartmentsDialogForm_Load(object sender, EventArgs e)
        {
            departmentVersionBindingSource.DataSource = from c in db.DepartmentVersions orderby c.Code descending select c;

            if (hassDepartmentVersionID != null)
            {
                departmentVersionComboBox.SelectedValue = hassDepartmentVersionID;
                selectDepartmentversionButton_Click(null, null);
                TreeNode departmentForCurrentUser = departmentTreeView.GetAllNodes().First(c => ((Department)c.Tag).Id == hassDepartmentID);
                departmentTreeView.SelectedNode = departmentForCurrentUser;
                departmentTreeView.Focus();
            }
            else
            {
                selectDepartmentversionButton_Click(null, null);
            }

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
                this.SelectedDepartment = (Department)treeview.SelectedNode.Tag;

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
            if (currentDepartmentVersion == null)
            { Helper.ShowMessage("نسخه انتخاب نشده"); return; }

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

        private void departmentVersionComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            isChangedDepartmentVersion = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (passNullCheckBox.Checked)
            { this.SelectedDepartment = null; this.DialogResult = DialogResult.OK; }

            else
            {
                if (this.SelectedDepartment != null)
                    this.DialogResult = DialogResult.OK;
                else
                    Helper.ShowMessage("لطفا واحد را انتخاب کنید");
            }
                
            
        }



    }
}
