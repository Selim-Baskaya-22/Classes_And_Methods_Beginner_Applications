using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erişim_Bildirgeçleri_private_public_producted_internal_
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product = new Product {id=1,name="selim" };
           
            Product product2 = new Product(2,"Selim");


            Console.Read();
        }
    }
    class Customer
    {
        //private=sadece tanımlandığı sınıf içerisinde kullanılır.
        //protected=kalıtım aldığı sınıflarda kullanılabilir.
        //CLASSLAR ASLA PRİVATE VEYA PROTECTED OLAMAZ. YA PUBLİC YADA İNTERNAL OLUR
        //CLASSLARIN PRİVATE VEYA PROTECTED OLMASI İÇİN İÇ İÇE CLASS YAZMAMIZ GEREKİR
        //internal=classların oldupu assemblyde yani proje içerisinde istediğimiz yerde çağırabiliriz.
        //İNTERNAL ÖNEMLİ NOT: EĞER BİR CLASSTA ERİŞİM BELİRLEYİZİ YOKSA ONUN DEFAULT DEĞERİ İNTERNALDİR
        //public= TAM ANLAMIYLA PUBLİC KULLANMAMIZ İÇİN DİĞER BİR PROJEDEN REFERANS VERİP USİNG ALANINA 
        //PROJENİN İSMİ YAZILMALIDIR!!!
        protected int id { get; set; }
        private int gizliid { get; set; }
        public int MyProperty { get; set; }
        public void Save() 
        {
       
        }
    }
    class student:Customer
    {
        
        public void Save()
        {
            
        }
    }
    class basee
    {
        protected class a
        {
        }
    }
    class Product
    {
        int _id;
        string _name;
        public Product(int id,string name)
        {
            _id = id;
            _name = name;
        }
        public Product()
        {
          
        }
        public int id { get; set; }
        public string name { get; set; }
    }
}



