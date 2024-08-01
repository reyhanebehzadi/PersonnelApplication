using System;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
    public partial class ExpertAssesment
    {
        public string FullName
        {
            get { return Personnel?.Descriptor; }
        }

        public string DepartmentName
        {
            get { return Department?.Name; }
        }

        public string SectionName
        {
            get { return Department1?.Name; }
        }

        public int PersonelNumber
        {
            get { return Personnel != null ? Convert.ToInt32(Personnel.PersonnelNumber) : 0; }
        }
    }
}