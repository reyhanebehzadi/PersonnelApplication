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
    public partial class DiagramMaritualStatusReportForm : Jamsaz.Common.BasePersianForm
    {
        public DiagramMaritualStatusReportForm()
        {
            InitializeComponent();
        }
        JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
        private void DiagramMaritualStatusReportForm_Load(object sender, EventArgs e)
        {
            List<DiagramMaritualStatus> maritualAndSingelsStatus = new List<DiagramMaritualStatus>();
            maritualAndSingelsStatus = (from c in db.Personnels
                                        where c.IsActive == true && c.Gender == 2 
                                        group c by c.MaritalStatus  into g
                                        select new DiagramMaritualStatus
                                        {
                                            PersonnelCount = g.Count(),
                                            Gender = g.First().Gender == 1 ? "مرد" : "زن",
                                            MaritalStatusName = g.First().MaritalStatus == 2 ? "مجرد" : "متاهل"
                                            
                                        }).ToList();

            List<DiagramMaritualStatus> diagramMaritualStatus = new List<DiagramMaritualStatus>();
            diagramMaritualStatus = (from c in db.Personnels
                                     where c.IsActive == true && c.Gender == 1//&& c.MaritalStatus ==2
                                     group c by c.MaritalStatus into g
                                     select new DiagramMaritualStatus
                                     {
                                         PersonnelCount = g.Count(),
                                         Gender = g.First().Gender == 1 ? "مرد" : "زن",
                                         MaritalStatusName = g.First().MaritalStatus == 2 ? "مجرد" : "متاهل"

                                     }).ToList();

          
            foreach (DiagramMaritualStatus item in diagramMaritualStatus)
            {
                maritualAndSingelsStatus.Add(item);
            }
            DiagramMaritualStatusBindingSource.DataSource = maritualAndSingelsStatus;
            this.MainReportViewer.RefreshReport();
        }
    }
}
