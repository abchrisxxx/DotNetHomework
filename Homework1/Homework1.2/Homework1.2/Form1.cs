using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static bool isNum(string s)
        {
            if (s == "")
            {
                return false;
            }
            byte temp;
            for (int i = 0; i < s.Length; i++)
            {
                temp = Convert.ToByte(s[i]);
                if (temp < 48 || temp > 57)
                {
                    return false;
                }
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (isNum(textBox1.Text) && isNum(textBox2.Text) && comboBox1.Text != null)
            {
                if (comboBox1.Text == "/" && Double.Parse(textBox2.Text) == 0)
                {
                    label1.Text = "Invalid input!A number cannot be divided by 0!";
                }
                else
                {
                    double x = Double.Parse(textBox1.Text);
                    double y = Double.Parse(textBox2.Text);
                    string s = comboBox1.Text;
                    switch (s)
                    {
                        case "+":
                            label1.Text=($"{x} + {y} = {x + y}");
                            break;
                        case "-":
                            label1.Text = ($"{x} - {y} = {x - y}");
                            break;
                        case "*":
                            label1.Text = ($"{x} * {y} = {x * y}");
                            break;
                        case "/":
                            label1.Text = ($"{x} / {y} = {x / y}");
                            break;
                    }
                }
            }
            else
            {
                label1.Text = "Invalid input!Check your input and try again.";
            }
            
        }
    }
}
