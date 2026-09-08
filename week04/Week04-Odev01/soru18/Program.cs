namespace soru18;

class Program
{
    static void Main(string[] args)
    {
        //En az üç şekil (en az iki farklı tür) içeren liste oluşturun. Her şeklin etiketini ve alanını yazdırın; sonunda tüm alanların toplamını yazdırın.

        List<Shape> sekiller = new List<Shape>
        {
            new Rectangle(5, 4),
            new Circle(3),
            new Rectangle(6, 2)
        };

        double toplamAlan = 0;

        foreach (Shape sekil in sekiller)
        {
            double alan = sekil.AlanHesapla();

            Console.WriteLine($"{sekil.EtiketGetir()} — Alan: {alan:F2}");

            toplamAlan += alan;
        }

        Console.WriteLine($"Toplam alan: {toplamAlan:F2}");
    }
}

abstract class Shape
{
    public abstract double AlanHesapla();

    public virtual string EtiketGetir()
    {
        return "Şekil";
    }
}

class Rectangle : Shape
{
    public double Genislik { get; set; }
    public double Yukseklik { get; set; }

    public Rectangle(double genislik, double yukseklik)
    {
        Genislik = genislik;
        Yukseklik = yukseklik;
    }

    public override double AlanHesapla()
    {
        return Genislik * Yukseklik;
    }

    public override string EtiketGetir()
    {
        return "Dikdörtgen";
    }
}

class Circle : Shape
{
    public double Yaricap { get; set; }

    public Circle(double yaricap)
    {
        Yaricap = yaricap;
    }

    public override double AlanHesapla()
    {
        return Math.PI * Yaricap * Yaricap;
    }

    public override string EtiketGetir()
    {
        return "Daire";
    }
}
