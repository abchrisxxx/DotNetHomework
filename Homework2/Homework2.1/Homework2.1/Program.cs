﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeFactor
{
    class Program
    {
        //用来判断输入的字符串是不是一个数字
        private static bool IsNum(string s)
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

        //x是待分解数字，a[]用来保存其质因数，count统计质因数的数量
        private static void primeFactor(int x,int[] a,ref int count)
        {
            //递归结束条件
            if (x == 1)
            {
                return;
            }
            
            //寻找质因数并添加
            for(int i = 2; i <= x; i ++)
            {
                if (x % i == 0)
                {
                    a[count] = i;
                    count++;
                    primeFactor(x /i,a,ref  count);//递归调用
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
            int[] a=new int[31];//32位整型数的质因数不超过31个，Max=2^31-1
            int count = 0;
            if (IsNum(s))
            {
                x = int.Parse(s);
                primeFactor(x,  a,ref  count);
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
