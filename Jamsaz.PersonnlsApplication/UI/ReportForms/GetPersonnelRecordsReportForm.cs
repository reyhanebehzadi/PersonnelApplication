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
using Jamsaz.PersonnlsApplication.UI.DialogForms;

namespace Jamsaz.PersonnlsApplication.UI.ReportForms
{
    public partial class GetPersonnelRecordsReportForm : BasePersianForm
    {
        public GetPersonnelRecordsReportForm()
        {
            InitializeComponent();
        }
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        public Personnel personnel;
        int type = 0;
        List<GetPersonnelRecordsResult> List = new List<GetPersonnelRecordsResult>();
        private void selectButton_Click(object sender, EventArgs e)
        {
            PersonnelListForm personnelListForm = new PersonnelListForm(db) { IsActive = true };
            if (personnelListForm.ShowDialog() == DialogResult.OK)
            {
                personnel = new Personnel();
                if (personnelListForm.Personnel.Id > 0)
                    personnel = personnelListForm.Personnel;
                this.personelNumberTextBox.Text = personnelListForm.Personnel.PersonnelNumber;
                this.fullNameTextBox.Text = string.Format("{0} {1}", personnelListForm.Personnel.FirstName, personnelListForm.Personnel.LastName);
            }
        }

        private void GetPersonnelRecordsReportForm_Load(object sender, EventArgs e)
        {
            encouragementRadioButton.Checked = true;
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            if (encouragementRadioButton.Checked)
                type = 1;
            if (personnel != null)
                List = db.GetPersonnelRecords(personnel.Id, DatePicker.SelectedDateTime.Value.Date, toDatePicker.SelectedDateTime.Value.Date, type).ToList();
            else
                List = db.GetPersonnelRecords(null, DatePicker.SelectedDateTime.Value.Date, toDatePicker.SelectedDateTime.Value.Date, type).ToList();

            if (List.Count > 0)
            
                getPersonnelRecordsResultBindingSource.DataSource = List;
           else
                getPersonnelRecordsResultBindingSource.DataSource = null;

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            DatePicker.SelectedDateTime = toDatePicker.SelectedDateTime = null;
            personnel = null;
            this.personelNumberTextBox.Text = this.fullNameTextBox.Text = string.Empty;
            getPersonnelRecordsResultBindingSource.DataSource = null;
            encouragementRadioButton.Checked = true;
        }
    }
}
