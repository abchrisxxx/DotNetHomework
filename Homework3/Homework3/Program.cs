using System;
using System.Threading;

namespace Homework3
{
    public abstract class Shape//抽象基类Shape
    {   //成员变量
        protected double width;
        protected double height;
        
        public Shape() { }
        public Shape(double width,double height)
        {
            this.height = height;
            this.width = width;
        }
        //属性
        virtual public double Height { get { return this.height; } set { this.height = value; } }
        virtual public double Width { get { return this.width; } set { this.width = value; } }
        virtual public double Area { get; }
        //判断形状是否合法
        public bool IsLegal()
        {
            if (this.width > 0 && this.height > 0)
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
        //单一参数构造函数调用父类构造函数完成子类对象创建
        public Square(double width) : base(width, width) {}
        //两个参数的构造函数判断是否符合正方形定义后创建
        public Square(double width,double height)
        {
            if (width != height) { throw(new ArgumentException()); }
            this.height = height;
            this.width = width;
        }
        //重写属性，与父类的不同在于更改Height或Width时需要同时更新两者，以及计算正方形的面积
        override public double Height { get { return this.height; } set { this.width = value;this.height = value;} }
        override public double Width { get { return this.width; } set { this.width = value; this.height = value;} }
        override public double Area { get { return this.width * this.height; } }
        //判断形状是否合法，在父类同名函数的基础上需要判断宽、高是否相等
        public new bool IsLegal()
        {
            if (base.IsLegal())
            {
                if (this.width == this.height)
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
        public Rectangle(double width,double height) : base(width, height){ }
        override public double Area { get { return this.width * this.height; } }
    }

    class Triangle : Shape
    {
        public Triangle() { }
        public Triangle(double width, double height) : base(width, height){}
        //三角形的面积计算与前两者不同
        override public double Area { get { return this.width * this.height*0.5; } }

    }

    public class Factory
    {
        //简单工厂方法
        public static Shape Manufacture(String Type,double width,double height)
        {
            switch (Type)
            {
                case "Triangle":
                    Triangle a = new Triangle(width, height);
                    if(!a.IsLegal()) { throw (new ArgumentException()); }
                    
                    return a;
                case "Rectangle":
                    Rectangle b = new Rectangle(width, height);
                    if (!b.IsLegal()) { throw (new ArgumentException()); }
                    return b;
                case "Square":
                    Square c = new Square(width, height);
                    if (!c.IsLegal()) { throw (new ArgumentException()); }
                    return c;
                default:
                    Console.WriteLine($"类型错误，生产失败");
                    throw (new ArgumentException());
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //定义了可能出现的形状类型
            String[] s = { "Triangle", "Square", "Rectangle" };
            
            //作为简单工厂方法的参数
            int type;
            double width;
            double height;
            //记录面积之和
            double areaSum = 0;
            //循环创建10个形状并且计算其面积之和
            for(int i = 0; i < 10; i++)
            {
                //生成随机数
                Random ran = new Random();
                //调用Sleep()方法避免随机数重复
                Thread.Sleep(1);
                //对对应参数赋值
                type = ran.Next(3);
                width = Math.Round(10*ran.NextDouble(),3);
                height = Math.Round(10 * ran.NextDouble(),3);
                switch (type)
                {
                    case 0:
                        Triangle t = (Triangle)Factory.Manufacture(s[type], width, height);
                        Console.WriteLine($"生产了一个三角形，底边为{t.Width},高为{t.Height},面积为{Math.Round(t.Area, 3)}");
                        areaSum += Math.Round(t.Area, 3);
                        break;
                    case 1:
                        Square sq = (Square)Factory.Manufacture(s[type], width, width);
                        Console.WriteLine($"生产了一个正方形，底边为{sq.Width},高为{sq.Height},面积为{Math.Round(sq.Area, 3)}");
                        areaSum += Math.Round(sq.Area, 3);
                        break;
                    case 2:
                        Rectangle r = (Rectangle)Factory.Manufacture(s[type], width, height);
                        Console.WriteLine($"生产了一个长方形，底边为{r.Width},高为{r.Height},面积为{Math.Round(r.Area, 3)}");
                        areaSum += Math.Round(r.Area, 3);
                        break;
                    default:
                        Console.WriteLine($"生产失败！");
                        break;
                }
                
            }
            Console.WriteLine($"十个图形的面积之和为{areaSum}");
        }
    }
}
