using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    class program
    {     
        //Koleksiyonların amacı yeni bir veri kaynagından bir şey alınınca eski bilgilerin yok olmasından dolayı Koleksiyonlar geliştirilirrr 
        static void Main(string[] args)
        {
            //ctrl k+c toplu koment alma geri almak icin ctrl k+u

            //string[] isimler = new string[] { "engin", "kedi", "pisi", "japon balıgı"  }; //Oluşturdugumuz sınırlar ıcınde gcerlidir //yazarsan patlar "isimler[4] = "ilker";"
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "ilker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            //stack ve heap diye iki alan var referans tipler ikisinide kullanıyor , deger tipler sadece stack kullanıyor 
            
            //koleksiyonlarda degerleri kaybetmemeizi saglar ekleeme yapılınca

            List<string> isimler2 = new List<string> { "engin", "kedi", "pisi", "japon balıgı" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("ilker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }       
        
}