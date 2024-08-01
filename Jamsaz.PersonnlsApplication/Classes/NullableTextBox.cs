using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace Jamsaz.PersonnlsApplication.Classes
{
    
    public class NullableTextBox : TextBox
    {
        private bool isNumeric;
        private bool isCurrency;
        private bool isrolesCode;
        ErrorProvider TextSetError = new ErrorProvider();
        bool HassError = false;

        [Browsable(true), Bindable(true), Category("Data")]
        public string NullableText
        {
            get
            {
                try
                {
                    if (this.Text.Trim() == String.Empty)
                        return null;
                    else
                        return this.Text;
                }
                catch
                {
                    return null;
                }
            }
            set
            {
                if (value == null)
                    this.Text = String.Empty;
                else
                    this.Text = value;
            }
        }

        [Browsable(true), Category("Behavior"), DefaultValue(false)]
        public bool IsNumeric
        {
            get
            {
                return isNumeric;
            }
            set
            {
                isNumeric = value;
                //if (value)
                //{
                //    this.RightToLeft = true;
                //    this.RtlTranslateAlignment(HorizontalAlignment.Left);
                //    this.RtlTranslateLeftRight(LeftRightAlignment.Left);
                //}
                    
            }
        }

        [Browsable(true), Category("Behavior"), DefaultValue(false)]
        public bool Iscurrency
        {
            get
            {
                return isCurrency;
            }
            set
            {
                isCurrency = value;
            }
        }

        [Browsable(true), Category("Behavior"), DefaultValue(false)]
        public bool IsRolesCode
        {
            get
            {
                return isrolesCode;
            }
            set
            {
                isrolesCode = value;
            }
        }


        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (isNumeric && !isCurrency && !(char.IsControl(e.KeyChar) || char.IsNumber(e.KeyChar) || char.IsSeparator(e.KeyChar)))
            {
                e.Handled = true;
                HassError = true;
            }

            if (isNumeric && isCurrency && !(char.IsNumber(e.KeyChar) ^ e.KeyChar.ToString() == "."))
            {
                e.Handled = true;
                HassError = true;
            }

            if (isrolesCode && !(char.IsNumber(e.KeyChar)) && !(e.KeyChar == '-') && !char.IsControl(e.KeyChar) )
            {
                e.Handled = true;
                HassError = true;
            }

            base.OnKeyPress(e);
        }

        private bool IsNum(string s)
        {
            try
            {
                Int32.Parse(s);
            }
            catch
            {
                return false;
            }
            return true;
        }

        protected override void OnLeave(EventArgs e)
        {
            if (IsNum(base.Text))
            {
                TextSetError.Clear();
                HassError = false;
            }
            base.OnLeave(e);
        }
    }
}
