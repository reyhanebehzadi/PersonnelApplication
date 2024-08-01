using System;
using System.Deployment.Application;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;
using FarsiLibrary.Utils;
using Jamsaz.Common;
using Jamsaz.Common.Classes;
using Jamsaz.Common.UI.DialogForms;
using Jamsaz.Common.UserAuthenticationManager;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.PersonnlsApplication.Definitions;
using Jamsaz.PersonnlsApplication.Properties;
using Jamsaz.PersonnlsApplication.UI.DialogForms;
using Jamsaz.PersonnlsApplication.UI.DockForms;
using Jamsaz.PersonnlsApplication.UI.ReportForms;
using Janus.Windows.ButtonBar;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace Jamsaz.PersonnlsApplication.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fa-IR");
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
            mainParentForm = this;

#if(DEBUG)
            Manager.SolutionConfiguraton = SolutionConfiguraton.DEBUG;
#else
            Manager.SolutionConfiguraton = SolutionConfiguraton.RELEASE;
#endif

        }
        public static Form mainParentForm;
        AuthenticationManager authenticationManager;

        string connectionString = Settings.Default.JamsazERPLiteConnectionString;
        JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext(Settings.Default.JamsazERPLiteConnectionString);
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Manager.SolutionConfiguraton == SolutionConfiguraton.DEBUG)
            {
                ShowLoginDialogForm();
            }
            else
            {
                #region OLD
                //Jamsaz.Common.UI.DialogForms.LoginDialogForm loginDialogForm = new Jamsaz.Common.UI.DialogForms.LoginDialogForm(Jamsaz.PersonnlsApplication.BusinessObjects.Properties.Settings.Default.JamsazERPLiteConnectionString, "jamsaz.org", "Jamsaz.PersonnlsApplication", "نرم افزار پرسنلی");
                //if (loginDialogForm.ShowDialog() != DialogResult.OK)
                //{
                //    return;
                //}
                //authenticationManager = loginDialogForm.AuthenticationManager;

                //User.AuthenticationManager = loginDialogForm.AuthenticationManager; 
                #endregion

                try
                {
                    var client = new HttpClient { BaseAddress = new Uri("http://saturn:6363/") };
                    JToken credential = null;
                    // Usage
                    var response = client.GetAsync("api/GetUserCredential?userName=" + GetUserName()).Result;  
                if (response.IsSuccessStatusCode)
                    {
                        var res = response.Content.ReadAsStringAsync().Result;
                        credential = (JToken)JsonConvert.DeserializeObject(res);
                        User.FiscalYearID = credential["FiscalYearID"].Value<int>();
                    }
                    if (credential != null)
                    {
                        var manager = new AuthenticationManager("jamsaz.org",
                            "Jamsaz.PersonnlsApplication",
                            BusinessObjects.Properties.Settings.Default.JamsazERPLiteConnectionString
                            );

                    if (
                        manager.AuthenticateUser(
                            credential["UserName"].Value<string>(),
                            credential["Password"].Value<string>()))
                    {
                            User.AuthenticationManager = manager;
                            toolStripLabelUserName.Text = credential["UserName"].Value<string>();
                            User.Personnel = db.Personnels.Single(
                                        c =>
                                            c.PersonnelNumber.Equals(
                                                User.AuthenticationManager.directoryServiceAuthenticatedUser.EmployeeID));

                            //User.Personnel = db.Personnels.Single(
                            //            c =>
                            //                c.Id == 3149);

                            User.Department = db.SelectCurrentPersonnelDepartment(User.Personnel.Id).First();
                    }
                        else
                            ShowLoginDialogForm();
                }
                }
                catch (Exception)
                {
                    ShowLoginDialogForm();
                }
            }


            #region Default Farsi lib
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fa-IR");
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
            #endregion

            toolStripLabelDateTime.Text = PersianDate.Now.ToWritten();
            toolStripLableDate.Text = PersianDate.Now.ToWritten();
            
            if (ApplicationDeployment.IsNetworkDeployed)
                toolStripLabelVersion.Text = " نسخه " + ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();

            CreateConnectionString();
        }

        private void ShowLoginDialogForm()
        {
            LoginDialogForm loginDialogForm = new LoginDialogForm(BusinessObjects.Properties.Settings.Default.JamsazERPLiteConnectionString, "jamsaz.org", "Jamsaz.PersonnlsApplication", "نرم افزار پرسنلی");
            if (loginDialogForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            authenticationManager = loginDialogForm.AuthenticationManager;

            User.AuthenticationManager = loginDialogForm.AuthenticationManager;

            User.FiscalYearID = loginDialogForm.SelectedFiscalYearID;

            User.Personnel = db.Personnels.Single(
                                       c =>
                                           c.PersonnelNumber.Equals(
                                               User.AuthenticationManager.directoryServiceAuthenticatedUser.EmployeeID));
            //User.Personnel = db.Personnels.Single(
            //    c =>
            //        c.Id == 3149);
            User.Department = db.SelectCurrentPersonnelDepartment(User.Personnel.Id).First();

        }

        private void CreateConnectionString()
        {
            try
            {
                if (!Directory.Exists(@"C:\ConnectionString"))
                {
                    Directory.CreateDirectory(@"c:\ConnectionString");
                    File.Copy(@"\\atlas\Personnel Manager Software\ConnectionString\ATLAS JamsazERPLite vwCardPersonnely.odc", @"C:\ConnectionString\ATLAS JamsazERPLite vwCardPersonnely.odc");
                    File.Copy(@"\\atlas\Personnel Manager Software\ConnectionString\ATLAS JamsazERPLite vwContract.odc", @"C:\ConnectionString\ATLAS JamsazERPLite vwContract.odc");
                    File.Copy(@"\\atlas\Personnel Manager Software\ConnectionString\atlas JamsazERPLite vwDecree.odc", @"C:\\ConnectionString\atlas JamsazERPLite vwDecree.odc");
                }
                if (!File.Exists(@"C:\ConnectionString\ATLAS JamsazERPLite vwCardPersonnely.odc"))
                    File.Copy(@"\\atlas\Personnel Manager Software\ConnectionString\ATLAS JamsazERPLite vwCardPersonnely.odc", @"C:\ConnectionString\ATLAS JamsazERPLite vwCardPersonnely.odc");

                if (!File.Exists(@"C:\ConnectionString\ATLAS JamsazERPLite vwContract.odc"))
                    File.Copy(@"\\atlas\Personnel Manager Software\ConnectionString\ATLAS JamsazERPLite vwContract.odc", @"C:\ConnectionString\ATLAS JamsazERPLite vwContract.odc");

                if (!File.Exists(@"C:\ConnectionString\atlas JamsazERPLite vwDecree.odc"))
                    File.Copy(@"\\atlas\Personnel Manager Software\ConnectionString\atlas JamsazERPLite vwDecree.odc", @"C:\ConnectionString\atlas JamsazERPLite vwDecree.odc");
            }
            catch (Exception exp)
            {
                Helper.ShowMessage(exp.Message);
            }

        }

        private void buttonBar_ItemClick(object sender, ItemEventArgs e)
        {

            if (Manager.SolutionConfiguraton == SolutionConfiguraton.DEBUG)
            {
                Form CurrentForm = (Form)Assembly.GetExecutingAssembly().CreateInstance("Jamsaz.PersonnlsApplication.UI.DockForms." + e.Item.Key);
                SetActiveForm(CurrentForm, TypeForm.form);

                Form CurrentForm1 = (Form)Assembly.GetExecutingAssembly().CreateInstance("Jamsaz.PersonnlsApplication.UI.ReportForms." + e.Item.Key);
                SetActiveForm(CurrentForm1, TypeForm.form);
            }
            else
            {
                if (User.AuthenticationManager.IsActionAvailable(string.Format("{0}-{1}", e.Item.Key.ToString(), "View")))
                {
                    Form CurrentForm = (Form)Assembly.GetExecutingAssembly().CreateInstance("Jamsaz.PersonnlsApplication.UI.DockForms." + e.Item.Key);
                    SetActiveForm(CurrentForm, TypeForm.form);

                    Form CurrentForm1 = (Form)Assembly.GetExecutingAssembly().CreateInstance("Jamsaz.PersonnlsApplication.UI.ReportForms." + e.Item.Key);
                    SetActiveForm(CurrentForm1, TypeForm.form);
                }
                else
                    MessageBox.Show("شما به این فرم دسترسی ندارید");
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Helper.Confirm("آیا می خواهید از برنامه خارج شوید"))
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        public void SetActiveForm(Form FormTarget, TypeForm typeForm)
        {
            try
            {

                foreach (Form objForm in this.MdiChildren)
                {
                    if (objForm.Text == FormTarget.Text)
                    {
                        objForm.Activate();
                        return;
                    }
                }
                FormTarget.MdiParent = this;
                FormTarget.Show();

            }
            catch
            {

            }

        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void diagramDegreebyGenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Manager.SolutionConfiguraton == SolutionConfiguraton.DEBUG)
            {
                SetActiveForm(new DiagramDegreeByGenderReportForm(), TypeForm.form);
            }
            else
            {
                if (User.AuthenticationManager.IsActionAvailable(string.Format("{0}-{1}", "DiagramDegreeByGenderReportForm", "View")))
                {
                    SetActiveForm(new DiagramDegreeByGenderReportForm(), TypeForm.form);
                }
                else
                    MessageBox.Show("شما به این فرم دسترسی ندارید");
            }
        }


        private void digramMaritualStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Manager.SolutionConfiguraton == SolutionConfiguraton.DEBUG)
            {
                SetActiveForm(new DiagramMaritualStatusReportForm(), TypeForm.form);
            }
            else
            {
                if (User.AuthenticationManager.IsActionAvailable(string.Format("{0}-{1}", "DiagramMaritualStatusReportForm", "View")))
                {
                    SetActiveForm(new DiagramMaritualStatusReportForm(), TypeForm.form);
                }
                else
                    MessageBox.Show("شما به این فرم دسترسی ندارید");
            }

        }

        private void diagramPersonnelByGenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Manager.SolutionConfiguraton == SolutionConfiguraton.DEBUG)
            {
                SetActiveForm(new DiagramPersonnelByGenderReportForm(), TypeForm.form);
            }
            else
            {
                if (User.AuthenticationManager.IsActionAvailable(string.Format("{0}-{1}", "DiagramPersonnelByGenderReportForm", "View")))
                {
                    SetActiveForm(new DiagramPersonnelByGenderReportForm(), TypeForm.form);
                }
                else
                    MessageBox.Show("شما به این فرم دسترسی ندارید");
            }
        }

        private void ReportbyMaritualPersonnelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Manager.SolutionConfiguraton == SolutionConfiguraton.DEBUG)
            {
                SetActiveForm(new ListMaritualPersonnelsReportForm(), TypeForm.form);
            }
            else
            {
                if (User.AuthenticationManager.IsActionAvailable(string.Format("{0}-{1}", "ListMaritualPersonnelsReportForm", "View")))
                {
                    SetActiveForm(new ListMaritualPersonnelsReportForm(), TypeForm.form);
                }
                else
                    MessageBox.Show("شما به این فرم دسترسی ندارید");
            }
        }

        private void ReportPersonnelEducationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Manager.SolutionConfiguraton == SolutionConfiguraton.DEBUG)
            {
                SetActiveForm(new ListPersonnelByEducationReportForm(), TypeForm.form);
            }
            else
            {
                if (User.AuthenticationManager.IsActionAvailable(string.Format("{0}-{1}", "ListPersonnelByEducationReportForm", "View")))
                {
                    SetActiveForm(new ListPersonnelByEducationReportForm(), TypeForm.form);
                }
                else
                    MessageBox.Show("شما به این فرم دسترسی ندارید");
            }
        }

        private void technicalStaffReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Manager.SolutionConfiguraton == SolutionConfiguraton.DEBUG)
            {
                SetActiveForm(new TechnicalStaffReportForm(), TypeForm.form);
            }
            else
            {
                if (User.AuthenticationManager.IsActionAvailable(string.Format("{0}-{1}", "TechnicalStaffReportForm", "View")))
                {
                    SetActiveForm(new TechnicalStaffReportForm(), TypeForm.form);
                }
                else
                    MessageBox.Show("شما به این فرم دسترسی ندارید");
            }
        }

        private void changheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Manager.SolutionConfiguraton == SolutionConfiguraton.DEBUG)
            {
                SetActiveForm(new CustomConnectionStringDialogForm(), TypeForm.dialogForm);
            }
            else
            {
                if (User.AuthenticationManager.IsActionAvailable(string.Format("{0}-{1}", "CustomConnectionStringDialogForm", "View")))
                {
                    SetActiveForm(new CustomConnectionStringDialogForm(), TypeForm.dialogForm);
                }
                else
                    MessageBox.Show("شما به این فرم دسترسی ندارید");
            }
        }

        private void managementPathFoldersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Manager.SolutionConfiguraton == SolutionConfiguraton.DEBUG)
            {
                SetActiveForm(new ManagementPathFoldersDialogForm(), TypeForm.dialogForm);
            }
            else
            {
                if (User.AuthenticationManager.IsActionAvailable(string.Format("{0}-{1}", "ManagementPathFoldersDialogForm", "View")))
                {
                    SetActiveForm(new ManagementPathFoldersDialogForm(), TypeForm.dialogForm);
                }
                else
                    MessageBox.Show("شما به این فرم دسترسی ندارید");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void departmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Manager.SolutionConfiguraton == SolutionConfiguraton.DEBUG)
            {
                SetActiveForm(new departmentsForm(), TypeForm.form);
            }
            else
            {
                if (User.AuthenticationManager.IsActionAvailable(string.Format("{0}-{1}", "departmentsForm", "View")))
                {
                    SetActiveForm(new departmentsForm(), TypeForm.form);
                }
                else
                    MessageBox.Show("شما به این فرم دسترسی ندارید");
            }
        }

        private void roleStructureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Manager.SolutionConfiguraton == SolutionConfiguraton.DEBUG)
            {
                SetActiveForm(new rolesStructureForm(), TypeForm.form);
            }
            else
            {
                if (User.AuthenticationManager.IsActionAvailable(string.Format("{0}-{1}", "rolesStructureForm", "View")))
                {
                    SetActiveForm(new rolesStructureForm(), TypeForm.form);
                }
                else
                    MessageBox.Show("شما به این فرم دسترسی ندارید");
            }
        }

        private void assignPersonnelsToOrganizationStructureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Manager.SolutionConfiguraton == SolutionConfiguraton.DEBUG)
            {
                SetActiveForm(new AssignPersonnelsToOrganizationStructureForm(), TypeForm.form);
            }
            else
            {
                if (User.AuthenticationManager.IsActionAvailable(string.Format("{0}-{1}", "AssignPersonnelsToOrganizationStructureForm", "View")))
                {
                    SetActiveForm(new AssignPersonnelsToOrganizationStructureForm(), TypeForm.form);
                }
                else
                    MessageBox.Show("شما به این فرم دسترسی ندارید");
            }
        }

        private void personnelSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Manager.SolutionConfiguraton == SolutionConfiguraton.DEBUG)
            {
                SetActiveForm(new PersonnelSearchForm(), TypeForm.form);
            }
            else
            {
                if (User.AuthenticationManager.IsActionAvailable(string.Format("{0}-{1}", "PersonnelSearchForm", "View")))
                {
                    SetActiveForm(new PersonnelSearchForm(), TypeForm.form);
                }
                else
                    MessageBox.Show("شما به این فرم دسترسی ندارید");
            }

        }

        private void applicantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Manager.SolutionConfiguraton == SolutionConfiguraton.DEBUG)
            {
                SetActiveForm(new ApplicantsForm(), TypeForm.form);
            }
            else
            {
                if (User.AuthenticationManager.IsActionAvailable(string.Format("{0}-{1}", "ApplicantsForm", "View")))
                {
                    SetActiveForm(new ApplicantsForm(), TypeForm.form);
                }
                else
                    MessageBox.Show("شما به این فرم دسترسی ندارید");
            }
        }

        private void baseInformationMilitaryServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Manager.SolutionConfiguraton == SolutionConfiguraton.DEBUG)
            {
                SetActiveForm(new BaseInformationMilitaryServiceForm(), TypeForm.form);
            }
            else
            {
                if (User.AuthenticationManager.IsActionAvailable(string.Format("{0}-{1}", "BaseInformationMilitaryServiceForm", "View")))
                {
                    SetActiveForm(new BaseInformationMilitaryServiceForm(), TypeForm.form);
                }
                else
                    MessageBox.Show("شما به این فرم دسترسی ندارید");
            }
        }

        private void baseInformationUniversityServiceFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Manager.SolutionConfiguraton == SolutionConfiguraton.DEBUG)
            {
                SetActiveForm(new BaseInformationUniversityServiceForm(), TypeForm.form);
            }
            else
            {
                if (User.AuthenticationManager.IsActionAvailable(string.Format("{0}-{1}", "BaseInformationUniversityServiceForm", "View")))
                {
                    SetActiveForm(new BaseInformationUniversityServiceForm(), TypeForm.form);
                }
                else
                    MessageBox.Show("شما به این فرم دسترسی ندارید");
            }
        }

        private void BaseInformationMajorsFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Manager.SolutionConfiguraton == SolutionConfiguraton.DEBUG)
            {
                SetActiveForm(new BaseInformationMajorsForm(), TypeForm.form);
            }
            else
            {
                if (User.AuthenticationManager.IsActionAvailable(string.Format("{0}-{1}", "BaseInformationMajorsForm", "View")))
                {
                    SetActiveForm(new BaseInformationMajorsForm(), TypeForm.form);
                }
                else
                    MessageBox.Show("شما به این فرم دسترسی ندارید");
            }
        }

        private void baseInformationContractTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Manager.SolutionConfiguraton == SolutionConfiguraton.DEBUG)
            {
                SetActiveForm(new BaseInformationContractTypeForm(), TypeForm.form);
            }
            else
            {
                if (User.AuthenticationManager.IsActionAvailable(string.Format("{0}-{1}", "BaseInformationContractTypeForm", "View")))
                {
                    SetActiveForm(new BaseInformationContractTypeForm(), TypeForm.form);
                }
                else
                    MessageBox.Show("شما به این فرم دسترسی ندارید");
            }
        }

        private void selectPersonnelsByMajorReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Manager.SolutionConfiguraton == SolutionConfiguraton.DEBUG)
            {
                SetActiveForm(new SelectPersonnelsByMajorReportForm(), TypeForm.form);
            }
            else
            {
                if (User.AuthenticationManager.IsActionAvailable(string.Format("{0}-{1}", "SelectPersonnelsByMajorReportForm", "View")))
                {
                    SetActiveForm(new SelectPersonnelsByMajorReportForm(), TypeForm.form);
                }
                else
                    MessageBox.Show("شما به این فرم دسترسی ندارید");
            }
        }

        private void selectApplicantByRespectDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Manager.SolutionConfiguraton == SolutionConfiguraton.DEBUG)
            {
                SetActiveForm(new SelectApplicantByRespectDateReportForm(), TypeForm.form);
            }
            else
            {
                if (User.AuthenticationManager.IsActionAvailable(string.Format("{0}-{1}", "SelectApplicantByRespectDateReportForm", "View")))
                {
                    SetActiveForm(new SelectApplicantByRespectDateReportForm(), TypeForm.form);
                }
                else
                    MessageBox.Show("شما به این فرم دسترسی ندارید");
            }

        }

        private void departmentVersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Manager.SolutionConfiguraton == SolutionConfiguraton.DEBUG)
            {
                SetActiveForm(new DepartmentVersionReportForm(), TypeForm.form);
            }
            else
            {
                if (User.AuthenticationManager.IsActionAvailable(string.Format("{0}-{1}", "DepartmentVersionReportForm", "View")))
                {
                    SetActiveForm(new DepartmentVersionReportForm(), TypeForm.form);
                }
                else
                    MessageBox.Show("شما به این فرم دسترسی ندارید");
            }
        }

        private void lockToolStripButton_Click(object sender, EventArgs e)
        {
            LoginDialogForm loginDialogForm = new LoginDialogForm(BusinessObjects.Properties.Settings.Default.JamsazERPLiteConnectionString, "jamsaz.org", "Jamsaz.PersonnlsApplication", "نرم افزار پرسنلی");
            if (loginDialogForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            authenticationManager = loginDialogForm.AuthenticationManager;
        }

        private void PersonnelsListReportFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Manager.SolutionConfiguraton == SolutionConfiguraton.DEBUG)
            {
                SetActiveForm(new PersonnelsListReportForm(), TypeForm.form);
            }
            else
            {
                if (User.AuthenticationManager.IsActionAvailable(string.Format("{0}-{1}", "PersonnelsListReportForm", "View")))
                {
                    SetActiveForm(new PersonnelsListReportForm(), TypeForm.form);
                }
                else
                    MessageBox.Show("شما به این فرم دسترسی ندارید");
            }
        }

        private void لیستپرسنلباحقاولادToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Manager.SolutionConfiguraton == SolutionConfiguraton.DEBUG)
            {
                SetActiveForm(new PersonnelsList1ReportForm(), TypeForm.form);
            }
            else
            {
                if (User.AuthenticationManager.IsActionAvailable(string.Format("{0}-{1}", "PersonnelsList1ReportForm", "View")))
                {
                    SetActiveForm(new PersonnelsList1ReportForm(), TypeForm.form);
                }
                else
                    MessageBox.Show("شما به این فرم دسترسی ندارید");
            }
        }

        private void حقوقودستمزدپرسنلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Manager.SolutionConfiguraton == SolutionConfiguraton.DEBUG)
            {
                SetActiveForm(new PersonnelsPayRollReportForm(), TypeForm.form);
            }
            else
            {
                if (User.AuthenticationManager.IsActionAvailable(string.Format("{0}-{1}", "PersonnelsPayRollReportForm", "View")))
                {
                    SetActiveForm(new PersonnelsPayRollReportForm(), TypeForm.form);
                }
                else
                    MessageBox.Show("شما به این فرم دسترسی ندارید");
            }
        }

        private void ثبتافزایشمدیریتیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Manager.SolutionConfiguraton == SolutionConfiguraton.DEBUG)
            {
                SetActiveForm(new IncreaseManagementDockForm(), TypeForm.form);
            }
            else
            {
                if (User.AuthenticationManager.IsActionAvailable(string.Format("{0}-{1}", "IncreaseManagementDockForm", "View")))
                {
                    SetActiveForm(new IncreaseManagementDockForm(), TypeForm.form);
                }
                else
                    MessageBox.Show("شما به این فرم دسترسی ندارید");
            }
        }

        private void لیستپرسنلمستثتیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Manager.SolutionConfiguraton == SolutionConfiguraton.DEBUG)
            {
                SetActiveForm(new ExcludePersonnelListDockForm(), TypeForm.form);
            }
            else
            {
                if (User.AuthenticationManager.IsActionAvailable(string.Format("{0}-{1}", "ExcludePersonnelListDockForm", "View")))
                {
                    SetActiveForm(new ExcludePersonnelListDockForm(), TypeForm.form);
                }
                else
                    MessageBox.Show("شما به این فرم دسترسی ندارید");
            }
        }

        private void لیستToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Manager.SolutionConfiguraton == SolutionConfiguraton.DEBUG)
            {
                SetActiveForm(new WithoutOvertimePersonnelsDockForm(), TypeForm.form);
            }
            else
            {
                if (User.AuthenticationManager.IsActionAvailable(string.Format("{0}-{1}", "WithoutOvertimePersonnelsDockForm", "View")))
                {
                    SetActiveForm(new WithoutOvertimePersonnelsDockForm(), TypeForm.form);
                }
                else
                    MessageBox.Show("شما به این فرم دسترسی ندارید");
            }
        }

        private void گزارشسختیکارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Manager.SolutionConfiguraton == SolutionConfiguraton.DEBUG)
            {
                SetActiveForm(new SakhtieKarReportForm(), TypeForm.form);
            }
            else
            {
                if (User.AuthenticationManager.IsActionAvailable(string.Format("{0}-{1}", "SakhtieKarReportForm", "View")))
                {
                    SetActiveForm(new SakhtieKarReportForm(), TypeForm.form);
                }
                else
                    MessageBox.Show("شما به این فرم دسترسی ندارید");
            }
        }

        private void کارجواینترنتیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Manager.SolutionConfiguraton == SolutionConfiguraton.DEBUG)
            {
                SetActiveForm(new WebApplicantsDockForm(), TypeForm.form);
            }
            else
            {
                if (User.AuthenticationManager.IsActionAvailable(string.Format("{0}-{1}", "WebApplicantsDockForm", "View")))
                {
                    SetActiveForm(new WebApplicantsDockForm(), TypeForm.form);
                }
                else
                    MessageBox.Show("شما به این فرم دسترسی ندارید");
            }
        }

        private void گزارشپرسنلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Manager.SolutionConfiguraton == SolutionConfiguraton.DEBUG)
            {
                SetActiveForm(new PersonnelReportForm(), TypeForm.form);
            }
            else
            {
                if (User.AuthenticationManager.IsActionAvailable(string.Format("{0}-{1}", "PersonnelReportForm", "View")))
                {
                    SetActiveForm(new PersonnelReportForm(), TypeForm.form);
                }
                else
                    MessageBox.Show("شما به این فرم دسترسی ندارید");
            }
        }

        private string GetUserName()
        {
            try
            {
                var windowsPrincipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());

                var userName = windowsPrincipal.Identity.Name.Replace(@"JAMSAZ\", string.Empty).Trim();

                return userName.Replace(@"JSIP\", string.Empty).Trim();
            }
            catch (Exception)
            {
                return "";
            }
        }

        private void گزارشترددپرسنلهفتگیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Manager.SolutionConfiguraton == SolutionConfiguraton.DEBUG)
            {
                SetActiveForm(new PersonnelsFunctionReportForm(), TypeForm.form);
            }
            else
            {
                if (User.AuthenticationManager.IsActionAvailable(string.Format("{0}-{1}", "PersonnelsFunctionReportForm", "View")))
                {
                    SetActiveForm(new PersonnelsFunctionReportForm(), TypeForm.form);
                }
                else
                    MessageBox.Show("شما به این فرم دسترسی ندارید");
            }
        }
    }
}

