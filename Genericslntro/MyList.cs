using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Genericslntro
{
    //buranın amacı veriyi tutar yenısını ekler eki veriyi tutar ve bu tekrar eder
    class MyList<T> // T ye string verirsen T string olarak çalışır
    {
        //-------------------------------------------------
        //T[] items; //yenilemez sen referans hatası alırsın 
        T[] items; //class erişebilecegi bir ürün tanımlıyoruz //class daki bütün operasyonlarına yapıklarına erişebilirsin cünkü class sıfına yazdın
        //public void Add(T eleman)
        //{
        //                          //Hafızada tutacak alan burası
        //}

        //ctor tap tap  //yenilemek için //constructor denir
        //-------------------------------------------------
        public MyList()                                    // Class ile aynı metot onun adını duyunce "()" burası da calısır 
        {                                                  //class bir yerde new yapılırsa ici otomatik çalışıyor
            items = new T[0];                              //new dedigin anda sıfırlanacak
        }                                                  //
        public void Add(T item)               //Örnegin bir eleman eklediniz "engin" referans sayısını artırıncak ve eklenen kişileri kaç kişi eklendigini gösterecek
        {
            T[] tempArray = items;            // "tempArray" geçici dizi demek önceki referans numarası silinmesin diye geçici tutucu görevi görür
            items = new T[items.Length+1];    // Dinin eleman sayısı "1" artırılacak oyüzden "new"                                             
            for (int i = 0; i < tempArray.Length; i++)  //Az önce sana verdim elemanları bana geri ver 
                                                        //Aslında biz "string" listemizi bir tane daha artırdıkk
            {
                items[i] = tempArray[i];      //emenaten verdigin degerleri sırası ile geri alıyor
            }

            items[items.Length - 1] = item; //items in son elemanı = yukardan gelen item
        }
    }
}
