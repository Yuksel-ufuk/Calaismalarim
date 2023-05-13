using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP._3
{
    class IhtiyacKrediManagerK:IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            //işlemler "-,+,*"
            //
            Console.WriteLine("ihtiyac kredisi ödeme planı hesaplandı");
        }
    }
}
