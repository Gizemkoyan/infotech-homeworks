namespace soru16;

class Program
{
    static void Main(string[] args)
    {
        //`int[] data = { 9, 2, 7, 2 };` verildiğinde `Array.Sort` uygulayın; ardından `string.Join(" | ", data)` ile tek satırda yazdırın.

        int[] data = { 9, 2, 7, 2 };

        Array.Sort(data);

        Console.WriteLine(string.Join(" | ", data));
        
    }
}
