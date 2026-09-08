namespace soru4;

class Program
{
    static void Main(string[] args)
    {
        //double[] prices = { 12.5, 8.0, 15.75, 3.25 }; için foreach ile
        //  toplamı bulun; ortalamayı double olarak hesaplayıp iki ondalık (F2)
        //  ile yazdırın.

        double[] prices = { 12.5, 8.0, 15.75, 3.25 };

        double toplam = 0;

        foreach (double fiyat in prices)
        {
            toplam += fiyat;
        }

        double ortalama = toplam / prices.Length;

        Console.WriteLine("Toplam: " + toplam);
        Console.WriteLine("Ortalama: " + ortalama.ToString("F2"));
    }
}
