using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.Common;

namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class PersonnelListDialogForm : BasePersianForm
    {
        public int OrginalDepartmentID { get; internal set; }

        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();

        public List<SelectChildDepartmentsPersonnelResult> SelectdPersonnels = new List<SelectChildDepartmentsPersonnelResult>();

        public PersonnelListDialogForm()
        {
            InitializeComponent();
        }

        private void PersonnelListDialogForm_Load(object sender, EventArgs e)
        {
            selectChildDepartmentsPersonnelResultBindingSource.DataSource = db.SelectChildDepartmentsPersonnel(OrginalDepartmentID);
        }

        private void selectAllCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (selectAllCheckBox.Checked)
            {
                foreach (SelectChildDepartmentsPersonnelResult result in selectChildDepartmentsPersonnelResultBindingSource.List)
                    result.IsSelected = true;

                selectChildDepartmentsPersonnelResultDataGridView.Refresh();
            }
            else
            {
                foreach (SelectChildDepartmentsPersonnelResult result in selectChildDepartmentsPersonnelResultBindingSource.List)
                    result.IsSelected = false;

                selectChildDepartmentsPersonnelResultDataGridView.Refresh();
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            selectChildDepartmentsPersonnelResultDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);

            //SelectdPersonnels = ((IList<SelectChildDepartmentsPersonnelResult>)selectChildDepartmentsPersonnelResultBindingSource.DataSource).Where(c => c.IsSelected == true).ToList();
            foreach (SelectChildDepartmentsPersonnelResult result in selectChildDepartmentsPersonnelResultBindingSource.List)
                if (result.IsSelected == true)
                    SelectdPersonnels.Add(result);


            if (SelectdPersonnels.Count > 0)
                DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
