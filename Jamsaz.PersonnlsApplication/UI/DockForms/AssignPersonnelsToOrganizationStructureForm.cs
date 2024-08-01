using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jamsaz.PersonnlsApplication.Classes;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using System.Threading;
using Jamsaz.PersonnlsApplication.UI.DialogForms;
using Jamsaz.Common;


namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class AssignPersonnelsToOrganizationStructureForm : Jamsaz.Common.BasePersianForm
    {
        public AssignPersonnelsToOrganizationStructureForm()
        {
            InitializeComponent();
        }

        JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
        IEnumerable<OrganizationStructure> RolesStructures;
        private List<TreeNode> roleStructureTreeViewSearchResult = new List<TreeNode>();
        OrganizationStructure sourceOrganizationStructure = new OrganizationStructure();
        OrganizationStructure currentRule = new OrganizationStructure();
        private List<TreeNode> ruleTreeViewSearchResult = new List<TreeNode>();
        OrganizationStructureVersion currentOrganizationStructureVersion = new OrganizationStructureVersion();
        bool isChangedDepartmentVersion = false;
        private void AssignPersonnelsToOrganizationStructureForm_Load(object sender, EventArgs e)
        {
            organizationStructureVersionBindingSource.DataSource = from c in db.OrganizationStructureVersions orderby c.Code descending select c;

        }

        bool isChangedOrganizationStructureVersion = false;

        private void ShowProgressBarForm()
        {
            ProgressIconDialogForm progressIconDialogForm = new ProgressIconDialogForm();
            progressIconDialogForm.Location = new Point(Screen.PrimaryScreen.Bounds.Size.Height / 2, Screen.PrimaryScreen.Bounds.Size.Width / 2);
            progressIconDialogForm.ShowDialog();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            int lastIndex = ruleTreeViewSearchResult.FindIndex(c => c == rolesStructureTreeView.SelectedNode);
            lastIndex = lastIndex + 1;
            if (ruleTreeViewSearchResult.Count() > 1 && (ruleTreeViewSearchResult.Count() - 1) >= lastIndex)
                rolesStructureTreeView.SelectedNode = ruleTreeViewSearchResult.Skip(lastIndex).First();
            else
            {
                lastIndex = 0;
                rolesStructureTreeView.SelectedNode = ruleTreeViewSearchResult.First();
            }

            rolesStructureTreeView.Focus();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameTextBox.Text))
            {
                ruleTreeViewSearchResult = rolesStructureTreeView.GetAllNodes().Where(c => c.Text.Contains(nameTextBox.Text)).ToList();
                if (ruleTreeViewSearchResult.Count() != 0)
                    rolesStructureTreeView.SelectedNode = ruleTreeViewSearchResult.First();
                rolesStructureTreeView.Focus();
                if (ruleTreeViewSearchResult.Count > 1)
                    nextButton.Enabled = true;
                else
                    nextButton.Enabled = false;
            }

        }

        private void rolesStructureTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            currentRule = (OrganizationStructure)e.Node.Tag;

            db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
            allAssignOrganisationStructureForCurrentPersonnleBindingSource.DataSource = null;
            organisationStructurePersonnelBindingSource.DataSource = db.OrganizationStructurePersonnels.Where(c => c.OrganisationStructureId == currentRule.Id);

        }

        private void addPersonnelTocurrentRolButton_Click(object sender, EventArgs e)
        {
            List<int> hassPersonnelFromCurrentRule = new List<int>();
            foreach (OrganizationStructurePersonnel organisationStructurePersonnel in organisationStructurePersonnelBindingSource.List)
            {
                hassPersonnelFromCurrentRule.Add(organisationStructurePersonnel.PersonnelId);
            }


            Jamsaz.PersonnlsApplication.UI.DockForms.PersonnelsListForAssignForm personnelsListForAssignFrom = new PersonnelsListForAssignForm();
            personnelsListForAssignFrom.HassPersonnles = hassPersonnelFromCurrentRule;

            if (personnelsListForAssignFrom.ShowDialog() == DialogResult.OK)
            {
                foreach (Personnels_FullSearchAdvanced1Result resultSearchAdenced in personnelsListForAssignFrom.GetPersonnels)
                {
                    OrganizationStructurePersonnel organisationStructurePersonnel = (OrganizationStructurePersonnel)organisationStructurePersonnelBindingSource.AddNew();
                    organisationStructurePersonnel.PersonnelName = resultSearchAdenced.FullNameFa;
                    organisationStructurePersonnel.PersonnelId = resultSearchAdenced.Id;
                    organisationStructurePersonnel.OrganisationStructureId = currentRule.Id;
                    organisationStructurePersonnelBindingSource.EndEdit();
                }

                db.SubmitChanges();



            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (organisationStructurePersonnelBindingSource.Current != null)
            {
                if (Helper.Confirm("آیا مایل به حذف رکورد جاری هستید؟"))
                {
                    organisationStructurePersonnelBindingSource.RemoveCurrent();
                    
                    db.SubmitChanges();
                }

            }
        }

        private void setMainPositionButton_Click(object sender, EventArgs e)
        {
            OrganizationStructureVersion organizationStructureVersion = (OrganizationStructureVersion)organizationStructureVersionComboBox.SelectedItem;
            if (organizationStructureVersion == null)
            {
                Helper.ShowMessage("نسخه را انتخاب کنید");
                return;
            }


            if (Helper.Confirm("آیا مایل به تعیین سمت اصلی برای پرسنل جاری هستید؟ "))
            {
                OrganizationStructurePersonnel organisationStructurePersonnel = (OrganizationStructurePersonnel)organisationStructurePersonnelBindingSource.Current;
                IQueryable<OrganizationStructurePersonnel> personnelsFromCurrentRule = db.OrganizationStructurePersonnels.Where(c => c.PersonnelId == organisationStructurePersonnel.PersonnelId /*&& organizationStructureVersion.ID == c.OrganizationStructure.OrganizationStructureVersion.ID*/);

                foreach (OrganizationStructurePersonnel item in personnelsFromCurrentRule)
                {
                    if (organisationStructurePersonnel.Id == item.Id)
                        item.IsMainPosition = true;
                    else
                        item.IsMainPosition = false;
                }
                db.SubmitChanges();
                db.Refresh(System.Data.Linq.RefreshMode.KeepChanges, organisationStructurePersonnel);
                assignPersonnelsDataGridView.Refresh();
            }
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
        private void RefreshDataGrid()
        {
            if (organisationStructurePersonnelBindingSource.Current != null)
            {
                OrganizationStructurePersonnel currentOrganisationStructurePersonnel = (OrganizationStructurePersonnel)organisationStructurePersonnelBindingSource.Current;
                allAssignDepartmentForCurrentPersonnleGroupBox.Text = " تمام سمت های که به پرسنل " + currentOrganisationStructurePersonnel.PersonnelName + " تخصیص داده شده ";
                allAssignOrganisationStructureForCurrentPersonnleBindingSource.DataSource = db.OrganizationStructurePersonnels.Where(c => c.PersonnelId == currentOrganisationStructurePersonnel.PersonnelId);
            }
        }

        private void organisationStructurePersonnelBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (organisationStructurePersonnelBindingSource.Current != null)
            {
                OrganizationStructurePersonnel currentOrganizationStructurePersonnel = (OrganizationStructurePersonnel)organisationStructurePersonnelBindingSource.Current;
                allAssignDepartmentForCurrentPersonnleGroupBox.Text = " تمام بخش های که به پرسنل " + currentOrganizationStructurePersonnel.PersonnelName + " تخصیص داده شده ";
                allAssignOrganisationStructureForCurrentPersonnleBindingSource.DataSource = db.OrganizationStructurePersonnels.Where(c => c.PersonnelId == currentOrganizationStructurePersonnel.PersonnelId);
            }
            else
            {
                allAssignDepartmentForCurrentPersonnleGroupBox.Text = "تمام واحدهای که به پرسنل تخصیص داده شده";
                allAssignOrganisationStructureForCurrentPersonnleBindingSource.DataSource = null;
            }
        }

        private void organizationStructureVersionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            isChangedDepartmentVersion = true;
        }

        private void organisationStructurePersonnelBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            organisationStructurePersonnelBindingSource_PositionChanged(null, null);
        }

    }
}
