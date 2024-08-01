using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
    public partial class ExcludePersonnel
    {
        public string PersonnelNumber
        {
            get
            {
                if (Personnel != null)
                    return Personnel.PersonnelNumber;

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
    }
}
