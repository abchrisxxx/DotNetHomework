using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    class Order
    {
        public OrderDetails orderDetails { get; set; }
        public int orderID { get; set; }
        public Order(int orderID, string productNames
            , string consumerName, double orderCost)
        {
            this.orderID = orderID;
            this.orderDetails = new OrderDetails(productNames
            , consumerName, orderCost);
        }
        public Order(int orderID,OrderDetails orderDetails)
        {
            this.orderID = orderID;
            this.orderDetails = orderDetails;
        }
        //重写Equals()
        public override bool Equals(object obj)
        {
            return obj != null&& obj is Order o &&
                o.orderID == this.orderID &&
                o.orderDetails.Equals(this.orderDetails);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        //重写ToString()
        public override string ToString()
        {
            return $"Order ID:{this.orderID} " + this.orderDetails.ToString();
        }
    }
}
