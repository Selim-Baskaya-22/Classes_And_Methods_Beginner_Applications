using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap_Demo2_Loglama_İşlemi
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.logger = new SmsLog();
            customerManager.Added();
            Console.Read();
        }
    }
    class CustomerManager
    {
        public CustomerManager()
        {
            ILogger logger = new SqlLog();
            logger.Log();
        }

        public ILogger logger { get; set; }

        public void Added()
        {
            logger.Log();
            Console.WriteLine("Customer Added!");
        }
    }
    class SqlLog : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Sql Logged!");
        }
    }
    class SmsLog:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Sms Logged!");
        }
    }
    class CassandraLog:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Cassandra Logged!");
        }
    }
    interface ILogger
    {
        void Log();
    }
}
