using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService os = new OrderService();
            //新建订单
            Order o1 = new Order(1, new OrderDetails("Coke", "Alan", 3));
            Order o2 = new Order(1, new OrderDetails("Coke", "Alan", 3));
            Order o3 = new Order(2, "Milk", "Betty", 20);
            Order o4 = new Order(3, "Fruit", "Chris", 30);
            Order o5 = new Order(4, "Beef", "Chris", 10);
            //添加订单
            Console.WriteLine("o1添加成功：" + os.AddOrder(o1));
            Console.WriteLine("o2添加成功：" + os.AddOrder(o2));//重复，返回false
            Console.WriteLine("o4添加成功：" + os.AddOrder(o4));
            Console.WriteLine("o3添加成功：" + os.AddOrder(o3));
            Console.WriteLine("o5添加成功：" + os.AddOrder(o5));
            Console.WriteLine("\n\n原始订单");
            //打印当前所有订单，未排序
            foreach (Order o in os.orders)
            {
                //重写了ToString方法
                Console.WriteLine(o);
            }
            //按订单号对订单排序
            os.SortOrdersByOrderID();
            Console.WriteLine("\n\n按订单号排序后");
            //打印当前所有订单，已按订单号排序
            foreach (Order o in os.orders)
            {
                Console.WriteLine(o);
            }
            
            //删除订单
            Console.WriteLine("\n\no3删除成功：" + os.DeleteOrder(o3.orderID));
            Console.WriteLine("删除o3后");
            //打印当前所有订单，订单号2的订单已删除
            foreach (Order o in os.orders)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("\n\n修改o1后");
            //修改订单，将o1的cost改为100，productName改为wine
            os.ModifyOrder(o1.orderID, "Wine", o1.orderDetails.customerName, 100);
            //打印所有订单，此时o1的cost已经变为100,productName已经变为Wine
            foreach (Order o in os.orders)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("\n\n按姓名查找,且按金额递增排序");
            //按照顾客姓名查找，也可以按照订单号查找，并且返回按照订单金额排序的结果
            var ordersByChris = os.QueryByCustomerName("Chris");
            //打印查找结果
            foreach (Order o in ordersByChris)
            {
                Console.WriteLine(o);
            }
        }
    }
}
