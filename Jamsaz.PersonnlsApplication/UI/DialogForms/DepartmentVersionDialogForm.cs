using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.Classes;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using System.Collections;
using Jamsaz.PersonnlsApplication.UI.DialogForms;
using Jamsaz.PersonnlsApplication.Classes;
using System.Data.Linq;

namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class DepartmentVersionDialogForm : BasePersianForm
    {
        public DepartmentVersionDialogForm()
        {
            InitializeComponent();
        }

        public JamsazERPLiteDataClassesDataContext db { get; set; }
        public DepartmentVersion SelectDepartmentVersion { get; set; }
        public int CurrentDepartmentVersionID { get; set; }

        private void DepartmentVersionDialogForm_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void voidButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            this.SelectRow();
        }


        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.SelectRow();
        }

        private void LoadData()
        {
            try
            {
                this.departmentVersionBindingSource.DataSource = db.DepartmentVersions.Where(c => c.ID != this.CurrentDepartmentVersionID);
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(string.Format("{0}{1}{2}"
                                                            , "بروز خطا"
                                                            , "\n"
                                                            , ex.Message));
            }
        }

        private void SelectRow()
        {
            try
            {
                if (this.departmentVersionBindingSource.Current == null)
                    return;

                this.SelectDepartmentVersion = (DepartmentVersion)this.departmentVersionBindingSource.Current;
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(string.Format("{0}{1}{2}"
                                                            , "بروز خطا"
                                                            , "\n"
                                                            , ex.Message));
            }
        }

    }
}
