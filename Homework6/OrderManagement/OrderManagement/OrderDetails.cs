using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{   [Serializable]
    public class OrderDetails
    {
        public OrderDetails() { }
        public string productName {
            get;
            set;
        }
        public string customerName {
            get;
            set;
        }
        public double orderCost {
            get;
            set;
        }
        public OrderDetails(string productName
            ,string customerName,double orderCost)
        {
            this.productName = productName;
            this.customerName = customerName;
            this.orderCost = orderCost;
        }
        //重写Equals()
        public override bool Equals(Object myobject)
        {
            return myobject!=null&&myobject is OrderDetails od && 
                this.customerName.Equals(od.customerName) && 
                this.productName.Equals(od.productName) && 
                this.orderCost == od.orderCost;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        //重写ToString()
        public override string ToString()
        {
            return $"Product name:{this.productName} Customer name:{this.customerName} Cost:{this.orderCost}";
        }
    }
}
