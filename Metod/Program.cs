using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metod
{
    class Program
    {
        static void Main(string[] args)
        {
            //add();
            //operations(0,0);
            //int number1 = 20;
            //int number2 = 100;
            //var result = operations2(out number1,number2);
            //Console.WriteLine(result);
            //Console.WriteLine(number1);
            //Console.WriteLine(multiply(2, 3));
            //Console.WriteLine(multiply(2,3,5));
            Console.WriteLine(add1(1, 2, 3, 4, 5, 6, 7));
            Console.ReadKey();
        }
        static void add()
        {
            Console.WriteLine("-------Operations-------");
        }
        static void operations(int number1, int number2)
        {

            Console.Write("1.Sayıyı Giriniz= ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz= ");
            number2 = Convert.ToInt32(Console.ReadLine());
            var result = number1 + number2;
            Console.WriteLine("Result= " + result);

        }
        static int operations2(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        static int multiply(int n1, int n2)
        {
            return n1 * n2;
        }
        static int multiply(int n1, int n2, int n3)
        {
            return n1 * n2 * n3;
        }
        static int add1(params int[] numbers)
        {
            //return numbers.Max();
            return numbers.Max();

        }
    }
}