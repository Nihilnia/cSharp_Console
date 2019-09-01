using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    static class HelperMethods
    {
        public static string KarakterDuzelt(string Metin)
        {
            return Metin.Replace("ç", "c").
                Replace("ö", "o").
                Replace("ı", "i");
        }
    }

    class Urun
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public double UrunFiyat { get; set; }
        public bool IsSatista { get; set; }
    }

    static class MyDatabase
    {
        static Urun[] urunler = new Urun[4];

        static MyDatabase()
        {
            urunler[0] = new Urun() { UrunID = 1, UrunFiyat = 20.05, IsSatista = true };
            urunler[1] = new Urun() { UrunID = 2, UrunFiyat = 45.05, IsSatista = false };
            urunler[2] = new Urun() { UrunID = 3, UrunFiyat = 40.05, IsSatista = false };
            urunler[3] = new Urun() { UrunID = 4, UrunFiyat = 60.45, IsSatista = true };
        }

        public static Urun[] UrunleriGoster()
        {
            return urunler;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string girilenMetin = "ışık ölümüne çıkıyor lmao";
            Console.WriteLine(HelperMethods.KarakterDuzelt(girilenMetin));

            Urun[] gosterilecekUrunler = MyDatabase.UrunleriGoster();

            foreach (var item in gosterilecekUrunler)
            {
                string satistaMi;

                if (item.IsSatista)
                {
                    satistaMi = "Evet";
                    Console.WriteLine("Urun ID: {0} - Urun Adi: {1} - Urun Fiyat: {2} - Satista mi: {3}", item.UrunID, item.UrunAdi, item.UrunFiyat, satistaMi);
                }
                else
                {
                    satistaMi = "Hayır";
                    Console.WriteLine("Urun ID: {0} - Urun Adi: {1} - Urun Fiyat: {2} - Satista mi: {3}", item.UrunID, item.UrunAdi, item.UrunFiyat, satistaMi);
                }

                
            }

            Console.ReadLine();
        }
    }
}
