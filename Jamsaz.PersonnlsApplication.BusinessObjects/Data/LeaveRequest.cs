using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jamsaz.Common;
namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
    public partial class LeaveRequest
    {
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        public string PersonnelName
        {
            get
            {
                if (this.Personnel != null)
                    return string.Format("{0} {1}", this.Personnel.FirstName, this.Personnel.LastName);
                return string.Empty;
            }
        }

        public string PersonnelNumber
        {
            get
            {
                if (this.Personnel != null)
                    return this.Personnel.PersonnelNumber;
                return string.Empty;
            }
        }

        public string DepartmentName
        {
            get
            {
                if (this.Department != null)
                    return this.Department.Name;
                return string.Empty;
            }
        }

        public string DepartmentChildName
        {
            get
            {
                if (this.DepartmentChildID != null)
                    return db.Departments.SingleOrDefault(c => c.Id == this.DepartmentChildID).Name;
                return string.Empty;
            }
        }

        public string PersianStartDate
        {
            get
            {
                if (this.StartDate != null)
                    return Helper.GetPersianDate(this.StartDate.GetValueOrDefault());
                return string.Empty;
            }
        }

        public string PersianEndDate
        {
            get
            {
                if (this.EndDate != null)
                    return Helper.GetPersianDate(this.EndDate.GetValueOrDefault());
                return string.Empty;
            }
        }

        public string PersianDate
        {
            get
            {
                if (this.Date != null)
                    return Helper.GetPersianDate(this.Date.GetValueOrDefault());
                return string.Empty;
            }

        }
    }
}
