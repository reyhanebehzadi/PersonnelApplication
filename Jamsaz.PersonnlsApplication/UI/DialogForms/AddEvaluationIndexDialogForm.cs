using System.Windows.Forms;
using Jamsaz.Common;

namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class AddEvaluationIndexDialogForm : BasePersianForm
    {
        public string Code, Title;

        #region Ctor
        public AddEvaluationIndexDialogForm(string code)
        {
            InitializeComponent();
            CodeTextbox.Text = code;
            ActiveControl = TitleTextbox;
        }
        public AddEvaluationIndexDialogForm(string code, string title)
        {
            InitializeComponent();
            CodeTextbox.Text = code;
            TitleTextbox.Text = title;
            ActiveControl = TitleTextbox;
        }
        #endregion

        #region Event
        private void saveButton_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(CodeTextbox.Text) || string.IsNullOrEmpty(TitleTextbox.Text))
            {
                Helper.ShowMessage("لطفا اطلاعات را کامل کنید");
                return;
            }
            Code = CodeTextbox.Text;
            Title = TitleTextbox.Text;
            DialogResult = DialogResult.OK;
        } 
        #endregion
    }
}
