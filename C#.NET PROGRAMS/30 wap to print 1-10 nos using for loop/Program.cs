using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_wap_to_print_1_10_nos_using_for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1, j = 1; i <= 10; i++, j++)
            {
                Console.WriteLine("i= " + i);
                Console.WriteLine("j= " + j);

            }
            Console.ReadKey();
        }
    }
}
