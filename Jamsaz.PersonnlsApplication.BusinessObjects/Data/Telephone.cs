using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
    public partial class Telephone
    {
        public string DisplayTitle
        {
            get
            {
                return string.Format("{0}    : {1} - {2} ", this.Title, this.Number, this.AreaCode);
            }
        }
    }
}
