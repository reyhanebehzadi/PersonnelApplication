using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
    public partial class ApplicantSkill
    {
        public string SkillLevelTitle
        {
            get
            {
                if (this.SkillLevel != null)
                {
                    switch (SkillLevel)
                    {
                        case 1:
                            return "آشنایی";
                        case 2:
                            return "متوسط";
                        case 3:
                            return "خوب";
                        case 4:
                            return "مسلط";
                        default:
                            return string.Empty;
                    }
                }
                return string.Empty;
            }
        }
    }
}
