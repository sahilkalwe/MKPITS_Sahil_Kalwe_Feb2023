using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace _60_goto_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result = 0; char op;
            Console.WriteLine("Enter  num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter  num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Operator +,-,*");
            op = Convert.ToChar(Console.ReadLine());
            if (op == '+')
            {
                goto addition;
            }
            else if (op == '-')
            {
                goto substraction;
            }
            else if (op == '*')
            {
                goto multiplication;
            }
            else
            {
                goto end;
            }
        addition:
            result = num1 + num2;
            goto end;
        substraction:
            result = num1 - num2;
            goto end;
        multiplication:
            result = num1 * num2;
            goto end;
        end:
            Console.WriteLine("Result is " + result);
            Console.ReadKey();
        }
    }
}
