using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jamsaz.PersonnlsApplication.Classes
{
   public static class ExtensionMethod
    {
       public static string GetGenderName(this int value)
       {
           if (value == 1)
               return "مرد";
           if (value == 2)
               return "مرد";
           return string.Empty;
       }

    }
}
