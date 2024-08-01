using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
    public partial class MissionApprovalGroupDetail
    {
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();

        private bool _isNew = false;
        public bool IsNew
        {
            get
            {
                return this._isNew;
            }
            set
            {
                this._isNew = value;
            }
        }
        public string PersonnelName
        {
            get
            {
                if (this.PersonnelID != null)
                {
                    Personnel temp = db.Personnels.SingleOrDefault(c => c.Id == this.PersonnelID);
                    return string.Format("[{0}] : {1} {2}", temp.PersonnelNumber, temp.FirstName, temp.LastName);
                }
                else
                    return string.Empty;

            }

        }

        public string ReplacementPersonnelName
        {
            get
            {
                if (this.ReplacementPersonnelID != null)
                {
                    Personnel temp = db.Personnels.SingleOrDefault(c => c.Id == this.ReplacementPersonnelID);
                    return string.Format("[{0}] : {1} {2}", temp.PersonnelNumber, temp.FirstName, temp.LastName);
                }
                else
                    return string.Empty;

            }
        }

        public string ReplacementPersonnel2Name
        {
            get
            {
                if (this.ReplacementPersonnelID2 != null)
                {
                    Personnel temp = db.Personnels.SingleOrDefault(c => c.Id == this.ReplacementPersonnelID2);
                    return string.Format("[{0}] : {1} {2}", temp.PersonnelNumber, temp.FirstName, temp.LastName);
                }
                else
                    return string.Empty;

            }

        }
    }
}
