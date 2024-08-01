using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.Common;
using System.Globalization;
using FarsiLibrary.Utils;
using System.Data.Linq;

namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class PersonnelPayRollDialogForm : BasePersianForm
    {
        public PersonnelPayRollDialogForm()
        {
            InitializeComponent();
        }

        private JamsazERPLiteDataClassesDataContext db;

        public Personnel Current { get; set; }

        private Personnel Personnel;

        private void PersonnelPayRollDialogForm_Load(object sender, EventArgs e)
        {
            db = new JamsazERPLiteDataClassesDataContext();

            this.Text = string.Format("{0} [ {1} ]", "حقوق و دستمزد", this.Current.FirstName + " " + this.Current.LastName);

            this.LoadData();
        }

        private void LoadData()
        {
            try
            {
                this.Personnel = db.Personnels.Single(c => c.Id == this.Current.Id);

                this.payRollBindingSource.DataSource = db.PayRolls.Where(c => c.PersonnelID == this.Current.Id).OrderBy(c => c.EffectiveDate);
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
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Helper.Confirm("آیا مایل به ثبت تغییرات می باشید") == false)
                    return;

                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(string.Format("{0}{1}{2}"
                                                            , "بروز خطا"
                                                            , "\n"
                                                            , ex.Message));
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            PayRoll current = (PayRoll)this.payRollBindingSource.Current;

            if (current == null)
                return;

            if (Helper.Confirm("آیا مایل به حذف رکورد جاری می باشید؟") == false)
                return;

            if (current.ID == 0)
            {
                current.Personnel = null;

                this.payRollBindingSource.RemoveCurrent();
            }
            else
            {
                this.payRollBindingSource.RemoveCurrent();

                db.PayRolls.DeleteOnSubmit(current);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            PayRoll payRoll = new PayRoll()
                                  {
                                      Personnel = this.Personnel,
                                      Salary = 0,
                                      EffectiveDate = System.DateTime.Now,
                                      EffectiveDateEnd=System.DateTime.Now,
                                      Haghekharobar = 0,
                                      HagheMaskan = 0,
                                      HagheOlad = 0,
                                      HagheSakhtiKar = 0,
                                      HagheSarparsti = 0,
                                      MablagheNobateKari = 0,
                                      ShiftPercent = 0,
                                      HagheJazb=0
                                  };

            this.payRollBindingSource.Add(payRoll);

        }

        private void payRollBindingSource_PositionChanged(object sender, EventArgs e)
        {
            PayRoll current = (PayRoll)this.payRollBindingSource.Current;

            if (current == null)
                return;

            this.sumToWrittenTextBox.Text = FarsiLibrary.Utils.ToWords.ToString(current.PayRollSum);

        }

        private void payrollDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            PayRoll current = (PayRoll)this.payRollBindingSource.Current;

            if (e.ColumnIndex == 0 || e.ColumnIndex == 8) //7
            {
                current.MablagheNobateKari = ((current.Salary ?? 0) * (current.ShiftPercent ?? 0) / 100);

                this.payrollDataGridView.Refresh();

                this.sumToWrittenTextBox.Text = FarsiLibrary.Utils.ToWords.ToString(current.PayRollSum);
            }
        }

    }
}
