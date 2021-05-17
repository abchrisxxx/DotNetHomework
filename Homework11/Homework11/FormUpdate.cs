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
    public partial class FormUpdate : Form
    {
        Form1 form1;
        public FormUpdate(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        public void ModifyOrderDetail(int orderId,OrderDetail orderDetail,int addOrRemove)
        {
            using(var db=new OrderContext())
            {
                switch (addOrRemove)
                {
                    case 0:
                        var orderDetailToModify = db.OrderDetails.FirstOrDefault(od => od.product.Name == orderDetail.product.Name&&od.OrderId==orderId);
                        if (orderDetailToModify != null)
                        {
                            orderDetailToModify.quantity += orderDetail.quantity;
                            var orderToModify = db.Orders.FirstOrDefault(o => o.OrderId == orderId);
                            orderToModify.total += orderDetailToModify.productPrice * orderDetail.quantity;
                        }
                        else
                        {
                            orderDetail.OrderId = orderId;
                            db.OrderDetails.Add(orderDetail);
                            var orderToModify = db.Orders.FirstOrDefault(o => o.OrderId == orderId);
                            orderToModify.total += orderDetail.cost;
                            
                        }
                        db.SaveChanges();
                        break;
                    case 1:
                        var orderDetailToRemove = db.OrderDetails.FirstOrDefault(od => od.product.Name == orderDetail.product.Name&&od.OrderId==orderId);
                        if (orderDetailToRemove != null)
                        {
                            if (orderDetailToRemove.quantity - orderDetail.quantity > 0)
                            {
                                orderDetailToRemove.quantity -= orderDetail.quantity;
                                var orderToModify = db.Orders.FirstOrDefault(o => o.OrderId == orderId);
                                orderToModify.total -= orderDetail.productPrice * orderDetail.quantity;
                            }
                            else
                            {
                                db.OrderDetails.Remove(orderDetailToRemove);
                                var orderToModify = db.Orders.FirstOrDefault(o => o.OrderId == orderId);
                                orderToModify.total -= orderDetailToRemove.cost;
                            }
                            db.SaveChanges();
                        }
                        break;
                }
               
            }
        }


        private void button_Update_Click(object sender, EventArgs e)
        {
            Product Apple = new Product("Apple", 6);
            Product Book = new Product("Book", 5);
            Product Coke = new Product("Coke", 3);
            Product Milk = new Product("Milk", 4);
            Product Bread = new Product("Bread", 5);
            int orderId,amount;
            if(!int.TryParse(textBox_orderId.Text,out orderId))
            {
                return;
            }
            if (checkBox_Apple.Checked)
            {
                if (!int.TryParse(textBox_Apple.Text, out amount))
                {
                    return;
                }
                OrderDetail orderDetail = new OrderDetail(Apple, amount);
                ModifyOrderDetail(orderId, orderDetail,comboBox1.SelectedIndex);
            }
            if (checkBox_Book.Checked)
            {
                if (!int.TryParse(textBox_Book.Text, out amount))
                {
                    return;
                }
                OrderDetail orderDetail = new OrderDetail(Book, amount);
                ModifyOrderDetail(orderId, orderDetail, comboBox1.SelectedIndex);/*
                this.form1.orderService.Update(orderId, comboBox1.SelectedIndex, orderDetail);*/
            }
            if (checkBox_Coke.Checked)
            {
                if (!int.TryParse(textBox_Coke.Text, out amount))
                {
                    return;
                }
                OrderDetail orderDetail = new OrderDetail(Coke, amount);
                ModifyOrderDetail(orderId, orderDetail, comboBox1.SelectedIndex);
                /*                this.form1.orderService.Update(orderId, comboBox1.SelectedIndex, orderDetail);*/
            }
            if (checkBox_Milk.Checked)
            {
                if (!int.TryParse(textBox_Milk.Text, out amount))
                {
                    return;
                }
                OrderDetail orderDetail = new OrderDetail(Milk, amount);
                ModifyOrderDetail(orderId, orderDetail, comboBox1.SelectedIndex);
                /*                this.form1.orderService.Update(orderId, comboBox1.SelectedIndex, orderDetail);*/
            }
            if (checkBox_Bread.Checked)
            {
                if (!int.TryParse(textBox_Bread.Text, out amount))
                {
                    return;
                }
                OrderDetail orderDetail = new OrderDetail(Bread, amount);
                ModifyOrderDetail(orderId, orderDetail, comboBox1.SelectedIndex);
                /*                this.form1.orderService.Update(orderId, comboBox1.SelectedIndex, orderDetail);*/
            }
            this.Close();
        }

    }
}
