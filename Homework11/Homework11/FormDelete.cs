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
    public partial class FormDelete : Form
    {
        Form1 form1;
        public FormDelete(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }
        public void Delete(int orderId)
        {
            using(var db = new OrderContext())
            {
                var Order = db.Orders.Include("OrderDetails").FirstOrDefault(o => o.OrderId == orderId);
                if (Order != null)
                {
                    db.Orders.Remove(Order);
                    db.SaveChanges();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*this.form1.orderService.RemoveOrder(int.Parse(textBox1.Text));*/
            Delete(int.Parse(textBox1.Text));
            this.Close();
        }
    }
}
