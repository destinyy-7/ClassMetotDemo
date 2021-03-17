using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " Eklendi.");
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " Silindi.");
        }
        public void Update(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " Güncellendi.");
        }
        public void List(Musteri[] musteriler) {

            Console.WriteLine("Müşteri Listesi");
            for (int i = 0; i < musteriler.Length; i++)
            {
                Console.WriteLine(" "+musteriler[i].Id+" : "+musteriler[i].Name +" "+musteriler[i].Surname);
            }
        }
    }
}
