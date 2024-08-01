using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jamsaz.Common;

namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class CopyPersonnelsPayRollDialogForm : BasePersianForm
    {
        public CopyPersonnelsPayRollDialogForm()
        {
            InitializeComponent();
        }
        
        Jamsaz.PersonnlsApplication.BusinessObjects.Data.JamsazERPLiteDataClassesDataContext db;

        private void copyButton_Click(object sender, EventArgs e)
        {
            if (this.faDatePicker.IsNull)
            {
                Helper.ShowMessage("ابتدا تاریخ قراداد های جدید را مشخص کنید");

                return;
            }
            if (Helper.Confirm("آیا مایل به کپی قراداد ها در تاریخ جدید هستید؟") == false)
                return;

            try
            {
                db = new Jamsaz.PersonnlsApplication.BusinessObjects.Data.JamsazERPLiteDataClassesDataContext();

                db.CopyPayRolls(this.faDatePicker.SelectedDateTime.Value.Date);

                Helper.ShowMessage("قرارداد ها با موفقیت کپی شد.");
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(string.Format("{0}{1}{2}"
                                                            , "بروز خطا"
                                                            , "\n"
                                                            , ex.Message));
            }
        }

        private void voidButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void CopyPersonnelsPayRollDialogForm_Load(object sender, EventArgs e)
        {

        }
    }
}
