namespace soru3;

class Program
{
    static void Main(string[] args)
    {
        // int[] temperatures = { 18, 22, 19, 25 }; dizisini tanımlayın. 
        // Length, ilk ve son elemanı etiketli olarak (Console.WriteLine) 
        // yazdırın.

        int[] temperatures = { 18, 22, 19, 25 };

        Console.WriteLine("Dizi Uzunluğu: " + temperatures.Length);
        Console.WriteLine("İlk Eleman: " + temperatures[0]);
        Console.WriteLine("Son Eleman: " + temperatures[temperatures.Length - 1]);
    }
}
