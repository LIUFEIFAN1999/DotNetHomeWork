using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime03
{
    class prime03
    {
        static bool IsPrime(int num)
        {
            bool flag = true;
            for (int factor = 2; factor*factor <= num; factor++)
            {
                if (num % factor == 0)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
        static void Main(string[] args)
        {
            Console.Write("2-100以内的素数为：");
            for(int num= 2; num<=100; num++)
            {
                if (IsPrime(num))
                {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
