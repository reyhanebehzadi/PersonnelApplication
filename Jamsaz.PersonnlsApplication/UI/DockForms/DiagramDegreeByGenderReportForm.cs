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
	public partial class DiagramDegreeByGenderReportForm : Jamsaz.Common.BasePersianForm
	{
		public DiagramDegreeByGenderReportForm()
		{
			InitializeComponent();
		}
		Jamsaz.PersonnlsApplication.BusinessObjects.Data.JamsazERPLiteDataClassesDataContext db = new Jamsaz.PersonnlsApplication.BusinessObjects.Data.JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);

		private void DiagramDegreeByGenderReport_Load(object sender, EventArgs e)
		{
			//List<DiagramDegreeByGender> valuesForDiagramDegreeByGender = new List<DiagramDegreeByGender>();
			//valuesForDiagramDegreeByGender = (from c in db.Personnels
			//                                  where c.IsActive == true
			//                                  group c by c.UniversityDegreeId + c.Gender into g
			//                                  select new DiagramDegreeByGender
			//                                      {
			//                                          Gender = g.First().Gender == 1 ? "مرد" : "زن",
			//                                          CountPersonnel = g.Count(),
			//                                          NameDegree = g.First().UniversityDegree.Name

			//                                      }).ToList();

            #region ghasem injori neveshte bod ke man taghiresh dadam va ye procedure neveshtam.
            
            //List<DiagramDegreeByGender> diagramDegreeByGenderfemal = new List<DiagramDegreeByGender>();
            //List<DiagramDegreeByGender> diagramDegreeByGenderMan = new List<DiagramDegreeByGender>();

            //diagramDegreeByGenderfemal = (from c in db.UniversityDegrees
            //                                                            where c.Id == 1 || c.Id == 3 || c.Id == 4 || c.Id == 16
            //                                                            select new DiagramDegreeByGender
            //                                                            {
            //                                                                Gender = "زن",
            //                                                                CountPersonnel = c.Personnels.Count(d => d.Gender == 2 && d.IsActive == true),
            //                                                                NameDegree = c.Name

            //                                                            }).ToList();

            //diagramDegreeByGenderMan = (from c in db.UniversityDegrees
            //                                                        where c.Id == 1 || c.Id == 3 || c.Id == 4 || c.Id == 16
            //                                                        select new DiagramDegreeByGender
            //                                                        {
            //                                                            Gender = "مرد",
            //                                                            CountPersonnel = c.Personnels.Count(d => d.Gender == 1 && d.IsActive == true),
            //                                                            NameDegree = c.Name

            //                                                        }).ToList(); 

            #endregion

			DiagramDegreeByGenderBindingSource.DataSource = db.GetPersonnelByDegree().ToList();
			mainReportViewer.RefreshReport();
		}
	}
}
