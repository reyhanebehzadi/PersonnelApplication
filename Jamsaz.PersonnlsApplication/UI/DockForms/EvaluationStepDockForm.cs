using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.PersonnlsApplication.UI.DialogForms;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class EvaluationStepDockForm : BasePersianForm
    {
        private JamsazERPLiteDataClassesDataContext _db = new JamsazERPLiteDataClassesDataContext();
        public EvaluationStepDockForm()
        {
            InitializeComponent();
        }

        #region Events

        private void newButton_Click(object sender, EventArgs e)
        {
            var defineEvaluationStepDialogForm = new DefineEvaluationStepDialogForm();
            if (defineEvaluationStepDialogForm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var current = (EvaluationStep)evaluationStepBindingSource.Current;
            var defineEvaluationStepDialogForm = new DefineEvaluationStepDialogForm { CurrentId = current.ID };
            if (defineEvaluationStepDialogForm.ShowDialog() != DialogResult.OK) return;
            _db = new JamsazERPLiteDataClassesDataContext();
            LoadData();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var current = (EvaluationStep)evaluationStepBindingSource.Current;
                if (current == null) return;
                var finded = _db.EvaluationSteps.SingleOrDefault(x => x.ID == current.ID);
                if (finded == null) return;
                _db.EvaluationSteps.DeleteOnSubmit(finded);
                _db.SubmitChanges();
                Helper.ShowMessage("حذف شد");
                LoadData();
            }
            catch (DbException ex)
            {
                Helper.ShowMessage( $" خطای دیتابیس  {Environment.NewLine}  شما نمی توانید این رکورد را حذف نمائید {Environment.NewLine} {Environment.NewLine}{ex.Message}" );
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(ex.Message);
            }
        }

        private void EvaluationStepDockForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        #endregion

        #region Methods

        private void LoadData()
        {
            evaluationStepBindingSource.ResetBindings(false);
            evaluationStepBindingSource.DataSource = _db.EvaluationSteps.Where(x=>x.FiscalYearID == User.FiscalYearID).ToList();
        }

        #endregion
    }
}
