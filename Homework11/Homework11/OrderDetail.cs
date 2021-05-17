using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace Homework11
{
    public class OrderDetail
    {
        public OrderDetail() { }
        public Product product { get; set; }
        public int quantity { get; set; }
        public int OrderDetailId { set; get; }
        public string productName { get => this.product.Name; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }
        public int OrderId { get; set; }
        public int productPrice { get => this.product.Price; }
        public int cost { get => this.quantity * this.productPrice; }

        public OrderDetail(Product product,int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }

        public override int GetHashCode()
        {
            return 20011015 + EqualityComparer<Product>.Default.GetHashCode(product);
        }

        public override bool Equals(object obj)
        {
            OrderDetail orderDetail = obj as OrderDetail;
            return orderDetail != null && EqualityComparer<Product>.Default.Equals(this.product, orderDetail.product);
        }

        public override string ToString()
        {
            return $"OrderDetail:{product}, Quantity:{quantity}, Cost:{cost}";
        }
    }
}
