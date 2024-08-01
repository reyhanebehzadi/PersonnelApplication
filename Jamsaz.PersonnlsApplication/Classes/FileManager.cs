using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using System.Windows.Forms;
using System.Drawing;
using Jamsaz.Common;

namespace Jamsaz.PersonnlsApplication.Classes
{
   public static class FileManager
    {
       public static bool ThumbnailCallback()
       {
           return false;
       }

       public static void SavePictureWithResize(string passIdFile, string passPath)
       {
           Bitmap imgObject;

           try
           {
               using (FileStream fstPersons = new FileStream(passPath, FileMode.Open))
               {
                   imgObject = new Bitmap(fstPersons);
                   fstPersons.Close();
               }

               imgObject = new Bitmap(imgObject);
               Image img = (Image)imgObject;
               System.Drawing.Image.GetThumbnailImageAbort dummyCallBack = new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback);
               Image thumbnale = img.GetThumbnailImage(160, 120, dummyCallBack, IntPtr.Zero);
               thumbnale.Save("\\\\atlas\\Item Files\\Images\\" + passIdFile + ".jpg");
           }
           catch (Exception exp)
           {
               MessageBox.Show(exp.Message);
           }
       }

       public static bool Addfile(string passPersonnelNumber, string passPath)
       {
           try
           {
               Computer com = new Computer();
               if (File.Exists(Properties.Settings.Default.PathPersonnelsImage + passPersonnelNumber + ".jpg") != true)
               {
                   com.FileSystem.CopyFile(passPath, Properties.Settings.Default.PathPersonnelsImage + passPersonnelNumber + ".jpg", UIOption.AllDialogs);
                   return true;
               }
               else
               {
                   if (Helper.Confirm("فایل مورد نظر در سیستم موجود می باشد, آیا مایل به جایگزین کردن هستید"))
                   {
                       com.FileSystem.CopyFile(passPath, Properties.Settings.Default.PathPersonnelsImage + passPersonnelNumber + ".jpg", true);
                       return true;
                   }
               }
            
           }
           catch 
           {
               //helper.showMessage(exp.Message);
           }
           return false;
       }
       /// <summary>
       /// delet files in Cach dirctory
       /// </summary>
       /// <param name="fullPath"></param>
       public static bool DeleteFile(string  fullPathFiles)
       {
           try
           {
               if (File.Exists(fullPathFiles))
               {
                   File.Delete(fullPathFiles);
                   return true;
               }
           }
           catch (Exception exp)
           {
              // throw exp;
           }
           return false;
       }
       public static void DeleteFile(int passId)
       {
           try
           {
               if (File.Exists("\\\\atlas\\Item Files\\" + passId))
               {
                   File.Delete("\\\\atlas\\Item Files\\" + passId);
               }
           }
           catch (Exception exp)
           {
               throw exp;
           }
       }
       /// <summary>
       /// delet files from in Cach dirctory (\atlas\Item Files\Images\)
       /// </summary>
       /// <param name="fullPath"></param>
       public static void DeleteFileFromImages(int passId)
       {
           try
           {
               if (File.Exists("\\\\atlas\\Item Files\\Images\\" + passId +".jpg"))
               {
                   File.Delete("\\\\atlas\\Item Files\\Images\\" + passId + ".jpg");
               }
           }
           catch (Exception exp)
           {
               throw exp;
           }
       }


       public static void SaveAs(string passIdName, string passDestinationsPath,bool isOverwirte)
       {
           try
           {
               Computer com = new Computer();
               if (!isOverwirte)
               {
                            //File.Copy("\\\\atlas\\Item Files\\" + passIdName, passDestinationsPath,false);
                   com.FileSystem.CopyFile("\\\\atlas\\Item Files\\" + passIdName, passDestinationsPath, UIOption.AllDialogs);
               }
               else
                   com.FileSystem.CopyFile("\\\\atlas\\Item Files\\" + passIdName, passDestinationsPath, UIOption.AllDialogs);
                   //File.Copy("\\\\atlas\\Item Files\\" + passIdName, passDestinationsPath,true);
           }
           catch (Exception exp)
           {
               Helper.ShowMessage(exp.Message);
           }
       }


       public static void SetFileAttribute(string passFileName)
       {
           try
           {
               File.SetAttributes("C:\\CacheBom\\" + passFileName, FileAttributes.Normal);
           }
           catch 
           {
              // Helper.ShowMessage(exp.Message);
           }
       }

       public static void SetFileAttribute(int passIdFile)
       {
           try
           {
                   File.SetAttributes("\\\\atlas\\Item Files\\" + passIdFile, FileAttributes.Normal);
           }
           catch (Exception exp)
           {
               Helper.ShowMessage(exp.Message);
           }
       }
/// <summary>
/// Set file attribute from Images Folder to atlas Server  ["\\\\atlas\\Item Files\\Images"]
/// </summary>
/// <param name="passIdFile"></param>
       public static void SetFileAttributeFromImages(string passIdFile)
       {
           try
           {
               File.SetAttributes("\\\\atlas\\Item Files\\Images\\" + passIdFile + ".jpg", FileAttributes.Normal);
           }
           catch (Exception exp)
           {
               Helper.ShowMessage(exp.Message);
           }
       }


        
    }
}
