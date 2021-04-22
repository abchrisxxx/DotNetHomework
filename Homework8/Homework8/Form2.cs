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
    public partial class Form2 : Form
    {
        Form1 f1;
        OrderService os;
        public Form2(OrderService os,Form1 f1)
        {
            this.f1 = f1;
            this.os = os;
            InitializeComponent();
        }

        private void button_AddOrder_Click(object sender, EventArgs e)
        {
            int oid;
            double ocost;
            if (int.TryParse(textBox_OrderID.Text, out oid) && double.TryParse(textBox_TotalCost.Text, out ocost) &&
                !String.IsNullOrEmpty(textBox_ProductName.Text) && !String.IsNullOrEmpty(textBox_CustomerName.Text)) {
                f1.os.AddOrder(new Order(oid, textBox_ProductName.Text, textBox_CustomerName.Text, ocost));
               
            }
            else
            {
                label_msg.Text = "无效参数";
            }
            f1.os = this.os;
            this.Close();
        }
    }
}
