using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //TEMEL NESNE OLUŞTURUR
            //Interfaces();
            //IcustomerDal();
            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServertCustomerDal(),
                new OracleServertCustomerDal(),
                new CassandraServertCustomerDal()
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            Console.ReadKey();
        }

        private static void IcustomerDal()
        {
            CustomerManager customerManager = new CustomerManager();
            SqlServertCustomerDal sql = new SqlServertCustomerDal();
            customerManager.Add(sql);
            customerManager.Add(new OracleServertCustomerDal());
        }

        private static void Interfaces()
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                Adi = "Selim",
                Soyadi = "Başkaya",
                Adress = "Çekmeköy"
            };
            personManager.Add(customer);
            Student student = new Student
            {
                Id = 1,
                Adi = "Selim",
                Soyadi = "Başkaya",
                Departman = "Bilişim"
            };
            personManager.Add(student);
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string Adi { get; set; }
        string Soyadi { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Adress { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string Adi { get; set ; }
        public string Soyadi { get; set; }
        public string Departman { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine("{0} Customer Added!",person.Adi);
        }
      
    }
}
