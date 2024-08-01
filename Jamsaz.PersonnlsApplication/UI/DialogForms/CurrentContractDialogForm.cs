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
using Jamsaz.PersonnlsApplication.Definitions;
using System.Data.Linq;

namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class CurrentContractDialogForm : Jamsaz.Common.BasePersianForm
    {
        public CurrentContractDialogForm()
        {
            InitializeComponent();
        }

        private JamsazERPLiteDataClassesDataContext db;

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (this.startdatepicker.SelectedDateTime == null || this.endDatepicker.SelectedDateTime == null)
            {
                Helper.ShowMessage("ابتدا تاریخ شروع و پایان را انتخاب کنید");

                return;
            }

            if (Helper.Confirm("آیا مایل به انجام می باشید؟") == false)
                return;


            db = new JamsazERPLiteDataClassesDataContext();

            try
            {


                db.UpdateCurrentContractDates(this.startdatepicker.SelectedDateTime.Value.Date,
                                              this.endDatepicker.SelectedDateTime.Value.Date,
                                              null, this.headOfficeCheckbox.Checked);


                Helper.ShowMessage("بروزرسانی انجام شد");

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
