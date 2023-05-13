namespace OOP._3
{     
    internal class Program
    {
        static void Main(string[] args) 
        {
            //_______________________________________________________________________Veri
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManagerK();               
            IKrediManager tasıtKrediManager = new TasıtKrediManager();           
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKredisiManager = new EsnafKredisiManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLogggerService = new SmsLogggerService();
            //_______________________________________________________________________Veri

            //_______________________________________________________________________kullanılan kod

            BasvuruManager basvuruManager = new BasvuruManager();
            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, konutKrediManager };                                         //Krediler                                                                 //ampulden "sistem coletion generct" dan geliyor        
            basvuruManager.KrediOnBilgiledirmesiYap(krediler, new List<ILoggerService> { databaseLoggerService, fileLoggerService, smsLogggerService }); //kayıt yerleri

            //_______________________________________________________________________kullanılan kod           

            //yedek---
            //BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(esnafKredisiManager, new List<ILoggerService> { databaseLoggerService, smsLogggerService, fileLoggerService }); //Burdan nereye "save" lanacagını ve hangi işlmi yapacagını secebilirsin                       
            //basvuruManager, new List<IKrediManager> { ihtiyacKrediManager, tasıtKrediManager };
            //basvuruManager.KrediOnBilgiledirmesiYap(krediler);
            //basvuruManager.BasvuruYap(esnafKredisiManager, new List<ILoggerService> { databaseLoggerService, smsLogggerService, fileLoggerService }); //Burdan nereye "save" lanacagını ve hangi işlmi yapacagını secebilirsin

            //List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, }; //ampulden "sistem coletion generct" dan geliyor        
            //basvuruManager.KrediOnBilgiledirmesiYap(krediler);
            //yedek---

            //-----------------------------------------------
            //*****************************************************************************************
            //-----------------------------------------------asagıdaki gibide yapılabilir ama onu ögrenme daha basit yapılı

            //IKrediManager ihtiyacKrediManager = new IhtiyacKrediManagerK();
            //ihtiyacKrediManager.Hesapla();

            //IKrediManager tasıtKrediManager = new TasıtKrediManager();
            //tasıtKrediManager.Hesapla();

            //IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
        }
    }
}