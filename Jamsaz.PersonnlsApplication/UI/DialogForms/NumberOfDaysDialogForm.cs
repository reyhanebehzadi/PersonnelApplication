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
namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class NumberOfDaysDialogForm : BasePersianForm
    {
        public NumberOfDaysDialogForm(int selectedMonth)
        {
            InitializeComponent();
            switch (selectedMonth)
            {
                case 2:
                    Title = "فروردین";
                    break;
                case 3:
                    Title = "اردیبهشت";
                    break;
                case 4:
                    Title = "خرداد";
                    break;
                case 5:
                    Title = "تیر";
                    break;
                case 6:
                    Title = "مرداد";
                    break;
                case 7:
                    Title = "شهریور";
                    break;
                case 8:
                    Title = "مهر";
                    break;
                case 9:
                    Title = "آبان";
                    break;
                case 10:
                    Title = "آذر";
                    break;
                case 11:
                    Title = "دی";
                    break;
                case 12:
                    Title = "بهمن";
                    break;
                case 13:
                    Title = "اسفند";
                    break;
                default:
                    break;
            }
            this.Text = Title;
            
        }
       
        public int value { get; set; }
        private string Title;
        private void NumberOfDaysDialogForm_Load(object sender, EventArgs e)
        {
        
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (Helper.Confirm(string.Format("مقدار مورد نظر در تمامی ستون  ماه {0}  جایگزین میشود",Title) ))
            {
                value = int.Parse(numberTextBox.Text);
            }
            DialogResult = DialogResult.OK;
        }
    }
}
