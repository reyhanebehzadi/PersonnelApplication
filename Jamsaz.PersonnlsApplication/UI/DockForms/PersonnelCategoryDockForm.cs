using System;
using System.Linq;
using System.Windows.Forms;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.PersonnlsApplication.BusinessObjects.Definitions;
using Jamsaz.PersonnlsApplication.BusinessObjects.Resources;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class PersonnelCategoryDockForm : BasePersianForm
    {
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        private bool isLoaded;

        public PersonnelCategoryDockForm()
        {
            InitializeComponent();
        }

        private void PersonnelCategoryDockForm_Load(object sender, EventArgs e)
        {
            shiftComboBox.DataSource = db.WorkingShifts;

            shiftComboBox.SelectedIndex = 0;

            shiftTypeComboBox.DataSource = enumBase<ShiftType>.getItems();

            shiftTypeComboBox.SelectedIndex = 0;

            acivityDepartmentBindingSource.DataSource = db.AcivityDepartments.Where(c => c.ID == 14 || c.ParentID == 14 || c.ID == 13);

            activityDepartmentComboBox.SelectedIndex = 0;

            LoadData();

            isLoaded = true;
        }

        private void LoadData()
        {
            db = new JamsazERPLiteDataClassesDataContext();

            personnelCategoryBindingSource.DataSource =
                db.PersonnelCategories.Where(c => c.ShiftID == (int)shiftComboBox.SelectedValue
                                                  && c.ShiftType == (int)shiftTypeComboBox.SelectedValue
                                                  && c.ActivityDepartmentID == (int)activityDepartmentComboBox.SelectedValue
                                                  );
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(isLoaded)
                LoadData();
        }
    }
}
