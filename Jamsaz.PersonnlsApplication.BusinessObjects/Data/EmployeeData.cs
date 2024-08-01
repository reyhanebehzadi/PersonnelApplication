using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
    public class EmployeeData
    {
        public int PersonnelID { get; set; }
        public string PersonnelNumber { get; set; }
        public string Position { get; set; }
        public string FullName { get; set; }
        public int Saturday { get; set; }
        public int Sunday { get; set; }
        public int Monday { get; set; }
        public int TuseDay { get; set; }
        public int WendsDay { get; set; }
        public int Tuersday { get; set; }
        public int Friday { get; set; }
    }
}
