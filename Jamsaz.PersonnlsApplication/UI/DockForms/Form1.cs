using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jamsaz.PersonnlsApplication.UI.DockForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Select file";
            fdlg.InitialDirectory = @"c:\";
            fdlg.FileName = textBox1.Text;
            fdlg.Filter = "DBF Files(*.dbf)|*.dbf|All Files(*.*)|*.*";
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fdlg.FileName;
                //import();
                System.Windows.Forms.Application.DoEvents();
            }

            DataTable dt = GetDataTableDBF(textBox1.Text);
            dataGridView1.DataSource = dt.DefaultView;

        }

        public static DataTable GetDataTableDBF(string strFileName)
        {
            System.Data.Odbc.OdbcConnection conn = new System.Data.Odbc.OdbcConnection("Driver={Microsoft Visual FoxPro Driver};SourceType=DBF;SourceDB=" + System.IO.Path.GetFullPath(strFileName).Replace(System.IO.Path.GetFileName(strFileName), "") + ";Exclusive=No");
            conn.Open();
            string strQuery = "SELECT * FROM [" + System.IO.Path.GetFileName(strFileName) + "]";
            System.Data.Odbc.OdbcDataAdapter adapter = new System.Data.Odbc.OdbcDataAdapter(strQuery, conn);
            System.Data.DataSet ds = new System.Data.DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }
    }
}
