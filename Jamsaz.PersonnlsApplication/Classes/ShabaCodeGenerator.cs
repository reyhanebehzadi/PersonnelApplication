using System;
using System.Globalization;

namespace Jamsaz.PersonnlsApplication.Classes
{
    public class ShabaCodeGenerator
    {
        #region Constants

        private const string CountryCcWord = "IR";
        private const string CountryCcCode = "182700";

        #endregion

        #region Properties

        public string BankCode { get; set; }
        public string BankAccount { get; set; }
        public string AccountType { get; set; }

        #endregion

        #region Ctor

        public ShabaCodeGenerator(string bankCode, string bankAccount, string accountType)
        {
            BankAccount = bankAccount;
            BankCode = bankCode;
            AccountType = accountType;
        }

        #endregion

        #region Public Methods

        public string Generate()
        {
            var accountNumberDistance = 18 - BankAccount.Length;
            var accountNumberZeroes = "";
            for (var i = 0; i < accountNumberDistance; i++)
            {
                accountNumberZeroes += "0";
            }
            var instance = decimal.Parse($"{BankCode}{AccountType}{accountNumberZeroes}{BankAccount}{CountryCcCode}");
            var res = Math.Abs((instance % 97) - 98).ToString(CultureInfo.InvariantCulture);
            if (res.Length == 1) res = "0" + res;
            var sheba = $"{CountryCcWord}{res}{BankCode}{AccountType}{accountNumberZeroes}{BankAccount}";
            return sheba.Length != 26 ? "" : CreateSplitedString(sheba);
        }

        #endregion

        #region Private Methods

        private static string CreateSplitedString(string input)
        {
            var result = "";
            for (var i = 0; i < input.Length; i++)
            {
                if (i == 3 || i == 7 || i == 11 || i == 15 || i == 19 || i == 23)
                {
                    result += input[i] + " ";
                }
                else
                {
                    result += input[i];
                }
            }
            return result;
        }

        #endregion
    }
}
