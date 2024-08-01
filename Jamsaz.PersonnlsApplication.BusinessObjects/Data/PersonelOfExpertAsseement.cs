using System;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
    public partial class PersonelOfExpertAsseement
    {
        public string FullName
        {
            get { return Personnel.Descriptor; }
        }

        public string DepartmentName
        {
            get { return ExpertAssesment.DepartmentName; }
        }

        public string SectionName
        {
            get { return Department.Name; }
        }

        public int PersonelNumber
        {
            get { return Convert.ToInt32(Personnel.PersonnelNumber); }
        }

    }
}