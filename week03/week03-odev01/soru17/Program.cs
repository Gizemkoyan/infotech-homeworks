namespace soru17;

class Program
{
    static void Main(string[] args)
    {
        //`char[] letters = { 'z', 'a', 'm', 'k' };` dizisini önce `Array.Sort` ile sıralayın, sonra `Array.Reverse` uygulayın; sonucu `WriteLine` ile basın (birleştirerek veya döngüyle, net olsun yeter).

        char[] letters = { 'z', 'a', 'm', 'k' };

        Array.Sort(letters);
        Array.Reverse(letters);

        Console.WriteLine(string.Join("", letters));
        
    }
}
