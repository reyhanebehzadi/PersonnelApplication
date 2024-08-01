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

namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class RolesStructureEditDialogForm : BasePersianForm
    {
        ActionForm valueStatusForm;
        string mainValueCode = string.Empty;
        public OrganizationStructure SelectRole { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        int OrganizationStructureVersionID = 0;
        public RolesStructureEditDialogForm(ActionForm actionForm, int OrganizationStructureVersionID)
        {
            InitializeComponent();
            valueStatusForm = actionForm;
            //Jamsaz.Common.UserAuthenticationManager.SetAccessContorls.ModifyControl(this);
            this.GetStatusForm = StatusForm.DialogForm;
            this.OrganizationStructureVersionID = OrganizationStructureVersionID;
            
        }

        private void RolesStructureEditDialogForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (valueStatusForm == ActionForm.Edit)
                {

                    Helper.Changelanguage(Helper.Selectlanguage.Farsi);

                    if (!string.IsNullOrEmpty(this.SelectRole.Name))
                        nameTextBox.Text = this.SelectRole.Name;

                    if (!string.IsNullOrEmpty(this.SelectRole.Code))
                    {
                        codeTextBox.Text = this.SelectRole.Code;
                        mainValueCode = this.SelectRole.Code;
                    }
           
                    if (!string.IsNullOrEmpty(this.SelectRole.NameEn))
                        titleEnTextBox.Text = this.SelectRole.NameEn;
                }
               // this.DataBindings.Add(new Binding("Name", this.ActiveControl?? nameTextBox, "GetActiveControl", false));
            
            }
            catch (Exception exp)
            {
                if (exp.GetType() == typeof(System.Data.SqlClient.SqlException))
                    Helper.ShowMessage("خطا در ارتباط با بانک اطلاعاتی", " اتصال به بانک اطلاعاتی برقرار نیست " + "\n لطفا مشکل را به مسئول شبکه گزارش دهید\n ");
               
                Helper.ShowMessage(exp.Message);
            }
        }

        private void IsDataValid()
        {
            try
            {
                bool hasErrorTitle, hasErrorCode = false;

                if (!nameTextBox.Text.Trim().Equals("") && !nameTextBox.Text.Contains("بدون نام"))
                {
                    this.SelectRole.Name = nameTextBox.Text;
                    TitleErrorProvider.Clear();
                    hasErrorTitle = false;
                }
                else
                {
                    TitleErrorProvider.SetError(nameTextBox, "نام سمت سازمانی باید وارد شود");
                    hasErrorTitle = true;
                }

                if (!titleEnTextBox.Text.Trim().Equals(""))
                {
                    this.SelectRole.NameEn = titleEnTextBox.Text;
                    TitleErrorProvider.Clear();
                    hasErrorTitle = false;
                }
                else
                {
                    TitleErrorProvider.SetError(titleEnTextBox, "نام سمت سازمانی به انگلیسی را وارد شود");
                    hasErrorTitle = true;
                }

                if (!string.IsNullOrEmpty(codeTextBox.Text))
                {
                    this.SelectRole.Code = codeTextBox.Text;
                    CodeErrorProvider.Clear();
                    hasErrorCode = false;
                }
                else
                {
                    CodeErrorProvider.SetError(codeTextBox, "کد سمت سازمانی باید وارد شود");
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
                if (valueStatusForm == ActionForm.Edit && codeTextBox.Text != string.Empty && codeTextBox.Text != mainValueCode )
                {
                    if (HasUintCode(codeTextBox.Text, int.Parse(SelectRole.Id.ToString())))
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


                if ((hasErrorCode == true && hasErrorTitle == true) || (hasErrorCode == true && hasErrorTitle == false) || (hasErrorCode == false && hasErrorTitle == true))
                    return;


                this.DialogResult = DialogResult.OK;
            }
            catch (Exception exp)
            {
                throw exp;
            }

        }

        private bool HasUintCode(string code, int? currentId)
        {
            Jamsaz.PersonnlsApplication.BusinessObjects.Data.JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
            if (currentId == null)
            {
                if (db.OrganizationStructures.Count(c => c.Code.Equals(code)&& c.OrganizationStructureVersionID == this.OrganizationStructureVersionID) != 0 )
                    return true;
            }
            else if (db.OrganizationStructures.Count(c => c.Code.Equals(code) && c.Id != currentId && c.OrganizationStructureVersionID == this.OrganizationStructureVersionID) != 0)
                return true;
            
            return false;
        }// field code  check mikone

        public enum ActionForm
        {
            Insert,
            Edit
        }

        private void confirmbutton_Click(object sender, EventArgs e)
        {
            IsDataValid();
            Helper.Changelanguage(Helper.Selectlanguage.Farsi);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(this.ActiveControl.ToString());
            Helper.Changelanguage(Helper.Selectlanguage.Farsi);
            this.DialogResult = DialogResult.Cancel;
        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                IsDataValid();

            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }

        private void titleEnTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void titleEnTextBox_TextChanged(object sender, EventArgs e)
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
   
        void Notifychanges(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
      
        /* string _activControl;
        [Bindable(true)]
        public string GetActiveControl
        {
            get
            {
                if (this._activControl != null)
                    return null;
               
                switch (this._activControl)
                {
                    case "nameTextBox": Helper.Changelanguage(Helper.Selectlanguage.Farsi); break;
                    default: Helper.Changelanguage(Helper.Selectlanguage.English); break;
                }
                MessageBox.Show("Test");
                Notifychanges("GetActiveControl");
                return _activControl;
            }
            set
            {
                _activControl = value;
            }
        }
        */

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (this.ActiveControl.Name)
            {
                case "titleEnTextBox":
                 
                    if(Helper.IsCurrentLanguage(Helper.Selectlanguage.Farsi))
                    Helper.Changelanguage(Helper.Selectlanguage.English);
                    break;
                default: 
                    if(Helper.IsCurrentLanguage(Helper.Selectlanguage.English))
                    Helper.Changelanguage(Helper.Selectlanguage.Farsi);
                    break;
            }
            
            return base.ProcessCmdKey(ref msg, keyData);
        }
       
    }
}
