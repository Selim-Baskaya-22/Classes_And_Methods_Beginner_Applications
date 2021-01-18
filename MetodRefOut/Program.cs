using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodRefOut
{
    class Program
    {
        //Değer döndürmeyen metod
        static void Yazdır()
        {
            string yaz = "Değer Döndürmeyen Metot";
            Console.WriteLine(yaz);
        }
        //Toplama İşlemi
        static int topla(int sayi1, int sayi2)
        {
            var sonuç = sayi1 + sayi2;
            Console.WriteLine(sonuç);
            return sonuç;
        }
        //Ref kullanarak toplama
        static int reftopla(ref int a, int b)
        {
            a = 20;
            return a + b;
        }
        //out kullanarak toplama
        static int outtopla(out int a, int b)
        {
            a = 10;
            return a + b;
        }
        //params kullanım
        static int paramss(params int[] a)
        {
            return a.Sum();
        }
        static void Main(string[] args)
        {
            Yazdır();
            //int a1, a2;       



            /* Toplama
            Console.WriteLine("sayı gir=");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sayı gir=");
            a2 = Convert.ToInt32(Console.ReadLine());
         
            Console.WriteLine("sonuc={0}",topla( a1,a2));
            Console.WriteLine(a1);
             */

            /* RefTOPLAMA
            Console.WriteLine("sayı gir=");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sayı gir=");
            a2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("sonuc={0}", reftopla(ref a1, a2));
            Console.WriteLine(a1);
            */

            /*OUT TOPLAMA      
             * var sonuc = outtopla(out a1,a2);
            Console.WriteLine("Sonuç= {0}",sonuc);

            /*PARAMS KULLANIM
            Console.WriteLine("Toplam= " + paramss(2, 3, 4, 5, 6, 7, 3));
            */

            Console.Read();
        }
    }
}
