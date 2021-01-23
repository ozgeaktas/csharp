using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = "123456";
            musteri1.MusterininAdi = "Selma";
            musteri1.MusterininSoyadi = "Saygın";
            Musteri musteri2 = new Musteri();
            musteri2.Id = "1032589";
            musteri2.MusterininAdi = "Burak";
            musteri2.MusterininSoyadi = "Yıldız";
            Musteri musteri3 = new Musteri();
            musteri3.Id = "34034039";
            musteri3.MusterininAdi = "Özge";
            musteri3.MusterininSoyadi = "Kaygılar";


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteri = new MusteriManager();

            Console.WriteLine("Bankamıza hoşgeldiniz1");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz" + "\n"+
                "0-çıkış"+"\n"+
                " 1-ekle" +"\n"+
                " 2-sil " +"\n"+
                " 3-listele ");




            while (true)
            {
                Console.WriteLine("Seçiminizi giriniz: ");
                int secim = Convert.ToInt16(Console.ReadLine());

                switch (secim)
                {
                    case 0:
                        Console.WriteLine("Çıkış yapılıyor...");
                        break;
                    case 1:
                        musteri.Ekle(musteri1);
                        musteri.Ekle(musteri2);
                        musteri.Ekle(musteri3);
                        break;
                    case 2:
                        musteri.Sil(musteri1);
                        musteri.Sil(musteri2);
                        musteri.Sil(musteri3);
                        break;
                    case 3:
                        musteri.Listele(musteriler);
                        break;
                    default:
                        Console.WriteLine("Lütfen geçerli bir seçim yapınız.");
                        break;
                }

            }

        }
    }
}
