using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_addition_of_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, sum;
            Console.WriteLine("Enter first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number");
            c = Convert.ToInt32(Console.ReadLine());
            sum = a + b+ c;
            Console.WriteLine("Addition is " + sum);
            Console.ReadKey();
        }
    }
}
