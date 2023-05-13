using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP._2
{
    //"coorporate" TuzelMusteri
    //buralarda yapılan müsteride olan özelikler hem tüzelde hemde gercek müsteride vardır demek
    class TuzelMusteri:Musteri //Ebeveyin //Bu olaya miras deniliyor"inheratice" //"TuzelMusteri" bir "Musteri" dir demek oluyor
    { //sadece ona ait özelikler burada yani TuzelMusteri lere
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
     }
}
