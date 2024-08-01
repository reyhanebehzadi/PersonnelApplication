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
    public partial class EditOrganizationStructureVersionDialogForm : Jamsaz.Common.BasePersianForm
    {
        Jamsaz.PersonnlsApplication.Definitions.ActionForm actionForm = new Jamsaz.PersonnlsApplication.Definitions.ActionForm();


        public EditOrganizationStructureVersionDialogForm(ActionForm actionForm)
        {
            InitializeComponent();
            this.actionForm = actionForm;
        }
        public OrganizationStructureVersion selectOrganizationStructureVersion { get; set; }

        Jamsaz.PersonnlsApplication.BusinessObjects.Data.JamsazERPLiteDataClassesDataContext db = new Jamsaz.PersonnlsApplication.BusinessObjects.Data.JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);

        private void departmentVersionEditDialogForm_Load(object sender, EventArgs e)
        {

            if (this.actionForm == ActionForm.Edit)
            {
                organizationStructureVersionBindingSource.DataSource = db.OrganizationStructureVersions.Single(c => c.ID == selectOrganizationStructureVersion.ID);
            }
            else
            {
                this.selectOrganizationStructureVersion = (OrganizationStructureVersion)organizationStructureVersionBindingSource.AddNew();

                if (db.OrganizationStructureVersions.Count() == 0)
                    codeTextBox.Text = "1";
                else
                    codeTextBox.Text = db.OrganizationStructureVersions.Max(c => c.Code + 1).ToString();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DateTime currentDateFromServer = db.ExecuteQuery<DateTime>("SELECT GETDATE()").First();
            OrganizationStructureVersion currentOrganizationStructureVersion = (OrganizationStructureVersion)organizationStructureVersionBindingSource.Current;
            organizationStructureVersionBindingSource.EndEdit();
            if (db.OrganizationStructureVersions.Count(c => c.IsActive == true) == 0 && currentOrganizationStructureVersion.IsActive == false)
            {
                Helper.ShowMessage("هیچ نسخه فعالی در سیستم وجود ندارد");
                return;
            }
            if (db.OrganizationStructureVersions.Count(c => c.IsActive == true) == 1 &&
                db.OrganizationStructureVersions.Single(c => c.IsActive == true).ID == currentOrganizationStructureVersion.ID &&
               currentOrganizationStructureVersion.IsActive == false)
            {
                Helper.ShowMessage("شما نمی توانید این نسخه را غیر فعال کنید چون نسخه دیگری در سیستم فعال نیست");
                return;
            }

            if (db.OrganizationStructureVersions.Count(c => c.IsActive == true) == 1 &&
                 db.OrganizationStructureVersions.Single(c => c.IsActive == true).ID != currentOrganizationStructureVersion.ID &&
                ((OrganizationStructureVersion)organizationStructureVersionBindingSource.Current).IsActive == true)
            {
                if (Helper.Confirm("یک نسخه فعال در سیستم موجود می باشد آیا می خواهید این نسخه را فعال کنید؟"))
                {
                    OrganizationStructureVersion tempOrganizationStructureVersion = new OrganizationStructureVersion();
                    tempOrganizationStructureVersion = db.OrganizationStructureVersions.Single(c => c.IsActive == true);
                    tempOrganizationStructureVersion.IsActive = false;
                }
            }



            if (actionForm == ActionForm.Insert)
            {
                OrganizationStructure OrganizationStructure = new OrganizationStructure();
                OrganizationStructure.Code = "0";
                OrganizationStructure.Name = "مدیر عامل";
                OrganizationStructure.NameEn = "jamsaz co ";
                OrganizationStructure.OrganizationStructureVersion = this.selectOrganizationStructureVersion;
                db.OrganizationStructures.InsertOnSubmit(OrganizationStructure);
                db.OrganizationStructureVersions.InsertOnSubmit(this.selectOrganizationStructureVersion);
            }
            

          
            
            organizationStructureVersionBindingSource.EndEdit();
            db.SubmitChanges();

            this.DialogResult = DialogResult.OK;
        }

       
    }
}
