using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    class Program
    {
        static void addOrder(Order o)
        {
            using (var context = new OrderDB())
            {
                context.orders.Add(o);
                context.SaveChanges();
            }
        }

        static void deleteOrder(int orderId)
        {
            using (var context = new OrderDB())
            {
                var order = context.orders.FirstOrDefault(p => p.orderID == orderId);
                if (order != null)
                {
                    context.orders.Remove(order);
                    context.SaveChanges();
                }
            }

        }

        static void changeOrder(int orderId, int orderCost,string productName,string customerName)
        {
            using (var context = new OrderDB())
            {
                var order = context.orders.FirstOrDefault(p => p.orderID == orderId);
                if (order != null)
                {
                    order.customerName = customerName;
                    order.productName = productName;
                    order.orderCost =orderCost;
                    context.SaveChanges();
                }
            }
        }

        static void queryById(int orderId)
        {
            using (var context = new OrderDB())
            {
                var order = context.orders
                    .SingleOrDefault(b => b.orderID == orderId);
                if (order != null) Console.WriteLine(order);
            }
        }

        static void queryByName(string name)
        {
            using (var context = new OrderDB())
            {
                var order = context.orders.Where(p => p.customerName == name);
                if (order != null)
                {
                    foreach(Order o in order)
                    {
                        Console.WriteLine(o);
                    }
                }
            }

        }
        static void Main(string[] args)
        {
            addOrder(new Order { customerName = "Chris", orderCost = 13000, productName = "Laptop" });
            addOrder(new Order { customerName = "Chris", orderCost = 30, productName = "Book" });
            addOrder(new Order { customerName = "Sammy", orderCost = 50, productName = "Fruit" });

            queryById(1);

            queryByName("Chris");

            changeOrder(1,  3, "Water", "Chris");

            deleteOrder(2);
        }
    }
}
