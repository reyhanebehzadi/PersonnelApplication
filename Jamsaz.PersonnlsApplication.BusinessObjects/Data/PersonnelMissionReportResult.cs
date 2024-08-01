using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
  public partial  class PersonnelMissionReportResult
    {
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        public string CarName
        {
            get
            {
                
                if (CarID != null)
                {
                    if (db.CarDeliveries.SingleOrDefault(c => c.CarID == this.CarID && c.IsActive == true) != null)
                    {
                        Car car = db.CarDeliveries.SingleOrDefault(c => c.CarID == this.CarID && c.IsActive == true).Car;
                        return car.Name + "(" + car.DriverName + ")";
                    }
                    else
                    {
                        CarDelivery deliver = db.CarDeliveries.Where(c => c.CarID == this.CarID).OrderByDescending(d=>d.ToDate).First();
                        string fullName = db.Personnels.SingleOrDefault(c => c.Id == deliver.PersonnelID).FirstName + " " + db.Personnels.SingleOrDefault(c => c.Id == deliver.PersonnelID).LastName;
                        Car car = deliver.Car;
                        return car.Name + "(" + fullName + ")";
                    }
                    
                }
               else


                return string.Empty;
            }
            set { }
        }

        public string Confirm
        {
            get
            {
                if (this != null)

                    return "تایید";
                return string.Empty;
            }
            set { }
        }
    }
}
