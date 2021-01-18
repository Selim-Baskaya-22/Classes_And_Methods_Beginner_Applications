using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] worker = new IWorker[3]
            {
                new Manager(),
                new Robots(),
                new Worker()
            };
            foreach (var worker1 in worker)
            {
                worker1.works();
            }
            Console.ReadKey();
        }
    }

    interface IEat
    {
        void eat();
       
    }
    interface IGetSalary
    {
        void GetSalary();
    }
    interface IWorker
    {
        void works();
    }

    class Manager : IWorker,IGetSalary,IEat
    {
        public void eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void works()
        {
            Console.WriteLine("Yönetici");
        }
    }
    class Worker : IWorker,IGetSalary,IEat
    {
        public void eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void works()
        {
            Console.WriteLine("İnsan");
        }
    }
    class Robots : IWorker
    {      
        public void works()
        {
            Console.WriteLine("Robot");
        }
    
    }
 

}
