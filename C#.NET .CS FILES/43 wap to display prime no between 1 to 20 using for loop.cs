using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_wap_to_display_prime_no_between_1_to_20_using_for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int outercounter = 1; outercounter <= 20; outercounter++)
            {
                int num = outercounter;
                int isprime = 0;

                for (int counter = 2; counter < num; counter++)
                {
                    if (num % counter == 0)
                    {
                        isprime = 1;
                        break;
                    }
                }

                if (isprime == 0)
                {
                    Console.WriteLine(num + " It is a prime number");
                }
                
            }
            Console.ReadKey();
        }
       
    }
}

