using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43.prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int counter = 2;
            int isprime = 0;

            for (counter = 2; counter < num; counter++)
            {
                if (num % counter == 0)
                {
                    isprime = 1;
                    break;
                }
            }

            if (isprime == 0)
            {
                Console.WriteLine("It is a prime number");
            }
            else
            {
                Console.WriteLine("It is a not prime number");
            }
            Console.ReadKey();
        }
    }
}
