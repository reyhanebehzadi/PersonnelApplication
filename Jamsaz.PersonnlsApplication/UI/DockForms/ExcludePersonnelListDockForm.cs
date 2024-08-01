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
using Jamsaz.PersonnlsApplication.UI.DialogForms;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class ExcludePersonnelListDockForm : BasePersianForm
    {
        public ExcludePersonnelListDockForm()
        {
            InitializeComponent();
        }

        private JamsazERPLiteDataClassesDataContext db;

        private void LoadData()
        {
            db = new JamsazERPLiteDataClassesDataContext();
            excludePersonnelBindingSource.DataSource = db.ExcludePersonnels;
        }

        private void ExcludePersonnelListDockForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            PersonnelListForm listForm = new PersonnelListForm(db);

            if (listForm.ShowDialog() == DialogResult.OK)
            {
                if (db.ExcludePersonnels.Any(c => c.PersonnelID == listForm.Personnel.Id))
                    return;

                ExcludePersonnel excludePersonnel = new ExcludePersonnel()
                {
                    Personnel = db.Personnels.SingleOrDefault(c => c.Id == listForm.Personnel.Id)
                };

                db.ExcludePersonnels.InsertOnSubmit(excludePersonnel);
                db.SubmitChanges();

                LoadData();

            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            ExcludePersonnel excludePersonnel = (ExcludePersonnel) excludePersonnelBindingSource.Current;

            if (excludePersonnel != null)
            {
                if (Helper.Confirm("آیا مایل به حذف پرسنل جاری هستید؟"))
                {
                    db.ExcludePersonnels.DeleteOnSubmit(excludePersonnel);
                    db.SubmitChanges();
                    LoadData();
                }
            }
        }

       
    }
}