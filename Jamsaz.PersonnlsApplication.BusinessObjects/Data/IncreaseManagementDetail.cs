using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
    public partial class IncreaseManagementDetail
    {
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();

        public int PersonnelNumber
        {
            get
            {
                if (this.Personnel != null)
                    return int.Parse(Personnel.PersonnelNumber);

                return 0;
            }
        }

        public string PersonnelName
        {
            get
            {
                if (this.Personnel != null)
                    return Personnel.FirstName + " " + Personnel.LastName;

                return string.Empty;
            }
        }

        public string Semat
        {
            get
            {
                if (Personnel != null)
                    return
                        db.OrganizationStructurePersonnels.Where(c => c.PersonnelId == Personnel.Id).ToList().Last().OrganizationStructure.Name;

                return string.Empty;
            }
        }

        public int PayeHoghogh
        {
            get
            {
                if (this.IncreaseAmount != null && this.PayeGhabli != null)
                {
                    return IncreaseAmount.GetValueOrDefault() + PayeGhabli.GetValueOrDefault();
                }

                return 0;
            }
        }

        

    }
}
