using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_wap_to_print_numbers_between_5_to_25_using_do_while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            do
            {
                Console.WriteLine(num);
                num++;
            } while (num <= 25);
            Console.ReadKey();
        }
    }
}
