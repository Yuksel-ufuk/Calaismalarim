using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP._3
{// !! 
    //interface ara yüz demek yani şablonu bulmak zorundasın demek
    //Baiına "I" koy ki bunun interface anlarız
    interface IKrediManager //"interface" Şablon görevini görüyor
    {
        void Hesapla();   //birisi "interface" kullanırsa bu metodu içermek zorunda //burası şablon
        void BiseyYap();    //boş ekleme yapabilin                                  //burası şablon
    }
}

