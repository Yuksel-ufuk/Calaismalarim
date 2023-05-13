using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Soru= aynı veriyi türünde veriyi tasıyabilecek bir yapı
//cevap= (List<IKrediManager> krediler)

namespace OOP._3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            //Başvuran bigilerini degerlendirme
            //
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgiledirmesiYap(List<IKrediManager> krediler, List<ILoggerService> loggerServices)  //Birden fazla kredinin hesabını yapmak ıstediginde "List" kulan
        {
            foreach (var kredi in krediler)  //Her bir kredinin bir operasyonun yap hesebanı yap
            {
                kredi.Hesapla();
            }
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
        //Log da aslın da biz Method injection yapıyoruz yani "BasvuruYap" metodunun hangi kredi metodunu kullanacagını ve hangi log enjekte ediyoruz 
        
        //-------------------------------------
        //public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices) //!!çogul komut da gödere bilirsin bu cogul //buraya hangi komutu göderirsen onun kredi hesaplaması çalışır yani tasit , konut yada ihtiyac kredisi ne verilirse asagıda o calısır 
        //{
        //    //Başvuran bigilerini degerlendirme
        //    //
        //    //YAPMA!! KonutKrediManager konutKrediManager = new KonutKrediManager();    //krediyi hesapla
        //    //YAPMA!! konutKrediManager.Hesapla(); // calısır ama bütün komutlar komut kredisi üzerinden hesaplanır
        //    //YAPMA!! calısır ama bütün komutlar komut kredisi üzerinden hesaplanır

        //    krediManager.Hesapla();
        //    foreach (var IoggerService in loggerServices)
        //    {
        //        loggerServices.Log();
        //    }

        //    //loggerService.Log();//hangiloggerService verildi ise onu Log  la 
        //}
    }
}
