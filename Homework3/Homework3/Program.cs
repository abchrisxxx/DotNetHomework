using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    abstract class Shape
    {
        protected double length;
        protected double height;
        
        public Shape() { }
        public Shape(double length,double height)
        {
            this.height = height;
            this.length = length;
        }
        public double Height { get { return this.height; } set { this.height = value; } }
        public double Length { get { return this.length; } set { this.length = value; } }
        public bool IsLegal()
        {
            if (this.length > 0 && this.height > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Square : Shape
    {
        public Square() { }
        public Square(double length) : base(length, length) {}
        public new double Height { get { return this.height; } set { this.length = value;this.height = value;} }
        public new double Length { get { return this.length; } set { this.length = value; this.height = value;} }
        public double Area { get { return this.length * this.height; } }
        public new bool IsLegal()
        {
            if (base.IsLegal())
            {
                if (this.length == this.height)
                {
                    return true;
                }
            }
            return false;
        }
    }
    class Rectangle : Shape
    {
        public Rectangle() { }
        public Rectangle(double length,double height) : base(length, height){ }
        public double Area { get { return this.length * this.height; } }
    }

    class Triangle : Shape
    {
        public Triangle() { }
        public Triangle(double length, double height) : base(length, height){}
        public double Area { get { return this.length * this.height*0.5; } }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square(1.2);
            Console.WriteLine(s.Area);
            s.Length = 1.5;
            Console.WriteLine(s.Area);
            Square s1 = new Square();
            s1.Length = 1;
            Console.WriteLine(s1.Area);
            Console.WriteLine(s1.IsLegal());
            Triangle t = new Triangle(2, 3.6);
            Console.WriteLine(t.Area);
            t.Length = 1;
            Console.WriteLine(t.Area);

        }
    }
}
