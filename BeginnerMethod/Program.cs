using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerMethod
{
    class Program
    {
        int Topla(int s1, int s2)
        {
            int t;
            return t = s1 + s2;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int s1, s2, topla;
            Console.Write("1. Sayıyı Giriniz= ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz= ");
            s2 = Convert.ToInt32(Console.ReadLine());
            topla = p.Topla(s1, s2);
            Console.Write("Sonuç= " + topla);
            Console.Read();

        }
    }
}
