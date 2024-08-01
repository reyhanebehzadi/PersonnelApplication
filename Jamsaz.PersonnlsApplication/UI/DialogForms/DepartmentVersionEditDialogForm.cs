using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jamsaz.PersonnlsApplication.Definitions;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.Common;

namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class DepartmentVersionEditDialogForm : Jamsaz.Common.BasePersianForm
    {
        private ActionForm actionForm = new ActionForm();
        public DepartmentVersion selectDepartmentVersion { get; set; }
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);

        public DepartmentVersionEditDialogForm(ActionForm actionForm)
        {
            InitializeComponent();
            this.actionForm = actionForm;
        }

        private void departmentVersionEditDialogForm_Load(object sender, EventArgs e)
        {

            if (this.actionForm == ActionForm.Edit)
            {
                departmentVersionBindingSource.DataSource = db.DepartmentVersions.Single(c => c.ID == selectDepartmentVersion.ID);
            }
            else
            {
                this.IsActiveCheckBox.Enabled = false;
                this.selectDepartmentVersion = (DepartmentVersion)departmentVersionBindingSource.AddNew();

                if (db.DepartmentVersions.Count() == 0)
                    codeTextBox.Text = "1";
                else
                    codeTextBox.Text = db.DepartmentVersions.Max(c => c.Code + 1).ToString();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DateTime currentDateFromServer = db.ExecuteQuery<DateTime>("SELECT GETDATE()").First();
            DepartmentVersion currentDepartmentVersion = (DepartmentVersion)departmentVersionBindingSource.Current;
            departmentVersionBindingSource.EndEdit();
            if (db.DepartmentVersions.Count(c => c.IsActive == true) == 0 && currentDepartmentVersion.IsActive == false)
            {
                Helper.ShowMessage("هیچ نسخه فعالی در سیستم وجود ندارد");
                return;
            }
            if (db.DepartmentVersions.Count(c => c.IsActive == true) == 1 &&
                db.DepartmentVersions.Single(c => c.IsActive == true).ID == currentDepartmentVersion.ID &&
               currentDepartmentVersion.IsActive == false)
            {
                Helper.ShowMessage("شما نمی توانید این نسخه را غیر فعال کنید چون نسخه دیگری در سیستم فعال نیست");
                return;
            }

            if (db.DepartmentVersions.Count(c => c.IsActive == true) == 1 &&
                 db.DepartmentVersions.Single(c => c.IsActive == true).ID != currentDepartmentVersion.ID &&
                ((DepartmentVersion)departmentVersionBindingSource.Current).IsActive == true)
            {
                if (Helper.Confirm("یک نسخه فعال در سیستم موجود می باشد آیا می خواهید این نسخه را فعال کنید؟"))
                {
                    DepartmentVersion tempDepartment = new DepartmentVersion();
                    tempDepartment = db.DepartmentVersions.Single(c => c.IsActive == true);
                    tempDepartment.IsActive = false;
                }
            }

            if (this.actionForm == ActionForm.Edit && this.IsActiveCheckBox.Checked == true)
            {
                if ((db.Departments.Where(c => c.DepartmentVersionID == currentDepartmentVersion.ID && c.OriginalDepartment == null).Count() > 0) || db.Departments.Count(c => c.DepartmentVersionID == currentDepartmentVersion.ID) == 0)
                {
                    Helper.ShowMessage(string.Format("{0}{1}{2}", "مجاز به ثبت اطلاعات نمی باشید"
                                                                  , "\n"
                                                                  , "ابتدا ارتباط همه واحدهای نسخه جاری را با نسخه اصلی واحد ها مشخص کنید"));
                    return;
                }
            }

            if (actionForm == ActionForm.Insert)
            {
                //Department department = new Department();
                //department.Code = "0";
                //department.Name = "شرکت جمع ساز";
                //department.NameEn = "jamsaz co ";
                //department.DepartmentVersion = this.selectDepartmentVersion;
                //db.Departments.InsertOnSubmit(department);
                db.DepartmentVersions.InsertOnSubmit(this.selectDepartmentVersion);
            }

            db.SubmitChanges();
            departmentVersionBindingSource.EndEdit();

            db.SubmitChanges();
            this.DialogResult = DialogResult.OK;
        }


    }
}
