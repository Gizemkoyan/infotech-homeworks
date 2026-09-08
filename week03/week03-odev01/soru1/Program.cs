namespace soru1;

class Program
{
    static void Main(string[] args)
    {

        // int counter = 3; ile başlayın; while döngüsü kullanarak 
        // counter sıfırdan büyük olduğu sürece her turda counter değerini yazdırın ve bir azaltın.
        //  Döngü bitince tek satırda Başla! yazın.
        int counter = 3;

            while (counter > 0)
            {
                Console.WriteLine(counter);
                counter--;
            }

            Console.WriteLine("Başla!");
    }
}
