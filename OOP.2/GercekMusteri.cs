using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP._2
{
    //buralarda yapılan müsteride olan özelikler hem tüzelde hemde gercek müsteride vardır demek
    //"Individual" GercekMusteri
    class GercekMusteri :Musteri //Varlık yani operasyonlar olmaz burda olmaması gerekiyor
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TcNo { get; set; }      //işlem yapılmayacak sadece sayı gösterilecek ise  String yaz  cünkü farklı exzel gibi uygulamalar bunu degisik kodlayabilir sorun yaratmaz ama exzelde numara yanıs okunur
    }
}
