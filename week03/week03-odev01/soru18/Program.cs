namespace soru18;

class Program
{
    static void Main(string[] args)
    {
        //Okunmuş bir dizi üzerinde `Array.IndexOf` kullanın: `int[] nums = { 10, 20, 30, 20 };` için **ilk** `20`’nin dizinini bulun ve yazdırın.

        int[] nums = { 10, 20, 30, 20 };

        int index = Array.IndexOf(nums, 20);

        Console.WriteLine("İlk 20'nin dizini: " + index);
        
    }
}
