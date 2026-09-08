namespace soru19;

class Program
{
    static void Main(string[] args)
    {
        //Soyut `Report` sınıfı: rapor gövdesi her türde farklı üretilsin; tüm rapor türleri ortak bir başlık satırı basabilsin (ör. rapor adı). `SalesReport` (sipariş adedi ve ciro) ile `InventoryReport` (kritik stoktaki ürün sayısı) somut sınıflarını yazın. `Main` içinde her iki raporu da oluşturup başlık + gövde çıktısı üretin.

        SalesReport satisRaporu = new SalesReport("Satış Raporu", 120, 75000);
        InventoryReport stokRaporu = new InventoryReport("Stok Raporu", 8);

        satisRaporu.BaslikYazdir();
        Console.WriteLine(satisRaporu.GovdeOlustur());

        stokRaporu.BaslikYazdir();
        Console.WriteLine(stokRaporu.GovdeOlustur());
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
