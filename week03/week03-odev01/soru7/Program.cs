namespace soru7;

class Program
{
    static void Main(string[] args)
    {
        //List<int> ids = new List<int> { 101, 102, 103, 104 }; içinden 102 değerini listeden kaldırın 
        // (Remove). Kalan eleman sayısını ve tüm elemanları tek satırda virgülle birleştirerek yazdırın
        //  (string.Join kullanın).


        List<int> ids = new List<int> { 101, 102, 103, 104 };

        ids.Remove(102);

        Console.WriteLine("Kalan Eleman Sayısı: " + ids.Count);
        Console.WriteLine("Elemanlar: " + string.Join(", ", ids));
    

    }
}
