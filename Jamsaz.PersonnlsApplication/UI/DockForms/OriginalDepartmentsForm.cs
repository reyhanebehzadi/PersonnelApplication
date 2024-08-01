using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Windows.Forms;
using Jamsaz.PersonnlsApplication.UI.DialogForms;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.PersonnlsApplication.BusinessObjects.Definitions;
using Jamsaz.Common;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class OriginalDepartmentsForm : BasePersianForm
    {
        public OriginalDepartmentsForm()
        {
            InitializeComponent();
        }

        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext(Jamsaz.PersonnlsApplication.Properties.Settings.Default.JamsazERPLiteConnectionString);

        private void OriginalDepartmentsForm_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddOriginalDepartmentDialogForm addOriginalDepartmentDialogForm = new AddOriginalDepartmentDialogForm() { FormStatus = FormStatus.Add, db = db };
            if (addOriginalDepartmentDialogForm.ShowDialog() == DialogResult.OK)
            {
                this.LoadData();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            OriginalDepartment originalDepartment = (OriginalDepartment)this.originalDepartmentBindingSource.Current;
            if (originalDepartment == null)
                return;

            AddOriginalDepartmentDialogForm addOriginalDepartmentDialogForm = new AddOriginalDepartmentDialogForm() { FormStatus = FormStatus.Edit, OriginalDepartment = originalDepartment, db = db };
            if (addOriginalDepartmentDialogForm.ShowDialog() == DialogResult.OK)
            {
                db.Refresh(RefreshMode.OverwriteCurrentValues, originalDepartment);
                this.dataGridView.Refresh();
            }
        }

        private void LoadData()
        {
            try
            {
                db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
                this.originalDepartmentBindingSource.DataSource = db.OriginalDepartments;
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(string.Format("{0}{1}{2}"
                                                            , "بروز خطا"
                                                            , "\n"
                                                            , ex.Message));
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            OriginalDepartment Current = (OriginalDepartment)originalDepartmentBindingSource.Current;
            if (Current!=null)
            {
                if (Helper.Confirm("آیا مایل به حذف اطلاعات هستید؟"))
                {
                    if (db.Departments.Any(c=>c.OriginalDepartmentID==Current.ID))
                    {
                        Helper.ShowMessage("امکان حذف وجود ندارد");
                        return;
                    }
                    db.OriginalDepartments.DeleteOnSubmit(Current);
                    db.SubmitChanges();
                    db = new JamsazERPLiteDataClassesDataContext();
                    originalDepartmentBindingSource.DataSource = db.OriginalDepartments.ToList();
                    dataGridView.Refresh();
                }
            }

        }
    }
}
