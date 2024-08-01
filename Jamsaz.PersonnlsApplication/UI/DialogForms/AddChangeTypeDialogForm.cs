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
    public partial class AddChangeTypeDialogForm : BasePersianForm
    {
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        public ChangeType Selected { get; set; }
        public FormStatus FormStatus { get; set; }
        public AddChangeTypeDialogForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Helper.Confirm("آیا مایل به ثبت اطلاعات هستید؟"))
                if (FormStatus == FormStatus.Add)
                
                    db.ChangeTypes.InsertOnSubmit(Selected);
            db.SubmitChanges();
            DialogResult = DialogResult.OK;
        }

        private void AddChangeTypeDialogForm_Load(object sender, EventArgs e)
        {
            if (FormStatus == FormStatus.Add)
            {
                Selected = new ChangeType()
                {
                    Code = db.ChangeTypes.Any() ? db.ChangeTypes.Max(c => c.Code) + 1 : 1
                };

            }
            else
                Selected = db.ChangeTypes.SingleOrDefault(c => c.ID == Selected.ID);

            changeTypeBindingSource.DataSource = Selected;
        }
    }
}
