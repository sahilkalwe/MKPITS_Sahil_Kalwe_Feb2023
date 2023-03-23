using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_wap_to_accept_number_and_print_factorial_of_that__number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int fact = 1;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = num; i > 0; i--)
            {
                fact = fact * i;

            }
            Console.WriteLine("fact = " + fact);
            Console.ReadKey();

        }
    }
}
