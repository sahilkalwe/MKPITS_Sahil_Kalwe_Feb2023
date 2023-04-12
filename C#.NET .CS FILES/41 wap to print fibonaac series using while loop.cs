using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_wap_to_print_fibonaac_series_using_while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i=0, c;
            int a = 0;
            int b = 1;
            Console.WriteLine("Enter number");
            n = Convert.ToInt32(Console.ReadLine());
            while (i < n)
            {
                if (i <= 1)
                    c = i;
                else
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                i++;
                Console.Write(c + " ");
            }
            Console.ReadKey();
        }
    }
}
