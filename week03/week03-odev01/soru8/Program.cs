namespace soru8;

class Program
{
    static void Main(string[] args)
    {
        //`Dictionary<string, decimal>` ile en az **üç** ürün kodu ve birim fiyatı ekleyin (ör. `SKU01` → `29.99m`). `string code = "SKU02";` için `ContainsKey` ile kontrol edin: varsa fiyatı, yoksa `Ürün bulunamadı` yazdırın.
        
        Dictionary<string, decimal> urunler = new Dictionary<string, decimal>();

        urunler.Add("SKU01", 29.99m);
        urunler.Add("SKU02", 45.50m);
        urunler.Add("SKU03", 18.75m);

        string code = "SKU02";

        if (urunler.ContainsKey(code))
        {
            Console.WriteLine("Fiyat: " + urunler[code]);
        }
        else
        {
            Console.WriteLine("Ürün bulunamadı");
        }
    }
}
