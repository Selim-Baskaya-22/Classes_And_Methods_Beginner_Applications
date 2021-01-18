using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustumerManager custumerManager = new CustumerManager();
            custumerManager.Add();
            custumerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.CustomerId = 1;
            customer.CustomerFirstName = " Selim";
            customer.CustomerLastName = "Baskaya";
            customer.CustomerCity = "Sinop";

            Customer customer2 = new Customer
            {
                CustomerId = 2,
                CustomerFirstName = " Mertcan",
                CustomerLastName = "Karakulak",
                CustomerCity = "Rize"
            };

            Console.Write(customer.CustomerId);
            Console.WriteLine(customer.CustomerFirstName);
            Console.WriteLine(customer.CustomerLastName);
            Console.WriteLine("-------------------------");
            Console.Write(customer2.CustomerId);
            Console.WriteLine(customer2.CustomerFirstName);
            Console.WriteLine(customer2.CustomerLastName);
           
            Console.ReadKey();
        }     
    }
    class CustumerManager
    { 
        public void Add()
        {
            Console.WriteLine("Custumer Added!");
        }
        public void Update()
        {
            Console.WriteLine("Custumer Updated!");
        }
    }
    class ProductManager
    {
        public void Add()
        {
            Console.WriteLine("Product Added!");
        }
        public void Update()
        {
            Console.WriteLine("Product Updated!");
        }
    }
}
