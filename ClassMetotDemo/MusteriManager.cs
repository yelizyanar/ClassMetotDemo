using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri Bilgileri : " );

        }
        public void Guncelle(Musteri musteri)
       {
        Console.WriteLine("Müşteri güncelle: "  + " " + musteri.Adi +" "+  musteri.Soyadi + " " +  musteri.Id + " "+  musteri.Adres);
           }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("müşteri listele: " );

        }

    public void Sil(Musteri musteri)
        {
            Console.WriteLine("müşteri sil : ");
        }
         


    }
}
