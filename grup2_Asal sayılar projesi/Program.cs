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