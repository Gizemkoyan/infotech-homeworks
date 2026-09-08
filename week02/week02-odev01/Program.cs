namespace week02odev;

class Program
{
    static void Main(string[] args)
    {

        // 1. SORU : Ad (string), soyad (string), yaş (byte), şehir (string) değişkenlerini tanımlayın;
        // tek bir Console.WriteLine ile (tercihen string interpolation) ekrana yazdırın.
        {
            Console.WriteLine("===== 1. SORU =====");
            
            string ad = "Gizem";
            string soyad = "Koyan";
            byte yas = 24;
            string sehir = "İstanbul";
        
            Console.WriteLine($"Ad: {ad}, Soyad: {soyad}, Yaş: {yas}, Şehir: {sehir}");
        }

        // 2.SORU : Ürün stok adedini (int), şube kodunu (short), küçük bir kod değerini (byte) anlamlı değişken 
        // adlarıyla tanımlayın. (“Etiketli yazdırmak” = her satırda neye ait olduğu okunan bir ön yazıyla basmak;
        //  yani sadece sayı değil, “Stok: …” gibi.) Her birini ayrı satırda, başına açıklayıcı metin koyarak 
        // yazdırın (Console.WriteLine).
        {
            Console.WriteLine("===== 2. SORU =====");

            int stokAdedi = 150;
            short subeKodu = 245;
            byte kucukKod = 12;

            Console.WriteLine("Stok Adedi: " + stokAdedi);
            Console.WriteLine("Şube Kodu: " + subeKodu);
            Console.WriteLine("Küçük Kod Değeri: " + kucukKod);
        }

        // 3.SORU : Oda sıcaklığı (double), pencere açık mı (bool), birim göstergesi 
        // (char, örneğin santigrat için 'C') tanımlayın; sıcaklığı birim ile birlikte yazdırın; 
        // pencerenin durumunu okunaklı bir metinle belirtin.
            {
                Console.WriteLine("===== 3. SORU =====");

                double odaSicakligi = 24.5;
                bool pencereAcikMi = true;
                char birim = 'C';

                Console.WriteLine("Oda Sıcaklığı: " + odaSicakligi + "°" + birim);
                Console.WriteLine("Pencere Durumu: " + (pencereAcikMi ? "Açık" : "Kapalı"));
            }

        // 4.SORU : Birim fiyat (decimal), adet (int), KDV oranı yüzde (decimal, örneğin 20m) verilsin; 
        // ara toplam ve KDV dahil genel toplamı hesaplayıp para formatında (:C) gösterin.
            {
                Console.WriteLine("===== 4. SORU =====");

                decimal birimFiyat = 150.75m;
                int adet = 3;
                decimal kdvOrani = 20m;

                decimal araToplam = birimFiyat * adet;
                decimal genelToplam = araToplam + (araToplam * kdvOrani / 100);

                Console.WriteLine($"Ara Toplam: {araToplam:C}");
                Console.WriteLine($"KDV Dahil Genel Toplam: {genelToplam:C}");
            }

        // 5. SORU: Telefon numarası neden string, not ortalaması (4 üzerinden) neden double,
        //  market fişi toplamı neden decimal olduğunu kodu içinde üç kısa yorum satırı ile yazın; 
        // ardından her biri için birer örnek değişken tanımlayıp değerleri yazdırın.
            {
                Console.WriteLine("===== 5. SORU =====");

                string telefonNumarasi = "05321234567";
                double notOrtalamasi = 3.75;
                decimal marketToplami = 458.90m;

                Console.WriteLine("Telefon Numarası: " + telefonNumarasi);
                Console.WriteLine("Not Ortalaması: " + notOrtalamasi);
                Console.WriteLine("Market Fişi Toplamı: " + marketToplami + " TL");
            }

        // 6.SORU :Bir int değeri double değişkene örtük dönüşümle atayın; bir double değeri
        //  (örneğin 3.99) int’e açık cast ile atayın; hem genişletilmiş hem kesilmiş değerleri yazdırın.
        //  Ondalığın kesildiğini (ör. 3.99 → 3, yuvarlama yok) ekranda kısa bir Console.WriteLine 
        // satırıyla belirtin.
            {
                Console.WriteLine("===== 6. SORU =====");

                int tamSayi = 10;
                double genisletilmisDeger = tamSayi;
                double ondalikliSayi = 3.99;
                int kesilmisDeger = (int)ondalikliSayi;

                Console.WriteLine("Genişletilmiş Değer (int -> double): " + genisletilmisDeger);
                Console.WriteLine("Kesilmiş Değer (double -> int): " + kesilmisDeger);
                Console.WriteLine("Not: 3.99 -> 3 olur, ondalık kısım kesilir; yuvarlama yapılmaz.");
            }

        // 7.SORU Kullanıcıdan Console.ReadLine() ile doğum yılı alın; 
        // int.Parse ile sayıya çevirin; 2026 yılını baz alarak yaşı yaklaşık hesaplayıp
        //  (2026 - dogumYili) yazdırın.
            {
                Console.WriteLine("===== 7. SORU =====");

                Console.Write("Doğum yılınızı giriniz: ");
                string giris = Console.ReadLine();

                int dogumYili = int.Parse(giris);
                int yas = 2026 - dogumYili;

                Console.WriteLine("Yaklaşık yaşınız: " + yas);
            }

        // 8. SORU:  Aynı doğum yılı işini int.TryParse ile yapın:
        //  dönüşüm başarısızsa Geçersiz yıl yazın; başarılıysa yaşı önceki gibi yazdırın.
            {
                Console.WriteLine("===== 8. SORU =====");

                Console.Write("Doğum yılınızı giriniz: ");
                string giris = Console.ReadLine();

                if (int.TryParse(giris, out int dogumYili))
                {
                    int yas = 2026 - dogumYili;
                    Console.WriteLine("Yaklaşık yaşınız: " + yas);
                }
                else
                {
                    Console.WriteLine("Geçersiz yıl");
                }
            }

        // 9. SORU: Kullanıcıdan ürün fiyatı isteyin; decimal.TryParse ile okuyun.
        //  Başarılıysa 10m tutarında indirim uygulayın; sonuç sıfırın altına inmesin
            {
                Console.WriteLine("===== 9. SORU =====");

                Console.Write("Ürün fiyatını giriniz: ");
                string giris = Console.ReadLine();

                if (decimal.TryParse(giris, out decimal fiyat))
                {
                    decimal indirimliFiyat = fiyat - 10m;

                    if (indirimliFiyat < 0)
                    {
                        indirimliFiyat = 0;
                    }

                    Console.WriteLine("İndirimli fiyat: " + indirimliFiyat + " TL");
                }
                    else
                    {
                        Console.WriteLine("Geçersiz fiyat");
                    }
            }

        //10. SORU: Tek basamaklı rakam içeren bir string (örneğin "7") verin; 
        // char veya int.Parse ile tam sayıya çevirin; iki katını yazdırın.
            {
                Console.WriteLine("===== 10. SORU =====");

                string rakam = "7";

                int sayi = int.Parse(rakam);
                int sonuc = sayi * 2;

                Console.WriteLine("İki katı: " + sonuc);
            }

        // 11.SORU: int a = 10, b = 3 için a / b ile
        //  (double)a / b sonuçlarını yazdırın; farkı kodda bir yorum satırı ile özetleyin.
            {
                Console.WriteLine("===== 11. SORU =====");

                int a = 10;
                int b = 3;

                Console.WriteLine("a / b = " + (a / b));
                Console.WriteLine("(double)a / b = " + ((double)a / b));
            }

        // 12.SORU:  Kullanıcıdan tam sayı alın (TryParse). Sayı çift ise Çift, tek ise Tek yazdırın (% 2).
            {
                Console.WriteLine("===== 12. SORU =====");

                Console.Write("Bir tam sayı giriniz: ");
                string giris = Console.ReadLine();

                if (int.TryParse(giris, out int sayi))
                {
                    if (sayi % 2 == 0)
                    {
                        Console.WriteLine("Çift");
                    }
                    else
                    {
                        Console.WriteLine("Tek");
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz sayı");
                }
            }

        // 13.SORU:  23 yumurta var; her kutuya 6 yumurta konuyor. 
        // Kaç dolu kutu olduğunu ve kutuya sığmayan kalan yumurta sayısını / ve % ile hesaplayıp yazdırın.
            {
                Console.WriteLine("===== 13. SORU =====");

                int yumurtaSayisi = 23;
                int kutuKapasitesi = 6;

                int doluKutu = yumurtaSayisi / kutuKapasitesi;
                int kalanYumurta = yumurtaSayisi % kutuKapasitesi;

                Console.WriteLine("Dolu kutu sayısı: " + doluKutu);
                Console.WriteLine("Kalan yumurta sayısı: " + kalanYumurta);
            }

        //14.SORU: Toplam dakikayı (int) kullanıcıdan alın; 
        // tam saat ve kalan dakikayı hesaplayıp X saat Y dakika biçiminde yazdırın.
            {
                Console.WriteLine("===== 14. SORU =====");

                Console.Write("Toplam dakikayı giriniz: ");
                string giris = Console.ReadLine();

                if (int.TryParse(giris, out int toplamDakika))
                {
                    int saat = toplamDakika / 60;
                    int dakika = toplamDakika % 60;

                    Console.WriteLine(saat + " saat " + dakika + " dakika");
                }
                else
                {
                    Console.WriteLine("Geçersiz değer");
                }
            }

        //15.SORU: Yaş (int) ve vatandaşlık (bool) değişkenleri tanımlayın;
        //  oy kullanabilirlik için age >= 18 && isCitizen ifadesinin sonucunu bir bool 
        // değişkende tutun ve kullanıcıya anlamlı bir cümleyle yazdırın.
            {
                Console.WriteLine("===== 15. SORU =====");

                int yas = 24;
                bool isCitizen = true;

                bool oyKullanabilirMi = yas >= 18 && isCitizen;

                Console.WriteLine(oyKullanabilirMi 
                    ? "Kişi oy kullanabilir." 
                    : "Kişi oy kullanamaz.");
            }

        //16.SORU: bool isStudent ve yaş bilgisi ile: kişi öğrenci ise veya yaşı 65 ve 
        // üzeri ise indirim uygulanır. || kullanın; indirim var/yok mesajı yazdırın.
            {
                Console.WriteLine("===== 16. SORU =====");

                bool isStudent = true;
                int yas = 24;

                bool indirimVarMi = isStudent || yas >= 65;

                Console.WriteLine(indirimVarMi 
                    ? "İndirim uygulanır." 
                    : "İndirim uygulanmaz.");
            }

        //17.SORU:  0 ile 100 arasında (sınırlar dahil) bir not int ise geçerlidir;
        //  bu aralıkta değilse geçersizdir. Koşulu && ile veya anlamlı bir bool 
        // değişkende toplayarak mesaj yazdırın.
            {
                Console.WriteLine("===== 17. SORU =====");

                int not = 85;

                bool gecerliMi = not >= 0 && not <= 100;

                Console.WriteLine(gecerliMi 
                    ? "Not geçerlidir." 
                    : "Not geçersizdir.");
            }

        //18.SORU: int x = 0; tanımlayın; bool result = (x != 0) && (10 / x > 1); ifadesini yazıp
        //  result değerini yazdırın. Programın neden bölme hatasına düşmediğini bir cümlelik yorum 
        // satırı ile açıklayın.
            {
                Console.WriteLine("===== 18. SORU =====");

                int x = 0;

                bool result = (x != 0) && (10 / x > 1);

                Console.WriteLine("Result: " + result);
            }

        // 19.SORU: 0–100 arası bir not için: 50’den küçükse Kaldı,
        //  50–69 Geçer, 70–84 İyi, 85 ve üzeri Pekiyi. Sınırda 50’nin dahil olduğu 
        // “Geçer” olduğundan emin olun. Yalnızca if / else if / else kullanın (switch yok).
            {
                Console.WriteLine("===== 19. SORU =====");

                int not = 78;

                if (not < 50)
                {
                    Console.WriteLine("Kaldı");
                }
                else if (not < 70)
                {
                    Console.WriteLine("Geçer");
                }
                else if (not < 85)
                {
                    Console.WriteLine("İyi");
                }
                else
                {
                    Console.WriteLine("Pekiyi");
                }
            }


        //20.SORU:  Sabit bir decimal bakiye ve kullanıcıdan 
        // decimal.TryParse ile çekilecek tutar alın: tutar 0 veya negatifse Geçersiz tutar; 
        // tutar bakiyeden büyükse Yetersiz bakiye; aksi halde bakiyeyi düşürüp yeni bakiyeyi
        //  :C ile gösterin.
            {
                Console.WriteLine("===== 20. SORU =====");

                decimal bakiye = 500m;

                Console.Write("Çekilecek tutarı giriniz: ");
                string giris = Console.ReadLine();

                if (decimal.TryParse(giris, out decimal cekilecekTutar))
                {
                    if (cekilecekTutar <= 0)
                    {
                        Console.WriteLine("Geçersiz tutar");
                    }
                    else if (cekilecekTutar > bakiye)
                    {
                        Console.WriteLine("Yetersiz bakiye");
                    }
                    else
                    {
                        bakiye -= cekilecekTutar;
                        Console.WriteLine($"Yeni bakiye: {bakiye:C}");
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş");
                }
            }    
    }
    
}
