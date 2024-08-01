using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Linq;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Definitions;
using Jamsaz.PersonnlsApplication.UI.DialogForms;
namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class BaseInformationUniversityServiceForm : Jamsaz.Common.BasePersianForm
    {
        public BaseInformationUniversityServiceForm()
        {
            InitializeComponent();
        }
        // Jamsaz.PersonnlsApplication.BusinessObjects.Data.JamsazERPLiteDataClassesDataContext db = new Jamsaz.PersonnlsApplication.BusinessObjects.Data.JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
        JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        private void BaseInformationUniversityServiceForm_Load(object sender, EventArgs e)
        {
            try
            {
                universityDegreeBindingSource.DataSource = db.UniversityDegrees;
            }
            catch (System.Data.SqlClient.SqlException exp)
            {
                MessageBox.Show(exp.Message, "مشکل در ارتباط با بانک اطلاعاتی");
            }
        }

        //private void saveBotton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        ChangeSet changeSet = db.GetChangeSet();
        //        if (changeSet.Deletes.Count != 0 || changeSet.Inserts.Count != 0 || changeSet.Updates.Count != 0)
        //        {
        //            if (Helper.Confirm("آیا مایل به ثبت تغیرات هستید؟"))
        //            {
        //                universityDegreeBindingSource.EndEdit();
        //                db.SubmitChanges();
        //                cancelBotton.Enabled = false;
        //                saveBotton.Enabled = false;
        //            }
        //        }
        //        else
        //        {
        //            cancelBotton.Enabled = false;
        //            saveBotton.Enabled = false;
        //        }

        //    }
        //    catch (System.Data.SqlClient.SqlException exp)
        //    {
        //        MessageBox.Show(exp.Message);
        //    }
        //}

        //private void cancelBotton_Click(object sender, EventArgs e)
        //{
        //    db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
        //    universityDegreeBindingSource.DataSource = db.UniversityDegrees;
        //    cancelBotton.Enabled = false;
        //    saveBotton.Enabled = false;
        //}

        //private void majorDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
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
        //        foreach (UniversityDegree universityDegree in universityDegreeBindingSource.List)
        //        {
        //            if (universityDegree.Name == name && universityDegree.Id != Helper.GetInt(currentID))
        //                return true;
        //        }
        //        return false;

        //    }
        //    catch { }
        //    return false;
        //}
        //public bool IsHassCode(string code, string currentID)
        //{
        //    foreach (UniversityDegree universityDegree in universityDegreeBindingSource.List)
        //    {
        //        if (Helper.GetInt(universityDegree.Code) == Helper.GetInt(code) && universityDegree.Id != Helper.GetInt(currentID))
        //            return true;
        //    }
        //    return false;
        //}

        //private void majorDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        //{
        //    UniversityDegree universityDegree = (UniversityDegree)universityDegreeBindingSource.Current;
        //    int countPersonnelUses = db.Personnels.Count(c => c.UniversityDegreeId == universityDegree.Id);

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
            AddBaseInformationUniversityServiceDialogForm addBaseInformationUniversityServiceDialogForm = new AddBaseInformationUniversityServiceDialogForm()
            {
                FormStatus = FormStatus.Add
            };
            if (addBaseInformationUniversityServiceDialogForm.ShowDialog() == DialogResult.OK)
            {
                db = new JamsazERPLiteDataClassesDataContext();
                universityDegreeBindingSource.DataSource = db.UniversityDegrees.ToList();
                majorDataGridView.Refresh();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            UniversityDegree Current = (UniversityDegree)universityDegreeBindingSource.Current;
            if (Current != null)
            {

                AddBaseInformationUniversityServiceDialogForm addBaseInformationUniversityServiceDialogForm = new AddBaseInformationUniversityServiceDialogForm()
                {
                    FormStatus = FormStatus.Edit,
                    UniversityDegree = Current
                };
                if (addBaseInformationUniversityServiceDialogForm.ShowDialog() == DialogResult.OK)
                {
                    db = new JamsazERPLiteDataClassesDataContext();
                    universityDegreeBindingSource.DataSource = db.UniversityDegrees.ToList();
                    majorDataGridView.Refresh();
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            UniversityDegree Current = (UniversityDegree)universityDegreeBindingSource.Current;
            if (Current != null)
            {
                if (Helper.Confirm("آیا مایل به حذف اطلاعات هستید؟"))
                {
                    if (db.Personnels.Any(c=>c.UniversityDegreeId==Current.Id))
                    {
                        Helper.ShowMessage(" در پرونده پرسنل از این کد استفاده شده پس از ویرایش دوباره سعی نمائید");
                        return;
                    }
                    db.UniversityDegrees.DeleteOnSubmit(Current);
                    db.SubmitChanges();
                    db = new JamsazERPLiteDataClassesDataContext();
                    universityDegreeBindingSource.DataSource = db.UniversityDegrees.ToList();
                    majorDataGridView.Refresh();
                }
            }
        }
    }
}
