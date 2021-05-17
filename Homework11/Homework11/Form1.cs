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
    public partial class Form1 : Form
    {
/*        public OrderService orderService;*/
        public Form1()
        {
            InitializeComponent();
            /*orderService = new OrderService();
            orderService.Import("C:/Users/abchris/source/repos/Homework11/Homework11/bin/Debug/OrderList.xml");
            bindingSourceOrders.DataSource = orderService.orderList;*/
            using(var db = new OrderContext())
            {
                bindingSourceOrders.DataSource = db.Orders.Where(o => o.OrderId != 0).ToList();
                var orderDetails = db.OrderDetails.Where(od => od.OrderId == 1).ToList();
                orderDetailsBindingSource.DataSource = orderDetails;

            }
            
        }


        private void button_Query_Click(object sender, EventArgs e)
        {
            using (var db = new OrderContext())
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        var all = db.Orders.Where(o=>o.OrderId!=0).ToList();
                        bindingSourceOrders.DataSource = all;
                        int id0 = all[0].OrderId;
                        orderDetailsBindingSource.DataSource = db.OrderDetails.Where(od => od.OrderId == id0).ToList();
                        dataGridView1.Rows[0].Selected=true;
                        break;
                    case 1:
                        int id1 = int.Parse(textBox1.Text);
                        var byId = db.Orders.FirstOrDefault(o => o.OrderId == id1);
                        bindingSourceOrders.DataSource = byId;
                        orderDetailsBindingSource.DataSource = db.OrderDetails.Where(od=>od.OrderId==id1).ToList();
                        dataGridView1.Rows[0].Selected = true;
                        break;
                    case 2:
                        string name = textBox1.Text;
                        var byCustomer = db.Orders.Where(o => o.customer == name).ToList();
                        bindingSourceOrders.DataSource = byCustomer;
                        int id2 = byCustomer[0].OrderId;
                        orderDetailsBindingSource.DataSource = db.OrderDetails.Where(od => od.OrderId == id2).ToList();
                        dataGridView1.Rows[0].Selected = true;
                        break;
                }
                textBox1.Text = "";
            }
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            FormDelete formDelete = new FormDelete(this);
            formDelete.ShowDialog();
            using(var db = new OrderContext())
            {
                bindingSourceOrders.DataSource = db.Orders.Where(o => o.OrderId != 0).ToList();
            }
            
        }

        private void button_Import_Click(object sender, EventArgs e)
        {
            /*orderService.Import("C:/Users/abchris/source/repos/Homework5/Homework5/bin/Debug/OrderList.xml");
            bindingSourceOrders.DataSource = orderService.QueryAll();*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
/*            this.orderService.Export("OrderList.xml");*/
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd(this);
            formAdd.ShowDialog();
            using(var db=new OrderContext())
            {
                bindingSourceOrders.DataSource = db.Orders.Where(o => o.OrderId != 0).ToList();
            }
            
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            FormUpdate formUpdate = new FormUpdate(this);
            formUpdate.ShowDialog();
            using(var db=new OrderContext())
            {
                bindingSourceOrders.DataSource = db.Orders.Where(o => o.OrderId != 0).ToList();
                orderDetailsBindingSource.DataSource = null;
            }
            
        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            using (var db= new OrderContext())
            {
                orderDetailsBindingSource.DataSource = db.OrderDetails.Where(od => od.OrderId == id).ToList();
            }
        }
            
        
    }
}
