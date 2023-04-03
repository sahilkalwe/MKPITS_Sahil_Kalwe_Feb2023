using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53_check_whether_number_is_prime_or_not_by_using_method_and_parameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=3;
            Console.WriteLine("Enter a positive number: ");
            num = Convert.ToInt32(Console.ReadLine());
            int counter=2;
            int isprime = 0;
          
                for (counter = 2; counter < num; counter++)
                {
                    if (num % counter == 0)
                    {
                    isprime = 1;
                        break;
                    }
                }

                if (isprime ==0)
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
