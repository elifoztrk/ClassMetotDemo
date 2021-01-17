using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void CustomerAdd(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + "İsimli Muşteri Eklendi");
        }

        public void CustomerDelete(Musteri musteri)
        {
            if(musteri.Id==1)
            {
                Console.WriteLine(musteri.Ad + " " + "İsimli Muşteri Silindi");
            }

            else
            {
                Console.WriteLine(musteri.Ad + " " + "İsimli Muşteriyi Silemezsiniz");
            }
          
        }

        public void CustomerList(Musteri[] musteriler)
        {
            Console.WriteLine("Müşteri Listesi");
            foreach (Musteri item in musteriler)
            {
                Console.WriteLine(item.Ad + "/ " + item.Soyad + "/" + item.MusteriNo);
            }

        }

    }
}
