using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOperation
{
    class ArrayOperation
    {
        int MaxiumValue(int[] array)
        {
            int max=array[0],idx;
            for(idx=1; idx<array.Length; idx++)
            {
                if (array[idx] > max)
                    max = array[idx];
            }
            return max;
        }

        int MiniumValue(int[] array)
        {
            int min = array[0], idx;
            for (idx = 1; idx < array.Length; idx++)
            {
                if (array[idx] < min)
                    min = array[idx];
            }
            return min;
        }

        double ArgValue(int[] array)
        {
            int sum = Sum(array);
            double arg = sum/array.Length;
            return arg;
        }

        int Sum(int[] array)
        {
            int idx, sum = 0;
            for (idx = 0; idx < array.Length; idx++)
            {
                sum += array[idx];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            ArrayOperation array1 = new ArrayOperation();
            int[] array = { 1,2,3,4,5,6,7,8,9,10};
            Console.WriteLine(array1.MaxiumValue(array));
            Console.WriteLine(array1.MiniumValue(array));
            Console.WriteLine(array1.Sum(array));
            Console.WriteLine(array1.ArgValue(array));
        }
    }
}
