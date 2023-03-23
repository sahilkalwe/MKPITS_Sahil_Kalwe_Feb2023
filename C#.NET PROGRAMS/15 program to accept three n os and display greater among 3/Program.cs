using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_program_to_accept_three_n_os_and_display_greater_among_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int a, b, c;
            Console.WriteLine("enter Number 1");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 3");
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("num 1 is greater");
                    }
            else if (b > c)
            {
                Console.WriteLine("num 2 is Greater");
            }
            else
                    {
                Console.WriteLine("Num 3 is greater");

            }
            Console.ReadKey();

        }
    }
}
