using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jamsaz.Common.UI.DialogForms;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.PersonnlsApplication.UI.DialogForms;
using Jamsaz.PersonnlsApplication.Classes;
using Jamsaz.Common;
using Microsoft.Office.Interop.Word;
using Jamsaz.PersonnlsApplication.Definitions;

namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class PersonnelByBirthDayDialogForm : BasePersianForm
    {
        public PersonnelByBirthDayDialogForm()
        {
            InitializeComponent();
        }

        private JamsazERPLiteDataClassesDataContext db;

        private void PersonnelByBirthDayDialogForm_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("{0} {1}", "لیست متولدین ", FarsiLibrary.Utils.PersianDate.Now.ToWritten());

            try
            {
                this.faDatePicker.SelectedDateTime = DateTime.Now;

                db = new JamsazERPLiteDataClassesDataContext();

                this.selectPersonnelsByBirthdayResultBindingSource.DataSource
                    = db.SelectPersonnelsByBirthday((this.factoryRadioButton.Checked) ? 1 : 2 , this.faDatePicker.SelectedDateTime.Value.Date);


                this.faDatePicker.SelectedDateTimeChanged += new EventHandler(faDatePicker_SelectedDateTimeChanged);
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(string.Format("{0}{1}{2}"
                                                            , "بروز خطا"
                                                            , "\n"
                                                            , ex.Message));
            }
        }

        void faDatePicker_SelectedDateTimeChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.faDatePicker.SelectedDateTime == null)
                {

                    Helper.ShowMessage("لطفا تاریخ را انتخاب کنید");

                    return;
                }

                this.Text = string.Format("{0} {1}", "لیست متولدین ",
                                          FarsiLibrary.Utils.PersianDate.Parse(
                                              FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(
                                                  this.faDatePicker.SelectedDateTime.Value).ToString()).ToWritten());


                this.selectPersonnelsByBirthdayResultBindingSource.DataSource
                    = db.SelectPersonnelsByBirthday((this.factoryRadioButton.Checked) ? 1 : 2, this.faDatePicker.SelectedDateTime.Value.Date);
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(string.Format("{0}{1}{2}"
                                                            , "بروز خطا"
                                                            , "\n"
                                                            , ex.Message));
            }
        }

        
        private void factoryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.faDatePicker.SelectedDateTime == null)
                {

                    Helper.ShowMessage("لطفا تاریخ را انتخاب کنید");

                    return;
                }


                this.Text = string.Format("{0} {1}", "لیست متولدین ",
                                          FarsiLibrary.Utils.PersianDate.Parse(
                                              FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(
                                                  this.faDatePicker.SelectedDateTime.Value).ToString()).ToWritten());


                this.selectPersonnelsByBirthdayResultBindingSource.DataSource
                    = db.SelectPersonnelsByBirthday((this.factoryRadioButton.Checked) ? 1 : 2, this.faDatePicker.SelectedDateTime.Value.Date);
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(string.Format("{0}{1}{2}"
                                                            , "بروز خطا"
                                                            , "\n"
                                                            , ex.Message));
            }
        }

        private void headOfficeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.factoryRadioButton_CheckedChanged(null, null);
        }

        private void voidButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void exportToExcelButton_Click(object sender, EventArgs e)
        {
            List<SelectPersonnelsByBirthdayResult> birthdayResults =
                ((IList<SelectPersonnelsByBirthdayResult>)this.selectPersonnelsByBirthdayResultBindingSource.List).
                    ToList();

            if (birthdayResults.Count == 0)
                return;

            Jamsaz.PersonnlsApplication.Classes.ExportToExcel<SelectPersonnelsByBirthdayResult>.Export(birthdayResults);
        }

     
    }
}
