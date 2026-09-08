namespace soru5;

class Program
{
    static void Main(string[] args)
    {
        //Aynı prices dizisinde for döngüsü ve if ile en yüksek fiyatı bulun; 
        // En yüksek: 15,75 benzeri etiketli yazdırın.

        double[] prices = { 12.5, 8.0, 15.75, 3.25 };

        double enYuksek = prices[0];

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] > enYuksek)
            {
                enYuksek = prices[i];
            }
        }

        Console.WriteLine("En yüksek: " + enYuksek.ToString("F2"));
    }
}
