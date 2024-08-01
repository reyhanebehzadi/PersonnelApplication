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

namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class PaymentDialogForm : BasePersianForm
    {
        public EidRegistration Selected { get; set; }
        public JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        public EidRegistration EidRegistration { get; set; }
        public PaymentDialogForm()
        {
            InitializeComponent();
        }
        
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Helper.Confirm("آیا مایل به ثبت اطلاعات هستید؟"))
            {
                db.SubmitChanges();
                DialogResult = DialogResult.OK;
            }
            
        }

        private void PaymentDialogForm_Load(object sender, EventArgs e)
        {
            EidRegistration = db.EidRegistrations.SingleOrDefault(c => c.ID == Selected.ID);
            payTypeBindingSource.DataSource = db.PayTypes;
            eidRegistrationBindingSource.DataSource = EidRegistration;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void allcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (allcheckBox.Checked)
            {
                p1CheckBox.Checked = p2CheckBox.Checked = p3CheckBox.Checked = p4CheckBox.Checked = p5CheckBox.Checked = p6CheckBox.Checked = p7CheckBox.Checked = p8CheckBox.Checked = p9CheckBox.Checked
                    = p10CheckBox.Checked = p11CheckBox.Checked = p12CheckBox.Checked = true;

                this.EidRegistration.P1 = this.EidRegistration.P2 = this.EidRegistration.P3 = this.EidRegistration.P4 = this.EidRegistration.P5 = this.EidRegistration.P6 = this.EidRegistration.P7 = this.EidRegistration.P8 = this.EidRegistration.P9 = this.EidRegistration.P10 = this.EidRegistration.P11 = this.EidRegistration.P12 = true;
            }
            else
            {
                p1CheckBox.Checked = p2CheckBox.Checked = p3CheckBox.Checked = p4CheckBox.Checked = p5CheckBox.Checked = p6CheckBox.Checked = p7CheckBox.Checked = p8CheckBox.Checked = p9CheckBox.Checked
                    = p10CheckBox.Checked = p11CheckBox.Checked = p12CheckBox.Checked = false;
                this.EidRegistration.P1 = this.EidRegistration.P2 = this.EidRegistration.P3 = this.EidRegistration.P4 = this.EidRegistration.P5 = this.EidRegistration.P6 = this.EidRegistration.P7 = this.EidRegistration.P8 = this.EidRegistration.P9 = this.EidRegistration.P10 = this.EidRegistration.P11 = this.EidRegistration.P12 = false;
            }
        }
    }
}
