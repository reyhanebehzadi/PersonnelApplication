using System;
using System.Collections.Generic;
using System.Text;
using Jamsaz.PersonnlsApplication.Classes;
using Jamsaz.PersonnlsApplication.Resources;

namespace Jamsaz.PersonnlsApplication.Definitions
{
    public enum ActionForm
    {
        Insert,
        Edit
    }
    public enum TypeForm
    {
        form,dialogForm
    }
    public enum eMaritualStatus
    {
        Married = 1,
        Single = 2

    }
    public class enumMaritualStatus : enumBase<eMaritualStatus>
    {
        public enumMaritualStatus(int value)
            : base(value)
        { }
        }

    public enum eGender
    {
        male = 1,
        female = 2
    }


    public class enumGender : enumBase<eGender>
    {
        public enumGender(int value)
            : base(value)
        {
        }
    }
    public enum eApplicantStatus
    {
        Null = 0,
        AcceptedWaiting = 1,
        Rejcted = 2,
        InWaiting = 3
    }

    public class enumeApplicantStatus : enumBase<eApplicantStatus>
    {
        public enumeApplicantStatus(int value)
            : base(value)
        { }
    }

    public enum eFieldsContract
    {
        CurrentContractEndDate = 1,
        CurrentContractStartDate = 2,
        FirstContractStartDate = 3
    }

    public class enumFieldsContract : enumBase<eFieldsContract>
    {
        public enumFieldsContract(int value)
            : base(value)
        {
        }
    }

  

}
