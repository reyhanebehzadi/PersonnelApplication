using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
    
    

    public partial class SelectPersonnelWithoutOvertimeResult
    {
        JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();

        private string _semat;
        
        public string Semat
        {
            get
            {
                if (this.PersonnelID != null)
                {
                    return db.vwMainPersonnelies.SingleOrDefault(c => c.Id == this.PersonnelID).OccupationTitle;
                }

                return string.Empty;
            }
            set { _semat = value; }
        }

    }
}
