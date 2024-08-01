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
    public partial class AddMissionApprovalGroupDialogForm : BasePersianForm
    {

        public MissionApprovalGroup MissionApprovalGroup { get; set; }
        public FormStatus FormStatus { get; set; }
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        public AddMissionApprovalGroupDialogForm()
        {
            InitializeComponent();
        }

        private void AddMissionApprovalGroupDialogForm_Load(object sender, EventArgs e)
        {

            if (FormStatus == FormStatus.Add)
            {
                MissionApprovalGroup = new MissionApprovalGroup();
                if (db.MissionApprovalGroups.Count() > 0)
                    MissionApprovalGroup.Code = db.MissionApprovalGroups.Max(c => c.Code) + 1;
                else
                    MissionApprovalGroup.Code = 1;
            }
            else
            {
                MissionApprovalGroup = db.MissionApprovalGroups.SingleOrDefault(c => c.ID == MissionApprovalGroup.ID);
            }
            missionApprovalGroupBindingSource.DataSource = MissionApprovalGroup;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (Helper.Confirm("آیا مایل به ثبت اطلاعات هستید؟"))
            {
                if (FormStatus == FormStatus.Add)
                {
                    db.MissionApprovalGroups.InsertOnSubmit(MissionApprovalGroup);
                }
                db.SubmitChanges();

            }

            DialogResult = DialogResult.OK;
        }
    }
}
