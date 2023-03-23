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
            bool isprime;
            for (int num = 1; num <= 20; num++)
            {
                 isprime = true;
                for (int counter = 2; counter < num; counter++)
                {
                    if (num % counter == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if(isprime =1 && num > 1)
                {
                    Console.WriteLine(num + "<br>");
                }
            }

         
        }
    }
}
