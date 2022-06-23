using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_5_Group_3
{
    class ProductList
    {
        private static List<Product> products = new List<Product>();
        public void ProductFactory(string name ,string price , string descripton , string imagePath)
        {
            Product product = new Product(name,price,descripton,imagePath);
            products.Add(product);
        }
        public List<Product> getList()
        {
            return products;
        }
    }
}
