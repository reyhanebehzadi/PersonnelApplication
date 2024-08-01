namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
    public partial class vwAccountNumberPersonnely_SearchAdvancedResult
    {
        private string bankAccountType;
        public string BankAccountType
        {
            get
            {
                switch (BankType)
                {
                    case 0:
                        return "سپرده";
                    case 1:
                        return "تسهیلات";
                    default:
                        return "";
                }
            }
            set { bankAccountType = value; }
        }
    }
}
