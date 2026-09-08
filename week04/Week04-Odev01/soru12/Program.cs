namespace soru12;

class Program
{
    static void Main(string[] args)
    {
        //En az bir müdür ve iki geliştirici içeren çalışan listesi oluşturun. Tek bir döngüde her çalışanın adını ve hesaplanan maaşını yazdırın (her tip kendi maaş kuralını kullanmalı).

        List<Employee> calisanlar = new List<Employee>
        {
            new Manager("Gizem Koyan", 40000, 10000),
            new Developer("Ahmet Yılmaz", 30000, "Junior"),
            new Developer("Zeynep Kaya", 40000, "Senior")
        };

        foreach (Employee calisan in calisanlar)
        {
            Console.WriteLine($"{calisan.TamAd} — Maaş: {calisan.MaasHesapla():C}");
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
