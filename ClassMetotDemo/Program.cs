using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string Adi = "Ayşe";
            string Soyadi = "Yılmaz";
            int Id= 12345;
            string Adres = "Muğla";
            

            string [] Musteriler = new string[] { };

            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Ayşe";
            musteri1.Soyadi = "Fatma";
            musteri1.Id = 287;
            musteri1.Adres = "Aydın";

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Fatma";
            musteri2.Soyadi = "Sarı";
            musteri2.Id = 67;
            musteri2.Adres = "İzmir";

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Yunus";
            musteri3.Soyadi = "Can";
            musteri3.Id = 207;
            musteri3.Adres = "Denizli";

            Musteri musteri4 = new Musteri();
            musteri4.Adi = "Esra";
            musteri4.Soyadi = "Duman";
            musteri4.Id = 207;
            musteri4.Adres = "Denizli";



            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3,musteri4 };
             foreach ( Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri Adı = " + musteri.Adi);
                Console.WriteLine("Müşteri Soyadı = " + musteri.Soyadi);
                Console.WriteLine("Müşteri Id = " + musteri.Id);
                Console.WriteLine("Müşteri Adresi = " + musteri.Adres);
                Console.WriteLine("-------------------");
            }
            Console.WriteLine("metotlar");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Sil(musteri4);
            musteriManager.Guncelle( musteri2);





        }
    }
}
