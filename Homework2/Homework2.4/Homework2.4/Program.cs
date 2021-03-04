using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2._4
{
    class Program
    {
        static bool fun(int[,] a,int row,int col)
        {
            int flag;
            bool result = true;
            for(int i = 0; i <= col - row;i++)
            {
                flag = a[0,i];
                for(int j = 0; j < row; j++)
                {
                    if (a[j,i] != flag)
                    {
                        result = false;
                    }
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3, 4 }, { 5, 1, 2, 3 }, { 9, 5, 1, 2 } };
            Console.WriteLine(fun(a, 3, 4));
        }
    }
}
