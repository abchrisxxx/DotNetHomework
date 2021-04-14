using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Graphics graphics;

        private void Draw_button_Click(object sender, EventArgs e)
        {
            if (Length.Text == string.Empty || Depth.Text == string.Empty || BLRLeft.Text == string.Empty || BLRRight.Text == string.Empty
                || AngleLeft.Text == string.Empty || AngleRight.Text == string.Empty || Colors.Text == string.Empty) {
                Label.Text = "Please fill all blanks.";
                return;
            }
            int depth;
            if(!int.TryParse(Depth.Text,out depth))
            {
                Label.Text = "Invalid input.";
            }
            double length;
            if(!double.TryParse(Length.Text,out length))
            {
                Label.Text = "Invalid input";
            }
            if (graphics != null)
            {
                graphics.Clear(Color.BackColor);
            }
            graphics = Panel.CreateGraphics();
            
            drawCayleyTree(depth, 750, 600, length, -90);
        }
        void drawCayleyTree(int depth,double x0,double y0,double length,double angle)
        {
            if (depth == 0)
            {
                return;
            }
            double x1 = x0 + length * Math.Cos(angle*Math.PI/180);
            double y1 = y0 + length * Math.Sin(angle*Math.PI/180);

            drawLine(x0, y0, x1, y1);
            double blrleft,blrright,angleleft,angleright;
            if (!double.TryParse(BLRLeft.Text, out blrleft)) {
                Label.Text = "Invalid input.";
            }
            if(!double.TryParse(BLRRight.Text,out blrright))
            {
                Label.Text = "Invalid input.";
            }
            if(!double.TryParse(AngleLeft.Text,out angleleft))
            {
                Label.Text = "Invalid input.";
            }
            if(!double.TryParse(AngleRight.Text,out angleright))
            {
                Label.Text = "Invalid input";
            }
            Label.Text = "";
            drawCayleyTree(depth - 1,x1, y1, blrleft*length, angle + angleleft);
            drawCayleyTree(depth - 1, x1, y1, blrright*length, angle - angleright);

        }
        void drawLine(double x0,double y0,double x1,double y1)
        {
            switch (Colors.Text)
            {
                case "Red":
                    graphics.DrawLine(Pens.Red,(int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "Green":
                    graphics.DrawLine(Pens.Green, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "Blue":
                    graphics.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
            }
        }

  
    }
}
