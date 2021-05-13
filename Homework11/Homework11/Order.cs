using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;

namespace Homework11
{
    class Order
    {
        [Key,Column(Order =1)]
        public int orderID { get; set; }
        public int orderCost { get; set; }
        public string customerName { get; set; }
        public string productName { get; set; }
        
        /*public Order(int orderID, string productNames
            , string consumerName, double orderCost)
        {
            this.orderID = orderID;
            this.orderDetails = new OrderDetails(productNames
            , consumerName, orderCost);
        }
        public Order(int orderID, OrderDetails orderDetails)
        {
            this.orderID = orderID;
            this.orderDetails = orderDetails;
        }
        //重写Equals()
        public override bool Equals(object obj)
        {
            return obj != null && obj is Order o &&
                o.orderID == this.orderID &&
                o.orderDetails.Equals(this.orderDetails);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }*/
        //重写ToString()
        public override string ToString()
        {
            return $"Order ID:{this.orderID} Order Cost:{this.orderCost} Customer Name:{this.customerName} Product Name:{this.productName}";
        }
    }
}
