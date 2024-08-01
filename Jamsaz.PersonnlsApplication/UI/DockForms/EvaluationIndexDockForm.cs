using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.PersonnlsApplication.UI.DialogForms;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class EvaluationIndexDockForm : BasePersianForm
    {
        private readonly JamsazERPLiteDataClassesDataContext db;

        #region Ctor
        public EvaluationIndexDockForm()
        {
            InitializeComponent();
            db = new JamsazERPLiteDataClassesDataContext();
        } 
        #endregion

        #region Form Load Event
        private void EvaluationIndexDockForm_Load(object sender, EventArgs e)
        {
            try
            {
                var fiscalYears = db.FiscalYears.ToList();
                fiscalYearBindingSource.DataSource = fiscalYears;
                //For Select fiscal Year From Combo box In form Load Auto
                FiscalYearsCombo.SelectedItem =
                    fiscalYears.Find(p => p.StartDate < DateTime.Now && p.EndDate > DateTime.Now);
            }
            catch
            {
                // ignored
            }
        }
        #endregion

        #region Data Source Change Position
        private async void fiscalYearBindingSource_PositionChanged_1(object sender, EventArgs e)
        {
            //Change Categury When Changed fiscalYear
            if (fiscalYearBindingSource.Current == null) return;
            categoriesIndexEvaluationBindingSource.DataSource = await GetAllCategury();
        }
        private async void categoriesIndexEvaluationBindingSource_PositionChanged(object sender, EventArgs e)
        {
            //And Change Details When Changed Categury
            if (categoriesIndexEvaluationBindingSource.Current == null)
            {
                evaluationIndexBindingSource.DataSource = null;
                return;
            }
            evaluationIndexBindingSource.DataSource = await GetAllEvaluation();
        }
        private async Task<List<CategoriesIndexEvaluation>> GetAllCategury()
        {
            try
            {
                return await Task.FromResult(db.CategoriesIndexEvaluations.Where(p => p.FiscalYearID == ((FiscalYear)fiscalYearBindingSource.Current).ID).ToList());
            }
            catch (Exception e)
            {
                throw new Exception(e.InnerException?.Message ?? e.Message);
            }
        }

        private async Task<List<EvaluationIndex>> GetAllEvaluation() //Details
        {
            try
            {
                return await Task.FromResult(db.EvaluationIndexes.Where(p => p.CategoriesIndexEvaluationID == ((CategoriesIndexEvaluation)categoriesIndexEvaluationBindingSource.Current).ID).ToList());
            }
            catch (Exception e)
            {
                throw new Exception(e.InnerException?.Message ?? e.Message);
            }
        }
        #endregion

        #region Method

        #region Categury Method
        private async void AddCateguryButton_Click(object sender, EventArgs e)
        {
            try
            {
                var frmAdd = new AddEvaluationIndexDialogForm((categoriesIndexEvaluationBindingSource.Count + 1).ToString());
                if (frmAdd.ShowDialog() != DialogResult.OK) return;
                db.CategoriesIndexEvaluations.InsertOnSubmit(new CategoriesIndexEvaluation()
                {
                    Code = frmAdd.Code,
                    FiscalYear = FiscalYearsCombo.SelectedItem as FiscalYear,
                    Title = frmAdd.Title,
                });
                db.SubmitChanges();
                categoriesIndexEvaluationBindingSource.DataSource = await GetAllCategury();
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(ex.InnerException?.Message ?? ex.Message);
            }
        }

        private async void EditCateguryButton_Click(object sender, EventArgs e)
        {
            try
            {
                var frmEdit = new AddEvaluationIndexDialogForm(((CategoriesIndexEvaluation)categoriesIndexEvaluationBindingSource.Current).Code, ((CategoriesIndexEvaluation)categoriesIndexEvaluationBindingSource.Current).Title);
                if (frmEdit.ShowDialog() != DialogResult.OK) return;
                var updated = (CategoriesIndexEvaluation)categoriesIndexEvaluationBindingSource.Current;
                updated.Code = frmEdit.Code;
                updated.Title = frmEdit.Title;
                db.SubmitChanges();
                categoriesIndexEvaluationBindingSource.DataSource = await GetAllCategury();
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(ex.InnerException?.Message ?? ex.Message);
            }
        }

        private async void DeleteCateguryButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Helper.Confirm("آیا مطمئن هستید ؟ ")) return;
                var current = (CategoriesIndexEvaluation)categoriesIndexEvaluationBindingSource.Current; //GEt Current
                db.EvaluationIndexes.DeleteAllOnSubmit(current.EvaluationIndexes); //Delete Details
                db.SubmitChanges(); //Save database
                db.CategoriesIndexEvaluations.DeleteOnSubmit(current); // Delete Master
                db.SubmitChanges(); //Save Changes
                categoriesIndexEvaluationBindingSource.DataSource = await GetAllCategury(); //Refresh
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) //Conflicted Delete Error
                    Helper.ShowMessage("امکان حذف وجود ندارد ، از این شاخص استفاده شده است  ");
                else
                    Helper.ShowMessage(ex.InnerException?.Message ?? ex.Message);
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(ex.InnerException?.Message ?? ex.Message);
            }
        }
        #endregion

        #region Details Method
        private async void AddEvaButton_Click(object sender, EventArgs e)
        {
            try
            {
                var frmAdd = new AddEvaluationIndexDialogForm((evaluationIndexBindingSource.Count + 1).ToString());
                if (frmAdd.ShowDialog() != DialogResult.OK) return;
                db.EvaluationIndexes.InsertOnSubmit(new EvaluationIndex()
                {
                    Code = frmAdd.Code,
                    CategoriesIndexEvaluation = categoriesIndexEvaluationBindingSource.Current as CategoriesIndexEvaluation,
                    Title = frmAdd.Title
                });
                db.SubmitChanges();
                evaluationIndexBindingSource.DataSource = await GetAllEvaluation();
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(ex.InnerException?.Message ?? ex.Message);
            }
        }

        private async void EditEvaButton_Click(object sender, EventArgs e)
        {
            try
            {
                var frmEdit = new AddEvaluationIndexDialogForm(((EvaluationIndex)evaluationIndexBindingSource.Current).Code, ((EvaluationIndex)evaluationIndexBindingSource.Current).Title);
                if (frmEdit.ShowDialog() != DialogResult.OK) return;
                var updated = (EvaluationIndex)evaluationIndexBindingSource.Current;
                updated.Code = frmEdit.Code;
                updated.Title = frmEdit.Title;
                db.SubmitChanges();
                evaluationIndexBindingSource.DataSource = await GetAllEvaluation();
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(ex.InnerException?.Message ?? ex.Message);
            }

        }

        private async void DeleteEvaButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Helper.Confirm("آیا مطمئن هستید ؟ ")) return;
                var deleted = evaluationIndexBindingSource.Current as EvaluationIndex;
                if (deleted == null) return;
                db.EvaluationIndexes.DeleteOnSubmit(deleted);
                db.SubmitChanges();
                evaluationIndexBindingSource.DataSource = await GetAllEvaluation();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) //Conflicted Delete Error
                    Helper.ShowMessage("امکان حذف وجود ندارد ، از این شاخص استفاده شده است  ");
                else
                    Helper.ShowMessage(ex.InnerException?.Message ?? ex.Message);
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(ex.InnerException?.Message ?? ex.Message);
            }

        }  
        #endregion
       
        #endregion

    }
}
