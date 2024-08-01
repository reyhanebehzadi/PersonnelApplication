using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.PersonnlsApplication.UI.DialogForms;
using Jamsaz.PersonnlsApplication.BusinessObjects.Definitions;
using Jamsaz.PersonnlsApplication.UI.ReportForms;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class EidRegistrationDockForm : BasePersianForm
    {
        public EidRegistrationDockForm()
        {
            InitializeComponent();
        }
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();

        private void EidRegistrationDockForm_Load(object sender, EventArgs e)
        {
            fiscalYearBindingSource.DataSource = db.FiscalYears;
            fiscalyearComboBox.SelectedItem = db.FiscalYears.SingleOrDefault(c => c.Status == 2);




        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddEidRegistrationDialogForm addEidRegistrationDialogForm = new AddEidRegistrationDialogForm() { FormStatus = FormStatus.Add };

            if (addEidRegistrationDialogForm.ShowDialog() == DialogResult.OK)
            {
                db = new JamsazERPLiteDataClassesDataContext();
                eidRegistrationBindingSource.DataSource = db.EidRegistrations.Where(c => c.FiscalYearID == ((FiscalYear)fiscalYearBindingSource.Current).ID).OrderBy(d => Convert.ToInt32(d.Personnel.PersonnelNumber)).ToList();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EidRegistration current = (EidRegistration)eidRegistrationBindingSource.Current;
            if (current != null)
            {
                AddEidRegistrationDialogForm addEidRegistrationDialogForm = new AddEidRegistrationDialogForm() { FormStatus = FormStatus.Edit, EidRegistration = current };

                if (addEidRegistrationDialogForm.ShowDialog() == DialogResult.OK)
                {
                    db = new JamsazERPLiteDataClassesDataContext();
                    eidRegistrationBindingSource.DataSource = db.EidRegistrations.Where(c => c.FiscalYearID == ((FiscalYear)fiscalYearBindingSource.Current).ID).OrderBy(d => Convert.ToInt32(d.Personnel.PersonnelNumber)).ToList();
                }
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            EidRegistration current = (EidRegistration)eidRegistrationBindingSource.Current;
            if (current != null)
            {
                if (Helper.Confirm("آیا مایل به حذف اطلاعات هستید؟"))
                {
                    db.EidRegistrations.DeleteOnSubmit(current);
                    db.SubmitChanges();
                    db = new JamsazERPLiteDataClassesDataContext();
                    eidRegistrationBindingSource.DataSource = db.EidRegistrations.Where(c => c.FiscalYearID == ((FiscalYear)fiscalYearBindingSource.Current).ID).OrderBy(d => Convert.ToInt32(d.Personnel.PersonnelNumber)).ToList();
                }



            }
        }



        private void fiscalyearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            db = new JamsazERPLiteDataClassesDataContext();
            if (fiscalyearComboBox.SelectedValue != null)
            {
                eidRegistrationBindingSource.Clear();

                int current = (int)fiscalyearComboBox.SelectedValue;
                if (current > 0 && !string.IsNullOrEmpty(searchTextBox.Text))
                {
                    eidRegistrationBindingSource.DataSource = db.EidRegistrations.Where(c => c.FiscalYearID == current && (c.Personnel.PersonnelNumber.Contains(searchTextBox.Text.Trim()) || c.Personnel.FirstName.Contains(searchTextBox.Text.Trim()) || c.Personnel.LastName.Contains(searchTextBox.Text.Trim()))).OrderBy(d => Convert.ToInt32(d.Personnel.PersonnelNumber)).ToList();
                }
                else
                {
                    eidRegistrationBindingSource.DataSource = db.EidRegistrations.Where(c => c.FiscalYearID == current).OrderBy(d => Convert.ToInt32(d.Personnel.PersonnelNumber)).ToList();

                }
            }

        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            EidRegistrationReport eidRegistrationReport = new EidRegistrationReport() { fiscalyearID = (int)fiscalyearComboBox.SelectedValue };
            eidRegistrationReport.ShowDialog();
        }

        private void personnelListButton_Click(object sender, EventArgs e)
        {
            AllPersonnelListDialogForm allPersonnelListDialogForm = new AllPersonnelListDialogForm() { FiscalYearID= (int)fiscalyearComboBox.SelectedValue };

            if (allPersonnelListDialogForm.ShowDialog() == DialogResult.OK)
            {
                foreach (Personnel item in allPersonnelListDialogForm.SelectedPersonnels)
                {
                    if (!db.EidRegistrations.Any(c => c.FiscalYearID == (int)fiscalyearComboBox.SelectedValue && c.PersonnelID == item.Id))
                    {
                        db.EidRegistrations.InsertOnSubmit(new EidRegistration()
                        {
                            FiscalYearID = (int)fiscalyearComboBox.SelectedValue,
                            PersonnelID = item.Id,
                            M1 = 0,
                            M2 = 0,
                            M3 = 0,
                            M4 = 0,
                            M5 = 0,
                            M6 = 0,
                            M7 = 0,
                            M8 = 0,
                            M9 = 0,
                            M10 = 0,
                            M11 = 0,
                            M12 = 0,
                            Total = 0,
                            P1 = false,
                            P2 = false,
                            P3 = false,
                            P4 = false,
                            P5 = false,
                            P6 = false,
                            P7 = false,
                            P8 = false,
                            P9 = false,
                            P10 = false,
                            P11 = false,
                            P12 = false

                        });
                    }
                }
            }
            db.SubmitChanges();

            db = new JamsazERPLiteDataClassesDataContext();
            eidRegistrationBindingSource.DataSource = db.EidRegistrations.Where(c => c.FiscalYearID == ((FiscalYear)fiscalYearBindingSource.Current).ID).OrderBy(d => Convert.ToInt32(d.Personnel.PersonnelNumber)).ToList();
        }

        private void eidRegistrationDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            EidRegistration current = (EidRegistration)eidRegistrationBindingSource.Current;


            if (e.ColumnIndex == 2 || e.ColumnIndex == 3 || e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 6 || e.ColumnIndex == 7 || e.ColumnIndex == 8 || e.ColumnIndex == 9
              || e.ColumnIndex == 10 || e.ColumnIndex == 11 || e.ColumnIndex == 12 || e.ColumnIndex == 13)
                current.Total = current.M1.GetValueOrDefault() + current.M2.GetValueOrDefault() + current.M3.GetValueOrDefault() + current.M4.GetValueOrDefault() + current.M5.GetValueOrDefault() +
                 current.M6.GetValueOrDefault() + current.M7.GetValueOrDefault() + current.M8.GetValueOrDefault() + current.M9.GetValueOrDefault() + current.M10.GetValueOrDefault() + current.M11.GetValueOrDefault() + current.M12.GetValueOrDefault();


        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Helper.Confirm("آیا مایل به ثبت تغییرات میباشید؟"))
            {
                db.SubmitChanges();
            }
        }

        private void eidRegistrationDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            (sender as DataGridView).Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
        }

        private void eidRegistrationDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            NumberOfDaysDialogForm numberOfDaysDialogForm = new NumberOfDaysDialogForm(e.ColumnIndex);
            if (numberOfDaysDialogForm.ShowDialog() == DialogResult.OK)
            {

                if (e.ColumnIndex == 2)
                {

                    foreach (EidRegistration item in eidRegistrationBindingSource.List)
                    {
                        item.M1 = numberOfDaysDialogForm.value;
                        item.Total = item.M1.GetValueOrDefault() + item.M2.GetValueOrDefault() + item.M3.GetValueOrDefault() + item.M4.GetValueOrDefault() + item.M5.GetValueOrDefault() +
                 item.M6.GetValueOrDefault() + item.M7.GetValueOrDefault() + item.M8.GetValueOrDefault() + item.M9.GetValueOrDefault() + item.M10.GetValueOrDefault() + item.M11.GetValueOrDefault() + item.M12.GetValueOrDefault();


                    }





                }
                if (e.ColumnIndex == 3)
                {

                    foreach (EidRegistration item in eidRegistrationBindingSource.List)
                    {
                        item.M2 = numberOfDaysDialogForm.value;
                        item.Total = item.M1.GetValueOrDefault() + item.M2.GetValueOrDefault() + item.M3.GetValueOrDefault() + item.M4.GetValueOrDefault() + item.M5.GetValueOrDefault() +
                 item.M6.GetValueOrDefault() + item.M7.GetValueOrDefault() + item.M8.GetValueOrDefault() + item.M9.GetValueOrDefault() + item.M10.GetValueOrDefault() + item.M11.GetValueOrDefault() + item.M12.GetValueOrDefault();


                    }





                }
                if (e.ColumnIndex == 4)
                {

                    foreach (EidRegistration item in eidRegistrationBindingSource.List)
                    {
                        item.M3 = numberOfDaysDialogForm.value;
                        item.Total = item.M1.GetValueOrDefault() + item.M2.GetValueOrDefault() + item.M3.GetValueOrDefault() + item.M4.GetValueOrDefault() + item.M5.GetValueOrDefault() +
                 item.M6.GetValueOrDefault() + item.M7.GetValueOrDefault() + item.M8.GetValueOrDefault() + item.M9.GetValueOrDefault() + item.M10.GetValueOrDefault() + item.M11.GetValueOrDefault() + item.M12.GetValueOrDefault();


                    }




                }
                if (e.ColumnIndex == 5)
                {

                    foreach (EidRegistration item in eidRegistrationBindingSource.List)
                    {
                        item.M4 = numberOfDaysDialogForm.value;
                        item.Total = item.M1.GetValueOrDefault() + item.M2.GetValueOrDefault() + item.M3.GetValueOrDefault() + item.M4.GetValueOrDefault() + item.M5.GetValueOrDefault() +
                 item.M6.GetValueOrDefault() + item.M7.GetValueOrDefault() + item.M8.GetValueOrDefault() + item.M9.GetValueOrDefault() + item.M10.GetValueOrDefault() + item.M11.GetValueOrDefault() + item.M12.GetValueOrDefault();


                    }





                }


                if (e.ColumnIndex == 6)
                {

                    foreach (EidRegistration item in eidRegistrationBindingSource.List)
                    {
                        item.M5 = numberOfDaysDialogForm.value;
                        item.Total = item.M1.GetValueOrDefault() + item.M2.GetValueOrDefault() + item.M3.GetValueOrDefault() + item.M4.GetValueOrDefault() + item.M5.GetValueOrDefault() +
                 item.M6.GetValueOrDefault() + item.M7.GetValueOrDefault() + item.M8.GetValueOrDefault() + item.M9.GetValueOrDefault() + item.M10.GetValueOrDefault() + item.M11.GetValueOrDefault() + item.M12.GetValueOrDefault();


                    }





                }
                if (e.ColumnIndex == 7)
                {

                    foreach (EidRegistration item in eidRegistrationBindingSource.List)
                    {
                        item.M6 = numberOfDaysDialogForm.value;
                        item.Total = item.M1.GetValueOrDefault() + item.M2.GetValueOrDefault() + item.M3.GetValueOrDefault() + item.M4.GetValueOrDefault() + item.M5.GetValueOrDefault() +
                 item.M6.GetValueOrDefault() + item.M7.GetValueOrDefault() + item.M8.GetValueOrDefault() + item.M9.GetValueOrDefault() + item.M10.GetValueOrDefault() + item.M11.GetValueOrDefault() + item.M12.GetValueOrDefault();


                    }





                }

                if (e.ColumnIndex == 8)
                {

                    foreach (EidRegistration item in eidRegistrationBindingSource.List)
                    {
                        item.M7 = numberOfDaysDialogForm.value;
                        item.Total = item.M1.GetValueOrDefault() + item.M2.GetValueOrDefault() + item.M3.GetValueOrDefault() + item.M4.GetValueOrDefault() + item.M5.GetValueOrDefault() +
                 item.M6.GetValueOrDefault() + item.M7.GetValueOrDefault() + item.M8.GetValueOrDefault() + item.M9.GetValueOrDefault() + item.M10.GetValueOrDefault() + item.M11.GetValueOrDefault() + item.M12.GetValueOrDefault();


                    }





                }

                if (e.ColumnIndex == 9)
                {

                    foreach (EidRegistration item in eidRegistrationBindingSource.List)
                    {
                        item.M8 = numberOfDaysDialogForm.value;
                        item.Total = item.M1.GetValueOrDefault() + item.M2.GetValueOrDefault() + item.M3.GetValueOrDefault() + item.M4.GetValueOrDefault() + item.M5.GetValueOrDefault() +
                 item.M6.GetValueOrDefault() + item.M7.GetValueOrDefault() + item.M8.GetValueOrDefault() + item.M9.GetValueOrDefault() + item.M10.GetValueOrDefault() + item.M11.GetValueOrDefault() + item.M12.GetValueOrDefault();


                    }


                }


            }

            if (e.ColumnIndex == 10)
            {

                foreach (EidRegistration item in eidRegistrationBindingSource.List)
                {
                    item.M9 = numberOfDaysDialogForm.value;
                    item.Total = item.M1.GetValueOrDefault() + item.M2.GetValueOrDefault() + item.M3.GetValueOrDefault() + item.M4.GetValueOrDefault() + item.M5.GetValueOrDefault() +
             item.M6.GetValueOrDefault() + item.M7.GetValueOrDefault() + item.M8.GetValueOrDefault() + item.M9.GetValueOrDefault() + item.M10.GetValueOrDefault() + item.M11.GetValueOrDefault() + item.M12.GetValueOrDefault();


                }




            }

            if (e.ColumnIndex == 11)
            {

                foreach (EidRegistration item in eidRegistrationBindingSource.List)
                {
                    item.M10 = numberOfDaysDialogForm.value;
                    item.Total = item.M1.GetValueOrDefault() + item.M2.GetValueOrDefault() + item.M3.GetValueOrDefault() + item.M4.GetValueOrDefault() + item.M5.GetValueOrDefault() +
             item.M6.GetValueOrDefault() + item.M7.GetValueOrDefault() + item.M8.GetValueOrDefault() + item.M9.GetValueOrDefault() + item.M10.GetValueOrDefault() + item.M11.GetValueOrDefault() + item.M12.GetValueOrDefault();


                }





            }

            if (e.ColumnIndex == 12)
            {

                foreach (EidRegistration item in eidRegistrationBindingSource.List)
                {
                    item.M11 = numberOfDaysDialogForm.value;
                    item.Total = item.M1.GetValueOrDefault() + item.M2.GetValueOrDefault() + item.M3.GetValueOrDefault() + item.M4.GetValueOrDefault() + item.M5.GetValueOrDefault() +
             item.M6.GetValueOrDefault() + item.M7.GetValueOrDefault() + item.M8.GetValueOrDefault() + item.M9.GetValueOrDefault() + item.M10.GetValueOrDefault() + item.M11.GetValueOrDefault() + item.M12.GetValueOrDefault();


                }





            }

            if (e.ColumnIndex == 13)
            {

                foreach (EidRegistration item in eidRegistrationBindingSource.List)
                {
                    item.M12 = numberOfDaysDialogForm.value;
                    item.Total = item.M1.GetValueOrDefault() + item.M2.GetValueOrDefault() + item.M3.GetValueOrDefault() + item.M4.GetValueOrDefault() + item.M5.GetValueOrDefault() +
             item.M6.GetValueOrDefault() + item.M7.GetValueOrDefault() + item.M8.GetValueOrDefault() + item.M9.GetValueOrDefault() + item.M10.GetValueOrDefault() + item.M11.GetValueOrDefault() + item.M12.GetValueOrDefault();


                }





            }
            eidRegistrationBindingSource.ResetBindings(true);

        }

        private void eidRegistrationDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            EidRegistration current = (EidRegistration)eidRegistrationBindingSource.Current;
            if (current != null)
            {
                PaymentDialogForm paymentDialogForm = new PaymentDialogForm() { Selected = current };
                if (paymentDialogForm.ShowDialog() == DialogResult.OK)
                {
                    db = new JamsazERPLiteDataClassesDataContext();
                    eidRegistrationBindingSource.DataSource = db.EidRegistrations.Where(c => c.FiscalYearID == ((FiscalYear)fiscalYearBindingSource.Current).ID).OrderBy(d => Convert.ToInt32(d.Personnel.PersonnelNumber)).ToList();

                }
            }

        }

        private void eidRegistrationDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in eidRegistrationDataGridView.Rows)
            {
                if (Convert.ToInt32(row.Cells[15].Value) == 1 && row.Cells[27].Value != null && Convert.ToInt32(row.Cells[27].Value) == 2)
                    row.Cells[2].Style.BackColor = Color.LightGreen;

                if (Convert.ToInt32(row.Cells[16].Value) == 1 && row.Cells[27].Value != null && Convert.ToInt32(row.Cells[27].Value) == 2)
                    row.Cells[3].Style.BackColor = Color.LightGreen;

                if (Convert.ToInt32(row.Cells[17].Value) == 1 && row.Cells[27].Value != null && Convert.ToInt32(row.Cells[27].Value) == 2)
                    row.Cells[4].Style.BackColor = Color.LightGreen;

                if (Convert.ToInt32(row.Cells[18].Value) == 1 && row.Cells[27].Value != null && Convert.ToInt32(row.Cells[27].Value) == 2)
                    row.Cells[5].Style.BackColor = Color.LightGreen;

                if (Convert.ToInt32(row.Cells[19].Value) == 1 && row.Cells[27].Value != null && Convert.ToInt32(row.Cells[27].Value) == 2)
                    row.Cells[6].Style.BackColor = Color.LightGreen;

                if (Convert.ToInt32(row.Cells[20].Value) == 1 && row.Cells[27].Value != null && Convert.ToInt32(row.Cells[27].Value) == 2)
                    row.Cells[7].Style.BackColor = Color.LightGreen;

                if (Convert.ToInt32(row.Cells[21].Value) == 1 && row.Cells[27].Value != null && Convert.ToInt32(row.Cells[27].Value) == 2)
                    row.Cells[8].Style.BackColor = Color.LightGreen;

                if (Convert.ToInt32(row.Cells[22].Value) == 1 && row.Cells[27].Value != null && Convert.ToInt32(row.Cells[27].Value) == 2)
                    row.Cells[9].Style.BackColor = Color.LightGreen;

                if (Convert.ToInt32(row.Cells[23].Value) == 1 && row.Cells[27].Value != null && Convert.ToInt32(row.Cells[27].Value) == 2)
                    row.Cells[10].Style.BackColor = Color.LightGreen;

                if (Convert.ToInt32(row.Cells[24].Value) == 1 && row.Cells[27].Value != null && Convert.ToInt32(row.Cells[27].Value) == 2)
                    row.Cells[11].Style.BackColor = Color.LightGreen;

                if (Convert.ToInt32(row.Cells[25].Value) == 1 && row.Cells[27].Value != null && Convert.ToInt32(row.Cells[27].Value) == 2)
                    row.Cells[12].Style.BackColor = Color.LightGreen;

                if (Convert.ToInt32(row.Cells[26].Value) == 1 && row.Cells[27].Value != null && Convert.ToInt32(row.Cells[27].Value) == 2)
                    row.Cells[13].Style.BackColor = Color.LightGreen;
                //--------------------
                if (Convert.ToInt32(row.Cells[15].Value) == 1 && row.Cells[27].Value != null && Convert.ToInt32(row.Cells[27].Value) == 1)
                    row.Cells[2].Style.BackColor = Color.IndianRed;

                if (Convert.ToInt32(row.Cells[16].Value) == 1 && row.Cells[27].Value != null && Convert.ToInt32(row.Cells[27].Value) == 1)
                    row.Cells[3].Style.BackColor = Color.IndianRed;

                if (Convert.ToInt32(row.Cells[17].Value) == 1 && row.Cells[27].Value != null && Convert.ToInt32(row.Cells[27].Value) == 1)
                    row.Cells[4].Style.BackColor = Color.IndianRed;

                if (Convert.ToInt32(row.Cells[18].Value) == 1 && row.Cells[27].Value != null && Convert.ToInt32(row.Cells[27].Value) == 1)
                    row.Cells[5].Style.BackColor = Color.IndianRed;

                if (Convert.ToInt32(row.Cells[19].Value) == 1 && row.Cells[27].Value != null && Convert.ToInt32(row.Cells[27].Value) == 1)
                    row.Cells[6].Style.BackColor = Color.IndianRed;

                if (Convert.ToInt32(row.Cells[20].Value) == 1 && row.Cells[27].Value != null && Convert.ToInt32(row.Cells[27].Value) == 1)
                    row.Cells[7].Style.BackColor = Color.IndianRed;

                if (Convert.ToInt32(row.Cells[21].Value) == 1 && row.Cells[27].Value != null && Convert.ToInt32(row.Cells[27].Value) == 1)
                    row.Cells[8].Style.BackColor = Color.IndianRed;

                if (Convert.ToInt32(row.Cells[22].Value) == 1 && row.Cells[27].Value != null && Convert.ToInt32(row.Cells[27].Value) == 1)
                    row.Cells[9].Style.BackColor = Color.IndianRed;

                if (Convert.ToInt32(row.Cells[23].Value) == 1 && row.Cells[27].Value != null && Convert.ToInt32(row.Cells[27].Value) == 1)
                    row.Cells[10].Style.BackColor = Color.IndianRed;

                if (Convert.ToInt32(row.Cells[24].Value) == 1 && row.Cells[27].Value != null && Convert.ToInt32(row.Cells[27].Value) == 1)
                    row.Cells[11].Style.BackColor = Color.IndianRed;

                if (Convert.ToInt32(row.Cells[25].Value) == 1 && row.Cells[27].Value != null && Convert.ToInt32(row.Cells[27].Value) == 1)
                    row.Cells[12].Style.BackColor = Color.IndianRed;

                if (Convert.ToInt32(row.Cells[26].Value) == 1 && row.Cells[27].Value != null && Convert.ToInt32(row.Cells[27].Value) == 1)
                    row.Cells[13].Style.BackColor = Color.IndianRed;
            }

            eidRegistrationDataGridView.Refresh();

        }




        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EidRegistration current = (EidRegistration)eidRegistrationBindingSource.Current;
            if (current != null)
            {
                karkardReportForm karkardReportForm = new karkardReportForm() { selectedPersonnel = current.Personnel };
                karkardReportForm.ShowDialog();
            }
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                db = new JamsazERPLiteDataClassesDataContext();
                if (fiscalyearComboBox.SelectedValue != null)
                {
                    eidRegistrationBindingSource.Clear();

                    int current = (int)fiscalyearComboBox.SelectedValue;
                    if (current > 0 && !string.IsNullOrEmpty(searchTextBox.Text))
                    {
                        eidRegistrationBindingSource.DataSource = db.EidRegistrations.Where(c => c.FiscalYearID == current && (c.Personnel.PersonnelNumber.Contains(searchTextBox.Text.Trim()) || c.Personnel.FirstName.Contains(searchTextBox.Text.Trim()) || c.Personnel.LastName.Contains(searchTextBox.Text.Trim()))).OrderBy(d => Convert.ToInt32(d.Personnel.PersonnelNumber)).ToList();
                    }
                    else
                    {
                        eidRegistrationBindingSource.DataSource = db.EidRegistrations.Where(c => c.FiscalYearID == current).OrderBy(d => Convert.ToInt32(d.Personnel.PersonnelNumber)).ToList();

                    }
                }
            }
        }
    }
}

