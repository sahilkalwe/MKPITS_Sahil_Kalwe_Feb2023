using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_wap_to_accept_a_no___print_factorial_of__no_using_while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int fact = 1;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            while (num>0) 
            {
                fact = fact * num;
                num = num - 1;
            }
            Console.WriteLine("fact = " + fact);
            Console.ReadKey();
        }
    }
}
