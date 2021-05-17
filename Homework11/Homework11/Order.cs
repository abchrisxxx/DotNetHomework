using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    public class Order
    {
        public Order() { }
        [Key,Column(Order =1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderId { get; set; }
        [Required]
        public string customer { get; set; }
        public List<OrderDetail> orderDetails { get; set; }

        public int total {
            get;set;
        }

        public Order(int orderId,string customer)
        {
            this.OrderId = orderId;
            this.customer = customer;
            this.orderDetails = new List<OrderDetail>();
            this.total = 0;
        }

        public void AddOrderDetail(OrderDetail orderDetail)
        {
            this.orderDetails.Add(orderDetail);
            this.total += orderDetail.cost;
        }
        public void RemoveOrderDetail(OrderDetail orderDetail)
        {
            this.orderDetails.Remove(orderDetail);
        }
        public override int GetHashCode()
        {
            return 20180407 + OrderId.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Order order = obj as Order;
            return order != null && this.OrderId == order.OrderId;
        }

        public override string ToString()
        {
            string order = $"Order ID:{OrderId} Customer:{customer}\n";
            foreach(OrderDetail orderDetail in this.orderDetails)
            {
                order += (orderDetail.ToString() + "\n");
            }
            return order;
        }
    }
}
