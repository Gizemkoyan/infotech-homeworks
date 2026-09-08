namespace soru13;

class Program
{
    static void Main(string[] args)
    {
        //`string messy = "  Infotech Academy  ";` için **ardışık zincir**: `Trim` + `ToUpper`. Sonuçtan sonra `Contains("ACADEMY")` sonucunu bool olarak yazdırın.

        string messy = "  Infotech Academy  ";

        string sonuc = messy.Trim().ToUpper();

        Console.WriteLine(sonuc);
        Console.WriteLine(sonuc.Contains("ACADEMY"));
    }
}
