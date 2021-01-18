using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] students = { "Ali", "Veli", "Mehmet", "Mert" };
            //foreach (var std in students)
            //{
            //    Console.WriteLine(std);
            //}

            //string[,] season = new string[4, 3]
            //{

            //    {"Aralık","Ocak","Şubat" },
            //    {"Mart","Nisan","Mayıs" },
            //    {"Haziran","Temmuz","Ağustos" },
            //    {"Eylül","Ekim","Kasım" }

            //};
            //for (int i = 0; i <= season.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j <= season.GetUpperBound(1); j++)
            //    {
            //        Console.WriteLine(season[i, j]);
            //    }
            //    Console.WriteLine("-------------");
            //}
            //Console.Write("Sayı giriniz= ");
            //int sayi=Convert.ToInt32(Console.ReadLine());

            //for (int i = sayi; i >= 0; i--)
            //{
            //    for (int j = i; j >= 0; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine ();
            //}



            //string[] sınıf= {"Ali","Veli","Fatma"};
            //foreach (var s in sınıf)
            //{
            //    Console.WriteLine(s);
            //}








            string[,] season = new string[3, 1]
            {
                { "Ali"},
                { "Veli"},
                { "Mehmet"}

            };
            for (int i = 0; i <= season.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= season.GetUpperBound(1); j++)
                {
                    Console.WriteLine(season[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}
