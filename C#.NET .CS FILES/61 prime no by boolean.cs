using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61_prime_no_by_boolean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int counter = 2;
            bool isprime = true; ;


            for (counter = 2; counter < num; counter++)
            {
                if (num % counter == 0)
                {
                    isprime = false;
                    break;
                }
            }

            if (isprime == true)
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
