using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Ege";
            musteri1.Soyadi = "Ozturk";
            musteri1.Yasi = 26;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Samet";
            musteri2.Soyadi = "Ozturk";
            musteri2.Yasi = 36;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Yumit";
            musteri3.Soyadi = "Gyuler";
            musteri3.Yasi = 29;


            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            Console.WriteLine("------------------------");
            Console.WriteLine("Musteriler Yenileniyor");
            Console.WriteLine("-------------------------");

            musteriManager.Silme(musteri2);

            Console.WriteLine("----------------");
            Console.WriteLine("Kalan Musteriler");
            Console.WriteLine("-------------------");
            musteriManager.Listele(musteri1); 
            musteriManager.Listele(musteri3);
        }
    }
}
