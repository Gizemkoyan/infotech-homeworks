using System;
namespace Week01_Odev01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SORU1= Ad (`string`), soyad (`string`), yaş (`byte`), şehir (`string`) değişkenlerini tanımlayın; tek bir `Console.WriteLine` ile (tercihen string interpolation) ekrana yazdırın.
           { 
            Console.WriteLine("===== SORU 1 =====");
            string ad = "Gizem";
            string soyad = "Koyan";
            byte yas = 24;
            string sehir = "İstanbul";

            Console.WriteLine($"Ad: {ad}, Soyad: {soyad}, Yaş: {yas}, Şehir: {sehir}");}

           
            //SORU2= Ürün stok adedini (`int`), şube kodunu (`short`), küçük bir kod değerini (`byte`) anlamlı değişken adlarıyla tanımlayın. *(“Etiketli yazdırmak” = her satırda neye ait olduğu okunan bir ön yazıyla basmak; yani sadece sayı değil, “Stok: …” gibi.)* Her birini **ayrı satırda**, başına açıklayıcı metin koyarak yazdırın (`Console.WriteLine`).
            {
            Console.WriteLine("===== SORU 2 ====="); 
            int stokAdedi= 200;
            short subeKodu= 707;
            byte kod= 10;
            Console.WriteLine($"stok adedi: {stokAdedi}");
            Console.WriteLine($"sube kodu: {subeKodu}");
            Console.WriteLine($"kod: {kod}");}


            //SORU3= Oda sıcaklığı (`double`), pencere açık mı (`bool`), birim göstergesi (`char`, örneğin santigrat için `'C'`) tanımlayın; sıcaklığı birim ile birlikte yazdırın; pencerenin durumunu okunaklı bir metinle belirtin.
            {
            Console.WriteLine("===== SORU 3 =====");
            double odaSıcaklığı= 25.5;
            bool pencereAcıkMı= true;
            char birim ='C';
            Console.WriteLine($"Sıcaklık:{odaSıcaklığı} {birim} - Pencere Açıkmı?:{pencereAcıkMı}");}


            //SORU4= Birim fiyat (`decimal`), adet (`int`), KDV oranı yüzde (`decimal`, örneğin `20m`) verilsin; ara toplam ve KDV dahil genel toplamı hesaplayıp para formatında (`:C`) gösterin.
            {
            Console.WriteLine("===== SORU 4 =====");
            decimal birimFiyat= 150.75m;
            int adet=3;
            decimal kdvOranı=20m;
            decimal araToplam= birimFiyat * adet;
            decimal kdvTutarı= araToplam * kdvOranı / 100;
            decimal genelToplam= araToplam + kdvTutarı;

            Console.WriteLine($"ara toplam:{araToplam:C}");
            Console.WriteLine($"genel toplam:{genelToplam:C}");}


            //SORU5= Telefon numarası neden `string`, not ortalaması (4 üzerinden) neden `double`, market fişi toplamı neden `decimal` olduğunu **kodu içinde üç kısa yorum satırı** ile yazın; ardından her biri için birer örnek değişken tanımlayıp değerleri yazdırın.
            {
            Console.WriteLine("===== SORU 5 =====");
            string telefonNumarası= "05372518898";
            double notOrtalaması= 3.75;
            decimal marketFişiToplamı= 487.90m;

            Console.WriteLine($"Telefon Numarası: {telefonNumarası}");
            Console.WriteLine($"Not Ortalaması: {notOrtalaması}");
            Console.WriteLine($"Market Fişi Toplamı: {marketFişiToplamı}");}


            //SORU6= Bir `int` değeri `double` değişkene örtük dönüşümle atayın; bir `double` değeri (örneğin `3.99`) `int`’e açık cast ile atayın; hem genişletilmiş hem kesilmiş değerleri yazdırın. Ondalığın **kesildiğini** (ör. `3.99` → `3`, yuvarlama yok) ekranda kısa bir `Console.WriteLine` satırıyla belirtin.
            {
            Console.WriteLine("===== SORU 6 =====");    
            int tamSayi= 100;
            double genişletilmişDeğer= tamSayi;

            double ondalıklıSayı= 3.99;
            int kesilmişDeğer= (int)ondalıklıSayı;

            Console.WriteLine($"int'den double'a: {genişletilmişDeğer:0}");
            Console.WriteLine($"double'den int'e: {ondalıklıSayı:0.00}");
            Console.WriteLine($"Not: ondalık kısım yuvarlanmaz,atılır");}


            //SORU7= Kullanıcıdan `Console.ReadLine()` ile doğum yılı alın; `int.Parse` ile sayıya çevirin; **2026** yılını baz alarak yaşı yaklaşık hesaplayıp (`2026 - dogumYili`) yazdırın.
            {
            Console.WriteLine("===== SORU 7 =====");    
            Console.WriteLine("Doğum yılınızı giriniz:");
            string? girilenDeger = Console.ReadLine();
            int dogumYili = int.Parse(girilenDeger!);
            int hesaplananYas = 2026 - dogumYili;

            Console.WriteLine($"Yaklaşık yaşınız: {hesaplananYas}");}

            //SORU8= Aynı doğum yılı işini `int.TryParse` ile yapın: dönüşüm başarısızsa `Geçersiz yıl` yazın; başarılıysa yaşı önceki gibi yazdırın.
            {
            Console.WriteLine("===== SORU 8 =====");    
            Console.Write("Doğum yılınızı giriniz: ");
            string? girilenDeger = Console.ReadLine();
            if (int.TryParse(girilenDeger, out int dogumYili))
            {
                int yas = 2026 - dogumYili;
                Console.WriteLine($"Yaklaşık yaşınız: {yas}");
            }
            else
            {
                Console.WriteLine("Geçersiz yıl");
            }}


            //SORU9= Kullanıcıdan ürün fiyatı isteyin; `decimal.TryParse` ile okuyun. Başarılıysa `10m` tutarında indirim uygulayın; sonuç sıfırın altına inmesin (`Math.Max(0m, ...)` veya `if`). Son tutarı `:C` ile yazdırın.
            {
            Console.WriteLine("===== SORU 9 =====");    
            Console.Write("Ürün fiyatını giriniz: ");
            string? girilenFiyat = Console.ReadLine();
            if (decimal.TryParse(girilenFiyat, out decimal fiyat))
            {
                decimal odenecek = Math.Max(0m, fiyat - 10m);
                Console.WriteLine($"Ödenecek: {odenecek:C}");
            }
            else
            {
                Console.WriteLine("Geçersiz fiyat");
            }}


            //SORU10= Tek basamaklı rakam içeren bir `string` (örneğin `"7"`) verin; `char` veya `int.Parse` ile tam sayıya çevirin; **iki katını** yazdırın.
            {
            Console.WriteLine("===== SORU 10 =====");    
            Console.Write("Tek basamaklı bir rakam giriniz: ");
            string? rakam = Console.ReadLine();
            if (int.TryParse(rakam, out int sayi))
            {
                Console.WriteLine($"İki katı: {sayi * 2}");
            }
            else
            {
                Console.WriteLine("Geçersiz giriş.");}
            }


            //SORU11= `int a = 10`, `b = 3` için `a / b` ile `(double)a / b` sonuçlarını yazdırın; farkı kodda bir yorum satırı ile özetleyin.
            {
            Console.WriteLine("===== SORU 11 ====="); 
            int a = 10;
            int b = 3;

            Console.WriteLine($"Tam sayı bölme: {a / b}");
            Console.WriteLine($"Kayan noktalı bölme: {(double)a / b}");}


            //SORU12= Kullanıcıdan tam sayı alın (`TryParse`). Sayı çift ise `Çift`, tek ise `Tek` yazdırın (`% 2`).
            {
            Console.WriteLine("===== SORU 12 =====");      
            Console.Write("Bir tam sayı giriniz: ");
            string? girilenSayi = Console.ReadLine();
            if (int.TryParse(girilenSayi, out int sayi))
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
                Console.WriteLine("Geçersiz sayı.");
            }}


            //SORU13= 23 yumurta var; her kutuya 6 yumurta konuyor. Kaç **dolu kutu** olduğunu ve kutuya sığmayan **kalan yumurta** sayısını `/` ve `%` ile hesaplayıp yazdırın.
            {
            Console.WriteLine("===== SORU 13 =====");   
            int yumurta = 23;
            int kutuKapasitesi = 6;

            int doluKutu = yumurta / kutuKapasitesi;
            int kalanYumurta = yumurta % kutuKapasitesi;

            Console.WriteLine($"Dolu kutu: {doluKutu}");
            Console.WriteLine($"Kalan yumurta: {kalanYumurta}");}


            //SORU14= Toplam dakikayı (`int`) kullanıcıdan alın; tam saat ve kalan dakikayı hesaplayıp `X saat Y dakika` biçiminde yazdırın.
            {
            Console.WriteLine("===== SORU 14 ====="); 
            Console.Write("Toplam dakikayı giriniz: ");
            string? girilenDakika = Console.ReadLine();
            if (int.TryParse(girilenDakika, out int toplamDakika))
            {
                int saat = toplamDakika / 60;
                int dakika = toplamDakika % 60;
                Console.WriteLine($"{saat} saat {dakika} dakika");
            }
            else
            {
                Console.WriteLine("Geçersiz giriş.");
            }}


            //SORU15= Yaş (`int`) ve vatandaşlık (`bool`) değişkenleri tanımlayın; oy kullanabilirlik için `age >= 18 && isCitizen` ifadesinin sonucunu bir `bool` değişkende tutun ve kullanıcıya anlamlı bir cümleyle yazdırın.
            {
            Console.WriteLine("===== SORU 15 =====");     
            int yas = 20;
            bool vatandas = true;
            bool oyKullanabilir = yas >= 18 && vatandas;
            if (oyKullanabilir)
            {
                Console.WriteLine("Oy kullanabilirsiniz: Evet");
            }
            else
            {
                Console.WriteLine("Oy kullanabilirsiniz: Hayır");
            }}


            //SORU16= `bool isStudent` ve yaş bilgisi ile: kişi **öğrenci ise** veya **yaşı 65 ve üzeri ise** indirim uygulanır. `||` kullanın; indirim var/yok mesajı yazdırın.
            {
            Console.WriteLine("===== SORU 16 =====");     
            bool ogrenciMi = true;
            int yas = 20;
            bool indirim = ogrenciMi || yas >= 65;
            if (indirim)
            {
                Console.WriteLine("İndirim uygulanır.");
            }
            else
            {
                Console.WriteLine("İndirim uygulanmaz.");
            }}


            //SORU17= 0 ile 100 arasında (sınırlar dahil) bir not `int` ise geçerlidir; bu aralıkta değilse geçersizdir. Koşulu `&&` ile veya anlamlı bir `bool` değişkende toplayarak mesaj yazdırın.
            {
            Console.WriteLine("===== SORU 17 =====");     
            int not = 85;
            bool notGecerli = not >= 0 && not <= 100;
            if (notGecerli)
            {
                Console.WriteLine("Not geçerli.");
            }
            else
            {
                Console.WriteLine("Not geçersiz.");
            }}


            //SORU18= `int x = 0;` tanımlayın; `bool result = (x != 0) && (10 / x > 1);` ifadesini yazıp `result` değerini yazdırın. Programın neden bölme hatasına düşmediğini **bir cümlelik yorum satırı** ile açıklayın.
            {
            Console.WriteLine("===== SORU 18 =====");
            int x = 0;
            bool result = (x != 0) && (10 / x > 1);

            Console.WriteLine($"Sonuç: {result}");}


            //SORU19=  0–100 arası bir not için: 50’den küçükse `Kaldı`, 50–69 `Geçer`, 70–84 `İyi`, 85 ve üzeri `Pekiyi`. Sınırda 50’nin dahil olduğu “Geçer” olduğundan emin olun. **Yalnızca `if` / `else if` / `else`** kullanın (`switch` yok).
            {
            Console.WriteLine("===== SORU 19 =====");   
            int not = 72;
            if (not < 50)
            {
                Console.WriteLine("Durum: Kaldı");
            }
            else if (not <= 69)
            {
                Console.WriteLine("Durum: Geçer");
            }
            else if (not <= 84)
            {
                Console.WriteLine("Durum: İyi");
            }
            else
            {
                Console.WriteLine("Durum: Pekiyi");
            }}


            //SORU20= Sabit bir `decimal` bakiye ve kullanıcıdan `decimal.TryParse` ile çekilecek tutar alın: tutar 0 veya negatifse `Geçersiz tutar`; tutar bakiyeden büyükse `Yetersiz bakiye`; aksi halde bakiyeyi düşürüp yeni bakiyeyi `:C` ile gösterin.
            {
            Console.WriteLine("===== SORU 20 =====");    
            decimal bakiye = 250m;

            Console.Write("Çekmek istediğiniz tutarı giriniz: ");

            string? girilenTutar = Console.ReadLine();
            if (decimal.TryParse(girilenTutar, out decimal cekilecekTutar))
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
            }}
            
    

        
        }
    }
}


    

