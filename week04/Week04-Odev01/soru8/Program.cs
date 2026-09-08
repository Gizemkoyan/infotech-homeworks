namespace soru8;

class Program
{
    static void Main(string[] args)
    {
        //`Person` ata sınıfı: tam ad ve rol bilgisi döndüren bir davranış (`Person` için rol: Personel). `Main` içinde bir `Person` oluşturup ad ve rolü yazdırın.

        Person kisi = new Person("Ali Veli");

        Console.WriteLine($"{kisi.TamAd} — Rol: {kisi.RolGetir()}");
    }
}

class Person
{
    public string TamAd { get; set; }

    public Person(string tamAd)
    {
        TamAd = tamAd;
    }

    public string RolGetir()
    {
        return "Personel";
    }
}
