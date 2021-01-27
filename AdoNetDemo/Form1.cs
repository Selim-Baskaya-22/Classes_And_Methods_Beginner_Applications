using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgwProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        Product _product = new Product();
        ProductDal _productDal = new ProductDal();
        private void button1_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }
        private void TextClear()
        {
            textProductName.Clear();
            textProductNameUpdate.Clear();
            textStockAmount.Clear();
            textStockAmountUpdate.Clear();
            textUnitePrice.Clear();
            textUnitePriceUpdate.Clear();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product 
            { 
                ProducName = textProductName.Text,
                UnitePrice=Convert.ToDecimal(textUnitePrice.Text),
                StockAmount=Convert.ToInt32(textStockAmount.Text)
            }
            );
            TextClear();
            LoadProducts();
            MessageBox.Show("Product Added!");
        }



        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // textProductId = dgwProducts.CurrentRow.Cells[0].Value.ToString();
            textProductNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            textUnitePriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            textStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }
        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Product_Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                ProducName =textProductNameUpdate.Text,
                UnitePrice = Convert.ToDecimal(textUnitePriceUpdate.Text),
                StockAmount = Convert.ToInt32(textStockAmountUpdate.Text),
            });
            TextClear();
            LoadProducts();
            MessageBox.Show("Product Updated!");
            //MessageBox.Show("{0} Product Updated!",_product.ProducName);
        }

        private void btnDeleted_Click(object sender, EventArgs e)
        {
            _productDal.Deleted(new Product 
                {
                    Product_Id=Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                    ProducName=textProductNameUpdate.Text,
                    UnitePrice=Convert.ToInt32(textUnitePriceUpdate.Text),
                    StockAmount=Convert.ToInt32(textStockAmountUpdate.Text)
                }            
            );
            TextClear();
            LoadProducts();
            MessageBox.Show("Product Deleted!");
        }
    }
}
