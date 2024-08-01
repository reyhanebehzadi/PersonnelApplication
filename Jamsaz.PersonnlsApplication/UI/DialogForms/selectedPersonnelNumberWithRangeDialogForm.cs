using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jamsaz.Common;

namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class selectedPersonnelNumberWithRangeDialogForm : BasePersianForm
    {
        int? currentPersonnelNumber = null;
        public selectedPersonnelNumberWithRangeDialogForm(int? currentPersonnelNumber)
        {
            InitializeComponent();
            
            this.currentPersonnelNumber = currentPersonnelNumber;

            this.effectiveDatePicker.SelectedDateTime = System.DateTime.Now;

            ADatepicker.SelectedDateTime = DateTime.Now;
        }

        private void selectedPersonnelNumberWithRangeDialogForm_Load(object sender, EventArgs e)
        {
            if (currentPersonnelNumber != null)
            {
                ToTextBox.Text = currentPersonnelNumber.ToString();
                FromTextBox.Text = currentPersonnelNumber.ToString();
            }
        }
        public int GetFrom { get; set; }
        public int GetTo { get; set; }
        public string PersonnelNumbers { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime ADate { get; set; }

        private void SelectedButton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (string.IsNullOrEmpty(FromTextBox.Text))
            {
                errorProvider.SetError(FromTextBox, "مقدار را وارد کنید");
            }
            else if (string.IsNullOrEmpty(ToTextBox.Text))
            {
                errorProvider.SetError(ToTextBox, "مقدار را وارد کنید");
            }
            else if (Helper.GetInt(FromTextBox.Text) > Helper.GetInt(ToTextBox.Text))
            {
                errorProvider.SetError(SelectedButton, "کوچکتر و بزرگتر بودن محدوده را رعایت کنید");
            }
            else
            {
                GetFrom = Helper.GetInt(FromTextBox.Text);
                GetTo = Helper.GetInt(ToTextBox.Text);
                if (pesonnelNumbersTextBox.Text.Trim() == string.Empty)
                    PersonnelNumbers = null;
                else
                    PersonnelNumbers = pesonnelNumbersTextBox.Text.TrimEnd(new char[] { ',' });

                EffectiveDate = effectiveDatePicker.SelectedDateTime.Value.Date;

                ADate = ADatepicker.SelectedDateTime.Value.Date;

                DialogResult = DialogResult.OK;
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
