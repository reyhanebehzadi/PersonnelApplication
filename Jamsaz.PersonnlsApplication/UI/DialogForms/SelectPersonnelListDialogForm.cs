using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;

namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class SelectPersonnelListDialogForm : BasePersianForm
    {
        public SelectPersonnelListDialogForm()
        {
            InitializeComponent();
        }

        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        public Personnel Personnel { get; set; }
        public List<Personnel> Personnels = new List<Personnel>();
        public List<Personnel> AddedPersonnelList { get; set; }
        public int increaseAmount;
        private void SelectPersonnelListDialogForm_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (familyTextBox.Text != string.Empty)
                this.personnelBindingSource.DataSource = db.Personnels.Where(c => c.LastName.Contains(familyTextBox.Text) || c.FirstName.Contains(familyTextBox.Text) || c.PersonnelNumber == familyTextBox.Text && c.IsActive == true).OrderBy(d => Convert.ToInt32(d.PersonnelNumber));
            else
                this.LoadData();
        }

        private void LoadData()
        {
            //List<Personnel> personnels = db.Personnels.Where(c => c.IsActive == true).ToList().OrderBy(c => Convert.ToInt32(c.PersonnelNumber)).ToList();

            ////List<Personnel> newList = from item in personnels
            ////            where !AddedPersonnelList.Contains(item.Id)
            ////            select item;

            ////List<Personnel> newList = personnels.Where(t => !AddedPersonnelList.Contains(Personnel)).ToList();

            //List<Personnel> newList = personnels.Except(AddedPersonnelList).ToList();


            // EmployeeList.ExceptBy(Managerlist, x=>x.EmpId , y=>y.ManagerId));


            this.personnelBindingSource.DataSource = db.Personnels.Where(c => c.IsActive == true).ToList().OrderBy(c => Convert.ToInt32(c.PersonnelNumber)).ToList();

        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            foreach (Personnel personnel in personnelBindingSource.List)
            {
                if (personnel.IsSelect == true)
                {
                    Personnels.Add(personnel);
                }
            }
            if (!string.IsNullOrEmpty(increaseAmountTextBox.Text))
                increaseAmount = int.Parse(increaseAmountTextBox.Text);

            if (Personnels.Count != 0)
                this.DialogResult = DialogResult.OK;

        }

        private void voidButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void familyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (familyTextBox.Text != string.Empty)
                    this.personnelBindingSource.DataSource = db.Personnels.Where(c => c.LastName.Contains(familyTextBox.Text) || c.FirstName.Contains(familyTextBox.Text) || c.PersonnelNumber == familyTextBox.Text).OrderBy(d => Convert.ToInt32(d.PersonnelNumber));
                else
                    this.LoadData();
            }
        }

        private void selectAllCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (selectAllCheckBox.Checked == true)
            {
                foreach (Personnel personnel in personnelBindingSource.List)
                {
                    personnel.IsSelect = true;
                }
                personnelDataGridView.Refresh();

            }
            else
            {
                foreach (Personnel personnel in personnelBindingSource.List)
                {
                    personnel.IsSelect = false;
                }

                personnelDataGridView.Refresh();
            }
        }


    }
}
