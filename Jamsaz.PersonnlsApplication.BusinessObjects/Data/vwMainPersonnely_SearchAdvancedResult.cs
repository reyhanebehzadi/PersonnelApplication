using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
    public partial class vwMainPersonnely_SearchAdvancedResult
    {
        public DateTime BrithDateToPersianDate { get; set; }

        private int _intPersonelNumber;
        public int IntPersonnelNumber
        {
            get
            {
                _intPersonelNumber = int.Parse(PersonnelNumber);
                return _intPersonelNumber;
            }
            set { _intPersonelNumber = value; }
        }
    }
}
