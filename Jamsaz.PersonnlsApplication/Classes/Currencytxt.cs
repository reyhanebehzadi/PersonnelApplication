using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;


namespace Jamsaz.PersonnlsApplication.Classes
{
    class Currencytxt : AMS.TextBox.CurrencyTextBox
    {
        
        string s;
        // string ValueText;
        private int GetDigitToString(string value)
         {
             try
             {
                 string tmp = string.Empty;
                 foreach (char item in value)
                 {
                     if (char.IsDigit(item))
                         tmp += item;
                 }
                 return int.Parse(tmp);
             }
             catch
             {
                 return 0;
             }

         }

        [Browsable(true), Bindable(true), Category("Data")]
        public string GetInt
        {

            get
            {
                try
                {
                    // int i = base.Text.IndexOf("/");

                    // s = base.Text.Replace("ریال", string.Empty);
                    //s = base.Text.Replace("$", string.Empty);
                    //s = s.Replace("/00", string.Empty);
                    //s = s.Replace(",", string.Empty);
                    //s = s.Replace("-", string.Empty);
                    //s = s.Trim();
                    //int i = s.IndexOf(" ");
                    //s = s.Substring(i+1);

                    //if (!helper.HassInteger(s))
                    //    s = "0";

                    if (!string.IsNullOrEmpty(s))
                        return GetDigitToString(s).ToString();
                    else return "0";
                }
                catch
                {
                    return s = "0";
                }
            }
            set
            {
                base.Text = value;
            }

        }

        public override string Text
        {
            get
            {
                return GetDigitToString(base.Text).ToString();
            }
            set
            {
                try
                {
             
                    base.Text = value;
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }

            }
        }

        //public int ToInteger
        //{
            
        //    get
        //    {
        //        try
        //        {

        //            if (!string.IsNullOrEmpty(base.Text))
        //            {
        //                ValueText = base.Text.Replace("ريال 0", string.Empty);
        //                ValueText = ValueText.Replace("$", string.Empty);
        //                ValueText = ValueText.Replace("/00", string.Empty);
        //                ValueText = ValueText.Replace(",", string.Empty);
        //                ValueText = ValueText.Replace("-", string.Empty);
        //                ValueText = ValueText.Replace(".00", string.Empty);
        //                ValueText = ValueText.Trim();

        //                if (string.IsNullOrEmpty(ValueText))
        //                    ValueText = "0";

        //                return int.Parse(ValueText);
        //            }
        //            else
        //                return 0;
        //        }
        //        catch (Exception)
        //        {
        //            return int.Parse(ValueText);
        //        }
        //    }
        //}
        
    }
}
