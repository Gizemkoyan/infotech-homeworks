namespace soru20;

class Program
{
    static void Main(string[] args)
    {
        //`List<double> readings = new List<double> { 1.1, 2.2, 3.3 };` oluşturun; bunu **`IEnumerable<double>`** tipinde bir değişkene atayın. **`foreach`** ile toplamı hesaplayıp `F2` formatında yazdırın.

        List<double> readings = new List<double> { 1.1, 2.2, 3.3 };

        IEnumerable<double> values = readings;

        double toplam = 0;

        foreach (double value in values)
        {
            toplam += value;
        }

        Console.WriteLine(toplam.ToString("F2"));
        
    }
}
