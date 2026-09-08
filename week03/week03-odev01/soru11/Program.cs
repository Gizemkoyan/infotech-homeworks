namespace soru11;

class Program
{
    static void Main(string[] args)
    {
        //`static int TotalStock(int boxCount, int perBox)` metodu kutu sayısı × kutu başına adet döndürsün. `Main` içinde sonucu yazdırın.

        int toplam = TotalStock(12, 20);
        Console.WriteLine("Toplam adet: " + toplam);

        static int TotalStock(int boxCount, int perBox)
        {
            return boxCount * perBox;
        }
        
    }
}
