string adi = "Engin";
int yas = 47;

kurs kurs1 = new kurs();
kurs1.KursAdi = "kedi roketi";
kurs1.Egitmeni = "kedi maması";
kurs1.İzlenmeOranı = 47;

kurs kurs2 = new kurs();
kurs2.KursAdi = "matematik kedi";
kurs2.Egitmeni = "bezelye kedi";
kurs2.İzlenmeOranı = 47;

kurs kurs3 =  new kurs();
kurs3.KursAdi = "pisikolok ked";
kurs3.Egitmeni = "havyar kedi";
kurs3.İzlenmeOranı = 47;

kurs kurs4 = new kurs();
kurs4.KursAdi = "c++";
kurs4.Egitmeni = "mahmut kedi";
kurs4.İzlenmeOranı = 40;

//ister bu şekilde
Console.WriteLine(kurs4.KursAdi + " : " + kurs4.Egitmeni + " : " + kurs4.İzlenmeOranı);
kurs[] kurslar = new kurs[] {kurs1, kurs2, kurs3 };
foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi); //ister bu şekilde göstere bilirsin
}

class kurs
{
    public string KursAdi { get; set; }
    public string Egitmeni { get; set; }
    public int İzlenmeOranı { get; set; }
}


//bu işlem bir klasörde altında yapılan işlemler bütünü gösterir
//ör olarak bir ders programının görüntüsü alta calısan ise 1 dersin hagi hocanın hangi dersi verdigi ve görüntülenme sayısı 