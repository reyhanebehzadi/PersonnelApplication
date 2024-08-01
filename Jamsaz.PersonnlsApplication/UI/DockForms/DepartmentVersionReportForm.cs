using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class DepartmentVersionReportForm : Jamsaz.Common.BasePersianForm
    {
        public DepartmentVersionReportForm()
        {
            InitializeComponent();
        }

        JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);

        private void DepartmentVersionReportForm_Load(object sender, EventArgs e)
        {
            this.departmentVersionBindingSource.DataSource = db.DepartmentVersions.ToList();

        }

        private void getRepotButton_Click(object sender, EventArgs e)
        {
            int idversion = 0;
            //int.TryParse(versionTextBox.Text, out idversion);
            int dv = int.Parse(this.departmentVersionComboBox.SelectedValue.ToString());
            this.DepartmentBindingSource.DataSource = db.Departments.Where(c => c.DepartmentVersionID == dv).OrderBy(c => c.ParentId).ToList();
            this.reportViewer.RefreshReport();
        }
    }
}
