using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
  public partial  class OvertimeLicenseDetail
    {
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

        public string Time
        {
            get
            {

                return string.Format("{0}_{1}",this.From,this.To);
            }
        }
    }
}
