using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Definitions;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
   public partial class Accident
    {
        public string PersonnelNumber
        { get
            {
                if (this.Personnel != null)

                    return this.Personnel.PersonnelNumber;
                else
                    return string.Empty;
            }
        }

        public string FullName
        {
            get
            {
                if (this.Personnel != null)

                    return string.Format("{0} {1}", this.Personnel.FirstName, this.Personnel.LastName);
                else
                    return string.Empty;
            }
        }

        public string PersianDate
        {
            get
            {
                return Helper.GetPersianDate(this.Date.GetValueOrDefault());
            }
        }

       


       
    }
}
