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
using Jamsaz.PersonnlsApplication.BusinessObjects.Definitions;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class AddApprovalGroupDialogForm : BasePersianForm
    {
        public AddApprovalGroupDialogForm()
        {
            InitializeComponent();
        }
        public ApprovalGroup ApprovalGroup { get; set; }
        public FormStatus FormStatus { get; set; }
        private JamsazERPLiteDataClassesDataContext db=new JamsazERPLiteDataClassesDataContext();

        private void AddApprovalGroupDialogForm_Load(object sender, EventArgs e)
        {
            if (FormStatus == FormStatus.Add)
            {
                ApprovalGroup = new ApprovalGroup();
                if (db.ApprovalGroups.Count() > 0)
                    ApprovalGroup.Code = db.ApprovalGroups.Max(c => c.Code) + 1;
                else
                    ApprovalGroup.Code = 1;
            }
            else
            {
                ApprovalGroup = db.ApprovalGroups.SingleOrDefault(c => c.ID == ApprovalGroup.ID);
            }
            approvalGroupBindingSource.DataSource = ApprovalGroup;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (Helper.Confirm("آیا مایل به ثبت اطلاعات هستید؟"))
            {
                if (FormStatus == FormStatus.Add)
                {
                    db.ApprovalGroups.InsertOnSubmit(ApprovalGroup);
                }
                db.SubmitChanges();
               
            }

            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


    }
}
