using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class DiagramPersonnelByGenderReportForm : Jamsaz.Common.BasePersianForm
    {
        public DiagramPersonnelByGenderReportForm()
        {
            InitializeComponent();
        }
        JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
        private void DiagramPersonnelByGenderReportForm_Load(object sender, EventArgs e)
        {
            List<DigramPersonnelByGender> valuesDigramPersonnelByGender = new List<DigramPersonnelByGender>();
            valuesDigramPersonnelByGender = (from c in db.Personnels
                                             where c.IsActive == true
                                             group c by c.Gender into g
                                             select new DigramPersonnelByGender { TitleGender = g.First().Gender == 1 ? "مرد" : "زن", PersonnelCount = g.Count() }).ToList();
            DigramPersonnelByGenderBindingSource.DataSource = valuesDigramPersonnelByGender;
            this.mainReportViewer.RefreshReport();
        }
    }
}
