using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManagement;

namespace Homework8
{
    public partial class Form1 : Form
    {
        public OrderService os = new OrderService();
        public Form1()
        {
            InitializeComponent();
            bindingSourceOrder.DataSource = os.orders.ToArray();
            
        }

        


        private void button_AddOrder_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2(this.os, this);
            f2.ShowDialog();

            bindingSourceOrder.DataSource = os.orders.ToArray();
        }

        private void button_QueryByID_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(textBox_QueryByID.Text, out id))
            {
                bindingSourceOrder.DataSource = os.orders.Where(o => o.OrderID == id);
                this.textBox_QueryByID.Text = "";
            }
        }

        private void button_QueryByName_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_QueryByName.Text)) {
                bindingSourceOrder.DataSource = os.orders.Where(o => o.CustomerName == textBox_QueryByName.Text);
                this.textBox_QueryByName.Text = "";
            }
        }

        private void button_DeleteOrder_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(textBox_DeleteOrder.Text, out id)) {
                os.DeleteOrder(id);
                bindingSourceOrder.DataSource = os.orders.ToArray();
                this.textBox_DeleteOrder.Text = "";
            }
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            bindingSourceOrder.DataSource = os.orders.ToArray();
        }

        private void button_Import_Click(object sender, EventArgs e)
        {
            os.Import("orders.xml");
            bindingSourceOrder.DataSource = os.orders.ToArray();
        }

        private void button_Export_Click(object sender, EventArgs e)
        {
            os.Export("orders.xml");
        }
    }
}
