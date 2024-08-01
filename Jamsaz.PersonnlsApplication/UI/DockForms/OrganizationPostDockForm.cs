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
using Jamsaz.PersonnlsApplication.BusinessObjects.Definitions;
using Jamsaz.PersonnlsApplication.UI.DialogForms;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class OrganizationPostDockForm : BasePersianForm
    {
        public OrganizationPostDockForm()
        {
            InitializeComponent();
        }
        private JamsazERPLiteDataClassesDataContext db;

        private void OrganizationPostDockForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            db = new JamsazERPLiteDataClassesDataContext();
            organizationPostBindingSource.DataSource = db.OrganizationPosts;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddOrganizationPostDialogForm addOrganizationPostDialogForm = new AddOrganizationPostDialogForm()
            {
                FormStatus = FormStatus.Add
            };
            if (addOrganizationPostDialogForm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            OrganizationPost current = (OrganizationPost)organizationPostBindingSource.Current;
            if (current != null)
            {
                AddOrganizationPostDialogForm addOrganizationPostDialogForm = new AddOrganizationPostDialogForm()
                {
                    FormStatus = FormStatus.Edit,
                    OrganizationPost = current
                };
                if (addOrganizationPostDialogForm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                OrganizationPost current = (OrganizationPost)organizationPostBindingSource.Current;
                if (current != null)
                    if (Helper.Confirm("آیا مایل به حذف اطلاعات هستید؟"))
                    {
                        db.OrganizationPosts.DeleteOnSubmit(current);
                        db.SubmitChanges();
                        LoadData();
                    }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                Helper.ShowMessage("امکان حذف وجود ندارد");
            }
        }
    }
}
