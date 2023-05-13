using Metotlarr;
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
            double fiyati = 15; 
            string aciklama = "Taze patates";

            string[] meyveler = new string[] { };

            //   Urun1 bir ürün degişken

            kurs urun1 = new kurs();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Acıklama = "Gala elması";

            kurs urun2 = new kurs();
            urun2.Adi = "patates";
            urun2.Fiyati = 9;
            urun2.Acıklama = "Taze patates";

            kurs[] urunler = new kurs[] { urun1, urun2 };
            //type-safe -- tip güvenli
            //(veri tip / döndürecek in )          
            foreach (var urun in urunler)
            {
                // <li><{ { } }</li> LinkedList HDMI da ürün göstermek icin
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Acıklama);
                Console.WriteLine("-----------------------");   
            }

            Console.WriteLine("--------------Metotlar---------------");
            //instance - bir sürü ürün için oluşturur
            //encapsulation ilişkilendirme yani ayrı ayrı yazılacak yazıyı düzensiz olan bır yazıyı düzenli bir şekilde yazmak için kulanılan ve bunun ısmıne encapsulation denir
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            //**************************************Kulanma Güncelemesi zor ama günceleme yapılmayacak bir durumda tek tek ekleyere kulana bilirsin********
            //sepetManager.Ekle2("Armut", "Amasya Armut", 12, 3);
            //sepetManager.Ekle2("Elma", "Yeşil elma", 15, 3);
            //sepetManager.Ekle2("Karpuz", "Diyarbakır karpuz", 12, 4);
            //*********************************************************************************************************************************************
        }
    }
}

