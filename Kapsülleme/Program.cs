using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsülleme
{
    class Program
    {
        static void Main(string[] args)
        {
            EmlakKapsül emlk = new EmlakKapsül();
            emlk.kuladi = "Mehmet Sarıçam";
            emlk.Semt = "Çekmeköy";
            emlk.biyas = -4;
            emlk.fiyati = -340000;
            emlk.metrekare = -86;

            Console.WriteLine("Kullanıcı Adı= " + emlk.kuladi);
            Console.WriteLine("Kullanıcı Semti= " + emlk.Semt);
            Console.WriteLine("Bina Yaşı= " + emlk.biyas);
            Console.WriteLine("Bina Fiyatı= " + emlk.fiyati);
            Console.WriteLine("Binanın Metrekaresi= " + emlk.metrekare);
            Console.ReadLine();
        }
    }
    class EmlakKapsül
    {
        private string semt, kulad;
        private int binayas;
        private int metrek, fiyat;
        public string Semt
        {
            get { return semt; }
            set { semt = value.ToUpper(); }
        }
        public string kuladi
        {
            get { return kulad; }
            set { kulad = value.ToLower(); }
        }
        public int biyas
        {
            get { return binayas; }
            set { binayas = Math.Abs(value); }
        }
        public int metrekare
        {
            get { return metrek; }
            set { metrek = Math.Abs(value); }
        }
        public int fiyati
        {
            get { return fiyat; }
            set { fiyat = Math.Abs(value); }
        }
    }
}
