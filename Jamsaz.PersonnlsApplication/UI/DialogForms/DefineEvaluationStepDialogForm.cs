using System;
using System.Linq;
using System.Windows.Forms;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;

namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class DefineEvaluationStepDialogForm : BasePersianForm
    {
        private readonly JamsazERPLiteDataClassesDataContext _db = new JamsazERPLiteDataClassesDataContext();
        public int CurrentId = 0;
        public DefineEvaluationStepDialogForm()
        {
            InitializeComponent();
        }

        private void DefineEvaluationStepDialogForm_Load(object sender, System.EventArgs e)
        {
            if (CurrentId > 0)
            {
                var finded = _db.EvaluationSteps.SingleOrDefault(x => x.ID == CurrentId);
                if (finded == null) return;
                nameTextBox.Text = finded.Name;
                startDatePicker.SelectedDateTime = finded.StartDate;
                endDatePicker.SelectedDateTime = finded.EndDate;
            }
            else
            {
                startDatePicker.SelectedDateTime = DateTime.Now;
                endDatePicker.SelectedDateTime = DateTime.Now;
            }
        }

        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nameTextBox.Text))
                {
                    Helper.ShowMessage("لطفا یک عنوان انتخاب نمایید");
                    return;
                }

                if (CurrentId == 0)
                {

                    if (
                        _db.EvaluationSteps.Any(
                            x =>
                                x.StartDate >= startDatePicker.SelectedDateTime &&
                                x.EndDate <= endDatePicker.SelectedDateTime))
                    {
                        Helper.ShowMessage("قبلا برای تاریخ های وارد شده ثبت شده است");
                        return;
                    }

                    _db.EvaluationSteps.InsertOnSubmit(new EvaluationStep
                    {
                        Name = nameTextBox.Text,
                        StartDate = startDatePicker.SelectedDateTime.Value,
                        EndDate = endDatePicker.SelectedDateTime.Value,
                        FiscalYearID = User.FiscalYearID
                    });
                    _db.SubmitChanges();
                    DialogResult = DialogResult.OK;
                    Helper.ShowMessage("ثبت شد");
                    Close();
                }
                else
                {
                    var finded = _db.EvaluationSteps.SingleOrDefault(x => x.ID == CurrentId);
                    if (finded == null) return;
                    finded.Name = nameTextBox.Text;
                    finded.StartDate = startDatePicker.SelectedDateTime.Value;
                    finded.EndDate = endDatePicker.SelectedDateTime.Value;
                    _db.SubmitChanges();
                    DialogResult = DialogResult.OK;
                    Helper.ShowMessage("ذخیره شد");
                    Close();
                }
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(ex.Message);
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
