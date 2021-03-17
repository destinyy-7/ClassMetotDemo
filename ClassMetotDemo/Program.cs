using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();

            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Name = "Kader";
            musteri1.Surname = "İPEK";

            musteriManager.Add(musteri1);

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Name = "Zeynep";
            musteri2.Surname = "SAYGIN";

            musteriManager.Add(musteri2);

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Name = "Muhammet";
            musteri3.Surname = "GÜNEŞ";

            musteriManager.Add(musteri3);

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Name = "Elif";
            musteri4.Surname = "GÜNDOĞDU";

            musteriManager.Add(musteri4);
            musteriManager.Delete(musteri2);
            musteriManager.Update(musteri1);

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3,musteri4 };
            musteriManager.List(musteriler);
        }
    }
}
