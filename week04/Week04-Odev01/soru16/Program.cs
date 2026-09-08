namespace soru16;

class Program
{
    static void Main(string[] args)
    {
        //Daha önce yazdığınız sınıflardan birinde nesneyi yazdırıldığında anlamlı özet veren metin tanımlayın. `Main` içinde nesneyi doğrudan ekrana yazdırarak bu özetin göründüğünü gösterin.

        Course ders = new Course("MCSD-101", "ASP.NET Core Temelleri", 12);

        Console.WriteLine(ders);
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

    public override string ToString()
    {
        return $"[{DersKodu}] {Baslik} — {Sure} saat";
    }
}
