using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {

            Console.WriteLine("Musteri Eklendi" + musteri.Adi);

        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Musteriler: " + musteri.Adi);

        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " isimli müşterinin kaydı silindi!");
        }

        public void Guncelle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " isimli müşterinin kaydı güncellendi!");
        }

    }
}
