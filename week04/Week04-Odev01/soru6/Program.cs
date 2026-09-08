namespace soru6;

class Program
{
    static void Main(string[] args)
    {
        //`Course` sınıfı: ders kodu, başlık, süre (saat). Nesne oluşturulurken üç bilgi de verilsin. Tek satırlık özet yazdıran bir davranış olsun. `Main` içinde bir ders oluşturup özeti yazdırın.

        Course ders = new Course("MCSD-101", "ASP.NET Core Temelleri", 12);

        ders.OzetYazdir();
    }
}

class Course
{
    public string DersKodu { get; set; }
    public string Baslik { get; set; }
    public int Sure { get; set; }

    public Course(string dersKodu, string baslik, int sure)
    {
        DersKodu = dersKodu;
        Baslik = baslik;
        Sure = sure;
    }

    public void OzetYazdir()
    {
        Console.WriteLine($"[{DersKodu}] {Baslik} — {Sure} saat");
    }
}
