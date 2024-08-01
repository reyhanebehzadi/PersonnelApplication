using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.PersonnlsApplication.UI.ReportForms;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class SettlementReportForm : BasePersianForm
    {
        public SettlementReportForm()
        {
            InitializeComponent();
        }
        List<GetSettlementReportResult> list = new List<GetSettlementReportResult>();
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        private void showButton_Click(object sender, EventArgs e)
        {
            list.Clear();
            if (fromDatePicker.SelectedDateTime != null && toDatePicker.SelectedDateTime != null && SettlementCategorycomboBox.SelectedIndex != -1)
            {
                list = db.GetSettlementReport(fromDatePicker.SelectedDateTime.Value.Date, toDatePicker.SelectedDateTime.Value.Date, null, ((SettlementCategory)settlementCategoryBindingSource.Current).ID, complainedCheckBox.Checked, accidentComplaintCheckBox.Checked).ToList();

            }
            else if (fromDatePicker.SelectedDateTime != null && toDatePicker.SelectedDateTime != null && SettlementCategorycomboBox.SelectedIndex == -1)
            {

                list = db.GetSettlementReport(fromDatePicker.SelectedDateTime.Value.Date, toDatePicker.SelectedDateTime.Value.Date, null, null, complainedCheckBox.Checked, accidentComplaintCheckBox.Checked).ToList();


            }
            else if (fromDatePicker.SelectedDateTime == null && toDatePicker.SelectedDateTime == null && SettlementCategorycomboBox.SelectedIndex != -1)
                list = db.GetSettlementReport(null, null, null, ((SettlementCategory)settlementCategoryBindingSource.Current).ID, complainedCheckBox.Checked, accidentComplaintCheckBox.Checked).ToList();
            else
                list = db.GetSettlementReport(null, null, null, null, complainedCheckBox.Checked, accidentComplaintCheckBox.Checked).ToList();

            list.Add(new GetSettlementReportResult() { price = list.Sum(p => p.price) });


            if (payCheckBox.Checked)
                list = list.Where(p => p.Pay_complaint == true).ToList();
            else
                list = list.Where(p => p.Pay_complaint == false).ToList();

            list.Add(new GetSettlementReportResult()
            {
                price = list.Sum(p => p.price)
            });

            getSettlementReportResultBindingSource.DataSource = list;
        }

        private void SettlementReportForm_Load(object sender, EventArgs e)
        {
            settlementCategoryBindingSource.DataSource = db.SettlementCategories;
            SettlementCategorycomboBox.SelectedIndex = -1;
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            if (list.Count > 0)
            {
                SettlementReport settlementReport = new SettlementReport() { Result = list, From = Helper.GetPersianDate(fromDatePicker.SelectedDateTime.GetValueOrDefault()), End = Helper.GetPersianDate(toDatePicker.SelectedDateTime.GetValueOrDefault()) };
                settlementReport.ShowDialog();
            }

        }

        private void FillRecordNo()
        {
            //for (int i = 0; i < this.getSettlementReportResultDataGridView.Rows.Count; i++)
            //{
            //    this.getSettlementReportResultDataGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
            //}
        }

        private void getSettlementReportResultDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.FillRecordNo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list.Clear();
            if (fromDatePicker.SelectedDateTime != null && toDatePicker.SelectedDateTime != null && SettlementCategorycomboBox.SelectedIndex == -1)
            {

                list = db.GetSettlementReport(fromDatePicker.SelectedDateTime.Value.Date, toDatePicker.SelectedDateTime.Value.Date, null, null, null, null).ToList();

            }


            list.Add(new GetSettlementReportResult()
            {
                price = list.Sum(p => p.price)
            });

            getSettlementReportResultBindingSource.DataSource = list;
        }
    }
}
