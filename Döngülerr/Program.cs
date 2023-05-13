//tekrarklama döngüsü bir metni tekrarlar yada sayar
for (int i = 1; i < 10; i++)

{
    Console.WriteLine(i);
}
for (int i = 1; i < 10; i = i + 2)
{
    Console.WriteLine(i);
}
//----------------------------------------------------
//tek tek gösterim şekli güncelemesi zor kullanışlı degil
string kurs1 = "yazılım geliştirici ";
string kurs2 = "programlamaya baslanngıc";
string kurs3 = "java";
string kurs4 = "c#";
Console.WriteLine(kurs1);
Console.WriteLine(kurs2);
Console.WriteLine(kurs3);
Console.WriteLine(kurs4);
//-----------------------------------------------------
// string dizlierini birlikte tutmak icin dizi bir array oluşturz
// Güncelemesi kolay gösterim şekli for ile 
string[] kusrslar = new string[] { 
    "yazılım geliştirici " , 
    "programlamaya baslanngıc" , 
    "java" ,"c#"};
for (int i = 0; i<kusrslar .Length; i++)
{
    Console.WriteLine(kusrslar[i]);
}
//bu kodları javada calıtırmak ıstenırse degisilecek tek sey -console.witeline yerine sistem aoutline ve strşng in S s, buyuk harf yazılır
//ikinici farklı döngü yöntemi
Console.WriteLine("for bitti");
foreach (string kedi in kusrslar)
{
    Console.WriteLine(kedi);
}
Console.WriteLine("sayfa sonu -footer");




