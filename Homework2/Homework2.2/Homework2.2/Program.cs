using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static int maxNum(int[] a,int count)
        {
            int max = int.MinValue;
            foreach(int num in a)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }

        static int minNum(int[]a,int count)
        {
            int min = int.MaxValue;
            foreach (int num in a)
            {
                if (num <min)
                {
                    min = num;
                }
            }
            return min;
        }
        static int arraySum(int[]a,int count)
        {
            int sum = 0;
            foreach (int num in a)
            {
                sum += num;
            }
            return sum;
        }

        static double arrayAvg(int []a,int count)
        {
            return arraySum(a, count) / count;
        }
        static void Main(string[] args)
        {
            int[] a = new int[100];
            for(int i = 0; i < 100; i++)
            {
                a[i] = i;
            }//初始化数组，以1-100的数组为例
            Console.WriteLine($"The max value of the array is:{ maxNum(a,100)}");
            Console.WriteLine($"The min value of the array is:{ minNum(a, 100)}");
            Console.WriteLine($"The average value of the array is:{ arrayAvg(a, 100)}");
            Console.WriteLine($"The sum of the array is:{ arraySum(a, 100)}");
        }
    }
}
