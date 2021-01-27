using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 

namespace EntityFrameworkDemo
{
    public class Product
    {
        public int Product_Id { get; set; }
        public string ProductName { get; set; }
        public decimal UnitePrice { get; set; }
        public int StockAmount { get; set; }
 
    }
}
