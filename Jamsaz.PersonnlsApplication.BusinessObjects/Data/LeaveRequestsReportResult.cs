using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
   public partial class LeaveRequestsReportResult
    {
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


        public bool IsSelect { get; set; }

    }
}
