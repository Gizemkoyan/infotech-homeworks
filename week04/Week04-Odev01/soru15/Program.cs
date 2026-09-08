namespace soru15;

class Program
{
    static void Main(string[] args)
    {
        //`Vehicle` ata sınıfı: marka, yıl ve kısa açıklama döndüren davranış. `Car` ve `Motorcycle` türetin; açıklamada araç türü belli olsun. İkisini de araç listesinde tutup açıklamalarını yazdırın.

        List<Vehicle> araclar = new List<Vehicle>
        {
            new Car("BMW", 2024),
            new Motorcycle("Honda", 2023)
        };

        foreach (Vehicle arac in araclar)
        {
            Console.WriteLine(arac.AciklamaGetir());
        }
    }
}

class Vehicle
{
    public string Marka { get; set; }
    public int Yil { get; set; }

    public Vehicle(string marka, int yil)
    {
        Marka = marka;
        Yil = yil;
    }

    public virtual string AciklamaGetir()
    {
        return $"{Marka} — {Yil}";
    }
}

class Car : Vehicle
{
    public Car(string marka, int yil)
        : base(marka, yil)
    {
    }

    public override string AciklamaGetir()
    {
        return $"Otomobil — {Marka} — {Yil}";
    }
}

class Motorcycle : Vehicle
{
    public Motorcycle(string marka, int yil)
        : base(marka, yil)
    {
    }

    public override string AciklamaGetir()
    {
        return $"Motosiklet — {Marka} — {Yil}";
    }
}
