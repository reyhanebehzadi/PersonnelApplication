using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Jamsaz.Common;
using System.Linq;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;


namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class departmentEditDialogForm : BasePersianForm
    {

        string mainValueCode = string.Empty;
        public Department SelectDepartment { get; set; }
        ActionForm valueStatusForm;
        int DepartmentVersionID = 0;
        public JamsazERPLiteDataClassesDataContext db { get; set; }
        
        public departmentEditDialogForm(ActionForm statusForm, int DepartmentVersionID)
        {
            InitializeComponent();
            this.GetStatusForm = BasePersianForm.StatusForm.DialogForm;
            //Jamsaz.Common.UserAuthenticationManager.SetAccessContorls.ModifyControl(this);
            valueStatusForm = statusForm;
            this.DepartmentVersionID = DepartmentVersionID;
        }

        public enum ActionForm
        {
            Insert,
            Edit
        }

        private void DepartmentEditDialogForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (valueStatusForm == ActionForm.Edit)
                {
                   
                    Helper.Changelanguage(Helper.Selectlanguage.Farsi);

                    if (!string.IsNullOrEmpty(this.SelectDepartment.Name))
                        nameTextBox.Text = this.SelectDepartment.Name;

                    if (!string.IsNullOrEmpty(this.SelectDepartment.Code))
                    {
                        codeTextBox.Text = this.SelectDepartment.Code;
                        mainValueCode = this.SelectDepartment.Code;
                    }
                    if (!string.IsNullOrEmpty(this.SelectDepartment.Description))
                        descriptionTextBox.Text = this.SelectDepartment.Description;

                    if (!string.IsNullOrEmpty(this.SelectDepartment.NameEn))
                        titleEnTextBox.Text = this.SelectDepartment.NameEn;

                    this.originalDepartmentTextBox.Text = this.SelectDepartment.OriginalDepartmentName;
                }


            }
            catch (Exception exp)
            {
                if (exp.GetType() == typeof(System.Data.SqlClient.SqlException))
                    Helper.ShowMessage("خطا در ارتباط با بانک اطلاعاتی", " اتصال به بانک اطلاعاتی برقرار نیست " + "\n لطفا مشکل را به مسئول شبکه گزارش دهید\n ");
                //  else
                Helper.ShowMessage(exp.Message);
            }

        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            IsDataValid();
            Helper.Changelanguage(Helper.Selectlanguage.Farsi);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Helper.Changelanguage(Helper.Selectlanguage.Farsi);
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// The Name of function is nor correct
        /// </summary>
        /// 

        private void IsDataValid()
        {
            try
            {
                bool hasErrorTitle, hasErrorCode = false;

                if (!nameTextBox.Text.Trim().Equals("") && !nameTextBox.Text.Contains("بدون نام"))
                {
                    this.SelectDepartment.Name = nameTextBox.Text;
                    TitleErrorProvider.Clear();
                    hasErrorTitle = false;
                }
                else
                {
                    TitleErrorProvider.SetError(nameTextBox, "نام واحد سازمانی باید وارد شود");
                    hasErrorTitle = true;
                }

                if (!titleEnTextBox.Text.Trim().Equals(""))
                {
                    this.SelectDepartment.NameEn = titleEnTextBox.Text;
                    TitleErrorProvider.Clear();
                    hasErrorTitle = false;
                }
                else
                {
                    TitleErrorProvider.SetError(titleEnTextBox, "نام واحد سازمانی به انگلیسی را وارد شود");
                    hasErrorTitle = true;
                }

                if (!string.IsNullOrEmpty(codeTextBox.Text))
                {
                    this.SelectDepartment.Code = codeTextBox.Text;
                    CodeErrorProvider.Clear();
                    hasErrorCode = false;
                }
                else
                {
                    CodeErrorProvider.SetError(codeTextBox, "کد واحد سازمانی باید وارد شود");
                    hasErrorCode = true;
                }

                if (valueStatusForm == ActionForm.Insert && codeTextBox.Text != "")
                {
                    if (HasUintCode(codeTextBox.Text, null))
                    {
                        CodeErrorProvider.SetError(codeTextBox, "اين كد در سيستم موجود مي باشد" + "\n لطفا كد ديگري را انتخاب كنيد");
                        hasErrorCode = true;
                        return;
                    }
                    else
                    {
                        hasErrorCode = false;
                        CodeErrorProvider.Clear();
                    }

                }
                ////////////////////////////////////for update /////////////////////////////
                if (valueStatusForm == ActionForm.Edit && codeTextBox.Text != string.Empty && codeTextBox.Text != mainValueCode)
                {
                    if (HasUintCode(codeTextBox.Text, int.Parse(SelectDepartment.Id.ToString())))
                    {
                        CodeErrorProvider.SetError(codeTextBox, "اين كد در سيستم موجود مي باشد" + "\n لطفا كد ديگري را انتخاب كنيد");
                        hasErrorCode = true;
                        return;
                    }
                    else
                    {
                        hasErrorCode = false;
                        CodeErrorProvider.Clear();
                    }

                }


                this.SelectDepartment.Description = descriptionTextBox.Text;

                if ((hasErrorCode == true && hasErrorTitle == true) || (hasErrorCode == true && hasErrorTitle == false) || (hasErrorCode == false && hasErrorTitle == true))
                    return;


                this.DialogResult = DialogResult.OK;
            }
            catch (Exception exp)
            {
                throw exp;
            }

        }

        private bool HasUintCode(string UintCode, int? currentId)
        {
            Jamsaz.PersonnlsApplication.BusinessObjects.Data.JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
            //if (dr["Code"].ToString() == UintCode.ToString()&& int.Parse(dr["ID"].ToString()) != currentId)           
            if (currentId == null)
            {
                if (db.Departments.Count(c => c.Code.Equals(UintCode) && c.DepartmentVersionID == this.DepartmentVersionID) != 0)
                    return true;
            }
            else
                if (db.Departments.Count(c => c.Code.Equals(UintCode) && c.Id != currentId && c.DepartmentVersionID == this.DepartmentVersionID) != 0)
                    return true;
            return false;
        }// field uintcode  check mikone

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                IsDataValid();

            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }

        private void DescriptionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                IsDataValid();
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }

        private void CodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();

            if (e.KeyChar == (char)Keys.Enter)
                IsDataValid();
        }

        private void TitleEnTextBox_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < nameTextBox.Text.Length; i++)
            {
                if (System.Char.IsDigit(nameTextBox.Text, i))
                {
                    nameTextBox.Text = "";
                    TitleErrorProvider.SetError(nameTextBox, "مقدار را از نوع غير عددي وارد كنيد");
                    return;
                }
                else if (TitleErrorProvider.GetError(nameTextBox) == "مقدار را از نوع غير عددي وارد كنيد")
                    TitleErrorProvider.Clear();
            }


        }

        public bool IsNumeric(string s)
        {
            try
            {
                Int32.Parse(s);
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void TitleEnTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                IsDataValid();

            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }

        private void CodeTextBox_Leave(object sender, EventArgs e)
        {
            switch (this.ActiveControl.Name.ToString())
            {
                case "txtName": Helper.Changelanguage(Helper.Selectlanguage.Farsi); break;
                case "txtDesc": Helper.Changelanguage(Helper.Selectlanguage.Farsi); break;
                default: Helper.Changelanguage(Helper.Selectlanguage.English); break;
            }

        }

        private void selectOriginalDepartmentButton_Click(object sender, EventArgs e)
        {
            OriginalDepartmentListDialogForm originalDepartmentListDialogForm = new OriginalDepartmentListDialogForm() { db = db , CurrentDepartmentVersionID = DepartmentVersionID };
            if (originalDepartmentListDialogForm.ShowDialog() == DialogResult.OK)
            {
                this.originalDepartmentTextBox.Text = originalDepartmentListDialogForm.SelectOriginalDepartment.Name;
                this.SelectDepartment.OriginalDepartment = originalDepartmentListDialogForm.SelectOriginalDepartment;
                originalDepartmentListDialogForm.SelectOriginalDepartment.LatestName = this.SelectDepartment.Name;
            }
        }




    }
}