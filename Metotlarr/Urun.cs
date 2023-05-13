using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlarr
{
    class kurs // aslında kurs degil ürün olması gerekiyordu ama kelimelerden hoşlanmadıgı için kurs yazmak zorunda kaldım
    {
        //property - ürünlerin özelikleri
        //encapsulation ilişkilendirme
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; } 
        public string Acıklama { get; set; }
        public string StokAdedi { get; set; }

    }
}
