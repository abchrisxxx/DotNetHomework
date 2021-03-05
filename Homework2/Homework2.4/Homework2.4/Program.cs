using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    class Program
    {
        static bool Fun(int[,] a,int row,int col)
        {
            int flag;
            bool result = true;
            for(int i = 0; i <= col - row;i++)
            {
                flag = a[0,i];//基准值
                for(int j = 1; j < row; j++)
                {
                    if (a[j,i+j] != flag)
                    {
                        result = false;
                    }
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3, 4 }, { 5, 1, 2, 3 }, { 9, 5, 1, 2 } };//用这个数组为例
            Console.WriteLine(Fun(a, 3, 4));
        }
    }
}
