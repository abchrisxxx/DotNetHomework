/*using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Homework11
{
    public class OrderService
    {
        public List<Order> orderList { get; set; } = new List<Order>();

        public void AddOrder(Order order)
        {
            foreach(Order o in orderList)
            {
                if (o.OrderId == order.OrderId)
                {
                    return;
                }
            }
            this.orderList.Add(order);
        }

        public void RemoveOrder(int orderId)
        {
            Order orderToRemove = null;
            foreach (Order o in orderList)
            {
                if (o.OrderId == orderId)
                {
                    orderToRemove = o;
                }
            }
            if (orderToRemove != null)
            {
                orderList.Remove(orderToRemove);
            }
        }

        public Order QueryById(int orderId)
        {
            foreach (Order o in orderList)
            {
                if (o.OrderId == orderId)
                {
                    return o;
                }
            }
            return null;
        }

        public List<Order> QueryByCustomer(string customer)
        {
            List<Order> orders = new List<Order>();
            foreach (Order o in orderList)
            {
                if (o.customer == customer)
                {
                    orders.Add(o);
                }
            }
            return orders;
        }
        public List<Order> QueryAll()
        {
            List<Order> orders = new List<Order>();
            foreach(Order o in orderList)
            {
                orders.Add(o);
            }
            return orders;
        }

        public void Update(int orderId, int addOrRemove, OrderDetail orderDetail)
        {
            foreach (Order o in orderList)
            {
                if (o.OrderId == orderId)
                {
                    if (addOrRemove == 0)
                    {
                        foreach (OrderDetail od in o.orderDetails)
                        {
                            if (od.product.Equals(orderDetail.product))
                            {
                                od.quantity += orderDetail.quantity;
                                return;
                            }
                        }
                        o.AddOrderDetail(orderDetail);
                        return;
                    }
                    else
                    {
                        OrderDetail orderDetailToRemove = null;
                        foreach (OrderDetail od in o.orderDetails)
                        {
                            if (od.Equals(orderDetail))
                            {
                                orderDetailToRemove = od;
                            }
                        }
                        if (orderDetailToRemove != null)
                        {
                            if (orderDetailToRemove.quantity < orderDetail.quantity)
                            {
                                return;
                            }
                            OrderDetail newOrderDetail = new OrderDetail(orderDetailToRemove.product, orderDetailToRemove.quantity - orderDetail.quantity);
                            o.RemoveOrderDetail(orderDetailToRemove);
                            if(orderDetailToRemove.quantity - orderDetail.quantity > 0) {
                                o.AddOrderDetail(newOrderDetail);
                            }
                            
                        }
                        return;
                    }
                }
            }
            return;
        }

        public void Export(String fileName)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                xs.Serialize(fs, orderList);
            }
        }

        public void Import(string path)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                this.orderList=(List<Order>)xs.Deserialize(fs);
          
            }
        }
    }
}
*/