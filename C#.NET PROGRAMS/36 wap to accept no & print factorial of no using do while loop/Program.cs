using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_wap_to_accept_no___print_factorial_of_no_using_do_while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int fact = 1;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            do
            {
                fact = fact * num;
                num = num - 1;
            } while (num > 0);
                Console.WriteLine("fact = " + fact);
            Console.ReadKey();
        }
    }
}
