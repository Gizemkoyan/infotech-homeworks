namespace soru9;

class Program
{
    static void Main(string[] args)
    {
        
        //`SortedList<string, int>` kullanarak en az **üç** öğrenci adı ve notu girin; anahtarları **bilerek** alfabetik sırada **olmayan** sırada yazın (ör. önce `Zeynep`, sonra `Ahmet`). `foreach` ile yazdırdığınızda çıktının **ada göre sıralı** geldiğini gösterin.

        SortedList<string, int> ogrenciler = new SortedList<string, int>();

        ogrenciler.Add("Zeynep", 95);
        ogrenciler.Add("Ahmet", 80);
        ogrenciler.Add("Burak", 92);

        foreach (var ogrenci in ogrenciler)
        {
            Console.WriteLine(ogrenci.Key + ": " + ogrenci.Value);
        }
        
    }
}
