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
using Jamsaz.PersonnlsApplication.BusinessObjects.Definitions;
using Jamsaz.PersonnlsApplication.UI.DialogForms;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class BaseInformationContractTypeForm : BasePersianForm
    {
        public BaseInformationContractTypeForm()
        {
            InitializeComponent();
        }
        //JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
        JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        private void BaseInformationContractTypeForm_Load(object sender, EventArgs e)
        {
            try
            {
                contractTypeBindingSource.DataSource = db.ContractTypes;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "مشکل در ارتباط با بانک اطلاعاتی");
            }
        }

        //private void ContractTypeDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
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
        //            if (IsHassCode(e.FormattedValue.ToString(), ContractTypeDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()))
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
        //                Helper.ShowMessageBox("مقدار نام قرارداد را وارد کنید", "خطا در ورود اطلاعات", FarsiLibrary.Win.Enums.FarsiMessageBoxExIcon.Error);
        //                e.Cancel = true;
        //                return;
        //            }
        //        }

        //        if (e.ColumnIndex == 2)
        //        {
        //            if (IsHassWord(e.FormattedValue.ToString(), ContractTypeDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()))
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
        //        foreach (ContractType contractType in contractTypeBindingSource.List)
        //        {
        //            if (contractType.Name == name && contractType.Id != Helper.GetInt(currentID))
        //                return true;
        //        }
        //        return false;

        //    }
        //    catch { }
        //    return false;
        //}
        //public bool IsHassCode(string code, string currentID)
        //{
        //    foreach (ContractType contractType in contractTypeBindingSource.List)
        //    {
        //        if (contractType.Code == Helper.GetInt(code) && contractType.Id != Helper.GetInt(currentID))
        //            return true;
        //    }
        //    return false;
        //}

        //private void cancelBotton_Click(object sender, EventArgs e)
        //{
        //    db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
        //    contractTypeBindingSource.DataSource = db.ContractTypes;
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

        //private void ContractTypeDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        //{
        //    ContractType contractType = (ContractType)contractTypeBindingSource.Current;
        //    int countPersonnelUses = db.Personnels.Count(c => c.ContractTypeId == contractType.Id);

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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            ContractType Current = (ContractType)contractTypeBindingSource.Current;
            if (Current != null)
            {
                if (Helper.Confirm("آیا مایل به حذف اطلاعات هستید؟"))
                {
                    if (db.Personnels.Any(c => c.ContractTypeId == Current.Id))
                    {
                        Helper.ShowMessage("در پرونده پرسنل از این کد استفاده شده پس از ویرایش دوباره سعی نمائید");
                        return;
                    }
                    db.ContractTypes.DeleteOnSubmit(Current);
                    db.SubmitChanges();
                    db = new JamsazERPLiteDataClassesDataContext();
                    contractTypeBindingSource.DataSource = db.ContractTypes.ToList();
                    ContractTypeDataGridView.Refresh();
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddBaseInformationContractTypeDialogForm addBaseInformationContractTypeDialogForm = new AddBaseInformationContractTypeDialogForm()
            {
                FormStatus = FormStatus.Add
            };
            if (addBaseInformationContractTypeDialogForm.ShowDialog() == DialogResult.OK)
            {
                db = new JamsazERPLiteDataClassesDataContext();
                contractTypeBindingSource.DataSource = db.ContractTypes.ToList();
                ContractTypeDataGridView.Refresh();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ContractType Currnet = (ContractType)contractTypeBindingSource.Current;
            if (Currnet != null)
            {

                AddBaseInformationContractTypeDialogForm addBaseInformationContractTypeDialogForm = new AddBaseInformationContractTypeDialogForm()
                {
                    FormStatus = FormStatus.Edit,
                    ContractType = Currnet
                };
                if (addBaseInformationContractTypeDialogForm.ShowDialog() == DialogResult.OK)
                {
                    db = new JamsazERPLiteDataClassesDataContext();
                    contractTypeBindingSource.DataSource = db.ContractTypes.ToList();
                    ContractTypeDataGridView.Refresh();
                }
            }
        }
    }
}
