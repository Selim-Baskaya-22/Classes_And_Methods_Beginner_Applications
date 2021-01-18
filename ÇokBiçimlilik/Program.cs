using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÇokBiçimlilik
{
    class Program
    {
        static void Main(string[] args)
        {

            türk t = new türk();
            fransız f = new fransız();
            İnsan i = new İnsan();
            i.selam();
            Console.WriteLine();
            t.selaM = Console.ReadLine();
            Console.WriteLine(t.selaM);
            Console.WriteLine();
            f.selam();
            Console.Read();
        }
    }
    class İnsan
    {

        public virtual void selam()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Hello World!");
        }
    }
    class türk : İnsan
    {
        private string selamver;
        public string selaM
        {
            get { return selamver; }
            set { selamver = value.ToLower(); }
        }
        public override void selam()
        {

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            //Console.WriteLine("Merhaba Dünya!");
        }
    }
    class fransız : İnsan
    {
        public override void selam()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Bonjour World!!");
        }
    }
}
