namespace soru3;

class Program
{
    static void Main(string[] args)
    {
        //`Student` sınıfı: ad, soyad, yaş. Ad atandığında baştaki ve sondaki boşluklar temizlensin, ad büyük harfle saklansın. Yaş yalnızca 0–150 aralığında kabul edilsin; dışındaki değer atanamasın. Oluştururken ad ve soyad zorunlu olsun. `Main` içinde adı başında ve sonunda boşluk olan bir öğrenci oluşturup (`"  ayşe  "`, `"demir"`), yaşı 21 yapıp bilgileri yazdırın.

        Student ogrenci = new Student("  ayşe  ", "demir");

        ogrenci.Yas = 21;

        Console.WriteLine($"Ad: {ogrenci.Ad}, Soyad: {ogrenci.Soyad}, Yaş: {ogrenci.Yas}");
    }
}

class Student
{
    private string ad = "";
    private int yas;

    public string Ad
    {
        get
        {
            return ad;
        }
        set
        {
            ad = value.Trim().ToUpper();
        }
    }

    public string Soyad { get; set; }

    public int Yas
    {
        get
        {
            return yas;
        }
        set
        {
            if (value >= 0 && value <= 150)
            {
                yas = value;
            }
        }
    }

    public Student(string ad, string soyad)
    {
        Ad = ad;
        Soyad = soyad;
    }
}