using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();

            musteri1.MusteriNo = "22212345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "1234567";
            musteri1.Id = 32;



            //Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();

            musteri2.SirketAdi = "Kodlama.io";
            musteri2.MusteriNo = "54321";
            musteri2.Id = 1;
            musteri2.VergiNo = " 2123154";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);




        }
    }
}
