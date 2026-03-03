Asal Sayı Kontrol Uygulaması (Grup 2)
1. Proje Tanımı
Bu proje, kullanıcının konsol üzerinden girdiği tam sayıların matematiksel olarak asal olup olmadığını kontrol eden bir uygulamadır. Uygulama, sayıların temel bileşenlerini analiz ederek algoritma ve döngü mantığını göstermeyi amaçlar.


2. Çalışma Mantığı
Program şu adımları takip eder:

Kullanıcıdan bir tam sayı girdisi alır.

Sayının 2'den küçük olması durumunda (0, 1 ve negatif sayılar) doğrudan "Asal Değildir" sonucunu verir.


Sayı 2 veya daha büyükse, bir for döngüsü ile sayının kendisine kadar olan değerlere modu alınır.

Herhangi bir sayıya tam bölünme gerçekleşirse sayı asal değil olarak işaretlenir.

3. Kullanılan Teknolojiler

Programlama Dili: C#.



Kütüphane: System, System.Collections.Generic.


4. Sistem Gereksinimleri

İşletim Sistemi: Windows 10/11.


Çalışma Ortamı: .NET 8.0 SDK.


Geliştirme Aracı: Visual Studio 2022.

5. Lisans Bilgisi
Bu proje MIT Lisansı ile lisanslanmıştır.


Neden MIT Lisansı Seçildi?:


Açık Kaynak: Kodun herkes tarafından incelenmesine ve geliştirilmesine izin verir.


Ticari Kullanım: Yazılımın ticari amaçlarla kullanılmasına olanak tanır.


Basitlik: Kullanım koşulları ve yasal sorumluluk reddi çok net ve kısa bir metinden oluşur.



KOd Blocuğu

using System;
using System.Collections.Generic; // Liste kullanabilmek için gerekli

namespace AsalSayiMi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test edilen sayıları ve sonuçlarını tutmak için bir liste oluşturuyoruz
            List<string> testGecmisi = new List<string>();
            string secim = "";

            Console.WriteLine("--- Asal Sayı Kontrol Paneli ---");
            Console.WriteLine("Çıkış yapmak için 'h' tuşuna basınız, devam etmek için herhangi bir tuşa basınız.");

            while (secim != "h")
            {
                Console.Write("\nKontrol edilecek sayıyı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                bool kalansizBolum = false;

                // Asallık kontrol mantığı (Döngü ve Karar Yapısı) 
                if (sayi < 2)
                {
                    kalansizBolum = true;
                }
                else
                {
                    for (int i = 2; i < sayi; i++)
                    {
                        if (sayi % i == 0)
                        {
                            kalansizBolum = true;
                            break;
                        }
                    }
                }

                // Sonucu belirle ve listeye ekle
                string sonuc = kalansizBolum ? "Asal Değil" : "Asal";
                testGecmisi.Add($"| {sayi,-15} | {sonuc,-15} |");

                Console.WriteLine($"{sayi} sayısı kontrol edildi: {sonuc}");

                Console.Write("Başka bir sayı denemek ister misiniz? (e/h): ");
                secim = Console.ReadLine().ToLower();
            }

            // Ödevin 'Bulgular' kısmı için kodun içinde tablo oluşturma 
            Console.WriteLine("\n\n--- TEST SONUÇLARI TABLOSU ---");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("| Girilen Sayı    | Sonuç           |");
            Console.WriteLine("---------------------------------------");

            foreach (var satir in testGecmisi)
            {
                Console.WriteLine(satir);
            }

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Program sonlandırıldı. Çıkmak için Enter'a basın.");
            Console.ReadLine();
        }
    }
}