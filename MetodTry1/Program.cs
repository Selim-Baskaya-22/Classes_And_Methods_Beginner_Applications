using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodTry1
{
    class Program
    {
        static void try1()
        {
            Console.WriteLine("Try 1 !");
        }
        static int paramaters(int number1 = 0, int number2 = 0)
        {
            Console.Write("Enter Number 1: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number 2: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Result: ");
            int result = number1 + number2;
            return result;
        }
        static void Main(string[] args)
        {
            try1();
            //Console.WriteLine(paramaters());
            //int number1=20;
            //int number2 = 120;
            //int number3 = 2;
            //int result = refkey(number1, number2, number3);
            //Console.WriteLine(result);
            //Console.WriteLine(number3);
            int sum;

            for (int i = 0; i <= 100;)
            {

                Console.Write("Number 1= ");
                sum = paramskey(Convert.ToInt32(Console.ReadLine()));
                Console.Write("Number 2= ");
                sum += paramskey(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Total Numbers= " + sum);
                if (sum > 99)
                {
                    i += 101;
                }
            }


            Console.ReadKey();
        }
        static int refkey(int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        static int refkey(int number1, int number2, int number3)
        {
            number3 = 3;
            return (number1 + number2) * number3;
        }
        static int paramskey(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
