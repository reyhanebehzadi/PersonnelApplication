using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Jamsaz.Common;
namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
    public partial class AnnouncementChange
    {
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


        public string PersonnelNumber
        {
            get
            {
                if (this.Personnel != null)

                    return this.Personnel.PersonnelNumber;
                else
                    return string.Empty;

            }

        }

        public string ChangeTitle
        {
            get
            {
                if (this.ChangeType != null)

                    return this.ChangeType.Title;
                else
                    return string.Empty;

            }

        }


        public string PersianDate
        {
            get
            {
                if (this.DateTime != null)

                    return Helper.GetPersianDate(this.DateTime.GetValueOrDefault());
                else
                    return string.Empty;
            }

        }

        public string Mounth
        {
            get
            {
                return Helper.GetPersianDate(this.DateTime.GetValueOrDefault()).Substring(5,2);
            }
        }

    }
}
