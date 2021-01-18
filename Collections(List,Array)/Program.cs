using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_List_Array_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { CustomerId=1,Customer_FirstName="Selim",Customer_LastName="Başkaya",CustomerTC="42922915734"});
            customers.Add(new Customer { CustomerId = 2, Customer_FirstName = "Ferhat",Customer_LastName="Sönmez",CustomerTC="12345678901" });
            customers.Add(new Customer { CustomerId = 3, Customer_FirstName = "Sinan",Customer_LastName="Akçıl",CustomerTC="45678912345"});
         
            foreach (var customer in customers)
            {
                Console.Write(customer.CustomerId+" ");
                Console.Write(customer.Customer_FirstName+" ");
                Console.Write(customer.Customer_LastName+" ");
                Console.WriteLine(customer.CustomerTC);
            }
            
                
            Console.ReadLine();
        }
    }
    class Customer : ICustomerServices
    {
        public int CustomerId { get ; set; }
        public string Customer_FirstName { get ; set; }
        public string Customer_LastName { get; set; }
        private string tc;
        public string CustomerTC
        {
            get { return tc; }
            
               
            
            set
            {
               // 429 2291 5734
                tc =value.Substring(0, 3)+" **** *"+value.Substring(8,3) ;
                tc = CustomerTC;
          
            }
        }
    }
    interface ICustomerServices
    {
         int CustomerId { get; set; }
         string CustomerTC { get; set; }
         string Customer_FirstName { get; set; }
         string Customer_LastName { get; set; }
    }
}
