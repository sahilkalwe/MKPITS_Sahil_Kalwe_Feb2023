using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_accept_name_from_user_and_print_it
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name;
            Console.WriteLine("Enter Your Name");
            name = Console.ReadLine();
            Console.WriteLine("Your Nmae Is " + name);
            Console.ReadKey();
        }
    }
}
