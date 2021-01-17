using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " eklendi...");
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi+" "+musteri.Soyadi+" Id: "+musteri.Id);
        }
        public void Delete(Musteri musteri,Musteri[] kalan)
        {
            bool x = true;
            if (x == true)
            {
                Console.WriteLine("\n----Müşteri Siliniyor----");
            }
            Console.WriteLine("Idsi "+musteri.Id+" olan "+musteri.Adi+" "+musteri.Soyadi+" isimli kişi silindi!");
            foreach (Musteri item in kalan)
            {
                if (x == true)
                {
                    Console.WriteLine("\n*****MÜŞTERİLER*****");
                }
                
                if (item.Id!=musteri.Id)
                {

                    Console.WriteLine(item.Adi + " " + item.Soyadi + " Id: " + item.Id);
                }

                x = false;
            }
        }
    }
}
