using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using Jamsaz.PersonnlsApplication.Resources;

namespace Jamsaz.PersonnlsApplication.Classes
{
        public class enumBase<T>
        {
            public enumBase(T type)
            {
                this.Value = type;
            }

            public enumBase(int value)
            {
                object t = value;
                this.Value = (T)t;
            }

            public T Value;

            public override string ToString()
            {
                return Jamsaz.PersonnlsApplication.Resources.EnumNames.ResourceManager.GetString(this.Value.ToString());
                
            }

            public static string ToString(T type)
            {
                return Jamsaz.PersonnlsApplication.Resources.EnumNames.ResourceManager.GetString(type.ToString());
            }

            public int intValue
            {
                get
                {
                    object t = Value;
                    return (int)t;
                }
                set
                {
                    object t = value;
                    this.Value = (T)t;
                }
            }

            public static ArrayList getItems()
            {
                ArrayList returnItems = new ArrayList();
                foreach (int i in Enum.GetValues(typeof(T)))
                {
                    returnItems.Add(new enumBase<T>(i));
                }
                return returnItems;
            }
           


    }
}
