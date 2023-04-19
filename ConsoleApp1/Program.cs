using ConsoleApp1;
using System;

public class Program
{
    static void Main(string[] args)
    {
        /*double[] prices = new double[7];
        int[] quantities = new int[7];
        // Kullanıcıdan ürünlerin fiyatları ve miktarları için girdi alınması
        for (int i = 0; i < 7; i++)
        {
            Console.Write("Ürün " + (i + 1) + " fiyatı: ");
            prices[i] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ürün " + (i + 1) + " miktarı: ");
            quantities[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Toplam fiyat ve indirim miktarı için değişkenler oluşturma
        double totalPrice = 0;
        double totalDiscount = 0;

        // Her bir ürünü ve fiyatını işleme alma
        for (int i = 0; i < 7; i++)
        {
            // Ürün grubunu belirleme
            int group = 0;
            if (i < 5)
            {
                group = 1;
            }
            else if (i < 10)
            {
                group = 2;
            }
            else
            {
                group = 3;
            }

            // Toplam fiyata ürün fiyatı ve miktarını ekleyin
            double productPrice = prices[i] * quantities[i];
            totalPrice += productPrice;

            // İndirim miktarını hesaplayın ve toplam indirime ekleyin
            double discount = 0;
            if (quantities[i] > 1)
            {
                switch (group)
                {
                    case 1:
                        if (productPrice > 1000)
                            discount = productPrice * 0.01;
                        break;
                    case 2:
                        if (productPrice > 2000)
                            discount = productPrice * 0.02;
                        break;
                    case 3:
                        if (productPrice > 3000)
                            discount = productPrice * 0.03;
                        break;
                }
                totalDiscount += discount;
            }
        }

        // Toplam indirimi toplam fiyattan çıkarın
        double finalPrice = totalPrice - totalDiscount;

        // Sonuçları yazdırın
        Console.WriteLine("Toplam fiyat: " + totalPrice.ToString("C"));
        Console.WriteLine("Toplam indirim: " + totalDiscount.ToString("C"));
        Console.WriteLine("Sepet Tutarı: " + finalPrice.ToString("C"));

        Console.ReadLine();*/
        /*const string TL = " TL";
        string cizgi = "-------------------------------------------------";
        string uzunCizgi = "--------------------------------------------------------------------------";
        // Ürünler ve fiyatlar
        string[] urunGrup1 = { "Bilgisayar", "Monitör", "Yazıcı", "Laptop", "Projeksiyon"};
        string[] urunGrup2 = { "Masaaa", "Sandalye", "Koltuk", "Sehpa", "Keson"};
        string[] urunGrup3 = { "Eldiven", "Sedye", "Diş Ünitesi", "Ultrason", "MR Cihazı" };

        List<string> urunler = new List<string>();
        urunler.AddRange(urunGrup1);
        urunler.AddRange(urunGrup2);
        urunler.AddRange(urunGrup3);

        double[] fiyatlar = new double[urunler.Count];

        // Ürün fiyatlarını kullanıcıdan alma
        for (int i = 0; i < urunler.Count; i++)
        {
            do
            {
                Console.Write($"'{urunler[i]}' ürünün fiyatını girin: ");
                fiyatlar[i] = double.Parse(Console.ReadLine());
                if (fiyatlar[i] < 100 || fiyatlar[i] > 1000)
                    Console.WriteLine("Hatalı Giriş! 100-1000 arasında bir değer giriniz.");
            } while (fiyatlar[i] < 100 || fiyatlar[i] > 1000);

        }
        

        // Ürün ve fiyatları tablo şeklinde listeleme
        Console.Clear();
        Console.WriteLine(cizgi);
        Console.WriteLine("|  Ürünler\t\t|  Fiyatlar\t\t|");
        Console.WriteLine(cizgi);
        for (int i = 0; i < urunler.Count; i++)
        {
            Console.WriteLine($"|  {i+1 + "." + urunler[i]}\t\t|  {fiyatlar[i]:C}"+TL+"\t\t|");
        }
        Console.WriteLine(cizgi);
        Console.WriteLine("\n");


        // Kaç adet ürün ekleyeceği ve ürün adetlerini kullanıcıdan alma
        int urunAdedi;
        do
        {
            Console.Write("Ürün adedini girin (1-7 arasında): ");
            urunAdedi = int.Parse(Console.ReadLine());
            if (urunAdedi < 1 || urunAdedi > 7)
                Console.WriteLine("Hatalı giriş yaptınız, lütfen 1-7 arasında bir değer girin.");
        }
        while (urunAdedi < 1 || urunAdedi > 7);

        string[] sepet = new string[urunAdedi];
        int[] sepetAdetleri = new int[urunAdedi];
        double sepetToplam = 0;

        for (int i = 0; i < urunAdedi; i++)
        {
            Console.Write($"{i + 1}. ürünün ismini girin: ");
            string urunIsmi = Console.ReadLine();
            sepet[i] = urunIsmi;

            Console.Write($"{urunIsmi} üründen kaç adet istiyorsunuz? : ");
            int urunAdeti = int.Parse(Console.ReadLine());
            sepetAdetleri[i] = urunAdeti;

            int urunIndex = Array.IndexOf(urunGrup1, urunIsmi);
            double urunFiyati = fiyatlar[urunIndex] * urunAdeti;
            sepetToplam += urunFiyati;
        }

        // Sepet bilgilerini listeleme
        Console.Clear();
        Console.WriteLine("\n");
        Console.WriteLine(uzunCizgi);
        Console.WriteLine("|  Ürün\t\t\t|  Adet\t\t|  Fiyat\t|  Tutar\t |");
        Console.WriteLine(uzunCizgi);
        
        for (int i = 0; i < urunAdedi; i++)
        {
            double fiyat = sepetAdetleri[i] * fiyatlar[Array.IndexOf(urunGrup1, sepet[i])];
            Console.WriteLine($"| {i+"."+ sepet[i]}\t\t|  {sepetAdetleri[i]}\t\t|  {fiyatlar[Array.IndexOf(urunGrup1, sepet[i])]:C}      | {fiyat:C}" + TL + "| ");
        }
        double grup1Fiyat = sepetToplam;


        Console.WriteLine(uzunCizgi);
        Console.WriteLine($"|  Toplam Tutar:\t\t\t\t\t| {sepetToplam:C}" + TL + "|");
        Console.WriteLine(uzunCizgi);*/

        Sepet cart = new Sepet();

        cart.UrunFiyatBelirle();
        Console.Clear();
        cart.UrunEkle();
        cart.SepetToplam();
        cart.IndirimTutari();
    }
}