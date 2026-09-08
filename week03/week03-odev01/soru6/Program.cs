namespace soru6;

class Program
{
    static void Main(string[] args)
    {
        //List<string> cities = new List<string>(); oluşturun;
        //  üç şehir adı ekleyin (Add). Count değerini ve listeyi foreach 
        // ile madde işareti veya tire ile yazdırın.

            List<string> cities = new List<string>();

            cities.Add("İstanbul");
            cities.Add("Ankara");
            cities.Add("İzmir");

            Console.WriteLine("Şehir Sayısı: " + cities.Count);

            foreach (string city in cities)
            {
                Console.WriteLine("- " + city);
            }
    }
}
