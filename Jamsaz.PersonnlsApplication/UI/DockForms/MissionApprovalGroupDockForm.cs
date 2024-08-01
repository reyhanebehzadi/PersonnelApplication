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
using Jamsaz.PersonnlsApplication.BusinessObjects.Definitions;
using Jamsaz.PersonnlsApplication.UI.DialogForms;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class MissionApprovalGroupDockForm : BasePersianForm
    {
        public MissionApprovalGroupDockForm()
        {
            InitializeComponent();
        }
        private JamsazERPLiteDataClassesDataContext db;
        private List<MissionApprovalGroupDetail> MissionApprovalGroupDetails = new List<MissionApprovalGroupDetail>();
        private void addButton_Click(object sender, EventArgs e)
        {
            AddMissionApprovalGroupDialogForm addMissionApprovalGroupDialogForm = new AddMissionApprovalGroupDialogForm()
            {
                FormStatus = FormStatus.Add
            };

            if (addMissionApprovalGroupDialogForm.ShowDialog() == DialogResult.OK)
                LoadData();
        }

        private void LoadData()
        {
            db = new JamsazERPLiteDataClassesDataContext();
            missionApprovalGroupBindingSource.DataSource = db.MissionApprovalGroups;
        }

        private void MissionApprovalGroupDockForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            MissionApprovalGroup current = (MissionApprovalGroup)missionApprovalGroupBindingSource.Current;
            if (current != null)
            {
                AddMissionApprovalGroupDialogForm addMissionApprovalGroupDialogForm = new AddMissionApprovalGroupDialogForm()
                {
                    MissionApprovalGroup = current,
                    FormStatus = FormStatus.Edit
                };

                if (addMissionApprovalGroupDialogForm.ShowDialog() == DialogResult.OK)
                    LoadData();
            }
        }

        private void addApprovalGroupDetailButton_Click(object sender, EventArgs e)
        {
            MissionApprovalGroup currentGroup = (MissionApprovalGroup)missionApprovalGroupBindingSource.Current;
            if (currentGroup == null)
                return;


            AddMissionAndLeaveDialogForm addMissionAndLeaveDialogForm = new AddMissionAndLeaveDialogForm() { FormStatus = FormStatus.Add };
            if (addMissionAndLeaveDialogForm.ShowDialog() == DialogResult.OK)
            {
                if (this.MissionApprovalGroupDetails.Exists(c => c.PersonnelID == addMissionAndLeaveDialogForm.Personnel.Id))
                {
                    Helper.ShowMessage("پرسنل انتخابی در حال حاضر در لیست وجود دارد");
                    return;
                }

                MissionApprovalGroupDetail missionApprovalGroupDetail = new MissionApprovalGroupDetail();

                if (addMissionAndLeaveDialogForm.Personnel != null)
                    missionApprovalGroupDetail.PersonnelID = addMissionAndLeaveDialogForm.Personnel.Id;

                if (addMissionAndLeaveDialogForm.ReplacementPersonnel != null)
                    missionApprovalGroupDetail.ReplacementPersonnelID = addMissionAndLeaveDialogForm.ReplacementPersonnel.Id;

                if (addMissionAndLeaveDialogForm.ReplacementPersonnel2 != null)
                    missionApprovalGroupDetail.ReplacementPersonnelID2 = addMissionAndLeaveDialogForm.ReplacementPersonnel2.Id;

                missionApprovalGroupDetail.IsNew = true;
                missionApprovalGroupDetail.MissionApprovalGroup = currentGroup;

                if (this.MissionApprovalGroupDetails.Count != 0)
                    missionApprovalGroupDetail.Order = this.MissionApprovalGroupDetails.Max(c => c.Order) + 1;
                else
                    missionApprovalGroupDetail.Order = 1;
                this.MissionApprovalGroupDetails.Add(missionApprovalGroupDetail);
                this.missionApprovalGroupDetailBindingSource.DataSource = this.MissionApprovalGroupDetails.OrderBy(c => c.Order);

            }


            this.saveButton.Enabled = true;
        }

        private void editApprovalGroupDetailButton_Click(object sender, EventArgs e)
        {
            MissionApprovalGroupDetail current = (MissionApprovalGroupDetail)this.missionApprovalGroupDetailBindingSource.Current;
            if (current == null || current.ID == 0)
                return;


            MissionApprovalGroupDetail[] except = new MissionApprovalGroupDetail[] { current };
            AddApprovalGroupDetailDialogForm addApprovalGroupDetailDialogForm = new AddApprovalGroupDetailDialogForm() { FormStatus = FormStatus.Edit, MissionApprovalGroupDetail = current ,Mission = true};
            if (addApprovalGroupDetailDialogForm.ShowDialog() == DialogResult.OK)
            {

                if (this.MissionApprovalGroupDetails.Except(except).Where(c => c.PersonnelID == addApprovalGroupDetailDialogForm.Personnel.Id).Count() > 0)
                {
                    Helper.ShowMessage("پرسنل انتخابی در حال حاضر در لیست وجود دارد");
                    return;
                }

                current.Personnel = db.Personnels.SingleOrDefault(c => c.Id == addApprovalGroupDetailDialogForm.Personnel.Id);
                current.Personnel1 = addApprovalGroupDetailDialogForm.ReplacementPersonnel != null ? db.Personnels.SingleOrDefault(c => c.Id == addApprovalGroupDetailDialogForm.ReplacementPersonnel.Id) : null;
                current.Personnel2 = addApprovalGroupDetailDialogForm.ReplacementPersonnel2 != null ? db.Personnels.SingleOrDefault(c => c.Id == addApprovalGroupDetailDialogForm.ReplacementPersonnel2.Id) : null;

                this.missionApprovalGroupDetailBindingSource.DataSource = this.MissionApprovalGroupDetails.OrderBy(c => c.Order);


                this.saveButton.Enabled = true;

            }
        }

        private void deleteApprovalGroupDetailButton_Click(object sender, EventArgs e)
        {
            MissionApprovalGroupDetail current = (MissionApprovalGroupDetail)this.missionApprovalGroupDetailBindingSource.Current;
            if (current == null)
                return;

            if (Helper.Confirm("آیا مایل به حذف رکورد انتخاب شده هستید؟") == false)
                return;

            int currentOrder = current.Order;

            try
            {
                if (current.ID != 0)
                {
                    db.MissionApprovalGroupDetails.DeleteOnSubmit(current);
                    this.MissionApprovalGroupDetails.Remove(current);
                }

                else
                    this.MissionApprovalGroupDetails.Remove(current);


                missionApprovalGroupDetailBindingSource.DataSource = MissionApprovalGroupDetails;

                foreach (MissionApprovalGroupDetail item in this.MissionApprovalGroupDetails.Where(c => c.Order > currentOrder))
                {
                    item.Order = item.Order - 1;

                }
                this.missionApprovalGroupDetailBindingSource.DataSource = this.MissionApprovalGroupDetails.Count > 0 ? this.MissionApprovalGroupDetails.OrderBy(c => c.Order) : null;
                this.saveButton.Enabled = true;


            }
            catch (Exception ex)
            {
                Helper.ShowMessage(string.Format("{0}{1}{2}"
                                                            , "بروز خطا"
                                                            , "\n"
                                                            , ex.Message));
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (MissionApprovalGroupDetail item in this.MissionApprovalGroupDetails)
                {
                    if (item.IsNew)
                    {
                        db.MissionApprovalGroupDetails.InsertOnSubmit(item);
                        item.IsNew = false;
                    }
                }

                db.SubmitChanges();
                Helper.ShowMessage("تغییرات ثبت شد");
                this.saveButton.Enabled = false;



            }
            catch (Exception ex)
            {
                Helper.ShowMessage(string.Format("{0}{1}{2}"
                                                            , "بروز خطا"
                                                            , "\n"
                                                            , ex.Message));
            }
        }

        private void missionApprovalGroupBindingSource_PositionChanged(object sender, EventArgs e)
        {
            MissionApprovalGroup current = (MissionApprovalGroup)missionApprovalGroupBindingSource.Current;
            if (current != null)
            {
                missionApprovalGroupDetailBindingSource.DataSource = current.MissionApprovalGroupDetails.Count > 0 ? current.MissionApprovalGroupDetails.OrderBy(c => c.Order) : null;
                missionApprovalGroupPersonnelBindingSource.DataSource = current.MissionApprovalGroupPersonnels.Count > 0 ? current.MissionApprovalGroupPersonnels : null;
                MissionApprovalGroupDetails = current.MissionApprovalGroupDetails.ToList();
            }
        }

        private void topButton_Click(object sender, EventArgs e)
        {
            MissionApprovalGroupDetail current = (MissionApprovalGroupDetail)this.missionApprovalGroupDetailBindingSource.Current;
            if (current == null)
                return;

            MissionApprovalGroupDetail[] except = new MissionApprovalGroupDetail[] { current };

            int currentOrder = current.Order;

            current.Order = 1;

            foreach (MissionApprovalGroupDetail item in this.MissionApprovalGroupDetails.Except(except).Where(c => c.Order < currentOrder))
            {
                item.Order = item.Order + 1;

            }
            this.missionApprovalGroupDetailBindingSource.DataSource = this.MissionApprovalGroupDetails.OrderBy(c => c.Order);
            this.saveButton.Enabled = true;
        }

        private void upperButton_Click(object sender, EventArgs e)
        {
            MissionApprovalGroupDetail current = (MissionApprovalGroupDetail)this.missionApprovalGroupDetailBindingSource.Current;
            if (current == null)
                return;

            if (current.Order == 1)
                return;


            this.MissionApprovalGroupDetails.Single(c => c.Order == current.Order - 1).Order = current.Order;
            current.Order--;
            this.missionApprovalGroupDetailBindingSource.DataSource = this.MissionApprovalGroupDetails.OrderBy(c => c.Order);
            this.saveButton.Enabled = true;
        }

        private void lowerbutton_Click(object sender, EventArgs e)
        {
            MissionApprovalGroupDetail current = (MissionApprovalGroupDetail)this.missionApprovalGroupDetailBindingSource.Current;
            if (current == null)
                return;

            if (current.Order == this.MissionApprovalGroupDetails.Max(c => c.Order))
                return;

            this.MissionApprovalGroupDetails.Single(c => c.Order == current.Order + 1).Order = current.Order;
            current.Order++;
            this.missionApprovalGroupDetailBindingSource.DataSource = this.MissionApprovalGroupDetails.OrderBy(c => c.Order);
            this.saveButton.Enabled = true;
        }

        private void lowestButton_Click(object sender, EventArgs e)
        {
            MissionApprovalGroupDetail current = (MissionApprovalGroupDetail)this.missionApprovalGroupDetailBindingSource.Current;
            if (current == null)
                return;

            MissionApprovalGroupDetail[] except = new MissionApprovalGroupDetail[] { current };

            int currentOrder = current.Order;

            current.Order = this.MissionApprovalGroupDetails.Max(c => c.Order);

            foreach (MissionApprovalGroupDetail item in this.MissionApprovalGroupDetails.Except(except).Where(c => c.Order > currentOrder))
            {
                item.Order = item.Order - 1;

            }
            this.missionApprovalGroupDetailBindingSource.DataSource = this.MissionApprovalGroupDetails.OrderBy(c => c.Order);
            this.saveButton.Enabled = true;
        }

        private void addPersonnelButton_Click(object sender, EventArgs e)
        {
            MissionApprovalGroup group = (MissionApprovalGroup)missionApprovalGroupBindingSource.Current;
            if (group != null)
            {
                ApprovalGroupPersonnelDialogForm approvalGroupPersonnelDialogForm = new ApprovalGroupPersonnelDialogForm() { Mission = true};
                approvalGroupPersonnelDialogForm.ShowDialog();
                if (approvalGroupPersonnelDialogForm.personnels != null)
                {
                    foreach (Personnel item in approvalGroupPersonnelDialogForm.personnels)
                    {
                        MissionApprovalGroupPersonnel personnel = new MissionApprovalGroupPersonnel()
                        {
                            Personnel = db.Personnels.SingleOrDefault(c => c.Id == item.Id),
                            MissionApprovalGroup = group
                        };
                        db.MissionApprovalGroupPersonnels.InsertOnSubmit(personnel);
                    }
                    db.SubmitChanges();
                    LoadData();
                    missionApprovalGroupBindingSource_PositionChanged(null, null);
                }
            }

        }

        private void deletePersonnelButton_Click(object sender, EventArgs e)
        {
            MissionApprovalGroupPersonnel current = (MissionApprovalGroupPersonnel)missionApprovalGroupPersonnelBindingSource.Current;
            if (current != null)
                if (Helper.Confirm("آیا مایل به حذف پرسنل مورد نظر هستید؟"))
                {
                    db.MissionApprovalGroupPersonnels.DeleteOnSubmit(current);
                    db.SubmitChanges();
                    LoadData();
                    missionApprovalGroupBindingSource_PositionChanged(null, null);
                }
        }
    }
}
