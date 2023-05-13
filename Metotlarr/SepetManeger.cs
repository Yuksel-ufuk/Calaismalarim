//sepetle ilgili işlemler ürünle ilgili işlemler
using Metotlarr;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager  // ☺bir class  ıcınde 1 den fazla metotlar olabilir
    {
        //naming convention ilk harflerin büyük yazılması gerek
        //syntax "java" ile "c" yazım şekilerinin aynı olması demek
        public void Ekle(kurs urun) //burada Urüne ulaşmak ıcın urun yazılmalı demek buna imza denir  //encapsulation ilişkilendirme yani ayrı ayrı yazılacak yazıyı düzensiz olan bır yazıyı düzenli bir şekilde yazmak için kulanılan ve bunun ısmıne encapsulation denir
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi);
            //
            //
            //
            //bu programın içerisi çagrılır
        }
        //**************************************Kulanma Güncelemesi zor ama günceleme yapılmayacak bir durumda tek tek ekleyere kulana bilirsin********
        //public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi ) // ☺bir class  ıcınde 1 den fazla metotlar olabilir "2ci" metot bu
        //{
        //    Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        //}
        //*********************************************************************************************************************************************

    }
}