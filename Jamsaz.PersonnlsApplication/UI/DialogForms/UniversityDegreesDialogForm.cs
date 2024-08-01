using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Linq;

using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.Common;

namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class UniversityDegreesDialogForm : Form
    {

        private int? Selected;

        public UniversityDegreesDialogForm()
        {
            InitializeComponent();
        }

        JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
        List<UniversityDegree> universityDegreeNames = new List<UniversityDegree>();
        private void universityDegreesDialogForm_Load(object sender, EventArgs e)
        {
            try
            {
                universityDegreeNames = db.UniversityDegrees.ToList();
                universityDegreesBindingSource.DataSource = universityDegreeNames;
                
            }
            catch (Exception exp)
            {
                if (exp.GetType() == typeof(System.Data.SqlClient.SqlException))
                   Helper.ShowMessage("خطا در ارتباط با بانک اطلاعاتی", " اتصال به بانک اطلاعاتی برقرار نیست " + "\n لطفا مشکل را به مسئول شبکه گزارش دهید\n ");
                else
                    Helper.ShowMessage(exp.Message);
            }
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            SelectedRow();
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public UniversityDegree SelectedUniversityDegree { get; set; }


        private void universityDegreesDataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 24)
                this.Close();

            if (e.KeyChar == 10)
            {
                SelectedRow();
            }
        }

        

        private void txtFilterName_TextChanged(object sender, EventArgs e)
        {
            universityDegreesBindingSource.DataSource = universityDegreeNames.Where(c => c.Name.Contains(filterNameTextBox.Text));
        }
        private void SelectedRow()
        {
            try
            {
                if (!paasNullCheckBox.Checked && universityDegreesBindingSource.Current !=null)
                {
                    this.SelectedUniversityDegree = (UniversityDegree)universityDegreesBindingSource.Current; 
                }
                else
                {
                    this.SelectedUniversityDegree = null;
                }
                this.DialogResult = DialogResult.OK;
            }
            catch { }
        }

        private void universityDegreesDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectedRow();
        }
     
    }
}