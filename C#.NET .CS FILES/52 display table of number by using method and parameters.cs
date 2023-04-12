using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52_display_trable_of_number_by_using_method_and_parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1,i=1;
            
            Console.WriteLine("enter number");
            n1 = Convert.ToInt32(Console.ReadLine());
            int re = square(n1);
            Console.WriteLine("{0} * {1} = {2}", n1, i, re);
            Console.ReadKey();
        }
            static int square(int num)
            {
            int i = 1;
            int res = 1;
            while (i <= 10)
                {
                    res = num * i;
                    i++;
                
            }
            return num;
        }
    }
}
