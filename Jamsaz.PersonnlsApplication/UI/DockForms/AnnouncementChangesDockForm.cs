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
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.PersonnlsApplication.BusinessObjects.Definitions;
using Jamsaz.PersonnlsApplication.UI.DialogForms;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class AnnouncementChangesDockForm : BasePersianForm
    {
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        private List<AnnouncementChange> list = new List<AnnouncementChange>();
        private  string str;
        public AnnouncementChangesDockForm()
        {
            InitializeComponent();
        }

        private void AnnouncementChangesDockForm_Load(object sender, EventArgs e)
        {
            fiscalYearBindingSource.DataSource = db.FiscalYears;
            monthBindingSource.DataSource = db.MonthTables;
            fiscalYearComboBox.SelectedItem = db.FiscalYears.SingleOrDefault(c => c.Status == 2);
            LoadData();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddAnnouncementChangesDialogForm addAnnouncementChangesDialogForm = new AddAnnouncementChangesDialogForm()
            {
                CurrentYear = (FiscalYear)fiscalYearComboBox.SelectedItem,
                FormStatus = FormStatus.Add
            };
            if (addAnnouncementChangesDialogForm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            db = new JamsazERPLiteDataClassesDataContext();
            if (fiscalYearComboBox.SelectedItem != null && monthsComboBox.SelectedItem != null)
            {

                //announcementChangeBindingSource.DataSource = db.AnnouncementChanges.Where(c => c.FiscalYearID == ((FiscalYear)fiscalYearComboBox.SelectedItem).ID );
                list = db.AnnouncementChanges.Where(c => c.FiscalYearID == ((FiscalYear)fiscalYearComboBox.SelectedItem).ID).ToList();
                list = list.Where(p => Convert.ToInt32(p.Mounth) == ((MonthTable)monthsComboBox.SelectedItem).ID).ToList();
                announcementChangeBindingSource.DataSource = list;
            }
               
        }


        private void editButton_Click(object sender, EventArgs e)
        {
            if (!(announcementChangeBindingSource.Current is AnnouncementChange current)) return;
            {
                AddAnnouncementChangesDialogForm addAnnouncementChangesDialogForm = new AddAnnouncementChangesDialogForm()
                {
                    CurrentYear = (FiscalYear)fiscalYearComboBox.SelectedItem,
                    FormStatus = FormStatus.Edit,
                    AnnouncementChange = current
                };
                if (addAnnouncementChangesDialogForm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (!(announcementChangeBindingSource.Current is AnnouncementChange current)) return;
            {
                if (Helper.Confirm("آیا مایل به حذف اطلاعات هستید؟"))
                {
                    db.AnnouncementChanges.DeleteOnSubmit(current);
                    db.SubmitChanges();
                    LoadData();
                }
            }
        }

        private void fiscalYearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            if (list.Count > 0)
            {

                var report = new Stimulsoft.Report.StiReport();


                //report.Load(@"D:\ChangeTypeReport.mrt");

                report.Load(Properties.Resources.ChangeTypeReport);



                report.RegBusinessObject("items", list.Where( p=> Convert.ToInt32(p.Mounth) == ((MonthTable)monthsComboBox.SelectedItem).ID).OrderBy(c=>c.ChangeTypeID));
                int month = Convert.ToInt32(list.First().Mounth);
                
                switch (month)
                {
                    case 1:str="فروردین";
                        break;
                    case 2:
                        str = "اردیبهشت";
                        break;
                    case 3:
                        str = "خرداد";
                        break;
                    case 4:
                        str = "تیر";
                        break;
                    case 5:
                        str = "مرداد";
                        break;
                    case 6:
                        str = "شهریور";
                        break;
                    case 7:
                        str = "مهر";
                        break;
                    case 8:
                        str = "آبان";
                        break;
                    case 9:
                        str = "آذر";
                        break;
                    case 10:
                        str = "دی";
                        break;
                    case 11:
                        str = "بهمن";
                        break;
                    case 12:
                        str = "اسفند";
                        break;
                    
                }

                report.Dictionary.Variables["Year"].Value = ((FiscalYear)fiscalYearComboBox.SelectedItem).Title;
                report.Dictionary.Variables["Month"].Value = str;
                report.Dictionary.Variables["ReportDate"].Value = DateTime.Now.ToShortPersianDate();
                report.Render();
                //stiViewerControl1.PageViewMode = StiPageViewMode.SinglePage;
                //stiViewerControl1.Report = report;



                //stiViewerControl1.Show();
                //report.Design();
                report.Show(true);
            }

        }

        private void monthsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
