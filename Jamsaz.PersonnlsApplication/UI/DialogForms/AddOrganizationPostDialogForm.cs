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
namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class AddOrganizationPostDialogForm : BasePersianForm
    {
        public AddOrganizationPostDialogForm()
        {
            InitializeComponent();
        }
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        public OrganizationPost OrganizationPost { get; set; }
        public FormStatus FormStatus { get; set; }

        private void AddOrganizationPostDialogForm_Load(object sender, EventArgs e)
        {
            if (FormStatus==FormStatus.Add)
            {
                int? code = db.OrganizationPosts.Count() > 0 ? db.OrganizationPosts.Max(c => c.Code):0;
                OrganizationPost = new OrganizationPost()
                {
                    Code=code+1
                };
            }
            else
            {
                OrganizationPost = db.OrganizationPosts.SingleOrDefault(c => c.ID == OrganizationPost.ID);
            }

            organizationPostBindingSource.DataSource = OrganizationPost;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (FormStatus==FormStatus.Add)
            
                db.OrganizationPosts.InsertOnSubmit(OrganizationPost);
            
            db.SubmitChanges();
            DialogResult = DialogResult.OK;
        }
    }
}
