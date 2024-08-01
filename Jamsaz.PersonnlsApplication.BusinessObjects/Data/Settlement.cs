using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jamsaz.Common;
namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
  public partial  class Settlement
    {
        public string PersonnelCode
        {
            get
            {
                if (this.Personnel != null)

                    return this.Personnel.PersonnelNumber;
                else
                    return string.Empty;

            }
        }

        public string PersonnelName
        {
            get
            {
                if (this.Personnel != null)

                    return string.Format("{0} {1}", this.Personnel.FirstName, this.Personnel.LastName);
                else
                    return string.Empty;

            }
        }

        public string PersianDate
        {
            get
            {
                return Helper.GetPersianDate(this.Date.GetValueOrDefault());

            }
        }

        public string SettlementTitle
        {
            get
            {
                if (this.SettlementCategory != null)

                    return this.SettlementCategory.Title;
                else
                    return string.Empty;

            }
        }
    }
}
