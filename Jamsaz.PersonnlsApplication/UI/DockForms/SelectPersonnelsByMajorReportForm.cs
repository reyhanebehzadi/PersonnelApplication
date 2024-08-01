using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Microsoft.Reporting.WinForms;
using Jamsaz.Common;
using Jamsaz.Application.Common;
using Jamsaz.Application.Common.UI.DialogForm;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class SelectPersonnelsByMajorReportForm : Form
    {
        public SelectPersonnelsByMajorReportForm()
        {
            InitializeComponent();
        }
        private List<SelectPersonnelByMajorResult> result ;
        private List<Major> selectedItem = new List<Major>();
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
        private string universityDegreeIDs = string.Empty;
        private int? major_ID = null;

        private void SelectPersonnelsByMajorReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.universityDegreeBindingSource.DataSource = db.UniversityDegrees.ToList();
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(string.Format("{0}{1}{2}"
                                                           , "بروز خطا"
                                                           , "\n"
                                                           , ex.Message));
            }
        }

        private void selectMajorButton_Click(object sender, EventArgs e)
        {
            DialogForms.MajorsDialogForm MajorsDialogForm = new DialogForms.MajorsDialogForm() { MultiSelect = true };
            string delimiter = ",";
            if (MajorsDialogForm.ShowDialog() == DialogResult.OK)
            {
                this.majorNameTextBox.Text = MajorsDialogForm.SelectedMajorList.Aggregate((i, j) => new Major { Name = (i.Name + delimiter + j.Name) }).Name;

                selectedItem = MajorsDialogForm.SelectedMajorList;
                major_ID = selectedItem.First().Id;

                
                #region MyRegion
                //ResultSearchAdvencedBindingSource.DataSource = from c in db.Personnels
                //                                               where
                //                                                   c.MajorId == MajorsDialogForm.SelectedMajor.Id
                //                                                   orderby Convert.ToInt32( c.PersonnelNumber)
                //                                               select new ResultSearchAdvenced
                //                                                   {
                //                                                       MajorName = c.Major.Name,
                //                                                       FullNameFa = c.FirstName + " " + c.LastName,
                //                                                       FatherName = c.FatherName,
                //                                                       PersonnelNumber = c.PersonnelNumber,
                //                                                       Gender = c.Gender == 1 ? "مرد" : "زن",
                //                                                       IssueNo = c.IssueNo,
                //                                                       UniversityDegreeName  =c.UniversityDegree.Name
                //                                                   };

                #endregion
            }
        }

        private void selectUniversityDegreeButton_Click(object sender, EventArgs e)
        {
            BulkUniversityDegreeDialogForm bulkUniversityDegreeDialogForm = new BulkUniversityDegreeDialogForm(Properties.Settings.Default.JamsazERPLiteConnectionString) { };
            if (bulkUniversityDegreeDialogForm.ShowDialog() == DialogResult.OK)
            {
                universityDegreeIDs = bulkUniversityDegreeDialogForm.UniversityDegreeIDs;
                universityDegreeTextBox.Text = bulkUniversityDegreeDialogForm.UniversityDegreeNames;
            }
        }

        private void getReportButton_Click(object sender, EventArgs e)
        {

            try
            {
                int? gender = null;

                if (menRadioButton.Checked)
                    gender = 1;
                else if (womenRadioButton.Checked)
                    gender = 2;
                else
                    gender = null;

                if (this.universityDegreeIDs == string.Empty)
                {
                    result  = new List<SelectPersonnelByMajorResult>();
                    foreach (Major item in selectedItem)
                        result.AddRange(db.SelectPersonnelByMajor(item.Id, null, gender));
                    
                    this.SelectPersonnelByMajorResultBindingSource.DataSource = result;
                   
                }

                else
                    this.SelectPersonnelByMajorResultBindingSource.DataSource = db.SelectPersonnelByMajor(this.major_ID, this.universityDegreeIDs, gender).ToList();


                ReportParameter DateReportParameter = new ReportParameter("ReportDate", Jamsaz.Common.Helper.GetPersianDate(DateTime.Now));
                ReportParameter MajorNameParameter = new ReportParameter("MajorNameParameter", this.majorNameTextBox.Text);
                mainReportViewer.LocalReport.SetParameters(new ReportParameter[] { DateReportParameter, MajorNameParameter });

                this.mainReportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(string.Format("{0}{1}{2}"
                                                           , "بروز خطا"
                                                           , "\n"
                                                           , ex.Message));
            }
        }
    }
}
