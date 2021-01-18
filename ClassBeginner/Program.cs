using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBeginner
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrencii ogr = new Ogrencii();
            Console.Write("Öğrenci Adını Giriniz= ");
            ogr.Ograd = Console.ReadLine();
            Console.Write("Öğrenci Soyadını Giriniz= ");
            ogr.Ogrsoyad = Console.ReadLine();
            Console.Write("Alan Bilgisini Giriniz= ");
            ogr.Alan = Console.ReadLine();
            Console.Write("Öğrencinin Yaşını Giriniz= ");
            ogr.Yası = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Öğrenci Yaşı=" + ogr.Yası);
            Console.Read();
        }
    }

    class Ogrencii
    {
        private string ograd, soyad, alan;
        private int yas;
        public string Ograd
        {
            get { return ograd; }
            set { ograd = value; }
        }
        public string Ogrsoyad
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public string Alan
        {
            get { return alan; }
            set { alan = value; }
        }
        public int Yası
        {
            get { return yas; }
            set
            {
                if (value < 18)
                {
                    yas = 18;
                }
                else
                {
                    yas = value;
                }
            }

        }
    }
}
