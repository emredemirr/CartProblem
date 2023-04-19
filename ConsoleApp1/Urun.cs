using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Urun
    {
        public string Adi { get; set; }
        public decimal Fiyat { get; set; }
        public int Adet { get; set; }
        public int Kategori { get; set; }


        public static List<Urun> urunler()
        {
            List<Urun> uruns = new List<Urun>
            {
                new Urun { Adi = "Bilgisayar", Fiyat = 200, Adet = 10, Kategori = 1 },
                new Urun { Adi = "Monitör", Fiyat = 200, Adet = 15, Kategori = 1 },
                new Urun { Adi = "Yazıcı", Fiyat = 200, Adet = 5, Kategori = 1 },
                new Urun { Adi = "Laptop", Fiyat = 200, Adet = 8, Kategori = 1 },
                new Urun { Adi = "Projeksiyon", Fiyat = 200, Adet = 2, Kategori = 1 },
                new Urun { Adi = "Masa", Fiyat = 200, Adet = 20, Kategori = 2 },
                new Urun { Adi = "Sandalye", Fiyat = 200, Adet = 50, Kategori = 2 },
                new Urun { Adi = "Koltuk", Fiyat = 200, Adet = 15, Kategori = 2 },
                new Urun { Adi = "Sehpa", Fiyat = 200, Adet = 10, Kategori = 2 },
                new Urun { Adi = "Keson", Fiyat = 200, Adet = 5, Kategori = 2 },
                new Urun { Adi = "Eldiven", Fiyat = 200, Adet = 100, Kategori = 3 },
                new Urun { Adi = "Sedye", Fiyat = 200, Adet = 3, Kategori = 3 },
                new Urun { Adi = "Diş Ünitesi", Fiyat = 200, Adet = 2, Kategori = 3},
                new Urun { Adi = "Ultrason", Fiyat = 200, Adet = 3, Kategori = 3 },
                new Urun { Adi = "MR Cihazı", Fiyat = 200, Adet = 3, Kategori = 3 },
            };
            return uruns;
        }
    }
}

