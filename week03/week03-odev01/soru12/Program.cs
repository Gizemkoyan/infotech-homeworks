namespace soru12;

class Program
{
    static void Main(string[] args)
    {
        //Aynı sınıfta **metot aşırı yükleme** kullanın: `static string Describe(int value)` tamsayıyı `Tam: {value}` stringi olarak döndürsün; `static string Describe(double value)` ondalıklıyı `Ondalık: {value:F2}` olarak döndürsün. `Main` içinde her iki çağrıyı da yapıp yazdırın.

        Console.WriteLine(Describe(7));
        Console.WriteLine(Describe(3.14));
    }

    static string Describe(int value)
    {
        return $"Tam: {value}";
    }

    static string Describe(double value)
    {
        return $"Ondalık: {value:F2}";
    }
}
