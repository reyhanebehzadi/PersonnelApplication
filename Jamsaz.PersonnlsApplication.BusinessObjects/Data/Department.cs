using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
    public partial class Department
    {
        public string OriginalDepartmentName
        {
            get
            {
                if (this.OriginalDepartment != null)
                    return string.Format("{0} : {1} ->> {2} : {3}", "کد واحد اصلی ", this.OriginalDepartment.Code, "نام", this.OriginalDepartment.Name);
                return string.Empty;
            }
        }

        public string OriginalCode
        {
            get
            {
                if (this.OriginalDepartment != null)
                    return this.OriginalDepartment.Code;
                return string.Empty;
            }
        }

        public string OriginalName
        {
            get
            {
                if (this.OriginalDepartment != null)
                    return this.OriginalDepartment.Name;
                return string.Empty;
            }
        }

    }
}
