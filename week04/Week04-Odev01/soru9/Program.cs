namespace soru9;

class Program
{
    static void Main(string[] args)
    {
        //`Person`'dan türeyen `StudentPerson`: öğrenci numarası da tutulsun, rol Öğrenci dönsün. `Main` içinde bir öğrenci oluşturup ad, numara ve rolü yazdırın.

        StudentPerson ogrenci = new StudentPerson("Zeynep Kaya", 2024001);

        Console.WriteLine($"{ogrenci.TamAd} (No: {ogrenci.OgrenciNo}) — Rol: {ogrenci.RolGetir()}");
    }
}

class Person
{
    public string TamAd { get; set; }

    public Person(string tamAd)
    {
        TamAd = tamAd;
    }

    public virtual string RolGetir()
    {
        return "Personel";
    }
}

class StudentPerson : Person
{
    public int OgrenciNo { get; set; }

    public StudentPerson(string tamAd, int ogrenciNo) : base(tamAd)
    {
        OgrenciNo = ogrenciNo;
    }

    public override string RolGetir()
    {
        return "Öğrenci";
    }
}
