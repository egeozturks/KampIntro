using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri Eklendi : " + musteri.Adi + " " + musteri.Soyadi);
        }
        public void Listele(Musteri musteri) 
        {
            Console.WriteLine("Musteri Listeleniyor : " + musteri.Adi + " " + musteri.Soyadi);
        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Musteri Siliniyor : " + musteri.Adi + " " + musteri.Soyadi);
        }
    }
}
