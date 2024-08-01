using Jamsaz.Common;
using Jamsaz.PersonnlsApplication.BusinessObjects.Data;

namespace Jamsaz.PersonnlsApplication.UI.DialogForms
{
    public partial class SetShabaForPersonnelDialogForm : BasePersianForm
    {
        JamsazERPLiteDataClassesDataContext db = new JamsazERPLiteDataClassesDataContext();
        public SetShabaForPersonnelDialogForm()
        {
            InitializeComponent();
        }

    //    private void shabaGeneratorButton_Click(object sender, EventArgs e)
    //    {
    //        var query =
    //$"select * from hrm.Personnel where cast(PersonnelNumber as int) >= {int.Parse(maskedTextBox1.Text)} and cast(PersonnelNumber as int) <= {int.Parse(maskedTextBox2.Text)} and BankAccount is not null";
    //        var dataes = db.ExecuteQuery<Personnel>(query);
    //        var messages = "";
    //        foreach (var personnel in dataes)
    //        {
    //            var codeGenerator = new ShabaCodeGenerator(personnel.);
    //            var sheba = codeGenerator.Generate();
    //            if (sheba != "")
    //            {
    //                personnel.Shaba = sheba;
    //                var p = db.Personnels.FirstOrDefault(x => x.Id == personnel.Id);
    //                if (p == null) continue;
    //                p.Shaba = sheba;
    //                db.SubmitChanges();
    //            }
    //            else
    //            {
    //                messages += $"[{personnel.PersonnelNumber}],";
    //            }
    //        }
    //        if (string.IsNullOrEmpty(messages))
    //            Helper.ShowMessage("شماره شبا مورد نظر ساخته شد");
    //        else
    //            Helper.ShowMessage("شماره شبا برای پرسنل زیر ساخته نشد : \n" + messages);
    //        maskedTextBox1.Text = "";
    //        maskedTextBox2.Text = "";
    //    }

    //    private void ShabaGenerator()
    //    {
    //        const string a1A3 = "017"; //bankmeli
    //        const string cccd = "182700";
    //        var query =
    //            $"select * from hrm.Personnel where cast(PersonnelNumber as int) >= {int.Parse(maskedTextBox1.Text)} and cast(PersonnelNumber as int) <= {int.Parse(maskedTextBox2.Text)} and BankAccount is not null";
    //        var dataes = db.ExecuteQuery<Personnel>(query);
    //        var messages = "";
    //        foreach (var personnel in dataes)
    //        {
    //            var b2B19 = personnel.BankAccount; // shomarehesab
    //            const string b1 = "0"; //sepordeh
    //            var instance = decimal.Parse($"{a1A3}{b1}00000{b2B19}{cccd}");
    //            var res = Math.Abs((instance % 97) - 98).ToString(CultureInfo.InvariantCulture);
    //            if (res.Length == 1) res = "0" + res;
    //            var sheba = $"IR{res}{a1A3}{b1}00000{b2B19}";
    //            if (sheba.Length == 26)
    //            {
    //                sheba = $"IR{res} {a1A3}{b1} 0000 0{CreateSplitedString(b2B19)}";
    //                personnel.Shaba = sheba;
    //                var p = db.Personnels.FirstOrDefault(x => x.Id == personnel.Id);
    //                if (p == null) continue;
    //                p.Shaba = sheba;
    //                db.SubmitChanges();
    //            }
    //            else
    //            {
    //                messages += $"[{personnel.PersonnelNumber}],";
    //            }
    //        }
    //        if (string.IsNullOrEmpty(messages))
    //            Helper.ShowMessage("شماره شبا مورد نظر ساخته شد");
    //        else
    //            Helper.ShowMessage("شماره شبا برای پرسنل زیر ساخته نشد : \n" + messages);
    //        maskedTextBox1.Text = "";
    //        maskedTextBox2.Text = "";
    //    }

    //    private string CreateSplitedString(string input)
    //    {
    //        var first = input.Substring(0, 3);
    //        var secound = input.Substring(3, 4);
    //        var third = input.Substring(7, 4);
    //        var last = input.Substring(11, 2);
    //        return $"{first} {secound} {third} {last}";
    //    }
    }
}
