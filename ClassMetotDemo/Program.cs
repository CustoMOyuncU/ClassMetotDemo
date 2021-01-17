using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********ClassMetotDemoBankacılık*********\n");
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Emirhan";
            musteri1.Soyadi = "Köseoğlu";
            musteri1.Id = 55;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Mehmet";
            musteri2.Soyadi = "Konak";
            musteri2.Id = 153;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Murat";
            musteri3.Soyadi = "Sungur";
            musteri3.Id = 120;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("----Müşteriler ekleniyor----");
            
            foreach (Musteri musteri in musteriler)
            {
                musteriManager.Ekle(musteri);
            }

            Console.WriteLine("\n*****MÜŞTERİLER*****");

            foreach (Musteri musteri in musteriler)
            {
                musteriManager.Listele(musteri);
            }

            musteriManager.Delete(musteri3, musteriler);

            //Dont Repeat Yoursel -- DRY
        }
    }
}
