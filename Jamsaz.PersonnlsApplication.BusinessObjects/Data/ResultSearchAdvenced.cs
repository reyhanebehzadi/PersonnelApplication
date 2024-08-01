using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jamsaz.Common;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
    public partial class ResultSearchAdvenced
    {
        DateTime? _BrithDateToPersianDate;
        public DateTime BrithDateToPersianDate
        {
            get
            {
                this.BrithDate = _BrithDateToPersianDate.Value.ToPersianDate();
                return _BrithDateToPersianDate.Value;
            }
            set
            {

                _BrithDateToPersianDate = value;
                this.BrithDate = _BrithDateToPersianDate.Value.ToPersianDate();
            }
        }

        string _MainNationalCode;
    }
}
