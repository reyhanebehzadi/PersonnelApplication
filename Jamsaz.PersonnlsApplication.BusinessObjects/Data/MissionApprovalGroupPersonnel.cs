using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
  public partial  class MissionApprovalGroupPersonnel
    {
        public string PersonnelName
        {
            get
            {
                if (this.PersonnelID != null)
                    return string.Format("{0} {1}", this.Personnel.FirstName, this.Personnel.LastName);
                else
                    return string.Empty;
            }

        }

        public string PersonnelNumber
        {
            get
            {
                if (this.PersonnelID != null)
                    return this.Personnel.PersonnelNumber;
                else
                    return string.Empty;
            }

        }
    }
}
