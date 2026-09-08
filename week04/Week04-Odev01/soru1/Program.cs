namespace soru1;

class Program
{
    static void Main(string[] args)
    {
        //`Book` adında bir sınıf tanımlayın; kitap başlığı ve yazar bilgisini tutun. `Main` içinde bir kitap nesnesi oluşturup bilgileri atayın; başlık ve yazarı tek satırda yazdırın.

        Book kitap = new Book();

        kitap.Baslik = "Clean Code";
        kitap.Yazar = "Robert Martin";

        Console.WriteLine($"Başlık: {kitap.Baslik} — Yazar: {kitap.Yazar}");

    }
}

class Book
{
    public string Baslik { get; set; } = "";
    public string Yazar { get; set; } = "";
}