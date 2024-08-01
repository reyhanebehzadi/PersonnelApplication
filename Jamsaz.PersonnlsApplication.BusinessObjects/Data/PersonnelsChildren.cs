using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
    public partial class PersonnelsChildren
    {
        public string UniversityDegreeTitle
        {
            get
            {
                if (this.UniversityDegree != null)
                    return this.UniversityDegree.Name;

                return string.Empty;
            }
        }

    }
}
