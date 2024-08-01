using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Definitions
{
    public enum FormStatus
    {
        Add = 1,
        Edit
    }

    public enum ActionType
    {
        //SetadiFanni = 1,
        //SetadiEdari = 2,
        //GheireSetadi = 3,
        //GheireSetadiFanni = 4
        Setadi=1,
        Tolidi=2
    }

    public enum Location
    {
        Factory = 1,
        HeadOffice = 2
    }

    public enum ShiftType
    {
        Static = 1,
        Double = 2,
        Triple = 3,
    }

    public enum PersonnelStatus
    {
        employe=1,
        dismiss=0,
        Special=2,
        Retired=3
    }

   

    
}
