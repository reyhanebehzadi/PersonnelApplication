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
using System.Data.Linq;
using Jamsaz.PersonnlsApplication.UI.DialogForms;
using Jamsaz.PersonnlsApplication.BusinessObjects.Definitions;
namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class BaseInformationMajorsForm : BasePersianForm
    {
        public BaseInformationMajorsForm()
        {
            InitializeComponent();

        }
      // JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
        JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        private void BaseInformationMajorsForm_Load(object sender, EventArgs e)
        {
            try
            {
                majorsBindingSource.DataSource = db.Majors.ToList();
            }
            catch (System.Data.SqlClient.SqlException exp)
            {
                MessageBox.Show(exp.Message, "مشکل در ارتباط با بانک اطلاعاتی");
            }
        }

        private void filterNameTextBox_TextChanged(object sender, EventArgs e)
        {
            
            majorsBindingSource.DataSource = db.Majors.Where(c => c.Name.Contains(filterNameTextBox.Text));
        }

        //private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        //{
        //    try
        //    {
        //        cancelBotton.Enabled = true;
        //        saveBotton.Enabled = true;
        //        if (e.ColumnIndex == 1)
        //        {
        //            if (!Helper.HassInteger(e.FormattedValue.ToString()))
        //            {
        //                Helper.ShowMessageBox("مقدار کد را عددی وارد کنید", "خطا در ورود اطلاعات", FarsiLibrary.Win.Enums.FarsiMessageBoxExIcon.Error);
        //                e.Cancel = true;
        //                return;
        //            }
        //        }
        //        if (e.ColumnIndex == 1)
        //        {
        //            if (IsHassCode(e.FormattedValue.ToString(), majorDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()))
        //            {
        //                Helper.ShowMessageBox(" مقدار" + "[" + e.FormattedValue.ToString() + "]" + "قبلا در لیست اضافه شده \n" + " لطفا مقدار را تغییر دهید یا با زدن کلید " + " [Escapt]" + " مقدار را خالی کنید", "خطا در ورود اطلاعات", FarsiLibrary.Win.Enums.FarsiMessageBoxExIcon.Error);
        //                e.Cancel = true;
        //                return;
        //            }
        //        }
        //        if (e.ColumnIndex == 2)
        //        {
        //            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
        //            {
        //                Helper.ShowMessageBox("مقدار نام رشته تحصیلی را وارد کنید", "خطا در ورود اطلاعات", FarsiLibrary.Win.Enums.FarsiMessageBoxExIcon.Error);
        //                e.Cancel = true;
        //                return;
        //            }
        //        }

        //        if (e.ColumnIndex == 2)
        //        {
        //            if (IsHassWord(e.FormattedValue.ToString(), majorDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()))
        //            {
        //                Helper.ShowMessageBox(" مقدار" + "[" + e.FormattedValue.ToString() + "]" + "قبلا در لیست اضافه شده \n" + " لطفا مقدار را تغییر دهید یا با زدن کلید " + " [Escapt]" + " مقدار را خالی کنید", "خطا در ورود اطلاعات", FarsiLibrary.Win.Enums.FarsiMessageBoxExIcon.Error);
        //                e.Cancel = true;
        //                return;
        //            }
        //        }
        //        //   saveBotton_Click(null, null);
        //    }
        //    catch { }
        //}

        //public override bool CloseForm()
        //{
        //    try
        //    {
        //        ChangeSet changeSet = db.GetChangeSet();
        //        if (changeSet.Deletes.Count != 0 || changeSet.Inserts.Count != 0 || changeSet.Updates.Count != 0)
        //            return false;

        //        return true;
        //    }
        //    catch
        //    {
        //        return true;
        //    }
        //}
        //public bool IsHassWord(string name, string currentID)
        //{
        //    try
        //    {
        //        foreach (Major major in majorsBindingSource.List)
        //        {
        //            if (major.Name == name && major.Id != Helper.GetInt(currentID))
        //                return true;
        //        }
        //        return false;

        //    }
        //    catch { }
        //    return false;
        //}
        //public bool IsHassCode(string code, string currentID)
        //{
        //    foreach (Major major in majorsBindingSource.List)
        //    {
        //        if (major.Code == Helper.GetInt(code) && major.Id != Helper.GetInt(currentID))
        //            return true;
        //    }
        //    return false;
        //}

        //private void cancelBotton_Click(object sender, EventArgs e)
        //{
        //    filterNameTextBox.Text = string.Empty;
        //    db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
        //    majorsBindingSource.DataSource = db.Majors;
        //    cancelBotton.Enabled = false;
        //    saveBotton.Enabled = false;
        //}

        //private void saveBotton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        ChangeSet changeSet = db.GetChangeSet();
        //        if (changeSet.Deletes.Count != 0 || changeSet.Inserts.Count != 0 || changeSet.Updates.Count != 0)
        //        {
        //            if (Helper.Confirm("آیا مایل به ثبت تغیرات هستید؟"))
        //            {
        //                db.SubmitChanges();
        //                cancelBotton.Enabled = false;
        //                saveBotton.Enabled = false;
        //            }
        //        }
        //    }
        //    catch (System.Data.SqlClient.SqlException exp)
        //    {
        //        MessageBox.Show(exp.Message);
        //    }
        //}

        //private void majorDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        //{
        //    Major major = (Major)majorsBindingSource.Current;
        //    int countPersonnelUses = db.Personnels.Count(c => c.MajorId == major.Id);

        //    if (countPersonnelUses != 0)
        //    {
        //        e.Cancel = true;
        //        Helper.ShowMessage(" در پرونده " + countPersonnelUses.ToString() + " " + "پرسنل از این کد استفاده شده پس از ویرایش دوباره سعی نمائید");
        //    }
        //    else
        //    {
        //        cancelBotton.Enabled = true;
        //        saveBotton.Enabled = true;
        //    }
        //}

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                AddBaseInformationMajorsDialogForm addBaseInformationMajorsDialogForm = new AddBaseInformationMajorsDialogForm()
                {
                    FormStatus = FormStatus.Add
                };
                if (addBaseInformationMajorsDialogForm.ShowDialog() == DialogResult.OK)
                {
                    db = new JamsazERPLiteDataClassesDataContext();
                    majorsBindingSource.DataSource = db.Majors.ToList();
                    majorDataGridView.Refresh();
                }
            }
            catch (Exception ex)
            {

                Helper.Error(ex.ToString());
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {

                Major Current = (Major)majorsBindingSource.Current;

                if (Current != null)
                {
                    AddBaseInformationMajorsDialogForm addBaseInformationMajorsDialogForm = new AddBaseInformationMajorsDialogForm()
                    {
                        FormStatus = FormStatus.Edit,
                        Major = Current
                    };

                    if (addBaseInformationMajorsDialogForm.ShowDialog() == DialogResult.OK)
                    {
                        db = new JamsazERPLiteDataClassesDataContext();
                        majorsBindingSource.DataSource = db.Majors.ToList();
                        majorDataGridView.Refresh();
                    }
                }

            }
            catch (Exception ex)
            {

                Helper.Error("بروز خطا");
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Major Current = (Major)majorsBindingSource.Current;

            if (Current != null)
            {
               if( Helper.Confirm("آیا مایل به حذف اطلاعات می باشید"))
                {
                    if (db.Personnels.Any(c=>c.MajorId==Current.Id))
                    {
                       
                        Helper.ShowMessage(" در پرونده پرسنل از این کد استفاده شده پس از ویرایش دوباره سعی نمائید");
                        return;
                    }
                    db.Majors.DeleteOnSubmit(Current);
                    db.SubmitChanges();
                    db = new JamsazERPLiteDataClassesDataContext();
                    majorsBindingSource.DataSource = db.Majors.ToList();
                }
            }
            
              
        }

      
    }
}
