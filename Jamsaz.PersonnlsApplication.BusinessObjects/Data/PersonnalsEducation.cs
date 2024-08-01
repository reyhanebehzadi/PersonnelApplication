using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jamsaz.Common;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
    public partial class PersonnalsEducation
    {
        string _StartDatePersianDate;

        public string StartDatePersianDate
        {
            get
            {
                try
                {
                    if (string.IsNullOrEmpty(_StartDatePersianDate))
                    {
                        _StartDatePersianDate = this.StartDate.Value.ToPersianDate();
                        return _StartDatePersianDate;
                    }
                    else
                        return _StartDatePersianDate;
                }
                catch
                {
                    return string.Empty;
                }
            }
        }

        string _GraduationDatePersianDate;
        public string GraduationDatePersianDate
        {
            get
            {
                try
                {
                    if (string.IsNullOrEmpty(_GraduationDatePersianDate))
                    {
                        _GraduationDatePersianDate = this.GraduationDate.Value.ToPersianDate();
                        return _GraduationDatePersianDate;
                    }
                    else
                        return _GraduationDatePersianDate;
                }
                catch
                {
                    return string.Empty;
                }

            }
        }

        string _FullName;
        public string FullName
        {
            get
            {
                if (string.IsNullOrEmpty(_FullName))
                {
                    _FullName = this.Personnel.FirstName + " " + this.Personnel.LastName;
                    return _FullName;
                }
                else
                    return _FullName;
            }
            set
            {
                _FullName = value;
            }
        }

        string _MajorName;
        public string MajorName
        {
            get
            {
                if (string.IsNullOrEmpty(_MajorName))
                {
                    _MajorName = this.Major1.Name;
                    return _MajorName;
                }
                else
                    return _MajorName;
            }

        }
        string _DegreeLevelName;
        public string DegreeLevelName
        {
            get
            {
                if (string.IsNullOrEmpty(_DegreeLevelName))
                {
                    _DegreeLevelName = this.UniversityDegree.Name;
                    return _DegreeLevelName;
                }
                else
                    return _DegreeLevelName;
            }
        }
        string _StatusStudyingTitle;

        public string StatusStudyingTitle
        {
            get
            {
                if (this.StatusStudying == 0)
                    _StatusStudyingTitle = "در حال تحصیل";
                else _StatusStudyingTitle = "فارغ التحصیل";

                return _StatusStudyingTitle;
            }
           
        }
        string _PersonnelNumber;
        public string PersonnelNumber
        {
            get
            {
                if (string.IsNullOrEmpty(_PersonnelNumber))
                {
                    _PersonnelNumber = this.Personnel.PersonnelNumber;
                    return _PersonnelNumber;
                }
                else
                    return _PersonnelNumber;
            }
            set
            {
                _PersonnelNumber = value;
            }
        }


    }
}
