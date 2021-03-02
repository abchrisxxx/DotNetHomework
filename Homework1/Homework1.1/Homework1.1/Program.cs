using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1._1
{
    class Program
    {
        private static bool isNum(string s)
        {
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
        static void Main(string[] args)
        {
            string s = "";
            double x = 0;
            double y = 0;
            bool exit = false;
            while (!exit)
            {
                Console.Write("Please input a number x:");
                s = Console.ReadLine();
                while (!isNum(s))
                {
                    Console.WriteLine("Invalid input!Try again.");
                    s = Console.ReadLine();
                }
                x = Double.Parse(s);
                Console.Write("Please input a number y:");
                s = Console.ReadLine();
                while (!isNum(s))
                {
                    Console.WriteLine("Invalid input!Try again.");
                    s = Console.ReadLine();
                }
                y = Double.Parse(s);
                Console.Write("Please input an operator(+ - * /):");
                bool flag = true;
                while (flag)
                {
                    s = Console.ReadLine();
                    flag = false;
                    switch (s)
                    {
                        case "+":
                            Console.WriteLine($"x + y = {x + y}");
                            break;
                        case "-":
                            Console.WriteLine($"x - y = {x - y}");
                            break;
                        case "*":
                            Console.WriteLine($"x * y = {x * y}");
                            break;
                        case "/":
                            if (y == 0)
                            {
                                Console.WriteLine("A number can not be divided by 0!");
                            }
                            else
                                Console.WriteLine($"x / y = {x / y}");
                            break;
                        default:
                            Console.WriteLine("Invalid input!Try again!");
                            flag = true;
                            break;

                    }
                }
                Console.WriteLine("To end the program, input 0. Otherwise, the program will continue.");
                s = Console.ReadLine();
                if (s != "" && isNum(s))
                {
                    if (int.Parse(s) == 0)
                    {
                        exit = true;
                    }
                }

            }

        }
    }
}
