using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_accept_twon_numbers_and_print_greater_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter number 1");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            b=Convert.ToInt32(Console.ReadLine());  
            if (a>b) 
            {
                Console.WriteLine("Number 1 is greater");
            }
            else
            { Console.WriteLine("Number 2 is greater");
            }
            Console.ReadKey();


        }
    }
}
