using System.Linq;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class GetPersonelSubEmployeeDockForm : BasePersianForm
    {
        private readonly JamsazERPLiteDataClassesDataContext _db;
        public GetPersonelSubEmployeeDockForm()
        {
            InitializeComponent();
            _db = new JamsazERPLiteDataClassesDataContext();
        }

        private void searchButton_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(personelNumberText.Text)) return;
            var personel = _db.Personnels.SingleOrDefault(
                x => x.PersonnelNumber.Equals(personelNumberText.Text) || x.Descriptor.Equals(FullNameText.Text));
            if (personel != null)
            {
                var personelId =
                    personel
                        .Id;
                getStructurePersonelsResultBindingSource.DataSource = _db.GetStructurePersonels(personelId);
            }
            else
            {
                Helper.ShowMessage("چنین شخصی وجود ندارد");
            }
        }
    }
}
