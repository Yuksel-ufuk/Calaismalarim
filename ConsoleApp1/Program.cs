using System.ComponentModel.Design;
using System.Linq.Expressions;
{
    //type safety - tip güvenligi
    //do not r epeat yourself-kedini tekrarlama
    // "string" katogori etiketi bir deger tutucudur,alias yani kategori etiketi artık bizim için birkod

    string KategoriEtiketi = "kedii";
    int kedisayisi = 4747; // normal sayı
    double kesirlikedi = 4.7;
    bool SistemeGirisYapmismi = true;
    double dolarındun = 19.98;
    double dolarınbugu = 19.98;

    if (dolarındun>dolarınbugu)
    {
        Console.WriteLine("Azalış Oku");
    }
    else if (dolarındun<dolarınbugu)             
    {
        Console.WriteLine("Artış Oku");
    }
    else
    {
        Console.WriteLine("Degişmedi oku");
    }



    if (SistemeGirisYapmismi == false)
    {
        Console.WriteLine("Kullanıcı Ayarları butonu"); //hhd-<button>kullanıcı ayarları</button> 
    }
    else
    {
        Console.WriteLine("giriş yap butonu");
    }

    Console.WriteLine("KategoriEtiketi"); // bu sadece göster komutu

    Console.WriteLine(KategoriEtiketi);

    Console.WriteLine(KategoriEtiketi);

    Console.WriteLine(KategoriEtiketi);

    Console.WriteLine(KategoriEtiketi);

    Console.WriteLine(KategoriEtiketi);
}
