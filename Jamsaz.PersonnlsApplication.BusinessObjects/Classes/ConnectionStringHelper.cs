using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Classes
{
   public static class ConnectionStringHelper
    {
       public static void SaveConnectionString(string value)
       {
           //Properties.Settings.Default.JamsazERPLiteConnectionString = value;
           Properties.Settings.Default.Save();
       }
    }
}
