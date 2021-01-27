using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace EntityFrameworkBasic
{
    public class ETradeContext:DbContext
    {
        public DbSet<Products> Product { get; set; }
    }
}
