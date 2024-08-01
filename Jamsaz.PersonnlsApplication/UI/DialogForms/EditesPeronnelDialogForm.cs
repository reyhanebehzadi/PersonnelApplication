using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Linq;
using FarsiLibrary.Utils;
using System.IO;
using System.Linq;
using System.Threading;
using System.Globalization;
using Jamsaz.Common.UI.DialogForms;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.Classes;
using Jamsaz.PersonnlsApplication.BusinessObjects.Definitions;
using Jamsaz.PersonnlsApplication.UI.DockForms;
namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class EditesPeronnelDialogForm : BasePersianForm
    {
        public EditesPeronnelDialogForm(int personnelIDPassed, bool statusPassed)
        {
            InitializeComponent();
            personnelID = personnelIDPassed;
            LastPersonnelID = personnelID;
            FormStatusEditing = statusPassed;
            maritalStatusComboBox.ValueMember = "intValue";
            maritalStatusComboBox.DisplayMember = "Value";
            maritalStatusComboBox.DataSource = Jamsaz.PersonnlsApplication.Definitions.enumMaritualStatus.getItems();
            genderComboBox.ValueMember = "intValue";
            genderComboBox.DisplayMember = "Value";
            genderComboBox.DataSource = Jamsaz.PersonnlsApplication.Definitions.enumGender.getItems();
        }

        Bitmap imgObject;
        string pathFilePicture = "";
        string currentPersonnelNumber;
        int personnelID = 0;
        int LastPersonnelID = 0;
        bool FormStatusEditing = true;
        bool HassError = false;
        Jamsaz.PersonnlsApplication.BusinessObjects.Data.JamsazERPLiteDataClassesDataContext db = new Jamsaz.PersonnlsApplication.BusinessObjects.Data.JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
        Personnel personnel = new Personnel();
        OrganizationStructurePersonnel OrganizationStructurePersonnel;
        DepartmentPersonnel departmentPersonnel;
        private void EditesPeronnelDialogForm_Load(object sender, EventArgs e)
        {
            try
            {
                User.AuthenticationManager.SetFormControlPropertiesByAvailableActions(this.Name, this);

                this.isInfactoryComboBox.DataSource = Jamsaz.PersonnlsApplication.BusinessObjects.Resources.enumBase<Location>.getItems();

                this.actionTypeComboBox.DataSource = enumBase<PersonnlsApplication.BusinessObjects.Definitions.ActionType>.getItems();

                this.personnelStatusComboBox.DataSource = enumBase<PersonnlsApplication.BusinessObjects.Definitions.PersonnelStatus>.getItems();
                List<MartialStatusType> dataSource = new List<MartialStatusType>();
                dataSource.Add(new MartialStatusType() { ID = 1, Name = "مجرد" });
                dataSource.Add(new MartialStatusType() { ID = 2, Name = "متاهل" });
                this.martialStatusTypeBindingSource.DataSource = dataSource;

                universityDegreeBindingSource.DataSource = db.UniversityDegrees.ToList();
                organizationPostBindingSource.DataSource = db.OrganizationPosts.ToList();

                if (!User.AuthenticationManager.IsActionAvailable("EditesPeronnelDialogForm-ChangeIsInFactory") && FormStatusEditing == true)
                    this.isInfactoryComboBox.Enabled = false;

                System.Globalization.CultureInfo CultureInfo = new System.Globalization.CultureInfo("fa-IR");

                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(CultureInfo);

                Thread.CurrentThread.CurrentCulture = new CultureInfo("fa-IR");

                Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalDigits = 0;

                Helper.Changelanguage(Helper.Selectlanguage.Farsi);

                //  txtEmail.GotFocus += new EventHandler(txtEmail_GotFocus);

                if (FormStatusEditing)
                {
                    personnel = db.Personnels.SingleOrDefault(c => c.Id == personnelID);
                    PersonnelbindingSource.DataSource = personnel;
                    var personelBankAccount = db.PersonelBankAccounts.SingleOrDefault(pba => pba.PersonelID == personnelID && pba.IsDefault);
                    if (personelBankAccount != null)
                        bankAccountTextBox.Text = $"{personelBankAccount.AccountNumber} - {personelBankAccount.BankName}";
                    this.Text = " نام و نام خانوادگی: " + personnel.FirstName + " " + personnel.LastName + "      " + "شماره پرسنلی : " + personnel.PersonnelNumber;
                    OrganizationStructurePersonnel x = db.OrganizationStructurePersonnels.SingleOrDefault(c => c.PersonnelId == personnel.Id && c.IsMainPosition == true);
                    DepartmentPersonnel y = db.DepartmentPersonnels.SingleOrDefault(c => c.PersonnelID == personnel.Id && c.IsActiveDepartment == true);
                    if (x != null)
                        roleStructurtextBox.Text = x.RoleName;
                    else
                        roleStructurtextBox.Text = "";


                    if (y != null)
                        sectionTextBox.Text = y.DepartmentName;
                    else
                        sectionTextBox.Text = "";

                    FillCurrentPersonnel();

                }
                else
                {
                    nextButton.Visible = false;
                    previewButton.Visible = false;
                    personnel = (Personnel)PersonnelbindingSource.AddNew();
                    personnel.IsInFactory = 1;
                    isActiveCheckBox.Checked = true;
                    religionTextBox.Text = "شیعه";
                }

            }
            catch (Exception exp)
            {
                if (exp.GetType() == typeof(System.Data.SqlClient.SqlException))
                    Helper.ShowMessage("خطا در ارتباط با بانک اطلاعاتی", " اتصال به بانک اطلاعاتی برقرار نیست " + "\n لطفا مشکل را به مسئول شبکه گزارش دهید\n ");
                else
                    Helper.ShowMessage(exp.Message);

            }
        }

        #region Functions

        public void isvalidControl()
        {
            //else if (cboBrithDate.Text.Length < 10)
            //{
            //    ProError.SetError(cboBrithDate, "ِلطفا تاریخ تولد را وارد کندید");
            //    HassError = true;
            //}
            errorProvider.Clear();
            HassError = false;

            if (personnelNumberTextBox.Text == "")
            {
                errorProvider.SetError(personnelNumberTextBox, "ِلطفا شماره کارمندی را وارد کنید");
                HassError = true;
            }
            else if (firstNameTextBox.Text == "")
            {
                errorProvider.SetError(firstNameTextBox, "ِلطفا نام را وارد کنید");
                HassError = true;
            }
            else if (lastNameTextBox.Text == "")
            {
                errorProvider.SetError(lastNameTextBox, "ِلطفا نام خانوادگی را وارد کنید");
                HassError = true;
            }
            else if (issueNoTextBox.Text == "")
            {
                errorProvider.SetError(issueNoTextBox, "ِلطفا شماره سناسنامه را وارد کنید");
                HassError = true;
            }
            else if (fatherNameTextBox.Text == "")
            {
                errorProvider.SetError(fatherNameTextBox, "ِلطفا نام پدر را وارد کنید");
                HassError = true;
            }
            else if (genderComboBox.SelectedIndex == -1)
            {
                errorProvider.SetError(genderComboBox, "ِلطفا جنسیت شخص را وارد کنید ");
                HassError = true;
            }
            else if (brithDateDatePicker.IsNull == true)
            {
                errorProvider.SetError(brithDateDatePicker, "ِلطفا تاریخ تولد را وارد کنید ");
                HassError = true;
            }
            else if (firstContractStartDateDatePicker.IsNull == true)
            {
                errorProvider.SetError(firstContractStartDateDatePicker, "ِلطفا تاریخ اولین قرارداد را وارد کنید ");
                HassError = true;
            }
            else if (DateTime.Compare(brithDateDatePicker.SelectedDateTime.Value.Date, firstContractStartDateDatePicker.SelectedDateTime.Value.Date) >= 0)
            {
                errorProvider.SetError(brithDateDatePicker, "ِتاریخ تولد باید کوچکتر از تاریخ قرارداد می باشد");
                errorProvider.SetError(firstContractStartDateDatePicker, "ِتاریخ قرارداد باید بزرگ تر از تاریخ تولد باشد ");
                HassError = true;
            }
            else if (workStartDateDatePicker.IsNull == true)
            {
                errorProvider.SetError(workStartDateDatePicker, "ِلطفا تاریخ شروع به کار را وارد کنید ");
                HassError = true;
            }
            else if (DateTime.Compare(firstContractStartDateDatePicker.SelectedDateTime.Value.Date, workStartDateDatePicker.SelectedDateTime.Value.Date) > 0)
            {
                //    ProError.SetError(cboFirstContractStartDate, "ِتاریخ اولین قرارداد باید کوچکتر یا مساوی از تاریخ شروع به کار باشد ");
                //    ProError.SetError(cboWorkStartDate, "ِتاریخ شروع به کار باید بزرگ تر یا مساوی از تاریخ اولین فراداد باشد ");
                //     HassError = true;
            }
            else if (currentContractStartDateDatePicker.IsNull == true)
            {
                errorProvider.SetError(currentContractStartDateDatePicker, "ِلطفا تاریخ قرارداد جاری را وارد کنید ");
                HassError = true;
            }
            else if (DateTime.Compare(workStartDateDatePicker.SelectedDateTime.Value.Date, currentContractStartDateDatePicker.SelectedDateTime.Value.Date) < 0)
            {
                //    ProError.SetError(cboWorkStartDate, "ِتاریخ شروع به کار نباید کوچکتر از تاریخ قرارداد جاری باشد ");
                //    ProError.SetError(cboCurrentContractStartDate, "ِتاریخ قرارداد جاری باید کوچکتر یا مساوی از تاریخ شروع به کار باشد ");
                //     HassError = true;
            }
            else if (contractEndDateDatePicker.IsNull == true)
            {
                errorProvider.SetError(contractEndDateDatePicker, "ِلطفا تاریخ  پایان قرارداد را وارد کنید ");
                HassError = true;
            }
            else if (DateTime.Compare(currentContractStartDateDatePicker.SelectedDateTime.Value.Date, contractEndDateDatePicker.SelectedDateTime.Value.Date) > 0 ^ DateTime.Compare(currentContractStartDateDatePicker.SelectedDateTime.Value.Date, contractEndDateDatePicker.SelectedDateTime.Value.Date) == 0)
            {
                errorProvider.SetError(currentContractStartDateDatePicker, "ِتاریخ قرارداد نباید کوچکتر از تاریخ پایان قراداد باشد ");
                errorProvider.SetError(contractEndDateDatePicker, "ِتاریخ پایان قراداد باید بزرگتر از تاریخ قرارداد جاری  باشد ");
                HassError = true;
            }
            else if (telTextBox.Text == "")
            {
                errorProvider.SetError(telTextBox, "ِلطفا شماره تلفن را وارد کنید ");
                HassError = true;
            }
            else if (addressTextBox.Text == "")
            {
                errorProvider.SetError(addressTextBox, "ِلطفا آدرس را وارد کنید ");
                HassError = true;
            }
            else if (emailTextBox.Text != "")
            {
                if ((Helper.IsValidEmail(emailTextBox.Text) != true))
                {
                    errorProvider.SetError(emailTextBox, "ِلطفا آدرس ایمیل رادرست وارد کنید ");
                    HassError = true;
                }
            }
            else if (isActiveCheckBox.CheckState == CheckState.Indeterminate)
            {
                errorProvider.SetError(isActiveCheckBox, "لطفا شاغل بودن پرسنل را مشخص کنید");
                HassError = true;
            }


        }

        /*      private void LastSum()
              {
                  int vsalary, vmaskan, vOlad, vkharobar, vSakhtikar, vSarparsti, vNobatekari;

                  try
                  {
                      if (string.IsNullOrEmpty(lastSalaryTextBox.Text))
                      {
                          nobateKariTextBox2.Text = "";
                          vNobatekari = 0;
                          vsalary = 0;
                          vmaskan = 0;
                      }
                      else
                          vsalary = GetDigitToString(lastSalaryTextBox.Text);

                      if (string.IsNullOrEmpty(maskanTextBox2.Text))
                          vmaskan = 0;
                      else
                          vmaskan = GetDigitToString(maskanTextBox2.Text);

                      if (string.IsNullOrEmpty(oladTextBox2.Text))
                          vOlad = 0;
                      else
                          vOlad = GetDigitToString(oladTextBox2.Text);

                      if (string.IsNullOrEmpty(kharobarTextBox2.Text))
                          vkharobar = 0;
                      else
                          vkharobar = GetDigitToString(kharobarTextBox2.Text);

                      if (string.IsNullOrEmpty(sarparstiTextBox2.Text))
                          vSarparsti = 0;
                      else
                          vSarparsti = GetDigitToString(sarparstiTextBox2.Text);

                      if (string.IsNullOrEmpty(sakhtikarTextBox2.Text))
                          vSakhtikar = 0;
                      else
                          vSakhtikar = GetDigitToString(sakhtikarTextBox2.Text);

                      if (string.IsNullOrEmpty(nobateKariTextBox2.Text))
                          vNobatekari = 0;
                      else
                          vNobatekari = GetDigitToString(nobateKariTextBox2.Text);

                      lastSumSalaryTextBox.Text = Convert.ToString(vsalary +
                                            vmaskan +
                                            vOlad +
                                            vkharobar +
                                            vSarparsti +
                                            vSakhtikar +
                                            vNobatekari);
                  }
                  catch (Exception exp)
                  {
                      MessageBox.Show(exp.Message);
                  }

              }
              */

        private int GetDigitToString(string value)
        {
            try
            {
                string tmp = string.Empty;
                foreach (char item in value)
                {
                    if (char.IsDigit(item))
                        tmp += item;
                }
                return int.Parse(tmp);
            }
            catch
            {
                return 0;
            }

        }



        private void previewFilePic(string FileName)
        {
            try
            {
                if (!string.IsNullOrEmpty(FileName))
                {
                    using (FileStream fstPersons = new FileStream(FileName, FileMode.Open))
                    {
                        Image Image1 = new Bitmap(fstPersons);
                        SizeF SizeImage = Image1.PhysicalDimension;
                        double w = SizeImage.Width;
                        double h = SizeImage.Height;
                        pathFilePicture = FileName;
                        imgObject = new Bitmap(fstPersons);
                        imgObject = new Bitmap(imgObject, pictureBox.Width, pictureBox.Height);
                        pictureBox.Image = imgObject;
                        fstPersons.Close();
                    }
                }

            }
            catch (Exception Exp)
            {
                if (Exp.GetType() == typeof(FileNotFoundException))
                    NullPictureBox();
                else
                    MessageBox.Show(Exp.Message);
            }
        }

        private void NullPictureBox()
        {
            imgObject = null;
            pictureBox.Image = imgObject;
        }

        void FillCurrentPersonnel()
        {
            currentPersonnelNumber = personnelNumberTextBox.Text;
            errorProvider.Clear();
            personnelID = personnel.Id;

            #region Fill Fileds
            if (personnel.MajorId != null)
            {
                Major major = db.Majors.Single(c => c.Id == personnel.MajorId);
                majorsTextBox.Text = major.Name;
                personnel.MajorId = major.Id;
            }
            if (personnel.MilitaryServiceStatusId != null)
            {
                MilitaryServiceStatus militaryServiceStatus = db.MilitaryServiceStatus.Single(c => c.Id == personnel.MilitaryServiceStatusId);
                militaryServiceStatusNameTextBox.Text = militaryServiceStatus.Title;
                personnel.MilitaryServiceStatusId = militaryServiceStatus.Id;
            }
            if (personnel.ContractTypeId != null)
            {
                ContractType contractType = db.ContractTypes.Single(c => c.Id == personnel.ContractTypeId);
                kindsOfContractNameTextBox.Text = contractType.Name;
                personnel.ContractTypeId = contractType.Id;
            }
            if (personnel.UniversityDegreeId != null)
            {
                UniversityDegree universityDegree = db.UniversityDegrees.Single(c => c.Id == personnel.UniversityDegreeId);
                universityDegreeTextBox.Text = universityDegree.Name;
                personnel.UniversityDegreeId = universityDegree.Id;
            }

            if (personnel.DepartmentId != null)
            {
                Department department = db.Departments.Single(c => c.Id == personnel.DepartmentId);
                departmentNameTextBox.Text = department.Name;
                personnel.DepartmentId = department.Id;

            }

            #endregion

            if (!string.IsNullOrEmpty(personnelNumberTextBox.Text))
                previewFilePic(Properties.Settings.Default.PathPersonnelsImage + personnelNumberTextBox.Text + ".jpg");
            else
                NullPictureBox();

            // CurrentSum();
            //  LastSum();

            if (FormStatusEditing)
                returnButton.Visible = true;
            else returnButton.Visible = false;


        }

        private Boolean HassPersonNumric(int PersonnelNumeric, bool? StatusEditFrm, int? personnelID)
        {
            bool hassPerson = false;
            int findpersonnelId = 0;

            int countPersonnel = db.Personnels.Count(c => Convert.ToInt32(c.PersonnelNumber) == PersonnelNumeric);

            if (countPersonnel != 0)
                findpersonnelId = db.Personnels.Single(c => Convert.ToInt32(c.PersonnelNumber) == PersonnelNumeric).Id;

            if (countPersonnel > 0)
            {
                if (StatusEditFrm == true && (countPersonnel == 1 || countPersonnel == 0) && findpersonnelId == personnelID)
                    hassPerson = false;
                else
                    hassPerson = true;
            }
            else
                hassPerson = false;

            return hassPerson;
        }

        #endregion

        /*   #region methodaye hoghogh va dastmozd

        private void oladTextBox_TextChanged(object sender, EventArgs e)
        {
            CurrentSum();
            numberToWordTextBox.Text = ToWords.ToString(GetDigitToString(sumCurremtSalaryTextBox.Text));
        }

        private void shiftPercentTextBox_TextChanged(object sender, EventArgs e)
        {
            GetCalculationShiftPercent(3);
            CurrentSum();
            LastSum();
            PersonnelbindingSource.EndEdit();

        }

        private void lastSalaryTextBox_TextChanged(object sender, EventArgs e)
        {
            GetCalculationShiftPercent(2);
            LastSum();
        }

        private void oladTextBox2_TextChanged(object sender, EventArgs e)
        {
            LastSum();
        }

        private void salaryTextBox_TextChanged(object sender, EventArgs e)
        {
            GetCalculationShiftPercent(1);
            CurrentSum();
            numberToWordTextBox.Text = ToWords.ToString(GetDigitToString(sumCurremtSalaryTextBox.Text));
        }

        #endregion*/

        private void selectUniversityDegreeButton_Click(object sender, EventArgs e)
        {
            DialogForms.UniversityDegreesDialogForm universityDegreesDialogForm = new UniversityDegreesDialogForm();

            if (universityDegreesDialogForm.ShowDialog() == DialogResult.OK)
            {
                if (universityDegreesDialogForm.SelectedUniversityDegree == null)
                {
                    personnel.UniversityDegreeId = null;
                    universityDegreeTextBox.Text = string.Empty;
                }
                else
                {
                    personnel.UniversityDegreeId = universityDegreesDialogForm.SelectedUniversityDegree.Id;
                    universityDegreeTextBox.Text = universityDegreesDialogForm.SelectedUniversityDegree.Name;
                }
            }
        }

        private void majorsButton_Click(object sender, EventArgs e)
        {
            DialogForms.MajorsDialogForm majorsDialogForm = new MajorsDialogForm();

            //frmMajorsnew.FormBorderStyle = FormBorderStyle;
            if (majorsDialogForm.ShowDialog() == DialogResult.OK)
            {

                if (majorsDialogForm.SelectedMajor == null)
                {
                    personnel.MajorId = null;
                    majorsTextBox.Text = string.Empty;
                }
                else
                {
                    personnel.MajorId = majorsDialogForm.SelectedMajor.Id;
                    majorsTextBox.Text = majorsDialogForm.SelectedMajor.Name;
                }

            }
        }

        private void selectMilitaryServiceStatusButton_Click(object sender, EventArgs e)
        {

            DialogForms.MilitaryServiceStatusDialogForm militaryServiceStatusDialogForm = new MilitaryServiceStatusDialogForm();
            if (militaryServiceStatusDialogForm.ShowDialog() == DialogResult.OK)
            {

                if (militaryServiceStatusDialogForm.SelectedMilitaryServiceStatus == null)
                {
                    personnel.MilitaryServiceStatusId = null;
                    militaryServiceStatusNameTextBox.Text = string.Empty;
                }
                else
                {
                    personnel.MilitaryServiceStatusId = militaryServiceStatusDialogForm.SelectedMilitaryServiceStatus.Id;
                    militaryServiceStatusNameTextBox.Text = militaryServiceStatusDialogForm.SelectedMilitaryServiceStatus.Title;
                }
            }
        }

        private void selectkindsOfContractButton_Click(object sender, EventArgs e)
        {
            DialogForms.ContractTypeDialogForm contractTypeDialogForm = new ContractTypeDialogForm();

            if (contractTypeDialogForm.ShowDialog() == DialogResult.OK)
            {
                if (contractTypeDialogForm.SelectedContractType == null)
                {
                    personnel.ContractTypeId = null;
                    kindsOfContractNameTextBox.Text = string.Empty;
                }
                else
                {
                    personnel.ContractTypeId = contractTypeDialogForm.SelectedContractType.Id;
                    kindsOfContractNameTextBox.Text = contractTypeDialogForm.SelectedContractType.Name;
                }
            }
        }

        private void departmentButton_Click(object sender, EventArgs e)
        {
            DialogForms.DepartmentsDialogForm departmentsDialogForm;
            Department currentDepartment = personnel.Department;
            if (currentDepartment != null)
                departmentsDialogForm = new DepartmentsDialogForm(db, currentDepartment.Id, currentDepartment.DepartmentVersionID);
            else
                departmentsDialogForm = new DepartmentsDialogForm(db, null, null);


            if (departmentsDialogForm.ShowDialog() == DialogResult.OK)
            {
                if (departmentsDialogForm.SelectedDepartment == null)
                {
                    personnel.Department = null;
                    personnel.DepartmentId = null;
                    departmentNameTextBox.Text = string.Empty;
                }
                else
                {
                    personnel.Department = departmentsDialogForm.SelectedDepartment;
                    departmentNameTextBox.Text = departmentsDialogForm.SelectedDepartment.Name;
                }
            }


        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            try
            {
                db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
                Personnel PrviewPersonnel = db.Personnel_NextPersonnelNumber(currentPersonnelNumber).Single();
                FormStatusEditing = true;
                int personnelID = PrviewPersonnel.Id;
                personnel = db.Personnels.Single(c => c.Id == personnelID);
                this.Text = " نام و نام خانوادگی: " + personnel.FirstName + " " + personnel.LastName + "      " + "شماره پرسنلی : " + personnel.PersonnelNumber;
                PersonnelbindingSource.DataSource = personnel;
                OrganizationStructurePersonnel x = db.OrganizationStructurePersonnels.SingleOrDefault(c => c.PersonnelId == personnel.Id && c.IsMainPosition == true);
                DepartmentPersonnel y = db.DepartmentPersonnels.SingleOrDefault(c => c.PersonnelID == personnel.Id && c.IsActiveDepartment == true);
                if (x != null)
                    roleStructurtextBox.Text = x.RoleName;
                else
                    roleStructurtextBox.Text = "";


                if (y != null)
                    sectionTextBox.Text = y.DepartmentName;
                else
                    sectionTextBox.Text = "";
                LastPersonnelID = personnel.Id;
                FillCurrentPersonnel();

            }
            catch
            {
            }
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            try
            {
                db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
                Personnel PrviewPersonnel = db.Personnel_PreviewPersonnelNumber(currentPersonnelNumber).Single();
                FormStatusEditing = true;
                int personnelID = PrviewPersonnel.Id;
                personnel = db.Personnels.Single(c => c.Id == personnelID);
                PersonnelbindingSource.DataSource = personnel;
                this.Text = " نام و نام خانوادگی: " + personnel.FirstName + " " + personnel.LastName + "      " + "شماره پرسنلی : " + personnel.PersonnelNumber;
                OrganizationStructurePersonnel x = db.OrganizationStructurePersonnels.SingleOrDefault(c => c.PersonnelId == personnel.Id && c.IsMainPosition == true);
                DepartmentPersonnel y = db.DepartmentPersonnels.SingleOrDefault(c => c.PersonnelID == personnel.Id && c.IsActiveDepartment == true);
                if (x != null)
                    roleStructurtextBox.Text = x.RoleName;
                else
                    roleStructurtextBox.Text = "";


                if (y != null)
                    sectionTextBox.Text = y.DepartmentName;
                else
                    sectionTextBox.Text = "";

                FillCurrentPersonnel();
                LastPersonnelID = personnel.Id;
            }
            catch
            {

            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (isActiveCheckBox.Checked == false)
                {
                    SettlementDialogForm settlementDialogForm = new SettlementDialogForm()
                    {
                        Personnel = personnel,
                        FormStatus=FormStatus.Add
                    };
                    if (settlementDialogForm.ShowDialog() == DialogResult.OK)
                    {
                        isActiveCheckBox.Checked = false;
                    }
                    //else
                    //    isActiveCheckBox.Checked = true;

                }

                isvalidControl();
                if (HassError == false)
                {
                    if (FormStatusEditing == false)
                    {
                        if (!string.IsNullOrEmpty(personnelNumberTextBox.Text))
                        {
                            if (HassPersonNumric(Convert.ToInt32(personnelNumberTextBox.Text), null, null) == false)
                            {
                                isvalidControl();
                                db.Personnels.InsertOnSubmit(personnel);
                                foreach (PersonnelsChildren personnelsChildren in personnelsChildrensBindingSource.List)
                                {
                                    if (personnelsChildren.FirstName != null && personnelsChildren.LatName != null)
                                    {
                                        personnelsChildren.Personnel = personnel;
                                        db.PersonnelsChildrens.InsertOnSubmit(personnelsChildren);
                                    }
                                    else
                                    {
                                        personnelsChildren.Personnel = null;
                                    }
                                }
                                db.SubmitChanges();
                                Helper.ShowMessage("ثبت شد");
                                this.DialogResult = DialogResult.OK;
                            }
                            else errorProvider.SetError(personnelNumberTextBox, "این شماره قبلا در سیستم ثبت شده\n" + "لطفا شماره دیگری انتخاب کنید ");
                        }
                        else
                            errorProvider.SetError(personnelNumberTextBox, "شماره پرسنلی را تخصیص دهید!");
                    }

                    ///**************************STATUS EDITING FORM************************************///    
                    if (FormStatusEditing == true)
                    {


                        if (string.IsNullOrEmpty(personnelNumberTextBox.Text))
                            Helper.ShowMessage("شماره پرسنلی را وارد کنید");
                        else
                        {
                            if (HassPersonNumric(Helper.GetInt(personnelNumberTextBox), true, personnelID) == false)
                            {


                                isvalidControl();
                                PersonnelbindingSource.EndEdit();
                                db.SubmitChanges();
                                Helper.ShowMessage("تغییرات ثبت شد");
                            }
                            else
                            {
                                errorProvider.SetError(personnelNumberTextBox, "این شماره قبلا در سیستم ثبت شده\n" + "لطفا شماره دیگری انتخاب کنید ");
                                mainDetailsPersonnelTabPage.SelectedIndex = 0;
                            }
                        }
                    }
                }
                else
                {
                    errorProvider.SetError(saveButton, "در اطلاعات وارد شده خطا وجود دارد لطفا پس از رفع خطا اقدام به ذخیره اطلاعات نمائید");
                    mainDetailsPersonnelTabPage.SelectedIndex = 0;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (FormStatusEditing)
            {
                db = new JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
                personnel = db.Personnels.Single(c => c.Id == LastPersonnelID);
                PersonnelbindingSource.DataSource = personnel;
                FillCurrentPersonnel();
            }
            else
                this.Close();
        }

        private void savePictureButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (!string.IsNullOrEmpty(pathFilePicture))
                {
                    if (!string.IsNullOrEmpty(personnelNumberTextBox.Text))
                    {
                        if (FileManager.Addfile(personnelNumberTextBox.Text, pathFilePicture) != false)
                            Helper.ShowMessage("ثبت شد");
                    }
                }

            }
            catch
            { }
        }

        /*   private void shiftValueLeftToRightTextBox_Click(object sender, EventArgs e)
           {
               lastSalaryTextBox.Text = salaryTextBox.Text;
               oladTextBox2.Text = oladTextBox.Text;
               maskanTextBox2.Text = maskanTextBox.Text;
               kharobarTextBox2.Text = kharobarTextBox.Text;
               sarparstiTextBox2.Text = sarparstiTextBox.Text;
               sakhtikarTextBox2.Text = sakhtikarTextBox.Text;
               salaryTextBox.Text = string.Empty;
               oladTextBox.Text = string.Empty;
               maskanTextBox.Text = string.Empty;
               kharobarTextBox.Text = string.Empty;
               sarparstiTextBox.Text = string.Empty;
               sakhtikarTextBox.Text = string.Empty;
           }

           private void shiftValueRightToLeftButton_Click(object sender, EventArgs e)
           {
               salaryTextBox.Text = lastSalaryTextBox.Text;
               oladTextBox.Text = oladTextBox2.Text;
               maskanTextBox.Text = maskanTextBox2.Text;
               kharobarTextBox.Text = kharobarTextBox2.Text;
               sarparstiTextBox.Text = sarparstiTextBox2.Text;
               sakhtikarTextBox.Text = sakhtikarTextBox2.Text;

               maskanTextBox2.Text = string.Empty;
               lastSalaryTextBox.Text = string.Empty;
               oladTextBox2.Text = string.Empty;
               kharobarTextBox2.Text = string.Empty;
               sarparstiTextBox2.Text = string.Empty;
               sakhtikarTextBox2.Text = string.Empty;
           }*/

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (FileManager.DeleteFile(Properties.Settings.Default.PathPersonnelsImage + personnelNumberTextBox.Text + ".jpg") != false)
                {
                    NullPictureBox();
                    Helper.ShowMessage("حذف شد");
                }
            }
            catch (Exception exp)
            {
                Helper.ShowMessage(exp.Message);
            }
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog OpenDialog1 = new OpenFileDialog();
            OpenDialog1.Filter = "Pictures (JPG)|*.jpg";
            if (OpenDialog1.ShowDialog() == DialogResult.OK)
            {
                previewFilePic(OpenDialog1.FileName);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
                returnButton_Click(null, null);

            if (keyData == Keys.F9)
                payRollButton_Click(null, null);

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void payRollButton_Click(object sender, EventArgs e)
        {

            if (personnel != null)
            {
                if (personnel.IsInFactory == 2)
                {
                    if (User.AuthenticationManager.IsActionAvailable("PersonnelSearchForm-HeadOfficeSalary"))
                    {
                        PersonnelPayRollDialogForm personnelPayRollDialogForm = new PersonnelPayRollDialogForm() { Current = personnel };

                        personnelPayRollDialogForm.ShowDialog();
                    }
                    else
                    {
                        Jamsaz.Common.UI.DialogForms.MessageDialogForm messageDialogForm = new MessageDialogForm();

                        messageDialogForm.ShowDialog();
                    }
                }
                else
                {
                    PersonnelPayRollDialogForm personnelPayRollDialogForm = new PersonnelPayRollDialogForm() { Current = personnel };

                    personnelPayRollDialogForm.ShowDialog();
                }

                //DialogForms.PayRollForCurrentUserDialogForm payRollForCurrentUserDialogForm = new PayRollForCurrentUserDialogForm(personnel.Id);
                //payRollForCurrentUserDialogForm.ShowDialog();
            }

        }

        private void responsiblePersonnelNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                Personnel responsible = db.Personnels.SingleOrDefault(c => c.PersonnelNumber == responsiblePersonnelNumberTextBox.Text);

                if (responsible != null)
                {
                    this.personnel.Personnel1 = responsible;
                }
            }
        }

        private void administratorPersonnelNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                Personnel administrator = db.Personnels.SingleOrDefault(c => c.PersonnelNumber == administratorPersonnelNumberTextBox.Text);

                if (administrator != null)
                {
                    this.personnel.Personnel2 = administrator;
                }
            }
        }

        private void managerPersonnelNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                Personnel manager = db.Personnels.SingleOrDefault(c => c.PersonnelNumber == managerPersonnelNumberTextBox.Text);

                if (manager != null)
                {
                    this.personnel.Personnel3 = manager;
                }
            }
        }

        private void selectResponsibleButton_Click(object sender, EventArgs e)
        {
            PersonnelListForm personnelListForm = new PersonnelListForm(db) { IsActive = Convert.ToBoolean(personnel.IsActive) };

            if (personnelListForm.ShowDialog() == DialogResult.OK)
            {
                this.personnel.Personnel2 = personnelListForm.Personnel;
            }
        }

        private void selectAdministratorButton_Click(object sender, EventArgs e)
        {
            PersonnelListForm personnelListForm = new PersonnelListForm(db) { IsActive = Convert.ToBoolean(personnel.IsActive) };

            if (personnelListForm.ShowDialog() == DialogResult.OK)
            {
                this.personnel.Personnel3 = personnelListForm.Personnel;
            }
        }

        private void selectManagerButton_Click(object sender, EventArgs e)
        {
            PersonnelListForm personnelListForm = new PersonnelListForm(db) { IsActive = Convert.ToBoolean(personnel.IsActive) };

            if (personnelListForm.ShowDialog() == DialogResult.OK)
            {
                this.personnel.Personnel1 = personnelListForm.Personnel;
            }
        }

        private void deletechildrenButton_Click(object sender, EventArgs e)
        {
            PersonnelsChildren current = (PersonnelsChildren)this.personnelsChildrensBindingSource.Current;

            if (current == null)
                return;

            if (current.ID == 0)
            {
                current.Personnel = null;

                try
                {
                    this.personnelsChildrensBindingSource.RemoveCurrent();
                }
                catch { }
            }
            else
            {
                db.PersonnelsChildrens.DeleteOnSubmit(current);
                this.personnelsChildrensBindingSource.RemoveCurrent();
            }
        }

        private void StructureButton_Click(object sender, EventArgs e)
        {
            RolesStructureDialogForm RolesStructureForm;


            OrganizationStructurePersonnel organizationStructurepersonnel = db.OrganizationStructurePersonnels.SingleOrDefault(c => c.PersonnelId == personnel.Id && c.IsMainPosition == true);
            if (organizationStructurepersonnel != null)
                RolesStructureForm = new RolesStructureDialogForm(db, organizationStructurepersonnel.OrganisationStructureId, organizationStructurepersonnel.OrganizationStructure.OrganizationStructureVersionID);
            else
                RolesStructureForm = new RolesStructureDialogForm(db, null, null);



            if (RolesStructureForm.ShowDialog() == DialogResult.OK)
            {
                if (RolesStructureForm.SelectedOrganizationStructure == null)
                {
                    if (db.OrganizationStructurePersonnels.Count(c => c.PersonnelId == personnel.Id && c.IsMainPosition == true) != 0)
                    {
                        roleStructurtextBox.Text = db.OrganizationStructurePersonnels.SingleOrDefault(c => c.PersonnelId == personnel.Id && c.IsMainPosition == true).RoleName;
                    }

                }
                else
                {
                    roleStructurtextBox.Text = RolesStructureForm.SelectedOrganizationStructure.Name;
                    OrganizationStructurePersonnel = new OrganizationStructurePersonnel()
                    {
                        Personnel = this.personnel,
                        OrganisationStructureId = db.OrganizationStructures.SingleOrDefault(c => c.Id == RolesStructureForm.SelectedOrganizationStructure.Id).Id,
                        IsMainPosition = true
                    };

                    if (db.OrganizationStructurePersonnels.Any(c => c.PersonnelId == personnel.Id && c.IsMainPosition == true))
                    {
                        OrganizationStructurePersonnel temp = db.OrganizationStructurePersonnels.SingleOrDefault(c => c.PersonnelId == personnel.Id && c.IsMainPosition == true);
                        temp.IsMainPosition = false;
                    }
                    db.OrganizationStructurePersonnels.InsertOnSubmit(OrganizationStructurePersonnel);
                }
            }



        }

        private void sectionButton_Click(object sender, EventArgs e)
        {
            DialogForms.DepartmentsDialogForm departmentsDialogForm;
            DepartmentPersonnel currentDepartment = db.DepartmentPersonnels.SingleOrDefault(c => c.PersonnelID == personnel.Id && c.IsActiveDepartment == true);
            if (currentDepartment != null)
                departmentsDialogForm = new DepartmentsDialogForm(db, currentDepartment.DepartmentID, currentDepartment.Department.DepartmentVersionID);
            else
                departmentsDialogForm = new DepartmentsDialogForm(db, null, null);


            if (departmentsDialogForm.ShowDialog() == DialogResult.OK)
            {
                if (departmentsDialogForm.SelectedDepartment == null)
                {


                    if (db.DepartmentPersonnels.Count(c => c.PersonnelID == personnel.Id && c.IsActiveDepartment == true) != 0)
                    {
                        departmentNameTextBox.Text = db.DepartmentPersonnels.SingleOrDefault(c => c.PersonnelID == personnel.Id && c.IsActiveDepartment == true).DepartmentName;
                    }
                }
                else
                {

                    sectionTextBox.Text = departmentsDialogForm.SelectedDepartment.Name;

                    DepartmentPersonnel oldDepartment = db.DepartmentPersonnels.SingleOrDefault(c => c.PersonnelID == personnel.Id && c.DepartmentID == departmentsDialogForm.SelectedDepartment.Id);

                    if (oldDepartment != null)
                    {
                        oldDepartment.IsActiveDepartment = true;
                        if (currentDepartment != null)
                            currentDepartment.IsActiveDepartment = false;
                    }
                    else
                    {


                        departmentPersonnel = new DepartmentPersonnel()
                        {
                            Personnel = this.personnel,
                            DepartmentID = db.Departments.SingleOrDefault(c => c.Id == departmentsDialogForm.SelectedDepartment.Id).Id,
                            IsActiveDepartment = true
                        };


                        if (db.DepartmentPersonnels.Any(c => c.PersonnelID == personnel.Id && c.IsActiveDepartment == true))
                        {
                            DepartmentPersonnel temp = db.DepartmentPersonnels.SingleOrDefault(c => c.PersonnelID == personnel.Id && c.IsActiveDepartment == true);
                            temp.IsActiveDepartment = false;
                        }
                        db.DepartmentPersonnels.InsertOnSubmit(departmentPersonnel);
                    }


                }
            }
        }

        private void isActiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bankAccountButton_Click(object sender, EventArgs e)
        {
            if (personnelID > 0)
            {
                var personelBankAccountDialogForm = new PersonelBankAccountDialogForm
                {
                    PersonID = personnelID
                };
                personelBankAccountDialogForm.ShowDialog();
            }
            else
            {
                Helper.ShowMessage("لطفا ابتدا شخص را ذخیره کنید سپس دوباره آن را ویرایش و حساب بانکی را تعریف نمایید");
            }
        }
    }
}
