using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkBasic
{
    interface IProductDal
    {
        List<Products>  GetProducts();
        List<Products> SearchProducts(string key);
        List<Products> SearchUnitePrice(decimal min,decimal max);
        void Add(Products product);
        void Update(Products product);
        void Delete(Products product);
        
    }
}
