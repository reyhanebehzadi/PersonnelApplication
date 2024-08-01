using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.PersonnlsApplication.Classes;
using Jamsaz.Common;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class GetPersonelByStructuerDockForm : BasePersianForm
    {
        private readonly JamsazERPLiteDataClassesDataContext _db;
        private IEnumerable<OrganizationStructure> _rolesStructures;
        private OrganizationStructure _currentRule;
        public GetPersonelByStructuerDockForm()
        {
            InitializeComponent();
            _db = new JamsazERPLiteDataClassesDataContext();
        }

        private void GetPersonelByStructuerDockForm_Load(object sender, EventArgs e)
        {
            var currentOrganizationStructureVersion =
                _db.OrganizationStructureVersions.SingleOrDefault(x => x.IsActive == true);
            _rolesStructures = _db.OrganizationStructures.Where(c => c.OrganizationStructureVersionID == currentOrganizationStructureVersion.ID).AsEnumerable();
            var makeTree = new MakeTree<OrganizationStructure>();
            if (_rolesStructures.Count() != 0)
            {
                var organizationStructureRoot = _db.OrganizationStructures.Single(c => currentOrganizationStructureVersion.ID == c.OrganizationStructureVersionID && c.ParentId == null);
                makeTree.NodeTitlePropertyName = "Name";
                makeTree.NodeParentKeyPropertyName = "ParentId";
                makeTree.NodeKeyPropertyName = "Id";
                rolesStructureTreeView.Nodes.Clear();
                makeTree.CreateChartTree(organizationStructureRoot, _rolesStructures, rolesStructureTreeView, organizationStructureRoot);
            }
        }

        private void rolesStructureTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            _currentRule = (OrganizationStructure)e.Node.Tag;
            allAssignOrganisationStructureForCurrentPersonnleBindingSource.DataSource = null;
            organisationStructurePersonnelBindingSource.DataSource = _db.GetAllStructurePersonels().ToList().Where(c => c.MajorParentId == _currentRule.Id);
        }
    }
}
