using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45_program_to_accept_a_value_unless_user_enters_0_value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b = 0;
            do
            {
                Console.WriteLine("enter value");
                string c = Console.ReadLine();
                a = int.Parse(c);
            }
            while (a != b);
            Console.WriteLine("Its Over");
            Console.ReadKey();
        }
    }
}
