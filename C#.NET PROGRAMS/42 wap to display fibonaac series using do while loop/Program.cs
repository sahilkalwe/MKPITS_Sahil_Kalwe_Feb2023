using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_wap_to_display_fibonaac_series_using_do_while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i = 0, c;
            int a = 0;
            int b = 1;
            Console.WriteLine("Enter number");
            n = Convert.ToInt32(Console.ReadLine());
            do
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
            } while (i < n);
            Console.ReadKey();
        }
    }
}
