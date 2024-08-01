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
using Jamsaz.PersonnlsApplication.UI.DialogForms;
using Jamsaz.PersonnlsApplication.BusinessObjects.Definitions;
namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class AccidentsDockForm : BasePersianForm

    {
        public AccidentsDockForm()
        {
            InitializeComponent();
        }
        private JamsazERPLiteDataClassesDataContext db;
        private void addButton_Click(object sender, EventArgs e)
        {
            AddAccidentDialogForm addAccidentDialogForm = new AddAccidentDialogForm() { FormStatus=FormStatus.Add};
            if (addAccidentDialogForm.ShowDialog()==DialogResult.OK)
            {
                LoadData();
            }
        }

        private void AccidentsDockForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            db = new JamsazERPLiteDataClassesDataContext();
            accidentBindingSource.DataSource = db.Accidents.Where(c=>c.FiscalYearID==User.FiscalYearID);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (!(accidentBindingSource.Current is Accident current)) return;

            AddAccidentDialogForm addAccidentDialogForm = new AddAccidentDialogForm() { FormStatus = FormStatus.Edit,Accident=current };
            if (addAccidentDialogForm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (!(accidentBindingSource.Current is Accident current)) return;
            if (Helper.Confirm("آیا مایل به حذف می باشید؟"))
            {
                db.Accidents.DeleteOnSubmit(current);
                db.SubmitChanges();
                LoadData();
            }
        }
    }
}
