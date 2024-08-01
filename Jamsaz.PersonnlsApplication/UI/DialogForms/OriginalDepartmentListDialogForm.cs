using System;
using System.Linq;
using System.Windows.Forms;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.Common;


namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class OriginalDepartmentListDialogForm : BasePersianForm
    {
        public OriginalDepartmentListDialogForm()
        {
            InitializeComponent();
        }

        public JamsazERPLiteDataClassesDataContext db { get; set; }
        public OriginalDepartment SelectOriginalDepartment { get; set; }
        public int CurrentDepartmentVersionID { get; set; }

        private void OriginalDepartmentListDialogForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                getOriginalDepartmentsResultBindingSource.DataSource = db.GetOriginalDepartments(CurrentDepartmentVersionID , departmentTextBox.Text.Trim());
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(string.Format("{0}{1}{2}"
                                                            , "بروز خطا"
                                                            , "\n"
                                                            , ex.Message));
            }
        }

        private void departmentTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                getOriginalDepartmentsResultBindingSource.DataSource = db.GetOriginalDepartments(CurrentDepartmentVersionID, departmentTextBox.Text.Trim());
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(string.Format("{0}{1}{2}"
                                                            , "بروز خطا"
                                                            , "\n"
                                                            , ex.Message));
            }
        }

        private void searchAllButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void voidButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            SelectRow();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectRow();
        }

        private void LoadData()
        {
            try
            {
                getOriginalDepartmentsResultBindingSource.DataSource = db.GetOriginalDepartments(this.CurrentDepartmentVersionID , null); 
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(string.Format("{0}{1}{2}"
                                                            , "بروز خطا"
                                                            , "\n"
                                                            , ex.Message));
            }
        }

        private void SelectRow()
        {
            try
            {
                if (getOriginalDepartmentsResultBindingSource.Current == null)
                    return;

                SelectOriginalDepartment = db.OriginalDepartments.Single(c => c.ID == ((GetOriginalDepartmentsResult)this.getOriginalDepartmentsResultBindingSource.Current).ID);
                DialogResult = DialogResult.OK;
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
