using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazilim Gelistirici Yetistirme Kampi";
            string kurs2 = "Programlamaya baslangic icin temel kurs";
            string kurs3 = "Java kursu";

            Console.WriteLine(kurs1);
            Console.WriteLine("Tum kurslar bu sekilde devam eder kurs2 kurs3 vs");
            Console.WriteLine("Manuel yazma burada bitiyor--------");
            Console.WriteLine("------------------------------------");
            //array - dizi

            string[] kurslar = new string[] { "Yazilim Gelistirici Yetistirme Kampi", "Programlamaya baslangic icin temel kurs", "Java kursu", "Python", "C#" };




            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti simdi foreach baslayacak");
            Console.WriteLine("----------------------------------------");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}
