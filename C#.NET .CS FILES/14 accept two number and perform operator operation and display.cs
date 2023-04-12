using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_accept_two_number_and_perform_operator_operation_and_display
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            char op;
            int res=0;
            Console.WriteLine("Enter  number 1");
            n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteL0ine("Enter number 2");
            n2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Operator +,_,*");
            op = Convert.ToChar(Console.ReadLine());
            if (op == '+')
                res = n1 + n2;
            else if (op == '-')
                res = n1 - n2;
            else if (op == '*')
                res = n1 * n2;
            else
                Console.WriteLine("Invalid Operator");
            Console.WriteLine("Result is " + res);
            Console.ReadKey();


        }
    }
}
