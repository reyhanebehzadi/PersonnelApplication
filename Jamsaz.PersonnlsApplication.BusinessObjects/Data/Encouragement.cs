using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jamsaz.Common;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
    public partial class Encouragement
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

        public string PersonnelName
        {
            get
            {
                if (this.Personnel != null)
                    return string.Format("[{0}]{1} {2}", Personnel.PersonnelNumber, Personnel.FirstName,Personnel.LastName);

                return string.Empty;
            }
        }

        public string ApplicantName
        {
            get
            {
                if (this.Personnel1 != null)
                    return string.Format("[{0}]{1} {2}", Personnel1.PersonnelNumber, Personnel1.FirstName, Personnel1.LastName);

                return string.Empty;
            }
        }

        public string ConfirmorName
        {
            get
            {
                if (this.Personnel2 != null)
                    return string.Format("[{0}]{1} {2}", Personnel2.PersonnelNumber, Personnel2.FirstName, Personnel2.LastName);

                return string.Empty;
            }
        }

    }
}
