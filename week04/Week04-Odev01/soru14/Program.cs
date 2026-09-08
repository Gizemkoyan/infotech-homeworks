namespace soru14;

class Program
{
    static void Main(string[] args)
    {
        //Aynı liste üzerinde her çalışan için: müdürse prim bilgisini, geliştiriciyse seviye bilgisini ayrı satırda yazdırın.

        List<Employee> calisanlar = new List<Employee>
        {
            new Manager("Gizem Koyan", 40000, 10000),
            new Developer("Ahmet Yılmaz", 30000, "Junior"),
            new Developer("Zeynep Kaya", 40000, "Senior")
        };

        foreach (Employee calisan in calisanlar)
        {
            if (calisan is Manager mudur)
            {
                Console.WriteLine($"{mudur.TamAd} — Prim: {mudur.Prim:C}");
            }
            else if (calisan is Developer gelistirici)
            {
                Console.WriteLine($"{gelistirici.TamAd} — Seviye: {gelistirici.Seviye}");
            }
        }
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
