namespace soru20;

class Program
{
    static void Main(string[] args)
    {
        //Soyut `Report` tipinde bir değişken tanımlayın; çalışma sırasında önce satış, sonra stok raporu somut tipini atayıp aynı değişken üzerinden rapor gövdesini üretin. Soyut sınıftan doğrudan nesne oluşturulamadığını deneyerek gözlemleyin (isteğe bağlı yorum satırı).

        Report rapor;

        rapor = new SalesReport("Satış Raporu", 120, 75000);
        rapor.BaslikYazdir();
        Console.WriteLine(rapor.GovdeOlustur());

        rapor = new InventoryReport("Stok Raporu", 8);
        rapor.BaslikYazdir();
        Console.WriteLine(rapor.GovdeOlustur());

        // Report rapor2 = new Report("Rapor");
    }
}

abstract class Report
{
    public string RaporAdi { get; set; }

    public Report(string raporAdi)
    {
        RaporAdi = raporAdi;
    }

    public void BaslikYazdir()
    {
        Console.WriteLine($"--- {RaporAdi} ---");
    }

    public abstract string GovdeOlustur();
}

class SalesReport : Report
{
    public int SiparisAdedi { get; set; }
    public decimal Ciro { get; set; }

    public SalesReport(string raporAdi, int siparisAdedi, decimal ciro)
        : base(raporAdi)
    {
        SiparisAdedi = siparisAdedi;
        Ciro = ciro;
    }

    public override string GovdeOlustur()
    {
        return $"Sipariş adedi: {SiparisAdedi} — Ciro: {Ciro:C}";
    }
}

class InventoryReport : Report
{
    public int KritikStokUrunSayisi { get; set; }

    public InventoryReport(string raporAdi, int kritikStokUrunSayisi)
        : base(raporAdi)
    {
        KritikStokUrunSayisi = kritikStokUrunSayisi;
    }

    public override string GovdeOlustur()
    {
        return $"Kritik stoktaki ürün sayısı: {KritikStokUrunSayisi}";
    }
}
