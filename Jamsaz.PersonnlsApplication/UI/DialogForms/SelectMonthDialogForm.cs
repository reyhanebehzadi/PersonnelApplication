using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;

namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class SelectMonthDialogForm : Form
    {
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        public string Year { get; set; }
        public string Month { get; set; }

        public SelectMonthDialogForm()
        {
            InitializeComponent();
        }

        private void SelectMonthDialogForm_Load(object sender, EventArgs e)
        {
            foreach (var fiscalYear in db.FiscalYears.OrderByDescending(c => c.Title))
            {
                yearComboBox.Items.Add(fiscalYear.Title);
            }

            yearComboBox.SelectedIndex = 0;

            PersianCalendar calendar = new PersianCalendar();

            monthComboBox.SelectedIndex = calendar.GetMonth(DateTime.Today) - 1;

            Year = yearComboBox.Text;

            Month = monthComboBox.Text;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Year = yearComboBox.Text;

            Month = monthComboBox.Text;

            this.DialogResult = DialogResult.OK;
        }
    }
}
