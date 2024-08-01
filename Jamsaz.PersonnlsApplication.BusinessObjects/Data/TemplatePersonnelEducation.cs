using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jamsaz.Common;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
    public class TemplatePersonnelEducation
    {
        public string PersonnelNumber { get; set; }
        public string fullName { get; set; }
        public string EducationalOrganaizationName { get; set; }
        public string MajorName { get; set; }
        public string DegreeLevel { get; set; }
        public DateTime? StartDateEn { get; set; }
        string _StartDate;
        public string StartDate
        {
            get
            {
                if (string.IsNullOrEmpty(_StartDate))
                {
                    _StartDate = StartDateEn.Value.ToPersianDate();
                    return _StartDate;
                }
                else
                    return _StartDate;
            }
        }
        public DateTime? GraduationDateEn { get; set; }
        string _GraduationDate;
        public string GraduationDate
        {
            get
            {
                if (string.IsNullOrEmpty(_GraduationDate))
                {
                    _GraduationDate = GraduationDateEn.Value.ToPersianDate();
                    return _GraduationDate;
                }
                else
                    return _GraduationDate;
            }
        }
        public string GPA { get; set; }


    }
}
