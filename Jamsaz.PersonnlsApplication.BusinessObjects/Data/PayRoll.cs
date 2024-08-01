using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Windows.Forms;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
    public partial class PayRoll
    {
        int _PayRollsumm;
        public int PayRollSum
        {
            get
            {
                _PayRollsumm = ((this.Salary ?? 0) + (this.Haghekharobar ?? 0)
                                + (this.HagheMaskan ?? 0) +
                                (this.HagheOlad ?? 0) +
                                (this.HagheSakhtiKar ?? 0) +
                                (this.HagheSarparsti ?? 0)
                                + (this.MablagheNobateKari ?? 0) +
                                (this.HagheJazb ?? 0))+
                                (this.HagheGhaza ?? 0)+
                                (this.HagheAyabZahab ?? 0 )+
                                 (this.HagheTaahol ?? 0)
                                ;
                return _PayRollsumm;
            }
            set
            {
                _PayRollsumm = value;
            }

        }


    }
}
