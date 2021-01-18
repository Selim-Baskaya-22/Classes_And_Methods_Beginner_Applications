using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaClass
{

    class Araba
    {
        public string renk, model, vites, plaka;
        public int tutar;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Araba arbsnf = new Araba();
            arbsnf.renk = "Mavi";
            arbsnf.model = "2019";
            arbsnf.plaka = "34-İstanbul";
            arbsnf.vites = "Otomatik";
            arbsnf.tutar = 300000;

            Console.WriteLine("Araba Rengi=" + arbsnf.renk);
            Console.WriteLine("Araba Modeli=" + arbsnf.model);
            Console.WriteLine("Araba Plaka=" + arbsnf.plaka);
            Console.WriteLine("Araba Vites=" + arbsnf.vites);
            Console.WriteLine("Araba Tutarı=" + arbsnf.tutar);

            Console.WriteLine();

            arbsnf.renk = "Siyah";
            arbsnf.model = "2014";
            arbsnf.plaka = "34-İstanbul";
            arbsnf.vites = "Manuel";
            arbsnf.tutar = 140000;

            Console.WriteLine("Araba Rengi=" + arbsnf.renk);
            Console.WriteLine("Araba Modeli=" + arbsnf.model);
            Console.WriteLine("Araba Plaka=" + arbsnf.plaka);
            Console.WriteLine("Araba Vites=" + arbsnf.vites);
            Console.WriteLine("Araba Tutarı=" + arbsnf.tutar);
            Console.Read();
        }
    }
}
