using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2._1
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
        private static void primeFactor(int x,ref int[] a,ref int count)
        {
            if (x == 0)
            {
                return;
            }
            if (x%2 == 0){
                a[count] = 2;
                count++;
                primeFactor(x / 2,ref a, ref count);
                return;
            }
            for(int i = 3; i <= x; i += 2)
            {
                if (x % i == 0)
                {
                    a[count] = i;
                    count++;
                    primeFactor(x /i,ref a, ref count);
                    return;
                }
                
            }
            return;
            
        }
        static void Main(string[] args)
        {
            Console.Write("Inuput an integer:");
            string s = "";
            s = Console.ReadLine();
            int x;
            int[] a=new int[1000];
            int count = 0;
            if (isNum(s))
            {
                x = int.Parse(s);
                primeFactor(x, ref a, ref count);
                Console.Write($"{x}=");
                for(int i = 0; i < count-1; i++)
                {
                    Console.Write($"{a[i]}*");
                }
                Console.WriteLine(a[count - 1]);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
