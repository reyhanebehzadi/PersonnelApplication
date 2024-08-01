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
namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class AllPersonnelListDialogForm : BasePersianForm
    {
        public AllPersonnelListDialogForm()
        {
            InitializeComponent();
        }
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        bool flag = false;
        public int FiscalYearID { get; set; }
        private void AllPersonnelListDialogForm_Load(object sender, EventArgs e)
        {
            
            personnelBindingSource.DataSource = db.Personnels.Except(db.EidRegistrations.Where(d => d.FiscalYearID == FiscalYearID).Select(o => o.Personnel));
        }

        public List<Personnel> SelectedPersonnels { get; set; }
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (allRadioButton.Checked && !string.IsNullOrEmpty( familyTextBox.Text) )
            
                personnelBindingSource.DataSource = db.Personnels.Where(c => (c.LastName.Contains(familyTextBox.Text) || c.FirstName.Contains(familyTextBox.Text) || c.PersonnelNumber == familyTextBox.Text)).Except(db.EidRegistrations.Where(d=>d.FiscalYearID== FiscalYearID).Select(o=>o.Personnel)).OrderBy(d=>Convert.ToInt32(d.PersonnelNumber));
            else
                if (allRadioButton.Checked && string.IsNullOrEmpty(familyTextBox.Text))
           
                personnelBindingSource.DataSource = db.Personnels.Except(db.EidRegistrations.Where(d => d.FiscalYearID == FiscalYearID).Select(o => o.Personnel)).OrderBy(d => Convert.ToInt32(d.PersonnelNumber));
            else
                if (activeRadioButton.Checked && !string.IsNullOrEmpty(familyTextBox.Text))
            
                personnelBindingSource.DataSource = db.Personnels.Where(c => c.IsActive == true && (c.LastName.Contains(familyTextBox.Text) || c.FirstName.Contains(familyTextBox.Text) || c.PersonnelNumber == familyTextBox.Text)).Except(db.EidRegistrations.Where(d => d.FiscalYearID == FiscalYearID).Select(o => o.Personnel)).OrderBy(d => Convert.ToInt32(d.PersonnelNumber));
            else
                 if (activeRadioButton.Checked && string.IsNullOrEmpty(familyTextBox.Text))
            
                personnelBindingSource.DataSource = db.Personnels.Where(c => c.IsActive == true).Except(db.EidRegistrations.Where(d => d.FiscalYearID == FiscalYearID).Select(o => o.Personnel)).OrderBy(d => Convert.ToInt32(d.PersonnelNumber));

            else
                if (inactiveRadioButton.Checked && !string.IsNullOrEmpty(familyTextBox.Text))

                personnelBindingSource.DataSource = db.Personnels.Where(c => c.IsActive == false && (c.LastName.Contains(familyTextBox.Text) || c.FirstName.Contains(familyTextBox.Text) || c.PersonnelNumber == familyTextBox.Text)).Except(db.EidRegistrations.Where(d => d.FiscalYearID == FiscalYearID).Select(o => o.Personnel)).OrderBy(d => Convert.ToInt32(d.PersonnelNumber));
            else
                 if (inactiveRadioButton.Checked && string.IsNullOrEmpty(familyTextBox.Text))

                personnelBindingSource.DataSource = db.Personnels.Where(c => c.IsActive == false).Except(db.EidRegistrations.Where(d => d.FiscalYearID == FiscalYearID).Select(o => o.Personnel)).OrderBy(d => Convert.ToInt32(d.PersonnelNumber));

        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (Helper.Confirm("آیا مایل به اضافه کردن اطلاعات هستید؟"))
            {
                SelectedPersonnels = new List<Personnel>();
                foreach (Personnel item in personnelBindingSource.List)
                {
                    if (item.IsSelect == true)
                    {
                        SelectedPersonnels.Add(item);
                    }
                }
                DialogResult = DialogResult.OK;
            }
            
            
        }

        private void voidButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void personnelDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.ColumnIndex == 0 && !flag)
            {
                foreach (Personnel  item in personnelBindingSource.List)
                {
                    item.IsSelect = true;
                    
                }
                flag = true;
            }
            else
                if (e.ColumnIndex == 0 && flag)
            {
                foreach (Personnel item in personnelBindingSource.List)
                {
                    item.IsSelect = false;
                }
                flag = false;
            }

            personnelBindingSource.ResetBindings(true);
           
        }

        private void personnelDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            (sender as DataGridView).Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
        }
    }
}
