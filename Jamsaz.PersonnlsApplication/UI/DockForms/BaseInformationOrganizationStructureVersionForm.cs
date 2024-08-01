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
    public partial class BaseInformationOrganizationStructureVersionForm : Jamsaz.Common.BasePersianForm
    {
        public BaseInformationOrganizationStructureVersionForm()
        {
            InitializeComponent();
        }
        Jamsaz.PersonnlsApplication.BusinessObjects.Data.OrganizationStructureVersion organizationStructureVersion = new Jamsaz.PersonnlsApplication.BusinessObjects.Data.OrganizationStructureVersion();
        Jamsaz.PersonnlsApplication.BusinessObjects.Data.JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
        private void BaseInformationDepartmentVersionForm_Load(object sender, EventArgs e)
        {
            organizationStructureVersionBindingSource.DataSource = db.OrganizationStructureVersions;

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Jamsaz.PersonnlsApplication.UI.DialogForms.EditOrganizationStructureVersionDialogForm editOrganizationStructureVersionDialogForm = new Jamsaz.PersonnlsApplication.UI.DialogForms.EditOrganizationStructureVersionDialogForm(Jamsaz.PersonnlsApplication.Definitions.ActionForm.Insert);
            db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
            if (editOrganizationStructureVersionDialogForm.ShowDialog() == DialogResult.OK)
                organizationStructureVersionBindingSource.DataSource = db.OrganizationStructureVersions;

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (organizationStructureVersionBindingSource.Current != null)
            {
                Jamsaz.PersonnlsApplication.UI.DialogForms.EditOrganizationStructureVersionDialogForm editOrganizationStructureVersionDialogForm = new Jamsaz.PersonnlsApplication.UI.DialogForms.EditOrganizationStructureVersionDialogForm(Jamsaz.PersonnlsApplication.Definitions.ActionForm.Edit);
                db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
                editOrganizationStructureVersionDialogForm.selectOrganizationStructureVersion = (OrganizationStructureVersion)organizationStructureVersionBindingSource.Current;

                if (editOrganizationStructureVersionDialogForm.ShowDialog() == DialogResult.OK)
                    organizationStructureVersionBindingSource.DataSource = db.OrganizationStructureVersions;
            }
        }

        private void deletButton_Click(object sender, EventArgs e)
        {
            if (organizationStructureVersionBindingSource.Current != null)
            {
                if (Helper.Confirm("آیا مایل به حذف رکورد جاری می باشد"))
                {

                    OrganizationStructureVersion activeOrganizationStructureVersion = db.OrganizationStructureVersions.Single(c => c.IsActive == true);
                    OrganizationStructureVersion currentactiveOrganizationStructureVersion = (OrganizationStructureVersion)organizationStructureVersionBindingSource.Current;
                    if (activeOrganizationStructureVersion.IsActive == true && activeOrganizationStructureVersion.ID == currentactiveOrganizationStructureVersion.ID)
                    {
                        Helper.ShowMessage("این آیتم نسخه فعال در سیستم می باشد لطفا بعد از فعال کردن نسخه دیگر اقدام به حذف آن نمایید");
                        return;
                    }

                    if (db.OrganizationStructures.Count(c => c.OrganizationStructureVersionID == currentactiveOrganizationStructureVersion.ID) <= 1)
                    {
                        organizationStructureVersionBindingSource.RemoveCurrent();
                        db.SubmitChanges();
                        Helper.ShowMessage("عمل حذف با موفقیت انجام شد");
                    }
                    else Helper.ShowMessage("این نسخه غیر قابل حذف می باشد");

                }
            }
        }
       
    }
}
