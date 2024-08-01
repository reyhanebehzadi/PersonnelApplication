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
namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class BaseInformationDepartmentVersionForm : Jamsaz.Common.BasePersianForm
    {
        public BaseInformationDepartmentVersionForm()
        {
            InitializeComponent();
        }
        Jamsaz.PersonnlsApplication.BusinessObjects.Data.DepartmentVersion departmentVersion = new Jamsaz.PersonnlsApplication.BusinessObjects.Data.DepartmentVersion();
        Jamsaz.PersonnlsApplication.BusinessObjects.Data.JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
        private void BaseInformationDepartmentVersionForm_Load(object sender, EventArgs e)
        {
            departmentVersionBindingSource.DataSource = db.DepartmentVersions;

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Jamsaz.PersonnlsApplication.UI.DialogForms.DepartmentVersionEditDialogForm departmentVersionEditDialogForm = new Jamsaz.PersonnlsApplication.UI.DialogForms.DepartmentVersionEditDialogForm(Jamsaz.PersonnlsApplication.Definitions.ActionForm.Insert);
            db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
            if (departmentVersionEditDialogForm.ShowDialog() == DialogResult.OK)
                departmentVersionBindingSource.DataSource = db.DepartmentVersions;

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (departmentVersionBindingSource.Current != null)
            {
                Jamsaz.PersonnlsApplication.UI.DialogForms.DepartmentVersionEditDialogForm departmentVersionEditDialogForm = new Jamsaz.PersonnlsApplication.UI.DialogForms.DepartmentVersionEditDialogForm(Jamsaz.PersonnlsApplication.Definitions.ActionForm.Edit);
                db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
                departmentVersionEditDialogForm.selectDepartmentVersion = (DepartmentVersion)departmentVersionBindingSource.Current;
                
                if (departmentVersionEditDialogForm.ShowDialog() == DialogResult.OK)
                    departmentVersionBindingSource.DataSource = db.DepartmentVersions;
            }
        }

        private void deletButton_Click(object sender, EventArgs e)
        {
            if (departmentVersionBindingSource.Current != null)
            {
                if (Helper.Confirm("آیا مایل به حذف رکورد جاری می باشد"))
                {
                   
                    DepartmentVersion activeDepartmentVersion = db.DepartmentVersions.Single(c => c.IsActive == true);
                    DepartmentVersion currentDepartmentVersion= (DepartmentVersion)departmentVersionBindingSource.Current;
                    if (activeDepartmentVersion.IsActive == true && activeDepartmentVersion.ID == currentDepartmentVersion.ID)
                    {
                        Helper.ShowMessage("این آیتم نسخه فعال در سیستم می باشد لطفا بعد از فعال کردن نسخه دیگر اقدام به حذف آن نمایید");
                        return;
                    }

                    if (db.Departments.Count(c => c.DepartmentVersionID == currentDepartmentVersion.ID) <= 1)
                    {
                        departmentVersionBindingSource.RemoveCurrent();
                        db.SubmitChanges();
                        Helper.ShowMessage("عمل حذف با موفقیت انجام شد");
                    }
                    else Helper.ShowMessage("این نسخه غیر قابل حذف می باشد");

                }
            }
        }
       
    }
}
