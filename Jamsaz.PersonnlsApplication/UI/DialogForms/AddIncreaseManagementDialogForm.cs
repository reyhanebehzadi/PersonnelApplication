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
using Jamsaz.PersonnlsApplication.BusinessObjects.Definitions;

namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class AddIncreaseManagementDialogForm : BasePersianForm
    {
        public AddIncreaseManagementDialogForm()
        {
            InitializeComponent();
        }

        public BusinessObjects.Definitions.FormStatus FormStatus { get; set; }
        public BusinessObjects.Data.IncreaseManagement IncreaseManagement { get; set; }
        private JamsazERPLiteDataClassesDataContext db;

        private string GetCode()
        {
            string code = "0";

            if (db.IncreaseManagements.Count() > 0)
                code = (db.IncreaseManagements.Max(c => Convert.ToInt32(c.Code)) + 1).ToString();
            else
                code = "1";

            return code;
        }

        private void AddIncreaseManagementDialogForm_Load(object sender, EventArgs e)
        {
            try
            {
                db = new JamsazERPLiteDataClassesDataContext();

                if (FormStatus == FormStatus.Add)
                {
                    this.IncreaseManagement = new IncreaseManagement()
                    {
                        //FiscalYearID = UserInfo.FiscalYearID,
                        EffectiveDate = DateTime.Now,
                        Code = GetCode(),
                        Flag = 1
                    };

                    this.increaseManagementBindingSource.DataSource = this.IncreaseManagement;
                }
                else if (FormStatus == FormStatus.Edit)
                {
                    this.IncreaseManagement = db.IncreaseManagements.Single(c => c.ID == this.IncreaseManagement.ID);

                    this.increaseManagementBindingSource.DataSource = this.IncreaseManagement;
                    this.increaseManagementDetailsBindingSource.DataSource =
                        db.IncreaseManagementDetails.Where(c => c.IncreaseManagementID == this.IncreaseManagement.ID)
                            .OrderBy(d => Convert.ToInt32(d.Personnel.PersonnelNumber));
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //List<Personnel> addedPersonnelList = new List<Personnel>();

            //foreach (IncreaseManagementDetail increaseManagementDetail in increaseManagementDetailsBindingSource.List)
            //{
            //    addedPersonnelList.Add(increaseManagementDetail.Personnel);
            //}
            //{AddedPersonnelList = addedPersonnelList}

            SelectPersonnelListDialogForm personnelListDialogForm = new SelectPersonnelListDialogForm();

            if (personnelListDialogForm.ShowDialog() == DialogResult.OK)
            {
                foreach (Personnel personnel in personnelListDialogForm.Personnels)
                {
                    if (!((increaseManagementDetailsBindingSource.List as IList<IncreaseManagementDetail>).Any(c => c.PersonnelID == personnel.Id)))
                    {
                        IncreaseManagementDetail increaseManagementDetail = new IncreaseManagementDetail();
                        increaseManagementDetail.Personnel = db.Personnels.SingleOrDefault(c => c.Id == personnel.Id);
                        increaseManagementDetail.IncreaseAmount = personnelListDialogForm.increaseAmount;
                         List<PayRoll> payRollList = db.PayRolls.Where(c => c.PersonnelID == personnel.Id).ToList().ToList();
                    if(payRollList.Count >0)
                       increaseManagementDetail.PayeGhabli = payRollList.Last().Salary.GetValueOrDefault();

                        increaseManagementDetailsBindingSource.Add(increaseManagementDetail);
                    }
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            IncreaseManagementDetail increaseManagementDetail = (IncreaseManagementDetail)increaseManagementDetailsBindingSource.Current;

            if (increaseManagementDetail != null)
            {
                if (Helper.Confirm("آیا مایل به حذف سطر جاری هستید؟"))
                {
                    if (increaseManagementDetail.ID == 0)
                    {
                        increaseManagementDetailsBindingSource.Remove(increaseManagementDetail);
                        increaseManagementDetailsDataGridView.Refresh();
                    }
                    else
                    {
                        increaseManagementDetailsBindingSource.Remove(increaseManagementDetail);
                        increaseManagementDetailsDataGridView.Refresh();
                        db.IncreaseManagementDetails.DeleteOnSubmit(increaseManagementDetail);
                    }
                }
            }
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            if (this.FormStatus == FormStatus.Add)
            {
                db.IncreaseManagements.InsertOnSubmit(this.IncreaseManagement);

                foreach (IncreaseManagementDetail increaseManagementDetail in this.increaseManagementDetailsBindingSource.List)
                {
                    //if (increaseManagementDetail.IncreaseAmount == null)
                    //{
                    //    Helper.Error("مقدار افزایش را برای همه پرسنل مشخص کنید");
                    //    return;
                    //}

                    increaseManagementDetail.IncreaseManagement = this.IncreaseManagement;
                    db.IncreaseManagementDetails.InsertOnSubmit(increaseManagementDetail);
                }
            }
            else
            {
                foreach (IncreaseManagementDetail increaseManagementDetail in this.increaseManagementDetailsBindingSource.List)
                {
                    if (increaseManagementDetail.IncreaseAmount == null)
                    {
                        Helper.Error("مقدار افزایش را برای همه پرسنل مشخص کنید");
                        return;
                    }

                    if (increaseManagementDetail.ID == 0)
                    {
                        increaseManagementDetail.IncreaseManagement = this.IncreaseManagement;
                        db.IncreaseManagementDetails.InsertOnSubmit(increaseManagementDetail);
                       
                    }
                  
                }
            }

            db.SubmitChanges();
            Helper.ShowMessage("اطلاعات ثبت شد");
            this.DialogResult = DialogResult.OK;
        }

        private void voidBbutton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }




    }
}
