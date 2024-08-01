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
using Jamsaz.PersonnlsApplication.UI.DialogForms;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class ContactDockForm : BasePersianForm
    {
        public ContactDockForm()
        {
            InitializeComponent();
        }

        private JamsazERPLiteDataClassesDataContext db;
        public Contact Contact { get; set; }
        public FormStatus FormStatus;


        private void LoadData()
        {
            db = new JamsazERPLiteDataClassesDataContext();
            getContactsResultBindingSource.DataSource = db.GetContacts(4,string.Empty,string.Empty);
        }

        private void ContactDockForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddContactsDiaolgForm AddContactsDiaolgForm = new AddContactsDiaolgForm() { FormStatus = FormStatus.Add };

            if (AddContactsDiaolgForm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (this.getContactsResultBindingSource.Current != null)
            {
                Contact contact = db.Contacts.SingleOrDefault(c => c.ID == ((GetContactsResult)getContactsResultBindingSource.Current).ID);
                AddContactsDiaolgForm AddContactsDiaolgForm = new AddContactsDiaolgForm()
                {
                    FormStatus = FormStatus.Edit,
                    Contact = contact
                };

                if (AddContactsDiaolgForm.ShowDialog() == DialogResult.OK)
                {
                    db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, contact);
                    LoadData();
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (getContactsResultBindingSource.Current != null)
            {
                if (Helper.Confirm("آیا مایل به حذف اطلاعات هستید؟"))
                {
                    try
                    {
                        Contact currentContact = db.Contacts.SingleOrDefault(c => c.ID == ((GetContactsResult)getContactsResultBindingSource.Current).ID);

                        db.Contacts.DeleteOnSubmit(currentContact);
                        db.SubmitChanges();
                        LoadData();
                    }
                    catch
                    {
                        Helper.Error("امکان حذف این اطلاعات وجود ندارد");
                    }
                }

            }

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            getContactsResultBindingSource.DataSource = db.GetContacts(4,contactTextBox.Text,companyTextBox.Text);

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            getContactsResultBindingSource.DataSource = db.GetContacts(4, string.Empty, string.Empty);
            contactTextBox.Text = string.Empty;
            companyTextBox.Text = string.Empty;
        }

        private void contactTextBox_TextChanged(object sender, EventArgs e)
        {
            getContactsResultBindingSource.DataSource = db.GetContacts(4,contactTextBox.Text,companyTextBox.Text);
        }

        private void companyTextBox_TextChanged(object sender, EventArgs e)
        {
            getContactsResultBindingSource.DataSource = db.GetContacts(4,contactTextBox.Text,companyTextBox.Text);

        }
    }
}
