namespace soru14;

class Program
{
    static void Main(string[] args)
    {
        //`string tags = "csharp;dotnet;web";` ifadesini `Split(';')` ile böldükten sonra **kaç parça** olduğunu ve **son** parçayı yazdırın.

        string tags = "csharp;dotnet;web";

        string[] parcalar = tags.Split(';');

        Console.WriteLine("Parça sayısı: " + parcalar.Length);
        Console.WriteLine("Son parça: " + parcalar[parcalar.Length - 1]);
    }
}
