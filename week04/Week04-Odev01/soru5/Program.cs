namespace soru5;

class Program
{
    static void Main(string[] args)
    {
        //`BankAccount` sınıfı: hesap sahibi ve bakiye. Bakiye dışarıdan doğrudan değiştirilemesin; para yatırma ve çekme işlemleri ayrı davranışlarla yapılsın. Çekimde bakiye yetersizse bakiye değişmesin. `Main` içinde yatırma ve çekim deneyin; son bakiyeyi okunaklı para biçiminde yazdırın.

        BankAccount hesap = new BankAccount("Gizem");

        hesap.ParaYatir(1000);
        hesap.ParaCek(300);
        hesap.ParaCek(800);

        Console.WriteLine($"Son bakiye: {hesap.Bakiye:C}");
    }
}

class BankAccount
{
    public string HesapSahibi { get; set; }
    public decimal Bakiye { get; private set; }

    public BankAccount(string hesapSahibi)
    {
        HesapSahibi = hesapSahibi;
        Bakiye = 0;
    }

    public void ParaYatir(decimal miktar)
    {
        if (miktar > 0)
        {
            Bakiye += miktar;
        }
    }

    public void ParaCek(decimal miktar)
    {
        if (miktar > 0 && miktar <= Bakiye)
        {
            Bakiye -= miktar;
        }
    }
}
