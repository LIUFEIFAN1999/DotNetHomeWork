using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFatorOfaNumber
{
    class PrimeFatorOfaNumber
    {
        //判断该数字是不是素数
        static bool IsPrime(int num)
        {
            bool flag=true;
            for(int factor=2; factor*factor <= num; factor++)
            {
                if(num % factor == 0)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        static void PrimeFactor(int num, List<int> factors)
        {
            for(int factor = 2; factor <= num; factor++)
            {
                if((num % factor == 0) && IsPrime(factor))
                {
                    factors.Add(factor);
                }
            }
        }


        static void Main(string[] args)
        {
            int num;
            List<int> factors = new List<int>();
            Console.Write("请输入一个正整数：");
            num = int.Parse(Console.ReadLine());
            PrimeFactor(num, factors);
            if(factors.Count == 0)
            {
                Console.WriteLine("该数据不存在素数因子。");
            }
            else
            {
                Console.Write("该数据的素数因子：");
                foreach (var number in factors)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
