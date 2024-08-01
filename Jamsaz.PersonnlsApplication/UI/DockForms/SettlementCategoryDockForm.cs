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
using Jamsaz.PersonnlsApplication.BusinessObjects.Definitions;
using Jamsaz.PersonnlsApplication.UI.DialogForms;
namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class SettlementCategoryDockForm : BasePersianForm
    {
        public SettlementCategoryDockForm()
        {
            InitializeComponent();
        }
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        private void addButton_Click(object sender, EventArgs e)
        {
            AddSettlementCategoryDialogForm AddSettlementCategoryDialogForm = new AddSettlementCategoryDialogForm() { FormStatus = FormStatus.Add };
            if (AddSettlementCategoryDialogForm.ShowDialog() == DialogResult.OK)
            {
                db = new JamsazERPLiteDataClassesDataContext();
                settlementCategoryBindingSource.DataSource = db.SettlementCategories.ToList();
                settlementCategoryDataGridView.Refresh();
            }
        }

        private void SettlementCategoryDockForm_Load(object sender, EventArgs e)
        {
            settlementCategoryBindingSource.DataSource = db.SettlementCategories.ToList();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            SettlementCategory current = (SettlementCategory)settlementCategoryBindingSource.Current;
            if (current != null)
            {
                AddSettlementCategoryDialogForm AddSettlementCategoryDialogForm = new AddSettlementCategoryDialogForm()
                {
                    FormStatus = FormStatus.Edit,
                    SettlementCategory = current
                };
                if (AddSettlementCategoryDialogForm.ShowDialog() == DialogResult.OK)
                {
                    db = new JamsazERPLiteDataClassesDataContext();
                    settlementCategoryBindingSource.DataSource = db.SettlementCategories.ToList();
                    settlementCategoryDataGridView.Refresh();
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            SettlementCategory current = (SettlementCategory)settlementCategoryBindingSource.Current;
            if (current != null)
            {

                if (Helper.Confirm("آیا مایل به حذف اطلاعات هستید؟"))
                {
                    db.SettlementCategories.DeleteOnSubmit(current);
                    db.SubmitChanges();
                    db = new JamsazERPLiteDataClassesDataContext();
                    settlementCategoryBindingSource.DataSource = db.SettlementCategories.ToList();
                    settlementCategoryDataGridView.Refresh();
                }
            }
        }
    }
}
