namespace soru2;

class Program
{
    static void Main(string[] args)
    {
        //`Product` sınıfı: ürün adı ve fiyat bilgisi olsun. Fiyat negatif olamaz; geçersiz bir fiyat atamaya çalışıldığında mevcut fiyat korunmalı. `Main` içinde geçerli ve geçersiz fiyat deneyip son fiyatı yazdırın.

        Product urun = new Product();

        urun.Ad = "Klavye";
        urun.Fiyat = 750;

        Console.WriteLine("Geçerli fiyat: " + urun.Fiyat);

        urun.Fiyat = -200;

        Console.WriteLine("Son fiyat: " + urun.Fiyat);
    }
}

class Product
{
    public string Ad { get; set; } = "";

    private decimal fiyat;

    public decimal Fiyat
    {
        get
        {
            return fiyat;
        }
        set
        {
            if (value >= 0)
            {
                fiyat = value;
            }
        }
    }
}
