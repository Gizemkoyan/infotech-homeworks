namespace soru2;

class Program
{
    static void Main(string[] args)
    {
        //for döngüsü ile 1’den 6’ya kadar (sınırlar dahil) her i için i ile 7 - i çarpımını yazdırın. 
        // Her satır şu biçimde olsun: i x (7-i) = sonuç (aralarında boşluklar okunaklı olsun yeter).
        
        for (int i = 1; i <= 6; i++)
        {
            int sonuc = i * (7 - i);
            Console.WriteLine(i + " x " + (7 - i) + " = " + sonuc);
        }
    }
}
