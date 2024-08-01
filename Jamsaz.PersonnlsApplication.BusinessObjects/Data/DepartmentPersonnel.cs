using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jamsaz.Common;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
   public partial class DepartmentPersonnel
    {
       string _PersonnelName;
       public string PersonnelName
       {
           get
           {
               if (string.IsNullOrEmpty(_PersonnelName))
               {
                   try
                   {
                       _PersonnelName = this.Personnel.FirstName + " " + this.Personnel.LastName;
                       return _PersonnelName;
                   }
                   catch { return "-"; }

               }
               else return _PersonnelName;
           }
           set
           {
               _PersonnelName = value;
           }
       }

       string _DepartmentName;
       public string DepartmentName
       {
           get
           {
               if (string.IsNullOrEmpty(_DepartmentName))
               {
                   _DepartmentName = this.Department.Name;
                   return _DepartmentName;

               }
               else return _DepartmentName;
           }
       }

       string _DepartmentVersionName;
       public string DepartmentVersionName
       {
           get
           {
               if (string.IsNullOrEmpty(_DepartmentVersionName))
               {
                   _DepartmentVersionName = this.Department.DepartmentVersion.Code.ToString();
                   return _DepartmentVersionName;
               }
               else
                   return _DepartmentVersionName;
           }
       }

       string _DepartmentVersionDate;
       public string DepartmentVersionDate
       {
           get
           {
               if (string.IsNullOrEmpty(_DepartmentVersionDate))
               {
                   _DepartmentVersionDate = this.Department.DepartmentVersion.effectiveStardDate.Value.ToPersianDate()  +" - " + this.Department.DepartmentVersion.effectiveEndDate.Value.ToPersianDate();
                   return _DepartmentVersionDate;
               }
               else
                   return _DepartmentVersionDate;
           }
       }
      
    }
}
