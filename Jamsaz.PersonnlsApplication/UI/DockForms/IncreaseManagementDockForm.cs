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
using Jamsaz.PersonnlsApplication.UI.DialogForms;
using Jamsaz.PersonnlsApplication.UI.ReportForms;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class IncreaseManagementDockForm : BasePersianForm
    {
        public IncreaseManagementDockForm()
        {
            InitializeComponent();
        }

        private JamsazERPLiteDataClassesDataContext db;
        private List<IncreaseManagement> increaseManagementList;
        

        private void IncreaseManagementDockForm_Load(object sender, EventArgs e)
        {
            try
            {
                  LoadData();
                 
            }
            catch (Exception ex)
            {

                ex.ToString();
            }
            
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            AddIncreaseManagementDialogForm addIncreaseManagementDialogForm = new AddIncreaseManagementDialogForm()
            {
                FormStatus = FormStatus.Add
            };

            if (addIncreaseManagementDialogForm.ShowDialog() == DialogResult.OK)
                LoadData();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            IncreaseManagement increaseManagement = (IncreaseManagement)increaseManagementBindingSource.Current;

            if (increaseManagement != null && increaseManagement.Flag != 2)
            {
                if (Helper.Confirm("آیا مایل به حذف اطلاعات هستید؟"))
                {
                    List<IncreaseManagementDetail> list = db.IncreaseManagementDetails.Where(c => c.IncreaseManagementID == increaseManagement.ID).ToList();

                    db.IncreaseManagements.DeleteOnSubmit(increaseManagement);
                    db.IncreaseManagementDetails.DeleteAllOnSubmit(list);
                    db.SubmitChanges();
                    LoadData();
                    getIncreaseManagementDetailResultDataGridView.Refresh();
                }
            }
        }

        private void editToolStripButton_Click(object sender, EventArgs e)
        {
            if (increaseManagementBindingSource.Current != null)
            {
                IncreaseManagement increaseManagement = (IncreaseManagement)increaseManagementBindingSource.Current;

                AddIncreaseManagementDialogForm addIncreaseManagementDialogForm = new AddIncreaseManagementDialogForm()
                {
                    FormStatus = FormStatus.Edit,
                    IncreaseManagement = increaseManagement
                };

                if (addIncreaseManagementDialogForm.ShowDialog() == DialogResult.OK)
                    LoadData();
            }
        }

        private void LoadData()
        {
            db = new JamsazERPLiteDataClassesDataContext();
            try
            {
                increaseManagementList = db.IncreaseManagements.ToList();

                increaseManagementBindingSource.DataSource = increaseManagementList.OrderByDescending(c => Convert.ToInt32(c.Code)).ToList();

            }
            catch { }
        }

        private void increaseManagementBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            IncreaseManagement increaseManagement = (IncreaseManagement)increaseManagementBindingSource.Current;
            if (increaseManagement != null)
            {
                getIncreaseManagementDetailResultBindingSource.DataSource = db.GetIncreaseManagementDetail(increaseManagement.ID);
                getIncreaseManagementDetailResultDataGridView.Refresh();
                if (User.AuthenticationManager.IsActionAvailable(string.Format("{0}-{1}", "IncreaseManagementDockForm", "Apply")))
                {

                    if (increaseManagement.Flag == 2)
                    {
                        editToolStripButton.Enabled = false;
                        applyToolStripButton.Enabled = false;
                        bindingNavigatorDeleteItem.Enabled = false;
                    }
                    else
                    {

                        editToolStripButton.Enabled = true;
                        applyToolStripButton.Enabled = true;
                        bindingNavigatorDeleteItem.Enabled = true;

                    }
                }
            }
        }

        private void increaseManagementBindingSource_PositionChanged(object sender, EventArgs e)
        {
            increaseManagementBindingSource_CurrentChanged(null, null);
        }

        private void applyToolStripButton_Click(object sender, EventArgs e)
        {
           
                IncreaseManagement increaseManagement = (IncreaseManagement)increaseManagementBindingSource.Current;

                if (increaseManagement != null)
                {
                    if (increaseManagement.Flag == 2)
                        return;
                    else
                    {
                        if (Helper.Confirm("آیا مایل به تأیید نهایی می باشد؟"))
                        {


                            foreach (IncreaseManagementDetail increaseManagementDetail in increaseManagement.IncreaseManagementDetails)
                            {
                                if (increaseManagementDetail.IncreaseAmount == null)
                                {
                                    Helper.Error("مقدار افزایش را برای همه پرسنل مشخص نمایید");
                                    return;
                                }

                                List<PayRoll> payRollList = db.PayRolls.Where(c => c.PersonnelID == increaseManagementDetail.Personnel.Id).ToList().ToList();

                                if (payRollList.Count > 0)
                                {
                                    PayRoll lastPayRoll = payRollList.Last();
                                    PayRoll payRoll = new PayRoll()
                                    {
                                        IncreaseManagementDetailID = increaseManagementDetail.ID,
                                        PersonnelID = increaseManagementDetail.PersonnelID.GetValueOrDefault(),
                                        Salary = lastPayRoll.Salary + increaseManagementDetail.IncreaseAmount,
                                        HagheMaskan = lastPayRoll.HagheMaskan,
                                        HagheOlad = lastPayRoll.HagheOlad,
                                        HagheSakhtiKar = lastPayRoll.HagheSakhtiKar,
                                        HagheSarparsti = lastPayRoll.HagheSarparsti,
                                        Haghekharobar = lastPayRoll.Haghekharobar,
                                        ShiftPercent = lastPayRoll.ShiftPercent,
                                        EffectiveDate = increaseManagement.EffectiveDate
                                    };


                                    if (payRoll.ShiftPercent == 0)
                                    {
                                        payRoll.MablagheNobateKari = 0;
                                    }
                                    else
                                    {
                                        payRoll.MablagheNobateKari = Convert.ToInt32(Math.Round((Convert.ToDouble(payRoll.ShiftPercent * payRoll.Salary) / 100)));
                                    }

                                    db.PayRolls.InsertOnSubmit(payRoll);
                                }
                            }
                            increaseManagement.Flag = 2;

                            db.SubmitChanges();

                            LoadData();
                        }
                    
                }
            }
            
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            IncreaseManagement increaseManagement = (IncreaseManagement) increaseManagementBindingSource.Current;
            List<GetIncreaseManagementDetailResult> list = db.GetIncreaseManagementDetail(increaseManagement.ID).ToList();

            if (increaseManagement != null)
            {
                IncreaseManagementReportForm increaseManagementReportForm = new IncreaseManagementReportForm(){IncreaseManagement = increaseManagement,List = list};

                increaseManagementReportForm.ShowDialog();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //foreach (var x in db._94__s)
            //{
            //    PayRoll payRoll = new PayRoll();
            //    payRoll.PersonnelID = db.Personnels.SingleOrDefault(c => c.PersonnelNumber == x.کد_پرسنلي.ToString()).Id;
            //    payRoll.Salary = (int)x.پايه_حقوق_سال_94.GetValueOrDefault();
            //    payRoll.HagheOlad = (int)x.حق_اولاد.GetValueOrDefault();
            //    payRoll.HagheMaskan = (int)x.حق_مسکن.GetValueOrDefault();
            //    payRoll.Haghekharobar = (int)x.هزینه_اقلام_مصرفی.GetValueOrDefault();
            //    payRoll.HagheSarparsti = (int)x.حق_سرپرستي.GetValueOrDefault();
            //    payRoll.HagheSakhtiKar = (int)x.حق_سختي_کار.GetValueOrDefault();
            //    payRoll.MablagheNobateKari = (int)x.مبلغ_نوبتکاري.GetValueOrDefault();
            //    payRoll.ShiftPercent = (int)x.درصد_نوبت_کاري.GetValueOrDefault();
            //    payRoll.EffectiveDate = db.FiscalYears.SingleOrDefault(c => c.Status == 2).StartDate;

            //    db.PayRolls.InsertOnSubmit(payRoll);
               
            //}

            //db.SubmitChanges();
            //Helper.ShowMessage("اطلاعات با موفقیت ثبت شد");
        }

      

    }
}
