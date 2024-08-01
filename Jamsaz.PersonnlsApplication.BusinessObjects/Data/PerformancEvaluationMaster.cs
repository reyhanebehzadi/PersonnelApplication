using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
    public partial class PerformancEvaluationMaster
    {
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        public string StartDate
        {
            get
            {
                if (this.StartDateAssessment != null)
                
                    return Helper.GetPersianDate(this.StartDateAssessment.GetValueOrDefault());
              return  string.Empty;
            }
        }

       

        public string PersonnelNumber
        {
            get
            {
                if (this.Personnel!=null)
                
                    return Personnel.PersonnelNumber;
                return string.Empty;
            }
        }

        public string FullName
        {
            get
            {
                if (this.Personnel != null)

                    return string.Format("{0} {1}",Personnel.FirstName,Personnel.LastName);
                return string.Empty;
            }
        }

        public string Department
        {
            get
            {
                if (this.Personnel != null)

                    return Personnel.Department.Name ;
                return string.Empty;
            }
        }

        public string WorkStartDate
        {
            get
            {
                if (this.Personnel != null)

                    return Helper.GetPersianDate(Personnel.WorkStartDate.GetValueOrDefault());
                return string.Empty;
            }
        }

        public string Positon
        {
            get
            {
                if (this.Personnel != null)

                   return db.OrganizationStructurePersonnels.SingleOrDefault(c=>c.PersonnelId==this.Personnel.Id && c.IsMainPosition==true).OrganizationStructure.Name;
                  
                return string.Empty;
            }
        }

        public string Encouragement { get; set; }  // لیست تشویق ها

        public string Punishment { get; set; } //لیست تنبیه ها

    }
}
