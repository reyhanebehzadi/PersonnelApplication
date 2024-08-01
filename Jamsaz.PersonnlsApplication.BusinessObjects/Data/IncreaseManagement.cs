using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jamsaz.Common;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
    public partial class IncreaseManagement
    {
        public string PersianDate
        {
            get
            {
                if (this.EffectiveDate != null)
                    return Helper.GetPersianDate(EffectiveDate.GetValueOrDefault());

                return string.Empty;
            }
        }

        public string Status
        {
            get
            {
                if (this.Flag != null)
                {
                    if (Flag == 2)
                        return "تأیید نهایی";

                    return "تأیید نشده";
                }
                return string.Empty;
            }
        }
    }
}
