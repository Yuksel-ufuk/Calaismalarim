namespace Genericslntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>(); //burda <string> veya int istedigin duruma göre belirterek girebilirsin diger türlü hata alacaksın girmedigin taktirde
            isimler.Add("engin"); //burda bana ismi ver diyor <string>

            List<string> liste = new List<string>();
            Console.WriteLine(liste.Count);

            MyList<int> kedilerr = new MyList<int>();
            kedilerr.Add(56);
        }
    }
}