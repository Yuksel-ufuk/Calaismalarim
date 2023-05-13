using System;
// sadece bilgi vermek amaclı yazdım  çalışmaz !!!
namespace DegerVeReferansTipler
{
    class program
    {
        static void Main(string[] args)

            int sayi1 10;
            int sayi2 30;
            sayi1 = sayi2; // sayı1 = sayı2  verilince sayı2 üstüne geciyor
            sayi2 = 65;    //
            //sayı1 ?? 30
            //sayı2 ?? 65 sayı kopar olay sadece degeri aktarmak tır

            int[] sayilar1 = new int[] { 10, 20, 30 };    //101    // işlemlerden sonra daknet bunu işi kalmadıgı için otomatik onu cöpe yolar
            int[] sayilar1 = new int[] { 100, 200, 300 }; //102 
            sayilar1 = sayilar2;                          //101 = 102 -> 102 referans tiplerde adres atılır bu da bir referans tipidir deger tip de de degeri
            sayilar2[0] = 999;                            //bunun alnlamı sayılar2nin ilk elemanı yani A { A , B , C } "A" sıfırncı elemamı "100" içine 999 ekle diyor

            //sayı2 ?? 999
            

        //Sayısal Veri Tipleri "int" , "Decimol" , "float" , "double" , "bool" = Deger tip
        //Referans Tip   "alias" , "class" , "interface" 
    }
}