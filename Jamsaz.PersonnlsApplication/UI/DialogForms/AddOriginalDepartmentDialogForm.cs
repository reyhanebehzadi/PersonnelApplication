using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jamsaz.PersonnlsApplication.BusinessObjects.Definitions;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.Common;

namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class AddOriginalDepartmentDialogForm : BasePersianForm
    {
        public AddOriginalDepartmentDialogForm()
        {
            InitializeComponent();
        }

        public JamsazERPLiteDataClassesDataContext db { get; set; }
        public OriginalDepartment OriginalDepartment { get; set; }
        public FormStatus FormStatus { get; set; }

        private void AddOriginalDepartmentDialogForm_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void voidBbutton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Helper.Confirm("آیا مایل به ذخیره کردن اطلاعات هستید؟") == false)
                return;

            try 
            {
                if (this.FormStatus == FormStatus.Add)
                {
                    
                    db.OriginalDepartments.InsertOnSubmit(this.OriginalDepartment);
                    db.SubmitChanges();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    db.SubmitChanges();
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(string.Format("{0}{1}{2}"
                                                            , "بروز خطا"
                                                            , "\n"
                                                            , ex.Message));
            }
        }


        private void LoadData()
        {
            try
            {
                if (this.FormStatus == FormStatus.Edit)
                {
                    this.OriginalDepartment = db.OriginalDepartments.Single(c => c.ID == this.OriginalDepartment.ID);
                    this.originalDepartmentBindingSource.DataSource = this.OriginalDepartment;
                }
                else
                {
                    this.OriginalDepartment = new OriginalDepartment();
                    this.OriginalDepartment.Code = (db.OriginalDepartments.Count() + 1).ToString();
                    this.originalDepartmentBindingSource.DataSource = this.OriginalDepartment;
                }
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
