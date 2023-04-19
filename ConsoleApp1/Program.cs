using ConsoleApp1;
using System;

public class Program
{
    static void Main(string[] args)
    {
 
        Sepet cart = new Sepet();

        cart.UrunFiyatBelirle();
        Console.Clear();
        cart.UrunEkle();
        cart.SepetToplam();
        cart.IndirimTutari();
    }
}