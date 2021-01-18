using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface ICustomerDal
    {
        //insert delete update işlemi data accecs layer(dal)
        void Add();
        void Delete();
        void Update();
    }
    class SqlServertCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added!");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql Updated");
        }
    }
    class OracleServertCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated");
        }
    }
    class CassandraServertCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Cassandra Added");
        }

        public void Delete()
        {
            Console.WriteLine("Cassandra Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Cassandra Updated");
        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
