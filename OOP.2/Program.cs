namespace OOP._2
{
    //OOP nesneye yönelik progralmalama //soyutlama sektörde cok degerli dir 
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kedi Deli
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "474747";
            musteri1.Adi = "Kedi";
            musteri1.Soyadi = "Deli";
            musteri1.TcNo = "4747474474";

            //Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri(); 
            musteri2.Id = 2;
            musteri2.MusteriNo = "474747474474";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "3434343434";


            //Gerçek Müsteri- Tüzel Müsteri
            //SOLID

            Musteri musteri3 = new GercekMusteri(); //Musteri class hem gercek musteriyi tutar hemde Tuzel musteriyi referansını tutar 
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            
        }
    }
}