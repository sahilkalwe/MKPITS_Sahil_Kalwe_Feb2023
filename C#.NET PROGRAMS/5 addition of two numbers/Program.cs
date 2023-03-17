using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_addition_of_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b,c;
            Console.WriteLine("Enter first number");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("Addition is "+c);
            Console.ReadKey();

        }
    }
}
