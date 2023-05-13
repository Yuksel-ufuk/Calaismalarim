using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Product Manager  demek üsürnle ilgili operasyonlar demek
namespace OOP1
{
     
    class ProductManager //cagırılan konum 
    {
        //public void Add(string add)//Add->adım add //sring add -> parametre olarak bana bir metin yola demek
        public void Add(Product product) //101 //bana Urun ismi ile bisey gödereceksin ben onu urun türünde tutucam demek           
        {
            Console.WriteLine(product.ProductName + " Eklendi.");
            //product.ProductName = "Kamera"; //güncelemek için
            
        }
        public void Update(Product product)
        {           
            Console.WriteLine(product.ProductName + " Güncellendi.");
        }





        //------------------------------------------
        //nerde void ve nerde int kulanılacagını anlamak ıcın yapıldı
        //"void" git ekle git güncele git sil  gibi komutları yolamak icin public void 
        //Void kısacası işleme ekleme yapmak icin kullanamasın sadece göstermek ıcın kulanırsın
        //Void git yap bitir amaçlı ama // intbiz devam edeceksek işleme yani basit bir işlem den sonra cıkan sonuca bir şey daha eklmek için  mesela 2+3=5 5'i de 2 çarp demek ivcin ise "int" komutunu kulanabiliriz
        public int Topla(int sayi1, int sayi2) 
        {
            return sayi1 + sayi2;
        }
        //İNT return de alınan cevabı burdan alabilirz ve tekrardan başka bir işlme sokabiliriz
        public void Topla2(int sayi1, int sayi2) 
        {
            Console.WriteLine(sayi1 + sayi2);
        }
        //--------------------------------------------




        //public void BiseyYap(int sayi) 
        //{
        //    sayi = 99;
        //}
    }
}
