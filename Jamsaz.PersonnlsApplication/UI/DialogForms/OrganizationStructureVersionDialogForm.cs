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
    public partial class OrganizationStructureVersionDialogForm : BasePersianForm
    {
        public OrganizationStructureVersionDialogForm()
        {
            InitializeComponent();
        }

        public JamsazERPLiteDataClassesDataContext db { get; set; }
        public int CurrentOrganizationStructureVersionId { get; set; }
        public OrganizationStructureVersion SelectOrganizationStructureVersion { get; set; }

        private void OrganizationStructureVersionDialogForm_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SelectRow();
        }

        private void voidButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            this.SelectRow();
        }

        private void LoadData()
        {
            try
            {
                this.organizationStructureVersionBindingSource.DataSource = db.OrganizationStructureVersions.ToList();
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
                if (this.organizationStructureVersionBindingSource.Current == null)
                    return;

                this.SelectOrganizationStructureVersion = (OrganizationStructureVersion)this.organizationStructureVersionBindingSource.Current;
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
