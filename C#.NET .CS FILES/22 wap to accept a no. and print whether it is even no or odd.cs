using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_wap_to_accept_a_no.and_print_whether_it_is_even_no_or_odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter number");
            num=Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 0)
                {
                Console.WriteLine("Number is Even  Number");
                }
            else
            {
                Console.WriteLine("Number is odd number");
               
            }
            Console.ReadKey();
        }
    }
}
