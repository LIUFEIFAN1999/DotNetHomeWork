using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matrix
    {
        bool isToeplitz(int[,] matrix)
        {
            int i , j;
            //每一行最后一个数字不用比较，最后一行不用比较
            for(i = 0; i < matrix.GetLength(0)-1; i++)
            {
                for(j = 0; j < matrix.GetLength(1)-1; j++)
                {
                    //数字与右下角数字不相等返回false
                    if (matrix[i, j] != matrix[i + 1, j + 1])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Matrix matrixdemo = new Matrix();
            int[,] matrix = { {1,2,3,4}, { 5,1,2,3}, { 9,5,1,2} };
            Console.WriteLine(matrixdemo.isToeplitz(matrix));
        }
    }
}
