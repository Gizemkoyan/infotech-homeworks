namespace soru10;

class Program
{
    static void Main(string[] args)
    {
        //`Employee` ata sınıfı: tam ad, taban maaş ve maaş hesaplama davranışı (varsayılan: taban maaş). `Manager` türesin: prim bilgisi de olsun; maaş taban + prim olsun. `Main` içinde bir müdür oluşturup ad ve maaşını yazdırın.

        Manager mudur = new Manager("Gizem Koyan", 30000, 5000);

        Console.WriteLine($"{mudur.TamAd} — Maaş: {mudur.MaasHesapla():C}");
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

class Manager : Employee
{
    public decimal Prim { get; set; }

    public Manager(string tamAd, decimal tabanMaas, decimal prim)
        : base(tamAd, tabanMaas)
    {
        Prim = prim;
    }

    public override decimal MaasHesapla()
    {
        return TabanMaas + Prim;
    }
}


