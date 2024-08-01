using System;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
    public partial class vwMainPersonnely
    {
        public string ImageUrl { get; set; }// جهت استفاده برای گزارش گیری
        //بوده و ارزش قانونی دیگری نداذد !!!!
        public string City => Address; // جهت استفاده برای گزارش گیری

        //بوده و ارزش قانونی دیگری نداذد !!!!

    }
}