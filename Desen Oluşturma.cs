using System;

class Program
{
    static int SayiOku(string mesaj)
    {
        while (true)
        {
            Console.Write(mesaj);
            string giris = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(giris))
            {
                Console.WriteLine("HATA! - Boş bırakmayın.");
                continue;
            }

            if (!int.TryParse(giris.Trim(), out int sayi))
            {
                Console.WriteLine("HATA! - Metin girmeyin, tam sayı girin.");
                continue;
            }

            if (sayi < 1 || sayi > 50)
            {
                Console.WriteLine("HATA! - Sayı 1 ile 50 arasında olmalıdır.");
                continue;
            }

            return sayi;
        }
    }

    static char KarakterOku(string mesaj)
    {
        while (true)
        {
            Console.Write(mesaj);
            string giris = Console.ReadLine();

            if (string.IsNullOrEmpty(giris) || giris.Length != 1 || char.IsWhiteSpace(giris[0]))
            {
                Console.WriteLine("HATA! - Boşluk olmayan TEK bir karakter girin.");
                continue;
            }

            return giris[0];
        }
    }

    static void Main()
    {
        int enGenis = SayiOku("En geniş satırdaki karakter sayısı (1-50): ");
        char birinciKarakter = KarakterOku("Birinci karakteri girin: ");
        char ikinciKarakter = KarakterOku("İkinci karakteri girin: ");

        Console.WriteLine();

        int toplamSatir = 2 * enGenis - 1;

        for (int satir = 1; satir <= toplamSatir; satir++)
        {
            // Önce artan, sonra azalan genişlik: 1,2,3,4,5,4,3,2,1
            int genislik = (satir <= enGenis) ? satir : toplamSatir - satir + 1;

            // Tek satırlarda ikinci karakter, çift satırlarda birinci karakter
            char karakter = (satir % 2 == 1) ? ikinciKarakter : birinciKarakter;

            for (int sutun = 1; sutun <= genislik; sutun++)
            {
                Console.Write(karakter);
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}