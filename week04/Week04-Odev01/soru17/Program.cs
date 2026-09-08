namespace soru17;

class Program
{
    static void Main(string[] args)
    {
        //Soyut `Shape` sınıfı: alan hesabı her alt türde farklı olsun; ortak bir etiket metni döndürsün. `Rectangle` (genişlik, yükseklik) ve `Circle` (yarıçap) somut alt sınıflarını yazın. `Main` içinde birer örnek oluşturup alanları iki ondalık basamakla yazdırın.

        Rectangle dikdortgen = new Rectangle(5, 4);
        Circle daire = new Circle(3);

        Console.WriteLine($"{dikdortgen.EtiketGetir()} — Alan: {dikdortgen.AlanHesapla():F2}");
        Console.WriteLine($"{daire.EtiketGetir()} — Alan: {daire.AlanHesapla():F2}");
    }
}

abstract class Shape
{
    public abstract double AlanHesapla();

    public string EtiketGetir()
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
}
