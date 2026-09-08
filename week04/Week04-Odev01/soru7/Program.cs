namespace soru7;

class Program
{
    static void Main(string[] args)
    {
        //En az üç ders içeren bir liste oluşturun. Her dersin özetini alt alta yazdırın; ardından listedeki toplam ders saatini yazdırın.

        List<Course> dersler = new List<Course>
        {
            new Course("MCSD-101", "ASP.NET Core Temelleri", 12),
            new Course("MCSD-102", "C# OOP", 8),
            new Course("MCSD-103", "SQL Server", 8)
        };

        int toplamSure = 0;

        foreach (Course ders in dersler)
        {
            ders.OzetYazdir();
            toplamSure += ders.Sure;
        }

        Console.WriteLine($"Toplam süre: {toplamSure} saat");
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
