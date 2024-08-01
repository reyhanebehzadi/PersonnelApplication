using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace Jamsaz.PersonnlsApplication.Classes
{
    public class ExportToExcel<T>
    {

        public static void Export(List<T> list)
        {

            //excel = new Microsoft.Office.Interop.Excel.Application();
            //System.Globalization.CultureInfo myCultureInfo = new System.Globalization.CultureInfo("en-US");
            //System.Threading.Thread.CurrentThread.CurrentCulture = myCultureInfo;
            //book = excel.Workbooks.Add(missing);
            //sheetsColl = excel.Worksheets;
            //sheet = (Microsoft.Office.Interop.Excel.Worksheet)sheetsColl.get_Item("Sheet1"); 
            
            System.Globalization.CultureInfo myCultureInfo = new System.Globalization.CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentCulture = myCultureInfo;

            Object missing = System.Reflection.Missing.Value;

            Microsoft.Office.Interop.Excel.Application excelApplication = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workBook = excelApplication.Workbooks.Add(missing);
            Sheets sheet = excelApplication.Worksheets;
            Worksheet workSheet = (Worksheet)sheet.get_Item("Sheet1");


            int row = 0;
            int column = 0;
            PropertyInfo[] Infos = list.First().GetType().GetProperties();
            foreach (PropertyInfo item in Infos)
            {
                workSheet.Cells[row + 1, column + 1] = item.Name;
                column++;
            }

            foreach (T item in list)
            {
                column = 0;
                row++;
                PropertyInfo[] collection = item.GetType().GetProperties();
                foreach (PropertyInfo property in collection)
                {
                    try
                    {
                        workSheet.Cells[row + 1, column + 1] = property.GetValue(item, null);
                    }
                    catch { }
                    column++;
                }
            }

            workSheet.Columns.AutoFit();
            excelApplication.Visible = true;
        }

    }
}
