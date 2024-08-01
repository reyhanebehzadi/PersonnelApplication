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

namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class LeaveRequestDetailApprovalProcessDialogForm : BasePersianForm
    {
        public LeaveRequestsReportResult Current { get; set; }
        public JamsazERPLiteDataClassesDataContext db { get; set; }
        public LeaveRequestDetailApprovalProcessDialogForm()
        {
            InitializeComponent();
        }

        private void LeaveRequestDetailApprovalProcessDialogForm_Load(object sender, EventArgs e)
        {
            getLeaveRequestStatusResultBindingSource.DataSource = db.GetLeaveRequestStatus(Current.ID);
        }
    }
}
