using System;
using System.Data;
using System.Configuration;
using System.Reflection;
using System.Web;
using System.IO;
using word = Microsoft.Office.Interop.Word;
using System.Windows.Forms;
using System.Text;
using Jamsaz.PersonnlsApplication.Properties;
using Microsoft.ReportingServices.Interfaces;

namespace Jamsaz.PersonnlsApplication.Classes
{
    public class WordManager
    {

        private word.Application axWord;
        private word.Document axDocument;

        //public void showdocument(string StrDocumentFilename, int TypeDocument, int fromPersonnelNumber, int toPersonnelNumer, string personnelNumbers, DateTime effectiveDate, int? isInFactory)
        //{
        //    try
        //    {
        //        string strConnectionODC = "";
        //        string strsql = "";
        //        string strsql1 = "";

        //        //if (TypeDocument == 1)
        //        //{
        //        //    strConnectionODC = "C:\\ConnectionString\\ATLAS JamsazERPLite vwCardPersonnely.odc";
        //        //    strsql = "SELECT PersonnelNumber,FullNameFa,FullNameEn,OccupationTitleEn,OccupationTitleFa FROM vwCardPersonnely WHERE [PersonnelNumber] >= " + fromPersonnelNumber.ToString() + " AND [PersonnelNumber] < = " + toPersonnelNumer.ToString() + " ORDER BY CAST (pn AS INT)";
        //        //}
        //        //if (TypeDocument == 2)
        //        //{
        //        //    strConnectionODC = "C:\\ConnectionString\\ATLAS JamsazERPLite vwContract.odc";
        //        //    strsql = "SELECT PN,Name,Fname,Ino,BCPIssue,BDate,uDeg,MaritalS,Address,Tel,CcontractSD,CContractED,Salary,Military,DN,HOlad,HMaskan,HSarparst,HSakhtiK,Sum,Gen,NCode,BAcc,CType,Pos FROM vwContract WHERE [pn] >= " + fromPersonnelNumber.ToString() + " AND [pn] < = " + toPersonnelNumer.ToString() + " ORDER BY CAST (pn AS INT)";
        //        //}
        //        //if (TypeDocument == 3)
        //        //{
        //        //    strConnectionODC = "C:\\ConnectionString\\atlas JamsazERPLite vwDecree.odc";
        //        //    strsql = "SELECT PN,Name,Ino,Fname,BDate,BL,Mil,uD,maj,Mar,CTe,CSD,CED,DN,OsT,dep,InsuranceNo,S1,S2,O1,O2,M1,M2,kh1,kh2,Sa1,Sa2,Sak1,Sak2,N1,N2,Sum1,Sum2 FROM vwDecree WHERE [pn] >= "+ fromPersonnelNumber.ToString() +" AND [pn] < = " +toPersonnelNumer.ToString() + " ORDER BY CAST (pn AS INT)";
        //        //}

        //        if (TypeDocument == 1)
        //        {
        //            //strConnectionODC = "C:\\ConnectionString\\ATLAS JamsazERPLite vwCardPersonnely.odc";
        //            //strsql = "SELECT PersonnelNumber,FullNameFa,FullNameEn,OccupationTitleEn,OccupationTitleFa FROM vwCardPersonnely ";
        //            //if (personnelNumbers == null)
        //            //    strsql1 = "WHERE ([PersonnelNumber] >= " + fromPersonnelNumber.ToString() + " AND [PersonnelNumber] < = " + toPersonnelNumer.ToString() + ") ORDER BY CAST (pn AS INT)";
        //            //else
        //            //    strsql1 = "WHERE ([PersonnelNumber] >= " + fromPersonnelNumber.ToString() + " AND [PersonnelNumber] < = " + toPersonnelNumer.ToString() + ") Or ([PersonnelNumber] In (" + personnelNumbers + ")) ORDER BY CAST (PersonnelNumber AS INT)";

        //            strConnectionODC = "C:\\ConnectionString\\atlas JamsazERPLite PersonnelsCard.odc";
        //            strsql = "Execute [hrm].[SelectPersonnelCards]" + fromPersonnelNumber + "," + toPersonnelNumer + "," + "'" + personnelNumbers + "'";


        //        }
        //        if (TypeDocument == 2)
        //        {
        //            strConnectionODC = "C:\\ConnectionString\\ATLAS JamsazERPLite vwContract.odc";
        //            strsql = "Execute [hrm].[SelectPersonnelContracts]" + fromPersonnelNumber + "," + toPersonnelNumer + "," + "'" + effectiveDate.ToShortDateString() + "'" + "," + "'" + personnelNumbers + "'" + "," + "'" + isInFactory + "'";//"SELECT A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,V,W,X,Y,Z,A1,B1,C1 FROM vwContract WHERE (A>= " + fromPersonnelNumber.ToString() + " AND A<= " + toPersonnelNumer.ToString() + ") ";

        //            /*
        //            if (personnelNumbers == null)
        //                strsql1 = " ORDER BY CAST (A AS INT)";
        //            else
        //                strsql1 = "Or (A In(" + personnelNumbers + ")) ORDER BY CAST (A AS INT)";
        //            */
        //            //
        //            string s = strsql;
        //        }
        //        if (TypeDocument == 3)
        //        {
        //            strConnectionODC = "C:\\ConnectionString\\atlas JamsazERPLite vwDecree.odc";
        //            strsql = "Execute [hrm].[SelectPersonnelDecree]" + fromPersonnelNumber + "," + toPersonnelNumer + "," + "'" + effectiveDate.ToShortDateString() + "'" + "," + "'" + personnelNumbers + "'" + "," + "'" + isInFactory + "'";

        //            /*
        //            strsql = "SELECT PN,Name,Ino,Fname,BDate,BL,Mil,uD,maj,Mar,CTe,CSD,CED,DN,OsT,dep,InsuranceNo,S1,S2,O1,O2,M1,M2,kh1,kh2,Sa1,Sa2,Sak1,Sak2,N1,N2,Sum1,Sum2 FROM vwDecree ";
        //            if (personnelNumbers == null)
        //                strsql1 = "WHERE ([pn] >= " + fromPersonnelNumber.ToString() + " AND [pn] <=" + toPersonnelNumer.ToString() + ") ORDER BY CAST (pn AS INT)";
        //            else
        //                strsql1 = "WHERE ([pn] >= " + fromPersonnelNumber.ToString() + " AND [pn] <=" + toPersonnelNumer.ToString() + ") Or ([pn] In (" + personnelNumbers + ")) ORDER BY CAST (pn AS INT)";
        //             */

        //            string s = strsql;
        //        }
        //        if (TypeDocument == 4)
        //        {
        //            str = "C:\\ConnectionString\\atlas JamsazERPLite PersonnelsEvaluation.odc";
        //            object[] objArray3 = new object[] { "Execute [hrm].[SelectPersonnelEvaluations]", fromPersonnelNumber, ",", toPersonnelNumer, ",'", personnelNumbers, "'" };
        //            str1 = string.Concat(objArray3);
        //        }

        //        this.StartWord();

        //        object owdOpenFormatAuto = word.WdMailMergeMainDocType.wdDirectory;
        //        object owdMergeSubTypeOAL = word.WdMergeSubType.wdMergeSubTypeWorks;
        //        object ofileName = StrDocumentFilename;
        //        object oFalse = false;
        //        object oTrue = true;
        //        object oMissing = System.Reflection.Missing.Value;
        //        object oNull = "";
        //        object oSQL = strsql;
        //        object osql1 = strsql1;

        //        axDocument = axWord.Documents.Open(ref ofileName,
        //                                           ref oFalse,
        //                                           ref oTrue,
        //                                           ref oMissing,
        //                                           ref oMissing,
        //                                           ref oMissing,
        //                                           ref oMissing,
        //                                           ref oMissing,
        //                                           ref oMissing,
        //                                           ref oMissing,
        //                                           ref oMissing,
        //                                           ref oMissing,
        //                                           ref oFalse,
        //                                           ref oMissing,
        //                                           ref oMissing,
        //                                           ref oMissing);

        //        axDocument.Activate();

        //        // axDocument.MailMerge.MainDocumentType = Microsoft.Office.Interop.Word.WdMailMergeMainDocType.wdNotAMergeDocument;
        //        axDocument.MailMerge.MainDocumentType = Microsoft.Office.Interop.Word.WdMailMergeMainDocType.wdDirectory;


        //        axDocument.MailMerge.OpenDataSource(strConnectionODC,
        //                                            ref owdOpenFormatAuto,
        //                                            ref oFalse,
        //                                            ref oFalse,
        //                                            ref oFalse,
        //                                            ref oFalse,
        //                                            ref oNull,
        //                                            ref oNull,
        //                                            ref oFalse,
        //                                            ref oNull,
        //                                            ref oNull,
        //                                            ref oMissing,//dsf
        //                                            ref oSQL,
        //                                            ref osql1,
        //            /*ref oNull,*/
        //                                            ref oFalse,
        //                                            ref owdMergeSubTypeOAL);

        //        //--------------------------------------------------------
        //        axDocument.MailMerge.DataSource.FirstRecord = 1;
        //        axDocument.MailMerge.DataSource.LastRecord = -16;
        //        axDocument.MailMerge.Execute(ref oTrue);
        //    }
        //    catch (Exception exp)
        //    {
        //        MessageBox.Show(exp.Message);
        //    }
        //}

        public void showdocument(string StrDocumentFilename, int TypeDocument, int fromPersonnelNumber, int toPersonnelNumer, string personnelNumbers, DateTime effectiveDate, int? isInFactory, DateTime ADate)
        {
            try
            {
                string year = effectiveDate.Year.ToString();
                string month = effectiveDate.Month.ToString();
                string day = effectiveDate.Day.ToString();
                string tempEffectiveDate = string.Format("{0}-{1}-{2}", year, month, day);

                string ayear = ADate.Year.ToString();
                string amonth = ADate.Month.ToString();
                string aday = ADate.Day.ToString();
                string tempADate = string.Format("{0}-{1}-{2}", ayear, amonth, aday);



                string str = "";
                string str1 = "";
                string str2 = "";
                if (TypeDocument == 1)
                {
                    str = String.Concat(Settings.Default.PathConnectionString, "atlas JamsazERPLite PersonnelsCard.odc");
                    object[] objArray = new object[] { "Execute [hrm].[SelectPersonnelCards]", fromPersonnelNumber, ",", toPersonnelNumer, ",'", personnelNumbers, "'" };
                    str1 = string.Concat(objArray);
                }
                if (TypeDocument == 2)
                {
                    str = String.Concat(Settings.Default.PathConnectionString, "ATLAS JamsazERPLite vwContract.odc");
                    object[] objArray1 = new object[] { "Execute [hrm].[SelectPersonnelContracts]", fromPersonnelNumber, ",", toPersonnelNumer, ",'",tempEffectiveDate, "','", personnelNumbers, "','", isInFactory, "'" };
                    // effectiveDate.ToShortDateString()
                    str1 = string.Concat(objArray1);
                }
                if (TypeDocument == 3)
                {
                    str = String.Concat(Settings.Default.PathConnectionString, "atlas JamsazERPLite vwDecree.odc");
                    object[] objArray2 = new object[] { "Execute [hrm].[SelectPersonnelDecree]", fromPersonnelNumber, ",", toPersonnelNumer, ",'", tempEffectiveDate, "','", personnelNumbers, "','", isInFactory, "'" };
                    // effectiveDate.ToShortDateString()
                    str1 = string.Concat(objArray2);
                }
                if (TypeDocument == 4)
                {
                    str = String.Concat(Settings.Default.PathConnectionString, "atlas JamsazERPLite PersonnelsEvaluation.odc");
                    object[] objArray3 = new object[] { "Execute [hrm].[SelectPersonnelEvaluations]", fromPersonnelNumber, ",", toPersonnelNumer, ",'", personnelNumbers, "','", tempADate, "'" };
                    //ADate.ToShortDateString()
                    str1 = string.Concat(objArray3);
                }
                if (TypeDocument == 5)
                {
                    str = String.Concat(Settings.Default.PathConnectionString, "JamsazERPLite PersonnelsDescription.odc");
                    object[] objArray3 = new object[] { "Execute [hrm].[SelectPersonnelDescription]", fromPersonnelNumber, ",", toPersonnelNumer, ",'", personnelNumbers, "'" };
                    str1 = string.Concat(objArray3);
                }
                if (TypeDocument == 6)
                {
                    str = String.Concat(Settings.Default.PathConnectionString, "atlas JamsazERPLite PersonnelsCard.odc");
                    object[] objArray = new object[] { "Execute [hrm].[SelectPersonnelCards]", fromPersonnelNumber, ",", toPersonnelNumer, ",'", personnelNumbers, "'" };
                    str1 = string.Concat(objArray);
                }
                if (TypeDocument == 7)
                {
                    str = String.Concat(Settings.Default.PathConnectionString, "atlas JamsazERPLite PersonnelsZheton.odc");
                    object[] objArray = new object[] { "Execute [hrm].[SelectPersonnelZheton]", fromPersonnelNumber, ",", toPersonnelNumer, ",'", personnelNumbers, "'" };
                    str1 = string.Concat(objArray);
                }


                this.StartWord();
                object obj = word.WdMailMergeMainDocType.wdCatalog;
                object obj1 = word.WdMergeSubType.wdMergeSubTypeWorks;
                object strDocumentFilename = StrDocumentFilename;
                object obj2 = false;
                object obj3 = true;
                object value = Missing.Value;
                object obj4 = "";
                object obj5 = str1;
                object obj6 = str2;
                this.axDocument = this.axWord.Documents.Open(ref strDocumentFilename, ref obj2, ref obj3, ref value, ref value, ref value, ref value, ref value, ref value, ref value, ref value, ref value, ref obj2, ref value, ref value, ref value);
                this.axDocument.Activate();
                this.axDocument.ActiveWindow.View.Type = word.WdViewType.wdNormalView;
                this.axDocument.MailMerge.MainDocumentType = word.WdMailMergeMainDocType.wdCatalog;
                this.axDocument.MailMerge.OpenDataSource(str, ref obj, ref obj2, ref obj2, ref obj2, ref obj2, ref obj4, ref obj4, ref obj2, ref obj4, ref obj4, ref value, ref obj5, ref obj6, ref obj2, ref obj1);
                this.axDocument.MailMerge.DataSource.FirstRecord = 1;
                this.axDocument.MailMerge.DataSource.LastRecord = -16;
                this.axDocument.MailMerge.Execute(ref obj3);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private word.Application StartWord()
        {
            if (IsWordActive() == false)
            {
                axWord = new Microsoft.Office.Interop.Word.Application();
                axWord.Visible = true;
            }
            return axWord;
        }

        private bool IsWordActive()
        {
            try
            {
                string strName;
                strName = axWord.Name;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
