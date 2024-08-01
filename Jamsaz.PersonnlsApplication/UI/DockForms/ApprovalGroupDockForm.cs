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
using Jamsaz.PersonnlsApplication.UI.DialogForms;
using Jamsaz.PersonnlsApplication.BusinessObjects.Definitions;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class ApprovalGroupDockForm : BasePersianForm
    {
        public ApprovalGroupDockForm()
        {
            InitializeComponent();
        }
        private int PersonnelID;
        private JamsazERPLiteDataClassesDataContext db;
        private List<ApprovalGroupDetail> ApprovalGroupDetails = new List<ApprovalGroupDetail>();
        DataGridViewRow row;
        ApprovalGroup Selected;
        private void ApprovalGroupDockForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            AddApprovalGroupDialogForm addApprovalGroupDialogForm = new AddApprovalGroupDialogForm()
            {
                FormStatus = FormStatus.Add
            };

            if (addApprovalGroupDialogForm.ShowDialog() == DialogResult.OK)
                LoadData();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ApprovalGroup current = (ApprovalGroup)approvalGroupBindingSource.Current;
            if (current != null)
            {
                AddApprovalGroupDialogForm addApprovalGroupDialogForm = new AddApprovalGroupDialogForm()
                {
                    ApprovalGroup = current,
                    FormStatus = FormStatus.Edit
                };

                if (addApprovalGroupDialogForm.ShowDialog() == DialogResult.OK)
                    LoadData();
            }

        }

        private void LoadData()
        {
            db = new JamsazERPLiteDataClassesDataContext();
            approvalGroupBindingSource.DataSource = db.ApprovalGroups;
        }

        private void approvalGroupBindingSource_PositionChanged(object sender, EventArgs e)
        {
            ApprovalGroup current = (ApprovalGroup)approvalGroupBindingSource.Current;
            if (current != null)
            {
                approvalGroupDetailBindingSource.DataSource = current.ApprovalGroupDetails.Count > 0 ? current.ApprovalGroupDetails.OrderBy(c => c.Order) : null;
                approvalGroupPersonnelBindingSource.DataSource = current.ApprovalGroupPersonnels.Count > 0 ? current.ApprovalGroupPersonnels : null;
                ApprovalGroupDetails = current.ApprovalGroupDetails.ToList();
            }
        }

        private void addApprovalGroupDetailButton_Click(object sender, EventArgs e)
        {
            ApprovalGroup currentGroup = (ApprovalGroup)approvalGroupBindingSource.Current;
            if (currentGroup == null)
                return;


            AddMissionAndLeaveDialogForm addMissionAndLeaveDialogForm = new AddMissionAndLeaveDialogForm() { FormStatus = FormStatus.Add };
            if (addMissionAndLeaveDialogForm.ShowDialog() == DialogResult.OK)
            {
                if (this.ApprovalGroupDetails.Exists(c => c.PersonnelID == addMissionAndLeaveDialogForm.Personnel.Id))
                {
                    Helper.ShowMessage("پرسنل انتخابی در حال حاضر در لیست وجود دارد");
                    return;
                }

                ApprovalGroupDetail approvalGroupDetail = new ApprovalGroupDetail();

                if (addMissionAndLeaveDialogForm.Personnel != null)
                    approvalGroupDetail.PersonnelID = addMissionAndLeaveDialogForm.Personnel.Id;

                if (addMissionAndLeaveDialogForm.ReplacementPersonnel != null)
                    approvalGroupDetail.ReplacementPersonnelID = addMissionAndLeaveDialogForm.ReplacementPersonnel.Id;

                if (addMissionAndLeaveDialogForm.ReplacementPersonnel2 != null)
                    approvalGroupDetail.ReplacementPersonnelID2 = addMissionAndLeaveDialogForm.ReplacementPersonnel2.Id;

                approvalGroupDetail.IsNew = true;
                approvalGroupDetail.ApprovalGroup = currentGroup;

                if (this.ApprovalGroupDetails.Count != 0)
                    approvalGroupDetail.Order = this.ApprovalGroupDetails.Max(c => c.Order) + 1;
                else
                    approvalGroupDetail.Order = 1;
                this.ApprovalGroupDetails.Add(approvalGroupDetail);
                this.approvalGroupDetailBindingSource.DataSource = this.ApprovalGroupDetails.OrderBy(c => c.Order);

                //-----------------

                Save();
                //---------------------

            }
            
            //this.saveButton.Enabled = true;
        }

        private void editApprovalGroupDetailButton_Click(object sender, EventArgs e)
        {
            ApprovalGroupDetail current = (ApprovalGroupDetail)this.approvalGroupDetailBindingSource.Current;
            if (current == null || current.ID == 0)
                return;


            ApprovalGroupDetail[] except = new ApprovalGroupDetail[] { current };
            AddApprovalGroupDetailDialogForm addApprovalGroupDetailDialogForm = new AddApprovalGroupDetailDialogForm() { FormStatus = FormStatus.Edit, ApprovalGroupDetail = current };
            if (addApprovalGroupDetailDialogForm.ShowDialog() == DialogResult.OK)
            {

                if (this.ApprovalGroupDetails.Except(except).Where(c => c.PersonnelID == addApprovalGroupDetailDialogForm.Personnel.Id).Count() > 0)
                {
                    Helper.ShowMessage("پرسنل انتخابی در حال حاضر در لیست وجود دارد");
                    return;
                }

                current.Personnel = db.Personnels.SingleOrDefault(c => c.Id == addApprovalGroupDetailDialogForm.Personnel.Id);
                current.Personnel1 = addApprovalGroupDetailDialogForm.ReplacementPersonnel != null ? db.Personnels.SingleOrDefault(c => c.Id == addApprovalGroupDetailDialogForm.ReplacementPersonnel.Id) : null;
                current.Personnel2 = addApprovalGroupDetailDialogForm.ReplacementPersonnel2 != null ? db.Personnels.SingleOrDefault(c => c.Id == addApprovalGroupDetailDialogForm.ReplacementPersonnel2.Id) : null;

                this.approvalGroupDetailBindingSource.DataSource = this.ApprovalGroupDetails.OrderBy(c => c.Order);

                //-----------------

                Save();
                //---------------------
                //this.saveButton.Enabled = true;

            }
        }

        private void deleteApprovalGroupDetailButton_Click(object sender, EventArgs e)
        {
            ApprovalGroupDetail current = (ApprovalGroupDetail)this.approvalGroupDetailBindingSource.Current;
            if (current == null)
                return;

            if (Helper.Confirm("آیا مایل به حذف رکورد انتخاب شده هستید؟") == false)
                return;

            int currentOrder = current.Order;

            try
            {
                if (current.ID != 0)
                {
                    db.ApprovalGroupDetails.DeleteOnSubmit(current);
                    this.ApprovalGroupDetails.Remove(current);
                }

                else
                    this.ApprovalGroupDetails.Remove(current);


                approvalGroupDetailBindingSource.DataSource = ApprovalGroupDetails;

                foreach (ApprovalGroupDetail item in this.ApprovalGroupDetails.Where(c => c.Order > currentOrder))
                {
                    item.Order = item.Order - 1;

                }
                this.approvalGroupDetailBindingSource.DataSource = this.ApprovalGroupDetails.Count > 0 ? this.ApprovalGroupDetails.OrderBy(c => c.Order) : null;
                //this.saveButton.Enabled = true;
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

        private void topButton_Click(object sender, EventArgs e)
        {
            ApprovalGroupDetail current = (ApprovalGroupDetail)this.approvalGroupDetailBindingSource.Current;
            if (current == null)
                return;

            ApprovalGroupDetail[] except = new ApprovalGroupDetail[] { current };

            int currentOrder = current.Order;

            current.Order = 1;

            foreach (ApprovalGroupDetail item in this.ApprovalGroupDetails.Except(except).Where(c => c.Order < currentOrder))
            {
                item.Order = item.Order + 1;

            }
            this.approvalGroupDetailBindingSource.DataSource = this.ApprovalGroupDetails.OrderBy(c => c.Order);

            Save();
            //this.saveButton.Enabled = true;
        }

        private void upperButton_Click(object sender, EventArgs e)
        {
            ApprovalGroupDetail current = (ApprovalGroupDetail)this.approvalGroupDetailBindingSource.Current;
            if (current == null)
                return;

            if (current.Order == 1)
                return;


            this.ApprovalGroupDetails.Single(c => c.Order == current.Order - 1).Order = current.Order;
            current.Order--;
            this.approvalGroupDetailBindingSource.DataSource = this.ApprovalGroupDetails.OrderBy(c => c.Order);

            Save();
            //this.saveButton.Enabled = true;
        }

        private void lowerbutton_Click(object sender, EventArgs e)
        {
            ApprovalGroupDetail current = (ApprovalGroupDetail)this.approvalGroupDetailBindingSource.Current;
            if (current == null)
                return;

            if (current.Order == this.ApprovalGroupDetails.Max(c => c.Order))
                return;

            this.ApprovalGroupDetails.Single(c => c.Order == current.Order + 1).Order = current.Order;
            current.Order++;
            this.approvalGroupDetailBindingSource.DataSource = this.ApprovalGroupDetails.OrderBy(c => c.Order);

            Save();
            //this.saveButton.Enabled = true;
        }

        private void lowestButton_Click(object sender, EventArgs e)
        {
            ApprovalGroupDetail current = (ApprovalGroupDetail)this.approvalGroupDetailBindingSource.Current;
            if (current == null)
                return;

            ApprovalGroupDetail[] except = new ApprovalGroupDetail[] { current };

            int currentOrder = current.Order;

            current.Order = this.ApprovalGroupDetails.Max(c => c.Order);

            foreach (ApprovalGroupDetail item in this.ApprovalGroupDetails.Except(except).Where(c => c.Order > currentOrder))
            {
                item.Order = item.Order - 1;

            }
            this.approvalGroupDetailBindingSource.DataSource = this.ApprovalGroupDetails.OrderBy(c => c.Order);

            Save();
            //this.saveButton.Enabled = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //try
            //{

            //    foreach (ApprovalGroupDetail item in this.ApprovalGroupDetails)
            //    {
            //        if (item.IsNew)
            //        {
            //            db.ApprovalGroupDetails.InsertOnSubmit(item);
            //            item.IsNew = false;
            //        }
            //    }

            //    db.SubmitChanges();
            //    Helper.ShowMessage("تغییرات ثبت شد");
            //    this.saveButton.Enabled = false;



            //}
            //catch (Exception ex)
            //{
            //    Helper.ShowMessage(string.Format("{0}{1}{2}"
            //                                                , "بروز خطا"
            //                                                , "\n"
            //                                                , ex.Message));
            //}
        }

        private void addPersonnelButton_Click(object sender, EventArgs e)
        {
            ApprovalGroup group = (ApprovalGroup)approvalGroupBindingSource.Current;
            if (group != null)
            {
                ApprovalGroupPersonnelDialogForm approvalGroupPersonnelDialogForm = new ApprovalGroupPersonnelDialogForm() ;
                approvalGroupPersonnelDialogForm.ShowDialog();
                if (approvalGroupPersonnelDialogForm.personnels != null)
                {
                    foreach (Personnel item in approvalGroupPersonnelDialogForm.personnels)
                    {
                        ApprovalGroupPersonnel personnel = new ApprovalGroupPersonnel()
                        {
                            Personnel = db.Personnels.SingleOrDefault(c=>c.Id== item.Id),
                            ApprovalGroup = group
                        };
                        db.ApprovalGroupPersonnels.InsertOnSubmit(personnel);
                    }
                    db.SubmitChanges();
                    LoadData();
                    approvalGroupBindingSource_PositionChanged(null, null);
                }
            }

        }

        private void deletePersonnelButton_Click(object sender, EventArgs e)
        {
            ApprovalGroupPersonnel current = (ApprovalGroupPersonnel)approvalGroupPersonnelBindingSource.Current;
            if (current != null)
                if(Helper.Confirm("آیا مایل به حذف پرسنل مورد نظر هستید؟"))
            {
                    db.ApprovalGroupPersonnels.DeleteOnSubmit(current);
                    db.SubmitChanges();
                    LoadData();
                    approvalGroupBindingSource_PositionChanged(null,null);
            }
           
        }


        public void Save()
        {
            foreach (ApprovalGroupDetail item in this.ApprovalGroupDetails)
            {
                if (item.IsNew)
                {
                    db.ApprovalGroupDetails.InsertOnSubmit(item);
                    item.IsNew = false;
                }
            }

            db.SubmitChanges();
        }

        private void selectPersonnelButton_Click(object sender, EventArgs e)
        {
            PersonnelListForm personnelListForm = new PersonnelListForm(db = db) { IsActive = false };
            if (personnelListForm.ShowDialog() == DialogResult.OK)
            {
                PersonnelID = personnelListForm.Personnel.Id;
                personnelNameTextBox.Text = string.Format("{0} {1}", personnelListForm.Personnel.FirstName, personnelListForm.Personnel.LastName);
            }

           
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            if (PersonnelID > 0)
            {
                Selected = db.ApprovalGroupPersonnels.FirstOrDefault(c => c.PersonnelID == PersonnelID)?.ApprovalGroup;

                if (Selected != null)
                {


                    foreach (DataGridViewRow item in approvalGroupDataGridView.Rows)
                    {
                        if (Convert.ToInt32(item.Cells[0].Value) == Selected.Code)
                        {
                            row = item;
                        }

                    }

                    approvalGroupDataGridView.ClearSelection();
                    approvalGroupDataGridView.Rows[row.Index].Selected = true;
                    approvalGroupDetailBindingSource.DataSource = Selected.ApprovalGroupDetails;
                    approvalGroupPersonnelBindingSource.DataSource = Selected.ApprovalGroupPersonnels;
                }
            }
        }
    }
}
