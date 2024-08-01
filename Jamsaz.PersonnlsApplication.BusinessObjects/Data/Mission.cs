using Jamsaz.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
   public partial class Mission
    {
        public string PersianDate
        {
            get
            {
                if (Date != null)
                    return Helper.GetPersianDate(Date.Value.Date);
                return string.Empty;
            }
        }

        public string PersianStartDate
        {
            get
            {
                if (this.StartDate != null)
                    return Helper.GetPersianDate(StartDate.Value.Date);
                return string.Empty;
            }
        }

        public string PersianEndDate
        {
            get
            {
                if (EndDate != null)
                    return Helper.GetPersianDate(EndDate.Value.Date);
                return string.Empty;
            }
        }

        public string CarName
        {
            get
            {
                if (Car != null)
                    return Car.Name + "(" + Car.DriverName + ")";
                return string.Empty;
            }
        }

        public string PersonnelName
        {
            get
            {
                if (Personnel != null)
                    return Personnel.FirstName + " " + Personnel.LastName;
                return string.Empty;
            }
        }

        public string PersonnelNumber
        {
            get
            {
                if (Personnel != null)
                    return Personnel.PersonnelNumber;
                return string.Empty;
            }
        }
    }
}
