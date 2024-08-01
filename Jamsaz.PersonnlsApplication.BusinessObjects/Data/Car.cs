using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
    public partial class Car
    {
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        public string DriverName
        {
            get
            {

                CarDelivery Driver = db.CarDeliveries.SingleOrDefault(c => c.CarID == this.ID && c.IsActive == true);
                if (Driver != null)
                    return Driver.Personnel.FirstName + " " + Driver.Personnel.LastName;
                return string.Empty;
            }
        }
    }
}
