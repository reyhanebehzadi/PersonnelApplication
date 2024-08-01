using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;

namespace Jamsaz.PersonnlsApplication.Classes
{
    public class OrganizationStructureEX
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string NameEn { get; set; }

        public string Code { get; set; }

        public int? ParentId { get; set; }

        public int? OrganizationStructureVersionId { get; set; }

        public OrganizationStructure ParentOfChildOrganizationStructure { get; set; }

        public List<OrganizationStructurePersonnel> OrganizationStructurePersonnels { get; set; }
    }
}
