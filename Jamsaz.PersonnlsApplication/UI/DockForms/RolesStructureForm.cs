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
using System.Collections;
using Jamsaz.PersonnlsApplication.Classes;
using Jamsaz.PersonnlsApplication.UI.DialogForms;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class rolesStructureForm : BasePersianForm
    {
        public rolesStructureForm()
        {
            InitializeComponent();
        }
        JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
        IEnumerable<OrganizationStructure> RolesStructures;
        bool treeviewNodeStatus = false;
        private List<TreeNode> roleStructureTreeViewSearchResult = new List<TreeNode>();
        OrganizationStructure sourceOrganizationStructure = new OrganizationStructure();
        TreeNode sourceNodeForCute = new TreeNode();
        bool isChangedOrganizationStructureVersion = false;
        OrganizationStructureVersion currentOrganizationStructureVersion = new OrganizationStructureVersion();
        private void RolesStructureForm_Load(object sender, EventArgs e)
        {
            organizationStructureVersionBindingSource.DataSource = from c in db.OrganizationStructureVersions orderby c.Code descending select c;
            //RolesStructures = db.OrganizationStructures.AsEnumerable();
            //MakeTree<OrganizationStructure> makeTree = new MakeTree<OrganizationStructure>();
            //OrganizationStructure organizationStructureRoot = RolesStructures.Single(c => c.ParentId == null);
            //makeTree.NodeTitlePropertyName = "Name";
            //makeTree.NodeParentKeyPropertyName = "ParentId";
            //makeTree.NodeKeyPropertyName = "Id";
            //makeTree.CreateChartTree(organizationStructureRoot, RolesStructures, rolesStructureTreeView, organizationStructureRoot);

            if (db.OrganizationStructures.Count(c => c.OrganizationStructureVersionID == (int)this.organizationStructureVersionComboBox.SelectedValue) > 1)
                this.copyButton.Enabled = false;
            else
                this.copyButton.Enabled = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (rolesStructureTreeView.Nodes.Count == 0)
                {
                    Helper.ShowMessage("نسخه بخش  را انتخاب کنید");
                    return;
                }
                if (isChangedOrganizationStructureVersion)
                {
                    Helper.ShowMessage("نسخه بخش تغییر کرده لطفا دوباره نسخه را انتخاب کنید");
                    return;
                }

                if (rolesStructureTreeView.SelectedNode == null)
                {
                    Helper.ShowMessage("ابتدا یک واحد سازمانی را انتخاب نمایید");
                    return;
                }
                TreeNode treeNode = new TreeNode();
                OrganizationStructure OrganizationStructure = new OrganizationStructure();

                OrganizationStructure.ParentId = ((OrganizationStructure)rolesStructureTreeView.SelectedNode.Tag).Id;
                OrganizationStructure.OrganizationStructureVersionID = ((OrganizationStructureVersion)organizationStructureVersionBindingSource.Current).ID;
                UI.DialogForms.RolesStructureEditDialogForm rolesStructureEditDialogForm = new Jamsaz.PersonnlsApplication.UI.DialogForms.RolesStructureEditDialogForm(Jamsaz.PersonnlsApplication.UI.DialogForms.RolesStructureEditDialogForm.ActionForm.Insert, ((OrganizationStructureVersion)organizationStructureVersionBindingSource.Current).ID);

                rolesStructureEditDialogForm.SelectRole = OrganizationStructure;

                if (rolesStructureEditDialogForm.ShowDialog() == DialogResult.OK)
                {
                    db.OrganizationStructures.InsertOnSubmit(OrganizationStructure);
                    db.SubmitChanges();
                    treeNode.Tag = rolesStructureEditDialogForm.SelectRole;
                    treeNode.Text = rolesStructureEditDialogForm.SelectRole.Name;
                    rolesStructureTreeView.SelectedNode.Nodes.Add(treeNode);
                    treeNode.ImageIndex = 0;
                    rolesStructureTreeView.SelectedNode = treeNode;

                }
            }
            catch (Exception exp)
            {
                throw exp;
            }
        }
        private void EditNode()
        {
            if (rolesStructureTreeView.SelectedNode != null)
            {
                UI.DialogForms.RolesStructureEditDialogForm rolesStructureEditDialogForm = new Jamsaz.PersonnlsApplication.UI.DialogForms.RolesStructureEditDialogForm(Jamsaz.PersonnlsApplication.UI.DialogForms.RolesStructureEditDialogForm.ActionForm.Edit, ((OrganizationStructureVersion)organizationStructureVersionBindingSource.Current).ID);

                OrganizationStructure organizationStructure = db.OrganizationStructures.Single(c => c.Id == ((OrganizationStructure)rolesStructureTreeView.SelectedNode.Tag).Id);
                rolesStructureEditDialogForm.SelectRole = organizationStructure;
                if (rolesStructureEditDialogForm.ShowDialog() == DialogResult.OK)
                {
                    organizationStructure = rolesStructureEditDialogForm.SelectRole;
                    rolesStructureTreeView.SelectedNode.Text = organizationStructure.Name;
                    db.SubmitChanges();
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
            if (rolesStructureTreeView.Nodes.Count == 0)
            {
                Helper.ShowMessage("نسخه بخش  را انتخاب کنید");
                return;
            }

            if (isChangedOrganizationStructureVersion)
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
                if (rolesStructureTreeView.Nodes.Count == 0)
                {
                    Helper.ShowMessage("نسخه بخش  را انتخاب کنید");
                    return;
                }

                if (isChangedOrganizationStructureVersion)
                {
                    Helper.ShowMessage("نسخه بخش تغییر کرده لطفا دوباره نسخه را انتخاب کنید");
                    return;
                }

                if (rolesStructureTreeView.SelectedNode == null)
                {
                    Helper.ShowMessage("ابتدا یک سمت سازمانی را انتخاب نمایید");
                    return;
                }

                if (rolesStructureTreeView.SelectedNode.Nodes.Count > 0)
                {
                    Helper.ShowMessage("ابتدا باید تمام سمت های زیرمجموعه حذف شوند");
                    return;
                }

                if (Helper.Confirm("آيا می خواهید حذف شود؟", "حذف") == false)
                    return;

                int roleID = ((OrganizationStructure)rolesStructureTreeView.SelectedNode.Tag).Id;
                var ListPersonnels = from p in db.OrganizationStructurePersonnels where p.OrganisationStructureId == roleID select new { PN = p.Personnel.PersonnelNumber, FullName = p.Personnel.FirstName + " " + p.Personnel.LastName };

                int countPersonal = ListPersonnels.Count();
                if (countPersonal != 0)
                {
                    string Personnels = string.Empty;
                    foreach (var item in ListPersonnels)
                    {
                        countPersonal += 1;
                        Personnels += item.PN + " " + item.FullName + "\n";
                    }
                    Helper.ShowMessage("در این واحد" + countPersonal + " کاربر تخصیص داده شده!"
                                       + "ابتدا  باید تمام کاربران را در این واحد حذف کنید\n" + Personnels);
                    return;
                }

                OrganizationStructure organizationStructure = (OrganizationStructure)rolesStructureTreeView.SelectedNode.Tag;

                db.OrganizationStructures.DeleteOnSubmit(organizationStructure);
                db.SubmitChanges();
                rolesStructureTreeView.SelectedNode.Remove();
            }
            catch (Exception exp)
            {
                Helper.ShowMessage(exp.Message);
            }
        }



        private void searchButton_Click(object sender, EventArgs e)
        {
            roleStructureTreeViewSearchResult = rolesStructureTreeView.GetAllNodes().Where(c => c.Text.Contains(nameTextBox.Text)).ToList();
            if (roleStructureTreeViewSearchResult.Count() != 0)
                rolesStructureTreeView.SelectedNode = roleStructureTreeViewSearchResult.First();

            if (roleStructureTreeViewSearchResult.Count > 1)
                nextButton.Enabled = true;
            else
                nextButton.Enabled = false;

            rolesStructureTreeView.Focus();
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            int lastIndex = roleStructureTreeViewSearchResult.FindIndex(c => c == rolesStructureTreeView.SelectedNode);
            lastIndex = lastIndex + 1;
            if (roleStructureTreeViewSearchResult.Count() > 1 && (roleStructureTreeViewSearchResult.Count() - 1) >= lastIndex)
                rolesStructureTreeView.SelectedNode = roleStructureTreeViewSearchResult.Skip(lastIndex).First();
            else
            {
                lastIndex = 0;
                rolesStructureTreeView.SelectedNode = roleStructureTreeViewSearchResult.First();
            }

            rolesStructureTreeView.Focus();
        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                searchButton_Click(null, null);
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
                        nextButton_Click(null, null);
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
                        searchButton_Click(null, null);
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

        private void cuteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                sourceOrganizationStructure = ((OrganizationStructure)rolesStructureTreeView.SelectedNode.Tag);
                sourceNodeForCute = rolesStructureTreeView.SelectedNode;
                pastNodeToolStripMenuItem.Enabled = true;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void pastNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakeTree<OrganizationStructure> makeTree = new MakeTree<OrganizationStructure>();
            makeTree.NodeTitlePropertyName = "Name";
            makeTree.NodeParentKeyPropertyName = "ParentId";
            makeTree.NodeKeyPropertyName = "Id";
            OrganizationStructure currentOraganizationStructure = (OrganizationStructure)rolesStructureTreeView.SelectedNode.Tag;

            makeTree.FindNodeDetail(sourceOrganizationStructure, db.OrganizationStructures.AsEnumerable(), currentOraganizationStructure.Id);
            if (!makeTree.IsFindeNode)
            {
                if (sourceOrganizationStructure.Id != 0 && sourceOrganizationStructure.Id != currentOraganizationStructure.Id)
                {
                    sourceOrganizationStructure.ParentId = currentOraganizationStructure.Id;
                    db.SubmitChanges();
                    db.Refresh(System.Data.Linq.RefreshMode.KeepChanges, sourceOrganizationStructure);
                    sourceNodeForCute.Remove();
                    rolesStructureTreeView.SelectedNode.Nodes.Insert(sourceNodeForCute.Index, sourceNodeForCute);
                    rolesStructureTreeView.SelectedNode = sourceNodeForCute;
                }
            }
            else
                Helper.ShowMessage("انتقال به این  قسمت امکان پذیر نیست در بخش دیگر سعی کنید");

            pastNodeToolStripMenuItem.Enabled = false;
        }

        private void rolesStructureTreeView_MouseDown(object sender, MouseEventArgs e)
        {
            SetSelectedNodeByPosition(rolesStructureTreeView, e.X, e.Y);
            if (rolesStructureTreeView.SelectedNode == null) { return; }
            if (e.Button == MouseButtons.Right) { return; }
        }

        private void rolesStructureTreeView_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:

                    contextMenuStrip.Show(rolesStructureTreeView, new Point(e.X, e.Y));
                    return;

                default:
                    break;
            }
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
                rolesStructureTreeView.Nodes.Clear();
                makeTree.CreateChartTree(organizationStructureRoot, RolesStructures, rolesStructureTreeView, organizationStructureRoot);
                isChangedOrganizationStructureVersion = false;
            }
        }

        private void organizationStructureVersionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (db.OrganizationStructures.Count(c => c.OrganizationStructureVersionID == (int)this.organizationStructureVersionComboBox.SelectedValue) > 1)
                this.copyButton.Enabled = false;
            else
                this.copyButton.Enabled = true;

            isChangedOrganizationStructureVersion = true;
        }

        private void reportPersonnelsFromCurrentRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rolesStructureTreeView.SelectedNode != null)
            {
                OrganizationStructure organizationStructure = db.OrganizationStructures.Single(c => c.Id == ((OrganizationStructure)rolesStructureTreeView.SelectedNode.Tag).Id);

                Jamsaz.PersonnlsApplication.UI.DockForms.personnelProfilesReportForm personnelProfilesReportForm = new personnelProfilesReportForm(organizationStructure);
                personnelProfilesReportForm.MdiParent = UI.MainForm.mainParentForm;
                personnelProfilesReportForm.Show();
            }
            else
            {
                Helper.ShowMessage("ابتدا یک واحد سازمانی را انتخاب نمایید");
                return;
            }
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            OrganizationStructureVersionDialogForm organizationStructureVersionDialogForm = new OrganizationStructureVersionDialogForm() { db = db, CurrentOrganizationStructureVersionId = (int)this.organizationStructureVersionComboBox.SelectedValue };
            if (organizationStructureVersionDialogForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<OrganizationStructureEX> organizationStructureEXList = (from c in db.OrganizationStructures
                                                                                 where c.OrganizationStructureVersionID == organizationStructureVersionDialogForm.SelectOrganizationStructureVersion.ID
                                                                                 select new OrganizationStructureEX
                                                                                 {
                                                                                     Id = c.Id,
                                                                                     Name = c.Name,
                                                                                     NameEn = c.NameEn,
                                                                                     Code = c.Code,
                                                                                     OrganizationStructureVersionId = c.OrganizationStructureVersionID,
                                                                                     ParentId = c.ParentId,
                                                                                     OrganizationStructurePersonnels = c.OrganizationStructurePersonnels.ToList()
                                                                                 }).OrderBy(c => c.Id).ToList();


                    List<OrganizationStructure> newOrganizationStructures = new List<OrganizationStructure>();

                    foreach (OrganizationStructureEX item in organizationStructureEXList)
                    {
                        OrganizationStructure organizationStructure = new OrganizationStructure();

                        organizationStructure.Name = item.Name;

                        organizationStructure.NameEn = item.NameEn;

                        organizationStructure.Code = item.Code;

                        organizationStructure.OrganizationStructureVersionID = (int)this.organizationStructureVersionComboBox.SelectedValue;

                        foreach (OrganizationStructurePersonnel organizationStructurePersonnel in item.OrganizationStructurePersonnels)
                        {
                            OrganizationStructurePersonnel personnel = new OrganizationStructurePersonnel();

                            personnel.OrganizationStructure = organizationStructure;

                            personnel.PersonnelId = organizationStructurePersonnel.PersonnelId;

                            personnel.IsMainPosition = organizationStructurePersonnel.IsMainPosition;

                            organizationStructurePersonnel.IsMainPosition = false;

                            organizationStructure.OrganizationStructurePersonnels.Add(personnel);
                        }

                        item.ParentOfChildOrganizationStructure = organizationStructure;

                        newOrganizationStructures.Add(organizationStructure);

                    }

                     bool root = false;

                    foreach (OrganizationStructure item in newOrganizationStructures)
                    {
                        if (root == false && organizationStructureEXList.Single(c => c.Code == item.Code).ParentId == null)
                        {
                            item.ParentId = null;

                            root = true;
                        }
                        else
                        {
                            item.OrganizationStructure1 =
                                   organizationStructureEXList.Single(
                                       c =>
                                       c.Id == organizationStructureEXList.Single(g => g.Code == item.Code).ParentId).
                                       ParentOfChildOrganizationStructure;

                        }
                    }

                    db.OrganizationStructures.InsertAllOnSubmit(newOrganizationStructures);

                    db.SubmitChanges();

                    this.selectOrganizationStructureVersionButton_Click(null, null);

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

}
