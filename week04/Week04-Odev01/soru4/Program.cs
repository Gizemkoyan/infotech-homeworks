namespace soru4;

class Program
{
    static void Main(string[] args)
    {
        //`Student` sınıfına çalışma mesajı basan bir davranış ekleyin; mesajda öğrencinin adı geçsin. `Main` içinde en az iki öğrenci için bu davranışı çalıştırın.

        Student ogrenci1 = new Student("Ahmet");
        Student ogrenci2 = new Student("Zeynep");

        ogrenci1.Calis();
        ogrenci2.Calis();
    }
}

class Student
{
    public string Ad { get; set; }

    public Student(string ad)
    {
        Ad = ad.ToUpper();
    }

    public void Calis()
    {
        Console.WriteLine($"MCSD için çalışıyor: {Ad}");
    }
}