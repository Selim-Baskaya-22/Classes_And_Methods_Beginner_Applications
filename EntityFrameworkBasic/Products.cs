using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkBasic
{
    [Table("Product")]

        public class Products
    {
        [Key]
        public int Product_Id { get; set; }
        public string ProductName { get; set; }
        public decimal UnitePrice { get; set; }
        public int StockAmount { get; set; }
    }
}
