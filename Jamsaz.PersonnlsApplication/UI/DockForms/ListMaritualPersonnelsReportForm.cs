using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class ListMaritualPersonnelsReportForm : Jamsaz.Common.BasePersianForm
    {
        public ListMaritualPersonnelsReportForm()
        {
            InitializeComponent();
        }
        JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);

        private void ListMaritualPersonnelsReportForm_Load(object sender, EventArgs e)
        {
            List<ResultSearchAdvenced> maritualPersonnels = new List<ResultSearchAdvenced>();
            maritualPersonnels = (from c in db.Personnels
                                  where c.IsActive == true && c.MaritalStatus == 1 && c.Gender == 1
                                  orderby Convert.ToInt64(c.PersonnelNumber)
                                  select new ResultSearchAdvenced
                                  {
                                      FullNameFa = c.FirstName + " " + c.LastName,
                                      PersonnelNumber = c.PersonnelNumber,
                                      FatherName = c.FatherName,
                                      IssueNo = c.NationalCode
                                  }).ToList();
            ResultSearchAdvencedBindingSource.DataSource = maritualPersonnels;
            this.mainReportViewer.RefreshReport();
        }

        private void maleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (maleRadioButton.Checked)
            {
                List<ResultSearchAdvenced> maritualPersonnels = new List<ResultSearchAdvenced>();
                maritualPersonnels = (from c in db.Personnels
                                      where c.IsActive == true && c.MaritalStatus == 1 && c.Gender == 1
                                      orderby Convert.ToInt64(c.PersonnelNumber)
                                      select new ResultSearchAdvenced
                                      {
                                          FullNameFa = c.FirstName + " " + c.LastName,
                                          PersonnelNumber = c.PersonnelNumber,
                                          FatherName = c.FatherName,
                                          IssueNo = c.NationalCode
                                      }).ToList();
                ResultSearchAdvencedBindingSource.DataSource = maritualPersonnels;
                this.mainReportViewer.RefreshReport();
            }
        }

        private void femaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (femaleRadioButton.Checked)
            {
                List<ResultSearchAdvenced> maritualPersonnels = new List<ResultSearchAdvenced>();
                maritualPersonnels = (from c in db.Personnels
                                      where c.IsActive == true && c.MaritalStatus == 1 && c.Gender == 2
                                      orderby Convert.ToInt64(c.PersonnelNumber)
                                      select new ResultSearchAdvenced
                                      {
                                          FullNameFa = c.FirstName + " " + c.LastName,
                                          PersonnelNumber = c.PersonnelNumber,
                                          FatherName = c.FatherName,
                                          IssueNo = c.NationalCode
                                      }).ToList();
                ResultSearchAdvencedBindingSource.DataSource = maritualPersonnels;
                this.mainReportViewer.RefreshReport();
            }
        }

       

        private void allRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (allRadioButton1.Checked)
            {
                List<ResultSearchAdvenced> maritualPersonnels = new List<ResultSearchAdvenced>();
                maritualPersonnels = (from c in db.Personnels
                                      where c.IsActive == true && c.MaritalStatus == 1 
                                      orderby Convert.ToInt64(c.PersonnelNumber)
                                      select new ResultSearchAdvenced
                                      {
                                          FullNameFa = c.FirstName + " " + c.LastName,
                                          PersonnelNumber = c.PersonnelNumber,
                                          FatherName = c.FatherName,
                                          IssueNo = c.NationalCode
                                      }).ToList();
                ResultSearchAdvencedBindingSource.DataSource = maritualPersonnels;
                this.mainReportViewer.RefreshReport();
            }
        }
    }
}
