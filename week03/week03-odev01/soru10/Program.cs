namespace soru10;

class Program
{
    static void Main(string[] args)
    {
        //`static void RepeatPrint(string label, int times)` adında bir metot yazın: `times` kadar `for` ile aynı satırda değil, **alt alta** `{label} ({i})` biçiminde bassın (`i` 1’den başlasın). `Main` içinden bir kez çağırın (`"Satır"`, `3`).

        RepeatPrint("Satır", 3);

        static void RepeatPrint(string label, int times)
        {
            for (int i = 1; i <= times; i++)
            {
                Console.WriteLine($"{label} ({i})");
            }
        }
    }
}
