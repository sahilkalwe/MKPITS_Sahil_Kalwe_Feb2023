using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace _23__wap_to_accept_two_number_and_display_operation_perform_on_it
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            char op;
            int res = 0;
            Console.WriteLine("Enter Num 1");
            n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Num 2");
            n2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Operation To be performed => +,-,*,/,% etc");
            op=Convert.ToChar(Console.ReadLine());
            switch (op)
            {
                case '+':
                    res = n1 + n2;
                    break;
                case '-':
                    res = n1 - n2;
                    break;
                case '*':
                    res = n1 * n2;
                    break;
                case '/':
                    res = n1 / n2;
                    break;
                case '%':
                    res = n1 % n2;
                    break;
                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }
                    Console.WriteLine("Reasult= "+res);
            Console.ReadKey();
                
        }
    }
}
