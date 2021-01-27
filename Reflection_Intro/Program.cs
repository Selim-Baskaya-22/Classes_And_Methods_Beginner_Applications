using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Math maths = new Math(3,2);
            //Console.WriteLine(math.sum(4, 5));
            //Console.WriteLine(math.sum2());

            var type = typeof(Math);
            Math maths =(Math)Activator.CreateInstance(type,4,5);
            Console.WriteLine(maths.sum2());

            var math = Activator.CreateInstance(type,3,4);
            Console.WriteLine(math.GetType().GetMethod("sum2").Invoke(math,null));

            //or
            
            MethodInfo methodInfo = math.GetType().GetMethod("sum2");
            Console.WriteLine( methodInfo.Invoke(math,null));


            var metods = type.GetMethods();
            foreach (var metod in metods)
            {
                Console.WriteLine("Method Name ={0} ", metod.Name);
                foreach (var name in metod.GetParameters())
                {
                    Console.WriteLine("Parameters Name  ={0} ", name.Name );
                }
                Console.WriteLine();
                foreach (var item in metod.GetCustomAttributes())
                {
                    Console.WriteLine("Attributes Name = {0}",item);
                }
            }
            
            Console.ReadKey();
        }
    }
 
}
