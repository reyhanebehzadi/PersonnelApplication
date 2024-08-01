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
namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    public partial class ComprehensivePersonnelReportForm : BasePersianForm
    {
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        public ComprehensivePersonnelReportForm()
        {
            InitializeComponent();
        }

        private void ComprehensivePersonnelReportForm_Load(object sender, EventArgs e)
        {
            //dataBindingSource.DataSource = db.GetComprehensivePersonnelReport();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //ExportToExcel<OperationDetail>.Export(OperationDetailList);

            // creating Excel Application
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();


            // creating new WorkBook within Excel application
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);


            // creating new Excelsheet in workbook
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            // see the excel sheet behind the program
            app.Visible = true;

            // get the reference of first sheet. By default its name is Sheet1.
            // store its reference to worksheet
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;

            // changing the name of active sheet
            worksheet.Name = "Exported from gridview";


            // storing header part in Excel
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }

            // storing Each row and column value to excel sheet
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (contractEndDatePicker.SelectedDateTime != null && contractStartDatePicker.SelectedDateTime != null)

                dataBindingSource.DataSource = db.GetComprehensivePersonnelReport().Where(p => p.WorkStartDate >= contractStartDatePicker.SelectedDateTime && p.WorkStartDate <= contractEndDatePicker.SelectedDateTime);
            else
                dataBindingSource.DataSource = db.GetComprehensivePersonnelReport();
        }
    }
}
