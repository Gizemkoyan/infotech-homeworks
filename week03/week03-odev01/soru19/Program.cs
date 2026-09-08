namespace soru19;

class Program
{
    static void Main(string[] args)
    {
        //`static string NormalizeCourseCode(string code)` metodu yazın: parametreyi `Trim` + `ToUpper` ile döndürsün. `Main` içinde `" mcsd-101 "` gibi kirli bir girdi verip sonucu yazdırın.

        Console.WriteLine(NormalizeCourseCode(" mcsd-101 "));

        static string NormalizeCourseCode(string code)
        {
            return code.Trim().ToUpper();
        }
        
    }
}
