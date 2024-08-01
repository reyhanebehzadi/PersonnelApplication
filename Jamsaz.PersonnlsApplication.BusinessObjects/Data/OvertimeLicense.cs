using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jamsaz.Common;
namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
   public partial class OvertimeLicense
    {
        public string PersianDate
        {
            get
            {
                if (this.Date != null)
                    return Helper.GetPersianDate(this.Date.GetValueOrDefault());
                return string.Empty;
            }
        }

        public string FullName
        {
            get
            {
                if (Personnel != null)
                    return string.Format("{0} {1}", this.Personnel.FirstName, this.Personnel.LastName);
                return string.Empty;
            }
        }

        public string PursonelNumber
        {
            get
            {
                if (Personnel != null)
                    return this.Personnel.PersonnelNumber;
                return string.Empty;
            }
        }

        public string Department
        {
            get
            {
                if (Personnel != null)
                    return this.Personnel.Department.Name;
                return string.Empty;
            }
        }

        public string Confirm
        {
            get
            {
                if (this != null)

                    return "تایید";
                return string.Empty;
            }
            set { }
        }
    }
}
