using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeNumber
{
    class Program
    {
        static int[] fun()
        {
            int[] a = new int[100];
            for(int i = 0; i < 100; i++)
            {
                a[i] = 1;
            }//初始化数组，a[i]=0表示i+1被筛掉了
            a[0] = 0;//筛掉1
            for(int i = 2; i <= 10; i++)
            {
                for(int j = 2; j <= 100; j++)
                {
                    if (j % i == 0&&j!=i)
                    {
                        a[j - 1] = 0;//埃氏筛法
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
                if (a[i]==1)//a[i]=1则i+1是质数
                {
                    Console.Write($"{i + 1} ");
                }
            }
        }
    }
}
