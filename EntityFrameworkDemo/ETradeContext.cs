using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace EntityFrameworkDemo
{
    
    public class ETradeContext:DbContext
    {
        public DbSet<Product> Product { get; set; }
    }
}
