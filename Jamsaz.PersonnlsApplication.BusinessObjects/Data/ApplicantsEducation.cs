using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
    public partial class ApplicantsEducation
    {
        public string UniversityTypeTitle
        {
            get
            {
                if (this.UniversityType != null)
                {
                    switch (UniversityType)
                    {
                        case 1:
                            return "دانشگاه سراسری";
                        case 2:
                            return "دانشگاه آزاد";
                        case 3:
                            return "دانشگاه پیام نور";
                        case 4:
                            return "دانشگاه غیر انتفاعی";
                        case 5:
                            return "دانشگاه علمی کاربردی";
                        case 6:
                            return "دبیرستان";
                        case 7:
                            return "هنرستان";
                        case 8:
                            return "کار و دانش";
                        default:
                            return string.Empty;
                    }
                }
                return string.Empty;
            }
        }

        public string DegreeLevelTitle
        {
            get
            {
                if (this.DegreeLevel != null)
                {
                    switch (DegreeLevel)
                    {
                        case 1:
                            return "دیپلم";
                        case 2:
                            return "کاردانی";
                        case 3:
                            return "کارشناسی";
                        case 4:
                            return "کارشناسی ارشد";
                        case 5:
                            return "دکترا";
                        case 6:
                            return "فوق دکترا";
                        default:
                            return string.Empty;
                    }
                }
                return string.Empty;
            }
        }
    }
}
