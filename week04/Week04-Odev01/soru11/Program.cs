namespace soru11;

class Program
{
    static void Main(string[] args)
    {
        //`Developer` türesin: seviye bilgisi (ör. Junior, Senior) olsun. Senior için taban maaşa 5.000 ₺ eklenmiş sayılsın; Junior için yalnızca taban maaş. `Main` içinde bir Junior ve bir Senior oluşturup maaşlarını yazdırın.

        Developer junior = new Developer("Gizem Koyan", 30000, "Junior");
        Developer senior = new Developer("Zeynep Kaya", 40000, "Senior");

        Console.WriteLine($"{junior.TamAd} — Seviye: {junior.Seviye} — Maaş: {junior.MaasHesapla():C}");
        Console.WriteLine($"{senior.TamAd} — Seviye: {senior.Seviye} — Maaş: {senior.MaasHesapla():C}");
    }
}

class Employee
{
    public string TamAd { get; set; }
    public decimal TabanMaas { get; set; }

    public Employee(string tamAd, decimal tabanMaas)
    {
        TamAd = tamAd;
        TabanMaas = tabanMaas;
    }

    public virtual decimal MaasHesapla()
    {
        return TabanMaas;
    }
}

class Developer : Employee
{
    public string Seviye { get; set; }

    public Developer(string tamAd, decimal tabanMaas, string seviye)
        : base(tamAd, tabanMaas)
    {
        Seviye = seviye;
    }

    public override decimal MaasHesapla()
    {
        if (Seviye == "Senior")
        {
            return TabanMaas + 5000;
        }

        return TabanMaas;
    }
}
