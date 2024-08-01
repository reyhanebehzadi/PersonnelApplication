using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.PersonnlsApplication.Classes;

namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class RolesStructureDialogForm : BasePersianForm
    {
        public RolesStructureDialogForm(JamsazERPLiteDataClassesDataContext db, int? hasOrganizationStructureID, int? hasOrganizationStructureversionID)
        {
            InitializeComponent();
            this.hasOrganizationStructureID = hasOrganizationStructureID;
            this.hasOrganizationStructureversionID = hasOrganizationStructureversionID;
            this.db = db;
        }
        int? hasOrganizationStructureID = null;
        int? hasOrganizationStructureversionID = null;
        private List<TreeNode> roleStructureTreeViewSearchResult = new List<TreeNode>();
        JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
        IEnumerable<OrganizationStructure> RolesStructures;
        OrganizationStructureVersion currentOrganizationStructureVersion = new OrganizationStructureVersion();
        bool isChangedOrganizationStructureVersion = false;
        bool treeviewNodeStatus = false;
        public OrganizationStructure SelectedOrganizationStructure { get; set; }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            roleStructureTreeViewSearchResult = rolesStructuretreeView.GetAllNodes().Where(c => c.Text.Contains(nameTextBox.Text)).ToList();
            if (roleStructureTreeViewSearchResult.Count() != 0)
                rolesStructuretreeView.SelectedNode = roleStructureTreeViewSearchResult.First();

            if (roleStructureTreeViewSearchResult.Count > 1)
                nextButton.Enabled = true;
            else
                nextButton.Enabled = false;

            rolesStructuretreeView.Focus();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            int lastIndex = roleStructureTreeViewSearchResult.FindIndex(c => c == rolesStructuretreeView.SelectedNode);
            lastIndex = lastIndex + 1;
            if (roleStructureTreeViewSearchResult.Count() > 1 && (roleStructureTreeViewSearchResult.Count() - 1) >= lastIndex)
                rolesStructuretreeView.SelectedNode = roleStructureTreeViewSearchResult.Skip(lastIndex).First();
            else
            {
                lastIndex = 0;
                rolesStructuretreeView.SelectedNode = roleStructureTreeViewSearchResult.First();
            }

            rolesStructuretreeView.Focus();
        }

        private void selectOrganizationStructureVersionButton_Click(object sender, EventArgs e)
        {

            if (organizationStructureVersionComboBox.SelectedItem == null)
            {
                Jamsaz.Common.Helper.ShowMessage("لطفا نسخه را انتخاب کنید");
                return;
            }



            currentOrganizationStructureVersion = (OrganizationStructureVersion)organizationStructureVersionComboBox.SelectedItem;
            if (currentOrganizationStructureVersion.IsActive == true)
                activeOrganizationStructureVersionLabel.Visible = true;
            else activeOrganizationStructureVersionLabel.Visible = false;

            RolesStructures = db.OrganizationStructures.Where(c => c.OrganizationStructureVersionID == currentOrganizationStructureVersion.ID).AsEnumerable();
            MakeTree<OrganizationStructure> makeTree = new MakeTree<OrganizationStructure>();
            if (RolesStructures.Count() != 0)
            {
                OrganizationStructure organizationStructureRoot = db.OrganizationStructures.Single(c => currentOrganizationStructureVersion.ID == c.OrganizationStructureVersionID && c.ParentId == null);
                makeTree.NodeTitlePropertyName = "Name";
                makeTree.NodeParentKeyPropertyName = "ParentId";
                makeTree.NodeKeyPropertyName = "Id";
                rolesStructuretreeView.Nodes.Clear();
                makeTree.CreateChartTree(organizationStructureRoot, RolesStructures, rolesStructuretreeView, organizationStructureRoot);
                isChangedOrganizationStructureVersion = false;
            }
        }

        private void collapseAndExpandButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (treeviewNodeStatus == false)
                {
                    rolesStructuretreeView.CollapseAll();
                    rolesStructuretreeView.Nodes[0].Expand();
                    treeviewNodeStatus = true;
                    collapseAndExpandButton.Text = "باز کردن";
                }
                else
                {
                    rolesStructuretreeView.ExpandAll();
                    rolesStructuretreeView.Nodes[0].Expand();
                    treeviewNodeStatus = false;
                    collapseAndExpandButton.Text = "جمع کردن";
                }
            }
            catch { }
        }

        private void RolesStructureDialogForm_Load(object sender, EventArgs e)
        {
            organizationStructureVersionBindingSource.DataSource = from c in db.OrganizationStructureVersions orderby c.Code descending select c;

            if (hasOrganizationStructureversionID != null)
            {
                organizationStructureVersionComboBox.SelectedValue = hasOrganizationStructureversionID;
                selectOrganizationStructureVersionButton_Click(null, null);
                TreeNode departmentForCurrentUser = rolesStructuretreeView.GetAllNodes().First(c => ((OrganizationStructure)c.Tag).Id == hasOrganizationStructureID);
                rolesStructuretreeView.SelectedNode = departmentForCurrentUser;
                rolesStructuretreeView.Focus();

            }
            else
            {
                selectOrganizationStructureVersionButton_Click(null, null);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (passNullCheckBox.Checked)
            {
                this.SelectedOrganizationStructure = null;
                this.DialogResult = DialogResult.OK;
            }

            else
            {
                if (this.SelectedOrganizationStructure != null)
                    this.DialogResult = DialogResult.OK;
                else
                    Helper.ShowMessage("لطفا واحد را انتخاب کنید");
            }
        }

        private void rolesStructuretreeView_MouseDown(object sender, MouseEventArgs e)
        {
            SetSelectedNodeByPosition(rolesStructuretreeView, e.X, e.Y);
            if (rolesStructuretreeView.SelectedNode == null) { return; }
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
                this.SelectedOrganizationStructure = (OrganizationStructure)treeview.SelectedNode.Tag;

                if (node == null) return;

                if (!node.Bounds.Contains(pointNode)) { return; }

            }
            catch { }
            return;
        }
    }
}
