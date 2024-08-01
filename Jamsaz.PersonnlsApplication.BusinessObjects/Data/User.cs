using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jamsaz.Common.UserAuthenticationManager;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
    public static class User
    {
        public static Personnel Personnel { get; set; }
        public static Department Department { get; set; }
        public static int DepartmentID { get; set; }
        public static int FiscalYearID { get; set; }
        public static bool FiscalYearActive { get; set; }
        public static string UserName { get; set; }
        public static AuthenticationManager AuthenticationManager { get; set; }
        public static int ServiceTrackingDepartmentID { get; set; }
        public static int WarehouseID { get; set; }

    }
}
