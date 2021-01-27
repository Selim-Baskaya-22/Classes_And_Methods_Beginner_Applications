using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkBasic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    
        ProductDal _productDal = new ProductDal();
     
        void TextClear()
        {
            textProductName.Clear();
            textProductNameUpdate.Clear();
            textStockAmount.Clear();
            textStockAmountUpdate.Clear();
            textUnitePrice.Clear();
            textUnitePriceUpdate.Clear();
        }

        private void LoadProduct()
        {
            dgwProducts.DataSource = _productDal.GetProducts();
        }

        private void btnDeleted_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Products
            {
                Product_Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value.ToString()),
                ProductName = textProductNameUpdate.Text,
                UnitePrice = Convert.ToDecimal(textUnitePriceUpdate.Text),
                StockAmount = Convert.ToInt32(textStockAmountUpdate.Text)
            
            });
            LoadProduct();
            TextClear();
            MessageBox.Show("Product Deleted!");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Products
            {         
                ProductName = textProductName.Text,
                UnitePrice = Convert.ToDecimal(textUnitePrice.Text),
                StockAmount = Convert.ToInt32(textStockAmount.Text),
            });
            LoadProduct();
            TextClear();
            MessageBox.Show("Product Added!");
        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Products
            {
                Product_Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                ProductName = textProductNameUpdate.Text,
                UnitePrice = Convert.ToDecimal(textUnitePriceUpdate.Text),
                StockAmount = Convert.ToInt32(textStockAmountUpdate.Text),
            });
            LoadProduct();
            TextClear();
            MessageBox.Show("Product Updated!");
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textProductNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            textUnitePriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            textStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }

        

        private void textSearchProduct_TextChanged(object sender, EventArgs e)
        {
            dgwProducts.DataSource = _productDal.SearchProducts(textSearchProduct.Text);
          
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
           

        }

        private void btnMinMax_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textMaxPrice.Text) && string.IsNullOrEmpty(textMinPrice.Text))
            {
                LoadProduct();
            }
            else
            {
                var result = _productDal.SearchUnitePrice(Convert.ToDecimal(textMinPrice.Text), Convert.ToDecimal(textMaxPrice.Text));
                dgwProducts.DataSource = result;
            }
            textMinPrice.Clear();
            textMaxPrice.Clear();
        }
    }
}
