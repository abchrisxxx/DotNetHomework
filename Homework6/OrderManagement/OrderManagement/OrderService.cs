using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
namespace OrderManagement
    
{   
   
    public class OrderNotExistException : Exception
    {
        private int code;
        public int Code { get => code; }
        public OrderNotExistException(String msg,int code):base(msg)
        {
            this.code = code;
        }
    }
    public class OrderService
    {
        //订单表
        public List<Order> orders=new List<Order>();
        //按ID查询
        public List<Order> QueryByID(int orderID)
        {
            var o=from order in this.orders
                  where order.orderID == orderID
                  orderby order.orderDetails.orderCost
                  select order;
            return o.ToList();
        }
        //按顾客姓名查询，并且金额递增排序
        public List<Order> QueryByCustomerName(string customerName)
        {
            var o = from order in this.orders
                    where order.orderDetails.customerName == customerName
                    orderby order.orderDetails.orderCost
                    select order;
            return o.ToList();
        }
        //添加订单
        public bool AddOrder(Order o)
        {
            if (o == null)
            {
                throw new ArgumentException();
            }
            if (QueryByID(o.orderID).Count() != 0)
            {
                return false;
            }
            orders.Add(o);
            return true;
        }
        //删除订单
        public bool DeleteOrder(int orderID)
        {
            List<Order> o = QueryByID(orderID);
            if (o.Count == 0)
            {
                throw new OrderNotExistException("No such order", 3);
            }
            else
            {
                foreach( Order order in o){
                    orders.Remove(order);
                }
            }
            return true;
        }
        //修改订单
        public void ModifyOrder(int orderID,string productName,string costumerName,double cost)
        {
            List<Order> o = QueryByID(orderID);
            if (o.Count==0)
            {
                throw new OrderNotExistException("No such order", 3);
            }
            else
            {
                orders.Remove(o[0]);
                this.AddOrder(new Order(orderID, productName, costumerName, cost));
            }
        }
        //对订单按订单号排序
        public void SortOrdersByOrderID()
        {
            var temp = from o in this.orders
                          orderby o.orderID
                          select o;
            this.orders = temp.ToList();
        }

        public void Export(string filePath)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Order[]));
            using(FileStream fs =new FileStream(filePath, FileMode.Create))
            {
                xmlSerializer.Serialize(fs, this.orders.ToArray());
            }
        }
        public void Import(string filePath)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Order[]));
            using(FileStream fs=new FileStream(filePath, FileMode.Open))
            {
                this.orders = new List<Order>((Order[])xmlSerializer.Deserialize(fs));
            }
        }
    }
}
