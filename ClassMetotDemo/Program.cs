using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.Ad = "Ayşe";
            musteri1.Soyad = "Yıldızzzz";
            musteri1.Id = 1;
            musteri1.MusteriNo = "123456";

            Musteri musteri2 = new Musteri();

            musteri2.Ad = "Fatma";
            musteri2.Soyad = "sajdghj";
            musteri2.Id = 2;
            musteri2.MusteriNo = "345678";

            Musteri musteri3= new Musteri();

            musteri3.Ad = "Elif";
            musteri3.Soyad = "Öztürk";
            musteri3.Id = 3;
            musteri3.MusteriNo = "234567";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.CustomerAdd(musteri1);
            musteriManager.CustomerDelete(musteri2);
            musteriManager.CustomerList(musteriler);


            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
