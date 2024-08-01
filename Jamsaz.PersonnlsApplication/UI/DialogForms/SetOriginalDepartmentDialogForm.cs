using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jamsaz.PersonnlsApplication.BusinessObjects.Definitions;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.Common;

namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class SetOriginalDepartmentDialogForm : BasePersianForm
    {
        public SetOriginalDepartmentDialogForm()
        {
            InitializeComponent();
        }

        public JamsazERPLiteDataClassesDataContext db { get; set; }
        public Department Department { get; set; }
        public int CurrentDepartmentVersionID { get; set; }

        private void SetOriginalDepartmentDialogForm_Load(object sender, EventArgs e)
        {
            this.SetData();
        }

        private void selectOriginalDepartmentButton_Click(object sender, EventArgs e)
        {
            OriginalDepartmentListDialogForm originalDepartmentListDialogForm = new OriginalDepartmentListDialogForm() { db = db, CurrentDepartmentVersionID = this.CurrentDepartmentVersionID };
            if (originalDepartmentListDialogForm.ShowDialog() == DialogResult.OK)
            {
                this.Department.OriginalDepartment = originalDepartmentListDialogForm.SelectOriginalDepartment;
                originalDepartmentListDialogForm.SelectOriginalDepartment.LatestName = this.Department.Name;
            }
        }

        private void voidButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Helper.Confirm("آیا مایل به ذخیره کردن اطلاعات هستید؟") == false)
                return;

            try
            {
                db.SubmitChanges();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(string.Format("{0}{1}{2}"
                                                            , "بروز خطا"
                                                            , "\n"
                                                            , ex.Message));
            }
        }

        private void SetData()
        {
            try
            {
                this.departmentBindingSource.DataSource = this.Department;
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
