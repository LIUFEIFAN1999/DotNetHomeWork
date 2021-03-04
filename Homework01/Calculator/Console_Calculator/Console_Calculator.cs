using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Calculator
{
    class Console_Calculator
    {
        static void Main(string[] args)
        {
            double op1, op2, result;
            string op;
            bool again = false;
            do
            {
                try
                {
                    Console.Write("请输入第一个操作数：");
                    op1 = Double.Parse(Console.ReadLine());
                    Console.Write("请输入第二个操作数：");
                    op2 = Double.Parse(Console.ReadLine());
                    Console.Write("请输入运算符：");
                    op = Console.ReadLine();
                    switch (op)
                    {
                        case "+": result = op1 + op2; Console.WriteLine("{0}+{1}={2}", op1, op2, result); break;
                        case "-": result = op1 - op2; Console.WriteLine("{0}-{1}={2}", op1, op2, result); break;
                        case "*": result = op1 * op2; Console.WriteLine("{0}*{1}={2}", op1, op2, result); break;
                        case "/": result = op1 / op2; Console.WriteLine("{0}/{1}={2}", op1, op2, result); break;
                        default: Console.WriteLine("运算符输入有误！"); break;
                    }
                    Console.Write("是否继续运算（true/false）：");
                    again = Boolean.Parse(Console.ReadLine());
                }
                catch (System.FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (again);
        }
    }
}
