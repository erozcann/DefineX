using System;
using ZorunluAlanLibrary; // Class Library referansı eklenmeli

namespace ConsoleZorunluKontrol
{
    public class Ogrenci
    {
        [ZorunluAlan]
        public string Adi { get; set; }
        [ZorunluAlan]
        public string Soyadi { get; set; }
        [ZorunluAlan]
        public string Bolum { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci()
            {
                Adi = "İbrahim",
                Soyadi = "Gökyar",
                Bolum = "Yazılım"
            };

            if (!ZorunluAlanAttribute.Dogrula(ogrenci))
            {
                Console.WriteLine("Öğrenci bilgileri doğrulamadan geçemedi!");
            }
            else
            {
                Console.WriteLine("Form başarılı!");
            }

            Console.ReadLine();
        }
    }
}
