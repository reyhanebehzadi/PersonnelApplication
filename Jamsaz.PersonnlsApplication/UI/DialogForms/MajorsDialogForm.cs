using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Linq;
using System.Linq;
using System.Data.Linq.Mapping;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;
using Jamsaz.Common;

namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class MajorsDialogForm : Form
    {
        public MajorsDialogForm()
        {
            InitializeComponent();
        }
        int? Selected;
        Jamsaz.PersonnlsApplication.BusinessObjects.Data.JamsazERPLiteDataClassesDataContext db = new Jamsaz.PersonnlsApplication.BusinessObjects.Data.JamsazERPLiteDataClassesDataContext(Properties.Settings.Default.JamsazERPLiteConnectionString);
        List<Major> MajorsName = new List<Major>(); 
        private void cmdSelect_Click(object sender, EventArgs e)
        {
            SelectedRow();
        }

        public  Major SelectedMajor { get; set; }
        public List<Major> SelectedMajorList { get; set; }
        public bool MultiSelect { get; set; }

        private void majorsDialogForm_Load(object sender, EventArgs e)
        {
            try
            {
                MajorsName = db.Majors.ToList();
                majorsBindingSource.DataSource = db.Majors;//MajorsName;

                if (MultiSelect)
                
                    majorsDataGridView.Columns[1].Visible = true;
                else
                    majorsDataGridView.Columns[1].Visible = false;
            }
            catch (Exception exp)
            {
                if (exp.GetType() == typeof(System.Data.SqlClient.SqlException))
                Helper.ShowMessage("خطا در ارتباط با بانک اطلاعاتی", " اتصال به بانک اطلاعاتی برقرار نیست " + "\n لطفا مشکل را به مسئول شبکه گزارش دهید\n ");
                else
                    Helper.ShowMessage(exp.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void majorsDataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 24)
                this.Close();

            if (e.KeyChar == 10)
            {
                SelectedRow();
            }

        }


        private void filterNameTextBox_TextChanged(object sender, EventArgs e)
        {
            majorsBindingSource.DataSource = MajorsName.Where(c => c.Name.Contains(filterNameTextBox.Text));
        }
        private void SelectedRow()
        {
            try
            {
                if (MultiSelect)
                {
                    if (!passNullCheckBox.Checked && majorsBindingSource.Current != null)
                    {
                       
                        SelectedMajorList = new List<Major>();
                        this.majorsDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);

                        foreach (Major item in MajorsName)
                        {
                            if (item.IsSelect)
                            {
                                SelectedMajorList.Add(item);
                            }
                        }
                    }
                    else
                    {
                        this.SelectedMajorList = null;
                    }
                }
                else
                {

                    if (!passNullCheckBox.Checked && majorsBindingSource.Current != null)
                    {
                        Major major = (Major)majorsBindingSource.Current;
                        this.SelectedMajor = major;

                    }
                    else
                    {
                        this.SelectedMajor = null;
                    }
                }

                
                this.DialogResult = DialogResult.OK;
            }
            catch { }
        }

        private void majorsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow();
        }

    }
}