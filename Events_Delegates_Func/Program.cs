using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Delegates_Func
{
    public delegate void StockControl();
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Stok Miktarı Giriniz: ");
            int stock=Convert.ToInt32(Console.ReadLine());
            Product product = new Product(stock);
            product.ProductName = "Ram";
            product.StockControlEvent += Product_StockControlEvent;
            for (int i = 0; i < 10; i++)
            {
                product.Sell(10);
                Console.ReadLine();
            }
            Console.Read();
        }

        private static void Product_StockControlEvent()
        {
            Console.WriteLine("Stok Azalıyor Lütfen Stoklarınızı Yenileyiniz!");
        }
    }
    class Product
    {
        int _stock;
        public Product(int stock)
        {
            _stock = stock;
        }
        public event StockControl StockControlEvent;
        public string ProductName { get; set; }
        public int Stock
        {
            get { return _stock; }
            set
            {
                _stock = value;
                if (_stock <= 20 && StockControlEvent != null)

                {
                    StockControlEvent();
                }
            }
        }
        public void Sell(int amount)
        {
            Stock -= amount;
            Console.WriteLine("Product Name: {0}",ProductName);
            Console.WriteLine("Stock Amount: {0}",Stock);
            
        }
    }
}
