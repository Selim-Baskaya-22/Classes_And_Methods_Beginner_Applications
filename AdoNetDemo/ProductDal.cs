using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal:IProductDal
    {
        SqlConnection _connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=Etrade; Integrated Security=True");
        public List<Product> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * From Product", _connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product
                {
                    Product_Id = Convert.ToInt32(reader["Product_Id"]),
                    ProducName = reader["ProductName"].ToString(),
                    UnitePrice = Convert.ToInt32(reader["UnitePrice"]),
                    StockAmount = Convert.ToInt32(reader["StockAmount"])
                };
                products.Add(product);
            }


            reader.Close();
            _connection.Close();
            return products;
        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

    

        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("insert into Product values(@ProductName,@UnitePrice,@StockAmount)", _connection);
            command.Parameters.AddWithValue("@ProductName", product.ProducName);
            command.Parameters.AddWithValue("@UnitePrice", product.UnitePrice);
            command.Parameters.AddWithValue("@StockAmount", product.StockAmount);
            command.ExecuteNonQuery();

            _connection.Close();
        }

        public void Update(Product product)
        {
            _connection.Open();
            SqlCommand command = new SqlCommand("update product set ProductName=@ProductName,UnitePrice=@UnitePrice,StockAmount=@StockAmount where Product_Id=@Product_Id", _connection);
            command.Parameters.AddWithValue("@ProductName",product.ProducName);
            command.Parameters.AddWithValue("@UnitePrice", product.UnitePrice);
            command.Parameters.AddWithValue("@StockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@Product_Id", product.Product_Id);
            command.ExecuteNonQuery();
            _connection.Close();
        
        }
       // ProductName=@ProductName,UnitePrice=@UnitePrice,StockAmount=@StockAmount
        public void Deleted(Product product)
        {
            _connection.Open();
            SqlCommand command = new SqlCommand("delete from product where Product_Id=@Product_Id", _connection);
            command.Parameters.AddWithValue("@Product_Id", product.Product_Id);
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
