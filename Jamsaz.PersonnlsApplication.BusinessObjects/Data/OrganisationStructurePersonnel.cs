using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jamsaz.Common;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
    public partial class OrganizationStructurePersonnel
    {
        string _PersonnelName;

        public string PersonnelName
        {
            get
            {
                if (string.IsNullOrEmpty(_PersonnelName))
                {
                   
                    try
                    {
                  
                        _PersonnelName = this.Personnel.FirstName + " " + this.Personnel.LastName;
                        return _PersonnelName;
                    }
                    catch { return "-"; }

                }
                else return _PersonnelName;
            }
            set
            {
                _PersonnelName = value;
            }
        }

        string _IsMainPositionValue;
        public string IsMainPositionValue
        {
            get
            {
                if (string.IsNullOrEmpty(_IsMainPositionValue))
                {
                    if (this.IsMainPosition == true)
                        _IsMainPositionValue = "سمت اصلی";
                    else
                        _IsMainPositionValue = string.Empty;

                    return _IsMainPositionValue;
                }
                else return _IsMainPositionValue;
            }
        }

        string _PersonnelNummber;
        public string PersonnelNumber
        {
            get
            {
                if (string.IsNullOrEmpty(_PersonnelNummber))
                {
                    _PersonnelNummber = this.Personnel.PersonnelNumber;
                    return _PersonnelNummber;
                }
                else
                 return _PersonnelNummber;
            }
        }

        string _RoleName;
        public string RoleName
        {
            get
            {
                if (string.IsNullOrEmpty(_RoleName))
                {
                    _RoleName = this.OrganizationStructure.Name;
                    return _RoleName;

                }
                else return _RoleName;
            }
        }

        string _OrganizationStructureVersionCode;
        public string OrganizationStructureVersionCode
        {
            get
            {
                if (string.IsNullOrEmpty(_OrganizationStructureVersionCode))
                {
                    _OrganizationStructureVersionCode = this.OrganizationStructure.OrganizationStructureVersion.Code.ToString();
                    return _OrganizationStructureVersionCode;
                }
                else
                    return _OrganizationStructureVersionCode;
            }
        }

        string _OrganizationStructureVersionDate;
        public string OrganizationStructureVersionDate
        {
            get
            {
                if (string.IsNullOrEmpty(_OrganizationStructureVersionDate))
                {
                    _OrganizationStructureVersionDate = this.OrganizationStructure.OrganizationStructureVersion.effectiveStardDate.Value.ToPersianDate() + " - " + this.OrganizationStructure.OrganizationStructureVersion.effectiveEndDate.Value.ToPersianDate();
                    return _OrganizationStructureVersionDate;
                }
                else
                    return _OrganizationStructureVersionDate;
            }
        }
    }
}
