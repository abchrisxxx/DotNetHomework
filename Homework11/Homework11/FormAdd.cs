using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework11
{
    public partial class FormAdd : Form
    {
        Form1 form1;
        public FormAdd(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        private void button_newOrder_Click(object sender, EventArgs e)
        {
            using (var db = new OrderContext())
            {
                Product Apple = new Product("Apple", 6);
                Product Book = new Product("Book", 5);
                Product Coke = new Product("Coke", 3);
                Product Milk = new Product("Milk", 4);
                Product Bread = new Product("Bread", 5);
                int orderId;
                if (!int.TryParse(textBox_orderId.Text, out orderId))
                {
                    return;
                }
                foreach(Order o in db.Orders)
                {
                    if (o.OrderId == orderId)
                    {
                        return;
                    }
                }
                string customer = textBox_customer.Text;
                Order newOrder = new Order(orderId, customer);
                int amount;
                if (checkBox_Apple.Checked)
                {
                    if (!int.TryParse(textBox_Apple.Text, out amount))
                    {
                        return;
                    }
                    OrderDetail orderDetail = new OrderDetail(Apple, amount);
                    newOrder.AddOrderDetail(orderDetail);
                }
                if (checkBox_Book.Checked)
                {
                    if (!int.TryParse(textBox_Book.Text, out amount))
                    {
                        return;
                    }
                    OrderDetail orderDetail = new OrderDetail(Book, amount);
                    newOrder.AddOrderDetail(orderDetail);
                }
                if (checkBox_Coke.Checked)
                {
                    if (!int.TryParse(textBox_Coke.Text, out amount))
                    {
                        return;
                    }
                    OrderDetail orderDetail = new OrderDetail(Coke, amount);
                    newOrder.AddOrderDetail(orderDetail);
                }
                if (checkBox_Milk.Checked)
                {
                    if (!int.TryParse(textBox_Milk.Text, out amount))
                    {
                        return;
                    }
                    OrderDetail orderDetail = new OrderDetail(Milk, amount);
                    newOrder.AddOrderDetail(orderDetail);
                }
                if (checkBox_Bread.Checked)
                {
                    if (!int.TryParse(textBox_Bread.Text, out amount))
                    {
                        return;
                    }
                    OrderDetail orderDetail = new OrderDetail(Bread, amount);
                    newOrder.AddOrderDetail(orderDetail);
                }
         
                db.Orders.Add(newOrder);
                db.SaveChanges();
/*                this.form1.orderService.AddOrder(newOrder);*/
                
            }
            this.Close();
        }
    }
}
