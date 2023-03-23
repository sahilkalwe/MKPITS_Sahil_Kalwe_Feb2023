using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_wap_to_accept_3_noos_and_display_smallest_amog_them
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("enter Number 1");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 3");
            c = Convert.ToInt32(Console.ReadLine());
            if (a < b)
            {
                Console.WriteLine("num 1 is smallest");
            }
            else if (b < c)
            {
                Console.WriteLine("num 2 is smallest");
            }
            else
            {
                Console.WriteLine("Num 3 is smallest");

            }
            Console.ReadKey();


        }
    }
}
