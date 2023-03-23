using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40__wap_to_print_fibonaac_series_using_for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int n,i,c;
                int a = 0;
                int b = 1;
            Console.WriteLine("Enter number");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                if (i <= 1)
                    c = i;
                else
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                Console.Write(c + " ");
            }
            Console.ReadKey();
        }
    }
}
