using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
    public partial class Personnel
    {
        JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        public string ResponsiblePersonnelNumber
        {
            get
            {
                if (this.Personnel2 != null)
                    return Personnel2.PersonnelNumber;
                else
                    return string.Empty;
            }
        }

        public string ResponsibleName
        {
            get
            {
                if (this.Personnel2 != null)
                    return Personnel2.FirstName + " " + Personnel2.LastName;
                else
                    return string.Empty;
            }
        }


        public string AdministratorPersonnelNumber
        {
            get
            {
                if (this.Personnel3 != null)
                    return Personnel3.PersonnelNumber;
                else
                    return string.Empty;
            }
        }

        public string AdministratorName
        {
            get
            {
                if (this.Personnel3 != null)
                    return Personnel3.FirstName + " " + Personnel3.LastName;
                else
                    return string.Empty;
            }
        }

        public string ManagerPersonnelNumber
        {
            get
            {
                if (this.Personnel1 != null)
                    return Personnel1.PersonnelNumber;
                else
                    return string.Empty;
            }
        }

        public string ManagerName
        {
            get
            {
                if (this.Personnel1 != null)
                    return Personnel1.FirstName + " " + Personnel1.LastName;
                else
                    return string.Empty;
            }
        }

        public bool IsSelect { get; set; }


        public string FullName
        {
            get
            {
                if (this.FirstName != null && this.LastName != null)
                    return string.Format("{0} {1}", FirstName, LastName);

                return string.Empty;
            }
        }

        public bool IsSelected { get; set; }

        public string DepartmentName
        {
            get
            {
                if (this.DepartmentId != null)
                    return db.Departments.SingleOrDefault(c => c.Id == this.DepartmentId).Name;
                else
                    return string.Empty;
            }
        }


    }
}
