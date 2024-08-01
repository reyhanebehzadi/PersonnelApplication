using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
    public partial class WithoutOvertimePersonnel
    {
        JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();

        public int PersonnelNumber
        {
            get
            {
                if (this.Personnel != null)
                    return int.Parse(Personnel.PersonnelNumber);

                return 0;
            }
        }


        public string PersonnelName
        {
            get
            {
                if (this.Personnel != null)
                    return Personnel.FirstName + " " + Personnel.LastName;

                return string.Empty;
            }
        }

        public string Semat
        {
            get
            {
                if (this.Personnel != null)
                {
                    return db.vwMainPersonnelies.SingleOrDefault(c => c.Id == this.Personnel.Id).OccupationTitle;
                }

                return string.Empty;
            }
        }
    }
}
