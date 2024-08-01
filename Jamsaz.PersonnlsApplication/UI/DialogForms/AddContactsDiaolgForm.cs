using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.PersonnlsApplication.BusinessObjects.Definitions;

namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class AddContactsDiaolgForm : BasePersianForm
    {
        public AddContactsDiaolgForm()
        {
            InitializeComponent();
        }

        public BusinessObjects.Definitions.FormStatus FormStatus { get; set; }
        public BusinessObjects.Data.Contact Contact { get; set; }
        private JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();

        private void SetData()
        {
            try
            {

                if (this.FormStatus == FormStatus.Add)
                {
                    this.Contact = new Contact();

                    this.Contact.ReferenceFlag = 4;

                    //this.Contact.ReferenceID = null;

                    this.contactBindingSource.DataSource = this.Contact;

                }
                else
                {
                    this.Contact = db.Contacts.Single(c => c.ID == this.Contact.ID);

                    contactBindingSource.DataSource = this.Contact;
                }
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(string.Format("{0}{1}{2}"
                                                            , "بروز خطا"
                                                            , "\n"
                                                            , ex.Message));
            }
        }

        private void AddContactsDiaolgForm_Load(object sender, EventArgs e)
        {
            SetData();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(Contact.ContactName == null && Contact.CompanyName == null)
                    return;

                contactBindingSource.EndEdit();

                if(telephonBindingSource.Count != 0)
                {
                    telephonBindingSource.MoveLast();
                    if (((Telephone)telephonBindingSource.Current).AreaCode == null && ((Telephone)telephonBindingSource.Current).Number == null)
                    {
                        ((Telephone)telephonBindingSource.Current).Contact = null;
                        telephonBindingSource.RemoveCurrent();
                    }
                }


                if (this.FormStatus == FormStatus.Add)
                    db.Contacts.InsertOnSubmit(this.Contact);

                db.SubmitChanges();

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                Helper.ShowMessage(string.Format("{0}{1}{2}"
                                                            , "بروز خطا"
                                                            , "\n"
                                                            , ex.Message));
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(telephonBindingSource.Count != 0)
            {
                telephonBindingSource.MoveLast();
                if(((Telephone)telephonBindingSource.Current).AreaCode == null && ((Telephone)telephonBindingSource.Current).Number == null )
                    return;
            }
            Telephone telephone = new Telephone();
            
            this.telephonBindingSource.Add(telephone);

            telephone.Contact = this.Contact;

            this.telephonBindingSource.MoveLast();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Telephone current = (Telephone)this.telephonBindingSource.Current;

            if (current == null)
                return;

            if (current.ID == 0)
            {
                current.Contact = null;

                this.telephonBindingSource.RemoveCurrent();
            }
            else
            {
                db.Telephones.DeleteOnSubmit(current);

                this.telephonBindingSource.RemoveCurrent();
            }
        }

        
    }
}
