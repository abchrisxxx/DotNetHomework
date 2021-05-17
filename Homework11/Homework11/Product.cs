using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    public class Product
    {
        public Product() { }
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(string productName,int productPrice)
        {
            this.Name = productName;
            this.Price = productPrice;
        }
        public override int GetHashCode()
        {
            return 20010913 + Name.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Product product = obj as Product;
            return product != null && product.Name == this.Name;
        }
        public override string ToString()
        {
            return $"Product Name:{Name}  Product Price:{Price}";
        }
    }
}
