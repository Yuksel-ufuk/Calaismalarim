using System;
 namespace OOP1
{
    class program
    {
        static void Main(string[]args)
        {
            Product product1 = new Product(); //101
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa"; //101 komutunu  üstüne yazdı ProductManager aldıgı komutu ve ekranda gösterdi
            product1.UnitPrice = 500;
            product1.UnitInStock = 5;
            //---------------------------
            Product product2 = new Product {Id = 2, CategoryId=5, UnitInStock =7, 
                ProductName="kalem" ,UnitPrice= 35 };
            //case sensitive kücük büyük harf duyarlı dır
            //Kelimelerin ilk harfi büyük yazılır  PascalCase demek
            //PascalCase   //CamelCase
            ProductManager productManager = new ProductManager(); 
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName); //cevap kamera //101 komutunu  üstüne yazdı ProductManager aldıgı komutu ve ekranda gösterdi

            int sayi = 100;
            //productManager.BiseyYap(sayi);        //productManeger'e 100 sayısını yazdırır 
            Console.WriteLine(sayi); //cevap 100
            //---------------------------
            //***************************
            //---------------------------
            productManager.Topla2(3, 6); //3 ve 6  ProductManager göderir orda toplar ekrana yazar "9"

            // return                     //
            int toplamaSonucu = productManager.Topla(3, 6); //burda işleme devam edebilir 
            //return de alınan cevabı burdan alabilirz ve tekrardan başka bir işlme sokabiliriz
            Console.WriteLine(toplamaSonucu*2); //programın akışı 
            //---------------------------
            //***************************






        }
    }       
}