namespace soru15;

class Program
{
    static void Main(string[] args)
    {
        //`string template = "Merhaba NAME, hoş geldin";` içindeki `NAME` yerine kendi adınızı koyup **`Replace`** ile tek satırda yeni metni oluşturun ve yazdırın.

        string template = "Merhaba NAME, hoş geldin";

        string yeniMetin = template.Replace("NAME", "Gizem");

        Console.WriteLine(yeniMetin);
    }
}
