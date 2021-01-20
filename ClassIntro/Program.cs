using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.egitmen = "Engin Demirog";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.egitmen = "Kerem Varis";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 84;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.egitmen = "Murat Kurtbogan";
            kurs4.IzlenmeOrani = 100;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                
                Console.WriteLine(kurs.egitmen + " : " + kurs.KursAdi + " Izlenme Orani : " + kurs.IzlenmeOrani);
            } 


         
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
