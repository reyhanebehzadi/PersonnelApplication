using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;

namespace Jamsaz.PersonnlsApplication.Classes
{
    public class DepartmentEX
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string NameEn { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        public int? ParentId { get; set; }

        public int? DepartmentVersionID { get; set; }

        public int? OriginalDepartmentID { get; set; }

        public Department ParentOfChildDepartment { get; set; }


    }
}
