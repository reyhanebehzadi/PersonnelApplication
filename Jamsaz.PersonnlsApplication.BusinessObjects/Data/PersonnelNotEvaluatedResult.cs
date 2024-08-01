using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
    public class PersonnelNotEvaluatedResult
    {
        public long RowNum { get; set; }
        public int PersonnelNumber { get; set; }
        public string Descriptor { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentChildName { get; set; }
    }
}
