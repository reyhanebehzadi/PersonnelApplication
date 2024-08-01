using System.Linq;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
    public partial class PersonelBankAccount
    {
        private string bankName;
        public string BankName
        {
            get
            {
                using (var db = new JamsazERPLiteDataClassesDataContext())
                {
                    var bank = db.Banks.SingleOrDefault(x => x.ID == BankID);
                    if (bank != null) return bank.Name;
                }
                return "";
            }
            set { bankName = value; }
        }

        private string bankAccountType;
        public string BankAccountType
        {
            get
            {
                switch (Type)
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
