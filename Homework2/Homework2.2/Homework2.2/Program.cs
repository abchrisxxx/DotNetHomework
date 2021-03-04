using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2._2
{
    class Program
    {
        static int maxNum(int[] a,int count)
        {
            int max = int.MinValue;
            for(int i = 0; i < count; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }

        static int minNum(int[]a,int count)
        {
            int min = int.MaxValue;
            for (int i = 0; i < count; i++)
            {
                if (a[i] <min)
                {
                    min = a[i];
                }
            }
            return min;
        }
        static int arraySum(int[]a,int count)
        {
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += a[i];
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
            }
            Console.WriteLine($"The max value of the array is:{ maxNum(a,100)}");
            Console.WriteLine($"The min value of the array is:{ minNum(a, 100)}");
            Console.WriteLine($"The average value of the array is:{ arrayAvg(a, 100)}");
            Console.WriteLine($"The sum of the array is:{ arraySum(a, 100)}");
        }
    }
}
