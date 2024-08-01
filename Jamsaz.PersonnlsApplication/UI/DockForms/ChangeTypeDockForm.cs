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
    public partial class ChangeTypeDockForm : BasePersianForm
    {
        public ChangeTypeDockForm()
        {
            InitializeComponent();
        }
        private JamsazERPLiteDataClassesDataContext db;
        private void ChangeTypeDockForm_Load(object sender, EventArgs e)
        {
            LoadDate();
        }
        private void LoadDate()
        {
            db = new JamsazERPLiteDataClassesDataContext();
            changeTypeBindingSource.DataSource = db.ChangeTypes;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddChangeTypeDialogForm addChangeTypeDialogForm = new AddChangeTypeDialogForm() { FormStatus=FormStatus.Add};
            if (addChangeTypeDialogForm.ShowDialog()==DialogResult.OK)
            {
                LoadDate();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (!(changeTypeBindingSource.Current is ChangeType current)) return;
            
            AddChangeTypeDialogForm addChangeTypeDialogForm = new AddChangeTypeDialogForm() { FormStatus = FormStatus.Edit,Selected=current };
            if (addChangeTypeDialogForm.ShowDialog() == DialogResult.OK)
            {
                LoadDate();
            }
        }
    }
}
