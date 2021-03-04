using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2._3
{
    class Program
    {
        static int[] fun()
        {
            int[] a = new int[100];
            for(int i = 0; i < 100; i++)
            {
                a[i] = 1;
            }
            for(int i = 2; i <= 10; i++)
            {
                for(int j = 2; j <= 100; j++)
                {
                    if (j % i == 0)
                    {
                        a[j - 1] = 0;
                    }
                }
            }
            return a;
        }
        static void Main(string[] args)
        {
            int[]a=fun();
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i]==1)
                {
                    Console.Write($"{i + 1} ");
                }
            }
        }
    }
}
