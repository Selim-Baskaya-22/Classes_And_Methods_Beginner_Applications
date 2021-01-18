using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayıBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, sonuc = 0;
            //int asalbölen;

            Console.WriteLine("-----------Asal Sayı Bulma----------");
        basadön:
            Console.Write("Sayıyı giriniz= ");
            number1 = Convert.ToInt32(Console.ReadLine());
            if (number1 == 1 || number1 == 2)
            {
                Console.WriteLine("1 ve 2 sayısını girmeyiniz");
                goto basadön;
            }
            for (int i = 2; i <= number1 - 1; i++)
            {
                sonuc = number1 % i;
                if (sonuc != 0 && number1 != 2)
                {
                    Console.WriteLine("Sayı Asaldır");
                    i += number1;
                }
                else if (sonuc == 0 && number1 != 2)
                {
                    Console.WriteLine("Sayı Asal değildir");
                    i += number1;
                }
            }


            //for (int i = 0; i < 10; i++)
            //{
            //sayibastanyazdir:
            //Console.Write("Sayıyı giriniz= ");
            //number1 = Convert.ToInt32(Console.ReadLine());
            //if (number1!=1)
            //{       
            //asalbölen = number1-1; 
            //sonuc = number1 % asalbölen;

            //while (sonuc!=0  && asalbölen!=1)
            //{
            //    if (number1!=2)
            //    {
            //        sonuc = number1 % asalbölen;
            //        asalbölen -= 1;
            //    }                
            //}
            //if (sonuc == 0 && number1!=2)
            //{
            //    Console.WriteLine("Sayı asal değildir");
            //}
            //else 
            //{               
            //        Console.WriteLine("Sayı asaldır");         
            //}
            //}
            //else
            //{
            //    Console.WriteLine("Girilen Sayı 1 olamaz");
            //    goto sayibastanyazdir;
            //}
            //}

            Console.ReadLine();
        }

    }
}
