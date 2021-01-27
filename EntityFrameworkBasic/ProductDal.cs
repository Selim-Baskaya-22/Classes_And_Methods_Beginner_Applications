using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkBasic
{
    class ProductDal:IProductDal
    {
        public List<Products> GetProducts()
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Product.ToList();
            }
        }

        public List<Products> SearchProducts(string key)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Product.Where(p=>p.ProductName.Contains(key)).ToList();
            }
        }
        public void Add(Products products)
        {
            using (ETradeContext context=new ETradeContext())
            {
                var entity = context.Entry(products); 
                    entity.State=EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Update(Products products)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(products);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

     
        public void Delete(Products products)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(products);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        List<Products> listelemele()
        {
            using (ETradeContext context=new ETradeContext())
            {
               return context.Product.ToList();         
            }
        }


        public List<Products> SearchUnitePrice(decimal min, decimal max)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Product.Where(p => p.UnitePrice >= min && p.UnitePrice <= max).ToList();
            }
        }
    }
}
