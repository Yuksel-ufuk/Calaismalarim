using System;
using System.Collections.Generic;
using System.Text;


namespace Metotlar
{
    class program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Patates";
            double fiyati = 16;
            string aciklama = "Taze patates";

            string[] meyveler = new string[] { };

            //   Urun1 bir ürün degişken
            
            Urun urun1 = new Urun();
            urun1.Adi = "Patates";
            urun1.Fiyati = 16;
            urun1.Acıklama = "Gala elması";

            Urun urun2 = new Urun();
            urun2.Adi = "patates";
            urun2.Fiyati = 9;
            urun2.Aciklama = "Taze patates";

            Urun[] urunler = new Urun[] { urun1, urun2 };
            //(veri tip / döndürecek in )
            foreach (var urun in urunler)
            {
                // <li><{ { } }</li> LinkedList HDMI da ürün göstermek icin
                Console.WriteLine(urun.adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
            }

        }
    }
}






    





















