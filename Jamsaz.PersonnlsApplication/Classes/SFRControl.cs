using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace Jamsaz.PersonnlsApplication.Classes
{
   public  static class SFRControl
    {
       static Suprema.SFR sfr = new Suprema.SFR();
       static byte[] template1 = new byte[384];
       private static int valCodeMessage;

       public static string loadDeviceFingerScanner()
       {
           sfr.Initialize();
           string GetDevTitle = sfr.ReturnMessage + "\n" 
           + "\n Device : " + sfr.Device.ToString()
           + "\n Device Number : " + sfr.DeviceNumber.ToString()
           + "\n Device Serial :" + sfr.DeviceSerial.ToString()
           + "\n Sensor :" + sfr.Sensor.ToString()
           + "\n Is Sensor On : " + sfr.IsSensorOn().ToString()
           + "\n Is Finger On : " + sfr.IsFingerOn().ToString();
           return GetDevTitle;
       }

       public static string SetValueAttributes()
       {
           sfr.SensorBrightness = 100;
           sfr.SecurityLevel = 4;
           sfr.MatchMode = Suprema.SFR.MatchType.NORMAL_MODE;
           sfr.SensorSensitivity = 4;
           sfr.ImageCheckQuality = 70;
           sfr.TimeOut = 10;
           sfr.Sensor = Suprema.SFR.SensorType.SFR300V2;
     //---------------------------------------------------
           string GetTitleAtt =   "Sensor Brightness : 100\n"
             +"Security Level : 4\n"
             +"Match Mode : Normal Mode\n"
             +"Sensor Sensitivity : 4\n"
             +"Quality : 70\n"
             +"Time Out : 10\n"
             +"Sensor : SFR300";
             return GetTitleAtt;
       }

       //////////////////////////////////////

     /// <summary>
     /// گرفتن اثر انگشت مرجع 
     /// </summary>
     /// <returns></returns>
     /// 
       public static byte[] LoadTemplate ()
       {
           template1 = GetTemplate();
           valCodeMessage = sfr.ReturnCode;
           return template1;
       }


       public static int GetQuality
       {
           get 
           {
               return sfr.Quality;
           }
       }

       public static void LoadCurrentFinger()
       {
               bool returnvalue = sfr.MatchTemplate(template1, true, true);
               valCodeMessage = sfr.ReturnCode;
       }
       public static bool ConfirmCurrentFinger(byte[] tempFinger)
       {
           bool returnvalue = sfr.MatchTemplate(tempFinger, true, true);
           valCodeMessage = sfr.ReturnCode;
           return returnvalue;
       }

       public static Bitmap GetLastImage
       {
           get
           {
               return sfr.GetLastImage();
           }
       }

       public static int ReturnCodeMessage
       {
           get
           {
               return valCodeMessage;
           }
       }

       public static string GetMessage
       {
           get
           {
               return ReturnMessageToPersian(valCodeMessage);
           }
       }

       public static byte[] GetTemplate()
       {
           byte[] bytes = new byte[384];

           try
           {
               bytes = sfr.ScanTemplate(true, true);
               valCodeMessage = sfr.ReturnCode;
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message.ToString());
           }

           return bytes;
       }

       public static string ReturnMessageToPersian(int getCode)
       {
           switch (getCode)
           {
               case 0: return "نمونه برداری مرجع مورد تأیید نمی باشد";
               case 1:
                   return " مورد تأیید می باشد";
               case 1005:
                   return " انگشت خود را روی اسنکر  قرار دهید";
               case 1202:
                   return "اثر انگشت مورد تأیید نیست";
               case 16:
               case 4:
               case 8:
               case 32:
                   return "مرکز انگشت پیدا نشد";
               default: return "مورد تأیید نمی باشد";
                 
           }
           return "";
       }

    }
}
