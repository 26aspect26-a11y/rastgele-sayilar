using System;

class Program
{
    static void Main()
    {

        // Rastgele sayılarla en büyük/küçük, tek/çift ve filtreleme işlemleri
        
        Random rastgele = new Random();
        int[] sayilar = new int[10];

        // 1. Rastgele 10 sayı üret (1-100 arası)
        Console.WriteLine("Üretilen sayılar:");
        for (int i = 0; i < sayilar.Length; i++)
        {
            sayilar[i] = rastgele.Next(1, 101);
            Console.WriteLine($"{i + 1}. sayı: {sayilar[i]}");
        }

        // 2. En büyük ve en küçük sayıyı bul (sıralarıyla birlikte)
        int enBuyuk = sayilar[0];
        int enKucuk = sayilar[0];
        int enBuyukSira = 1;
        int enKucukSira = 1;

        for (int i = 1; i < sayilar.Length; i++)
        {
            if (sayilar[i] > enBuyuk)
            {
                enBuyuk = sayilar[i];
                enBuyukSira = i + 1;
            }
            if (sayilar[i] < enKucuk)
            {
                enKucuk = sayilar[i];
                enKucukSira = i + 1;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"En büyük sayı: {enBuyuk}");
        Console.WriteLine($"En küçük sayı: {enKucuk}");

        // 3. Çift ve tek sayıların adedini bul
        int ciftSayisi = 0;
        int tekSayisi = 0;

        foreach (int sayi in sayilar)
        {
            if (sayi % 2 == 0)
                ciftSayisi++;
            else
                tekSayisi++;
        }

        Console.WriteLine($"Çift sayı adedi: {ciftSayisi}");
        Console.WriteLine($"Tek sayı adedi: {tekSayisi}");

        // 4. En büyük ve en küçük sayının kaçıncı sayı olduğunu yazdır
        Console.WriteLine($"En büyük sayı {enBuyukSira}. sırada.");
        Console.WriteLine($"En küçük sayı {enKucukSira}. sırada.");

        // 5. Kullanıcıdan sayı iste, ondan büyük olanları yazdır
        int girilen;
        while (true)
        {
            Console.Write("\nBir sayı girin: ");
            if (int.TryParse(Console.ReadLine(), out girilen))
                break;
            Console.WriteLine("HATA! - Lütfen geçerli bir tam sayı girin.");
        }

        Console.WriteLine($"{girilen} sayısından büyük olan sayılar:");
        bool bulundu = false;
        foreach (int sayi in sayilar)
        {
            if (sayi > girilen)
            {
                Console.WriteLine(sayi);
                bulundu = true;
            }
        }

        if (!bulundu)
        {
            Console.WriteLine("Girdiğiniz sayıdan büyük sayı yok.");
        }

        Console.ReadLine();
    }
}
