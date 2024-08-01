using Jamsaz.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
   public partial class EidRegistration
    {
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        public string FullName
        {
            get
            {
                if (this.Personnel != null)

                    return string.Format("{0} {1} ", this.Personnel.FirstName, this.Personnel.LastName);

                else
                    return string.Empty;
            }

        }

        public string PersonnelNumber
        {
            get
            {
                if (this.Personnel != null)

                    return this.Personnel.PersonnelNumber;

                else
                    return string.Empty;
            }

        }
        public string PayTypeTitle
        {
            get
            {
                if (this.PayType != null)

                    return PayType.Title;

                else
                    return string.Empty;
            }

        }
        public string Year
        {
            get
            {
                if (this.FiscalYearID != null)

                    return this.FiscalYear.Title;

                else
                    return string.Empty;
            }

        }

        public string StartDate
        {
            get
            {
                if (this.Personnel != null)

                    return Helper.GetPersianDate( this.Personnel.FirstContractStartDate.GetValueOrDefault());

                else
                    return string.Empty;
            }

        }

        public string EndtDate
        {
            get
            {
                if (this.Personnel != null)

                    return Helper.GetPersianDate(this.Personnel.CurrentContractEndDate.GetValueOrDefault());

                else
                    return string.Empty;
            }

        }

        public string JobTitle
        {
            get
            {
                if (this.Personnel != null)
                {
                    return (from D in db.OrganizationStructures
                            join c in db.OrganizationStructurePersonnels
                            on D.Id equals c.OrganisationStructureId
                            where c.PersonnelId == this.PersonnelID && c.IsMainPosition == true
                            select D.Name).First().ToString();
                }
                else

                    return string.Empty;
            }
        }
    }
}
