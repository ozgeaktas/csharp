using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusterininAdi + " "+
                musteri.MusterininSoyadi + " " +
                musteri.Id + " "+
                "bilgilerine sahip müsterimiz bankamıza eklenmiştir.");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.MusterininAdi + " "+
                musteri.MusterininSoyadi + " "+
                musteri.Id + " "+
                "bilgilerine sahip müsterimiz bankamıza silinmiştir.");
        }
        public void Listele(Musteri[] musteriler)
        {
            foreach(Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.MusterininAdi);
                Console.WriteLine(musteri.MusterininSoyadi);

            }
        }
    }
}
