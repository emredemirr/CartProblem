using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Sepet
    {
        private List<Urun> urunler;
        private int maksimumAdet;

        public Sepet()
        {
            this.urunler = new List<Urun>();
            this.maksimumAdet = maksimumAdet;
        }
        List<Urun> sepet = new List<Urun>();
        List<Urun> urunListesi = Urun.urunler();
        decimal grup1Fiyat = 0, grup2Fiyat = 0, grup3Fiyat = 0, urunTutar, toplamSepetTutari = 0, indirimliSepetTutari = 0, indirimMiktari = 0;


        //Ürünlerin fiyatları uygulama başlangıcında programcıdan alınır. 
        //Ürün fiyatları 100-1000 TL arasında olmalıdır.
        public List<Urun> UrunFiyatBelirle()
        {


            for (int i = 0; i < urunListesi.Count; i++)
            {
                do
                {
                    Console.Write($"'{urunListesi[i].Adi}' ürünün fiyatını girin: ");
                    urunListesi[i].Fiyat = int.Parse(Console.ReadLine());
                    if (urunListesi[i].Fiyat < 100 || urunListesi[i].Fiyat > 1000)
                        Console.WriteLine("Hatalı Giriş! 100-1000 arasında bir değer giriniz.");
                }
                while (urunListesi[i].Fiyat < 100 || urunListesi[i].Fiyat > 1000);
            }
            return urunListesi;
        }

        // Tüm ürünler arasından 1-7 arasında ürünü(1-10 adet) rastgele sepete ekler. 
        public void UrunEkle()
        {
            string cizgi = "--------------------------------------------------------------------------";
            Random rnd = new Random();
            int sayi = rnd.Next(1, 8);

            for (int i = 0; i < sayi; i++)
            {
                Urun urun = urunListesi[rnd.Next(urunListesi.Count)];
                int adet = rnd.Next(1, 11);
                urun.Adet = adet;
                sepet.Add(urun);
                urunTutar = 0;

                if (urun.Kategori == 1)
                    grup1Fiyat += urun.Fiyat * urun.Adet;
                urunTutar = urun.Fiyat * urun.Adet;
                if (urun.Kategori == 2)
                    grup2Fiyat += urun.Fiyat * urun.Adet;
                urunTutar = urun.Fiyat * urun.Adet;
                if (urun.Kategori == 3)
                    grup3Fiyat += urun.Fiyat * urun.Adet;
                urunTutar = urun.Fiyat * urun.Adet;

                if (i == 0)
                {
                    Console.WriteLine("\n\t\t\t\tÜrünler Tablosu\t\t");
                    Console.WriteLine(cizgi);
                    Console.WriteLine("|  Adı\t\t\t|  Fiyat\t| Adet\t\t| Tutar\t\t |");
                }
                Console.WriteLine($"| {i + 1 + "." + urun.Adi}\t\t|  {urun.Fiyat}\t\t|  {urun.Adet}\t\t| {urunTutar}\t\t | ");

                if (i == sayi - 1)
                    Console.WriteLine(cizgi);
            }
        }

        // İndirimsiz sepet tutarı
        public void SepetToplam()
        {
            foreach (Urun urun in sepet)
            {
                toplamSepetTutari = grup1Fiyat + grup2Fiyat + grup3Fiyat;
            }
            Console.WriteLine($"\t\t\t\t\t   Toplam Sepet  Tutarı: {toplamSepetTutari}" + " TL |");
            Console.WriteLine("--------------------------------------------------------------------------");
        }

        public void IndirimTutari()
        {
            decimal indirimliSepetTutari = toplamSepetTutari;
            
            foreach (Urun urun in sepet)
            {
                urunTutar = urun.Fiyat * urun.Adet;
                if (urun.Adet > 1)
                {
                    if (urunTutar > 1000 && urunTutar <= 2000)
                        indirimMiktari += urunTutar / 100;
                    
                    if (urunTutar > 2000 && urunTutar <= 3000)
                        indirimMiktari += (urunTutar / 100) * 2;
                        
                    if (urunTutar > 3000 && urunTutar <= 4000)
                        indirimMiktari += (urunTutar / 100) * 3;
                        
                    if (urunTutar > 4000 && urunTutar <= 5000)
                        indirimMiktari += (urunTutar / 100) * 4;
                        
                    if (urunTutar > 5000 && urunTutar <= 6000)
                        indirimMiktari += (urunTutar / 100) * 5;
                        
                    if (urunTutar > 6000 && urunTutar <= 7000)
                        indirimMiktari += (urunTutar / 100) * 6;
                }
                
            }
            indirimliSepetTutari = toplamSepetTutari - indirimMiktari;
            Console.WriteLine($"\t\t\t\t\tİndirimli Sepet  Tutarı: {indirimliSepetTutari}" + " TL |");
            Console.WriteLine("--------------------------------------------------------------------------");

            /*Console.WriteLine("\n\n-------------------------");
            Console.WriteLine("1.Grup Tutarı: " + grup1Fiyat + " TL");
            Console.WriteLine("2.Grup Tutarı: " + grup2Fiyat + " TL");
            Console.WriteLine("3.Grup Tutarı: " + grup3Fiyat + " TL");
            Console.WriteLine("-------------------------\n\n");*/
        }
    }
}
