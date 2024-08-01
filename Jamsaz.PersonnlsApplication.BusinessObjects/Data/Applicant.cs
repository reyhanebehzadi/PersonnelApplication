

using Jamsaz.Common;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
    public partial class Applicant
    {

        string ـFullName;
        public string Fullname
        {
            get
            {
                if(this.Name != null && this.LastName!= null)
                    return this.Name + " " + this.LastName;

                return string.Empty;
            }
        }

        string _MajorName;
        public string MajorName
        {
            get
            {
                if (string.IsNullOrEmpty(_MajorName))
                {
                    if(this.Major != null)
                    _MajorName = this.Major.Name;
                    return _MajorName;
                }
                else
                    return _MajorName;
            }

        }
        string _DegreeLevelName;
        public string UniversityDegreeName
        {
            get
            {
                if (string.IsNullOrEmpty(_DegreeLevelName))
                {
                    if (this.UniversityDegree != null)
                        _DegreeLevelName = this.UniversityDegree.Name;
                    return _DegreeLevelName;
                }
                else
                    return _DegreeLevelName;
            }
        }
        string _MilitaryServiceStatusName;
        public string MilitaryServiceStatusName
        {
            get
            {
                if (string.IsNullOrEmpty(_MilitaryServiceStatusName))
                {
                    if (this.MilitaryServiceStatus != null)
                        _MilitaryServiceStatusName = this.MilitaryServiceStatus.Title;

                    return _MilitaryServiceStatusName;
                }
                else return _MilitaryServiceStatusName;
            }
        }

        string _MaritalStatusName;
        public string MaritalStatusName
        {
            get
            {
                if (string.IsNullOrEmpty(_MaritalStatusName))
                {
                    if (this.MaritalStatus == 1)
                        _MaritalStatusName = "متاهل";
                    else _MaritalStatusName = "مجرد";
                    return _MaritalStatusName;
                }
                else
                    return _MaritalStatusName;
            }
        }
        string _GenderName;
        public string GenderName
        {
            get
            {
                if (string.IsNullOrEmpty(_GenderName))
                {
                    if (this.Gender == 1)
                        _GenderName = "مرد";
                    else _GenderName = "زن";
                    return _GenderName;
                }
                else
                    return _GenderName;
            }
        }

        public string StatusName
        {
            get
            {
                switch (this.Status)
                {
                    case 0:
                        return string.Empty;
                        break;
                    case 1:
                        return "قبول در حال انتظار";
                        break;
                    case 2:
                        return "رد صلاحیت";
                        break;
                    case 3: return "در حال انتظار";
                }
                return string.Empty;

            }
        }

        public string PersianBrithDate
        {
            get
            {
                if (this.BrithDate != null)
                    return Helper.GetPersianDate(this.BrithDate.GetValueOrDefault());

                return string.Empty;
            }
        }

        public string PersianRespectDate
        {
            get
            {
                if (this.RespectDate != null)
                    return Helper.GetPersianDate(this.RespectDate.GetValueOrDefault());

                return string.Empty;
            }
        }
    }
}
