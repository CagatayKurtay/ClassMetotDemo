using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] Musterilerimiz = new string[] { };
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Zekeriya";
            musteri1.Soyadı = "Özçiçek";
            musteri1.Cinsiyeti = "Erkek";
            musteri1.Yasi = 41;



            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Naime";
            musteri2.Soyadı = "Durmuşoğulları";
            musteri2.Cinsiyeti = "Kadın";
            musteri2.Yasi = 81;

            Musteri[] Musteriler = new Musteri[] { musteri1, musteri2 };
            foreach (Musteri musteri in Musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadı);
                Console.WriteLine(musteri.Cinsiyeti);
                Console.WriteLine(musteri.Yasi);

              

            }

            Console.WriteLine("---------Metot------");
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);

            musteriManager.Silme(musteri1);
            musteriManager.Silme(musteri2);





        }
    }
}
